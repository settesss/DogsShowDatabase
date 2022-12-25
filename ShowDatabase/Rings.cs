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
    public partial class FormRings : Form
    {
        public FormRings()
        {
            InitializeComponent();
        }

        private void рингBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.рингBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.выставкаDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void FormRings_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "выставкаDataSet.Эксперт_Ринг". При необходимости она может быть перемещена или удалена.
            this.эксперт_РингTableAdapter.Fill(this.выставкаDataSet.Эксперт_Ринг);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "выставкаDataSet.Собака_Ринг". При необходимости она может быть перемещена или удалена.
            this.собака_РингTableAdapter.Fill(this.выставкаDataSet.Собака_Ринг);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "выставкаDataSet.Ринг". При необходимости она может быть перемещена или удалена.
            this.рингTableAdapter.Fill(this.выставкаDataSet.Ринг);

        }

        private static FormRings ri;
        public static FormRings fr
        {
            get
            {
                if (ri == null || ri.IsDisposed) ri = new FormRings();
                return ri;
            }
        }

        public void ShowForm()
        {
            toolStripButtonOK.Visible = false;
            рингBindingSource.Position = 0;
            Show();
            Activate();
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos = рингBindingSource.Find("Название_породы", toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                рингBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких пород нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                рингBindingSource.Position = 0;
            }
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        рингBindingSource.Filter =
                       "Название_породы" + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                рингBindingSource.Filter = "";
            if (рингBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                рингBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }

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
               (int)((DataRowView)рингBindingSource.Current)["Код_ринга"];
            else
                return -1;
        }

        private void FormRings_Shown(object sender, EventArgs e)
        {
            рингBindingSource.Position =
            рингBindingSource.Find("Код_ринга", idCurrent);
        }



    }
}
