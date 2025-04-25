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

        // Merke dir die Id des zuletzt selektierten Produkts
        private int lastSelectedProductKey;

        public ProductsScreen()
        {
            InitializeComponent();
            ShowProducts();

        }

         private void btnProductSave_Click(object sender, EventArgs e)
        {

            if (textBoxProductName.Text == "" ||
                textBoxProductBrand.Text == "" ||
                comboBoxProductCategory.Text == "Bitte wählen..." ||
                textBoxProductPrice.Text == "")
            {
                MessageBox.Show("Bitte fülle alle Felder aus!");
                
                // Programmabbruch
                return;
            }
            string productName = textBoxProductName.Text;
            string productBrand = textBoxProductBrand.Text;
            string productCategory = comboBoxProductCategory.Text;
            string productPrice = textBoxProductPrice.Text;

            string query = string.Format("insert into products values ('{0}', '{1}', '{2}', '{3}');",productName, productBrand, productCategory, productPrice);
            
            ExecuteQuery(query);
            ClearAllFields();
            ShowProducts();
            
        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {

            if (lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Produkt aus!");

                // Programmabbruch
                return;
            }

            string productName = textBoxProductName.Text;
            string productBrand = textBoxProductBrand.Text;
            string productCategory = comboBoxProductCategory.Text;
            string productPrice = textBoxProductPrice.Text;

            string query = string.Format("update products set name = '{0}', brand = '{1}', category = '{2}', price = '{3}' where id = {4};", productName, productBrand, productCategory, productPrice, lastSelectedProductKey);

            ExecuteQuery(query);
            ClearAllFields();
            ShowProducts();
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {

            if (lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Produkt aus!");

                // Programmabbruch
                return;
            }

            string query = string.Format("delete from products where id = {0};", lastSelectedProductKey);
            
            ExecuteQuery(query);
            ClearAllFields();
            ShowProducts();

        }

        private void btnProductClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void ClearAllFields()
        {
            textBoxProductName.Text = "";
            textBoxProductBrand.Text = "";
            textBoxProductPrice.Text = "";
            comboBoxProductCategory.SelectedItem = null;
            comboBoxProductCategory.Text = "Bitte wählen...";
        }

        private void ShowProducts()
        {
            // Daten aus DB-Lesen um diese bei Beginn anzuzeigen
            databaseConnection.Open();

            string query = "select * from Products";
            SqlDataAdapter adapter = new SqlDataAdapter(query, databaseConnection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            // Daten aus erster Tabelle
            productsDGV.DataSource = dataSet.Tables[0];
            productsDGV.Columns[0].Visible = false;
            databaseConnection.Close();
        }

        private void productsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxProductName.Text = productsDGV.SelectedRows[0].Cells[1].Value.ToString();
            textBoxProductBrand.Text = productsDGV.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxProductCategory.Text = productsDGV.SelectedRows[0].Cells[3].Value.ToString();
            textBoxProductPrice.Text = productsDGV.SelectedRows[0].Cells[4].Value.ToString();
            // Objekt in Integer casten
            lastSelectedProductKey = (int)productsDGV.SelectedRows[0].Cells[0].Value;

        }

        private void ExecuteQuery(string query)
        {
            databaseConnection.Open();
            SqlCommand cmd = new SqlCommand(query, databaseConnection);
            cmd.ExecuteNonQuery();
            databaseConnection.Close();
        }

    }
}
