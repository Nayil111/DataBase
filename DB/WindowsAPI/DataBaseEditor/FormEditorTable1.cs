using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseLib;
using WindowsAPI.DataBaseEditor;
using WindowsAPI.EditingMode;

namespace WindowsFormsApp1.DataBaseEditor
{
    public partial class FormEditorTable1 : Form
    {
        public FormEditorTable1()
        {
            InitializeComponent();
        }

        string _tableName = "Ученики";

        private void Table1_Load(object sender, EventArgs e)
        {
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            dataGridView1.DataSource = manager.GetDataTable(_tableName);
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string[] args = new string[4];
            args[0] = textBox1.Text;
            args[1] = textBox2.Text;
            args[2] = textBox3.Text;
            args[3] = textBox5.Text;

            DataBaseCommadsManager manager  = new DataBaseCommadsManager();
            manager.Insert(args, _tableName);

            this.Hide();
            FormEditorTable1 form = new FormEditorTable1();
            form.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox4.Text);

            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Delete(number, _tableName);

            this.Hide();
            FormEditorTable1 form = new FormEditorTable1();
            form.Show();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox4.Text);

            string[] args = new string[3];
            args[0] = textBox2.Text;
            args[1] = textBox3.Text;
            args[2] = textBox5.Text;

            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Update(args, number, _tableName);

            this.Hide();
            FormEditorTable1 form = new FormEditorTable1();
            form.Show();
        }

        private void Main_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            EditingModeTabel1 editingModeTabel1 = new EditingModeTabel1();
            editingModeTabel1.Show();
        }
    }
}
