using BibliotecaManager.Models;
using System;
using System.Windows.Forms;

namespace BibliotecaManager.Forms
{
    public partial class InserisciAutoreForm : Form
    {
        public Autore Autore { get; private set; }

        public InserisciAutoreForm()
        {
            InitializeComponent();
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            if (ValidaDati())
            {
                Autore = new Autore
                {
                    Persona = new Persona
                    {
                        ID = Guid.NewGuid().ToString(),
                        Nome = txtNome.Text,
                        Cognome = txtCognome.Text
                    },
                    CasaEditrice = txtCasaEditrice.Text,
                    IndiceDiGradimento = (int)numGradimento.Value
                };
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidaDati()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Inserire il nome dell'autore");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCognome.Text))
            {
                MessageBox.Show("Inserire il cognome dell'autore");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCasaEditrice.Text))
            {
                MessageBox.Show("Inserire la casa editrice");
                return false;
            }
            return true;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}