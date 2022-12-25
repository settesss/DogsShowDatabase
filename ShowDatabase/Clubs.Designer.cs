
namespace Lab2_
{
    partial class FormClubs
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label название_клубаLabel;
            System.Windows.Forms.Label количество_собакLabel;
            System.Windows.Forms.Label количество_участниковLabel;
            System.Windows.Forms.Label сведения_о_медаляхLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClubs));
            this.выставкаDataSet = new Lab2_.ВыставкаDataSet();
            this.клубBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клубTableAdapter = new Lab2_.ВыставкаDataSetTableAdapters.КлубTableAdapter();
            this.tableAdapterManager = new Lab2_.ВыставкаDataSetTableAdapters.TableAdapterManager();
            this.клубBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.клубBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.название_клубаTextBox = new System.Windows.Forms.TextBox();
            this.количество_собакTextBox = new System.Windows.Forms.TextBox();
            this.количество_участниковTextBox = new System.Windows.Forms.TextBox();
            this.сведения_о_медаляхTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxHost = new System.Windows.Forms.GroupBox();
            this.ХозяинBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.хозяинBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.хозяинBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.хозяинDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.хозяинTableAdapter = new Lab2_.ВыставкаDataSetTableAdapters.ХозяинTableAdapter();
            название_клубаLabel = new System.Windows.Forms.Label();
            количество_собакLabel = new System.Windows.Forms.Label();
            количество_участниковLabel = new System.Windows.Forms.Label();
            сведения_о_медаляхLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.выставкаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клубBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клубBindingNavigator)).BeginInit();
            this.клубBindingNavigator.SuspendLayout();
            this.groupBoxHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ХозяинBindingNavigator)).BeginInit();
            this.ХозяинBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.хозяинBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.хозяинDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // название_клубаLabel
            // 
            название_клубаLabel.AutoSize = true;
            название_клубаLabel.Location = new System.Drawing.Point(12, 31);
            название_клубаLabel.Name = "название_клубаLabel";
            название_клубаLabel.Size = new System.Drawing.Size(118, 17);
            название_клубаLabel.TabIndex = 1;
            название_клубаLabel.Text = "Название клуба:";
            // 
            // количество_собакLabel
            // 
            количество_собакLabel.AutoSize = true;
            количество_собакLabel.Location = new System.Drawing.Point(12, 59);
            количество_собакLabel.Name = "количество_собакLabel";
            количество_собакLabel.Size = new System.Drawing.Size(132, 17);
            количество_собакLabel.TabIndex = 3;
            количество_собакLabel.Text = "Количество собак:";
            // 
            // количество_участниковLabel
            // 
            количество_участниковLabel.AutoSize = true;
            количество_участниковLabel.Location = new System.Drawing.Point(12, 87);
            количество_участниковLabel.Name = "количество_участниковLabel";
            количество_участниковLabel.Size = new System.Drawing.Size(169, 17);
            количество_участниковLabel.TabIndex = 5;
            количество_участниковLabel.Text = "Количество участников:";
            // 
            // сведения_о_медаляхLabel
            // 
            сведения_о_медаляхLabel.AutoSize = true;
            сведения_о_медаляхLabel.Location = new System.Drawing.Point(12, 115);
            сведения_о_медаляхLabel.Name = "сведения_о_медаляхLabel";
            сведения_о_медаляхLabel.Size = new System.Drawing.Size(147, 17);
            сведения_о_медаляхLabel.TabIndex = 7;
            сведения_о_медаляхLabel.Text = "Сведения о медалях:";
            // 
            // выставкаDataSet
            // 
            this.выставкаDataSet.DataSetName = "ВыставкаDataSet";
            this.выставкаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клубBindingSource
            // 
            this.клубBindingSource.DataMember = "Клуб";
            this.клубBindingSource.DataSource = this.выставкаDataSet;
            // 
            // клубTableAdapter
            // 
            this.клубTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Lab2_.ВыставкаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВыставкаTableAdapter = null;
            this.tableAdapterManager.Клуб_ВыставкаTableAdapter = null;
            this.tableAdapterManager.КлубTableAdapter = this.клубTableAdapter;
            this.tableAdapterManager.ОрганизаторTableAdapter = null;
            this.tableAdapterManager.РингTableAdapter = null;
            this.tableAdapterManager.Собака_РингTableAdapter = null;
            this.tableAdapterManager.СобакаTableAdapter = null;
            this.tableAdapterManager.ХозяинTableAdapter = null;
            this.tableAdapterManager.Эксперт_РингTableAdapter = null;
            this.tableAdapterManager.ЭкспертTableAdapter = null;
            // 
            // клубBindingNavigator
            // 
            this.клубBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.клубBindingNavigator.BindingSource = this.клубBindingSource;
            this.клубBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.клубBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.клубBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.клубBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.клубBindingNavigatorSaveItem});
            this.клубBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.клубBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.клубBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.клубBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.клубBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.клубBindingNavigator.Name = "клубBindingNavigator";
            this.клубBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.клубBindingNavigator.Size = new System.Drawing.Size(768, 31);
            this.клубBindingNavigator.TabIndex = 0;
            this.клубBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // клубBindingNavigatorSaveItem
            // 
            this.клубBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.клубBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("клубBindingNavigatorSaveItem.Image")));
            this.клубBindingNavigatorSaveItem.Name = "клубBindingNavigatorSaveItem";
            this.клубBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.клубBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.клубBindingNavigatorSaveItem.Click += new System.EventHandler(this.клубBindingNavigatorSaveItem_Click);
            // 
            // название_клубаTextBox
            // 
            this.название_клубаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клубBindingSource, "Название_клуба", true));
            this.название_клубаTextBox.Location = new System.Drawing.Point(187, 28);
            this.название_клубаTextBox.Name = "название_клубаTextBox";
            this.название_клубаTextBox.Size = new System.Drawing.Size(174, 22);
            this.название_клубаTextBox.TabIndex = 2;
            // 
            // количество_собакTextBox
            // 
            this.количество_собакTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клубBindingSource, "Количество_собак", true));
            this.количество_собакTextBox.Location = new System.Drawing.Point(187, 56);
            this.количество_собакTextBox.Name = "количество_собакTextBox";
            this.количество_собакTextBox.Size = new System.Drawing.Size(100, 22);
            this.количество_собакTextBox.TabIndex = 4;
            // 
            // количество_участниковTextBox
            // 
            this.количество_участниковTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клубBindingSource, "Количество_участников", true));
            this.количество_участниковTextBox.Location = new System.Drawing.Point(187, 84);
            this.количество_участниковTextBox.Name = "количество_участниковTextBox";
            this.количество_участниковTextBox.Size = new System.Drawing.Size(100, 22);
            this.количество_участниковTextBox.TabIndex = 6;
            // 
            // сведения_о_медаляхTextBox
            // 
            this.сведения_о_медаляхTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клубBindingSource, "Сведения_о_медалях", true));
            this.сведения_о_медаляхTextBox.Location = new System.Drawing.Point(187, 112);
            this.сведения_о_медаляхTextBox.Multiline = true;
            this.сведения_о_медаляхTextBox.Name = "сведения_о_медаляхTextBox";
            this.сведения_о_медаляхTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.сведения_о_медаляхTextBox.Size = new System.Drawing.Size(174, 98);
            this.сведения_о_медаляхTextBox.TabIndex = 8;
            // 
            // groupBoxHost
            // 
            this.groupBoxHost.Controls.Add(this.ХозяинBindingNavigator);
            this.groupBoxHost.Controls.Add(this.хозяинDataGridView);
            this.groupBoxHost.Location = new System.Drawing.Point(12, 239);
            this.groupBoxHost.Name = "groupBoxHost";
            this.groupBoxHost.Size = new System.Drawing.Size(744, 318);
            this.groupBoxHost.TabIndex = 9;
            this.groupBoxHost.TabStop = false;
            this.groupBoxHost.Text = "Хозяева";
            // 
            // ХозяинBindingNavigator
            // 
            this.ХозяинBindingNavigator.AddNewItem = this.toolStripButton1;
            this.ХозяинBindingNavigator.BindingSource = this.хозяинBindingSource;
            this.ХозяинBindingNavigator.CountItem = this.toolStripLabel1;
            this.ХозяинBindingNavigator.DeleteItem = this.toolStripButton2;
            this.ХозяинBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ХозяинBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.хозяинBindingNavigatorSaveItem});
            this.ХозяинBindingNavigator.Location = new System.Drawing.Point(3, 18);
            this.ХозяинBindingNavigator.MoveFirstItem = this.toolStripButton3;
            this.ХозяинBindingNavigator.MoveLastItem = this.toolStripButton6;
            this.ХозяинBindingNavigator.MoveNextItem = this.toolStripButton5;
            this.ХозяинBindingNavigator.MovePreviousItem = this.toolStripButton4;
            this.ХозяинBindingNavigator.Name = "ХозяинBindingNavigator";
            this.ХозяинBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.ХозяинBindingNavigator.Size = new System.Drawing.Size(738, 31);
            this.ХозяинBindingNavigator.TabIndex = 1;
            this.ХозяинBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "Добавить";
            // 
            // хозяинBindingSource
            // 
            this.хозяинBindingSource.DataMember = "FK_Хозяин_Клуб";
            this.хозяинBindingSource.DataSource = this.клубBindingSource;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 28);
            this.toolStripLabel1.Text = "для {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton2.Text = "Удалить";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton3.Text = "Переместить в начало";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton4.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 27);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton5.Text = "Переместить вперед";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton6.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // хозяинBindingNavigatorSaveItem
            // 
            this.хозяинBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.хозяинBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("хозяинBindingNavigatorSaveItem.Image")));
            this.хозяинBindingNavigatorSaveItem.Name = "хозяинBindingNavigatorSaveItem";
            this.хозяинBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.хозяинBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.хозяинBindingNavigatorSaveItem.Click += new System.EventHandler(this.хозяинBindingNavigatorSaveItem_Click);
            // 
            // хозяинDataGridView
            // 
            this.хозяинDataGridView.AutoGenerateColumns = false;
            this.хозяинDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.хозяинDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.хозяинDataGridView.DataSource = this.хозяинBindingSource;
            this.хозяинDataGridView.Location = new System.Drawing.Point(6, 56);
            this.хозяинDataGridView.Name = "хозяинDataGridView";
            this.хозяинDataGridView.RowHeadersWidth = 51;
            this.хозяинDataGridView.RowTemplate.Height = 24;
            this.хозяинDataGridView.Size = new System.Drawing.Size(732, 256);
            this.хозяинDataGridView.TabIndex = 0;
            this.хозяинDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.хозяинDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Данные_паспорта";
            this.dataGridViewTextBoxColumn1.HeaderText = "Данные_паспорта";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО_хозяина";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО_хозяина";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Номер_родословной";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер_родословной";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Название_клуба";
            this.dataGridViewTextBoxColumn4.HeaderText = "Название_клуба";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // хозяинTableAdapter
            // 
            this.хозяинTableAdapter.ClearBeforeFill = true;
            // 
            // FormClubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 557);
            this.Controls.Add(this.groupBoxHost);
            this.Controls.Add(название_клубаLabel);
            this.Controls.Add(this.название_клубаTextBox);
            this.Controls.Add(количество_собакLabel);
            this.Controls.Add(this.количество_собакTextBox);
            this.Controls.Add(количество_участниковLabel);
            this.Controls.Add(this.количество_участниковTextBox);
            this.Controls.Add(сведения_о_медаляхLabel);
            this.Controls.Add(this.сведения_о_медаляхTextBox);
            this.Controls.Add(this.клубBindingNavigator);
            this.Name = "FormClubs";
            this.Text = "Clubs";
            this.Load += new System.EventHandler(this.Clubs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.выставкаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клубBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клубBindingNavigator)).EndInit();
            this.клубBindingNavigator.ResumeLayout(false);
            this.клубBindingNavigator.PerformLayout();
            this.groupBoxHost.ResumeLayout(false);
            this.groupBoxHost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ХозяинBindingNavigator)).EndInit();
            this.ХозяинBindingNavigator.ResumeLayout(false);
            this.ХозяинBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.хозяинBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.хозяинDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ВыставкаDataSet выставкаDataSet;
        private System.Windows.Forms.BindingSource клубBindingSource;
        private ВыставкаDataSetTableAdapters.КлубTableAdapter клубTableAdapter;
        private ВыставкаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator клубBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton клубBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox название_клубаTextBox;
        private System.Windows.Forms.TextBox количество_собакTextBox;
        private System.Windows.Forms.TextBox количество_участниковTextBox;
        private System.Windows.Forms.TextBox сведения_о_медаляхTextBox;
        private System.Windows.Forms.GroupBox groupBoxHost;
        private System.Windows.Forms.BindingSource хозяинBindingSource;
        private ВыставкаDataSetTableAdapters.ХозяинTableAdapter хозяинTableAdapter;
        private System.Windows.Forms.DataGridView хозяинDataGridView;
        private System.Windows.Forms.BindingNavigator ХозяинBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton хозяинBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}