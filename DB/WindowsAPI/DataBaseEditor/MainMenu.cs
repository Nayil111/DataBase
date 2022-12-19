using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataBaseEditor;

namespace WindowsAPI.DataBaseEditor
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            FormEditorTable1 formEditorTable1 = new FormEditorTable1();
            formEditorTable1.Show();
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Tarif tarif = new Tarif();
            tarif.Show();
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Teachers teachers = new Teachers();
            teachers.Show();
        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            classs classs = new classs();
            classs.Show();
        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Schedule schedule = new Schedule();
            schedule.Show();
        }
    }
}
