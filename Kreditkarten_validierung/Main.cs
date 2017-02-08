using System;
using System.Windows.Forms;

namespace Kreditkarten_validierung
{
  public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			int müll;
			int prüfziffer = 0;
			bool prüfen = false;
			if (txtInput.Text.Length == 16)
			{
				prüfen = true;
				prüfziffer = int.Parse(txtInput.Text[15].ToString());
			}
			else if (txtInput.Text.Length > 16 || txtInput.Text.Length < 15)
			{ MessageBox.Show("Es ist ein Fehler aufgetreten!\nMeldung: Es wurden zu viele/wenig Ziffern angegeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

			int[] ziffern = stringToInt(txtInput.Text);
			if (ziffern == null)
			{ MessageBox.Show("Es ist ein Fehler aufgetreten!\nMeldung: Es wurde ein nicht gültiges Zeichen eingegeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }


			for (int i = 0; i < 15; i++)
				if (i % 2 == 0)
					ziffern[i] *= 2;

			for (int i = 0; i < 15; i++)
				if (ziffern[i] > 9)
					ziffern[i] = quersumme(ziffern[i]);

			int summe = 0;
			for (int i = 0; i < 15; i++)
			{
				summe += ziffern[i];
			}

			int rest = summe % 10;

			if (prüfen)
			{
				lblOut.Text = "Gültigkeit";
				txtOut.Text = (prüfziffer == 10 - rest).ToString();
			}
			else
			{
				prüfziffer = 10 - rest;
				lblOut.Text = "Prüfziffer";
				txtOut.Text = prüfziffer.ToString();
			}




		}

		private int[] stringToInt(string eingabe)
		{
			char[] charEingabe = eingabe.ToCharArray();
			int[] ausgabe = new int[eingabe.Length];
			int i = 0;
			foreach (char zahl in charEingabe)
			{
				if (!int.TryParse(zahl.ToString(), out ausgabe[i])) return null;
				i++;
			}
			return ausgabe;
		}

		private int quersumme(int ziffer)
		{
			string strZiffer = ziffer.ToString();
			int ausgabe = int.Parse(strZiffer[0].ToString()) + int.Parse(strZiffer[1].ToString());
			return ausgabe;
		}
	}
}
