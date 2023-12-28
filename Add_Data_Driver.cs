using courseDataBase.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace courseDataBase
{
    public partial class Add_Data_Driver : Form
    {
        DataBase dataBase = new DataBase();
        OpenFileDialog openFileDialog = new OpenFileDialog();

        public Add_Data_Driver()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // стартовая позиция окна (центр)
        }

        private void BUT_Save_Click(object sender, EventArgs e)
        {
            // создаём соединение с db
            dataBase.openConnection();

            InsertImage();

            var fio = textBox_FIO.Text;
            int phone;
            if (int.TryParse(textBox_PHONE.Text, out phone))
            {
                // создаём соединение с базой данных
                dataBase.openConnection();

                // создаём запрос на отправку данных в БД
                var querystring = "INSERT INTO student (fio, phone,photo) " +
                                  "VALUES (@fio, @phone, @photo)";

                // создание экземпляра команды и передача строки запроса и соединения
                var command = new SqlCommand(querystring, dataBase.getConnection());

                // добавление параметров в команду
                command.Parameters.AddWithValue("@fio", fio);
                command.Parameters.AddWithValue("@phone", phone);

                // добавление параметра изображения
                var photo = new Bitmap(pb_show.Image);
                using (var memoryStream = new MemoryStream())
                {
                    photo.Save(memoryStream, ImageFormat.Jpeg);
                    memoryStream.Position = 0;
                    command.Parameters.AddWithValue("@photo", memoryStream.ToArray());
                }

                // выполнение команды на добавление записи в БД
                command.ExecuteNonQuery();

                // закрытие соединения с базой данных
                dataBase.closeConnection();

                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Зарплата и id-автобуса должны иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void InsertImage()
        {
            pb_show.SizeMode = PictureBoxSizeMode.StretchImage;

            openFileDialog.Filter = "Image Files(*.JPG,*.JPEG,*.PNG)|*.JPG;*.JPEG;*.PNG"; //формат загружаемого файла

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pb_show.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void textBox_FIO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

