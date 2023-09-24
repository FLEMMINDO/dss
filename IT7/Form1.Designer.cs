namespace IT7
{
    partial class ExpertSystemForm
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удтверждениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стартToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tapPropositions = new System.Windows.Forms.TabPage();
            this.propositionsGrid = new System.Windows.Forms.DataGridView();
            this.tabOutcome = new System.Windows.Forms.TabPage();
            this.Outcome10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Outcome9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Outcome8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Outcome7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Outcome6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Outcome5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Outcome4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Outcome3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Outcome2 = new System.Windows.Forms.TextBox();
            this.Outcome1 = new System.Windows.Forms.TextBox();
            this.Proposition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tapPropositions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propositionsGrid)).BeginInit();
            this.tabOutcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.удтверждениеToolStripMenuItem,
            this.проверкаToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(288, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.openMenu_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.saveMenu_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.saveAsMenu_Click);
            // 
            // удтверждениеToolStripMenuItem
            // 
            this.удтверждениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.удтверждениеToolStripMenuItem.Name = "удтверждениеToolStripMenuItem";
            this.удтверждениеToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.удтверждениеToolStripMenuItem.Text = "Утверждения";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.addMenu_Click);
            // 
            // проверкаToolStripMenuItem
            // 
            this.проверкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стартToolStripMenuItem});
            this.проверкаToolStripMenuItem.Name = "проверкаToolStripMenuItem";
            this.проверкаToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.проверкаToolStripMenuItem.Text = "Проверка";
            // 
            // стартToolStripMenuItem
            // 
            this.стартToolStripMenuItem.Name = "стартToolStripMenuItem";
            this.стартToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.стартToolStripMenuItem.Text = "Старт";
            this.стартToolStripMenuItem.Click += new System.EventHandler(this.startMenu_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tapPropositions);
            this.tabControl1.Controls.Add(this.tabOutcome);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(288, 421);
            this.tabControl1.TabIndex = 1;
            // 
            // tapPropositions
            // 
            this.tapPropositions.Controls.Add(this.propositionsGrid);
            this.tapPropositions.Location = new System.Drawing.Point(4, 22);
            this.tapPropositions.Name = "tapPropositions";
            this.tapPropositions.Padding = new System.Windows.Forms.Padding(3);
            this.tapPropositions.Size = new System.Drawing.Size(280, 395);
            this.tapPropositions.TabIndex = 1;
            this.tapPropositions.Text = "Утверждения";
            this.tapPropositions.UseVisualStyleBackColor = true;
            this.tapPropositions.UseWaitCursor = true;
            // 
            // propositionsGrid
            // 
            this.propositionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propositionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proposition});
            this.propositionsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propositionsGrid.Location = new System.Drawing.Point(3, 3);
            this.propositionsGrid.Name = "propositionsGrid";
            this.propositionsGrid.Size = new System.Drawing.Size(274, 389);
            this.propositionsGrid.TabIndex = 0;
            this.propositionsGrid.UseWaitCursor = true;
            // 
            // tabOutcome
            // 
            this.tabOutcome.Controls.Add(this.Outcome10);
            this.tabOutcome.Controls.Add(this.label10);
            this.tabOutcome.Controls.Add(this.Outcome9);
            this.tabOutcome.Controls.Add(this.label9);
            this.tabOutcome.Controls.Add(this.Outcome8);
            this.tabOutcome.Controls.Add(this.label8);
            this.tabOutcome.Controls.Add(this.Outcome7);
            this.tabOutcome.Controls.Add(this.label7);
            this.tabOutcome.Controls.Add(this.Outcome6);
            this.tabOutcome.Controls.Add(this.label6);
            this.tabOutcome.Controls.Add(this.label5);
            this.tabOutcome.Controls.Add(this.Outcome5);
            this.tabOutcome.Controls.Add(this.label4);
            this.tabOutcome.Controls.Add(this.Outcome4);
            this.tabOutcome.Controls.Add(this.label3);
            this.tabOutcome.Controls.Add(this.Outcome3);
            this.tabOutcome.Controls.Add(this.label2);
            this.tabOutcome.Controls.Add(this.label1);
            this.tabOutcome.Controls.Add(this.Outcome2);
            this.tabOutcome.Controls.Add(this.Outcome1);
            this.tabOutcome.Location = new System.Drawing.Point(4, 22);
            this.tabOutcome.Name = "tabOutcome";
            this.tabOutcome.Size = new System.Drawing.Size(280, 395);
            this.tabOutcome.TabIndex = 2;
            this.tabOutcome.Text = "Исходы";
            this.tabOutcome.UseVisualStyleBackColor = true;
            // 
            // Outcome10
            // 
            this.Outcome10.Location = new System.Drawing.Point(8, 367);
            this.Outcome10.Name = "Outcome10";
            this.Outcome10.Size = new System.Drawing.Size(258, 20);
            this.Outcome10.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Исход №10";
            // 
            // Outcome9
            // 
            this.Outcome9.Location = new System.Drawing.Point(8, 330);
            this.Outcome9.Name = "Outcome9";
            this.Outcome9.Size = new System.Drawing.Size(258, 20);
            this.Outcome9.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Исход №9";
            // 
            // Outcome8
            // 
            this.Outcome8.Location = new System.Drawing.Point(8, 291);
            this.Outcome8.Name = "Outcome8";
            this.Outcome8.Size = new System.Drawing.Size(258, 20);
            this.Outcome8.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Исход №8";
            // 
            // Outcome7
            // 
            this.Outcome7.Location = new System.Drawing.Point(8, 252);
            this.Outcome7.Name = "Outcome7";
            this.Outcome7.Size = new System.Drawing.Size(258, 20);
            this.Outcome7.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Исход №7";
            // 
            // Outcome6
            // 
            this.Outcome6.Location = new System.Drawing.Point(8, 213);
            this.Outcome6.Name = "Outcome6";
            this.Outcome6.Size = new System.Drawing.Size(258, 20);
            this.Outcome6.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Исход №6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Исход №5";
            // 
            // Outcome5
            // 
            this.Outcome5.Location = new System.Drawing.Point(8, 174);
            this.Outcome5.Name = "Outcome5";
            this.Outcome5.Size = new System.Drawing.Size(258, 20);
            this.Outcome5.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Исход №4";
            // 
            // Outcome4
            // 
            this.Outcome4.Location = new System.Drawing.Point(8, 135);
            this.Outcome4.Name = "Outcome4";
            this.Outcome4.Size = new System.Drawing.Size(258, 20);
            this.Outcome4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Исход №2";
            // 
            // Outcome3
            // 
            this.Outcome3.Location = new System.Drawing.Point(8, 95);
            this.Outcome3.Name = "Outcome3";
            this.Outcome3.Size = new System.Drawing.Size(258, 20);
            this.Outcome3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Исход №3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Исход №1";
            // 
            // Outcome2
            // 
            this.Outcome2.Location = new System.Drawing.Point(8, 56);
            this.Outcome2.Name = "Outcome2";
            this.Outcome2.Size = new System.Drawing.Size(258, 20);
            this.Outcome2.TabIndex = 1;
            // 
            // Outcome1
            // 
            this.Outcome1.Location = new System.Drawing.Point(8, 17);
            this.Outcome1.Name = "Outcome1";
            this.Outcome1.Size = new System.Drawing.Size(258, 20);
            this.Outcome1.TabIndex = 0;
            // 
            // Proposition
            // 
            this.Proposition.HeaderText = "Утверждение";
            this.Proposition.Name = "Proposition";
            // 
            // ExpertSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 445);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "ExpertSystemForm";
            this.Text = "Form1";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tapPropositions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propositionsGrid)).EndInit();
            this.tabOutcome.ResumeLayout(false);
            this.tabOutcome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удтверждениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tapPropositions;
        private System.Windows.Forms.DataGridView propositionsGrid;
        private System.Windows.Forms.ToolStripMenuItem проверкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стартToolStripMenuItem;
        private System.Windows.Forms.TabPage tabOutcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Outcome2;
        private System.Windows.Forms.TextBox Outcome1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Outcome3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Outcome5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Outcome4;
        private System.Windows.Forms.TextBox Outcome8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Outcome7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Outcome6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Outcome10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Outcome9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proposition;
    }
}

