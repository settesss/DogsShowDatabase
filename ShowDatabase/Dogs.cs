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
    public partial class FormDogs : Form
    {
        public FormDogs()
        {
            InitializeComponent();
        }

        private void Dogs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "выставкаDataSet.Хозяин". При необходимости она может быть перемещена или удалена.
            this.хозяинTableAdapter.Fill(this.выставкаDataSet.Хозяин);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "выставкаDataSet.Собака". При необходимости она может быть перемещена или удалена.
            this.собакаTableAdapter.Fill(this.выставкаDataSet.Собака);

        }

        string fileImage = "";
        private void buttonOpenPhoto_Click(object sender, EventArgs e)
        {
            openFileDialogPhoto.Title = "Укажите файл для фото";
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogPhoto.FileName;
                try
                {
                    фотоPictureBox.Image = new
                   Bitmap(openFileDialogPhoto.FileName);
                }
                catch
                {
                    MessageBox.Show("Выбран не тот формат файла", "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else fileImage = "";
        }

        private static FormDogs f;
        public static FormDogs fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormDogs();
                return f;
            }
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

        private void собакаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.собакаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.выставкаDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        public void ShowForm()
        {
            собакаBindingSource.Position = 0;
            Show();
            Activate();
        }

        int idCurrent = -1;
        public int ShowSelectForm(int idDish, out decimal price)
        {
            idCurrent = idDish;
            ShowDialog();
            price =
           (decimal)((DataRowView)собакаBindingSource.Current)["Приз"];
            return (int)((DataRowView)собакаBindingSource.Current)["Номер_родословной"];
        }

        private void FormDishesList_Shown(object sender, EventArgs e)
        {
           собакаBindingSource.Position = собакаBindingSource.Find("Номер_родословной", idCurrent);
        }

        private void buttonDogRing_Click(object sender, EventArgs e)
        {
            int id = -1;
            if
           (((DataRowView)собакаBindingSource.Current)["Номер_родословной"].ToString() !=
           "")
            {
                id =
               (int)(((DataRowView)собакаBindingSource.Current)["Номер_родословной"]);
            }
            id = FormDog_ring.fdg.ShowSelectForm(id);
            if (id >= 0)
            {
                MessageBox.Show(id.ToString());
                собакаBindingSource.EndEdit();
            }
        }
    }
}