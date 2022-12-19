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
    public partial class EditingModeTeachers : Form
    {
        public EditingModeTeachers()
        {
            InitializeComponent();
        }

        string _tableName = "Преподователя";

        private void Save_Click(object sender, EventArgs e)
        {
            string[] args = new string[2];
            args[0] = _tableName;
            args[1] = _tableName;
            this.Hide();
            EditingModeTeachers editingModeTeachers = new EditingModeTeachers();
            editingModeTeachers.Show();
        }

        private void EditingModeTeachers_Load(object sender, EventArgs e)
        {
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            dataGridView1.DataSource = manager.GetDataTable(_tableName);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Код преподователя"].Value);
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Delete(number, _tableName);

            this.Hide();
            EditingModeTeachers editingModeTeachers = new EditingModeTeachers();
            editingModeTeachers.Show();
        }

        private void Exite_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teachers teachers = new Teachers();
            teachers.Show();
        }
    }
}
