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
        Team[] teams = new Team[11];


        //imgList
        String[] imgList = new String[]
            {"1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg", "6.jpg", "7.jpg", "8.jpg", "9.jpg", "10.jpg", "11.jpg", "12.jpg","13.jpg", "14.jpg", "15.jpg"};

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


            teams[6] = new Team();
            teams[6].setTeamId(7);
            teams[6].setName("Miami Heat");
            teams[6].setAbbr("MIA");
            teams[6].setLogo("7.jpg");

            teams[7] = new Team();
            teams[7].setTeamId(8);
            teams[7].setName("Orlando Magic");
            teams[7].setAbbr("ORL");
            teams[7].setLogo("8.jpg");


            teams[8] = new Team();
            teams[8].setTeamId(9);
            teams[8].setName("Atlanta Hawks");
            teams[8].setAbbr("ATL");
            teams[8].setLogo("9.jpg");


            teams[9] = new Team();
            teams[9].setTeamId(10);
            teams[9].setName("Washington Wizards");
            teams[9].setAbbr("WSH");
            teams[9].setLogo("10.jpg");


            teams[10] = new Team();
            teams[10].setTeamId(11);
            teams[10].setName("Charlotte Hornets");
            teams[10].setAbbr("CHA");
            teams[10].setLogo("11.jpg");



            label100.Text = teams[0].name;
            for (var i = 0; i < 10; i++)
            this.Controls["label10" + i].Text = teams[i].name;

            Logo1.Load("../../../../../01/Xi/Teams/" + imgList[0]); Logo2.Load("../../../Teams/" + imgList[1]); Logo3.Load("../../../Teams/" + imgList[2]);
            Logo4.Load("../../../../../01/Xi/Teams/" + imgList[3]); Logo5.Load("../../../Teams/" + imgList[4]); Logo6.Load("../../../Teams/" + imgList[5]);
            Logo7.Load("../../../Teams/" + imgList[6]); Logo8.Load("../../../Teams/" + imgList[7]); Logo9.Load("../../../Teams/" + imgList[8]);
            Logo10.Load("../../../Teams/" + imgList[9]); Logo11.Load("../../../Teams/" + imgList[10]); Logo12.Load("../../../Teams/" + imgList[11]);
            Logo13.Load("../../../Teams/" + imgList[12]); Logo14.Load("../../../Teams/" + imgList[13]); Logo15.Load("../../../Teams/" + imgList[14]);


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

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            
        }

        private void Teams_main_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form adminForm = new Visitor_Menu();
            adminForm.Show();
            Hide();
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
