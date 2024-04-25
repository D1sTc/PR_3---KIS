namespace PR_3
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Reference = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.Task = new System.Windows.Forms.GroupBox();
            this.pictureTask = new System.Windows.Forms.PictureBox();
            this.Dictionary = new System.Windows.Forms.GroupBox();
            this.Generation = new System.Windows.Forms.Button();
            this.textBoxNumbersKeys = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Value = new System.Windows.Forms.GroupBox();
            this.Multiply = new System.Windows.Forms.Button();
            this.textBoxNumbersValues = new System.Windows.Forms.TextBox();
            this.OutputToTheScreen = new System.Windows.Forms.GroupBox();
            this.textBoxNumbersExScreen = new System.Windows.Forms.TextBox();
            this.Applications = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationGeneration = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationMultiply = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.Task.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTask)).BeginInit();
            this.Dictionary.SuspendLayout();
            this.Value.SuspendLayout();
            this.OutputToTheScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.Reference});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(740, 24);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Applications,
            this.ClearMenu,
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(48, 20);
            this.FileMenu.Text = "файл";
            // 
            // ClearMenu
            // 
            this.ClearMenu.Name = "ClearMenu";
            this.ClearMenu.Size = new System.Drawing.Size(180, 22);
            this.ClearMenu.Text = "Очистить";
            this.ClearMenu.Click += new System.EventHandler(this.ClearMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(180, 22);
            this.ExitMenu.Text = "Выход";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // Reference
            // 
            this.Reference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgram});
            this.Reference.Name = "Reference";
            this.Reference.Size = new System.Drawing.Size(63, 20);
            this.Reference.Text = "справка";
            // 
            // AboutProgram
            // 
            this.AboutProgram.Name = "AboutProgram";
            this.AboutProgram.Size = new System.Drawing.Size(180, 22);
            this.AboutProgram.Text = "О программе";
            this.AboutProgram.Click += new System.EventHandler(this.AboutProgram_Click);
            // 
            // Task
            // 
            this.Task.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Task.Controls.Add(this.pictureTask);
            this.Task.Location = new System.Drawing.Point(12, 27);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(681, 92);
            this.Task.TabIndex = 2;
            this.Task.TabStop = false;
            this.Task.Text = "Задание:";
            // 
            // pictureTask
            // 
            this.pictureTask.Image = global::PR_3.Properties.Resources._2;
            this.pictureTask.Location = new System.Drawing.Point(19, 19);
            this.pictureTask.Name = "pictureTask";
            this.pictureTask.Size = new System.Drawing.Size(645, 63);
            this.pictureTask.TabIndex = 0;
            this.pictureTask.TabStop = false;
            // 
            // Dictionary
            // 
            this.Dictionary.Controls.Add(this.Generation);
            this.Dictionary.Controls.Add(this.textBoxNumbersKeys);
            this.Dictionary.Location = new System.Drawing.Point(12, 125);
            this.Dictionary.Name = "Dictionary";
            this.Dictionary.Size = new System.Drawing.Size(237, 92);
            this.Dictionary.TabIndex = 3;
            this.Dictionary.TabStop = false;
            this.Dictionary.Text = "Словарь генераций:";
            // 
            // Generation
            // 
            this.Generation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Generation.Location = new System.Drawing.Point(6, 48);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(135, 35);
            this.Generation.TabIndex = 7;
            this.Generation.Text = "Сгенерировать";
            this.Generation.UseVisualStyleBackColor = true;
            this.Generation.Click += new System.EventHandler(this.Generation_Click);
            // 
            // textBoxNumbersKeys
            // 
            this.textBoxNumbersKeys.Location = new System.Drawing.Point(6, 19);
            this.textBoxNumbersKeys.Name = "textBoxNumbersKeys";
            this.textBoxNumbersKeys.ReadOnly = true;
            this.textBoxNumbersKeys.Size = new System.Drawing.Size(224, 20);
            this.textBoxNumbersKeys.TabIndex = 6;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Clear.Location = new System.Drawing.Point(504, 195);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(106, 60);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Exit.Location = new System.Drawing.Point(616, 200);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(106, 50);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Value
            // 
            this.Value.Controls.Add(this.Multiply);
            this.Value.Controls.Add(this.textBoxNumbersValues);
            this.Value.Location = new System.Drawing.Point(255, 125);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(237, 92);
            this.Value.TabIndex = 8;
            this.Value.TabStop = false;
            this.Value.Text = "Значения:";
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Multiply.Location = new System.Drawing.Point(6, 48);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(118, 35);
            this.Multiply.TabIndex = 7;
            this.Multiply.Text = "Перемножить";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // textBoxNumbersValues
            // 
            this.textBoxNumbersValues.Location = new System.Drawing.Point(6, 19);
            this.textBoxNumbersValues.Name = "textBoxNumbersValues";
            this.textBoxNumbersValues.ReadOnly = true;
            this.textBoxNumbersValues.Size = new System.Drawing.Size(224, 20);
            this.textBoxNumbersValues.TabIndex = 6;
            // 
            // OutputToTheScreen
            // 
            this.OutputToTheScreen.Controls.Add(this.textBoxNumbersExScreen);
            this.OutputToTheScreen.Location = new System.Drawing.Point(498, 125);
            this.OutputToTheScreen.Name = "OutputToTheScreen";
            this.OutputToTheScreen.Size = new System.Drawing.Size(233, 64);
            this.OutputToTheScreen.TabIndex = 9;
            this.OutputToTheScreen.TabStop = false;
            this.OutputToTheScreen.Text = "Вывод на экран:";
            // 
            // textBoxNumbersExScreen
            // 
            this.textBoxNumbersExScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxNumbersExScreen.Location = new System.Drawing.Point(6, 19);
            this.textBoxNumbersExScreen.Name = "textBoxNumbersExScreen";
            this.textBoxNumbersExScreen.ReadOnly = true;
            this.textBoxNumbersExScreen.Size = new System.Drawing.Size(218, 38);
            this.textBoxNumbersExScreen.TabIndex = 6;
            // 
            // Applications
            // 
            this.Applications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApplicationGeneration,
            this.ApplicationMultiply});
            this.Applications.Name = "Applications";
            this.Applications.Size = new System.Drawing.Size(180, 22);
            this.Applications.Text = "Приложения";
            // 
            // ApplicationGeneration
            // 
            this.ApplicationGeneration.Name = "ApplicationGeneration";
            this.ApplicationGeneration.Size = new System.Drawing.Size(242, 22);
            this.ApplicationGeneration.Text = "Приложение \"Сгенерировать\"";
            this.ApplicationGeneration.Click += new System.EventHandler(this.ApplicationGeneration_Click);
            // 
            // ApplicationMultiply
            // 
            this.ApplicationMultiply.Name = "ApplicationMultiply";
            this.ApplicationMultiply.Size = new System.Drawing.Size(242, 22);
            this.ApplicationMultiply.Text = "Приложение \"Перемножить\"";
            this.ApplicationMultiply.Click += new System.EventHandler(this.ApplicationMultiply_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 266);
            this.Controls.Add(this.OutputToTheScreen);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.Dictionary);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Практическая работа №3";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.Task.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTask)).EndInit();
            this.Dictionary.ResumeLayout(false);
            this.Dictionary.PerformLayout();
            this.Value.ResumeLayout(false);
            this.Value.PerformLayout();
            this.OutputToTheScreen.ResumeLayout(false);
            this.OutputToTheScreen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem ClearMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem Reference;
        private System.Windows.Forms.ToolStripMenuItem AboutProgram;
        private System.Windows.Forms.GroupBox Task;
        private System.Windows.Forms.PictureBox pictureTask;
        private System.Windows.Forms.GroupBox Dictionary;
        private System.Windows.Forms.Button Generation;
        private System.Windows.Forms.TextBox textBoxNumbersKeys;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox Value;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.TextBox textBoxNumbersValues;
        private System.Windows.Forms.GroupBox OutputToTheScreen;
        private System.Windows.Forms.TextBox textBoxNumbersExScreen;
        private System.Windows.Forms.ToolStripMenuItem Applications;
        private System.Windows.Forms.ToolStripMenuItem ApplicationGeneration;
        private System.Windows.Forms.ToolStripMenuItem ApplicationMultiply;
    }
}

