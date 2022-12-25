using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab2_.Properties;
using System.Data.SqlClient;

namespace Lab2_
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?",
            "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
            DialogResult.Yes;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР,КИБЭВС\nМанаков Никита Артемович, группа 580-3, 2022", "О программе",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void СобакиtoolStripButtonItem_Click(object sender, EventArgs e)
        {
            FormDogs.fd.ShowForm();
        }

        private void ЭкспертыStripButtonItem_Click(object sender, EventArgs e)
        {
            FormExperts.fe.ShowForm();
        }

        private void ОрганизаторыtoolStripButtonItem_Click(object sender, EventArgs e)
        {
            FormOrganizers.fo.ShowForm();
        }

        private void выставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow.fs.ShowForm();
        }

        private void рингиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRings.fr.ShowForm();
        }

        private void клубыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClubs.fc.ShowForm();
        }

        private void хозяеваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHosts.fh.ShowForm();
        }

        private void клубвыставкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClub_show.fcs.ShowForm();
        }

        private void собакарингToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDog_ring.fdg.ShowForm();
        }

        private void экспертрингToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExpert_ring.fer.ShowForm();
        }

        private void SQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSQL.fs.ShowForm();
        }
    }
}
