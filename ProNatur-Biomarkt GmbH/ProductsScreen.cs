using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class ProductsScreen : Form
    {
        // Datenbankverbindung
        // Kopieren von Datenbankeigenschaften und dann doppelte Anführungszeichen um den String einfügen
        // @-Symbol vor den gesamten String setzen
        // Anführungszeichen von Pfad entfernen
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Alex\Documents\Pro-Natur Biomarkt GmbH.mdf;Integrated Security = True; Connect Timeout = 30");

        public ProductsScreen()
        {
            InitializeComponent();

            // Daten aus DB-Lesen um diese bei Beginn anzuzeigen
            databaseConnection.Open();
            
            string query = "select * from Products";
            SqlDataAdapter adapter = new SqlDataAdapter(query,databaseConnection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            // Daten aus erster Tabelle
            productsDGV.DataSource = dataSet.Tables[0];
            productsDGV.Columns[0].Visible = false;
            databaseConnection.Close();

        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {

        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnProductClear_Click(object sender, EventArgs e)
        {

        }
    }
}
