
namespace Lab2_
{
    partial class FormRings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRings));
            this.рингBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.рингBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выставкаDataSet = new Lab2_.ВыставкаDataSet();
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
            this.рингBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.checkBoxFind = new System.Windows.Forms.CheckBox();
            this.tableAdapterManager = new Lab2_.ВыставкаDataSetTableAdapters.TableAdapterManager();
            this.рингTableAdapter = new Lab2_.ВыставкаDataSetTableAdapters.РингTableAdapter();
            this.собака_РингTableAdapter = new Lab2_.ВыставкаDataSetTableAdapters.Собака_РингTableAdapter();
            this.эксперт_РингTableAdapter = new Lab2_.ВыставкаDataSetTableAdapters.Эксперт_РингTableAdapter();
            this.toolStripButtonOK = new System.Windows.Forms.Button();
            this.собака_РингBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.эксперт_РингBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.времяпроведенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиепородыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиевыставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодрингаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рингDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.рингBindingNavigator)).BeginInit();
            this.рингBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.рингBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выставкаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.собака_РингBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.эксперт_РингBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рингDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // рингBindingNavigator
            // 
            this.рингBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.рингBindingNavigator.BindingSource = this.рингBindingSource;
            this.рингBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.рингBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.рингBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.рингBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.рингBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripTextBoxFind,
            this.toolStripButtonFind});
            this.рингBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.рингBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.рингBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.рингBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.рингBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.рингBindingNavigator.Name = "рингBindingNavigator";
            this.рингBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.рингBindingNavigator.Size = new System.Drawing.Size(691, 27);
            this.рингBindingNavigator.TabIndex = 0;
            this.рингBindingNavigator.Text = "bindingNavigator1";
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
            // рингBindingSource
            // 
            this.рингBindingSource.DataMember = "Ринг";
            this.рингBindingSource.DataSource = this.выставкаDataSet;
            // 
            // выставкаDataSet
            // 
            this.выставкаDataSet.DataSetName = "ВыставкаDataSet";
            this.выставкаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // рингBindingNavigatorSaveItem
            // 
            this.рингBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.рингBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("рингBindingNavigatorSaveItem.Image")));
            this.рингBindingNavigatorSaveItem.Name = "рингBindingNavigatorSaveItem";
            this.рингBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.рингBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.рингBindingNavigatorSaveItem.Click += new System.EventHandler(this.рингBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripTextBoxFind
            // 
            this.toolStripTextBoxFind.Name = "toolStripTextBoxFind";
            this.toolStripTextBoxFind.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.Image = global::Lab2_.Properties.Resources.lupa;
            this.toolStripButtonFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFind.Name = "toolStripButtonFind";
            this.toolStripButtonFind.Size = new System.Drawing.Size(76, 24);
            this.toolStripButtonFind.Text = "Поиск";
            this.toolStripButtonFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
            // 
            // checkBoxFind
            // 
            this.checkBoxFind.AutoSize = true;
            this.checkBoxFind.Location = new System.Drawing.Point(522, 3);
            this.checkBoxFind.Name = "checkBoxFind";
            this.checkBoxFind.Size = new System.Drawing.Size(81, 21);
            this.checkBoxFind.TabIndex = 2;
            this.checkBoxFind.Text = "Фильтр";
            this.checkBoxFind.UseVisualStyleBackColor = true;
            this.checkBoxFind.CheckedChanged += new System.EventHandler(this.checkBoxFind_CheckedChanged);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Lab2_.ВыставкаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВыставкаTableAdapter = null;
            this.tableAdapterManager.Клуб_ВыставкаTableAdapter = null;
            this.tableAdapterManager.КлубTableAdapter = null;
            this.tableAdapterManager.ОрганизаторTableAdapter = null;
            this.tableAdapterManager.РингTableAdapter = this.рингTableAdapter;
            this.tableAdapterManager.Собака_РингTableAdapter = null;
            this.tableAdapterManager.СобакаTableAdapter = null;
            this.tableAdapterManager.ХозяинTableAdapter = null;
            this.tableAdapterManager.Эксперт_РингTableAdapter = null;
            this.tableAdapterManager.ЭкспертTableAdapter = null;
            // 
            // рингTableAdapter
            // 
            this.рингTableAdapter.ClearBeforeFill = true;
            // 
            // собака_РингTableAdapter
            // 
            this.собака_РингTableAdapter.ClearBeforeFill = true;
            // 
            // эксперт_РингTableAdapter
            // 
            this.эксперт_РингTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripButtonOK
            // 
            this.toolStripButtonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButtonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonOK.Location = new System.Drawing.Point(220, 360);
            this.toolStripButtonOK.Name = "toolStripButtonOK";
            this.toolStripButtonOK.Size = new System.Drawing.Size(233, 31);
            this.toolStripButtonOK.TabIndex = 3;
            this.toolStripButtonOK.Text = "Выбрать";
            this.toolStripButtonOK.UseVisualStyleBackColor = true;
            this.toolStripButtonOK.Click += new System.EventHandler(this.toolStripButtonOK_Click);
            // 
            // собака_РингBindingSource
            // 
            this.собака_РингBindingSource.DataMember = "FK_Собака_Ринг_Ринг";
            this.собака_РингBindingSource.DataSource = this.рингBindingSource;
            // 
            // эксперт_РингBindingSource
            // 
            this.эксперт_РингBindingSource.DataMember = "FK_Эксперт_Ринг_Ринг";
            this.эксперт_РингBindingSource.DataSource = this.рингBindingSource;
            // 
            // времяпроведенияDataGridViewTextBoxColumn
            // 
            this.времяпроведенияDataGridViewTextBoxColumn.DataPropertyName = "Время_проведения";
            this.времяпроведенияDataGridViewTextBoxColumn.HeaderText = "Время_проведения";
            this.времяпроведенияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.времяпроведенияDataGridViewTextBoxColumn.Name = "времяпроведенияDataGridViewTextBoxColumn";
            this.времяпроведенияDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиепородыDataGridViewTextBoxColumn
            // 
            this.названиепородыDataGridViewTextBoxColumn.DataPropertyName = "Название_породы";
            this.названиепородыDataGridViewTextBoxColumn.HeaderText = "Название_породы";
            this.названиепородыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиепородыDataGridViewTextBoxColumn.Name = "названиепородыDataGridViewTextBoxColumn";
            this.названиепородыDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиевыставкиDataGridViewTextBoxColumn
            // 
            this.названиевыставкиDataGridViewTextBoxColumn.DataPropertyName = "Название_выставки";
            this.названиевыставкиDataGridViewTextBoxColumn.HeaderText = "Название_выставки";
            this.названиевыставкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиевыставкиDataGridViewTextBoxColumn.Name = "названиевыставкиDataGridViewTextBoxColumn";
            this.названиевыставкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодрингаDataGridViewTextBoxColumn
            // 
            this.кодрингаDataGridViewTextBoxColumn.DataPropertyName = "Код_ринга";
            this.кодрингаDataGridViewTextBoxColumn.HeaderText = "Код_ринга";
            this.кодрингаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодрингаDataGridViewTextBoxColumn.Name = "кодрингаDataGridViewTextBoxColumn";
            this.кодрингаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодрингаDataGridViewTextBoxColumn.Width = 125;
            // 
            // рингDataGridView
            // 
            this.рингDataGridView.AutoGenerateColumns = false;
            this.рингDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.рингDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодрингаDataGridViewTextBoxColumn,
            this.названиевыставкиDataGridViewTextBoxColumn,
            this.названиепородыDataGridViewTextBoxColumn,
            this.времяпроведенияDataGridViewTextBoxColumn});
            this.рингDataGridView.DataSource = this.рингBindingSource;
            this.рингDataGridView.Location = new System.Drawing.Point(0, 30);
            this.рингDataGridView.Name = "рингDataGridView";
            this.рингDataGridView.RowHeadersWidth = 51;
            this.рингDataGridView.RowTemplate.Height = 24;
            this.рингDataGridView.Size = new System.Drawing.Size(691, 324);
            this.рингDataGridView.TabIndex = 1;
            // 
            // FormRings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 411);
            this.Controls.Add(this.toolStripButtonOK);
            this.Controls.Add(this.checkBoxFind);
            this.Controls.Add(this.рингDataGridView);
            this.Controls.Add(this.рингBindingNavigator);
            this.Name = "FormRings";
            this.Text = "Rings";
            this.Load += new System.EventHandler(this.FormRings_Load);
            this.Shown += new System.EventHandler(this.FormRings_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.рингBindingNavigator)).EndInit();
            this.рингBindingNavigator.ResumeLayout(false);
            this.рингBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.рингBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выставкаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.собака_РингBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.эксперт_РингBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рингDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ВыставкаDataSet выставкаDataSet;
        private System.Windows.Forms.BindingSource рингBindingSource;
        private ВыставкаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator рингBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton рингBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFind;
        private System.Windows.Forms.ToolStripButton toolStripButtonFind;
        private System.Windows.Forms.CheckBox checkBoxFind;
        private System.Windows.Forms.BindingSource собака_РингBindingSource;
        private System.Windows.Forms.BindingSource эксперт_РингBindingSource;
        private ВыставкаDataSetTableAdapters.Собака_РингTableAdapter собака_РингTableAdapter;
        private ВыставкаDataSetTableAdapters.РингTableAdapter рингTableAdapter;
        private ВыставкаDataSetTableAdapters.Эксперт_РингTableAdapter эксперт_РингTableAdapter;
        private System.Windows.Forms.Button toolStripButtonOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяпроведенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиепородыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиевыставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодрингаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView рингDataGridView;
    }
}