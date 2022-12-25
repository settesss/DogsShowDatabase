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
    public partial class FormExperts : Form
    {
        public FormExperts()
        {
            InitializeComponent();
        }

        private void экспертBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.экспертBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.выставкаDataSet);

        }

        private void Experts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "выставкаDataSet.Эксперт". При необходимости она может быть перемещена или удалена.
            this.экспертTableAdapter.Fill(this.выставкаDataSet.Эксперт);

        }

        private static FormExperts ex;
        public static FormExperts fe
        {
            get
            {
                if (ex == null || ex.IsDisposed) ex = new FormExperts();
                return ex;
            }
        }

        public void ShowForm()
        {
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
                indexPos = экспертBindingSource.Find("Стажировка", toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                экспертBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких экспертов нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                экспертBindingSource.Position = 0;
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
                        экспертBindingSource.Filter =
                      "Стажировка" + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                экспертBindingSource.Filter = "";
            if (экспертBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                экспертBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }


    }
}
