using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computerspiel_Verwaltung
{
    public partial class Bestand : Form
    {

        // Liste für Objekte wird Instanziert
        List<Computerspiele> verwaltung = new List<Computerspiele>();

        public Bestand()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Der "Hinzufügen" Button wird auf seine wesentliche Funktionen programmiert.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Eingabe_bestätigen_Click(object sender, EventArgs e)
        {
            var spiel = new Computerspiele();

            Ausgabe.Clear();

            // Eingabe
            spiel.Name = Spielename.Text;
            spiel.Entwickler = Entwicklerstudio.Text;
            if (int.TryParse(Erscheinungsjahr.Text, out var erscheinungsjahr))
                spiel.Erscheinungsjahr = erscheinungsjahr;
            if (int.TryParse(Freigabestufe.Text, out var freigabestufe))
                spiel.Freigabestufe = freigabestufe;
            spiel.Genre = Genre.Text;
            if (int.TryParse(Preis.Text, out var preis))
                spiel.Preis = preis;               

            // Fehlerprüfung
            spiel.Jahr();

            if (!spiel.Jahr())
            {
                Ausgabe.Text = "Ungültiges Jahr!";
                return;
            }

            spiel.Alter();

            if (!spiel.Alter())
            {
                Ausgabe.Text = "Ungültige Freigabestufe! (0, 6, 12, 16, 18)";
                return;
            }

            // Ausgabe in der ListBox
            Auflistung.Items.Add(spiel.Name);

            // Daten werden geleert. 
            Spielename.Clear();
            Entwicklerstudio.Clear();
            Erscheinungsjahr.Clear();
            Freigabestufe.Clear();
            Genre.Clear();
            Preis.Clear();

            // Objekte der Liste hinzufügen.
            verwaltung.Add(spiel);

        }

        /// <summary>
        /// Der "Löschen" Button wird auf seine wesentlichen Funktionen programmiert.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Click(object sender, EventArgs e)
        {
            // Wenn kein Spiel vorhanden ist, wird der Fehler aufgefangen.
            while (Auflistung.SelectedItems.Count > 0)
            {
                verwaltung.RemoveAt(Auflistung.SelectedIndex);
                Auflistung.Items.RemoveAt(Auflistung.SelectedIndex);
            }

            Ausgabe.Text = "Bitte ein Computerspiel auswählen!";
        }

        /// <summary>
        /// Ausgabe der wesentlichen Informationen der Computerspiele in den Textboxen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Auflistung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Auflistung.SelectedIndex < 0)
                return;

            var spiel = verwaltung[Auflistung.SelectedIndex];

            Spielename.Text = spiel.Name;
            Entwicklerstudio.Text = spiel.Entwickler;
            Erscheinungsjahr.Text = spiel.Erscheinungsjahr.ToString();
            Freigabestufe.Text = spiel.Freigabestufe.ToString();
            Genre.Text = spiel.Genre;
            Preis.Text = spiel.Preis.ToString();

        }

        /// <summary>
        /// Der "Bearbeiten" Button erhält hier seine Funktionen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bearbeiten_Click(object sender, EventArgs e)
        {

            if (Auflistung.SelectedIndex < 0)
                return;

            var spiel = verwaltung[Auflistung.SelectedIndex];

            // Überprüfung, ob die Eingabe leer ist. 
            spiel.Name = Spielename.Text;
            spiel.Entwickler = Entwicklerstudio.Text;
            if (int.TryParse(Erscheinungsjahr.Text, out var erscheinungsjahr))
                spiel.Erscheinungsjahr = erscheinungsjahr;
            if (int.TryParse(Freigabestufe.Text, out var freigabestufe))
                spiel.Freigabestufe = freigabestufe;
            spiel.Genre = Genre.Text;
            if (int.TryParse(Preis.Text, out var preis))
                spiel.Preis = preis;

            // Fehlereingaben werden abgefangen.
            spiel.Jahr();

            if (!spiel.Jahr())
            {
                Ausgabe.Text = "Ungültiges Jahr!";
                return;
            }

            spiel.Alter();

            if (!spiel.Alter())
            {
                Ausgabe.Text = "Ungültige Freigabestufe! (0, 6, 12, 16, 18)";
                return;
            }

            Auflistung.Items[Auflistung.SelectedIndex] = (spiel.Name);

            Spielename.Clear();
            Entwicklerstudio.Clear();
            Erscheinungsjahr.Clear();
            Freigabestufe.Clear();
            Genre.Clear();
            Preis.Clear();
        }
        /// <summary>
        /// Programmieren des "Schließen" Buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Schluß_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
