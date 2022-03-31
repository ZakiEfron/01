using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace WindowsFormsApp1
{
    public partial class Visitor_Menu : Form
    {
        public Visitor_Menu()
        {
            InitializeComponent();
        }

        private void Visitor_Menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Visitor_MouseMove(object sender, MouseEventArgs e)
        {
            Visitor.BackColor = Color.Blue;    
        }

        private void Visitor_Click(object sender, EventArgs e)
        {
            Form adminForm = new Teams_main();
            adminForm.Show();
        }
    }
}
