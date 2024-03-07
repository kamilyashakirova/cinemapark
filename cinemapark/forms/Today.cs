using System;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;

namespace cinemapark.forms
{
    public partial class TodayForm : Form
    {
        public TodayForm()
        {
            InitializeComponent();
            reset();
        }

        private void Today_Load(object sender, EventArgs e)
        {
           data();
        }
        private void data()
        {
            XDocument xmlDocument = XDocument.Load("../../references/filmstoday.xml");
            string jsonText = System.IO.File.ReadAllText("../../references/filmstoday.json");
            JObject jsonObject = JObject.Parse(jsonText);
            DisplayfilmstodayInTable(xmlDocument);
        }
        private void DisplayfilmstodayInTable(XDocument xmlDocument)
        {
            filmstodayGridView1.Rows.Clear();

            foreach (var elemtoday in xmlDocument.Root.Elements("filmstoday"))
            {
                string id = elemtoday.Element("ID")?.Value ?? "N/A";
                string name = elemtoday.Element("name")?.Value ?? "N/A";
                string actors = elemtoday.Element("actors")?.Value ?? "N/A";
                string rating = elemtoday.Element("rating")?.Value ?? "N/A";
                filmstodayGridView1.Rows.Add(id, name, actors, rating);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewToday_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < filmstodayGridView1.Rows.Count)
            {
                filmstodayGridView1.Visible = false;
                infolabel.Visible = true;
                IDlabel.Visible = true;
                todaynamelabel.Visible = true;
                actorslabel.Visible = true;
                ratelabel.Visible = true;
                idtext.Visible = true;
                nametext.Visible = true;
                actorstext.Visible = true;
                ratingtext.Visible = true;
                okbtn.Visible = true;
                DataGridViewRow selrow = filmstodayGridView1.Rows[e.RowIndex];
                string seltitle = selrow.Cells["Title"].Value.ToString();
                DisplayTodaySingleInfo(seltitle);
            }
        }
        private void DisplayTodaySingleInfo(string seltitle)
        {
            JObject jsonObj = JObject.Parse(System.IO.File.ReadAllText("../../references/filmstoday.json"));
            JToken selfilm = jsonObj["filmstoday"].FirstOrDefault(f => f["name"].ToString() == seltitle);

            if (selfilm != null) 
            {
                idtext.Text = selfilm["ID"].ToString();
                nametext.Text = selfilm["name"].ToString();
                actorstext.Text = selfilm["actors"].ToString();
                ratingtext.Text = selfilm["rating"].ToString();
            }
        }
        private void reset()
        {
            filmstodayGridView1.Visible = true;
            infolabel.Visible = false;
            IDlabel.Visible = false;
            todaynamelabel.Visible = false;
            actorslabel.Visible = false;
            ratelabel.Visible = false;
            idtext.Visible = false;
            nametext.Visible = false;
            actorstext.Visible = false;
            ratingtext.Visible = false;
            okbtn.Visible = false;
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}