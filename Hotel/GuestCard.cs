using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using NLog;
using System.Diagnostics;

namespace Hotel
{
    public partial class GuestCard : Form
    {
        Database database = new Database();
        private static Logger logger = LogManager.GetCurrentClassLogger();
        Stopwatch stopwatch = new Stopwatch();
        int days, id;
        string departure;
        
        public GuestCard(string fio, string birthday, string payment, string days, string with_animals, string id, string departure)
        {
            InitializeComponent();
            FioTextBox.Text = fio;
            birthdayTextBox.Text = birthday;
            paymentTextBox.Text = payment;
            daysTextBox.Text = days;
            this.days = int.Parse(days);
            animalInfoTextBox.Text = with_animals;
            this.id = int.Parse(id);
            this.departure = departure;

            logger.Info("Форма загружена");
        }

        private void increaseBtn_Click(object sender, EventArgs e)
        {
            logger.Info($"Нажата кнопка: {sender.ToString()}");
            int value;
            if (int.TryParse(daysTextBox.Text, out value))
            {
                value++;
                daysTextBox.Text = value.ToString();
            }
        }

        private void decreaseBtn_Click(object sender, EventArgs e)
        {
            logger.Info($"Нажата кнопка: {sender.ToString()}");
            int value;
            if (int.TryParse(daysTextBox.Text, out value))
            {
                value--;
                daysTextBox.Text = value.ToString();
            }
        }
        private void UpdateTable()
        {
            database.OpenConnection();
            DateTime depart;
            int newDays;

            if (DateTime.TryParse(departure, out depart))
            {
                if (int.TryParse(daysTextBox.Text, out newDays))
                {
                    double diff = newDays - days;
                    depart = depart.AddDays(diff);

                    departure = depart.ToShortDateString();
                }
            }
            var changeQuery = $"UPDATE Guests SET departure_date = '{departure}' WHERE ID = '{id}'";

            SqlCommand command = new SqlCommand(changeQuery, database.GetConnection());
            stopwatch.Start();
            int rowsAffected = command.ExecuteNonQuery();
            stopwatch.Stop();
            logger.Trace($"Обновление базы данных завершено. Затронуто строк: {rowsAffected}. Время выполнения(мс): {stopwatch.ElapsedMilliseconds}");
            database.CloseConnection();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            logger.Info($"Нажата кнопка: {sender.ToString()}");
            UpdateTable();
            MessageBox.Show("Данные сохранены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
