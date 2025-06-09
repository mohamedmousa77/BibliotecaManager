using BibliotecaManager.Controllers;
using System;
using System.Windows.Forms;
namespace BibliotecaManager.Forms
{
    public partial class MainForm : Form
    {
        private PersonaController personaController;
        private void MainForm_Load(object sender, EventArgs e)
        {
            // inizializzazioni al caricamento
            InitializeComponent();
        }
        public MainForm()
        {
            InitializeComponent();
            InitializeMenu();
            personaController = new PersonaController();
        }

        private void InitializeMenu()
        {
            var menuStrip = new MenuStrip();

            var gestioneMenu = new ToolStripMenuItem("Gestione");
            gestioneMenu.DropDownItems.Add("Autori", null, (s, e) => new AutoriForm(personaController).ShowDialog());
            gestioneMenu.DropDownItems.Add("Clienti", null, (s, e) => new ClientiForm().ShowDialog());
            gestioneMenu.DropDownItems.Add("Libri", null, (s, e) => new LibriForm().ShowDialog());
            gestioneMenu.DropDownItems.Add("Prestiti", null, (s, e) => new PrestitiForm().ShowDialog());

            var statisticheMenu = new ToolStripMenuItem("Statiche");
            statisticheMenu.Click += (s, e) => new StatisticheForm().ShowDialog();

            var archivioMenu = new ToolStripMenuItem("Archivio");
            archivioMenu.DropDownItems.Add("Salva", null, (s, e) => SalvaArchivio());
            archivioMenu.DropDownItems.Add("Carica", null, (s, e) => CaricaArchivio());

            menuStrip.Items.Add(gestioneMenu);
            menuStrip.Items.Add(statisticheMenu);
            menuStrip.Items.Add(archivioMenu);
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);

        }

        public void SalvaArchivio()
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Archivio salvato.");
                }
            }

        }

        public void CaricaArchivio()
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Archivio caricato.");
                }
            }


        }
    }
}
