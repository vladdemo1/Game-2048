namespace Game2048
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Player1 = new System.Windows.Forms.Button();
            this.Player2 = new System.Windows.Forms.Button();
            this.Player3 = new System.Windows.Forms.Button();
            this.Player4 = new System.Windows.Forms.Button();
            this.Player5 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label_Add = new System.Windows.Forms.Label();
            this.textbox_Name = new System.Windows.Forms.TextBox();
            this.Play = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.Saving = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.GreenYellow;
            this.Player1.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player1.Location = new System.Drawing.Point(12, 12);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(272, 79);
            this.Player1.TabIndex = 0;
            this.Player1.Text = "Пусто";
            this.Player1.UseVisualStyleBackColor = false;
            this.Player1.Click += new System.EventHandler(this.Player1_Click);
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.GreenYellow;
            this.Player2.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player2.Location = new System.Drawing.Point(12, 97);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(272, 79);
            this.Player2.TabIndex = 1;
            this.Player2.Text = "Пусто";
            this.Player2.UseVisualStyleBackColor = false;
            this.Player2.Click += new System.EventHandler(this.Player2_Click);
            // 
            // Player3
            // 
            this.Player3.BackColor = System.Drawing.Color.GreenYellow;
            this.Player3.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player3.Location = new System.Drawing.Point(12, 182);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(272, 79);
            this.Player3.TabIndex = 2;
            this.Player3.Text = "Пусто";
            this.Player3.UseVisualStyleBackColor = false;
            this.Player3.Click += new System.EventHandler(this.Player3_Click);
            // 
            // Player4
            // 
            this.Player4.BackColor = System.Drawing.Color.GreenYellow;
            this.Player4.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player4.Location = new System.Drawing.Point(12, 267);
            this.Player4.Name = "Player4";
            this.Player4.Size = new System.Drawing.Size(272, 79);
            this.Player4.TabIndex = 3;
            this.Player4.Text = "Пусто";
            this.Player4.UseVisualStyleBackColor = false;
            this.Player4.Click += new System.EventHandler(this.Player4_Click);
            // 
            // Player5
            // 
            this.Player5.BackColor = System.Drawing.Color.GreenYellow;
            this.Player5.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player5.Location = new System.Drawing.Point(12, 352);
            this.Player5.Name = "Player5";
            this.Player5.Size = new System.Drawing.Size(272, 79);
            this.Player5.TabIndex = 4;
            this.Player5.Text = "Пусто";
            this.Player5.UseVisualStyleBackColor = false;
            this.Player5.Click += new System.EventHandler(this.Player5_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.GreenYellow;
            this.Exit.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(484, 352);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(103, 79);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label_Add
            // 
            this.label_Add.AutoSize = true;
            this.label_Add.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Add.Location = new System.Drawing.Point(299, 12);
            this.label_Add.Name = "label_Add";
            this.label_Add.Size = new System.Drawing.Size(278, 44);
            this.label_Add.TabIndex = 6;
            this.label_Add.Text = "Добавить игрока";
            // 
            // textbox_Name
            // 
            this.textbox_Name.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox_Name.Location = new System.Drawing.Point(298, 59);
            this.textbox_Name.Name = "textbox_Name";
            this.textbox_Name.Size = new System.Drawing.Size(289, 51);
            this.textbox_Name.TabIndex = 7;
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.GreenYellow;
            this.Play.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Play.Location = new System.Drawing.Point(290, 116);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(297, 60);
            this.Play.TabIndex = 8;
            this.Play.Text = "Играть";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info.Location = new System.Drawing.Point(290, 182);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(297, 155);
            this.Info.TabIndex = 9;
            this.Info.Text = "Нажав на любую кнопку\r\nВы добавите нового\r\nигрока\r\nТак же можно улучшить\r\nсвои ре" +
    "зультаты!";
            // 
            // Saving
            // 
            this.Saving.BackColor = System.Drawing.Color.GreenYellow;
            this.Saving.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Saving.Location = new System.Drawing.Point(290, 352);
            this.Saving.Name = "Saving";
            this.Saving.Size = new System.Drawing.Size(188, 79);
            this.Saving.TabIndex = 10;
            this.Saving.Text = "Сохранения";
            this.Saving.UseVisualStyleBackColor = false;
            this.Saving.Click += new System.EventHandler(this.Saving_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 443);
            this.Controls.Add(this.Saving);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.textbox_Name);
            this.Controls.Add(this.label_Add);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Player5);
            this.Controls.Add(this.Player4);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.MaximumSize = new System.Drawing.Size(612, 481);
            this.MinimumSize = new System.Drawing.Size(612, 481);
            this.Name = "Form1";
            this.Text = "Игра 2048";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label_Add;
        private System.Windows.Forms.TextBox textbox_Name;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label Info;
        public System.Windows.Forms.Button Player1;
        public System.Windows.Forms.Button Player2;
        public System.Windows.Forms.Button Player3;
        public System.Windows.Forms.Button Player4;
        public System.Windows.Forms.Button Player5;
        private System.Windows.Forms.Button Saving;
    }
}