namespace Programka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartButton = new System.Windows.Forms.Button();
            this.MinTimeCB = new System.Windows.Forms.ComboBox();
            this.Rabd1CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Rabd2CB = new System.Windows.Forms.ComboBox();
            this.KolichCB = new System.Windows.Forms.ComboBox();
            this.StartButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(12, 161);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(81, 40);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Запуск";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MinTimeCB
            // 
            this.MinTimeCB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinTimeCB.FormattingEnabled = true;
            this.MinTimeCB.Items.AddRange(new object[] {
            "Random",
            "50",
            "100",
            "500",
            "1000",
            "5000",
            "10000"});
            this.MinTimeCB.Location = new System.Drawing.Point(12, 59);
            this.MinTimeCB.Name = "MinTimeCB";
            this.MinTimeCB.Size = new System.Drawing.Size(176, 28);
            this.MinTimeCB.TabIndex = 2;
            this.MinTimeCB.Text = "Время клика";
            // 
            // Rabd1CB
            // 
            this.Rabd1CB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rabd1CB.FormattingEnabled = true;
            this.Rabd1CB.Items.AddRange(new object[] {
            "5000",
            "10000",
            "30000",
            "60000",
            "180000"});
            this.Rabd1CB.Location = new System.Drawing.Point(12, 93);
            this.Rabd1CB.Name = "Rabd1CB";
            this.Rabd1CB.Size = new System.Drawing.Size(81, 28);
            this.Rabd1CB.TabIndex = 3;
            this.Rabd1CB.Text = "1500";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Клик машина";
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.Location = new System.Drawing.Point(162, 10);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(26, 26);
            this.ExitButton.TabIndex = 160;
            this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Rabd2CB
            // 
            this.Rabd2CB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rabd2CB.FormattingEnabled = true;
            this.Rabd2CB.Items.AddRange(new object[] {
            "5000",
            "10000",
            "30000",
            "60000",
            "180000"});
            this.Rabd2CB.Location = new System.Drawing.Point(107, 93);
            this.Rabd2CB.Name = "Rabd2CB";
            this.Rabd2CB.Size = new System.Drawing.Size(81, 28);
            this.Rabd2CB.TabIndex = 161;
            this.Rabd2CB.Text = "2000";
            // 
            // KolichCB
            // 
            this.KolichCB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KolichCB.FormattingEnabled = true;
            this.KolichCB.Items.AddRange(new object[] {
            "50",
            "100",
            "500",
            "1000",
            "5000",
            "10000"});
            this.KolichCB.Location = new System.Drawing.Point(12, 127);
            this.KolichCB.Name = "KolichCB";
            this.KolichCB.Size = new System.Drawing.Size(176, 28);
            this.KolichCB.TabIndex = 162;
            this.KolichCB.Text = "Количество";
            // 
            // StartButton2
            // 
            this.StartButton2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton2.Location = new System.Drawing.Point(107, 161);
            this.StartButton2.Name = "StartButton2";
            this.StartButton2.Size = new System.Drawing.Size(81, 40);
            this.StartButton2.TabIndex = 163;
            this.StartButton2.Text = "Запуск";
            this.StartButton2.UseVisualStyleBackColor = true;
            this.StartButton2.Click += new System.EventHandler(this.StartButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(200, 213);
            this.Controls.Add(this.StartButton2);
            this.Controls.Add(this.KolichCB);
            this.Controls.Add(this.Rabd2CB);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rabd1CB);
            this.Controls.Add(this.MinTimeCB);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ComboBox MinTimeCB;
        private System.Windows.Forms.ComboBox Rabd1CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ComboBox Rabd2CB;
        private System.Windows.Forms.ComboBox KolichCB;
        private System.Windows.Forms.Button StartButton2;
    }
}

