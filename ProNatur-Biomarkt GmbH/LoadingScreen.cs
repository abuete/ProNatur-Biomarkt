using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class LoadingScreen : Form
    {
        private int loadingBarValue;

        // Konstruktor
        public LoadingScreen()
        {
            InitializeComponent();
        }

        // Laden des Formular LoadingScreen
        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            // Timer starten
            loadingbarTimer.Start();

        }

        private void loadingbarTimer_Tick(object sender, EventArgs e)
        {
            // Pro Timertick wird die Variable um 5 erhöht
            loadingBarValue += 5;

            // Anzeige Prozentwert erhöhen pro Tick
            lblLoadingProgress.Text = loadingBarValue.ToString() + "%";

            // "Value" entspricht Property aus Eigenschaftenfenster
            loadingProgressbar.Value = loadingBarValue;

            if (loadingBarValue >= loadingProgressbar.Maximum)
            {
                // Timer stoppen
                loadingbarTimer.Stop();

                // Formular MainMenuScreen anzeigen
                MainMenuScreen mainMenuScreen = new MainMenuScreen();
                mainMenuScreen.Show();

                // Formular LoadingScreen verbergen
                // "this", da wir uns in dieser Klasse befinden
                this.Hide();
            }
        }    

        
    }
}
