using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportClubStart
{
    public partial class AllUsers : Form
    {
        public AllUsers()
        {
            InitializeComponent();
            SetUp();

            using var db = new ConnectDB();
            db.Database.EnsureCreated();
        }

        private void SetUp()
        {
            dataGridView1.Columns.Add("FullName", "ФИО");
            dataGridView1.Columns.Add("SportType", "Занятие");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView2.Columns.Add("FullName", "ФИО");
            dataGridView2.Columns.Add("Birthday", "День рождения");
            dataGridView2.Columns.Add("ParentPhone", "Телефон родителя");
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    LoadCoachers();
                    break;

                case 1:
                    LoadStudents();
                    break;
            }
        }

        public void LoadCoachers()
        {
            dataGridView1.Rows.Clear();
            using var db = new ConnectDB();
            var coaches = db.Coaches.ToList();
            foreach (var coach in coaches)
            {
                dataGridView1.Rows.Add(
                    coach.FullName,
                    coach.SportType
                );
            }
        }

        public void LoadStudents()
        {
            dataGridView2.Rows.Clear();
            using var db = new ConnectDB();
            var students = db.Sportsmen.ToList();
            foreach (var student in students)
            {
                dataGridView2.Rows.Add(
                    student.FullName,
                    student.Birthday,
                    student.ParentPhone
                );
            }
        }
    }
}