using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zamiana
{
    public partial class Form1 : Form
    {
        Elephant lloyd;
        Elephant lucinda;

        public Form1()
        {
            InitializeComponent();
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant holder;
            holder = lucinda;
            lucinda = lloyd;
            lloyd = holder;
            MessageBox.Show("Obiekty zamienione");
        }
    }

    public class Elephant
    {
        public int EarSize;
        public string Name;

        public void WhoAmI()
        {
            MessageBox.Show("Moje uszy mają " + EarSize + " cm szerokości", Name + " mówi...");
        }

        public void TellMe(string message, Elephant whoSaidIt){
        MessageBox.Show(whoSaidIt.Name + " mówi: " + message);
        }

        public void SpeakTo(Elephant whoToTalkTo, string message){
        whoToTalkTo.TellMe(message, this);
        }
    }
}
