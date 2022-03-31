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
        Team[] teams = new Team[5];
        public Teams_main()
        {
            InitializeComponent();
            InitializeComponent();
            Team team = new Team();
            team.setTeamId(1);
            team.setName("Miami Heat");
            team.setAbbr("MIA");
            team.setLogo("1.jpg");
            teams[0] = team;

            team.setTeamId(2);
            team.setName("Orlando Magic");
            team.setAbbr("ORL");
            team.setLogo("2.jpg");
            teams[1] = team;

            team.setTeamId(3);
            team.setName("Atlanta Hawks");
            team.setAbbr("ATL");
            team.setLogo("3.jpg");
            teams[2] = team;

            team.setTeamId(4);
            team.setName("Washington Wizards");
            team.setAbbr("WSH");
            team.setLogo("4.jpg");
            teams[3] = team;

            team.setTeamId(5);
            team.setName("Charlotte Hornets");
            team.setAbbr("CHA");
            team.setLogo("5.jpg");
            teams[4] = team;
        }

        private void label35_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                this.Controls["label" + i].Text = teams[i].name;
        }
    }
}
