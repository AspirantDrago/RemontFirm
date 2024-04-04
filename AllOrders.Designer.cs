namespace RemontFirm
{
    partial class AllOrders
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonNewOrder = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentSerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfCreationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfFault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateOfCreationDataGridViewTextBoxColumn,
            this.Status,
            this.TypeOfFault,
            this.priorityDataGridViewTextBoxColumn,
            this.EquipmentTitle,
            this.EquipmentInformation,
            this.EquipmentSerialNumber,
            this.informationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.applicationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(870, 281);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonNewOrder
            // 
            this.buttonNewOrder.Location = new System.Drawing.Point(164, 12);
            this.buttonNewOrder.Name = "buttonNewOrder";
            this.buttonNewOrder.Size = new System.Drawing.Size(126, 47);
            this.buttonNewOrder.TabIndex = 1;
            this.buttonNewOrder.Text = "Добавить заказ";
            this.buttonNewOrder.UseVisualStyleBackColor = true;
            this.buttonNewOrder.Click += new System.EventHandler(this.buttonNewOrder_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn1.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TypeOfFault";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип поломки";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn3.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TypeOfFault";
            this.dataGridViewTextBoxColumn4.HeaderText = "Тип поломки";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // EquipmentTitle
            // 
            this.EquipmentTitle.DataPropertyName = "EquipmentTitle";
            this.EquipmentTitle.HeaderText = "Оборудование";
            this.EquipmentTitle.Name = "EquipmentTitle";
            this.EquipmentTitle.ReadOnly = true;
            // 
            // EquipmentInformation
            // 
            this.EquipmentInformation.DataPropertyName = "EquipmentInformation";
            this.EquipmentInformation.HeaderText = "Оборудование (инф)";
            this.EquipmentInformation.Name = "EquipmentInformation";
            this.EquipmentInformation.ReadOnly = true;
            // 
            // EquipmentSerialNumber
            // 
            this.EquipmentSerialNumber.DataPropertyName = "EquipmentSerialNumber";
            this.EquipmentSerialNumber.HeaderText = "Серийный номер";
            this.EquipmentSerialNumber.Name = "EquipmentSerialNumber";
            this.EquipmentSerialNumber.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn5.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TypeOfFault";
            this.dataGridViewTextBoxColumn6.HeaderText = "Тип поломки";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dateOfCreationDataGridViewTextBoxColumn
            // 
            this.dateOfCreationDataGridViewTextBoxColumn.DataPropertyName = "DateOfCreation";
            this.dateOfCreationDataGridViewTextBoxColumn.HeaderText = "DateOfCreation";
            this.dateOfCreationDataGridViewTextBoxColumn.Name = "dateOfCreationDataGridViewTextBoxColumn";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // TypeOfFault
            // 
            this.TypeOfFault.DataPropertyName = "TypeOfFault";
            this.TypeOfFault.HeaderText = "Тип поломки";
            this.TypeOfFault.Name = "TypeOfFault";
            this.TypeOfFault.ReadOnly = true;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            // 
            // informationDataGridViewTextBoxColumn
            // 
            this.informationDataGridViewTextBoxColumn.DataPropertyName = "Information";
            this.informationDataGridViewTextBoxColumn.HeaderText = "Information";
            this.informationDataGridViewTextBoxColumn.Name = "informationDataGridViewTextBoxColumn";
            // 
            // applicationsBindingSource
            // 
            this.applicationsBindingSource.DataSource = typeof(RemontFirm.Models.Applications);
            // 
            // AllOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 358);
            this.Controls.Add(this.buttonNewOrder);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AllOrders";
            this.Text = "Ремонтная мастерская";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonNewOrder;
        private System.Windows.Forms.BindingSource applicationsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfCreationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfFault;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentSerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn informationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

