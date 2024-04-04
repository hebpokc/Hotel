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
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Main : Form
    {
        System.Timers.Timer timer = new System.Timers.Timer();
        Database database = new Database();
        int selectedRow;
        TimeSpan difference;
        Stopwatch stopwatch = new Stopwatch();
        string fio = "", birthday = "", payment = "", days = "", with_animals = "", id = "", departureDate = "";
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public Main()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Elapsed += timer_Tick;
            timer.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshAllDataGrid(guestsDataGridView);
            guestsDataGridView.Columns[4].Visible = false;
            guestsDataGridView.Columns[5].Visible = false;
            guestsDataGridView.Columns[6].Visible = false;
            guestsDataGridView.Columns[7].Visible = false;
            guestsDataGridView.Columns[8].Visible = false;
            guestsDataGridView.Columns[9].Visible = false;
            guestsDataGridView.Columns[10].Visible = false;
            guestsDataGridView.Columns[11].Visible = false;

            logger.Info("Форма загружена");
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            var str = DateTime.Now.ToString("HH : mm : ss");
            if (labelTime.InvokeRequired) labelTime.Invoke(new Action<string>((s) => labelTime.Text = s), str);
            else labelTime.Text = str;

        }
        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Поиск...")
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = Color.Black;
            }
        }
        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                searchTextBox.Text = "Поиск...";
                searchTextBox.ForeColor = Color.Silver;
            }
        }
        private void CreateColumns()
        {
            guestsDataGridView.Columns.Add("id", "ID");
            guestsDataGridView.Columns.Add("first_name", "Имя");
            guestsDataGridView.Columns.Add("second_name", "Фамилия");
            guestsDataGridView.Columns.Add("patronymic", "Отчество");
            guestsDataGridView.Columns.Add("birthday", "Дата рождения");
            guestsDataGridView.Columns.Add("arrival_date", "Дата заезда");
            guestsDataGridView.Columns.Add("departure_date", "Дата выезда");
            guestsDataGridView.Columns.Add("room", "Комната");
            guestsDataGridView.Columns.Add("status", "Статус");
            guestsDataGridView.Columns.Add("type_of_payment", "Тип оплаты");
            guestsDataGridView.Columns.Add("with_animals", "Есть животное");
            guestsDataGridView.Columns.Add("isNew", string.Empty);

            logger.Info($"Колонки созданы: {guestsDataGridView.Columns[0].HeaderText}, {guestsDataGridView.Columns[1].HeaderText}, {guestsDataGridView.Columns[2].HeaderText}, {guestsDataGridView.Columns[3].HeaderText}, " +
                $"{guestsDataGridView.Columns[4].HeaderText}, {guestsDataGridView.Columns[5].HeaderText}, {guestsDataGridView.Columns[6].HeaderText}, {guestsDataGridView.Columns[7].HeaderText}, {guestsDataGridView.Columns[8].HeaderText}," +
                $"{guestsDataGridView.Columns[9].HeaderText}, {guestsDataGridView.Columns[10].HeaderText}");
        }
        private void ReadRow(DataGridView dgw, IDataRecord record)
        {
            DateTime bday = record.GetDateTime(4);
            DateTime arrival = record.GetDateTime(5);
            DateTime departure = record.GetDateTime(6);

            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), bday.ToShortDateString(), arrival.ToShortDateString(), departure.ToShortDateString(), record.GetInt32(7), record.GetString(8), record.GetString(9), record.GetString(10),RowState.ModifiedNew);

            logger.Info("Колонка прочитана");
        }
        private void RefreshAllDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string query = "";

            if (allRadioButton.Checked)
            {
                query = $"SELECT * FROM Guests";
            }
            if (regRadioButton.Checked)
            {
                query = $"SELECT * FROM Guests WHERE status='Зарезервировано'";
            }
            if (freeRadioButton.Checked)
            {
                query = $"SELECT * FROM Guests WHERE status='Свободные'";
            }
            if (busyRadioButton.Checked)
            {
                query = $"SELECT * FROM Guests WHERE status='Заняты'";
            }
            if (dischargeRadioButton.Checked)
            {
                query = $"SELECT * FROM Guests WHERE status='Выписываются'";
            }
            SqlCommand command = new SqlCommand(query, database.GetConnection());
            database.OpenConnection();
            stopwatch.Start();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadRow(dgw, reader);
            }
            reader.Close();
            stopwatch.Stop();
            logger.Info($"Получено строк из базы данных: {guestsDataGridView.Rows.Count}");
            logger.Trace($"Подключение к источнику данных прошло успешно. Время выполнения(мс): {stopwatch.ElapsedMilliseconds}");
        }
        private void guestsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DateTime arrival;
            DateTime departure;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = guestsDataGridView.Rows[selectedRow];

                statusComboBox.SelectedItem = row.Cells[8].Value.ToString();
                FioTextBox.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString()  + " " + row.Cells[3].Value.ToString();
                arrivalTextBox.Text = row.Cells[5].Value.ToString();
                departureTextBox.Text = row.Cells[6].Value.ToString();
                guestRoomLabel.Text = "Номер комнаты - №" + row.Cells[7].Value.ToString();

                fio = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString() + " " + row.Cells[3].Value.ToString();
                birthday = row.Cells[4].Value.ToString();
                payment = row.Cells[9].Value.ToString();
                with_animals = row.Cells[10].Value.ToString();
                id = row.Cells[0].Value.ToString();
                departureDate = row.Cells[6].Value.ToString();

                if (DateTime.TryParse(arrivalTextBox.Text, out arrival) && DateTime.TryParse(departureTextBox.Text, out departure))
                {
                    difference = departure.Subtract(arrival);
                    days = difference.Days.ToString();
                }
            }
            logger.Info($"Двойное нажатие на ячейку: Строка {e.RowIndex}, Столбец {e.ColumnIndex}");
        }
        private void viewBtn_Click(object sender, EventArgs e)
        {
            logger.Info($"Нажата кнопка: {sender.ToString()}");
            GuestCard guestCard = new GuestCard(fio, birthday, payment, days, with_animals, id, departureDate);
            guestCard.Show();
            logger.Info($"Открыта форма: {guestCard.Name}");
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"SELECT * FROM Guests WHERE CONCAT(id, first_name, second_name, patronymic, birthday, arrival_date, departure_date, room, status, type_of_payment, with_animals) LIKE '%" + searchTextBox.Text + "%'";
            SqlCommand command = new SqlCommand(searchString, database.GetConnection());

            database.OpenConnection();
            stopwatch.Start();
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadRow(dgw, read);
            }

            read.Close();
            stopwatch.Stop();
            logger.Trace($"Поиск по базе данных завершен. Время выполнения(мс): {stopwatch.ElapsedMilliseconds}");
        }
        private void seacrhBtn_Click(object sender, EventArgs e)
        {
            Search(guestsDataGridView);
            logger.Info($"Нажата кнопка: {sender.ToString()}");
        }
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshAllDataGrid(guestsDataGridView);
            logger.Info($"Нажата кнопка: {sender.ToString()}");
        }
        private void UpdateTable()
        {
            database.OpenConnection();

            for (int index = 0; index < guestsDataGridView.Rows.Count; index++)
            {
                var rowState = (RowState)guestsDataGridView.Rows[index].Cells[11].Value;

                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Modified)
                {
                    var id = guestsDataGridView.Rows[index].Cells[0].Value.ToString();
                    var status = guestsDataGridView.Rows[index].Cells[8].Value.ToString();
                    var changeQuery = $"UPDATE Guests SET status = '{status}' WHERE ID = '{id}'";

                    SqlCommand command = new SqlCommand(changeQuery, database.GetConnection());
                    stopwatch.Start();
                    int rowsAffected = command.ExecuteNonQuery();
                    stopwatch.Stop();
                    logger.Trace($"Обновление базы данных завершено. Затронуто строк: {rowsAffected}. Время выполнения(мс): {stopwatch.ElapsedMilliseconds}");
                }
            }

            database.CloseConnection();
        }
        private void Change()
        {
            var selectedRowIndex = guestsDataGridView.CurrentCell.RowIndex;
            var status = statusComboBox.SelectedItem;

            if (guestsDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                guestsDataGridView.Rows[selectedRowIndex].Cells[8].Value = status;
                guestsDataGridView.Rows[selectedRowIndex].Cells[11].Value = RowState.Modified;
            }
        }
        private void changeStatusBtn_Click(object sender, EventArgs e)
        {
            logger.Info($"Нажата кнопка: {sender.ToString()}");
            Change();
            UpdateTable();
            MessageBox.Show("Статус изменен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            logger.Info($"Успешное изменение статуса");
        }
    }
}
