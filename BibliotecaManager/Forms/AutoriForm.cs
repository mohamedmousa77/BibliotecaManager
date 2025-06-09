using BibliotecaManager.Controllers;
using BibliotecaManager.Models;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace BibliotecaManager.Forms
{
    public partial class AutoriForm : Form
    {
        private PersonaController personaController;
        public AutoriForm(PersonaController controller)
        {
            InitializeComponent();
            personaController = controller;
            AggiornaGrid();
        }

        private void AggiornaGrid()
        {
            dgvAutori.DataSource = null;
            dgvAutori.DataSource = personaController.Autori;
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            var autore = new Autore
            {
                Persona = new Persona
                {
                    ID = Guid.NewGuid().ToString(),
                    Nome = "Nuovo",
                    Cognome = "Autore"
                },
                IndiceDiGradimento = 3,
                CasaEditrice = "Default"
            };

            personaController.AggingiAutore(autore);
            AggiornaGrid();

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dgvAutori.CurrentRow?.DataBoundItem is Autore autore)
            {
                autore.Persona.Nome = Prompt("Modifica nome:", autore.Persona.Nome);
                autore.Persona.Cognome = Prompt("Modifica cognome:", autore.Persona.Cognome);
                autore.CasaEditrice = Prompt("Modifica casa editrice:", autore.CasaEditrice);
                // Altri campi...
                AggiornaGrid();
            }
        }

        private string Prompt(string text, string defaultValue)
        {
            string input = Interaction.InputBox(text, "Modifica", defaultValue);
            return string.IsNullOrWhiteSpace(input) ? defaultValue : input;
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (dgvAutori.CurrentRow?.DataBoundItem is Autore autore)
            {
                personaController.EliminaAutore(autore);
                AggiornaGrid();
            }
        }
    }
}
