namespace SportClubStart
{
    partial class Posechenie
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
            AddZ = new Button();
            label3 = new Label();
            Cbtr = new ComboBox();
            label2 = new Label();
            DTz = new DateTimePicker();
            label1 = new Label();
            CBLsm = new CheckedListBox();
            Cancel = new Button();
            tabPage2 = new TabPage();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            tabPage3 = new TabPage();
            splitContainer2 = new SplitContainer();
            dataGridView2 = new DataGridView();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            button2 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(526, 432);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(AddZ);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(Cbtr);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(DTz);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(CBLsm);
            tabPage1.Controls.Add(Cancel);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(518, 399);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Отметить спортсменов";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // AddZ
            // 
            AddZ.BackColor = Color.FromArgb(192, 255, 192);
            AddZ.Location = new Point(330, 325);
            AddZ.Name = "AddZ";
            AddZ.Size = new Size(185, 71);
            AddZ.TabIndex = 15;
            AddZ.Text = "Отметить";
            AddZ.UseVisualStyleBackColor = false;
            AddZ.Click += AddZ_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 29);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 14;
            label3.Text = "Тренер:";
            // 
            // Cbtr
            // 
            Cbtr.FormattingEnabled = true;
            Cbtr.Location = new Point(138, 36);
            Cbtr.Name = "Cbtr";
            Cbtr.Size = new Size(379, 28);
            Cbtr.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 12;
            label2.Text = "Дата проведения";
            // 
            // DTz
            // 
            DTz.Location = new Point(138, 5);
            DTz.Name = "DTz";
            DTz.Size = new Size(379, 27);
            DTz.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 60);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 10;
            label1.Text = "Имя спортсмена:";
            // 
            // CBLsm
            // 
            CBLsm.FormattingEnabled = true;
            CBLsm.Location = new Point(138, 70);
            CBLsm.Name = "CBLsm";
            CBLsm.Size = new Size(379, 246);
            CBLsm.TabIndex = 9;
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.FromArgb(255, 192, 192);
            Cancel.DialogResult = DialogResult.Cancel;
            Cancel.Location = new Point(8, 320);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(186, 71);
            Cancel.TabIndex = 8;
            Cancel.Text = "Отмена";
            Cancel.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(518, 399);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Посещаемость";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(dateTimePicker2);
            splitContainer1.Panel2.Controls.Add(dateTimePicker1);
            splitContainer1.Size = new Size(512, 393);
            splitContainer1.SplitterDistance = 268;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(512, 268);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(3, 13);
            button1.Name = "button1";
            button1.Size = new Size(172, 94);
            button1.TabIndex = 9;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(181, 68);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 1;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(181, 35);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(splitContainer2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(518, 399);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Активность";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dataGridView2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(dateTimePicker3);
            splitContainer2.Panel2.Controls.Add(dateTimePicker4);
            splitContainer2.Panel2.Controls.Add(button2);
            splitContainer2.Size = new Size(512, 393);
            splitContainer2.SplitterDistance = 279;
            splitContainer2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(512, 279);
            dataGridView2.TabIndex = 1;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(181, 50);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(250, 27);
            dateTimePicker3.TabIndex = 12;
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(181, 17);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(250, 27);
            dateTimePicker4.TabIndex = 11;
            dateTimePicker4.ValueChanged += dateTimePicker4_ValueChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(172, 94);
            button2.TabIndex = 10;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = false;
            // 
            // Posechenie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 432);
            ControlBox = false;
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Posechenie";
            Text = "Отметить спортсменов";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button AddZ;
        private Label label3;
        private ComboBox Cbtr;
        private Label label2;
        private DateTimePicker DTz;
        private Label label1;
        private CheckedListBox CBLsm;
        private Button Cancel;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private SplitContainer splitContainer2;
        private DataGridView dataGridView2;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private Button button2;
    }
}