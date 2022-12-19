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
    public partial class EditingModeTarif : Form
    {
        public EditingModeTarif()
        {
            InitializeComponent();
        }

        string _tableName = "Тарифы";

        private void EditingModeTarif_Load(object sender, EventArgs e)
        {
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            dataGridView1.DataSource = manager.GetDataTable(_tableName);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string[] args = new string[2];
            args[0] = Convert.ToString(dataGridView1.CurrentRow.Cells["Вид тарифа"].Value);
            args[1] = Convert.ToString(dataGridView1.CurrentRow.Cells["Стоимость тарифа"].Value);
            this.Hide();
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Update(args, _tableName);
            EditingModeTarif editingModeTarif = new EditingModeTarif();
            editingModeTarif.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Код тарифа"].Value);
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Delete(number, _tableName);
            this.Hide();
            EditingModeTarif editingModeTarif = new EditingModeTarif();
            editingModeTarif.Show();
        }

        private void Exite_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tarif tarif = new Tarif();
            tarif.Show();
        }
    }
}
