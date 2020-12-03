namespace College
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonKadet = new System.Windows.Forms.Button();
            this.buttonSpec = new System.Windows.Forms.Button();
            this.buttonListKad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonKadet
            // 
            this.buttonKadet.Location = new System.Drawing.Point(12, 223);
            this.buttonKadet.Name = "buttonKadet";
            this.buttonKadet.Size = new System.Drawing.Size(263, 54);
            this.buttonKadet.TabIndex = 1;
            this.buttonKadet.Text = "Кадеты";
            this.buttonKadet.UseVisualStyleBackColor = true;
            this.buttonKadet.Click += new System.EventHandler(this.buttonKadet_Click);
            // 
            // buttonSpec
            // 
            this.buttonSpec.Location = new System.Drawing.Point(12, 283);
            this.buttonSpec.Name = "buttonSpec";
            this.buttonSpec.Size = new System.Drawing.Size(263, 54);
            this.buttonSpec.TabIndex = 2;
            this.buttonSpec.Text = "Специальность";
            this.buttonSpec.UseVisualStyleBackColor = true;
            this.buttonSpec.Click += new System.EventHandler(this.buttonSpec_Click);
            // 
            // buttonListKad
            // 
            this.buttonListKad.Location = new System.Drawing.Point(12, 343);
            this.buttonListKad.Name = "buttonListKad";
            this.buttonListKad.Size = new System.Drawing.Size(263, 54);
            this.buttonListKad.TabIndex = 3;
            this.buttonListKad.Text = "Список кадетов";
            this.buttonListKad.UseVisualStyleBackColor = true;
            this.buttonListKad.Click += new System.EventHandler(this.buttonListKad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(287, 407);
            this.Controls.Add(this.buttonListKad);
            this.Controls.Add(this.buttonSpec);
            this.Controls.Add(this.buttonKadet);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Частный кадетский колледж";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonKadet;
        private System.Windows.Forms.Button buttonSpec;
        private System.Windows.Forms.Button buttonListKad;
    }
}

