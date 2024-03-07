using System;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;

namespace cinemapark.forms
{
    public partial class SoonForm : Form
    {
        public SoonForm()
        {
            InitializeComponent();
            reset();
        }

        private void Soon_Load(object sender, EventArgs e)
        {
            data();
        }
        private void data()
        {
            XDocument xmlDocument = XDocument.Load("../../references/soon.xml");
            string jsonText = System.IO.File.ReadAllText("../../references/soon.json");
            JObject jsonObject = JObject.Parse(jsonText);
            DisplaysoonInTable(xmlDocument);
        }
        private void DisplaysoonInTable(XDocument xmlDocument)
        {
            soonGridView1.Rows.Clear();

            foreach (var elemtoday in xmlDocument.Root.Elements("soon"))
            {
                string id = elemtoday.Element("ID")?.Value ?? "N/A";
                string name = elemtoday.Element("name")?.Value ?? "N/A";
                string actors = elemtoday.Element("actors")?.Value ?? "N/A";
                string premier = elemtoday.Element("premier")?.Value ?? "N/A";
                soonGridView1.Rows.Add(id, name, actors, premier);
            }
        }
        private void DisplaySoonSingleInfo(string seltitle)
        {
            JObject jsonObj = JObject.Parse(System.IO.File.ReadAllText("../../references/soon.json"));
            JToken selfilm = jsonObj["soon"].FirstOrDefault(f => f["name"].ToString() == seltitle);

            if (selfilm != null) 
            {

                idtext.Text = selfilm["ID"].ToString();
                nametext.Text = selfilm["name"].ToString();
                actorstext.Text = selfilm["actors"].ToString();
                premiertext.Text = selfilm["premier"].ToString();
            }
        }
        private void reset()
        {
            soonGridView1.Visible = true;
            soonInfolabel.Visible = false;
            soonIDlabel.Visible = false;
            namelabel.Visible = false;
            actorslabel1.Visible = false;
            premierlabel.Visible = false;
            idtext.Visible = false;
            nametext.Visible = false;
            actorstext.Visible = false;
            premiertext.Visible = false;
            soonOKbtn.Visible = false;
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void soonGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < soonGridView1.Rows.Count)
            {
                soonGridView1.Visible = false;
                infolabel.Visible = true;
                IDlabel.Visible = true;
                todaynamelabel.Visible = true;
                actorslabel.Visible = true;
                datelabel.Visible = true;
                idtext.Visible = true;
                nametext.Visible = true;
                actorstext.Visible = true;
                premiertext.Visible = true;
                okbtn.Visible = true;
                DataGridViewRow selrow = soonGridView1.Rows[e.RowIndex];
                string seltitle = selrow.Cells["FilmName"].Value.ToString();
                DisplaySoonSingleInfo(seltitle);
            }
        }
    }
}