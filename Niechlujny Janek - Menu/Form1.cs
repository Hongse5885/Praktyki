using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Niechlujny_Janek___Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MenuMaker menu = new MenuMaker() { Randomizer = new Random() };
			label1.Text = menu.GetMenuItem();
			label2.Text = menu.GetMenuItem();
			label3.Text = menu.GetMenuItem();
			label4.Text = menu.GetMenuItem();
			label5.Text = menu.GetMenuItem();
			label6.Text = menu.GetMenuItem();
		}
    }

	public class MenuMaker
	{
		public Random Randomizer;

		string[] Meats = { "Pieczona wołowina", "Salami", "Indyk", "Szynka", "Karkówka" };
		string[] Condiments = { "żółta musztarda", "brązowa musztarda", "musztarda miodowa", "majonez", "przyprawa", "sos francuski" };
		string[] Breads = { "chleb ryżowy", "chleb biały", "chleb zbożowy", "pumpernikiel", "chleb włoski", "bułka" };

		public string GetMenuItem()
		{
			string randomMeat = Meats[Randomizer.Next(Meats.Length)];
			string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
			string randomBread = Breads[Randomizer.Next(Breads.Length)];
			return randomMeat + ", " + randomCondiment + ", " + randomBread;
		}
	}
}
