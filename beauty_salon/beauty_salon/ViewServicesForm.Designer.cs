
namespace beauty_salon
{
    partial class ViewServicesForm
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
            this.servicesDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationInSecondsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainImagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nail_salonDataSet = new beauty_salon.Nail_salonDataSet();
            this.logoNamePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serviceTableAdapter = new beauty_salon.Nail_salonDataSetTableAdapters.ServiceTableAdapter();
            this.backBtn = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.fieldLabel = new System.Windows.Forms.Label();
            this.columnsCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.changeDataBtn = new System.Windows.Forms.Button();
            this.addDataServBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nail_salonDataSet)).BeginInit();
            this.logoNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // servicesDataGridView
            // 
            this.servicesDataGridView.AllowUserToAddRows = false;
            this.servicesDataGridView.AutoGenerateColumns = false;
            this.servicesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.servicesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.servicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.durationInSecondsDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.mainImagePathDataGridViewTextBoxColumn});
            this.servicesDataGridView.DataSource = this.serviceBindingSource;
            this.servicesDataGridView.Location = new System.Drawing.Point(0, 114);
            this.servicesDataGridView.Name = "servicesDataGridView";
            this.servicesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.servicesDataGridView.Size = new System.Drawing.Size(800, 265);
            this.servicesDataGridView.TabIndex = 0;
            this.servicesDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.servicesDataGridView_CellEndEdit);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 35.53301F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.FillWeight = 117.8365F;
            this.titleDataGridViewTextBoxColumn.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.FillWeight = 109.3262F;
            this.costDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // durationInSecondsDataGridViewTextBoxColumn
            // 
            this.durationInSecondsDataGridViewTextBoxColumn.DataPropertyName = "DurationInSeconds";
            this.durationInSecondsDataGridViewTextBoxColumn.FillWeight = 109.3262F;
            this.durationInSecondsDataGridViewTextBoxColumn.HeaderText = "Длительность(сек.)";
            this.durationInSecondsDataGridViewTextBoxColumn.Name = "durationInSecondsDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 109.3262F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.FillWeight = 109.3262F;
            this.discountDataGridViewTextBoxColumn.HeaderText = "Скидка";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // mainImagePathDataGridViewTextBoxColumn
            // 
            this.mainImagePathDataGridViewTextBoxColumn.DataPropertyName = "MainImagePath";
            this.mainImagePathDataGridViewTextBoxColumn.FillWeight = 109.3262F;
            this.mainImagePathDataGridViewTextBoxColumn.HeaderText = "Путь до изображения";
            this.mainImagePathDataGridViewTextBoxColumn.Name = "mainImagePathDataGridViewTextBoxColumn";
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.nail_salonDataSet;
            // 
            // nail_salonDataSet
            // 
            this.nail_salonDataSet.DataSetName = "Nail_salonDataSet";
            this.nail_salonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logoNamePanel
            // 
            this.logoNamePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logoNamePanel.Controls.Add(this.pictureBox1);
            this.logoNamePanel.Controls.Add(this.label1);
            this.logoNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoNamePanel.Location = new System.Drawing.Point(0, 0);
            this.logoNamePanel.Name = "logoNamePanel";
            this.logoNamePanel.Size = new System.Drawing.Size(800, 118);
            this.logoNamePanel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::beauty_salon.Properties.Resources.beauty_logo;
            this.pictureBox1.Location = new System.Drawing.Point(27, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(244, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бархатные бровки";
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(671, 385);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(117, 53);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(57, 412);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(120, 20);
            this.searchTB.TabIndex = 8;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // fieldLabel
            // 
            this.fieldLabel.AutoSize = true;
            this.fieldLabel.Location = new System.Drawing.Point(12, 388);
            this.fieldLabel.Name = "fieldLabel";
            this.fieldLabel.Size = new System.Drawing.Size(33, 13);
            this.fieldLabel.TabIndex = 9;
            this.fieldLabel.Text = "Поле";
            // 
            // columnsCB
            // 
            this.columnsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnsCB.FormattingEnabled = true;
            this.columnsCB.Location = new System.Drawing.Point(57, 385);
            this.columnsCB.Name = "columnsCB";
            this.columnsCB.Size = new System.Drawing.Size(121, 21);
            this.columnsCB.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Поиск";
            // 
            // changeDataBtn
            // 
            this.changeDataBtn.Location = new System.Drawing.Point(370, 385);
            this.changeDataBtn.Name = "changeDataBtn";
            this.changeDataBtn.Size = new System.Drawing.Size(117, 53);
            this.changeDataBtn.TabIndex = 13;
            this.changeDataBtn.Text = "Изменить";
            this.changeDataBtn.UseVisualStyleBackColor = true;
            // 
            // addDataServBtn
            // 
            this.addDataServBtn.Location = new System.Drawing.Point(226, 385);
            this.addDataServBtn.Name = "addDataServBtn";
            this.addDataServBtn.Size = new System.Drawing.Size(117, 53);
            this.addDataServBtn.TabIndex = 12;
            this.addDataServBtn.Text = "Добавить";
            this.addDataServBtn.UseVisualStyleBackColor = true;
            this.addDataServBtn.Click += new System.EventHandler(this.addDataServBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(513, 385);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(117, 53);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // ViewServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.changeDataBtn);
            this.Controls.Add(this.addDataServBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.columnsCB);
            this.Controls.Add(this.fieldLabel);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.logoNamePanel);
            this.Controls.Add(this.servicesDataGridView);
            this.MaximumSize = new System.Drawing.Size(808, 481);
            this.MinimumSize = new System.Drawing.Size(808, 481);
            this.Name = "ViewServicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр услуг";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewServices_FormClosed);
            this.Load += new System.EventHandler(this.ViewServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nail_salonDataSet)).EndInit();
            this.logoNamePanel.ResumeLayout(false);
            this.logoNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView servicesDataGridView;
        private System.Windows.Forms.Panel logoNamePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Nail_salonDataSet nail_salonDataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private Nail_salonDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationInSecondsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainImagePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label fieldLabel;
        private System.Windows.Forms.ComboBox columnsCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button changeDataBtn;
        private System.Windows.Forms.Button addDataServBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}