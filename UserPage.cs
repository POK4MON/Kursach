using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using courseDataBase.Connection;
using System.Drawing;
using System.IO;

namespace courseDataBase
{
    public partial class UserPage : Form
    {
        DataBase dataBase = new DataBase();
        Sign_in signIn = new Sign_in();
        public UserPage()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // стартовая позиция окна (центр)
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            CreateColums();
            RefreshDataGrid(dataGridView_route);

            CreateColumsControl();
            RefreshDataGrid_Control(dataGridView_control);
        }

        private void BUT_BuyTicket_Click(object sender, EventArgs e)
        {
            int index = dataGridView_route.CurrentCell.RowIndex;

            var idRoute = dataGridView_route.Rows[index].Cells[0].Value.ToString();
            var idClient = signIn.id_user;
            var numberRoute = dataGridView_route.Rows[index].Cells[1].Value.ToString();
            var cityStart = dataGridView_route.Rows[index].Cells[2].Value.ToString();
            var cityFinish = dataGridView_route.Rows[index].Cells[3].Value.ToString();
            var timeTravel = dataGridView_route.Rows[index].Cells[4].Value.ToString();
            var date = dataGridView_route.Rows[index].Cells[5].Value.ToString();
            var price = dataGridView_route.Rows[index].Cells[6].Value.ToString();
            var status = "Ожидает подтверждения";

            // создаём соединение с db
            dataBase.openConnection();

            // создаём запрос на отправку данных в DB
            var querystring = $"insert into Course_work (id_route, id_client, number_route, city_start, city_finish, time_travel, date_, price, confirm) values ('{idRoute}','{idClient}','{numberRoute}','{cityStart}','{cityFinish}','{timeTravel}','{date}','{price}','{status}')";

            // вносим запрос в DB
            var command = new SqlCommand(querystring, dataBase.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Транзакция создана!", "Ожидайте подтверждения!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CreateColums() // инициализация столбцов для dataGridView_route
        {
            dataGridView_route.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView_route.Columns.Add("id", "id");
            dataGridView_route.Columns.Add("number_route", "Номер Маршрута");
            dataGridView_route.Columns.Add("city_start", "Выезд");
            dataGridView_route.Columns.Add("city_finish", "Конченая");
            dataGridView_route.Columns.Add("time_travel", "Длительность Маршрута");
            dataGridView_route.Columns.Add("date_", "Время отправления");
            dataGridView_route.Columns.Add("price", "Стоимость");
        }

        private void CreateColumsControl() // инициализация столбцов для dataGridView_control
        {
            dataGridView_control.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView_control.Columns.Add("id", "id Транзакции");
            dataGridView_control.Columns.Add("id_route", "id Маршрута");
            dataGridView_control.Columns.Add("id_client", "id Клиента");
            dataGridView_control.Columns.Add("number_route", "Номер Маршрута");
            dataGridView_control.Columns.Add("city_start", "Откуда");
            dataGridView_control.Columns.Add("city_finish", "Куда");
            dataGridView_control.Columns.Add("time_travel", "Длительность Маршрута");
            dataGridView_control.Columns.Add("date_", "Время отправления");
            dataGridView_control.Columns.Add("price", "Стоимость");
            dataGridView_control.Columns.Add("confirm", "Статус");
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from route";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void RefreshDataGrid_Control(DataGridView dgw)
        {
            dgw.Rows.Clear();

            var idClient = signIn.id_user;

            string queryString = $"SELECT * FROM transation WHERE id_client = {idClient}";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowControl(dgw, reader);
            }
            reader.Close();
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetInt32(6));
        }

        private void ReadSingleRowControl(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), record.GetString(7), record.GetInt32(8), record.GetString(9));
        }

        //dataGridView_control.Columns.Add("id", "id");+
        //dataGridView_control.Columns.Add("confirm", "Статус");+
        //dataGridView_control.Columns.Add("number_route", "Номер Маршрута");+
        //dataGridView_control.Columns.Add("register_number", "Номер Автобуса");+
        //dataGridView_control.Columns.Add("city_start", "Выезд");+
        //dataGridView_control.Columns.Add("city_finish", "Конченая");+
        //dataGridView_control.Columns.Add("time_travel", "Длительность Маршрута");+
        //dataGridView_control.Columns.Add("date_", "Время отправления");
        //dataGridView_control.Columns.Add("price", "Стоимость");

        private void textBox_SEARCH_FROM_TextChanged(object sender, EventArgs e)
        {
            SearchFrom(dataGridView_route);
        }

        private void textBox_SEARCH_WHERE_TextChanged(object sender, EventArgs e)
        {
            SearchWhere(dataGridView_route);
        }

        private void SearchFrom(DataGridView dgw) // поиск "Откуда"
        {
            dgw.Rows.Clear();
            string searchString = $"select * from route where (city_start) like '%" + textBox_SEARCH_WHERE.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }

        private void SearchWhere(DataGridView dgw) // поиск "Куда"
        {
            dgw.Rows.Clear();
            string searchString = $"select * from route where (city_finish) like '%" + textBox_SEARCH_WHERE.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }
    }
}
