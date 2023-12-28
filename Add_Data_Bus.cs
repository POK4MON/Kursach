using courseDataBase.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseDataBase
{
    public partial class Add_Data_Bus : Form
    {
        DataBase dataBase = new DataBase();

        public Add_Data_Bus()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // стартовая позиция окна (центр)
        }

        private void BUT_Save_Click(object sender, EventArgs e)
        {
            // создаём соединение с db
            dataBase.openConnection();

            var FIO = textBox_tutor_FIO.Text;
            var phone = textBox_tutor_PHONE.Text;
            int grade;

            if (int.TryParse(textBox_tutor_GRADE.Text, out grade))
            {
                // создаём запрос на отправку данных в DB
                var querystring = $"insert into tutor (FIO, phone, grade) values ('{FIO}','{phone}','{grade}')";

                // вносим запрос в DB
                var command = new SqlCommand(querystring, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Оценка должна быть записана в числовом формате", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox_tutor_GRADE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
