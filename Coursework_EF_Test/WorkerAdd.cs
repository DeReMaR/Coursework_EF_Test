using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_EF_Test
{
    public partial class WorkerAdd : Form
    {
        public WorkerAdd()
        {
            InitializeComponent();
        }

        private void WorkerAdd_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = 1;
            textBox1.Focus(); // при открытии окна, textBox1 получает фокус
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, @"([А-ЯЁ][а-яё]+[\-\s]?){3,}") && textBox1.Text == "")
            {
                button1.Enabled = false;
                MessageBox.Show("Пожалуйста, вводите ФИО полностью. Если у сотрудника отстутствует отчество или присутствуют другие отличия, нажмите 'ОК'.");
                return;
            }
            else
                button1.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Не заполнено поле ФИО");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Не заполнена должность сотрудника");
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                button1.Enabled = false;
            }
            else
                button1.Enabled = true;
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                button1.Enabled = false;
            }
            else
                button1.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                button1.Enabled = false;
            }
            else
                button1.Enabled = true;
        }
    }
}
