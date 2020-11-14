using Coursework_EF_Test.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Coursework_EF_Test
{
    public partial class Form1 : Form
    {
        AccountModelContainer db;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new AccountModelContainer();
            db.WorkerSet.Load();
            dataGridView1.DataSource = db.WorkerSet.Local.ToBindingList();
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            // создать фильтр, который выведет в dataGridView2 то что нужно
            int id;
            int index;

            index = dataGridView1.CurrentRow.Index;

            // взять значения id = Worker.ID_Worker
            id = (int)dataGridView1.Rows[index].Cells[0].Value;
            accountBindingSource.Filter = "WorkerID_Worker = " + id.ToString();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // создать фильтр, который выведет в dataGridView2 то что нужно
            int id;
            int index;

            index = dataGridView1.CurrentRow.Index;

            // взять значения id = Worker.ID_Worker
            id = (int)dataGridView1.Rows[index].Cells[0].Value;
            accountBindingSource.Filter = "WorkerID_Worker = " + id.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkerAdd f = new WorkerAdd(); //создать форму
            if (f.ShowDialog() == DialogResult.OK) // отобразить форму
            {
                // если OK, то добавить работника
                string UWName, UWPosition, UWSex;

                UWName = f.textBox1.Text;
                UWPosition = f.textBox2.Text;
                UWSex = f.comboBox1.Items[f.comboBox1.SelectedIndex].ToString();

                //Добавление и обработка исклюяения
                try
                {
                    Worker a_worker = new Worker
                    {
                        WName = UWName,
                        WPosition = UWPosition,
                        WSex = UWSex
                    };
                    db.WorkerSet.Add(a_worker);
                    db.SaveChanges();

                }
                catch (Exception)
                {

                    MessageBox.Show("Вы ввели некорректные данные или не заполнили обязательные поля.");
                    return;
                }


            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
    
    


