namespace cinemapark.forms
{
    partial class TodayForm
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
            this.filmstodayGridView1 = new System.Windows.Forms.DataGridView();
            this.infolabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.ratelabel = new System.Windows.Forms.Label();
            this.actorslabel = new System.Windows.Forms.Label();
            this.todaynamelabel = new System.Windows.Forms.Label();
            this.okbtn = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtext = new System.Windows.Forms.TextBox();
            this.nametext = new System.Windows.Forms.TextBox();
            this.actorstext = new System.Windows.Forms.TextBox();
            this.ratingtext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.filmstodayGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // filmstodayGridView1
            // 
            this.filmstodayGridView1.AllowUserToOrderColumns = true;
            this.filmstodayGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.filmstodayGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmstodayGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Title,
            this.actors,
            this.rating});
            this.filmstodayGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filmstodayGridView1.Location = new System.Drawing.Point(0, 0);
            this.filmstodayGridView1.Name = "filmstodayGridView1";
            this.filmstodayGridView1.RowHeadersWidth = 51;
            this.filmstodayGridView1.RowTemplate.Height = 24;
            this.filmstodayGridView1.Size = new System.Drawing.Size(800, 450);
            this.filmstodayGridView1.TabIndex = 0;
            this.filmstodayGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewToday_CellClick);
            this.filmstodayGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Font = new System.Drawing.Font("Montserrat", 15F);
            this.infolabel.Location = new System.Drawing.Point(11, 86);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(322, 35);
            this.infolabel.TabIndex = 1;
            this.infolabel.Text = "Информация о фильме";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDlabel.Location = new System.Drawing.Point(12, 139);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(40, 32);
            this.IDlabel.TabIndex = 2;
            this.IDlabel.Text = "ID";
            // 
            // ratelabel
            // 
            this.ratelabel.AutoSize = true;
            this.ratelabel.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratelabel.Location = new System.Drawing.Point(12, 274);
            this.ratelabel.Name = "ratelabel";
            this.ratelabel.Size = new System.Drawing.Size(114, 32);
            this.ratelabel.TabIndex = 3;
            this.ratelabel.Text = "Рейтинг";
            // 
            // actorslabel
            // 
            this.actorslabel.AutoSize = true;
            this.actorslabel.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actorslabel.Location = new System.Drawing.Point(12, 227);
            this.actorslabel.Name = "actorslabel";
            this.actorslabel.Size = new System.Drawing.Size(102, 32);
            this.actorslabel.TabIndex = 4;
            this.actorslabel.Text = "Актёры";
            // 
            // todaynamelabel
            // 
            this.todaynamelabel.AutoSize = true;
            this.todaynamelabel.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.todaynamelabel.Location = new System.Drawing.Point(12, 180);
            this.todaynamelabel.Name = "todaynamelabel";
            this.todaynamelabel.Size = new System.Drawing.Size(131, 32);
            this.todaynamelabel.TabIndex = 5;
            this.todaynamelabel.Text = "Название";
            // 
            // okbtn
            // 
            this.okbtn.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okbtn.Location = new System.Drawing.Point(19, 333);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(191, 76);
            this.okbtn.TabIndex = 6;
            this.okbtn.Text = "Готово";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.FillWeight = 200F;
            this.Title.HeaderText = "Название";
            this.Title.MinimumWidth = 12;
            this.Title.Name = "Title";
            // 
            // actors
            // 
            this.actors.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.actors.HeaderText = "Актёры";
            this.actors.MinimumWidth = 6;
            this.actors.Name = "actors";
            // 
            // rating
            // 
            this.rating.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rating.HeaderText = "Рейтинг ";
            this.rating.MinimumWidth = 6;
            this.rating.Name = "rating";
            // 
            // idtext
            // 
            this.idtext.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.idtext.Location = new System.Drawing.Point(197, 149);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(572, 22);
            this.idtext.TabIndex = 7;
            // 
            // nametext
            // 
            this.nametext.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nametext.Location = new System.Drawing.Point(197, 190);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(572, 22);
            this.nametext.TabIndex = 8;
            // 
            // actorstext
            // 
            this.actorstext.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.actorstext.Location = new System.Drawing.Point(197, 237);
            this.actorstext.Name = "actorstext";
            this.actorstext.Size = new System.Drawing.Size(572, 22);
            this.actorstext.TabIndex = 9;
            // 
            // ratingtext
            // 
            this.ratingtext.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ratingtext.Location = new System.Drawing.Point(197, 284);
            this.ratingtext.Name = "ratingtext";
            this.ratingtext.Size = new System.Drawing.Size(572, 22);
            this.ratingtext.TabIndex = 10;
            // 
            // TodayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ratingtext);
            this.Controls.Add(this.actorstext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.idtext);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.todaynamelabel);
            this.Controls.Add(this.actorslabel);
            this.Controls.Add(this.ratelabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.filmstodayGridView1);
            this.Name = "TodayForm";
            this.Text = "Today";
            this.Load += new System.EventHandler(this.Today_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmstodayGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView filmstodayGridView1;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label ratelabel;
        private System.Windows.Forms.Label actorslabel;
        private System.Windows.Forms.Label todaynamelabel;
        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn actors;
        private System.Windows.Forms.DataGridViewTextBoxColumn rating;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.TextBox actorstext;
        private System.Windows.Forms.TextBox ratingtext;
    }
}