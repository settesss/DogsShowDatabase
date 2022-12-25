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
    public partial class FormShow : Form
    {
        public FormShow()
        {
            InitializeComponent();
        }

        private void выставкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.выставкаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.выставкаDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void Show_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "выставкаDataSet.Выставка". При необходимости она может быть перемещена или удалена.
            this.выставкаTableAdapter.Fill(this.выставкаDataSet.Выставка);
        }

        private static FormShow sh;
        public static FormShow fs
        {
            get
            {
                if (sh == null || sh.IsDisposed) sh = new FormShow();
                return sh;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void выставкаDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if
            ((выставкаDataGridView.Rows[e.RowIndex].Cells["видDataGridViewTextBoxColumn"].Value == null) ||
            (выставкаDataGridView.Rows[e.RowIndex].Cells["видDataGridViewTextBoxColumn"
            ].Value.ToString() == ""))
                e.CellStyle.BackColor = Color.Beige;
            else
            {
                if
               (выставкаDataGridView.Rows[e.RowIndex].Cells["видDataGridViewTextBoxColumn"
               ].Value.ToString() == "Монопородная")
                    e.CellStyle.BackColor = Color.LightSalmon;
                else
                    e.CellStyle.BackColor = Color.DarkSalmon;
            }
        }
    }
}
