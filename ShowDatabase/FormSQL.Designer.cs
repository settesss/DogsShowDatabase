
namespace Lab2_
{
    partial class FormSQL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPages = new System.Windows.Forms.TabControl();
            this.tabPagePrimer = new System.Windows.Forms.TabPage();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonWinners = new System.Windows.Forms.RadioButton();
            this.radioButtonDogs = new System.Windows.Forms.RadioButton();
            this.radioButtonShows = new System.Windows.Forms.RadioButton();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.dataGridViewFSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxFSelect = new System.Windows.Forms.GroupBox();
            this.buttonF_Select = new System.Windows.Forms.Button();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.textBoxMore = new System.Windows.Forms.TextBox();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.groupBoxDet = new System.Windows.Forms.GroupBox();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonSalary_notAll = new System.Windows.Forms.RadioButton();
            this.radioButtonSalary_trainee = new System.Windows.Forms.RadioButton();
            this.radioButtonSalary_notTrainee = new System.Windows.Forms.RadioButton();
            this.textBoxExpert = new System.Windows.Forms.TextBox();
            this.labelExpert = new System.Windows.Forms.Label();
            this.tabPageSubquery = new System.Windows.Forms.TabPage();
            this.dataGridViewSubquery = new System.Windows.Forms.DataGridView();
            this.groupBoxSubquery = new System.Windows.Forms.GroupBox();
            this.buttonSubquery = new System.Windows.Forms.Button();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.radioButtonNoCorrelated = new System.Windows.Forms.RadioButton();
            this.radioButtonCorrelated = new System.Windows.Forms.RadioButton();
            this.tabPageDML = new System.Windows.Forms.TabPage();
            this.panelClub = new System.Windows.Forms.Panel();
            this.textBoxDesc_Club = new System.Windows.Forms.TextBox();
            this.textBoxHostCount_Club = new System.Windows.Forms.TextBox();
            this.textBoxDogCount_Club = new System.Windows.Forms.TextBox();
            this.labelDesc_Club = new System.Windows.Forms.Label();
            this.labelHostCount_Club = new System.Windows.Forms.Label();
            this.labelDogCount_Club = new System.Windows.Forms.Label();
            this.buttonSelectClubs = new System.Windows.Forms.Button();
            this.dataGridViewClub = new System.Windows.Forms.DataGridView();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.textBoxName_Club = new System.Windows.Forms.TextBox();
            this.labelName_Club = new System.Windows.Forms.Label();
            this.groupBoxDML = new System.Windows.Forms.GroupBox();
            this.radioButtonDelete_Club = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate_Club = new System.Windows.Forms.RadioButton();
            this.radioButtonInsert_Club = new System.Windows.Forms.RadioButton();
            this.openFileDialogDog = new System.Windows.Forms.OpenFileDialog();
            this.tabPages.SuspendLayout();
            this.tabPagePrimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).BeginInit();
            this.groupBoxFSelect.SuspendLayout();
            this.groupBoxDet.SuspendLayout();
            this.tabPageSubquery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).BeginInit();
            this.groupBoxSubquery.SuspendLayout();
            this.tabPageDML.SuspendLayout();
            this.panelClub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClub)).BeginInit();
            this.groupBoxDML.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPages
            // 
            this.tabPages.Controls.Add(this.tabPagePrimer);
            this.tabPages.Controls.Add(this.tabPageSelect);
            this.tabPages.Controls.Add(this.tabPageSubquery);
            this.tabPages.Controls.Add(this.tabPageDML);
            this.tabPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPages.Location = new System.Drawing.Point(0, 0);
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(800, 589);
            this.tabPages.TabIndex = 0;
            // 
            // tabPagePrimer
            // 
            this.tabPagePrimer.Controls.Add(this.dataGridViewSelect);
            this.tabPagePrimer.Controls.Add(this.groupBoxSelect);
            this.tabPagePrimer.Location = new System.Drawing.Point(4, 25);
            this.tabPagePrimer.Name = "tabPagePrimer";
            this.tabPagePrimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrimer.Size = new System.Drawing.Size(792, 506);
            this.tabPagePrimer.TabIndex = 0;
            this.tabPagePrimer.Text = "Примеры запросов";
            this.tabPagePrimer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 80);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.RowHeadersWidth = 51;
            this.dataGridViewSelect.RowTemplate.Height = 24;
            this.dataGridViewSelect.Size = new System.Drawing.Size(786, 423);
            this.dataGridViewSelect.TabIndex = 1;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButtonWinners);
            this.groupBoxSelect.Controls.Add(this.radioButtonDogs);
            this.groupBoxSelect.Controls.Add(this.radioButtonShows);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(786, 77);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Запросы по данным";
            // 
            // radioButtonWinners
            // 
            this.radioButtonWinners.AutoSize = true;
            this.radioButtonWinners.Location = new System.Drawing.Point(225, 30);
            this.radioButtonWinners.Name = "radioButtonWinners";
            this.radioButtonWinners.Size = new System.Drawing.Size(110, 21);
            this.radioButtonWinners.TabIndex = 3;
            this.radioButtonWinners.TabStop = true;
            this.radioButtonWinners.Text = "Победители";
            this.radioButtonWinners.UseVisualStyleBackColor = true;
            this.radioButtonWinners.CheckedChanged += new System.EventHandler(this.radioButtonWinners_CheckedChanged);
            // 
            // radioButtonDogs
            // 
            this.radioButtonDogs.AutoSize = true;
            this.radioButtonDogs.Location = new System.Drawing.Point(123, 30);
            this.radioButtonDogs.Name = "radioButtonDogs";
            this.radioButtonDogs.Size = new System.Drawing.Size(77, 21);
            this.radioButtonDogs.TabIndex = 2;
            this.radioButtonDogs.TabStop = true;
            this.radioButtonDogs.Text = "Собаки";
            this.radioButtonDogs.UseVisualStyleBackColor = true;
            this.radioButtonDogs.CheckedChanged += new System.EventHandler(this.radioButtonDogs_CheckedChanged);
            // 
            // radioButtonShows
            // 
            this.radioButtonShows.AutoSize = true;
            this.radioButtonShows.Location = new System.Drawing.Point(6, 30);
            this.radioButtonShows.Name = "radioButtonShows";
            this.radioButtonShows.Size = new System.Drawing.Size(92, 21);
            this.radioButtonShows.TabIndex = 0;
            this.radioButtonShows.TabStop = true;
            this.radioButtonShows.Text = "Выставки";
            this.radioButtonShows.UseVisualStyleBackColor = true;
            this.radioButtonShows.CheckedChanged += new System.EventHandler(this.radioButtonShows_CheckedChanged);
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.dataGridViewFSelect);
            this.tabPageSelect.Controls.Add(this.groupBoxFSelect);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 25);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(792, 506);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полная запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFSelect
            // 
            this.dataGridViewFSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFSelect.Location = new System.Drawing.Point(3, 219);
            this.dataGridViewFSelect.Name = "dataGridViewFSelect";
            this.dataGridViewFSelect.RowHeadersWidth = 51;
            this.dataGridViewFSelect.RowTemplate.Height = 24;
            this.dataGridViewFSelect.Size = new System.Drawing.Size(786, 284);
            this.dataGridViewFSelect.TabIndex = 1;
            // 
            // groupBoxFSelect
            // 
            this.groupBoxFSelect.Controls.Add(this.buttonF_Select);
            this.groupBoxFSelect.Controls.Add(this.checkBoxOrder);
            this.groupBoxFSelect.Controls.Add(this.textBoxMore);
            this.groupBoxFSelect.Controls.Add(this.checkBoxMore);
            this.groupBoxFSelect.Controls.Add(this.groupBoxDet);
            this.groupBoxFSelect.Controls.Add(this.textBoxExpert);
            this.groupBoxFSelect.Controls.Add(this.labelExpert);
            this.groupBoxFSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFSelect.Name = "groupBoxFSelect";
            this.groupBoxFSelect.Size = new System.Drawing.Size(786, 216);
            this.groupBoxFSelect.TabIndex = 0;
            this.groupBoxFSelect.TabStop = false;
            this.groupBoxFSelect.Text = "Выручка экспертов";
            // 
            // buttonF_Select
            // 
            this.buttonF_Select.Location = new System.Drawing.Point(291, 48);
            this.buttonF_Select.Name = "buttonF_Select";
            this.buttonF_Select.Size = new System.Drawing.Size(204, 68);
            this.buttonF_Select.TabIndex = 6;
            this.buttonF_Select.Text = "Зарплата экспертов";
            this.buttonF_Select.UseVisualStyleBackColor = true;
            this.buttonF_Select.Click += new System.EventHandler(this.buttonF_Select_Click);
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Location = new System.Drawing.Point(6, 131);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(197, 38);
            this.checkBoxOrder.TabIndex = 5;
            this.checkBoxOrder.Text = "Включить сортировку по \r\nубыванию зарплаты";
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            // 
            // textBoxMore
            // 
            this.textBoxMore.Location = new System.Drawing.Point(159, 94);
            this.textBoxMore.Name = "textBoxMore";
            this.textBoxMore.Size = new System.Drawing.Size(126, 22);
            this.textBoxMore.TabIndex = 4;
            // 
            // checkBoxMore
            // 
            this.checkBoxMore.AutoSize = true;
            this.checkBoxMore.Location = new System.Drawing.Point(6, 87);
            this.checkBoxMore.Name = "checkBoxMore";
            this.checkBoxMore.Size = new System.Drawing.Size(172, 38);
            this.checkBoxMore.TabIndex = 3;
            this.checkBoxMore.Text = "Выдать зарплату       \r\nболее";
            this.checkBoxMore.UseVisualStyleBackColor = true;
            // 
            // groupBoxDet
            // 
            this.groupBoxDet.Controls.Add(this.radioButtonAll);
            this.groupBoxDet.Controls.Add(this.radioButtonSalary_notAll);
            this.groupBoxDet.Controls.Add(this.radioButtonSalary_trainee);
            this.groupBoxDet.Controls.Add(this.radioButtonSalary_notTrainee);
            this.groupBoxDet.Location = new System.Drawing.Point(501, 21);
            this.groupBoxDet.Name = "groupBoxDet";
            this.groupBoxDet.Size = new System.Drawing.Size(279, 183);
            this.groupBoxDet.TabIndex = 2;
            this.groupBoxDet.TabStop = false;
            this.groupBoxDet.Text = "Детализация прибыли экспертов";
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(6, 153);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(129, 21);
            this.radioButtonAll.TabIndex = 3;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "Без изменений";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonSalary_notAll
            // 
            this.radioButtonSalary_notAll.AutoSize = true;
            this.radioButtonSalary_notAll.Location = new System.Drawing.Point(6, 109);
            this.radioButtonSalary_notAll.Name = "radioButtonSalary_notAll";
            this.radioButtonSalary_notAll.Size = new System.Drawing.Size(221, 38);
            this.radioButtonSalary_notAll.TabIndex = 2;
            this.radioButtonSalary_notAll.TabStop = true;
            this.radioButtonSalary_notAll.Text = "Прибыль эксперта без клуба\r\n(стажировка не важна)";
            this.radioButtonSalary_notAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonSalary_trainee
            // 
            this.radioButtonSalary_trainee.AutoSize = true;
            this.radioButtonSalary_trainee.Location = new System.Drawing.Point(6, 65);
            this.radioButtonSalary_trainee.Name = "radioButtonSalary_trainee";
            this.radioButtonSalary_trainee.Size = new System.Drawing.Size(209, 38);
            this.radioButtonSalary_trainee.TabIndex = 1;
            this.radioButtonSalary_trainee.TabStop = true;
            this.radioButtonSalary_trainee.Text = "Прибыль эксперта в клубе \r\n(со стажировкой)";
            this.radioButtonSalary_trainee.UseVisualStyleBackColor = true;
            // 
            // radioButtonSalary_notTrainee
            // 
            this.radioButtonSalary_notTrainee.AutoSize = true;
            this.radioButtonSalary_notTrainee.Location = new System.Drawing.Point(6, 21);
            this.radioButtonSalary_notTrainee.Name = "radioButtonSalary_notTrainee";
            this.radioButtonSalary_notTrainee.Size = new System.Drawing.Size(209, 38);
            this.radioButtonSalary_notTrainee.TabIndex = 0;
            this.radioButtonSalary_notTrainee.TabStop = true;
            this.radioButtonSalary_notTrainee.Text = "Прибыль эксперта в клубе \r\n(без стажировки)";
            this.radioButtonSalary_notTrainee.UseVisualStyleBackColor = true;
            // 
            // textBoxExpert
            // 
            this.textBoxExpert.Location = new System.Drawing.Point(159, 48);
            this.textBoxExpert.Name = "textBoxExpert";
            this.textBoxExpert.Size = new System.Drawing.Size(126, 22);
            this.textBoxExpert.TabIndex = 1;
            // 
            // labelExpert
            // 
            this.labelExpert.AutoSize = true;
            this.labelExpert.Location = new System.Drawing.Point(3, 51);
            this.labelExpert.Name = "labelExpert";
            this.labelExpert.Size = new System.Drawing.Size(138, 17);
            this.labelExpert.TabIndex = 0;
            this.labelExpert.Text = "Фамилия эксперта:";
            // 
            // tabPageSubquery
            // 
            this.tabPageSubquery.Controls.Add(this.dataGridViewSubquery);
            this.tabPageSubquery.Controls.Add(this.groupBoxSubquery);
            this.tabPageSubquery.Location = new System.Drawing.Point(4, 25);
            this.tabPageSubquery.Name = "tabPageSubquery";
            this.tabPageSubquery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubquery.Size = new System.Drawing.Size(792, 506);
            this.tabPageSubquery.TabIndex = 2;
            this.tabPageSubquery.Text = "Примеры подзапросов";
            this.tabPageSubquery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSubquery
            // 
            this.dataGridViewSubquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubquery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubquery.Location = new System.Drawing.Point(3, 160);
            this.dataGridViewSubquery.Name = "dataGridViewSubquery";
            this.dataGridViewSubquery.RowHeadersWidth = 51;
            this.dataGridViewSubquery.RowTemplate.Height = 24;
            this.dataGridViewSubquery.Size = new System.Drawing.Size(786, 343);
            this.dataGridViewSubquery.TabIndex = 1;
            // 
            // groupBoxSubquery
            // 
            this.groupBoxSubquery.Controls.Add(this.buttonSubquery);
            this.groupBoxSubquery.Controls.Add(this.textBoxDate);
            this.groupBoxSubquery.Controls.Add(this.labelDate);
            this.groupBoxSubquery.Controls.Add(this.radioButtonNoCorrelated);
            this.groupBoxSubquery.Controls.Add(this.radioButtonCorrelated);
            this.groupBoxSubquery.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSubquery.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSubquery.Name = "groupBoxSubquery";
            this.groupBoxSubquery.Size = new System.Drawing.Size(786, 157);
            this.groupBoxSubquery.TabIndex = 0;
            this.groupBoxSubquery.TabStop = false;
            this.groupBoxSubquery.Text = "Подзапросы по данным";
            // 
            // buttonSubquery
            // 
            this.buttonSubquery.Location = new System.Drawing.Point(296, 89);
            this.buttonSubquery.Name = "buttonSubquery";
            this.buttonSubquery.Size = new System.Drawing.Size(241, 44);
            this.buttonSubquery.TabIndex = 4;
            this.buttonSubquery.Text = "Выполнить подзапрос";
            this.buttonSubquery.UseVisualStyleBackColor = true;
            this.buttonSubquery.Click += new System.EventHandler(this.buttonSubquery_Click);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(144, 100);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(94, 22);
            this.textBoxDate.TabIndex = 3;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(3, 72);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(135, 68);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Дата проведения \r\nвыставки молодого\r\nорганизатора\r\nраньше чем:";
            // 
            // radioButtonNoCorrelated
            // 
            this.radioButtonNoCorrelated.AutoSize = true;
            this.radioButtonNoCorrelated.Location = new System.Drawing.Point(296, 31);
            this.radioButtonNoCorrelated.Name = "radioButtonNoCorrelated";
            this.radioButtonNoCorrelated.Size = new System.Drawing.Size(241, 21);
            this.radioButtonNoCorrelated.TabIndex = 1;
            this.radioButtonNoCorrelated.TabStop = true;
            this.radioButtonNoCorrelated.Text = "Некоррелированный подзапрос";
            this.radioButtonNoCorrelated.UseVisualStyleBackColor = true;
            // 
            // radioButtonCorrelated
            // 
            this.radioButtonCorrelated.AutoSize = true;
            this.radioButtonCorrelated.Location = new System.Drawing.Point(5, 31);
            this.radioButtonCorrelated.Name = "radioButtonCorrelated";
            this.radioButtonCorrelated.Size = new System.Drawing.Size(225, 21);
            this.radioButtonCorrelated.TabIndex = 0;
            this.radioButtonCorrelated.TabStop = true;
            this.radioButtonCorrelated.Text = "Коррелированный подзапрос";
            this.radioButtonCorrelated.UseVisualStyleBackColor = true;
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.panelClub);
            this.tabPageDML.Controls.Add(this.buttonSelectClubs);
            this.tabPageDML.Controls.Add(this.dataGridViewClub);
            this.tabPageDML.Controls.Add(this.buttonExecuteDML);
            this.tabPageDML.Controls.Add(this.textBoxName_Club);
            this.tabPageDML.Controls.Add(this.labelName_Club);
            this.tabPageDML.Controls.Add(this.groupBoxDML);
            this.tabPageDML.Location = new System.Drawing.Point(4, 25);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.Size = new System.Drawing.Size(792, 560);
            this.tabPageDML.TabIndex = 3;
            this.tabPageDML.Text = "Запросы изменения данных";
            this.tabPageDML.UseVisualStyleBackColor = true;
            // 
            // panelClub
            // 
            this.panelClub.Controls.Add(this.textBoxDesc_Club);
            this.panelClub.Controls.Add(this.textBoxHostCount_Club);
            this.panelClub.Controls.Add(this.textBoxDogCount_Club);
            this.panelClub.Controls.Add(this.labelDesc_Club);
            this.panelClub.Controls.Add(this.labelHostCount_Club);
            this.panelClub.Controls.Add(this.labelDogCount_Club);
            this.panelClub.Location = new System.Drawing.Point(6, 152);
            this.panelClub.Name = "panelClub";
            this.panelClub.Size = new System.Drawing.Size(778, 120);
            this.panelClub.TabIndex = 7;
            // 
            // textBoxDesc_Club
            // 
            this.textBoxDesc_Club.Location = new System.Drawing.Point(191, 85);
            this.textBoxDesc_Club.Multiline = true;
            this.textBoxDesc_Club.Name = "textBoxDesc_Club";
            this.textBoxDesc_Club.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDesc_Club.Size = new System.Drawing.Size(156, 22);
            this.textBoxDesc_Club.TabIndex = 7;
            // 
            // textBoxHostCount_Club
            // 
            this.textBoxHostCount_Club.Location = new System.Drawing.Point(191, 52);
            this.textBoxHostCount_Club.Name = "textBoxHostCount_Club";
            this.textBoxHostCount_Club.Size = new System.Drawing.Size(156, 22);
            this.textBoxHostCount_Club.TabIndex = 6;
            // 
            // textBoxDogCount_Club
            // 
            this.textBoxDogCount_Club.Location = new System.Drawing.Point(191, 19);
            this.textBoxDogCount_Club.Name = "textBoxDogCount_Club";
            this.textBoxDogCount_Club.Size = new System.Drawing.Size(156, 22);
            this.textBoxDogCount_Club.TabIndex = 5;
            // 
            // labelDesc_Club
            // 
            this.labelDesc_Club.AutoSize = true;
            this.labelDesc_Club.Location = new System.Drawing.Point(16, 90);
            this.labelDesc_Club.Name = "labelDesc_Club";
            this.labelDesc_Club.Size = new System.Drawing.Size(147, 17);
            this.labelDesc_Club.TabIndex = 3;
            this.labelDesc_Club.Text = "Сведения о медалях:";
            // 
            // labelHostCount_Club
            // 
            this.labelHostCount_Club.AutoSize = true;
            this.labelHostCount_Club.Location = new System.Drawing.Point(16, 55);
            this.labelHostCount_Club.Name = "labelHostCount_Club";
            this.labelHostCount_Club.Size = new System.Drawing.Size(169, 17);
            this.labelHostCount_Club.TabIndex = 2;
            this.labelHostCount_Club.Text = "Количество участников:";
            // 
            // labelDogCount_Club
            // 
            this.labelDogCount_Club.AutoSize = true;
            this.labelDogCount_Club.Location = new System.Drawing.Point(16, 19);
            this.labelDogCount_Club.Name = "labelDogCount_Club";
            this.labelDogCount_Club.Size = new System.Drawing.Size(132, 17);
            this.labelDogCount_Club.TabIndex = 1;
            this.labelDogCount_Club.Text = "Количество собак:";
            // 
            // buttonSelectClubs
            // 
            this.buttonSelectClubs.Location = new System.Drawing.Point(280, 278);
            this.buttonSelectClubs.Name = "buttonSelectClubs";
            this.buttonSelectClubs.Size = new System.Drawing.Size(195, 48);
            this.buttonSelectClubs.TabIndex = 6;
            this.buttonSelectClubs.Text = "Показать список клубов";
            this.buttonSelectClubs.UseVisualStyleBackColor = true;
            this.buttonSelectClubs.Click += new System.EventHandler(this.buttonSelectClubs_Click);
            // 
            // dataGridViewClub
            // 
            this.dataGridViewClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClub.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewClub.Location = new System.Drawing.Point(0, 332);
            this.dataGridViewClub.Name = "dataGridViewClub";
            this.dataGridViewClub.RowHeadersWidth = 51;
            this.dataGridViewClub.RowTemplate.Height = 24;
            this.dataGridViewClub.Size = new System.Drawing.Size(792, 228);
            this.dataGridViewClub.TabIndex = 5;
            // 
            // buttonExecuteDML
            // 
            this.buttonExecuteDML.Location = new System.Drawing.Point(323, 102);
            this.buttonExecuteDML.Name = "buttonExecuteDML";
            this.buttonExecuteDML.Size = new System.Drawing.Size(195, 31);
            this.buttonExecuteDML.TabIndex = 4;
            this.buttonExecuteDML.Text = "Выполнить запрос";
            this.buttonExecuteDML.UseVisualStyleBackColor = true;
            this.buttonExecuteDML.Click += new System.EventHandler(this.buttonExecuteDML_Click);
            // 
            // textBoxName_Club
            // 
            this.textBoxName_Club.Location = new System.Drawing.Point(127, 106);
            this.textBoxName_Club.Name = "textBoxName_Club";
            this.textBoxName_Club.Size = new System.Drawing.Size(100, 22);
            this.textBoxName_Club.TabIndex = 2;
            // 
            // labelName_Club
            // 
            this.labelName_Club.AutoSize = true;
            this.labelName_Club.Location = new System.Drawing.Point(3, 109);
            this.labelName_Club.Name = "labelName_Club";
            this.labelName_Club.Size = new System.Drawing.Size(118, 17);
            this.labelName_Club.TabIndex = 1;
            this.labelName_Club.Text = "Название клуба:";
            // 
            // groupBoxDML
            // 
            this.groupBoxDML.Controls.Add(this.radioButtonDelete_Club);
            this.groupBoxDML.Controls.Add(this.radioButtonUpdate_Club);
            this.groupBoxDML.Controls.Add(this.radioButtonInsert_Club);
            this.groupBoxDML.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDML.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDML.Name = "groupBoxDML";
            this.groupBoxDML.Size = new System.Drawing.Size(792, 100);
            this.groupBoxDML.TabIndex = 0;
            this.groupBoxDML.TabStop = false;
            this.groupBoxDML.Text = "Операторы";
            // 
            // radioButtonDelete_Club
            // 
            this.radioButtonDelete_Club.AutoSize = true;
            this.radioButtonDelete_Club.Location = new System.Drawing.Point(524, 35);
            this.radioButtonDelete_Club.Name = "radioButtonDelete_Club";
            this.radioButtonDelete_Club.Size = new System.Drawing.Size(203, 38);
            this.radioButtonDelete_Club.TabIndex = 2;
            this.radioButtonDelete_Club.TabStop = true;
            this.radioButtonDelete_Club.Text = "Удалить данные о клубе с\r\nзаданным названием\r\n";
            this.radioButtonDelete_Club.UseVisualStyleBackColor = true;
            this.radioButtonDelete_Club.CheckedChanged += new System.EventHandler(this.radioButtonDelete_Club_CheckedChanged);
            // 
            // radioButtonUpdate_Club
            // 
            this.radioButtonUpdate_Club.AutoSize = true;
            this.radioButtonUpdate_Club.Location = new System.Drawing.Point(253, 35);
            this.radioButtonUpdate_Club.Name = "radioButtonUpdate_Club";
            this.radioButtonUpdate_Club.Size = new System.Drawing.Size(219, 38);
            this.radioButtonUpdate_Club.TabIndex = 1;
            this.radioButtonUpdate_Club.TabStop = true;
            this.radioButtonUpdate_Club.Text = "Изменить данные по клубу с\r\n заданным названием\r\n";
            this.radioButtonUpdate_Club.UseVisualStyleBackColor = true;
            // 
            // radioButtonInsert_Club
            // 
            this.radioButtonInsert_Club.AutoSize = true;
            this.radioButtonInsert_Club.Location = new System.Drawing.Point(6, 44);
            this.radioButtonInsert_Club.Name = "radioButtonInsert_Club";
            this.radioButtonInsert_Club.Size = new System.Drawing.Size(208, 21);
            this.radioButtonInsert_Club.TabIndex = 0;
            this.radioButtonInsert_Club.TabStop = true;
            this.radioButtonInsert_Club.Text = "Добавить данные по клубу";
            this.radioButtonInsert_Club.UseVisualStyleBackColor = true;
            // 
            // openFileDialogDog
            // 
            this.openFileDialogDog.FileName = "openFileDialog1";
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.tabPages);
            this.Name = "FormSQL";
            this.Text = "Запросы";
            this.tabPages.ResumeLayout(false);
            this.tabPagePrimer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.tabPageSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).EndInit();
            this.groupBoxFSelect.ResumeLayout(false);
            this.groupBoxFSelect.PerformLayout();
            this.groupBoxDet.ResumeLayout(false);
            this.groupBoxDet.PerformLayout();
            this.tabPageSubquery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).EndInit();
            this.groupBoxSubquery.ResumeLayout(false);
            this.groupBoxSubquery.PerformLayout();
            this.tabPageDML.ResumeLayout(false);
            this.tabPageDML.PerformLayout();
            this.panelClub.ResumeLayout(false);
            this.panelClub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClub)).EndInit();
            this.groupBoxDML.ResumeLayout(false);
            this.groupBoxDML.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPages;
        private System.Windows.Forms.TabPage tabPagePrimer;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonDogs;
        private System.Windows.Forms.RadioButton radioButtonShows;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.RadioButton radioButtonWinners;
        private System.Windows.Forms.GroupBox groupBoxFSelect;
        private System.Windows.Forms.GroupBox groupBoxDet;
        private System.Windows.Forms.RadioButton radioButtonSalary_notAll;
        private System.Windows.Forms.RadioButton radioButtonSalary_trainee;
        private System.Windows.Forms.RadioButton radioButtonSalary_notTrainee;
        private System.Windows.Forms.TextBox textBoxExpert;
        private System.Windows.Forms.Label labelExpert;
        private System.Windows.Forms.CheckBox checkBoxOrder;
        private System.Windows.Forms.TextBox textBoxMore;
        private System.Windows.Forms.CheckBox checkBoxMore;
        private System.Windows.Forms.Button buttonF_Select;
        private System.Windows.Forms.DataGridView dataGridViewFSelect;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.TabPage tabPageSubquery;
        private System.Windows.Forms.GroupBox groupBoxSubquery;
        private System.Windows.Forms.RadioButton radioButtonNoCorrelated;
        private System.Windows.Forms.RadioButton radioButtonCorrelated;
        private System.Windows.Forms.DataGridView dataGridViewSubquery;
        private System.Windows.Forms.Button buttonSubquery;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TabPage tabPageDML;
        private System.Windows.Forms.GroupBox groupBoxDML;
        private System.Windows.Forms.RadioButton radioButtonUpdate_Club;
        private System.Windows.Forms.RadioButton radioButtonInsert_Club;
        private System.Windows.Forms.RadioButton radioButtonDelete_Club;
        private System.Windows.Forms.OpenFileDialog openFileDialogDog;
        private System.Windows.Forms.DataGridView dataGridViewClub;
        private System.Windows.Forms.Button buttonSelectClubs;
        private System.Windows.Forms.Button buttonExecuteDML;
        private System.Windows.Forms.TextBox textBoxName_Club;
        private System.Windows.Forms.Label labelName_Club;
        private System.Windows.Forms.Panel panelClub;
        private System.Windows.Forms.Label labelDesc_Club;
        private System.Windows.Forms.Label labelHostCount_Club;
        private System.Windows.Forms.Label labelDogCount_Club;
        private System.Windows.Forms.TextBox textBoxHostCount_Club;
        private System.Windows.Forms.TextBox textBoxDogCount_Club;
        private System.Windows.Forms.TextBox textBoxDesc_Club;
    }
}