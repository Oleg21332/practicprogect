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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            add qwe = new add();
            this.Hide();
            qwe.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;userid=root;database=ppractik";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();//соединение с бд

            MySqlCommand command1 = new MySqlCommand("DELETE FROM `book` where `id книги` =@id", connection);
            command1.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(iddel.Text);
            command1.ExecuteNonQuery();//выполнение команды
            MessageBox.Show("Книга удалена успешно", "Информация");
            connection.Close();
            Form1 sc = new Form1();
            sc.Show();
            this.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            try 
            {
                Form1 main = this.Owner as Form1;
                if (main != null)
                {
                    for (int i = 0; i < main.dataGridView1.RowCount; i++)
                    {
                        main.dataGridView1.Rows[i].Selected = false;
                        for (int j = 0; j < main.dataGridView1.ColumnCount; j++)
                            if (main.dataGridView1.Rows[i].Cells[j].Value != null)
                                if (main.dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(ssearch.Text))
                                {
                                    main.dataGridView1.Rows[i].Selected = true;
                                    break;
                                }
                    }
                }

            }
            catch
            {
                MessageBox.Show("Введите значение");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ppractikDataSet.book". При необходимости она может быть перемещена или удалена.
            this.bookTableAdapter.Fill(this.ppractikDataSet.book);

        }

        private void closed_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ssearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
