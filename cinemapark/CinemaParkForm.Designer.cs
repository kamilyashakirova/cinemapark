namespace cinemapark
{
    partial class CinemaParkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CinemaParkForm));
            this.menupanel = new System.Windows.Forms.Panel();
            this.soonbtn = new System.Windows.Forms.Button();
            this.mainlogo = new System.Windows.Forms.PictureBox();
            this.todaybtn = new System.Windows.Forms.Button();
            this.titlepanel = new System.Windows.Forms.Panel();
            this.titlelabel = new System.Windows.Forms.Label();
            this.desktopp = new System.Windows.Forms.Panel();
            this.exitbtn = new System.Windows.Forms.Button();
            this.menupanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainlogo)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menupanel
            // 
            this.menupanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menupanel.BackColor = System.Drawing.Color.MistyRose;
            this.menupanel.Controls.Add(this.exitbtn);
            this.menupanel.Controls.Add(this.soonbtn);
            this.menupanel.Controls.Add(this.mainlogo);
            this.menupanel.Controls.Add(this.todaybtn);
            this.menupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menupanel.Location = new System.Drawing.Point(0, 0);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(297, 611);
            this.menupanel.TabIndex = 0;
            // 
            // soonbtn
            // 
            this.soonbtn.BackColor = System.Drawing.Color.Pink;
            this.soonbtn.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.soonbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.soonbtn.Location = new System.Drawing.Point(12, 325);
            this.soonbtn.Name = "soonbtn";
            this.soonbtn.Size = new System.Drawing.Size(275, 55);
            this.soonbtn.TabIndex = 3;
            this.soonbtn.Text = "Скоро";
            this.soonbtn.UseVisualStyleBackColor = false;
            this.soonbtn.Click += new System.EventHandler(this.soonbtn_Click);
            // 
            // mainlogo
            // 
            this.mainlogo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mainlogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("mainlogo.ErrorImage")));
            this.mainlogo.Image = ((System.Drawing.Image)(resources.GetObject("mainlogo.Image")));
            this.mainlogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("mainlogo.InitialImage")));
            this.mainlogo.Location = new System.Drawing.Point(24, 13);
            this.mainlogo.Name = "mainlogo";
            this.mainlogo.Size = new System.Drawing.Size(249, 162);
            this.mainlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainlogo.TabIndex = 2;
            this.mainlogo.TabStop = false;
            this.mainlogo.Click += new System.EventHandler(this.mainlogo_Click);
            // 
            // todaybtn
            // 
            this.todaybtn.BackColor = System.Drawing.Color.Pink;
            this.todaybtn.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.todaybtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.todaybtn.Location = new System.Drawing.Point(12, 225);
            this.todaybtn.Name = "todaybtn";
            this.todaybtn.Size = new System.Drawing.Size(275, 54);
            this.todaybtn.TabIndex = 1;
            this.todaybtn.Text = "Фильмы сегодня";
            this.todaybtn.UseVisualStyleBackColor = false;
            this.todaybtn.Click += new System.EventHandler(this.todaybtn_Click);
            // 
            // titlepanel
            // 
            this.titlepanel.BackColor = System.Drawing.Color.Pink;
            this.titlepanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titlepanel.Controls.Add(this.titlelabel);
            this.titlepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlepanel.Location = new System.Drawing.Point(297, 0);
            this.titlepanel.Name = "titlepanel";
            this.titlepanel.Size = new System.Drawing.Size(538, 62);
            this.titlepanel.TabIndex = 1;
            // 
            // titlelabel
            // 
            this.titlelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titlelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titlelabel.Location = new System.Drawing.Point(224, 12);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(118, 35);
            this.titlelabel.TabIndex = 0;
            this.titlelabel.Text = "Главная";
            // 
            // desktopp
            // 
            this.desktopp.BackColor = System.Drawing.Color.MistyRose;
            this.desktopp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.desktopp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktopp.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktopp.Location = new System.Drawing.Point(297, 62);
            this.desktopp.Name = "desktopp";
            this.desktopp.Size = new System.Drawing.Size(538, 549);
            this.desktopp.TabIndex = 2;
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Pink;
            this.exitbtn.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitbtn.Location = new System.Drawing.Point(12, 435);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(275, 55);
            this.exitbtn.TabIndex = 4;
            this.exitbtn.Text = "Выход";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // CinemaParkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 611);
            this.Controls.Add(this.desktopp);
            this.Controls.Add(this.titlepanel);
            this.Controls.Add(this.menupanel);
            this.Name = "CinemaParkForm";
            this.Text = "CinemaPark";
            this.menupanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainlogo)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.Panel titlepanel;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Button todaybtn;
        private System.Windows.Forms.Button soonbtn;
        private System.Windows.Forms.PictureBox mainlogo;
        private System.Windows.Forms.Panel desktopp;
        private System.Windows.Forms.Button exitbtn;
    }
}

