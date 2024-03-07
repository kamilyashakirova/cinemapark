using System;
using System.Drawing;
using System.Windows.Forms;
using cinemapark.forms;
using FontAwesome.Sharp;

namespace cinemapark
{
    public partial class CinemaParkForm : Form
    {
        private Form childform;
        private IconButton btn;
        private Panel leftBorderBtn;
        private static Color color = Color.FromArgb(33, 183, 155);
        public CinemaParkForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 65);
            menupanel.Controls.Add(leftBorderBtn);
        }
        private void DisableButton()
        {
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(44, 56, 79);
                btn.ForeColor = Color.WhiteSmoke;
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.IconColor = Color.WhiteSmoke;
                btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                btn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            titlelabel.Text = "Главная";
        }
        private void mainlogo_Click(object sender, EventArgs e)
        {
            reset();
            childform?.Close();

        }
        private void OpenChildForm(Form childform)
        {
            this.childform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            desktopp.Controls.Add(childform);
            desktopp.Tag = childform;
            childform.BringToFront();
            childform.Show();
            titlelabel.Text = childform.Text;
        }

        private void todaybtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TodayForm());
        }

        private void soonbtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SoonForm());
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
