using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static SportClubStart.Models.DB;

namespace SportClubStart
{
    public partial class Progulchiki : Form
    {
        public Progulchiki()
        {
            InitializeComponent();
            Setup();
            LoadProgulshiki();

            using var db = new ConnectDB();
            db.Database.EnsureCreated();
        }

        public void Setup()
        {
            // Настройка 
            DGVprog.Columns.Clear();
            DGVprog.Columns.Add("FullName", "ФИО ребёнка");
            DGVprog.Columns.Add("Birthday", "Дата рождения");
            DGVprog.Columns.Add("ParentPhone", "Телефон родителя");
            DGVprog.Columns.Add("SkipDate", "Дата пропуска");
            DGVprog.Columns.Add("CoachName", "Тренер");
            DGVprog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVprog.AllowUserToAddRows = false;
            DGVprog.RowHeadersVisible = false;


        }

        public void LoadProgulshiki()
        {
            DGVprog.Rows.Clear();

            DateTime dateStart = dateTimePicker1.Value.Date;
            DateTime dateEnd = dateTimePicker2.Value.Date;

            using var db = new ConnectDB();

            var absences = db.Attendances
                .Where(a => a.Attended == false
                       && a.TrainingDate >= dateStart
                       && a.TrainingDate <= dateEnd)
                .ToList();

            foreach (var item in absences)
            {
                var child = db.Sportsmen.FirstOrDefault(s => s.Id == item.SportsmanId);
                var coach = db.Coaches.FirstOrDefault(c => c.Id == item.CoachId);

                if (child != null)
                {
                    DGVprog.Rows.Add(
                        child.FullName,
                        child.Birthday.ToShortDateString(),
                        child.ParentPhone,
                        item.TrainingDate.ToShortDateString(),
                        coach?.FullName ?? "Неизвестно"
                    );
                }
            }
        }

        // Обновление при изменении датыыыы 1427781ц1у12выzzzzzzz
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadProgulshiki();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            LoadProgulshiki();
        }
    }
}