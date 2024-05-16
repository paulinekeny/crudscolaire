using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace crudscolaire
{
    public partial class Form2 : Form
    {
        schoolEntities context = new schoolEntities();

        public Form2()
        {
            InitializeComponent();
            /*cmbclasse.DataSource = context.Classe.ToList();
            //cmbclasse.DataSource = context.Classe.ToList();
            cmbclasse.DisplayMember = "libelle";
            cmbclasse.ValueMember = "id";
            dataGridView1.DataSource = context.Etudiants.ToList();*/
            // Assurez-vous que le contrôle ComboBox est correctement lié à la source de données (contexte)
            cmbclasse.DataSource = context.Classe.ToList();

            // Définir la propriété DisplayMember pour afficher le libellé de la classe
            cmbclasse.DisplayMember = "libelle";

            // Définir la propriété ValueMember pour récupérer l'ID de la classe
            cmbclasse.ValueMember = "id";

            // Mettre à jour la source de données du DataGridView (dans votre cas, context.Etudiants)
            dataGridView1.DataSource = context.Etudiants.ToList();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            Etudiants etudiants = new Etudiants();
            etudiants.prenom = txtprenom.Text;
            etudiants.nom = txtnom.Text;
            etudiants.credit = int.Parse(txtcredit.Text);
            etudiants.montantverser  = int.Parse(txtreglement.Text);
            etudiants.anneescolaire = (txtanne.Text);
            etudiants.idclasse = Convert.ToInt32(cmbclasse.SelectedValue);
            context.Etudiants.Add(etudiants);
            context.SaveChanges();

            MessageBox.Show("Ajout reussi...");
            dataGridView1.DataSource = context.Etudiants.ToList();
            effacer();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                txtprenom.Text = row.Cells[1].Value.ToString();
                txtnom.Text = row.Cells[2].Value.ToString();
                txtcredit.Text = row.Cells[3].Value.ToString();
                txtreglement.Text = row.Cells[4].Value.ToString();
                txtanne.Text = row.Cells[5].Value.ToString();
                cmbclasse.Text = row.Cells[6].Value.ToString();

            }
        }

        void effacer()
        {
            txtprenom.Text = "";
            txtnom.Text = "";
            txtcredit.Text = "";
            txtreglement.Text = "";
            txtanne.Text = "";
            cmbclasse.Text = "";
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {

            var context = new schoolEntities();
            if (int.TryParse(txtid.Text.Trim(), out int entityId))
            {
                Etudiants personneToUpdate = context.Etudiants.Find(entityId);

                if (personneToUpdate != null)
                {
                    personneToUpdate.prenom = txtprenom.Text;
                    personneToUpdate.nom = txtnom.Text;
                    personneToUpdate.credit = int.Parse(txtcredit.Text);
                    personneToUpdate.montantverser = int.Parse(txtreglement.Text);
                    personneToUpdate.anneescolaire = (txtanne.Text);
                    personneToUpdate.idclasse = Convert.ToInt32(cmbclasse.SelectedValue);
                    context.SaveChanges();
                    MessageBox.Show("Modification réussie...");
                    dataGridView1.DataSource = context.Etudiants.ToList();
                    effacer();
                }
                else
                {
                    MessageBox.Show("Entité à mettre à jour non trouvée.");
                }
            }
            else
            {
                MessageBox.Show("ID invalide.");
            }

        }

        private void btnsuprimer_Click(object sender, EventArgs e)
        {

            var context = new schoolEntities();
            if (int.TryParse(txtid.Text.Trim(), out int entityId))
            {
                Etudiants etudiantToDelete = context.Etudiants.Find(entityId);

                if (etudiantToDelete != null)
                {
                    context.Etudiants.Remove(etudiantToDelete);
                    context.SaveChanges();
                    MessageBox.Show("Suppression réussie...");
                    dataGridView1.DataSource = context.Etudiants.ToList();
                    effacer();
                }
                else
                {
                    MessageBox.Show("Entité à supprimer non trouvée.");
                }
            }
            else
            {
                MessageBox.Show("ID invalide.");
            }
        }

        private void btnrechercher_Click(object sender, EventArgs e)
        {
            /*var context = new schoolEntities();
            string searchTerm = txtrechercher.Text.Trim();
            int selectedClasseId = Convert.ToInt32(cmbclasse.SelectedValue);
            var result = context.Etudiants
                                .Where(c => (c.anneescolaire.Contains(searchTerm) || c.prenom.Contains(searchTerm) || c.nom.Contains(searchTerm))
                                            && c.idclasse == selectedClasseId)
                                .ToList();

            dataGridView1.DataSource = result;*/
            string searchText = txtrechercher.Text.Trim();
            string libelleClasse = cmbclasse.Text.Trim();

            var etudiants = context.Etudiants.AsQueryable();

            if (!string.IsNullOrEmpty(searchText))
            {
                etudiants = etudiants.Where(etudiant => etudiant.anneescolaire.StartsWith(searchText));
            }

            if (!string.IsNullOrEmpty(libelleClasse))
            {
                etudiants = etudiants.Where(etudiant => etudiant.Classe.libelle.Contains(libelleClasse));
            }

            dataGridView1.DataSource = etudiants.ToList();
        }

        private void cmbclasse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
