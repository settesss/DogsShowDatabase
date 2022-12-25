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
    public partial class FormClubs : Form
    {
        public FormClubs()
        {
            InitializeComponent();
        }

        private void клубBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.клубBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.выставкаDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void Clubs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "выставкаDataSet.Хозяин". При необходимости она может быть перемещена или удалена.
            this.хозяинTableAdapter.Fill(this.выставкаDataSet.Хозяин);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "выставкаDataSet.Клуб". При необходимости она может быть перемещена или удалена.
            this.клубTableAdapter.Fill(this.выставкаDataSet.Клуб);
        }

        private static FormClubs cl;
        public static FormClubs fc
        {
            get
            {
                if (cl == null || cl.IsDisposed) cl = new FormClubs();
                return cl;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
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

        string GetSelectedFieldName()
        {
            return
           хозяинDataGridView.Columns[хозяинDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void хозяинDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (String.Compare(GetSelectedFieldName(), "Номер_родословной", false) ==
           0)
            {
                decimal price = 0;
                int idDishCurrent = -1;

                int.TryParse((((DataRowView)хозяинBindingSource.Current)["Номер_родословной"]).ToString(), out idDishCurrent);
                int idDish = FormDogs.fd.ShowSelectForm(idDishCurrent,
               out price);
                MessageBox.Show("Номер_родословной=" + idDish.ToString());
                ((DataRowView)хозяинBindingSource.Current)["Номер_родословной"] =
               idDish;
                хозяинBindingSource.EndEdit();
                хозяинTableAdapter.Update(this.выставкаDataSet);
                хозяинTableAdapter.Fill(this.выставкаDataSet.Хозяин);
            }
        }
    }
}
