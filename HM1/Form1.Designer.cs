namespace HM1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.B1 = new System.Windows.Forms.Button();
            this.lblTextCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB1 = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.Import = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копіюватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вирізатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скасуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.editorTextBox = new System.Windows.Forms.TextBox();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LB2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TopLevelMenu = new System.Windows.Forms.TextBox();
            this.SubItem = new System.Windows.Forms.TextBox();
            this.BM = new System.Windows.Forms.Button();
            this.BS = new System.Windows.Forms.Button();
            this.Strip1 = new System.Windows.Forms.MenuStrip();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(634, 291);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(53, 23);
            this.progressBar.TabIndex = 0;
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(634, 330);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 23);
            this.B1.TabIndex = 1;
            this.B1.Text = "Проскануй";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTextCount
            // 
            this.lblTextCount.AutoSize = true;
            this.lblTextCount.Location = new System.Drawing.Point(715, 301);
            this.lblTextCount.Name = "lblTextCount";
            this.lblTextCount.Size = new System.Drawing.Size(0, 13);
            this.lblTextCount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "1";
            // 
            // LB1
            // 
            this.LB1.FormattingEnabled = true;
            this.LB1.Location = new System.Drawing.Point(592, 396);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(120, 95);
            this.LB1.TabIndex = 4;
            this.LB1.TabStop = false;
            this.LB1.SelectedIndexChanged += new System.EventHandler(this.LB1_SelectedIndexChanged);
            this.LB1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LB1_KeyDown);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(472, 509);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 5;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.b2_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(460, 392);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(460, 418);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txtEmail.Location = new System.Drawing.Point(460, 444);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(460, 471);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 9;
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(634, 509);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(75, 23);
            this.Import.TabIndex = 10;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(553, 509);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(75, 23);
            this.export.TabIndex = 11;
            this.export.Text = "export";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "2";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копіюватиToolStripMenuItem,
            this.вирізатиToolStripMenuItem,
            this.вставитиToolStripMenuItem,
            this.скасуватиToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(133, 92);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // копіюватиToolStripMenuItem
            // 
            this.копіюватиToolStripMenuItem.Name = "копіюватиToolStripMenuItem";
            this.копіюватиToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.копіюватиToolStripMenuItem.Text = "Копіювати";
            // 
            // вирізатиToolStripMenuItem
            // 
            this.вирізатиToolStripMenuItem.Name = "вирізатиToolStripMenuItem";
            this.вирізатиToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.вирізатиToolStripMenuItem.Text = "Вирізати";
            // 
            // вставитиToolStripMenuItem
            // 
            this.вставитиToolStripMenuItem.Name = "вставитиToolStripMenuItem";
            this.вставитиToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.вставитиToolStripMenuItem.Text = "Вставити";
            // 
            // скасуватиToolStripMenuItem
            // 
            this.скасуватиToolStripMenuItem.Name = "скасуватиToolStripMenuItem";
            this.скасуватиToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.скасуватиToolStripMenuItem.Text = "Скасувати";
            // 
            // TextBox
            // 
            this.TextBox.ContextMenuStrip = this.contextMenuStrip;
            this.TextBox.Location = new System.Drawing.Point(197, 147);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox.Size = new System.Drawing.Size(181, 137);
            this.TextBox.TabIndex = 17;
            this.TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // editorTextBox
            // 
            this.editorTextBox.Location = new System.Drawing.Point(384, 200);
            this.editorTextBox.Name = "editorTextBox";
            this.editorTextBox.Size = new System.Drawing.Size(100, 20);
            this.editorTextBox.TabIndex = 18;
            // 
            // налаштуванняToolStripMenuItem
            // 
            this.налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            this.налаштуванняToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.налаштуванняToolStripMenuItem.Text = "Налаштування";
            this.налаштуванняToolStripMenuItem.Click += new System.EventHandler(this.налаштуванняToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.налаштуванняToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1389, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1389, 24);
            this.menuStrip2.TabIndex = 20;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(516, 51);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(643, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            // 
            // LB2
            // 
            this.LB2.FormattingEnabled = true;
            this.LB2.Location = new System.Drawing.Point(749, 56);
            this.LB2.Name = "LB2";
            this.LB2.Size = new System.Drawing.Size(120, 95);
            this.LB2.TabIndex = 23;
            this.LB2.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "4";
            // 
            // TopLevelMenu
            // 
            this.TopLevelMenu.Location = new System.Drawing.Point(1028, 330);
            this.TopLevelMenu.Name = "TopLevelMenu";
            this.TopLevelMenu.Size = new System.Drawing.Size(100, 20);
            this.TopLevelMenu.TabIndex = 25;
            // 
            // SubItem
            // 
            this.SubItem.Location = new System.Drawing.Point(1149, 330);
            this.SubItem.Name = "SubItem";
            this.SubItem.Size = new System.Drawing.Size(100, 20);
            this.SubItem.TabIndex = 26;
            // 
            // BM
            // 
            this.BM.Location = new System.Drawing.Point(1028, 366);
            this.BM.Name = "BM";
            this.BM.Size = new System.Drawing.Size(100, 42);
            this.BM.TabIndex = 27;
            this.BM.Text = "Додати пункт меню";
            this.BM.UseVisualStyleBackColor = true;
            this.BM.Click += new System.EventHandler(this.BM_Click);
            // 
            // BS
            // 
            this.BS.Location = new System.Drawing.Point(1149, 366);
            this.BS.Name = "BS";
            this.BS.Size = new System.Drawing.Size(98, 23);
            this.BS.TabIndex = 28;
            this.BS.Text = "Додати підменю";
            this.BS.UseVisualStyleBackColor = true;
            this.BS.Click += new System.EventHandler(this.BS_Click);
            // 
            // Strip1
            // 
            this.Strip1.Location = new System.Drawing.Point(0, 0);
            this.Strip1.Name = "Strip1";
            this.Strip1.Size = new System.Drawing.Size(1389, 24);
            this.Strip1.TabIndex = 29;
            this.Strip1.Text = "Strip1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(987, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 574);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BS);
            this.Controls.Add(this.BM);
            this.Controls.Add(this.SubItem);
            this.Controls.Add(this.TopLevelMenu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LB2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editorTextBox);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.export);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.add);
            this.Controls.Add(this.LB1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTextCount);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.Strip1);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.Text = "вц";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Label lblTextCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LB1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem копіюватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вирізатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скасуватиToolStripMenuItem;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.TextBox editorTextBox;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox LB2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TopLevelMenu;
        private System.Windows.Forms.TextBox SubItem;
        private System.Windows.Forms.Button BM;
        private System.Windows.Forms.Button BS;
        private System.Windows.Forms.MenuStrip Strip1;
        private System.Windows.Forms.Label label5;
    }
}

