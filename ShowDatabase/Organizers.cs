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
    public partial class FormOrganizers : Form
    {
        public FormOrganizers()
        {
            InitializeComponent();
        }

        private void организаторBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.организаторBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.выставкаDataSet);

        }

        private void Organizers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "выставкаDataSet.Организатор". При необходимости она может быть перемещена или удалена.
            this.организаторTableAdapter.Fill(this.выставкаDataSet.Организатор);

        }

        private static FormOrganizers org;
        public static FormOrganizers fo
        {
            get
            {
                if (org == null || org.IsDisposed) org = new FormOrganizers();
                return org;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

    }
}
