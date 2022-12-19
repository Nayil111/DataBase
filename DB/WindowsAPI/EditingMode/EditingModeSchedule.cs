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
    public partial class EditingModeSchedule : Form
    {
        public EditingModeSchedule()
        {
            InitializeComponent();
        }

        string _tableName = "Расписание";

        private void EditingModeSchedule_Load(object sender, EventArgs e)
        {
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            dataGridView1.DataSource = manager.GetDataTable(_tableName);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string[] args = new string[3];
            args[0] = _tableName;
            args[1] = _tableName;
            args[2] = _tableName;
            //dataGridView1.DataSource = args;
            this.Hide();
            EditingModeSchedule editingModeSchedule = new EditingModeSchedule();
            editingModeSchedule.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            int number = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Код дня"].Value);
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Delete(number, _tableName);


            this.Hide();
            EditingModeSchedule editingModeSchedule = new EditingModeSchedule();
            editingModeSchedule.Show();
        }

        private void Exite_Click(object sender, EventArgs e)
        {
            this.Hide();
            Schedule schedule = new Schedule();
            schedule.Show();
        }
    }
}
