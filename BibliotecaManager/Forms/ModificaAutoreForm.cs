using BibliotecaManager.Models;
using System;
using System.Windows.Forms;

namespace BibliotecaManager.Forms
{
    public partial class ModificaAutoreForm : Form
    {
        public Autore AutoreModificato { get; private set; }

        public ModificaAutoreForm(Autore autore)
        {
            InitializeComponent();

            if (autore == null)
                throw new ArgumentNullException(nameof(autore));

            AutoreModificato = autore;
        }

        private void ModificaAutoreForm_Load(object sender, EventArgs e)
        {
            txtNome.Text = AutoreModificato.Persona.Nome;
            txtCognome.Text = AutoreModificato.Persona.Cognome;
            txtCasaEditrice.Text = AutoreModificato.CasaEditrice;
            numGradimento.Value = AutoreModificato.IndiceDiGradimento;

            this.Text = $"Modifica Autore - {AutoreModificato.Persona.Nome} {AutoreModificato.Persona.Cognome}";
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            if (ValidaDati())
            {
                AutoreModificato.Persona.Nome = txtNome.Text.Trim();
                AutoreModificato.Persona.Cognome = txtCognome.Text.Trim();
                AutoreModificato.CasaEditrice = txtCasaEditrice.Text.Trim();
                AutoreModificato.IndiceDiGradimento = (int)numGradimento.Value;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidaDati()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Inserire il nome dell'autore", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCognome.Text))
            {
                MessageBox.Show("Inserire il cognome dell'autore", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCognome.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCasaEditrice.Text))
            {
                MessageBox.Show("Inserire la casa editrice", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCasaEditrice.Focus();
                return false;
            }
            return true;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ModificaAutoreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK && DialogResult != DialogResult.Cancel)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}