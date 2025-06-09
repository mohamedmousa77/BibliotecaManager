using BibliotecaManager.Controllers;
using BibliotecaManager.Models;
using Microsoft.VisualBasic;
using System;
using System.Linq;
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
            dgvAutori.DataSource = personaController.Autori.Select(a => new Autore
            {
                ID = a.Persona.ID,
                Nome = a.Persona.Nome,
                Cognome = a.Persona.Cognome,
                CasaEditrice = a.CasaEditrice,
                IndiceDiGradimento = a.IndiceDiGradimento
            }).ToList();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            string nome = Prompt("Inserisci il nome:", "");
            string cognome = Prompt("Inserisci il cognome:", "");
            string casaEditrice = Prompt("Inserisci la casa editrice:", "");
            string gradimentoStr = Prompt("Inserisci l'indice di gradimento (1-5):", "3");

            if (!int.TryParse(gradimentoStr, out int gradimento) || gradimento < 1 || gradimento > 5)
            {
                MessageBox.Show("Indice di gradimento non valido. Inserisci un numero tra 1 e 5.");
                return;
            }
            var autore = new Autore
            {
                Persona = new Persona
                {
                    ID = Guid.NewGuid().ToString(),
                    Nome = nome,
                    Cognome =cognome
                },
                CasaEditrice = casaEditrice,
                IndiceDiGradimento = gradimento
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
