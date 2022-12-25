using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_
{
    public partial class FormDog_ring : Form
    {
        public FormDog_ring()
        {
            InitializeComponent();
        }

        private void FormDog_ring_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "выставкаDataSet.Собака_Ринг". При необходимости она может быть перемещена или удалена.
            this.собака_РингTableAdapter.Fill(this.выставкаDataSet.Собака_Ринг);

        }

        private void собака_РингBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.собака_РингBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.выставкаDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private static FormDog_ring dr;
        public static FormDog_ring fdg
        {
            get
            {
                if (dr == null || dr.IsDisposed) dr = new FormDog_ring();
                return dr;
            }
        }

        public void ShowForm()
        {
            toolStripButtonOK.Visible = false;
            собака_РингBindingSource.Position = 0;
            Show();
            Activate();
        }

        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        int idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            toolStripButtonOK.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return
               (int)((DataRowView)собака_РингBindingSource.Current)["Номер_родословной"];
            else
                return -1;
        }

        private void FormDog_ring_Shown(object sender, EventArgs e)
        {
            собака_РингBindingSource.Position =
            собака_РингBindingSource.Find("Номер_родословной", idCurrent);
        }
    }
}
