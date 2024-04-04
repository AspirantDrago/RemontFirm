namespace RemontFirm
{
    partial class NewOrder
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxEqInfo = new System.Windows.Forms.TextBox();
            this.listBoxPrority = new System.Windows.Forms.ListBox();
            this.priorityBindingSourcePrority = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxTypesOfFault = new System.Windows.Forms.ListBox();
            this.dataBindingSourceTypeOfFault = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxTypeOfEq = new System.Windows.Forms.ListBox();
            this.typeOfEquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxEq = new System.Windows.Forms.TextBox();
            this.textBoxEqSerialNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priorityBindingSourcePrority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSourceTypeOfFault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfEquipmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxEqInfo, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.listBoxPrority, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxTypesOfFault, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxInfo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.listBoxTypeOfEq, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxEq, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxEqSerialNumber, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 347);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxEqInfo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxEqInfo, 2);
            this.textBoxEqInfo.Location = new System.Drawing.Point(3, 304);
            this.textBoxEqInfo.Multiline = true;
            this.textBoxEqInfo.Name = "textBoxEqInfo";
            this.textBoxEqInfo.Size = new System.Drawing.Size(318, 40);
            this.textBoxEqInfo.TabIndex = 10;
            // 
            // listBoxPrority
            // 
            this.listBoxPrority.DataSource = this.priorityBindingSourcePrority;
            this.listBoxPrority.DisplayMember = "Name";
            this.listBoxPrority.FormattingEnabled = true;
            this.listBoxPrority.Location = new System.Drawing.Point(170, 52);
            this.listBoxPrority.Name = "listBoxPrority";
            this.listBoxPrority.Size = new System.Drawing.Size(120, 43);
            this.listBoxPrority.TabIndex = 3;
            this.listBoxPrority.ValueMember = "Id";
            // 
            // priorityBindingSourcePrority
            // 
            this.priorityBindingSourcePrority.DataSource = typeof(RemontFirm.Models.Priority);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип неисправности";
            // 
            // listBoxTypesOfFault
            // 
            this.listBoxTypesOfFault.DataSource = this.dataBindingSourceTypeOfFault;
            this.listBoxTypesOfFault.DisplayMember = "Name";
            this.listBoxTypesOfFault.FormattingEnabled = true;
            this.listBoxTypesOfFault.Location = new System.Drawing.Point(170, 3);
            this.listBoxTypesOfFault.Name = "listBoxTypesOfFault";
            this.listBoxTypesOfFault.Size = new System.Drawing.Size(120, 43);
            this.listBoxTypesOfFault.TabIndex = 1;
            this.listBoxTypesOfFault.ValueMember = "Id";
            // 
            // dataBindingSourceTypeOfFault
            // 
            this.dataBindingSourceTypeOfFault.DataSource = typeof(RemontFirm.Models.TypeOfFault);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Приоритет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Информация";
            // 
            // textBoxInfo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxInfo, 2);
            this.textBoxInfo.Location = new System.Drawing.Point(3, 114);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(318, 70);
            this.textBoxInfo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Тип оборудования";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Оборудование";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Серийный номер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Описание";
            // 
            // listBoxTypeOfEq
            // 
            this.listBoxTypeOfEq.DataSource = this.typeOfEquipmentBindingSource;
            this.listBoxTypeOfEq.DisplayMember = "Name";
            this.listBoxTypeOfEq.FormattingEnabled = true;
            this.listBoxTypeOfEq.Location = new System.Drawing.Point(170, 190);
            this.listBoxTypeOfEq.Name = "listBoxTypeOfEq";
            this.listBoxTypeOfEq.Size = new System.Drawing.Size(120, 43);
            this.listBoxTypeOfEq.TabIndex = 11;
            this.listBoxTypeOfEq.ValueMember = "Id";
            // 
            // typeOfEquipmentBindingSource
            // 
            this.typeOfEquipmentBindingSource.DataSource = typeof(RemontFirm.Models.TypeOfEquipment);
            // 
            // textBoxEq
            // 
            this.textBoxEq.Location = new System.Drawing.Point(170, 239);
            this.textBoxEq.Name = "textBoxEq";
            this.textBoxEq.Size = new System.Drawing.Size(161, 20);
            this.textBoxEq.TabIndex = 12;
            // 
            // textBoxEqSerialNumber
            // 
            this.textBoxEqSerialNumber.Location = new System.Drawing.Point(170, 265);
            this.textBoxEqSerialNumber.Name = "textBoxEqSerialNumber";
            this.textBoxEqSerialNumber.Size = new System.Drawing.Size(161, 20);
            this.textBoxEqSerialNumber.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "СОХРАНИТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 400);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewOrder";
            this.Text = "Новый заказ";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priorityBindingSourcePrority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSourceTypeOfFault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfEquipmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxTypesOfFault;
        private System.Windows.Forms.BindingSource dataBindingSourceTypeOfFault;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxPrority;
        private System.Windows.Forms.BindingSource priorityBindingSourcePrority;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEqInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxTypeOfEq;
        private System.Windows.Forms.TextBox textBoxEq;
        private System.Windows.Forms.TextBox textBoxEqSerialNumber;
        private System.Windows.Forms.BindingSource typeOfEquipmentBindingSource;
    }
}