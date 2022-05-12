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
    public partial class Form1 : Form

    {
        //ImgList
       


        String[] imgList = new String[]
            {"1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg", "6.jpeg", "7.jpg", "8.jpg", "9.jpg", "10.jpg"};
        int index = 0;

        Country[] countries = new Country[5];
        POSITIONNAME[] pOSITIONNAMEs = new POSITIONNAME[5];
        Player[] players = new Player[5];
        Positionofplayer[] positionofplayers = new Positionofplayer[5];
        public Form1()
        {
            InitializeComponent();

            pictureBox2.Load("../../../pictures/" + imgList[0]);
            pictureBox3.Load("../../../pictures/" + imgList[1]);
            pictureBox4.Load("../../../pictures/" + imgList[2]);

            Positionofplayer positionofplayer = new Positionofplayer();
            positionofplayer.setPositionId("defender");
            positionofplayer.setPlayerId("5");
            positionofplayers[0] = positionofplayer;

            positionofplayer.setPositionId("midfielder");
            positionofplayer.setPlayerId("7");
            positionofplayers[1] = positionofplayer;

            positionofplayer.setPositionId("ctntre forward");
            positionofplayer.setPlayerId("10");
            positionofplayers[2] = positionofplayer;

            positionofplayer.setPositionId("left wing");
            positionofplayer.setPlayerId("36");
            positionofplayers[3] = positionofplayer;

            positionofplayer.setPositionId("goalkeeper");
            positionofplayer.setPlayerId("1");
            positionofplayers[4] = positionofplayer;

            Player player = new Player();
            player.setAll("1", "Mo", "Williams", "1.85", "89.8", "US");
            players[0] = player;

            player.setAll("2", "Alonzo", "Edward Gee", "1.98", "99", "US");
            players[1] = player;

            player.setAll("3", "Johnny", "O'Bryant", "2.05", "116.5", "US");
            players[2] = player;

            player.setAll("4", "Danilo", "Gallinari", "2.08", "102", "US");
            players[3] = player;

            player.setAll("5", "Darrell", "Arthur", "2.06", "107", "US");
            players[4] = player;

            POSITIONNAME pOSITIONNAME = new POSITIONNAME();
            pOSITIONNAME.setPositionId("1");
            pOSITIONNAME.setName("SmallForward");
            pOSITIONNAMEs[0] = pOSITIONNAME;

            pOSITIONNAME.setPositionId("2");
            pOSITIONNAME.setName("PowerForward");
            pOSITIONNAMEs[1] = pOSITIONNAME;

            pOSITIONNAME.setPositionId("3");
            pOSITIONNAME.setName("Center");
            pOSITIONNAMEs[2] = pOSITIONNAME;

            pOSITIONNAME.setPositionId("4");
            pOSITIONNAME.setName("ShootingGuard");
            pOSITIONNAMEs[3] = pOSITIONNAME;

            pOSITIONNAME.setPositionId("5");
            pOSITIONNAME.setName("PointGuard");
            pOSITIONNAMEs[4] = pOSITIONNAME;


            Country country = new Country();
            country.setCountryCode("ARG");
            country.setCountryName("Argentina");
            countries[0] = country;

            country.setCountryCode("AT");
            country.setCountryName("Austria");
            countries[1] = country;

            country.setCountryCode("AUS");
            country.setCountryName("Australia");
            countries[2] = country;

            country.setCountryCode("BI");
            country.setCountryName("Bosnia");
            countries[3] = country;

            country.setCountryCode("BIH");
            country.setCountryName("Bosnia Herzegovina");
            countries[4] = country;

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index + 3 > imgList.Length) index = 0;
            pictureBox2.Load("../../../pictures/" + imgList[index + 0]);
            pictureBox3.Load("../../../pictures/" + imgList[index + 1]);
            pictureBox4.Load("../../../pictures/" + imgList[index + 2]);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            index = index - 1;
            if (index < 0) index = imgList.Length - 3;
            pictureBox2.Load("../../../pictures/" + imgList[index + 0]);
            pictureBox3.Load("../../../pictures/" + imgList[index + 1]);
            pictureBox4.Load("../../../pictures/" + imgList[index + 2]);
           
        }

        
        private void Visitor_MouseMove(object sender, MouseEventArgs e)
        {
           
            button4.BackColor = Color.Blue;
        }

        private void Visitor_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = button2.BackColor;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Blue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = button4.BackColor;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form adminForm = new Visitor_Menu();
            adminForm.Show();
            Hide();
        }
    }
}
