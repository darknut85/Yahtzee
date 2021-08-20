using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class Form1 : Form
    {
        //initiate
        public Form1(){InitializeComponent();}
        Settings settings = new Settings();
        
        string a = @"C:\Users\Marco\source\repos\itvitae creations\Yahtzee\";
        private void Form1_Load(object sender, EventArgs e) { }

        // roll dice
        private void roll_Click(object sender, EventArgs e)
        {
            //set values for dice roll
            int playerNumber = settings.PlayerNumber;
            int players = settings.Players;
            int turnCount = settings.TurnCount;
            int rna; int rnb; int rnc; int rnd; int rne;
            bool lock1 = settings.Lock1; bool lock2 = settings.Lock2;
            bool lock3 = settings.Lock3; bool lock4 = settings.Lock4;
            bool lock5 = settings.Lock5;

            // if turn passes do this
            if (turnCount >= 3)
            {
                turn.Text = "roll 1";
                turnCount = 1;
                lock1 = false; lock2 = false; lock3 = false;
                lock4 = false; lock5 = false;
                label1.Text = "D1 unlocked"; label2.Text = "D2 unlocked";
                label3.Text = "D3 unlocked"; label4.Text = "D4 unlocked";
                label5.Text = "D5 unlocked";
                if (playerNumber < players)
                {
                    playerNumber++;
                }
                else
                {
                    playerNumber = 1;

                }
                AmountOfPlayers.Text = "player: " + playerNumber.ToString();
            }
            else if (turnCount == 2)
            {
                turn.Text = "roll 3";
                turnCount++;
            }
            else if (turnCount == 1)
            {
                turn.Text = "roll 2";
                turnCount++;
            }
            else if (turnCount == 0)
            {
                lock1 = false; lock2 = false; lock3 = false;
                lock4 = false; lock5 = false;
                label1.Text = "D1 unlocked"; label2.Text = "D2 unlocked";
                label3.Text = "D3 unlocked"; label4.Text = "D4 unlocked";
                label5.Text = "D5 unlocked";
                turn.Text = "roll 1";
                turnCount = 1;
                AmountOfPlayers.Text = "player: " + playerNumber.ToString();
            }

            //generate right dice picture
            Random rng = new Random();
            rna = rng.Next(1, 7); rnb = rng.Next(1, 7); rnc = rng.Next(1, 7);
            rnd = rng.Next(1, 7); rne = rng.Next(1, 7);
            if (lock1 != true)
            {
                if (rna == 1) { dice1.ImageLocation = a + "dice-1.png"; }
                if (rna == 2) { dice1.ImageLocation = a + "dice-2.png"; }
                if (rna == 3) { dice1.ImageLocation = a + "dice-3.png"; }
                if (rna == 4) { dice1.ImageLocation = a + "dice-4.png"; }
                if (rna == 5) { dice1.ImageLocation = a + "dice-5.png"; }
                if (rna == 6) { dice1.ImageLocation = a + "dice-6.png"; }
                settings.D1 = rna;
            }
            if (lock2 != true)
            {
                if (rnb == 1) { dice2.ImageLocation = a + "dice-1.png"; }
                if (rnb == 2) { dice2.ImageLocation = a + "dice-2.png"; }
                if (rnb == 3) { dice2.ImageLocation = a + "dice-3.png"; }
                if (rnb == 4) { dice2.ImageLocation = a + "dice-4.png"; }
                if (rnb == 5) { dice2.ImageLocation = a + "dice-5.png"; }
                if (rnb == 6) { dice2.ImageLocation = a + "dice-6.png"; }
                settings.D2 = rnb;
            }
            if (lock3 != true)
            {
                if (rnc == 1) { dice3.ImageLocation = a + "dice-1.png"; }
                if (rnc == 2) { dice3.ImageLocation = a + "dice-2.png"; }
                if (rnc == 3) { dice3.ImageLocation = a + "dice-3.png"; }
                if (rnc == 4) { dice3.ImageLocation = a + "dice-4.png"; }
                if (rnc == 5) { dice3.ImageLocation = a + "dice-5.png"; }
                if (rnc == 6) { dice3.ImageLocation = a + "dice-6.png"; }
                settings.D3 = rnc;
            }
            if (lock4 != true)
            {
                if (rnd == 1) { dice4.ImageLocation = a + "dice-1.png"; }
                if (rnd == 2) { dice4.ImageLocation = a + "dice-2.png"; }
                if (rnd == 3) { dice4.ImageLocation = a + "dice-3.png"; }
                if (rnd == 4) { dice4.ImageLocation = a + "dice-4.png"; }
                if (rnd == 5) { dice4.ImageLocation = a + "dice-5.png"; }
                if (rnd == 6) { dice4.ImageLocation = a + "dice-6.png"; }
                settings.D4 = rnd;
            }
            if (lock5 != true)
            {
                if (rne == 1) { dice5.ImageLocation = a + "dice-1.png"; }
                if (rne == 2) { dice5.ImageLocation = a + "dice-2.png"; }
                if (rne == 3) { dice5.ImageLocation = a + "dice-3.png"; }
                if (rne == 4) { dice5.ImageLocation = a + "dice-4.png"; }
                if (rne == 5) { dice5.ImageLocation = a + "dice-5.png"; }
                if (rne == 6) { dice5.ImageLocation = a + "dice-6.png"; }
                settings.D5 = rne;
            }

            //highlight possibilities upper
            int d1 = settings.D1; int d2 = settings.D2; int d3 = settings.D3;
            int d4 = settings.D4; int d5 = settings.D5;
            if (d1 == 1 || d2 == 1 || d3 == 1 || d4 == 1 || d5 == 1)
            { Aces.BackColor = Color.Aqua; }
            else { Aces.BackColor = Color.Empty; }
            if (d1 == 2 || d2 == 2 || d3 == 2 || d4 == 2 || d5 == 2)
            { Twos.BackColor = Color.Aqua; }
            else { Twos.BackColor = Color.Empty; }
            if (d1 == 3 || d2 == 3 || d3 == 3 || d4 == 3 || d5 == 3)
            { Threes.BackColor = Color.Aqua; }
            else { Threes.BackColor = Color.Empty; }
            if (d1 == 4 || d2 == 4 || d3 == 4 || d4 == 4 || d5 == 4)
            { Fours.BackColor = Color.Aqua; }
            else { Fours.BackColor = Color.Empty; }
            if (d1 == 5 || d2 == 5 || d3 == 5 || d4 == 5 || d5 == 5)
            { Fives.BackColor = Color.Aqua; }
            else { Fives.BackColor = Color.Empty; }
            if (d1 == 6 || d2 == 6 || d3 == 6 || d4 == 6 || d5 == 6)
            { Sixes.BackColor = Color.Aqua; }
            else { Sixes.BackColor = Color.Empty; }

            //highlight possibilities lower
            if ((d1 == d2 && d2 == d3) || (d1 == d2 && d2 == d4) || (d1 == d2 && d2 == d5) || 
                (d1 == d3 && d3 == d4) || (d1 == d3 && d3 == d5) || (d1 == d4 && d4 == d5) || 
                (d2 == d3 && d3 == d4) || (d2 == d3 && d3 == d5) || (d2 == d4 && d4 == d5) || 
                (d3 == d4 && d4 == d5))
            { ThreeOfAKind.BackColor = Color.Aqua; }
            else { ThreeOfAKind.BackColor = Color.Empty; }
            if ((d1 == d2 && d2 == d3 && d3 == d4) || (d1 == d3 && d3 == d4 && d4 == d5) || 
                (d1 == d2 && d2 == d4 && d4 == d5) || (d1 == d2 && d2 == d3 && d3 == d5) ||
                (d2 == d3 && d3 == d4 && d4 == d5))
            { FourOfAKind.BackColor = Color.Aqua; }
            else { FourOfAKind.BackColor = Color.Empty; }
            if ((d1 == d2 && d2 == d3 && d4 == d5) || (d1 == d2 && d2 == d4 && d3 == d5) || 
                (d1 == d2 && d2 == d5 && d3 == d4) || (d1 == d3 && d3 == d4 && d2 == d5) || 
                (d1 == d3 && d3 == d5 && d2 == d4) || (d1 == d4 && d4 == d5 && d2 == d3) ||
                (d2 == d3 && d3 == d4 && d1 == d5) || (d2 == d3 && d3 == d5 && d1 == d4) || 
                (d2 == d4 && d4 == d5 && d1 == d3) || (d3 == d4 && d4 == d5 && d1 == d2))
            { Full.BackColor = Color.Aqua; }
            else { Full.BackColor = Color.Empty; }
            if (((d1 == 1 || d2 == 1 || d3 == 1 || d4 == 1 || d5 == 1) &&
                (d1 == 2 || d2 == 2 || d3 == 2 || d4 == 2 || d5 == 2) &&
                (d1 == 3 || d2 == 3 || d3 == 3 || d4 == 3 || d5 == 3) &&
                (d1 == 4 || d2 == 4 || d3 == 4 || d4 == 4 || d5 == 4)) ||
                ((d1 == 2 || d2 == 2 || d3 == 2 || d4 == 2 || d5 == 2) &&
                (d1 == 3 || d2 == 3 || d3 == 3 || d4 == 3 || d5 == 3) &&
                (d1 == 4 || d2 == 4 || d3 == 4 || d4 == 4 || d5 == 4) &&
                (d1 == 5 || d2 == 5 || d3 == 5 || d4 == 5 || d5 == 5)) ||
                ((d1 == 3 || d2 == 3 || d3 == 3 || d4 == 3 || d5 == 3) &&
                (d1 == 4 || d2 == 4 || d3 == 4 || d4 == 4 || d5 == 4) &&
                (d1 == 5 || d2 == 5 || d3 == 5 || d4 == 5 || d5 == 5) &&
                (d1 == 6 || d2 == 6 || d3 == 6 || d4 == 6 || d5 == 6)))
            { Low.BackColor = Color.Aqua; }
            else { Low.BackColor = Color.Empty; }
            if (((d1 == 1 || d2 == 1 || d3 == 1 || d4 == 1 || d5 == 1) &&
                (d1 == 2 || d2 == 2 || d3 == 2 || d4 == 2 || d5 == 2) &&
                (d1 == 3 || d2 == 3 || d3 == 3 || d4 == 3 || d5 == 3) &&
                (d1 == 4 || d2 == 4 || d3 == 4 || d4 == 4 || d5 == 4) &&
                (d1 == 5 || d2 == 5 || d3 == 5 || d4 == 5 || d5 == 5)) ||
                ((d1 == 2 || d2 == 2 || d3 == 2 || d4 == 2 || d5 == 2) &&
                (d1 == 3 || d2 == 3 || d3 == 3 || d4 == 3 || d5 == 3) &&
                (d1 == 4 || d2 == 4 || d3 == 4 || d4 == 4 || d5 == 4) &&
                (d1 == 5 || d2 == 5 || d3 == 5 || d4 == 5 || d5 == 5) &&
                (d1 == 6 || d2 == 6 || d3 == 6 || d4 == 6 || d5 == 6)))
            { High.BackColor = Color.Aqua; }
            else { High.BackColor = Color.Empty; }
            if (d1 == d2 && d2 == d3 && d3 == d4 && d4 == d5)
            {
                Yahtzee.BackColor = Color.Aqua;
                YBonus.BackColor = Color.Aqua;
            }
            else { Yahtzee.BackColor = Color.Empty; }
            Chance.BackColor = Color.Aqua;


            //returning values
            settings.TurnCount = turnCount;
            settings.Lock1 = lock1; settings.Lock2 = lock2; settings.Lock3 = lock3;
            settings.Lock4 = lock4; settings.Lock5 = lock5;
            settings.PlayerNumber = playerNumber;
        }

        //(un)locking dice for the turn
        private void dice1_Click(object sender, EventArgs e) 
        {
            if (settings.Lock1 == true)
            {
                label1.Text = "D1 unlocked";
                settings.Lock1 = false;
            }
            else
            {
                label1.Text = "D1 locked";
                settings.Lock1 = true;
            }
        }

        private void dice2_Click(object sender, EventArgs e)
        {
            if (settings.Lock2 == true)
            {
                label2.Text = "D2 unlocked";
                settings.Lock2 = false;
            }
            else
            {
                label2.Text = "D2 locked";
                settings.Lock2 = true;
            }
        }

        private void dice3_Click(object sender, EventArgs e)
        {
            if (settings.Lock3 == true)
            {
                label3.Text = "D3 unlocked";
                settings.Lock3 = false;
            }
            else
            {
                label3.Text = "D3 locked";
                settings.Lock3 = true;
            }
        }

        private void dice4_Click(object sender, EventArgs e)
        {
            if (settings.Lock4 == true)
            {
                label4.Text = "D4 unlocked";
                settings.Lock4 = false;
            }
            else
            {
                label4.Text = "D4 locked";
                settings.Lock4 = true;
            }
        }

        private void dice5_Click(object sender, EventArgs e)
        {
            if (settings.Lock5 == true)
            {
                label5.Text = "D5 unlocked";
                settings.Lock5 = false;
            }
            else
            {
                label5.Text = "D5 locked";
                settings.Lock5 = true;
            }
        }

        // setting the amount of players
        private void increase_Click(object sender, EventArgs e)
        {
            if (settings.TurnCount == 0)
            {
                int players = settings.Players;
                if (players < 4)
                {
                    players++;
                    AmountOfPlayers.Text = "Players: " + players.ToString();
                }
                settings.PlayerNumber = 1;
                settings.Players = players;
            }
        }
        private void minus_Click(object sender, EventArgs e)
        {
            if (settings.TurnCount == 0)
            {
                int players = settings.Players;
                if (players > 1)
                {
                    players--;
                    AmountOfPlayers.Text = "Players: " + players.ToString();
                }
                settings.PlayerNumber = 1;
                settings.Players = players;
            }
        }

        // calculating score
        private void Calculate_Click(object sender, EventArgs e)
        {
            // variables
            int tb1 = 0; int tb2 = 0; int tb3 = 0; int tb4 = 0; int tb5 = 0; int tb6 = 0;
            int tb10 = 0; int tb11 = 0; int tb12 = 0; int tb13 = 0; int tb14 = 0;
            int tb15 = 0; int tb16 = 0; int tb17 = 0; int tb20 = 0; int tb21 = 0;
            int tb22 = 0; int tb23 = 0; int tb24 = 0; int tb25 = 0; int tb29 = 0;
            int tb30 = 0; int tb31 = 0; int tb32 = 0; int tb33 = 0; int tb34 = 0;
            int tb35 = 0; int tb36 = 0; int tb39 = 0; int tb40 = 0; int tb41 = 0;
            int tb42 = 0; int tb43 = 0; int tb44 = 0; int tb48 = 0; int tb49 = 0;
            int tb50 = 0; int tb51 = 0; int tb52 = 0; int tb53 = 0; int tb54 = 0;
            int tb55 = 0; int tb58 = 0; int tb59 = 0; int tb60 = 0; int tb61 = 0;
            int tb62 = 0; int tb63 = 0; int tb67 = 0; int tb68 = 0; int tb69 = 0;
            int tb70 = 0; int tb71 = 0; int tb72 = 0; int tb73 = 0; int tb74 = 0;
            int playe = settings.Players;

            // P1 upper
            try
            {
                tb1 = Convert.ToInt32(textBox1.Text); tb2 = Convert.ToInt32(textBox2.Text);
                tb3 = Convert.ToInt32(textBox3.Text); tb4 = Convert.ToInt32(textBox4.Text);
                tb5 = Convert.ToInt32(textBox5.Text); tb6 = Convert.ToInt32(textBox6.Text);
            }
            catch (Exception)
            {MessageBox.Show("Not every score in the upper section is used for P1");}
            int Total_P1 = tb1 + tb2 + tb3 + tb4 + tb5 + tb6;
            P1WO.Text = Total_P1.ToString();
            if (Total_P1 >= 63) { Total_P1 += 35; P1WB.Text = "35"; }
            else { P1WB.Text = "0"; }
            P1TUS.Text = Total_P1.ToString();

            // P1 lower
            try
            {
                tb10 = Convert.ToInt32(textBox10.Text); tb11 = Convert.ToInt32(textBox11.Text);
                tb12 = Convert.ToInt32(textBox12.Text); tb13 = Convert.ToInt32(textBox13.Text);
                tb14 = Convert.ToInt32(textBox14.Text); tb15 = Convert.ToInt32(textBox15.Text);
                tb16 = Convert.ToInt32(textBox16.Text); tb17 = Convert.ToInt32(textBox17.Text);
            }
            catch (Exception)
            { MessageBox.Show("Not every score in the lower section is used for P1"); }
            int TotalLP1 = tb10 + tb11 + tb12 + tb13 + tb14 + tb15 + tb16 + tb17;
            P1TLS.Text = TotalLP1.ToString();
            Total_P1 += TotalLP1;
            GT1.Text = Total_P1.ToString();

            if (playe > 1)
            {
                //P2 upper
                try
                {
                    tb20 = Convert.ToInt32(textBox20.Text); tb21 = Convert.ToInt32(textBox21.Text);
                    tb22 = Convert.ToInt32(textBox22.Text); tb23 = Convert.ToInt32(textBox23.Text);
                    tb24 = Convert.ToInt32(textBox24.Text); tb25 = Convert.ToInt32(textBox25.Text);
                }
                catch (Exception)
                { MessageBox.Show("Not every score in the upper section is used for P2"); }
                int Total_P2 = tb20 + tb21 + tb22 + tb23 + tb24 + tb25;
                P2WO.Text = Total_P2.ToString();
                if (Total_P2 >= 63) { Total_P2 += 35; P2WB.Text = "35"; }
                else { P2WB.Text = "0"; }
                P2TUS.Text = Total_P2.ToString();

                //P2 lower
                try
                {
                    tb29 = Convert.ToInt32(textBox29.Text); tb30 = Convert.ToInt32(textBox30.Text);
                    tb31 = Convert.ToInt32(textBox31.Text); tb32 = Convert.ToInt32(textBox32.Text);
                    tb33 = Convert.ToInt32(textBox33.Text); tb34 = Convert.ToInt32(textBox34.Text);
                    tb35 = Convert.ToInt32(textBox35.Text); tb36 = Convert.ToInt32(textBox36.Text);
                }
                catch (Exception)
                { MessageBox.Show("Not every score in the lower section is used for P2"); }
                int TotalLP2 = tb29 + tb30 + tb31 + tb32 + tb33 + tb34 + tb35 + tb36;
                P2TLS.Text = TotalLP2.ToString();
                Total_P2 += TotalLP2;
                GT2.Text = Total_P2.ToString();
            }

            if (playe > 2)
            {
                //P3 upper
                try
                {
                    tb39 = Convert.ToInt32(textBox39.Text); tb40 = Convert.ToInt32(textBox40.Text);
                    tb41 = Convert.ToInt32(textBox41.Text); tb42 = Convert.ToInt32(textBox42.Text);
                    tb43 = Convert.ToInt32(textBox43.Text); tb44 = Convert.ToInt32(textBox44.Text);
                }
                catch (Exception)
                { MessageBox.Show("Not every score in the upper section is used for P3"); }
                int Total_P3 = tb39 + tb40 + tb41 + tb42 + tb43 + tb44;
                P3WO.Text = Total_P3.ToString();
                if (Total_P3 >= 63) { Total_P3 += 35; P3WB.Text = "35"; }
                else { P3WB.Text = "0"; }
                P3TUS.Text = Total_P3.ToString();

                //P3 lower
                try
                {
                    tb48 = Convert.ToInt32(textBox48.Text); tb49 = Convert.ToInt32(textBox49.Text);
                    tb50 = Convert.ToInt32(textBox50.Text); tb51 = Convert.ToInt32(textBox51.Text);
                    tb52 = Convert.ToInt32(textBox52.Text); tb53 = Convert.ToInt32(textBox53.Text);
                    tb54 = Convert.ToInt32(textBox54.Text); tb55 = Convert.ToInt32(textBox55.Text);
                }
                catch (Exception)
                { MessageBox.Show("Not every score in the lower section is used for P3"); }
                int TotalLP3 = tb48 + tb49 + tb50 + tb51 + tb52 + tb53 + tb54 + tb55;
                P3TLS.Text = TotalLP3.ToString();
                Total_P3 += TotalLP3;
                GT3.Text = Total_P3.ToString();
            }

            if (playe > 3)
            {
                //P4 upper
                try
                {
                    tb58 = Convert.ToInt32(textBox58.Text); tb59 = Convert.ToInt32(textBox59.Text);
                    tb60 = Convert.ToInt32(textBox60.Text); tb61 = Convert.ToInt32(textBox61.Text);
                    tb62 = Convert.ToInt32(textBox62.Text); tb63 = Convert.ToInt32(textBox63.Text);
                }
                catch (Exception)
                { MessageBox.Show("Not every score in the upper section is used for P4"); }
                int Total_P4 = tb58 + tb59 + tb60 + tb61 + tb62 + tb63;
                P4WO.Text = Total_P4.ToString();
                if (Total_P4 >= 63) { Total_P4 += 35; P4WB.Text = "35"; }
                else { P4WB.Text = "0"; }
                P4TUS.Text = Total_P4.ToString();

                //P4 lower
                try
                {
                    tb67 = Convert.ToInt32(textBox67.Text); tb68 = Convert.ToInt32(textBox68.Text);
                    tb69 = Convert.ToInt32(textBox69.Text); tb70 = Convert.ToInt32(textBox70.Text);
                    tb71 = Convert.ToInt32(textBox71.Text); tb72 = Convert.ToInt32(textBox72.Text);
                    tb73 = Convert.ToInt32(textBox73.Text); tb74 = Convert.ToInt32(textBox74.Text);
                }
                catch (Exception)
                { MessageBox.Show("Not every score in the lower section is used for P4"); }
                int TotalLP4 = tb67 + tb68 + tb69 + tb70 + tb71 + tb72 + tb73 + tb74;
                P4TLS.Text = TotalLP4.ToString();
                Total_P4 += TotalLP4;
                GT4.Text = Total_P4.ToString();
            }
        }
    }
}
