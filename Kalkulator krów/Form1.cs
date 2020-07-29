﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_krów
{
    public partial class Form1 : Form
    {
        Farmer farmer;

        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer() { NumberOfCows = 15 };
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDown1.Value;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Coś");
            //Console.WriteLine("Potrzebuję {0} worków paszy do wykarmienia {1} krów", farmer.BagsOfFeed, farmer.NumberOfCows);
        }
    }

    public class Farmer
    {
        public int BagsOfFeed;
        public const int FeedMultiplier = 30;

        private int numberOfCows;
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }
    }
}
