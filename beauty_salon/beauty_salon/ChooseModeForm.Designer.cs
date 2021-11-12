
namespace beauty_salon
{
    partial class ChooseModeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseModeForm));
            this.viewServBtn = new System.Windows.Forms.Button();
            this.registrOnServ = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.logoNamePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewServBtn
            // 
            this.viewServBtn.Location = new System.Drawing.Point(120, 280);
            this.viewServBtn.Name = "viewServBtn";
            this.viewServBtn.Size = new System.Drawing.Size(117, 53);
            this.viewServBtn.TabIndex = 0;
            this.viewServBtn.Text = "Услуги";
            this.viewServBtn.UseVisualStyleBackColor = true;
            this.viewServBtn.Click += new System.EventHandler(this.viewServBtn_Click);
            // 
            // registrOnServ
            // 
            this.registrOnServ.Location = new System.Drawing.Point(537, 280);
            this.registrOnServ.Name = "registrOnServ";
            this.registrOnServ.Size = new System.Drawing.Size(117, 53);
            this.registrOnServ.TabIndex = 2;
            this.registrOnServ.Text = "Запись клиента на услугу";
            this.registrOnServ.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(405, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 53);
            this.button4.TabIndex = 3;
            this.button4.Text = "Работа с изображениями";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(256, 280);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 53);
            this.button5.TabIndex = 4;
            this.button5.Text = "Управление записями клиентов на услуги";
            this.button5.UseVisualStyleBackColor = true;
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
            this.logoNamePanel.TabIndex = 5;
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
            // ChooseModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoNamePanel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.registrOnServ);
            this.Controls.Add(this.viewServBtn);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(808, 481);
            this.MinimumSize = new System.Drawing.Size(808, 481);
            this.Name = "ChooseModeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с услугами";
            this.logoNamePanel.ResumeLayout(false);
            this.logoNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewServBtn;
        private System.Windows.Forms.Button registrOnServ;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel logoNamePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

