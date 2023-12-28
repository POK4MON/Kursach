using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using courseDataBase.Connection;

namespace courseDataBase
{
    public partial class Add_Data : Form
    {
        DataBase dataBase = new DataBase();

        public Add_Data()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // стартовая позиция окна (центр)
        }

        private void BUT_Save_Click(object sender, EventArgs e)
        {
            // создаём соединение с db
            dataBase.openConnection();

            var id = textBox_ID.Text;
            var acceptedd = textBox_ACCEPTEDD.Text;
            var acceptedc = textBox_ACCEPTEDC.Text;
            var student = textBox_STUDENT.Text;
            var course = textBox_COURSE.Text;
            int grade; int idTutor;

            if(int.TryParse(textBox_GRADE.Text, out grade) && int.TryParse(textBox_IDTUTOR.Text, out idTutor)) 
            {
                // создаём запрос на отправку данных в DB
                var querystring = $"insert into courseswork (id, accseptedd, acceptedc, student, course, grade, idTutor) values ('{id}','{acceptedd}','{acceptedc}','{student}','{course}','{grade}', '{idTutor}')";

                // вносим запрос в DB
                var command = new SqlCommand(querystring, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Оценка и id_преподователя должны быть записаны в числовой форме!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox_COURSE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
