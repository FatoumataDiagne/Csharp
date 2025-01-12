using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORML3IAGE
{
    public partial class Form1 : Form
    {
        List<Personne> list = new List<Personne>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)

        {
  
            Personne personne = new Personne();
            personne.prenom = txtPrenom.Text;
            personne.nom = txtNom.Text;
            personne.tel = txtTel.Text;
            if (rbFemme.Checked)
            {
                personne.sexe = "Femme";
            }
            else
            {
                personne.sexe = "Homme";
            }
            String tempocomb = "";
            if (ckbJava.Checked)
            {
                tempocomb += "JAVA";
            }
            if (ckbPhp.Checked)
            {
                tempocomb += "PHP";
            }
            if (ckbCplusplus.Checked)
            {
                tempocomb += "C++";
            }
            if (ckbCsharp.Checked)
            {
                tempocomb += "C#";
            }
            personne.competences = tempocomb;
            personne.classe = cmbClasse.Text;
        


            //Save data in list de personne
            list.Add(personne);
           
            MessageBox.Show("Données ajoutées", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // chargement du Datagrid View
            refresh();
            
            
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;

            effacer();

        }
        private void effacer()
        {
            txtPrenom.Text = String.Empty;
            txtNom.Text = String.Empty;
            txtTel.Text = String.Empty;
            rbFemme.Checked = false;
            rbHomme.Checked = false;
            ckbCplusplus.Checked = false;
            ckbJava.Checked = false;
            ckbPhp.Checked = false;
            ckbCsharp.Checked = false;
            cmbClasse.Text="selectionnez";


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            effacer();
        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        Personne personneselected = null;
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex<list.Count)
            {

                personneselected = list[e.RowIndex];
                txtNom.Text = personneselected.nom;
                txtPrenom.Text = personneselected.prenom;
                txtTel.Text = personneselected.tel;
                if (personneselected.sexe =="Femme")
                {
                  rbFemme.Checked=true;
                }
                else
                {
                    rbHomme.Checked=true;
                }
                String[] langue = personneselected.competences.Split();
                ckbCplusplus.Checked = langue.Contains("C++");
                ckbCsharp.Checked = langue.Contains("C#");
                ckbJava.Checked = langue.Contains("JAVA");
                ckbPhp.Checked = langue.Contains("PHP");
                cmbClasse.Text = personneselected.classe;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (personneselected == null)
            {
                MessageBox.Show("Verifiez que vous avez selcetionné", "Avertissement", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult result = MessageBox.Show("Voulez-vous confirmer la suppression", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    list.Remove(personneselected);
                    refresh();
                    effacer();
                }


            }
        }
        public void refresh()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (personneselected == null)
            {
                MessageBox.Show("Verifiez que vous avez selcetionné", "Avertissement", MessageBoxButtons.OK);
            }
            else
            {
                int pos=list.IndexOf(personneselected);
                personneselected.nom = txtNom.Text;
                personneselected.prenom = txtPrenom.Text;
                personneselected.tel = txtTel.Text;
                personneselected.sexe = (rbFemme.Checked) ? "Femme" : "Homme";
                String tempocomb = "";
                if (ckbJava.Checked)
                {
                    tempocomb += "JAVA";
                }
                if (ckbPhp.Checked)
                {
                    tempocomb += "PHP";
                }
                if (ckbCplusplus.Checked)
                {
                    tempocomb += "C++";
                }
                if (ckbCsharp.Checked)
                {
                    tempocomb += "C#";
                }
                personneselected.competences = tempocomb;
                personneselected.classe = cmbClasse.Text;

                list[pos] = personneselected;
                refresh();
                effacer();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}