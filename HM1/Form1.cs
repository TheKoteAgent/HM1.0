using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HM1
{
    public partial class Form1 : Form
    {

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.TextBox addressBox;
        private ListBox folderContentList;

        private string currentFilePath = "";
        public Form1()
        {
            InitializeComponent();
            InitializeEditor();
            InitializeExplorer();
        }

        private void InitializeExplorer()
        {
            // Налаштування MenuStrip
            var menuStrip = new MenuStrip();
            var fileMenu = new ToolStripMenuItem("Файл");
            fileMenu.DropDownItems.Add("Вийти", null, (s, e) => Close());
            menuStrip.Items.Add(fileMenu);
            Controls.Add(menuStrip);

            // Налаштування рядка адреси
            addressBox = new System.Windows.Forms.TextBox
            {
                Dock = DockStyle.Top,
                ReadOnly = true
            };
            Controls.Add(addressBox);

            // Налаштування TreeView для дерева дисків
            treeView = new System.Windows.Forms.TreeView
            {
                Dock = DockStyle.Left,
                Width = 200
            };
            treeView.AfterSelect += TreeView_AfterSelect;
            LoadDrives();
            Controls.Add(treeView);

            // Налаштування ListBox для вмісту папки
            folderContentList = new ListBox
            {
                Dock = DockStyle.Fill
            };
            Controls.Add(folderContentList);
        }
        private void LoadDrives()
        {
            treeView.Nodes.Clear();
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    var driveNode = new TreeNode(drive.Name)
                    {
                        Tag = drive.RootDirectory.FullName
                    };
                    treeView.Nodes.Add(driveNode);
                    LoadDirectories(driveNode);
                }
            }
        }

        private void LoadDirectories(TreeNode node)
        {
            try
            {
                var path = node.Tag.ToString();
                var directories = Directory.GetDirectories(path);
                foreach (var directory in directories)
                {
                    var dirInfo = new DirectoryInfo(directory);
                    var dirNode = new TreeNode(dirInfo.Name)
                    {
                        Tag = dirInfo.FullName
                    };
                    node.Nodes.Add(dirNode);
                }
            }
            catch { /* Ігноруємо недоступні папки */ }
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedPath = e.Node.Tag.ToString();
            addressBox.Text = selectedPath;
            LoadFolderContents(selectedPath);
        }
        private void LoadFolderContents(string path)
        {
            folderContentList.Items.Clear();
            try
            {
                var directories = Directory.GetDirectories(path);
                var files = Directory.GetFiles(path);
                foreach (var directory in directories)
                    folderContentList.Items.Add(new DirectoryInfo(directory).Name);
                foreach (var file in files)
                    folderContentList.Items.Add(new FileInfo(file).Name);
            }
            catch
            {
                folderContentList.Items.Add("Неможливо завантажити вміст папки.");
            }
        }

        private void InitializeEditor()
        {
            var textBox = new System.Windows.Forms.TextBox
            {
                Multiline = true,
                Dock = DockStyle.Fill,
                ScrollBars = ScrollBars.Vertical,
                ContextMenuStrip = CreateContextMenu()
            };
            Controls.Add(TextBox);

            // Налаштування меню
            var menuStrip = new MenuStrip();
            var fileMenu = new ToolStripMenuItem("Файл");
            var editMenu = new ToolStripMenuItem("Редагувати");
            var settingsMenu = new ToolStripMenuItem("Налаштування");

            fileMenu.DropDownItems.Add("Новий", null, NewFile_Click);
            fileMenu.DropDownItems.Add("Відкрити", null, OpenFile_Click);
            fileMenu.DropDownItems.Add("Зберегти", null, SaveFile_Click);
            fileMenu.DropDownItems.Add("Зберегти як", null, SaveFileAs_Click);
            fileMenu.DropDownItems.Add("Вихід", null, (s, e) => Close());

            editMenu.DropDownItems.Add("Копіювати", null, (s, e) => TextBox.Copy());
            editMenu.DropDownItems.Add("Вирізати", null, (s, e) => TextBox.Cut());
            editMenu.DropDownItems.Add("Вставити", null, (s, e) => TextBox.Paste());
            editMenu.DropDownItems.Add("Скасувати", null, (s, e) => TextBox.Undo());
            editMenu.DropDownItems.Add("Виділити все", null, (s, e) => TextBox.SelectAll());

            settingsMenu.Click += SettingsMenu_Click;

            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenu, editMenu });
            MainMenuStrip = menuStrip;
            Controls.Add(menuStrip);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\Serek\\source\\repos\\HM1\\HM1\\textfile.txt";
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    long totalLength = reader.BaseStream.Length;
                    long currentLength = 0;
                    progressBar.Minimum = 0;
                    progressBar.Maximum = (int)totalLength;

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        currentLength += line.Length;

                        // Оновлення прогресу
                        progressBar.Value = (int)currentLength;
                        lblTextCount.Text = $"Прочитано символів: {currentLength}";
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл не знайдено!");
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string userInfo = $"{name} {surname}, {email}, {phone}";
            LB1.Items.Add(userInfo);
            txtName.Clear();
            txtSurname.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }

        private void LB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LB1.SelectedIndex == -1) return;
            string selectedUser = LB1.SelectedItem.ToString();
            string[] userDetails = selectedUser.Split(',');
            txtName.Text = userDetails[0].Split(' ')[0].Trim();
            txtSurname.Text = userDetails[0].Split(' ')[1].Trim();
            txtEmail.Text = userDetails[1].Trim();
            txtPhone.Text = userDetails[2].Trim();
            LB1.Items.RemoveAt(LB1.SelectedIndex);
        }

        private void export_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("C:\\Users\\Serek\\source\\repos\\HM1\\HM1\\users.txt"))
            {
                foreach (var item in LB1.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }
            MessageBox.Show("Дані експортовано до файлу users.txt");
        }

        private void Import_Click(object sender, EventArgs e)
        {
            LB1.Items.Clear();
            if (File.Exists("C:\\Users\\Serek\\source\\repos\\HM1\\HM1\\users.txt"))
            {
                using (StreamReader reader = new StreamReader("C:\\Users\\Serek\\source\\repos\\HM1\\HM1\\users.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        LB1.Items.Add(line);
                    }
                }
                MessageBox.Show("Дані імпортовано з файлу users.txt");
            }
            else
            {
                MessageBox.Show("Файл users.txt не знайдено!");
            }
        }

        private void LB1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && LB1.SelectedIndex != -1)
            {
                LB1.Items.RemoveAt(LB1.SelectedIndex);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "Text Files|*.txt|All Files|*.*" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;
                string text = File.ReadAllText(currentFilePath);
                var textBox = Controls.OfType<System.Windows.Forms.TextBox>().FirstOrDefault();
                if (textBox != null)
                {
                    textBox.Text = text;
                }
                UpdateWindowTitle();
            }
        }


        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileAs_Click(sender, e);
            }
            else
            {
                var textBox = Controls.OfType<System.Windows.Forms.TextBox>().FirstOrDefault();
                if (textBox != null)
                {
                    File.WriteAllText(currentFilePath, textBox.Text);
                }
            }
        }

        private void SaveFileAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = "Text Files|*.txt|All Files|*.*" };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = saveFileDialog.FileName;
                var textBox = Controls.OfType<System.Windows.Forms.TextBox>().FirstOrDefault();
                if (textBox != null)
                {
                    File.WriteAllText(currentFilePath, textBox.Text);
                }
                UpdateWindowTitle();
            }
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            var textBox = Controls.OfType<System.Windows.Forms.TextBox>().FirstOrDefault();
            if (textBox != null)
            {
                textBox.Clear();
                currentFilePath = "";
                UpdateWindowTitle();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private ContextMenuStrip CreateContextMenu()
        {
            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Копіювати", null, (s, e) => TextBox.Copy());
            contextMenu.Items.Add("Вирізати", null, (s, e) => TextBox.Cut());
            contextMenu.Items.Add("Вставити", null, (s, e) => TextBox.Paste());
            contextMenu.Items.Add("Скасувати", null, (s, e) => TextBox.Undo());
            return contextMenu;
        }
        private void UpdateWindowTitle()
        {
            Text = string.IsNullOrEmpty(currentFilePath) ? "Новий документ - Текстовий редактор" : $"{currentFilePath} - Текстовий редактор";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void налаштуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.Font = TextBox.Font;
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    TextBox.Font = fontDialog.Font;
                }
            }
        }
        private void SettingsMenu_Click(object sender, EventArgs e)
        {
            // Діалог для вибору шрифту
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.Font = editorTextBox.Font;
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    editorTextBox.Font = fontDialog.Font;
                }
            }

            // Діалог для вибору кольору шрифту
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = editorTextBox.ForeColor;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    editorTextBox.ForeColor = colorDialog.Color;
                }
            }

            // Діалог для вибору кольору фону
            using (ColorDialog backgroundColorDialog = new ColorDialog())
            {
                backgroundColorDialog.Color = editorTextBox.BackColor;
                if (backgroundColorDialog.ShowDialog() == DialogResult.OK)
                {
                    editorTextBox.BackColor = backgroundColorDialog.Color;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BM_Click(object sender, EventArgs e)
        {
            string menuName = TopLevelMenu.Text.Trim();
            ToolStripMenuItem topLevelItem = new ToolStripMenuItem(menuName);
            Strip1.Items.Add(topLevelItem);
            TopLevelMenu.Clear();
        }

        private void BS_Click(object sender, EventArgs e)
        {
            string subItemName = SubItem.Text.Trim();
            ToolStripMenuItem selectedItem = Strip1.Items[Strip1.Items.Count - 1] as ToolStripMenuItem;
            ToolStripMenuItem subItem = new ToolStripMenuItem(subItemName);
            selectedItem.DropDownItems.Add(subItem);
            SubItem.Clear();
        }
    }
}
