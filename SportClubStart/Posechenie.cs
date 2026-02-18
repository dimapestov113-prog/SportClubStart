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
    public partial class Posechenie : Form
    {
        public Posechenie()
        {
            InitializeComponent();

            SetUp();

            LoadComboBox();
            LoadSportsmenList();

            LoadStatistica();
            LoadAktivnostDety();

            using var db = new ConnectDB();
            db.Database.EnsureCreated();
        }

        public void SetUp()
        {
            dataGridView1.Columns.Add("Coach", "Тренер");
            dataGridView1.Columns.Add("SportType", "Занятие");
            dataGridView1.Columns.Add("TotalTrainings", "Тренеровок всего");
            dataGridView1.Columns.Add("TotalVisits", "Посещений надо");
            dataGridView1.Columns.Add("Attended", "Посещено есть");
            dataGridView1.Columns.Add("Percent", "Процент посещаемости");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dataGridView2.Columns.Add("FullName", "ФИО");
            dataGridView2.Columns.Add("Age", "Возраст");
            dataGridView2.Columns.Add("TotalTrainings", "Всего тренировок");
            dataGridView2.Columns.Add("Absences", "Пропуски");
            dataGridView2.Columns.Add("Percent", "Процент посещаемости");
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            LoadAktivnostDety();
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            LoadAktivnostDety();
        }
        public void LoadAktivnostDety()
        {
            DateTime datestart = dateTimePicker4.Value.Date;
            DateTime dateend = dateTimePicker3.Value.Date;
            dataGridView2.Rows.Clear();

            DateTime today = DateTime.Today;

            using var db = new ConnectDB();

            // Получаем айди детей у которых было чет в это время
            var activeSportsmenIds = db.Attendances
                .Where(a => a.TrainingDate >= datestart && a.TrainingDate <= dateend)
                .Select(a => a.SportsmanId)
                .Distinct()
                .ToList();

            // Загружаем только этих детей
            var sportsmen = db.Sportsmen
                .Where(s => activeSportsmenIds.Contains(s.Id))
                .ToList();

            foreach (var child in sportsmen)
            {
                // Возраст 
                int age = today.Year - child.Birthday.Year;
                if (child.Birthday.Date > today.AddYears(-age)) age--;

                // Записи посещений в заданном периоде
                var attendances = db.Attendances
                    .Where(a => a.SportsmanId == child.Id
                           && a.TrainingDate >= datestart
                           && a.TrainingDate <= dateend)
                    .ToList();

                // Общее число тренировок 
                int totalTrainings = attendances
                    .Select(a => a.TrainingDate.Date)
                    .Distinct()
                    .Count();

                // Число пропусков 
                int absences = attendances.Count(a => a.Attended == false);

                // Общее количество записей
                int totalRecords = attendances.Count;

                // % посещаемости
                double percent = totalRecords > 0
                    ? (double)(totalRecords - absences) / totalRecords * 100
                    : 0;

                dataGridView2.Rows.Add(
                    child.FullName,
                    age,
                    totalTrainings,
                    absences,
                    $"{percent:F2}%"
                );
            }
        }
        public void LoadStatistica()//статистика тренер
        {
            dataGridView1.Rows.Clear();

            DateTime datestart = dateTimePicker1.Value.Date;
            DateTime dateend = dateTimePicker2.Value.Date;

            using var db = new ConnectDB();
            var coaches = db.Coaches.ToList();

            foreach (var coach in coaches)
            {
                // Все записи посещений этого тренера за период
                var attendances = db.Attendances
                    .Where(a => a.CoachId == coach.Id
                           && a.TrainingDate >= datestart
                           && a.TrainingDate <= dateend)
                    .ToList();

                //всего проведённых тренировок
                int totalTrainings = attendances
                    .Select(a => a.TrainingDate.Date)
                    .Distinct()
                    .Count();

                //Общее число посещений
                int totalVisits = attendances.Count;

                //Число посещённых детьми тренировок
                int attendedCount = attendances
                    .Count(a => a.Attended == true);

                //Процент посещаемости
                double percent = totalVisits > 0
                    ? (double)attendedCount / totalVisits * 100
                    : 0;

                //Добавляем строку в таблицу
                dataGridView1.Rows.Add(
                    coach.FullName,
                    coach.SportType,
                    totalTrainings,
                    totalVisits,
                    attendedCount,
                    $"{percent:F2}%"
                );
            }
        }

        // Обновление при изменении даты
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadStatistica();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            LoadStatistica();
        }

        public void LoadComboBox()
        {
            using var db = new ConnectDB();
            var coaches = db.Coaches
                .Select(c => new
                {
                    c.Id,
                    c.FullName
                })
                .ToList();

            Cbtr.DataSource = coaches;
            Cbtr.DisplayMember = "FullName";
            Cbtr.ValueMember = "Id";
        }

        public void LoadSportsmenList()
        {
            using var db = new ConnectDB();
            var sportsmen = db.Sportsmen
                .Select(s => new
                {
                    s.Id,
                    s.FullName
                })
                .ToList();

            CBLsm.DataSource = sportsmen;
            CBLsm.DisplayMember = "FullName";
            CBLsm.ValueMember = "Id";
        }

        private void AddZ_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cbtr.SelectedValue == null)
                {
                    MessageBox.Show("Выберите тренера");
                    return;
                }

                int coachId = (int)Cbtr.SelectedValue;
                DateTime trainingDate = DTz.Value;

                using var db = new ConnectDB();
                int Prishol = 0;
                int NePrishol = 0;

                for (int i = 0; i < CBLsm.Items.Count; i++)
                {
                    dynamic sportsman = CBLsm.Items[i];
                    int sportsmanId = sportsman.Id;
                    bool isChecked = CBLsm.GetItemChecked(i);

                    var attendance = new Attendances
                    {
                        SportsmanId = sportsmanId,
                        CoachId = coachId,
                        TrainingDate = trainingDate,
                        Attended = isChecked
                    };

                    db.Attendances.Add(attendance);

                    if (isChecked)
                        Prishol++;
                    else
                        NePrishol++;
                }

                db.SaveChanges();
                MessageBox.Show($"Пришли: {Prishol}\nОтсутствовали: {NePrishol}");

                // Очистка формы
                Cbtr.SelectedIndex = -1;
                for (int i = 0; i < CBLsm.Items.Count; i++)
                {
                    CBLsm.SetItemChecked(i, false);
                }
                DTz.Value = DateTime.Now;

                // Обновляем статистику
                LoadStatistica();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}