using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using courseDataBase.Connection;
using System.Drawing;
using System.IO;

namespace courseDataBase
{
    enum RowState
    {
        Existed,
        Nes,
        Modfield,
        ModfieldNew,
        Deleted,
        Decoration,
        Confirmed
    }

    public partial class AdminPage : Form
    {
        DataBase database = new DataBase();

        int selectedRow;
        int selectedIdStudent;
        int selectedRowTutor;
        int selectedIdImage;
        int selectedColumnValue;
        public AdminPage()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // стартовая позиция окна (центр)
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            CreateColums();
            RefreshDataGrid(dataGridView1);

            CreateColumsCur_tutors();
            RefreshDataGridCur_tutors(dataGridView2_tutor);

            CreateColumsCur_student();
            RefreshDataGridCur_student(dataGridView_student);

            CreateColumsTutor();
            RefreshDataGridTutor(dataGridView3_phone);

            CreateColumsConfirmDepositing();
            RefreshDataGridConfirmDepositing(dataGridView_Confirm_Depositing);
        }

        private void BUT_Refresh_Click(object sender, EventArgs e) // кнопка обновления информации в dataGridView
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void BUT_refresh_confirm_passingthecourse_Click(object sender, EventArgs e)
        {
            RefreshDataGridCur_tutors(dataGridView_Confirm_Depositing);
        }

        private void BUT_NewPost_Click(object sender, EventArgs e) // кнопка создания новой записи
        {
            Add_Data add_Data = new Add_Data();
            add_Data.Show();
        }

        private void BUT_Delete_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ClearFields();
        }

        private void BUT_Save_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void BUT_Change_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void BUT_ClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void textBox_SEARCH_TextChanged(object sender, EventArgs e) // текстовое поле для осуществление поиска по DataGridView1
        {
            Search(dataGridView1);
        }

        private void textBox_turtor_SEARCH_TextChanged(object sender, EventArgs e)
        {
            SearchStudent(dataGridView_student);
        }

        private void BUT_tutor_NewPost_Click_1(object sender, EventArgs e)
        {
            Add_Data_Bus add_Data_Bus = new Add_Data_Bus();
            add_Data_Bus.Show();
        }

        private void BUT_tutor_Delete_Click(object sender, EventArgs e)
        {
            DeleteRowTutor();
            ClearFieldsTutor();
        }

        private void BUT_tutor_Change_Click(object sender, EventArgs e)
        {
            ChangeTutor();
            ClearFieldsTutor();
        }

        private void BUT_tutor_Save_Click(object sender, EventArgs e)
        {
            UpdateStudent();
        }
        private void textBox_tutor_SEARCH_TextChanged(object sender, EventArgs e)
        {
            Search_Tutor(dataGridView2_tutor);
        }

        private void BUT_tutor_Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridTutor(dataGridView2_tutor);
            ClearFieldsTutor();
        }

        private void BUT_student_Delete_Click(object sender, EventArgs e)
        {
            DeleteRowStudent();
            ClearFieldsStudent();
        }

        private void BUT_student_Change_Click(object sender, EventArgs e)
        {
            ChangeStudent();
            ClearFieldsStudent();
        }

        private void BUT_student_Save_Click(object sender, EventArgs e)
        {
            UpdateStudent();
        }
    

        private void BUT_student_ClearField_Click(object sender, EventArgs e)
        {
            ClearFieldsStudent();
        }

        private void BUT_student_Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridCur_student(dataGridView_student);
            ClearFieldsStudent();
        }

        private void BUT_confirm_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var status = "Подтверждено";

            var changeQuery = $"UPDATE depositingg set confirm = '{status}' where id = '{selectedColumnValue}'";

            var command = new SqlCommand(changeQuery, database.getConnection());
            command.ExecuteNonQuery();

            RefreshDataGridConfirmDepositing(dataGridView_Confirm_Depositing);

            database.closeConnection();
        }

        private void BUT_cancel_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var status = "Отклонено";

            var changeQuery = $"UPDATE depositingg set confirm = '{status}' where id = '{selectedColumnValue}'";

            var command = new SqlCommand(changeQuery, database.getConnection());
            command.ExecuteNonQuery();

            RefreshDataGridConfirmDepositing(dataGridView_Confirm_Depositing);

            database.closeConnection();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textBox_ID.Text;
            var acceptedd = textBox_ACCEPTEDD.Text;
            var accpetedc = textBox_ACCEPTEDC.Text;
            var grade = textBox_GRADE.Text;
            var course = textBox_COURSE.Text;
            var student = textBox_STUDENT.Text;
            int idTutor;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox_IDTUTOR.Text, out idTutor))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, acceptedd, accpetedc, grade, course, student, idTutor);
                    dataGridView1.Rows[selectedRowIndex].Cells[6].Value = RowState.Modfield;
                }
                else
                    MessageBox.Show("id-преопдователя должен иметь числовое значение!");
            }
        }

        private void ChangeTutor()
        {
            var selectedRowIndex = dataGridView2_tutor.CurrentCell.RowIndex;

            var idtutor = textBox_tutor_ID.Text;
            var FIO = textBox_tutor_FIO.Text;
            int phone;

            if (dataGridView2_tutor.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox_tutor_PHONE.Text, out phone))
                {
                    dataGridView2_tutor.Rows[selectedRowIndex].SetValues(idtutor, FIO, phone);
                    dataGridView2_tutor.Rows[selectedRowIndex].Cells[2].Value = RowState.Modfield;
                }
                else
                    MessageBox.Show("Номер телефона должен иметь числовое значение!");
            }
        }

        private void ChangeStudent()
        {
            var selectedRowIndex = dataGridView_student.CurrentCell.RowIndex;

            var student = textBox_student_ID.Text;
            var fio = textBox_student_FIO.Text;
            int phone;

            if (dataGridView_student.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox_student_PHONE.Text, out phone))
                {
                    dataGridView_student.Rows[selectedRowIndex].SetValues(student, fio, phone);
                    dataGridView_student.Rows[selectedRowIndex].Cells[2].Value = RowState.Modfield;
                }
                else
                    MessageBox.Show("Номер телефона должен иметь числовое значнеие!");
            }
        }

        private void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[6].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuerry = $"DELETE FROM courseswork WHERE id = {id}";

                    var command = new SqlCommand(deleteQuerry, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modfield)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var acceptedd = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var acceptedc = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var grade = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var course = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var student = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var IdTutor = dataGridView1.Rows[index].Cells[6].Value.ToString();

                    var changeQuery = $"UPDATE courseswork SET acceptedd = '{acceptedd}', acceptedc = '{acceptedc}', grade = '{grade}', course = '{course}', student = '{student}', idtutor = '{IdTutor}',  WHERE id = '{id}'";

                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }

            database.closeConnection();
        }

        private void UpdateTutor()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView2_tutor.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView2_tutor.Rows[index].Cells[2].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView2_tutor.Rows[index].Cells[0].Value);
                    var deleteQuerry = $"DELETE FROM tutor WHERE id = {id}";

                    var command = new SqlCommand(deleteQuerry, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modfield)
                {
                    var id = dataGridView2_tutor.Rows[index].Cells[0].Value.ToString();
                    var fio = dataGridView2_tutor.Rows[index].Cells[1].Value.ToString();
                    var phone = dataGridView2_tutor.Rows[index].Cells[2].Value.ToString();

                    var changeQuery = $"update tutor set fio = '{fio}', phone = '{phone}', where id = '{id}'";

                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }

            database.closeConnection();
        }

        private void UpdateStudent()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView_student.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView_student.Rows[index].Cells[4].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView_student.Rows[index].Cells[0].Value);
                    var deleteQuerry = $"DELETE FROM student WHERE id = {id}";

                    var command = new SqlCommand(deleteQuerry, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modfield)
                {
                    var id = dataGridView_student.Rows[index].Cells[0].Value.ToString();
                    var fio = dataGridView_student.Rows[index].Cells[1].Value.ToString();
                    var phone = dataGridView_student.Rows[index].Cells[2].Value.ToString();
                    var idStudent = dataGridView_student.Rows[index].Cells[3].Value.ToString();

                    var changeQuery = $"UPDATE student SET fio = '{fio}', phone = '{phone}',idStudent = '{idStudent}' WHERE id = '{id}'";

                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }

            database.closeConnection();
        }


        private void ClearFields()
        {
            textBox_ID.Text = string.Empty;
            textBox_ACCEPTEDD.Text = string.Empty;
            textBox_ACCEPTEDC.Text = string.Empty;
            textBox_GRADE.Text = string.Empty;
            textBox_COURSE.Text = string.Empty;
            textBox_ID.Text = string.Empty;
        }

        private void ClearFieldsTutor()
        {
            textBox_tutor_ID.Text = string.Empty;
            textBox_tutor_FIO.Text = string.Empty;
            textBox_tutor_PHONE.Text = string.Empty;
        }

        private void ClearFieldsStudent()
        {
            textBox_student_ID.Text = string.Empty;
            textBox_student_FIO.Text = string.Empty;
            textBox_student_PHONE.Text = string.Empty;
        }

        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted; // изменение состояние записи
            }
        }

        private void DeleteRowTutor()
        {
            int index = dataGridView3_phone.CurrentCell.RowIndex;

            dataGridView3_phone.Rows[index].Visible = false;

            if (dataGridView3_phone.Rows[index].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView3_phone.Rows[index].Cells[2].Value = RowState.Deleted; // изменение состояние записи
            }
        }

        private void DeleteRowStudent()
        {
            int index = dataGridView_student.CurrentCell.RowIndex;

            dataGridView_student.Rows[index].Visible = false;

            if (dataGridView_student.Rows[index].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView_student.Rows[index].Cells[2].Value = RowState.Deleted; // изменение состояние записи
            }
        }

        private void Search(DataGridView dgw) // поиск
        {
            dgw.Rows.Clear();
            string searchString = $"SELECT * FROM courseswork WHERE concat (id, accseptedd, acceptedc, student, course, grade, idTutor) like '%" + textBox_SEARCH.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, database.getConnection());

            database.openConnection();

            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }

        private void Search_Tutor(DataGridView dgw) // поиск
        {
            dgw.Rows.Clear();
            string searchString = $"SELECT * FROM tutor WHERE concat (fio, phone) like '%" + textBox_tutor_SEARCH.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, database.getConnection());

            database.openConnection();

            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRowCur_tutor(dgw, read);
            }

            read.Close();
        }

        private void SearchStudent(DataGridView dgw) // поиск
        {
            dgw.Rows.Clear();
            string searchString = $"SELECT * FROM student WHERE concat (id, fio, phone) like '%" + textBox_student_SEARCH.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, database.getConnection());

            database.openConnection();

            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRowCur_student(dgw, read);
            }

            read.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // вывод информации из dataGridView1 по нажатию в textBox'ы
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_ID.Text = row.Cells[0].Value.ToString();
                textBox_ACCEPTEDD.Text = row.Cells[1].Value.ToString();
                textBox_ACCEPTEDC.Text = row.Cells[2].Value.ToString();
                textBox_GRADE.Text = row.Cells[3].Value.ToString();
                textBox_COURSE.Text = row.Cells[4].Value.ToString();

            }
        }

        private void dataGridView2_tutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2_tutor.Rows[selectedRow];

                textBox_tutor_ID.Text = row.Cells[0].Value.ToString();
                textBox_tutor_FIO.Text = row.Cells[1].Value.ToString();
                textBox_tutor_PHONE.Text = row.Cells[2].Value.ToString();

                selectedIdStudent = int.Parse(row.Cells[0].Value.ToString());
            }

            string searchString = $"SELECT * FROM cur_tutors WHERE id = '{selectedRowTutor}'";

            SqlCommand command = new SqlCommand(searchString, database.getConnection());

            database.openConnection();

            SqlDataReader read = command.ExecuteReader();

            dataGridView3_phone.Rows.Clear();

            while (read.Read())
            {
                ReadSingleRow(dataGridView3_phone, read);
            }

            read.Close();
        }

        private void dataGridView_tutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowTutor = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2_tutor.Rows[selectedRowTutor];

                textBox_tutor_ID.Text = row.Cells[0].Value.ToString();
                textBox_tutor_FIO.Text = row.Cells[1].Value.ToString();
                textBox_tutor_PHONE.Text = row.Cells[2].Value.ToString();
                selectedIdImage = int.Parse(row.Cells[0].Value.ToString());
            }

            string searchString = $"SELECT * FROM tutor WHERE id = '{selectedRowTutor}'";
            string searchStringImage = $"SELECT photo FROM student WHERE id = '{selectedIdImage}'";

            SqlCommand command = new SqlCommand(searchString, database.getConnection());

            database.openConnection();

            SqlDataReader read = command.ExecuteReader();

            dataGridView_student_PHONE.Rows.Clear();

            while (read.Read())
            {
                ReadSingleRowTutor(dataGridView_student_PHONE, read);
            }

            read.Close();

            database.closeConnection();

            // --------------------- выгрузка фото из DB --------------------- //

            SqlCommand command1 = new SqlCommand(searchStringImage, database.getConnection());

            database.openConnection();

            SqlDataReader readImage = command1.ExecuteReader();

            pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage;

            if (readImage.Read())
            {
                byte[] byteArray = (byte[])readImage["photo"];

                using (var ms = new MemoryStream(byteArray))
                {
                    Bitmap image = new Bitmap(ms);
                    pbPhoto.Image = image;
                }
            }
            readImage.Close();
            database.closeConnection();


            // ---------------------        конец        --------------------- //

        }

        private void CreateColums() // инициализация столбцов для dataGridView1
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("accseptedd", "Дата принятия к исполнению");
            dataGridView1.Columns.Add("acceptedc", "Дата сдачи");
            dataGridView1.Columns.Add("student", "Студент");
            dataGridView1.Columns.Add("course", "Курс");
            dataGridView1.Columns.Add("grade", "Оценка");
            dataGridView1.Columns.Add("idTutor", "id-преподователя");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void CreateColumsCur_student() // инициализация столбцов для dataGridView3_Student
        {
            dataGridView_student.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView_student.Columns.Add("id", "id");
            dataGridView_student.Columns.Add("fio", "ФИО");;
            dataGridView_student.Columns.Add("curse", "Курс");
            dataGridView_student.Columns.Add("facultet", "Факультет студента");
            dataGridView_student.Columns.Add("IsNew", String.Empty);
        }

        private void CreateColumsTutor() // инициализация столбцов для dataGridView_Tutor
        {
           dataGridView3_phone.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView3_phone.Columns.Add("id", "id");
            dataGridView3_phone.Columns.Add("fio", "ФИО");
            dataGridView3_phone.Columns.Add("phone", "Ном.телефона");
            dataGridView3_phone.Columns.Add("IsNew", String.Empty);
        }

        private void CreateColumscoCoursewok() // инициализация столбцов для dataGridView2_Coursework
        {
            dataGridView2_tutor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView2_tutor.Columns.Add("id", "id");
            dataGridView2_tutor.Columns.Add("date_", "Дата выдачи");
            dataGridView2_tutor.Columns.Add("acceptedD", "Принято на кафедре ");
            dataGridView2_tutor.Columns.Add("acceptedC", "Приянято к исполнению");
            dataGridView2_tutor.Columns.Add("IsNew", String.Empty);
        }

        private void CreateColumsCur_tutors() // инициализация столбцов для dataGridView_Passing_the_course
        {
            dataGridView2_tutor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView2_tutor.Columns.Add("id", "id");
            dataGridView2_tutor.Columns.Add("fio", "ФИО");
            dataGridView2_tutor.Columns.Add("discipline", "Дисциплина");
            dataGridView2_tutor.Columns.Add("IsNew", String.Empty);
        }

        private void CreateColumsConfirmDepositing() // инициализация столбцов для dataGridView_Confirm_Depositing
        {
            dataGridView_Confirm_Depositing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView_Confirm_Depositing.Columns.Add("id", "id Сдачи курсовых");
            dataGridView_Confirm_Depositing.Columns.Add("id_coursework", "id Курсовой работы");
            dataGridView_Confirm_Depositing.Columns.Add("date_give", "Дата получения");
            dataGridView_Confirm_Depositing.Columns.Add("date_deposting", "Дата сдачи на хранение");
            dataGridView_Confirm_Depositing.Columns.Add("fio", "ФИО");
            dataGridView_Confirm_Depositing.Columns.Add("grade", "Оценка");
            dataGridView_Confirm_Depositing.Columns.Add("confirm", "Дата принятия на хранение");
            dataGridView_Confirm_Depositing.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), RowState.ModfieldNew);
        }

        private void ReadSingleRowCur_student(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), RowState.ModfieldNew);
        }

        private void ReadSingleRowTutor(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModfieldNew);
        }

        private void ReadSingleRowConfirmDeposting(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6));
        }
        private void ReadSingleRowCur_tutor(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModfieldNew);
        }
        private void ReadSingleRowConfirmCur_tutors(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModfieldNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from courseswork";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void RefreshDataGridCur_student(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from cur_student";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowCur_student(dgw, reader);
            }
            reader.Close();
        }

        private void RefreshDataGridTutor(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from tutor";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowTutor(dgw, reader);
            }
            reader.Close();
        }

        private void RefreshDataGridCur_tutors(DataGridView dgw_Passingthecourse)
        {
            dgw_Passingthecourse.Rows.Clear();

            string queryString = $"select * from cur_tutors";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowConfirmCur_tutors(dgw_Passingthecourse, reader);
            }
            reader.Close();
        }
        private void RefreshDataGridConfirmDepositing(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from depositingg";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowConfirmDeposting(dgw, reader);
            }
            reader.Close();
        }

        private void dataGridView2_tutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void BUT_student_NewPost_Click(object sender, EventArgs e)
        {
            Add_Data_Driver add_Data_Driver = new Add_Data_Driver();
            add_Data_Driver.Show();
        }
    }
}
