using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Teams_main : Form
    {
        Team[] teams = new Team[6];
        public Teams_main()
        {
            InitializeComponent();


        
            

            teams[0] = new Team();
            teams[0].setTeamId(1);
            teams[0].setName("Miami Heat");
            teams[0].setAbbr("MIA");
            teams[0].setLogo("1.jpg");

            teams[1] = new Team();
            teams[1].setTeamId(2);
            teams[1].setName("Orlando Magic");
            teams[1].setAbbr("ORL");
            teams[1].setLogo("2.jpg");


            teams[2] = new Team();
            teams[2].setTeamId(3);
            teams[2].setName("Atlanta Hawks");
            teams[2].setAbbr("ATL");
            teams[2].setLogo("3.jpg");


            teams[3] = new Team();
            teams[3].setTeamId(4);
            teams[3].setName("Washington Wizards");
            teams[3].setAbbr("WSH");
            teams[3].setLogo("4.jpg");


            teams[4] = new Team();
            teams[4].setTeamId(5);
            teams[4].setName("Charlotte Hornets");
            teams[4].setAbbr("CHA");
            teams[4].setLogo("5.jpg");

            teams[5] = new Team();
            teams[5].setTeamId(6);
            teams[5].setName("Detroit Pistons");
            teams[5].setAbbr("DET");
            teams[5].setLogo("6.jpg");
            


            label100.Text = teams[0].name;
            for (var i = 0; i < 5; i++)
            this.Controls["label10" + i].Text = teams[i].name;
           
             

        }

        private void label35_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }
    }
}
