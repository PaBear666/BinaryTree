namespace LabThree
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AboutAuthor = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Programm = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ControlPanel = new System.Windows.Forms.GroupBox();
            this.RemoveList = new System.Windows.Forms.Button();
            this.AddTask = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Task = new System.Windows.Forms.ToolStripMenuItem();
            this.Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.TabPage();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TextCheckTree = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.tabControl1.SuspendLayout();
            this.AboutAuthor.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Programm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.Exit.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(959, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AboutAuthor);
            this.tabControl1.Controls.Add(this.Programm);
            this.tabControl1.Controls.Add(this.Exit);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(422, 447);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // AboutAuthor
            // 
            this.AboutAuthor.Controls.Add(this.groupBox4);
            this.AboutAuthor.Controls.Add(this.groupBox3);
            this.AboutAuthor.Controls.Add(this.groupBox2);
            this.AboutAuthor.Location = new System.Drawing.Point(4, 22);
            this.AboutAuthor.Name = "AboutAuthor";
            this.AboutAuthor.Padding = new System.Windows.Forms.Padding(3);
            this.AboutAuthor.Size = new System.Drawing.Size(414, 421);
            this.AboutAuthor.TabIndex = 0;
            this.AboutAuthor.Text = "Об программе";
            this.AboutAuthor.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(26, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 84);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Кто выполнил";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Лабораторная работа номер 3";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(26, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 84);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Задание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Создать дерево поиска. \r\nСкопировать в линейный список узлы дерева, \r\nвыбранные п" +
    "о заданным значениям ключей.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(26, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 84);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кто выполнил";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Бурмистров Никита Александрович 6103";
            // 
            // Programm
            // 
            this.Programm.Controls.Add(this.groupBox1);
            this.Programm.Controls.Add(this.ControlPanel);
            this.Programm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Programm.Location = new System.Drawing.Point(4, 22);
            this.Programm.Name = "Programm";
            this.Programm.Padding = new System.Windows.Forms.Padding(3);
            this.Programm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Programm.Size = new System.Drawing.Size(414, 421);
            this.Programm.TabIndex = 1;
            this.Programm.Text = "Обработка";
            this.Programm.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список по ключам";
            // 
            // listBox1
            // 
            this.listBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(397, 212);
            this.listBox1.TabIndex = 0;
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.RemoveList);
            this.ControlPanel.Controls.Add(this.AddTask);
            this.ControlPanel.Controls.Add(this.label3);
            this.ControlPanel.Controls.Add(this.label2);
            this.ControlPanel.Controls.Add(this.label1);
            this.ControlPanel.Controls.Add(this.textBox2);
            this.ControlPanel.Controls.Add(this.textBox1);
            this.ControlPanel.Controls.Add(this.Clear);
            this.ControlPanel.Controls.Add(this.Add);
            this.ControlPanel.Controls.Add(this.menuStrip2);
            this.ControlPanel.Location = new System.Drawing.Point(3, 247);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(403, 170);
            this.ControlPanel.TabIndex = 0;
            this.ControlPanel.TabStop = false;
            this.ControlPanel.Text = "Панель управления";
            // 
            // RemoveList
            // 
            this.RemoveList.Location = new System.Drawing.Point(61, 109);
            this.RemoveList.Name = "RemoveList";
            this.RemoveList.Size = new System.Drawing.Size(79, 23);
            this.RemoveList.TabIndex = 2;
            this.RemoveList.Text = "Remove";
            this.RemoveList.UseVisualStyleBackColor = true;
            this.RemoveList.Visible = false;
            this.RemoveList.Click += new System.EventHandler(this.RemoveList_Click);
            // 
            // AddTask
            // 
            this.AddTask.Enabled = false;
            this.AddTask.Location = new System.Drawing.Point(44, 140);
            this.AddTask.Name = "AddTask";
            this.AddTask.Size = new System.Drawing.Size(121, 22);
            this.AddTask.TabIndex = 9;
            this.AddTask.Text = "Добавить";
            this.AddTask.UseVisualStyleBackColor = true;
            this.AddTask.Visible = false;
            this.AddTask.Click += new System.EventHandler(this.AddTask_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Добавление элемента по ключу в список";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Информационное поле";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ключ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(221, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(221, 140);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(117, 22);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add
            // 
            this.Add.Enabled = false;
            this.Add.Location = new System.Drawing.Point(44, 140);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(121, 22);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.Task,
            this.Remove});
            this.menuStrip2.Location = new System.Drawing.Point(3, 16);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(397, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 20);
            this.toolStripMenuItem1.Text = "Добавить элемент";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Task
            // 
            this.Task.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(146, 20);
            this.Task.Text = "Обработка по Заданию";
            this.Task.Click += new System.EventHandler(this.Task_Click);
            // 
            // Remove
            // 
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(120, 20);
            this.Remove.Text = "Разрушить дерево";
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Exit
            // 
            this.Exit.Controls.Add(this.ExitButton);
            this.Exit.Location = new System.Drawing.Point(4, 22);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(414, 421);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.SeaShell;
            this.ExitButton.Font = new System.Drawing.Font("Oswald Stencil", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExitButton.Location = new System.Drawing.Point(96, 175);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(194, 58);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Выйти из программы";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // TextCheckTree
            // 
            this.TextCheckTree.AutoSize = true;
            this.TextCheckTree.Cursor = System.Windows.Forms.Cursors.No;
            this.TextCheckTree.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextCheckTree.Location = new System.Drawing.Point(587, 197);
            this.TextCheckTree.Name = "TextCheckTree";
            this.TextCheckTree.Size = new System.Drawing.Size(224, 39);
            this.TextCheckTree.TabIndex = 2;
            this.TextCheckTree.Text = "Дерево пусто";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(942, 24);
            this.vScrollBar1.Maximum = 10;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 407);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.Value = 5;
            this.vScrollBar1.Visible = false;
            this.vScrollBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.vScrollBar1_ValueChanged);
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(421, 430);
            this.hScrollBar1.Maximum = 10;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(521, 17);
            this.hScrollBar1.TabIndex = 3;
            this.hScrollBar1.Value = 5;
            this.hScrollBar1.Visible = false;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(959, 446);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.TextCheckTree);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Лабораторная работа 3";
            this.tabControl1.ResumeLayout(false);
            this.AboutAuthor.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Programm.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.Exit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AboutAuthor;
        private System.Windows.Forms.TabPage Programm;
        private System.Windows.Forms.TabPage Exit;
        private System.Windows.Forms.GroupBox ControlPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem Task;
        private System.Windows.Forms.ToolStripMenuItem Remove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label TextCheckTree;
        private System.Windows.Forms.Button AddTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RemoveList;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ExitButton;
    }
}

