using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForecastCity
{
    public partial class Form1 : Form
    {
        string[] cityList = { "Kabul", "Tirana", "Algiers", "Andorra la Vella", "Luanda", "Buenos Aires", "Yerevan", "Canberra", "Vienna", "Baku", "Nassau", "Manama", "Dhaka", "Bridgetown", "Minsk", "	Brussels", "Belmopan", "Thimphu", "Sucre", "Sarajevo", "Gaborone", "	Brasilia", "Bandar Seri Begawan", "Sofia", "Ouagadougou", "Bujumbura", "Praia", "Phnom Penh", "Yaounde", "Ottawa", "Bangui", "Santiago", "	Beijing", "	Bogota", "	Yamoussoukro", "Kinshasa", "Zagreb", "Havana", "Nicosia", "Prague", "Copenhagen", "Cairo", "Malabo", "Tallinn", "Suva", "Helsinki", "Paris", "Libreville", "Tbilisi", "Berlin", "Athens", "Georgetown", "Budapest", "Reykjavik", "New Delhi", "Tehran", "Jakarta", "Baghdad", "Dublin", "Jerusalem", "Rome", "Kingston", "Tokyo", "Amman", "Astana", "Kiev", "Ashgabat", "Ankara", "Tunis", "Bangkok", "Dushanbe", "Taipei", "Bern", "Stockholm", "Madrid", "Seoul", "Pretoria", "Mogadishu", "Ljubljana", "Bratislava", "Singapore", "Belgrade", "Dakar", "Riyadh", "San Marino", "Moscow", "Bucharest", "Doha", "Bishkek", "Riga", "Beirut", "Luxembourg", "Caracas", "Tashkent", "Montevideo", "Washington", "London", "Abu Dhabi", "Lisbon", "Warsaw", "Manila", "Lima", "Islamabad", "Oslo", "Pyongyang", "Amsterdam", "Kathmandu", "Rabat", "Ulaanbaatar", "Monaco", "Mexico", "Valletta", "Kuala Lumpur", "Skopje", "Antananarivo" };

        string cityFind = "";
        int ltrNumFind = 0;
        int chance = 10;
        Random rand;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            ltrNumFind = 0;
            btnEnterLtr.Enabled = true;
            btnGuess.Enabled = true;
            lblEnteredLtr.Text = "";
            chance = 10;
            ChooseNewCity();
            questArea.Controls.Clear();

            for (int i = 0; i < cityFind.Length; i++)
            {
                Label label = new Label();
                label.Location = new Point(20 * i + 20, 20);
                label.Text = cityFind[i].ToString();
                label.Font = new System.Drawing.Font("Verdana", 9, System.Drawing.FontStyle.Bold);
                label.Size = new System.Drawing.Size(15, 20);
                label.BackColor = Color.Blue;
                label.ForeColor = Color.Blue;
                questArea.Controls.Add(label);
            }
        }

        private void btnEnterLtr_Click(object sender, EventArgs e)
        {
            bool anyLetter = false;
            if (txtLtr.Text.Length != 1)
            {
                MessageBox.Show("Enter only one letter!");
            }
            else
            {
                if (lblEnteredLtr.Text.Contains(txtLtr.Text))
                {
                    MessageBox.Show("You entered this letter before");
                    txtLtr.Text = "";
                    txtLtr.Focus();
                }

                foreach (Control item in questArea.Controls)
                {
                    if (item is Label)
                    {
                        Label label = item as Label;
                        if (label.Text.ToUpper() == txtLtr.Text.ToUpper())
                        {
                            label.ForeColor = Color.Red;
                            label.BackColor = Color.Yellow;
                            anyLetter = true;
                            ltrNumFind++;
                        }
                    }
                }
            }
            if (!anyLetter)
            {
                chance--;
                lblChance.Text = chance.ToString();
                if (chance == 0)
                {
                    btnEnterLtr.Enabled = false;
                    btnGuess.Enabled = false;
                    MessageBox.Show("Game Over! Click New Game button for new game!" + " " + cityFind);
                }
            }
            lblEnteredLtr.Text += txtLtr.Text + " ";
            if (ltrNumFind == cityFind.Length)
            {
                btnEnterLtr.Enabled = false;
                btnGuess.Enabled = false;
                MessageBox.Show("Congratulations!!! You won!!!");
            }
            txtLtr.Text = "";
            txtLtr.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEnterLtr.Enabled = false;
            btnGuess.Enabled = false;
            rand = new Random();

            this.AcceptButton = btnEnterLtr;
        }

        private void ChooseNewCity()
        {
            int randNum = rand.Next(0, cityList.Length);
            cityFind = cityList[randNum];
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (cityFind.ToUpper() == txtLtr.Text.ToUpper())
            {
                foreach (Control item in questArea.Controls)
                {
                    if (item is Label)
                    {
                        Label label = new Label();
                        label.ForeColor = Color.Red;
                        label.BackColor = Color.Yellow;
                    }

                }
                MessageBox.Show("Congratulations!!! You won!!!");
            }
            else
            {
                MessageBox.Show("Game Over! Click New Game button for new game!" + " " + cityFind);
            }
            btnEnterLtr.Enabled = false;
            btnGuess.Enabled = false;
        }
    }
}
