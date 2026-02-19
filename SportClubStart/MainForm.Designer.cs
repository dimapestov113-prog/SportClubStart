namespace SportClubStart
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnAdd = new Button();
            BtnOtm = new Button();
            Otchet = new Button();
            OpenUsers = new Button();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.FromArgb(192, 255, 192);
            BtnAdd.Location = new Point(268, 12);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(122, 63);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "Добавить участников";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnOtm
            // 
            BtnOtm.BackColor = Color.White;
            BtnOtm.Location = new Point(140, 12);
            BtnOtm.Name = "BtnOtm";
            BtnOtm.Size = new Size(122, 63);
            BtnOtm.TabIndex = 1;
            BtnOtm.Text = "Фиксация посещений";
            BtnOtm.UseVisualStyleBackColor = false;
            BtnOtm.Click += BtnOtm_Click;
            // 
            // Otchet
            // 
            Otchet.BackColor = Color.White;
            Otchet.Location = new Point(12, 12);
            Otchet.Name = "Otchet";
            Otchet.Size = new Size(122, 63);
            Otchet.TabIndex = 2;
            Otchet.Text = "Отчет о прогульщиках";
            Otchet.UseVisualStyleBackColor = false;
            Otchet.Click += Otchet_Click;
            // 
            // OpenUsers
            // 
            OpenUsers.Location = new Point(12, 81);
            OpenUsers.Name = "OpenUsers";
            OpenUsers.Size = new Size(376, 29);
            OpenUsers.TabIndex = 3;
            OpenUsers.Text = "Тренера и спортсмены";
            OpenUsers.UseVisualStyleBackColor = true;
            OpenUsers.Click += OpenCoachers_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 115);
            ControlBox = false;
            Controls.Add(OpenUsers);
            Controls.Add(Otchet);
            Controls.Add(BtnOtm);
            Controls.Add(BtnAdd);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MainForm";
            Text = "SportClub - \"Start\"";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAdd;
        private Button BtnOtm;
        private Button Otchet;
        private Button OpenUsers;
    }
}
