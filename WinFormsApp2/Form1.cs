using System.Xml.Linq;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private Dictionary<string,float> _rates = new Dictionary<string,float>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument api = XDocument.Load("https://api.nbp.pl/api/exchangerates/tables/a/?format=xml");
          
            var rates = api.Descendants("Rate");
            //clear slownika
            _rates.Clear();
            debugTextBox.Text = rates.ToString();
            //pars api
            foreach (var rate in rates) 
            {
                if (rate.Element("Code") != null && rate.Element("Mid") != null)
                {
                    // skrot nazwyy z api
                    string code = rate.Element("Code").Value;
                    //kurs waluty i konwert na float
                    float mid = float.Parse(rate.Element("Mid").Value, System.Globalization.CultureInfo.InvariantCulture);
                    //dodaj do slownika kurs waluty
                    _rates.Add(code, mid);
                }


            }
            // kursy walut
            USDTextBot.Text = _rates["USD"].ToString();
            EURTextBot.Text = _rates["USD"].ToString();
            CHFTextBot.Text = _rates["USD"].ToString();
        }

        private void radioUSD_CheckedChanged(object sender, EventArgs e)
        {

        }

        //wymiana waluty
        private void Exchange(object sender, EventArgs e)

        {
            string currency = (sender as RadioButton).Text;
            float ammountPLN = float.Parse(ammountplntextbox.Text, System.Globalization.CultureInfo.InvariantCulture);
            
            {
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}