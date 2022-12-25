using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Lab2_
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
        }

        private static FormSQL fsql;
        public static FormSQL fs
        {
            get
            {
                if (fsql == null || fsql.IsDisposed) fsql = new FormSQL();
                return fsql;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        DataTable FillDataGridView(string sqlSelect)
        {
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.ВыставкаConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
             DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void radioButtonShows_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"SELECT CAST(Выставка.Дата_проведения AS nvarchar) +' `' 
            + Выставка.Название_выставки + '` г.' + Выставка.Место_проведения AS О_выставке, 
            CAST(Организатор.Данные_паспорта AS nvarchar) +' ' +
            ФИО_организатора + ' кл. ' + Название_клуба AS Об_организаторе FROM Выставка, Организатор
            WHERE Выставка.Название_выставки = Организатор.Название_выставки");
        }

        private void radioButtonDogs_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"SELECT Кличка +' - ' + CAST(Возраст AS nvarchar) + ' лет' AS Участник,
            CAST(Занятое_место AS nvarchar) + ' место' AS Занял,
            Кличка_мамы +' и ' + Кличка_папы AS Родители
            FROM Собака");
        }

        private void radioButtonWinners_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"SELECT CAST(Хозяин.Данные_паспорта AS nvarchar) +' ' + Хозяин.ФИО_хозяина AS Владелец,
            Кличка AS Собачка,
            CAST((1 / CAST(Занятое_место AS decimal(16, 2))) * Возраст * 1000 AS decimal(16, 2)) AS Выигрыш
            FROM Собака, Хозяин
            WHERE(Занятое_место IS NOT NULL) AND(Собака.Номер_родословной = Хозяин.Номер_родословной)");
        }

        private void buttonF_Select_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxExpert.Text))
            {
                MessageBox.Show("Обязательно укажите необходимого эксперта.\nДопустим ввод первых символов.", "Внимание", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            if (checkBoxMore.Checked && String.IsNullOrEmpty(textBoxMore.Text))
            {
                MessageBox.Show("Не указана зарплата в условии", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBoxMore.Checked = false;
                return;
            }
            string sqlSelect = "";
            if (radioButtonSalary_notTrainee.Checked)
                sqlSelect = @"SELECT Эксперт.ФИО_эксперта AS Эксперт, Эксперт.Данные_паспорта AS Данные, Клуб.Название_клуба, 
                Эксперт.Стажировка, CAST(SUM(CAST(Эксперт.Стажировка AS decimal(16,2))*Эксперт.Данные_паспорта/12 + 16700) AS decimal(16,2)) AS Зарплата
                FROM Эксперт, Клуб
                WHERE (Эксперт.Название_клуба = Клуб.Название_клуба) AND (Эксперт.Стажировка = 0)
                GROUP BY Эксперт.Данные_паспорта, Эксперт.ФИО_эксперта, Эксперт.Стажировка, Клуб.Название_клуба";
            else
            if (radioButtonSalary_trainee.Checked)
                sqlSelect = @"SELECT Эксперт.ФИО_эксперта AS Эксперт, Эксперт.Данные_паспорта AS Данные, Клуб.Название_клуба, 
                Эксперт.Стажировка, CAST(SUM(CAST(Эксперт.Стажировка AS decimal(16,2))*Эксперт.Данные_паспорта/12 + 16700) AS decimal(16,2)) AS Зарплата
                FROM Эксперт, Клуб
                WHERE (Эксперт.Название_клуба = Клуб.Название_клуба) AND (Эксперт.Стажировка = 1)
                GROUP BY Эксперт.Данные_паспорта, Эксперт.ФИО_эксперта, Эксперт.Стажировка, Клуб.Название_клуба";
            else
            if (radioButtonSalary_notAll.Checked)
                sqlSelect = @"SELECT Эксперт.ФИО_эксперта AS Эксперт, Эксперт.Данные_паспорта AS Данные, 
                Эксперт.Стажировка, CAST(SUM(CAST(Эксперт.Стажировка AS decimal(16,2))*Эксперт.Данные_паспорта/12 + 16700) AS decimal(16,2)) AS Зарплата
                FROM Эксперт
                WHERE (Эксперт.Название_клуба IS NULL)
                GROUP BY Эксперт.Данные_паспорта, Эксперт.ФИО_эксперта, Эксперт.Стажировка";
            else
                sqlSelect = @"SELECT Эксперт.ФИО_эксперта AS Эксперт, Эксперт.Данные_паспорта AS Данные, 
                Эксперт.Стажировка, CAST(SUM(CAST(Эксперт.Стажировка AS decimal(16,2))*Эксперт.Данные_паспорта/12 + 16700) AS decimal(16,2)) AS Зарплата
                FROM Эксперт
                WHERE Эксперт.ФИО_эксперта LIKE @last_name
                GROUP BY Эксперт.Данные_паспорта, Эксперт.ФИО_эксперта, Эксперт.Стажировка";
            if (checkBoxMore.Checked)
                sqlSelect += " HAVING SUM(CAST(Эксперт.Стажировка AS decimal(16,2))*Эксперт.Данные_паспорта/12 + 16700) > @amount";
            if (checkBoxOrder.Checked)
                sqlSelect += " ORDER BY SUM(CAST(Эксперт.Стажировка AS decimal(16,2))*Эксперт.Данные_паспорта/12 + 16700) desc";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.ВыставкаConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@last_name", textBoxExpert.Text + "%");
            if (checkBoxMore.Checked)
                try
                {
                    command.Parameters.Add("@amount", SqlDbType.Money).Value =
                   Double.Parse(textBoxMore.Text);
                }
                catch
                {
                    MessageBox.Show("Прибыль в условии должна быть задана числом", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkBoxMore.Checked = false;
                    return;
                }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewFSelect.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!",
           "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSubquery_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxDate.Text))
            {
                MessageBox.Show("Обязательно укажите дату необходимой выставки",
               "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlSelect = "";

            if (radioButtonCorrelated.Checked)
                sqlSelect = @"SELECT Название_выставки, Место_проведения, Дата_проведения
                FROM Выставка
                WHERE 30 >= (SELECT Возраст FROM Организатор
                WHERE Организатор.Название_выставки = Выставка.Название_выставки)
                AND Выставка.Дата_проведения <= @date";
            else
            if (radioButtonNoCorrelated.Checked)
                sqlSelect = @"SELECT Название_выставки, Место_проведения, Дата_проведения
                FROM Выставка
                WHERE Дата_проведения <= @date
                AND Название_выставки IN (SELECT Название_выставки FROM Организатор WHERE Возраст <= 30)";
            else
            {
                MessageBox.Show("Не выбрали вид подзапроса", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection connection = new
           SqlConnection(Properties.Settings.Default.ВыставкаConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            try
            {
                command.Parameters.Add("@date", SqlDbType.DateTime).Value =
               DateTime.Parse(textBoxDate.Text);
            }
            catch
            {
                MessageBox.Show("Дата выставки в условии должна быть задана в виде ГГГГ.ММ.ДД", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSubquery.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!",
           "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        void InsertClub()
        {
            if (String.IsNullOrEmpty(textBoxName_Club.Text))
            {
                MessageBox.Show("Обязательно введите название клуба", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
            }
            int hostcount, dogcount;
            if (!int.TryParse(textBoxHostCount_Club.Text, out hostcount))
            {
                MessageBox.Show("Некоректное значение участников!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxDogCount_Club.Text, out dogcount))
            {
                MessageBox.Show("Некоректное значение собак!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlInsert = @"INSERT INTO Клуб (Название_клуба, Количество_собак, Количество_участников, Сведения_о_медалях) 
            VALUES (@name, @dogcount, @hostcount, @desc)";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.ВыставкаConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@name", textBoxName_Club.Text);
            command.Parameters.AddWithValue("@dogcount", dogcount);
            command.Parameters.AddWithValue("@hostcount", hostcount);
            command.Parameters.AddWithValue("@desc", textBoxDesc_Club.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Close();
            buttonSelectClubs_Click(this, EventArgs.Empty);
        }

        void UpdateClub()
        {
            if (String.IsNullOrEmpty(textBoxName_Club.Text))
            {
                MessageBox.Show("Обязательно введите название клуба", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int hostcount, dogcount;
            if (!int.TryParse(textBoxHostCount_Club.Text, out hostcount))
            {
                MessageBox.Show("Некоректное значение участников!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxDogCount_Club.Text, out dogcount))
            {
                MessageBox.Show("Некоректное значение собак!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.ВыставкаConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            string sqlUpdate = "UPDATE Клуб SET Количество_собак=@dogcount, Количество_участников=@hostcount, Сведения_о_медалях=@desc  WHERE Название_клуба = @name";

            string sqlValues = "";
            if (!String.IsNullOrEmpty(textBoxName_Club.Text))
                sqlValues += "Название=@name,";
            if (!String.IsNullOrEmpty(textBoxDogCount_Club.Text))
                sqlValues += "Собаки=@dogcount,";
            if (!String.IsNullOrEmpty(textBoxHostCount_Club.Text))
                sqlValues += "Участники=@hostcount,";
            if (!String.IsNullOrEmpty(textBoxDesc_Club.Text))
                sqlValues += "Сведения=@desc,";

            command.CommandText = String.Format(sqlUpdate, sqlValues);

            if (!String.IsNullOrEmpty(textBoxName_Club.Text))
                command.Parameters.AddWithValue("@name", textBoxName_Club.Text);
            if (!String.IsNullOrEmpty(textBoxDogCount_Club.Text))
                command.Parameters.AddWithValue("@dogcount", textBoxDogCount_Club.Text);
            if (!String.IsNullOrEmpty(textBoxHostCount_Club.Text))
                command.Parameters.AddWithValue("@hostcount", textBoxHostCount_Club.Text);
            if (!String.IsNullOrEmpty(textBoxDesc_Club.Text))
                command.Parameters.AddWithValue("@desc", textBoxDesc_Club.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message,
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            buttonSelectClubs_Click(this, EventArgs.Empty);
        }

        void DeleteClub()
        {
            if (String.IsNullOrEmpty(textBoxName_Club.Text))
            {
                MessageBox.Show("Обязательно введите название клуба", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlDelete = @"DELETE FROM Клуб WHERE Название_клуба=@name";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.ВыставкаConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@name", textBoxName_Club.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка удаления");
            }
            connection.Close();
            buttonSelectClubs_Click(this, EventArgs.Empty);
        }

        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonInsert_Club.Checked)
                InsertClub();
             else
             if (radioButtonUpdate_Club.Checked)
                UpdateClub();
             else
             if (radioButtonDelete_Club.Checked)
                DeleteClub();
             else
             MessageBox.Show("Вы не выбрали действие", "Внимание",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void buttonSelectClubs_Click(object sender, EventArgs e)
        {
            dataGridViewClub.DataSource = FillDataGridView("SELECT * FROM Клуб");
        }

        private void radioButtonDelete_Club_CheckedChanged(object sender, EventArgs e)
        {
            panelClub.Visible = !radioButtonDelete_Club.Checked;
        }
    }
}
