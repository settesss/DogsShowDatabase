
namespace Lab2_
{
    partial class FormHosts
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
            System.Windows.Forms.Label данные_паспортаLabel;
            System.Windows.Forms.Label фИО_хозяинаLabel;
            System.Windows.Forms.Label номер_родословнойLabel;
            System.Windows.Forms.Label название_клубаLabel;
            System.Windows.Forms.Label собакаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHosts));
            System.Windows.Forms.Label выигрышLabel;
            this.выставкаDataSet = new Lab2_.ВыставкаDataSet();
            this.хозяинBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.хозяинTableAdapter = new Lab2_.ВыставкаDataSetTableAdapters.ХозяинTableAdapter();
            this.tableAdapterManager = new Lab2_.ВыставкаDataSetTableAdapters.TableAdapterManager();
            this.данные_паспортаTextBox = new System.Windows.Forms.TextBox();
            this.фИО_хозяинаTextBox = new System.Windows.Forms.TextBox();
            this.номер_родословнойTextBox = new System.Windows.Forms.TextBox();
            this.название_клубаTextBox = new System.Windows.Forms.TextBox();
            this.хозяинBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.хозяинBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.собакаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.собакаTableAdapter = new Lab2_.ВыставкаDataSetTableAdapters.СобакаTableAdapter();
            this.собакаLabel1 = new System.Windows.Forms.Label();
            this.выигрышLabel1 = new System.Windows.Forms.Label();
            данные_паспортаLabel = new System.Windows.Forms.Label();
            фИО_хозяинаLabel = new System.Windows.Forms.Label();
            номер_родословнойLabel = new System.Windows.Forms.Label();
            название_клубаLabel = new System.Windows.Forms.Label();
            собакаLabel = new System.Windows.Forms.Label();
            выигрышLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.выставкаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.хозяинBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.хозяинBindingNavigator)).BeginInit();
            this.хозяинBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.собакаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // данные_паспортаLabel
            // 
            данные_паспортаLabel.AutoSize = true;
            данные_паспортаLabel.Location = new System.Drawing.Point(12, 9);
            данные_паспортаLabel.Name = "данные_паспортаLabel";
            данные_паспортаLabel.Size = new System.Drawing.Size(131, 17);
            данные_паспортаLabel.TabIndex = 0;
            данные_паспортаLabel.Text = "Данные паспорта:";
            // 
            // фИО_хозяинаLabel
            // 
            фИО_хозяинаLabel.AutoSize = true;
            фИО_хозяинаLabel.Location = new System.Drawing.Point(12, 37);
            фИО_хозяинаLabel.Name = "фИО_хозяинаLabel";
            фИО_хозяинаLabel.Size = new System.Drawing.Size(103, 17);
            фИО_хозяинаLabel.TabIndex = 2;
            фИО_хозяинаLabel.Text = "ФИО хозяина:";
            // 
            // номер_родословнойLabel
            // 
            номер_родословнойLabel.AutoSize = true;
            номер_родословнойLabel.Location = new System.Drawing.Point(12, 65);
            номер_родословнойLabel.Name = "номер_родословнойLabel";
            номер_родословнойLabel.Size = new System.Drawing.Size(145, 17);
            номер_родословнойLabel.TabIndex = 4;
            номер_родословнойLabel.Text = "Номер родословной:";
            // 
            // название_клубаLabel
            // 
            название_клубаLabel.AutoSize = true;
            название_клубаLabel.Location = new System.Drawing.Point(12, 93);
            название_клубаLabel.Name = "название_клубаLabel";
            название_клубаLabel.Size = new System.Drawing.Size(118, 17);
            название_клубаLabel.TabIndex = 6;
            название_клубаLabel.Text = "Название клуба:";
            // 
            // собакаLabel
            // 
            собакаLabel.AutoSize = true;
            собакаLabel.Location = new System.Drawing.Point(12, 138);
            собакаLabel.Name = "собакаLabel";
            собакаLabel.Size = new System.Drawing.Size(60, 17);
            собакаLabel.TabIndex = 11;
            собакаLabel.Text = "Собака:";
            // 
            // выставкаDataSet
            // 
            this.выставкаDataSet.DataSetName = "ВыставкаDataSet";
            this.выставкаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // хозяинBindingSource
            // 
            this.хозяинBindingSource.DataMember = "Хозяин";
            this.хозяинBindingSource.DataSource = this.выставкаDataSet;
            // 
            // хозяинTableAdapter
            // 
            this.хозяинTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Lab2_.ВыставкаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВыставкаTableAdapter = null;
            this.tableAdapterManager.Клуб_ВыставкаTableAdapter = null;
            this.tableAdapterManager.КлубTableAdapter = null;
            this.tableAdapterManager.ОрганизаторTableAdapter = null;
            this.tableAdapterManager.РингTableAdapter = null;
            this.tableAdapterManager.Собака_РингTableAdapter = null;
            this.tableAdapterManager.СобакаTableAdapter = null;
            this.tableAdapterManager.ХозяинTableAdapter = this.хозяинTableAdapter;
            this.tableAdapterManager.Эксперт_РингTableAdapter = null;
            this.tableAdapterManager.ЭкспертTableAdapter = null;
            // 
            // данные_паспортаTextBox
            // 
            this.данные_паспортаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.хозяинBindingSource, "Данные_паспорта", true));
            this.данные_паспортаTextBox.Location = new System.Drawing.Point(163, 6);
            this.данные_паспортаTextBox.Name = "данные_паспортаTextBox";
            this.данные_паспортаTextBox.Size = new System.Drawing.Size(199, 22);
            this.данные_паспортаTextBox.TabIndex = 1;
            // 
            // фИО_хозяинаTextBox
            // 
            this.фИО_хозяинаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.хозяинBindingSource, "ФИО_хозяина", true));
            this.фИО_хозяинаTextBox.Location = new System.Drawing.Point(163, 34);
            this.фИО_хозяинаTextBox.Name = "фИО_хозяинаTextBox";
            this.фИО_хозяинаTextBox.Size = new System.Drawing.Size(270, 22);
            this.фИО_хозяинаTextBox.TabIndex = 3;
            // 
            // номер_родословнойTextBox
            // 
            this.номер_родословнойTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.хозяинBindingSource, "Номер_родословной", true));
            this.номер_родословнойTextBox.Location = new System.Drawing.Point(163, 62);
            this.номер_родословнойTextBox.Name = "номер_родословнойTextBox";
            this.номер_родословнойTextBox.Size = new System.Drawing.Size(270, 22);
            this.номер_родословнойTextBox.TabIndex = 5;
            // 
            // название_клубаTextBox
            // 
            this.название_клубаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.хозяинBindingSource, "Название_клуба", true));
            this.название_клубаTextBox.Location = new System.Drawing.Point(163, 90);
            this.название_клубаTextBox.Name = "название_клубаTextBox";
            this.название_клубаTextBox.Size = new System.Drawing.Size(199, 22);
            this.название_клубаTextBox.TabIndex = 7;
            // 
            // хозяинBindingNavigator
            // 
            this.хозяинBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.хозяинBindingNavigator.BindingSource = this.хозяинBindingSource;
            this.хозяинBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.хозяинBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.хозяинBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.хозяинBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.хозяинBindingNavigatorSaveItem});
            this.хозяинBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.хозяинBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.хозяинBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.хозяинBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.хозяинBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.хозяинBindingNavigator.Name = "хозяинBindingNavigator";
            this.хозяинBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.хозяинBindingNavigator.Size = new System.Drawing.Size(453, 27);
            this.хозяинBindingNavigator.TabIndex = 8;
            this.хозяинBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // хозяинBindingNavigatorSaveItem
            // 
            this.хозяинBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.хозяинBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("хозяинBindingNavigatorSaveItem.Image")));
            this.хозяинBindingNavigatorSaveItem.Name = "хозяинBindingNavigatorSaveItem";
            this.хозяинBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.хозяинBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.хозяинBindingNavigatorSaveItem.Click += new System.EventHandler(this.хозяинBindingNavigatorSaveItem_Click);
            // 
            // собакаBindingSource
            // 
            this.собакаBindingSource.DataMember = "Собака";
            this.собакаBindingSource.DataSource = this.выставкаDataSet;
            // 
            // собакаTableAdapter
            // 
            this.собакаTableAdapter.ClearBeforeFill = true;
            // 
            // собакаLabel1
            // 
            this.собакаLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.хозяинBindingSource, "Собака", true));
            this.собакаLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.собакаLabel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.собакаLabel1.Location = new System.Drawing.Point(158, 132);
            this.собакаLabel1.Name = "собакаLabel1";
            this.собакаLabel1.Size = new System.Drawing.Size(204, 23);
            this.собакаLabel1.TabIndex = 12;
            this.собакаLabel1.Text = "label1";
            // 
            // выигрышLabel
            // 
            выигрышLabel.AutoSize = true;
            выигрышLabel.Location = new System.Drawing.Point(12, 165);
            выигрышLabel.Name = "выигрышLabel";
            выигрышLabel.Size = new System.Drawing.Size(73, 17);
            выигрышLabel.TabIndex = 12;
            выигрышLabel.Text = "Выигрыш:";
            // 
            // выигрышLabel1
            // 
            this.выигрышLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.хозяинBindingSource, "Выигрыш", true));
            this.выигрышLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выигрышLabel1.ForeColor = System.Drawing.Color.SlateBlue;
            this.выигрышLabel1.Location = new System.Drawing.Point(158, 159);
            this.выигрышLabel1.Name = "выигрышLabel1";
            this.выигрышLabel1.Size = new System.Drawing.Size(204, 23);
            this.выигрышLabel1.TabIndex = 13;
            this.выигрышLabel1.Text = "label1";
            // 
            // FormHosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 195);
            this.Controls.Add(выигрышLabel);
            this.Controls.Add(this.выигрышLabel1);
            this.Controls.Add(собакаLabel);
            this.Controls.Add(this.собакаLabel1);
            this.Controls.Add(this.хозяинBindingNavigator);
            this.Controls.Add(данные_паспортаLabel);
            this.Controls.Add(this.данные_паспортаTextBox);
            this.Controls.Add(фИО_хозяинаLabel);
            this.Controls.Add(this.фИО_хозяинаTextBox);
            this.Controls.Add(номер_родословнойLabel);
            this.Controls.Add(this.номер_родословнойTextBox);
            this.Controls.Add(название_клубаLabel);
            this.Controls.Add(this.название_клубаTextBox);
            this.Name = "FormHosts";
            this.Text = "Hosts";
            this.Load += new System.EventHandler(this.Hosts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.выставкаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.хозяинBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.хозяинBindingNavigator)).EndInit();
            this.хозяинBindingNavigator.ResumeLayout(false);
            this.хозяинBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.собакаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ВыставкаDataSet выставкаDataSet;
        private System.Windows.Forms.BindingSource хозяинBindingSource;
        private ВыставкаDataSetTableAdapters.ХозяинTableAdapter хозяинTableAdapter;
        private ВыставкаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox данные_паспортаTextBox;
        private System.Windows.Forms.TextBox фИО_хозяинаTextBox;
        private System.Windows.Forms.TextBox номер_родословнойTextBox;
        private System.Windows.Forms.TextBox название_клубаTextBox;
        private System.Windows.Forms.BindingNavigator хозяинBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton хозяинBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource собакаBindingSource;
        private ВыставкаDataSetTableAdapters.СобакаTableAdapter собакаTableAdapter;
        private System.Windows.Forms.Label собакаLabel1;
        private System.Windows.Forms.Label выигрышLabel1;
    }
}