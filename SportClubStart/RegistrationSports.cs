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

        private void BtnAddSportsmen_Click(object sender, EventArgs e)//спортсмены
        {
            var Name = FioSm.Text;
            var Phone = PhoneSm.Text;
            var BD = Convert.ToDateTime(BdSm.Text);
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

                    FioSm.Clear();
                    PhoneSm.Clear();
                    BdSm.Value = DateTime.Now;

                    MessageBox.Show("Спортсмен добавлен");
                }
                catch
                {
                    MessageBox.Show("незя(");
                }
            }
            else
            {
                MessageBox.Show("Заполните данные");
            }
        }

        private void BtnAddTr_Click(object sender, EventArgs e)//добавление
        {
            var FullName = FioTr.Text;
            var SportType = ComboTr.Text;
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

                    FioTr.Clear();
                    ComboTr.SelectedIndex =-1;

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
}//поменял названия