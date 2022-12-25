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
    public partial class FormHosts : Form
    {
        public FormHosts()
        {
            InitializeComponent();
        }

        private void хозяинBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.хозяинBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.выставкаDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void Hosts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "выставкаDataSet.Собака". При необходимости она может быть перемещена или удалена.
            this.собакаTableAdapter.Fill(this.выставкаDataSet.Собака);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "выставкаDataSet.Хозяин". При необходимости она может быть перемещена или удалена.
            this.хозяинTableAdapter.Fill(this.выставкаDataSet.Хозяин);

        }

        private static FormHosts ho;
        public static FormHosts fh
        {
            get
            {
                if (ho == null || ho.IsDisposed) ho = new FormHosts();
                return ho;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }
    }
}
