
namespace beauty_salon
{
    partial class addServiceDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addServiceDataForm));
            this.logoNamePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleTb = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.pathTb = new System.Windows.Forms.TextBox();
            this.discountTb = new System.Windows.Forms.TextBox();
            this.costTb = new System.Windows.Forms.TextBox();
            this.timeTb = new System.Windows.Forms.TextBox();
            this.descriptionTb = new System.Windows.Forms.TextBox();
            this.cost = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.Label();
            this.logoNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.logoNamePanel.TabIndex = 7;
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
            // titleTb
            // 
            this.titleTb.Location = new System.Drawing.Point(282, 138);
            this.titleTb.Name = "titleTb";
            this.titleTb.Size = new System.Drawing.Size(213, 20);
            this.titleTb.TabIndex = 8;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(219, 141);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(57, 13);
            this.title.TabIndex = 9;
            this.title.Text = "Название";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(671, 385);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(117, 53);
            this.backBtn.TabIndex = 10;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(332, 385);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(117, 53);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // pathTb
            // 
            this.pathTb.Location = new System.Drawing.Point(282, 327);
            this.pathTb.Name = "pathTb";
            this.pathTb.Size = new System.Drawing.Size(213, 20);
            this.pathTb.TabIndex = 12;
            // 
            // discountTb
            // 
            this.discountTb.Location = new System.Drawing.Point(282, 291);
            this.discountTb.Name = "discountTb";
            this.discountTb.Size = new System.Drawing.Size(213, 20);
            this.discountTb.TabIndex = 13;
            // 
            // costTb
            // 
            this.costTb.Location = new System.Drawing.Point(282, 177);
            this.costTb.Name = "costTb";
            this.costTb.Size = new System.Drawing.Size(213, 20);
            this.costTb.TabIndex = 14;
            // 
            // timeTb
            // 
            this.timeTb.Location = new System.Drawing.Point(282, 217);
            this.timeTb.Name = "timeTb";
            this.timeTb.Size = new System.Drawing.Size(213, 20);
            this.timeTb.TabIndex = 15;
            // 
            // descriptionTb
            // 
            this.descriptionTb.Location = new System.Drawing.Point(282, 256);
            this.descriptionTb.Name = "descriptionTb";
            this.descriptionTb.Size = new System.Drawing.Size(213, 20);
            this.descriptionTb.TabIndex = 16;
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Location = new System.Drawing.Point(214, 180);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(62, 13);
            this.cost.TabIndex = 17;
            this.cost.Text = "Стоимость";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(166, 220);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(110, 13);
            this.time.TabIndex = 18;
            this.time.Text = "Длительность (сек.)";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(227, 259);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(57, 13);
            this.description.TabIndex = 19;
            this.description.Text = "Описание";
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Location = new System.Drawing.Point(232, 294);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(44, 13);
            this.discount.TabIndex = 20;
            this.discount.Text = "Скидка";
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(159, 330);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(117, 13);
            this.path.TabIndex = 21;
            this.path.Text = "Путь до изображения";
            // 
            // addServiceDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.path);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.description);
            this.Controls.Add(this.time);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.descriptionTb);
            this.Controls.Add(this.timeTb);
            this.Controls.Add(this.costTb);
            this.Controls.Add(this.discountTb);
            this.Controls.Add(this.pathTb);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.titleTb);
            this.Controls.Add(this.logoNamePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(808, 481);
            this.MinimumSize = new System.Drawing.Size(808, 481);
            this.Name = "addServiceDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление услуг";
            this.logoNamePanel.ResumeLayout(false);
            this.logoNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel logoNamePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTb;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox pathTb;
        private System.Windows.Forms.TextBox discountTb;
        private System.Windows.Forms.TextBox costTb;
        private System.Windows.Forms.TextBox timeTb;
        private System.Windows.Forms.TextBox descriptionTb;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.Label path;
    }
}