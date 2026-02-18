using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static SportClubStart.Models.DB;

namespace SportClubStart
{
    public partial class RegistrationSports : Form //регистрация спортсменов/
    {

        private readonly ConnectDB db = new ConnectDB();
        public RegistrationSports()
        {
            InitializeComponent();
            using var db = new ConnectDB();
            db.Database.EnsureCreated();
        }

        private void BTNadd_Click(object sender, EventArgs e)//спортсмены
        {
            var Name = FIOsm.Text;
            var Phone = Phonesm.Text;
            var BD = Convert.ToDateTime(BDsm.Text);
            if (Name.Length != 0 & Phone.Length != 0 & BD.Year != 0)
            {
                try
                {
                    using var db = new ConnectDB();
                    var Sportsmen = new Sportsmen
                    {
                        FullName = Name,
                        ParentPhone = Phone,
                        Birthday = BD
                    };
                    db.Sportsmen.Add(Sportsmen);
                    db.SaveChanges();

                    FIOsm.Clear();
                    Phonesm.Clear();
                    BDsm.Value = DateTime.Now;

                    MessageBox.Show("Спортсмен успешно добавлен");
                }
                catch
                {
                    MessageBox.Show("BALBES");
                }
            }
            else
            {
                MessageBox.Show("Заполните данные");
            }
        }

        private void BTNaddTR_Click(object sender, EventArgs e)
        {
            var FullName = FIOtr.Text;
            var SportType = Combotr.Text;
            if (FullName.Length != 0 &  SportType.Length != 0)
                try
                {
                    using var db = new ConnectDB();
                    var Coaches = new Coaches
                    {
                        FullName = FullName,
                        SportType = SportType
                    };
                    db.Coaches.Add(Coaches);
                    db.SaveChanges();

                    FIOtr.Clear();
                    Combotr.SelectedIndex =-1;

                    MessageBox.Show("Тренер успешно добавлен");
                }
                catch
                {
                    MessageBox.Show("BALBEEEES");
                }
            else
            {
                MessageBox.Show("Заполните данные");
            }
        }
    }
}
//FIOsm фио
//BDsm др
//Phonesm телефон мамы(
//BTNadd добавить спортсмена
//BTNcn отмена

//BTNaddTR добавить тренера
//FIOtr ФИО
//Combotr выбор вида спорта