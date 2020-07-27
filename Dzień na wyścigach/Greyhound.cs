using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

public class Greyhound
{
	public int StartingPosition;//Miejsce gdzie rozpoczyna się PictureBox
	public int RacetrackLength;//Długość trasy
	public PictureBox MyPictureBox = null;//Mój obiekt PictureBox
	public int Location = 0;//Moje położenie na torze wyścigowym
	public Random MyRandom;//Instancja klasy Random

	public bool Run()
	{
		//Przesuń się do przodu losowo o 1, 2, 3 lub 4 punkty
		//Zaktualizuj położenie PictureBox na formularzu
		//Zwróć true, jeżeli wygrałem wyścig
	}

	public void TakeStartingPosition()
    {
		//Wyzeruj położenie i ustaw na linii startowej
		//MyPictureBox.Left = StartingPosition;
    }
}
