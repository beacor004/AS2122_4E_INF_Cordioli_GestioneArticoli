using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AS2122_4E_INF_Cordioli_GestioneArticoli.Library;

namespace AS2122_4E_INF_Cordioli_GestioneArticoli
{
    public partial class frmMain : Form
    {
        Dictionary<string, Articoli> articoli = new Dictionary<string, Articoli>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (articoli.ContainsKey(txtCodice.Text))
                articoli[txtCodice.Text] = new Articoli(txtCodice.Text, txtDescrizione.Text, Convert.ToInt32(txtPrezzo.Text), cmbUnita.Text);
            else
                //chiave non presente
                articoli.Add(txtCodice.Text, new Articoli(txtCodice.Text, txtDescrizione.Text, Convert.ToInt32(txtPrezzo.Text), cmbUnita.Text));

        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            lstVisualizza.Items.Clear();
            switch (cmbVisualizza.Text)
            {
                case "Visualizza Articoli":
                    foreach (KeyValuePair<string, Articoli> a in Articoli)
                    {
                        lstVisualizza.Items.Add(Articoli.Stampa());
                    }
                    break;
            }
        }
    }
    
}

