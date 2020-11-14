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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountDataSet.AccountSet". При необходимости она может быть перемещена или удалена.
            this.accountSetTableAdapter.Fill(this.accountDataSet.AccountSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountDataSet.WorkerSet". При необходимости она может быть перемещена или удалена.
            this.workerSetTableAdapter.Fill(this.accountDataSet.WorkerSet);

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            // создать фильтр, который выведет в dataGridView2 то что нужно
            int id;
            int index;

            index = dataGridView1.CurrentRow.Index;

            // взять значения id = Worker.ID_Worker
            id = (int)dataGridView1.Rows[index].Cells[0].Value;
            accountSetBindingSource.Filter = "WorkerID_Worker = " + id.ToString();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // создать фильтр, который выведет в dataGridView2 то что нужно
            int id;
            int index;

            index = dataGridView1.CurrentRow.Index;

            // взять значения id = Worker.ID_Worker
            id = (int)dataGridView1.Rows[index].Cells[0].Value;
            accountSetBindingSource.Filter = "WorkerID_Worker = " + id.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
