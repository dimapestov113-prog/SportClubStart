namespace SportClubStart
{
    partial class RegistrationSports
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            BTNcnl = new Button();
            BTNadd = new Button();
            label5 = new Label();
            Phonesm = new TextBox();
            BDsm = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            FIOsm = new TextBox();
            tabPage2 = new TabPage();
            Combotr = new ComboBox();
            BTNcnl1 = new Button();
            BTNaddTR = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            FIOtr = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(425, 270);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BTNcnl);
            tabPage1.Controls.Add(BTNadd);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(Phonesm);
            tabPage1.Controls.Add(BDsm);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(FIOsm);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(417, 237);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Регистрация спортсмена";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // BTNcnl
            // 
            BTNcnl.BackColor = Color.FromArgb(255, 192, 192);
            BTNcnl.DialogResult = DialogResult.Cancel;
            BTNcnl.Location = new Point(6, 167);
            BTNcnl.Name = "BTNcnl";
            BTNcnl.Size = new Size(168, 67);
            BTNcnl.TabIndex = 13;
            BTNcnl.Text = "Назад";
            BTNcnl.UseVisualStyleBackColor = false;
            // 
            // BTNadd
            // 
            BTNadd.BackColor = Color.FromArgb(192, 255, 192);
            BTNadd.Location = new Point(241, 167);
            BTNadd.Name = "BTNadd";
            BTNadd.Size = new Size(168, 67);
            BTNadd.TabIndex = 12;
            BTNadd.Text = "Добавить спортсмена";
            BTNadd.UseVisualStyleBackColor = false;
            BTNadd.Click += BTNadd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 123);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 11;
            label5.Text = "Дата рождения:";
            // 
            // Phonesm
            // 
            Phonesm.Location = new Point(150, 70);
            Phonesm.Name = "Phonesm";
            Phonesm.Size = new Size(259, 27);
            Phonesm.TabIndex = 9;
            // 
            // BDsm
            // 
            BDsm.Location = new Point(150, 118);
            BDsm.Name = "BDsm";
            BDsm.Size = new Size(259, 27);
            BDsm.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 73);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 7;
            label3.Text = "Телефон родителя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 36);
            label2.Name = "label2";
            label2.Size = new Size(191, 20);
            label2.TabIndex = 6;
            label2.Text = "(максимум 100 символов)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 5;
            label1.Text = "ФИО спортсмена: ";
            // 
            // FIOsm
            // 
            FIOsm.Location = new Point(150, 6);
            FIOsm.MaxLength = 100;
            FIOsm.Name = "FIOsm";
            FIOsm.Size = new Size(259, 27);
            FIOsm.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(Combotr);
            tabPage2.Controls.Add(BTNcnl1);
            tabPage2.Controls.Add(BTNaddTR);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(FIOtr);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(417, 237);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Регистрация тренера";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Combotr
            // 
            Combotr.FormattingEnabled = true;
            Combotr.Items.AddRange(new object[] { "Бегит", "Отжумания", "Пресс", "Арбуз" });
            Combotr.Location = new Point(150, 70);
            Combotr.Name = "Combotr";
            Combotr.Size = new Size(259, 28);
            Combotr.TabIndex = 23;
            // 
            // BTNcnl1
            // 
            BTNcnl1.BackColor = Color.FromArgb(255, 192, 192);
            BTNcnl1.DialogResult = DialogResult.Cancel;
            BTNcnl1.Location = new Point(6, 167);
            BTNcnl1.Name = "BTNcnl1";
            BTNcnl1.Size = new Size(168, 67);
            BTNcnl1.TabIndex = 22;
            BTNcnl1.Text = "Назад";
            BTNcnl1.UseVisualStyleBackColor = false;
            // 
            // BTNaddTR
            // 
            BTNaddTR.BackColor = Color.FromArgb(192, 255, 192);
            BTNaddTR.Location = new Point(241, 167);
            BTNaddTR.Name = "BTNaddTR";
            BTNaddTR.Size = new Size(168, 67);
            BTNaddTR.TabIndex = 21;
            BTNaddTR.Text = "Добавить спортсмена";
            BTNaddTR.UseVisualStyleBackColor = false;
            BTNaddTR.Click += BTNaddTR_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 73);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 17;
            label6.Text = "Вид спорта:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(218, 36);
            label7.Name = "label7";
            label7.Size = new Size(191, 20);
            label7.TabIndex = 16;
            label7.Text = "(максимум 100 символов)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 9);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 15;
            label8.Text = "ФИО тренера: ";
            // 
            // FIOtr
            // 
            FIOtr.Location = new Point(150, 6);
            FIOtr.MaxLength = 100;
            FIOtr.Name = "FIOtr";
            FIOtr.Size = new Size(259, 27);
            FIOtr.TabIndex = 14;
            // 
            // RegistrationSports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 270);
            ControlBox = false;
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "RegistrationSports";
            Text = "Добавление пользователей";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label5;
        private TextBox Phonesm;
        private DateTimePicker BDsm;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox FIOsm;
        private Button BTNcnl;
        private Button BTNadd;
        private ComboBox Combotr;
        private Button BTNcnl1;
        private Button BTNaddTR;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox FIOtr;
    }
}