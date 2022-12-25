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
    public partial class FormClub_show : Form
    {
        public FormClub_show()
        {
            InitializeComponent();
        }

        private void клуб_ВыставкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.клуб_ВыставкаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.выставкаDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void Club_show_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "выставкаDataSet.Клуб_Выставка". При необходимости она может быть перемещена или удалена.
            this.клуб_ВыставкаTableAdapter.Fill(this.выставкаDataSet.Клуб_Выставка);

        }

        private static FormClub_show cs;
        public static FormClub_show fcs
        {
            get
            {
                if (cs == null || cs.IsDisposed) cs = new FormClub_show();
                return cs;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }
    }
}
