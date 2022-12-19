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
using WindowsAPI.EditingMode;

namespace WindowsAPI.DataBaseEditor
{
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
        }

        string _tableName = "Преподователя";

        private void Main_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            dataGridView1.DataSource = manager.GetDataTable(_tableName);
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            string[] args = new string[3];
            args[0] = textBox1.Text;
            args[1] = textBox2.Text;
            args[2] = textBox3.Text;

            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Insert(args, _tableName);

            this.Hide();
            Teachers teachers = new Teachers();
            teachers.Show();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);

            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Delete(number, _tableName);

            this.Hide();
            Teachers teachers = new Teachers();
            teachers.Show();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditingModeTeachers editingModeTeachers = new EditingModeTeachers();
            editingModeTeachers.Show();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);

            string[] args = new string[1];
            args[0] = textBox3.Text;

            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Update(args, number, _tableName);

            this.Hide();
            Teachers teachers = new Teachers();
            teachers.Show();
        }
    }
}
