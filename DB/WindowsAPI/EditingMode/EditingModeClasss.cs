using DataBaseLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAPI.DataBaseEditor;

namespace WindowsAPI.EditingMode
{
    public partial class EditingModeClasss : Form
    {
        public EditingModeClasss()
        {
            InitializeComponent();
        }

        string _tableName = "Классы";

        private void EditingModeClasss_Load(object sender, EventArgs e)
        {
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            dataGridView1.DataSource = manager.GetDataTable(_tableName);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string[] args = new string[2];
            args[0] = _tableName;
            args[1] = _tableName;
            //dataGridView1.DataSource = args;
            this.Hide();
            EditingModeClasss editingModeClasss = new EditingModeClasss();
            editingModeClasss.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Код класса"].Value);
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Delete(number, _tableName);

            this.Hide();
            EditingModeClasss editingModeClasss = new EditingModeClasss();
            editingModeClasss.Show();
        }

        private void Exite_Click(object sender, EventArgs e)
        {
            this.Hide();
            classs classs1 = new classs();
            classs1.Show();
        }
    }
}
