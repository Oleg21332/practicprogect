using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ppractic
{
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;userid=root;database=ppractik";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();//соединение с бд

            MySqlCommand command = new MySqlCommand($"insert into book (`id книги`, `Фамилия`, `Имя`, `Отчество`, `Название книги`) values ('{id1.Text}', '{n1.Text}', '{n2.Text}', '{n3.Text}', '{n4.Text}')")
            {
                Connection = connection//команда для заполнения
            };
            command.ExecuteNonQuery();//выполнение команды
            MessageBox.Show("Книга успешно добавлена.Библиотека обновлена.");
            Form1 qwer = new Form1();
            this.Hide();
            qwer.Show();

        }

        private void n1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
