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
    public partial class WorkerEdit : Form
    {
        public WorkerEdit()
        {
            InitializeComponent();
        }

        private void WorkerEdit_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Не заполнено поле ФИО");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Не заполнена должность сотрудника");
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, @"([А-ЯЁ][а-яё]+[\-\s]?){3,}"))
            {
                MessageBox.Show("Пожалуйста, вводите ФИО полностью. Если у сотрудника отстутствует отчество или присутствуют другие отличия, нажмите 'ОК'.");
            }
        }
    }
}
