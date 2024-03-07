namespace cinemapark.forms
{
    partial class SoonForm
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
            this.okbtn = new System.Windows.Forms.Button();
            this.todaynamelabel = new System.Windows.Forms.Label();
            this.actorslabel = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.infolabel = new System.Windows.Forms.Label();
            this.soonGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premiertext = new System.Windows.Forms.TextBox();
            this.actorstext = new System.Windows.Forms.TextBox();
            this.nametext = new System.Windows.Forms.TextBox();
            this.idtext = new System.Windows.Forms.TextBox();
            this.soonOKbtn = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.actorslabel1 = new System.Windows.Forms.Label();
            this.premierlabel = new System.Windows.Forms.Label();
            this.soonIDlabel = new System.Windows.Forms.Label();
            this.soonInfolabel = new System.Windows.Forms.Label();
            this.soonGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.soonGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soonGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // okbtn
            // 
            this.okbtn.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okbtn.Location = new System.Drawing.Point(20, 349);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(191, 76);
            this.okbtn.TabIndex = 12;
            this.okbtn.Text = "Готово";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // todaynamelabel
            // 
            this.todaynamelabel.AutoSize = true;
            this.todaynamelabel.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.todaynamelabel.Location = new System.Drawing.Point(13, 196);
            this.todaynamelabel.Name = "todaynamelabel";
            this.todaynamelabel.Size = new System.Drawing.Size(131, 32);
            this.todaynamelabel.TabIndex = 11;
            this.todaynamelabel.Text = "Название";
            // 
            // actorslabel
            // 
            this.actorslabel.AutoSize = true;
            this.actorslabel.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actorslabel.Location = new System.Drawing.Point(13, 243);
            this.actorslabel.Name = "actorslabel";
            this.actorslabel.Size = new System.Drawing.Size(102, 32);
            this.actorslabel.TabIndex = 10;
            this.actorslabel.Text = "Актёры";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datelabel.Location = new System.Drawing.Point(12, 292);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(137, 32);
            this.datelabel.TabIndex = 9;
            this.datelabel.Text = "Премьера";
            this.datelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDlabel.Location = new System.Drawing.Point(13, 155);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(40, 32);
            this.IDlabel.TabIndex = 8;
            this.IDlabel.Text = "ID";
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Font = new System.Drawing.Font("Montserrat", 15F);
            this.infolabel.Location = new System.Drawing.Point(12, 102);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(322, 35);
            this.infolabel.TabIndex = 7;
            this.infolabel.Text = "Информация о фильме";
            // 
            // soonGridView
            // 
            this.soonGridView.AllowUserToOrderColumns = true;
            this.soonGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.soonGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soonGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Title,
            this.actors,
            this.premier});
            this.soonGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soonGridView.Location = new System.Drawing.Point(0, 0);
            this.soonGridView.Name = "soonGridView";
            this.soonGridView.RowHeadersWidth = 51;
            this.soonGridView.RowTemplate.Height = 24;
            this.soonGridView.Size = new System.Drawing.Size(800, 450);
            this.soonGridView.TabIndex = 13;
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
            // premier
            // 
            this.premier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.premier.HeaderText = "Премьера";
            this.premier.MinimumWidth = 6;
            this.premier.Name = "premier";
            // 
            // premiertext
            // 
            this.premiertext.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.premiertext.Location = new System.Drawing.Point(197, 282);
            this.premiertext.Name = "premiertext";
            this.premiertext.Size = new System.Drawing.Size(572, 22);
            this.premiertext.TabIndex = 24;
            // 
            // actorstext
            // 
            this.actorstext.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.actorstext.Location = new System.Drawing.Point(197, 235);
            this.actorstext.Name = "actorstext";
            this.actorstext.Size = new System.Drawing.Size(572, 22);
            this.actorstext.TabIndex = 23;
            // 
            // nametext
            // 
            this.nametext.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nametext.Location = new System.Drawing.Point(197, 188);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(572, 22);
            this.nametext.TabIndex = 22;
            // 
            // idtext
            // 
            this.idtext.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.idtext.Location = new System.Drawing.Point(197, 147);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(572, 22);
            this.idtext.TabIndex = 21;
            // 
            // soonOKbtn
            // 
            this.soonOKbtn.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.soonOKbtn.Location = new System.Drawing.Point(19, 331);
            this.soonOKbtn.Name = "soonOKbtn";
            this.soonOKbtn.Size = new System.Drawing.Size(191, 76);
            this.soonOKbtn.TabIndex = 20;
            this.soonOKbtn.Text = "Готово";
            this.soonOKbtn.UseVisualStyleBackColor = true;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namelabel.Location = new System.Drawing.Point(12, 178);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(131, 32);
            this.namelabel.TabIndex = 19;
            this.namelabel.Text = "Название";
            // 
            // actorslabel1
            // 
            this.actorslabel1.AutoSize = true;
            this.actorslabel1.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actorslabel1.Location = new System.Drawing.Point(12, 225);
            this.actorslabel1.Name = "actorslabel1";
            this.actorslabel1.Size = new System.Drawing.Size(102, 32);
            this.actorslabel1.TabIndex = 18;
            this.actorslabel1.Text = "Актёры";
            // 
            // premierlabel
            // 
            this.premierlabel.AutoSize = true;
            this.premierlabel.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.premierlabel.Location = new System.Drawing.Point(12, 272);
            this.premierlabel.Name = "premierlabel";
            this.premierlabel.Size = new System.Drawing.Size(137, 32);
            this.premierlabel.TabIndex = 17;
            this.premierlabel.Text = "Премьера";
            // 
            // soonIDlabel
            // 
            this.soonIDlabel.AutoSize = true;
            this.soonIDlabel.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.soonIDlabel.Location = new System.Drawing.Point(12, 137);
            this.soonIDlabel.Name = "soonIDlabel";
            this.soonIDlabel.Size = new System.Drawing.Size(40, 32);
            this.soonIDlabel.TabIndex = 16;
            this.soonIDlabel.Text = "ID";
            // 
            // soonInfolabel
            // 
            this.soonInfolabel.AutoSize = true;
            this.soonInfolabel.Font = new System.Drawing.Font("Montserrat", 15F);
            this.soonInfolabel.Location = new System.Drawing.Point(11, 84);
            this.soonInfolabel.Name = "soonInfolabel";
            this.soonInfolabel.Size = new System.Drawing.Size(322, 35);
            this.soonInfolabel.TabIndex = 15;
            this.soonInfolabel.Text = "Информация о фильме";
            // 
            // soonGridView1
            // 
            this.soonGridView1.AllowUserToOrderColumns = true;
            this.soonGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.soonGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soonGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.FilmName,
            this.dataGridViewTextBoxColumn3,
            this.rating});
            this.soonGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soonGridView1.Location = new System.Drawing.Point(0, 0);
            this.soonGridView1.Name = "soonGridView1";
            this.soonGridView1.RowHeadersWidth = 51;
            this.soonGridView1.RowTemplate.Height = 24;
            this.soonGridView1.Size = new System.Drawing.Size(800, 450);
            this.soonGridView1.TabIndex = 14;
            this.soonGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.soonGridView1_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // FilmName
            // 
            this.FilmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FilmName.FillWeight = 200F;
            this.FilmName.HeaderText = "Название";
            this.FilmName.MinimumWidth = 12;
            this.FilmName.Name = "FilmName";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Актёры";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // rating
            // 
            this.rating.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rating.HeaderText = "Премьера";
            this.rating.MinimumWidth = 6;
            this.rating.Name = "rating";
            // 
            // SoonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.premiertext);
            this.Controls.Add(this.actorstext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.idtext);
            this.Controls.Add(this.soonOKbtn);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.actorslabel1);
            this.Controls.Add(this.premierlabel);
            this.Controls.Add(this.soonIDlabel);
            this.Controls.Add(this.soonInfolabel);
            this.Controls.Add(this.soonGridView1);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.todaynamelabel);
            this.Controls.Add(this.actorslabel);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.soonGridView);
            this.Name = "SoonForm";
            this.Text = "Soon";
            this.Load += new System.EventHandler(this.Soon_Load);
            this.Click += new System.EventHandler(this.Soon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soonGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soonGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.Label todaynamelabel;
        private System.Windows.Forms.Label actorslabel;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.DataGridView soonGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn actors;
        private System.Windows.Forms.DataGridViewTextBoxColumn premier;
        private System.Windows.Forms.TextBox premiertext;
        private System.Windows.Forms.TextBox actorstext;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.Button soonOKbtn;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label actorslabel1;
        private System.Windows.Forms.Label premierlabel;
        private System.Windows.Forms.Label soonIDlabel;
        private System.Windows.Forms.Label soonInfolabel;
        private System.Windows.Forms.DataGridView soonGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn rating;
    }
}