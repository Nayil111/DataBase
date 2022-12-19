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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp1.DataBaseEditor;
using WindowsAPI.EditingMode;

namespace WindowsAPI.DataBaseEditor
{
    public partial class Tarif : Form
    {
        public Tarif()
        {
            InitializeComponent();
        }

        string _tableName = "Тарифы";

        private void Main_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
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
            Tarif form = new Tarif();
            form.Show();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);

            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Delete(number, _tableName);

            this.Hide();
            Tarif form = new Tarif();
            form.Show();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditingModeTarif editingModeTarif = new EditingModeTarif();
            editingModeTarif.Show();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);

            string[] args = new string[2];
            args[0] = textBox2.Text;
            args[1] = textBox3.Text;

            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Update(args, number, _tableName);

            this.Hide();
            Tarif form = new Tarif();
            form.Show();
        }

        private void Tarif_Load(object sender, EventArgs e)
        {
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            dataGridView1.DataSource = manager.GetDataTable(_tableName);
        }
    }
}
