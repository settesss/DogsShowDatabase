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
    public partial class FormExpert_ring : Form
    {
        public FormExpert_ring()
        {
            InitializeComponent();
        }

        private void FormExpert_ring_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "выставкаDataSet.Эксперт_Ринг". При необходимости она может быть перемещена или удалена.
            this.эксперт_РингTableAdapter.Fill(this.выставкаDataSet.Эксперт_Ринг);

        }

        private void эксперт_РингBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.эксперт_РингBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.выставкаDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private static FormExpert_ring er;
        public static FormExpert_ring fer
        {
            get
            {
                if (er == null || er.IsDisposed) er = new FormExpert_ring();
                return er;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

    }
}
