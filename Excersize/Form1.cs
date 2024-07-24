using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Excersize
{
    public partial class Form1 : Form
    {
        public string Path = "Date.xml";
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, string> daysOfWeek = new Dictionary<string, string>()
        {
            { "ראשון", "באחד בשבת" },
            { "שני", "בשני בשבת" },
            { "שלישי", "בשלישי בשבת" },
            { "רביעי", "ברביעי בשבת" },
            { "חמישי", "בחמישי בשבת" },
            { "ששי", "בששי בשבת" }
        };

        Dictionary<int, string> daysOfMonth = new Dictionary<int, string>()
        {
            { 1, "יום אחד" },
            { 2, "שני ימים" },
            { 3, "שלשה ימים" },
            { 4, "ארבעה ימים" },
            { 5, "חמשה ימים" },
            { 6, "ששה ימים" },
            { 7, "שבעה ימים" },
            { 8, "שמנה ימים" },
            { 9, "תשעה ימים" },
            { 10, "עשרה ימים" },
            { 11, "אחד עשר יום" },
            { 12, "שנים עשר יום" },
            { 13, "שלשה עשר יום" },
            { 14, "ארבעה עשר יום" },
            { 15, "חמשה עשר יום" },
            { 16, "ששה עשר יום" },
            { 17, "שבעה עשר יום" },
            { 18, "שמנה עשר יום" },
            { 19, "תשעה עשר יום" },
            { 20, "עשרים יום" },
            { 21, "אחד ועשרים יום" },
            { 22, "שנים ועשרים יום" },
            { 23, "שלשה ועשרים יום" },
            { 24, "ארבעה ועשרים יום" },
            { 25, "חמשה ועשרים יום" },
            { 26, "ששה ועשרים יום" },
            { 27, "שבעה ועשרים יום" },
            { 28, "שמנה ועשרים יום" },
            { 29, "תשעה ועשרים יום" },
            { 30, "יום שלושים" }
        };

        Dictionary<string, string> Month = new Dictionary<string, string>()
        {
            { "תשרי", "לירח תשרי" },
            { "מרחשון", "לירח מרחשון" },
            { "כסלו", "לירח כסלו" },
            { "טבת", "לירח טבת" },
            { "שבט", "לירח שבט" },
            { "אדר", "לירח אדר" },
            { "אדר הראשון", "לירח אדר הראשון" },
            { "אדר השני", "לירח אדר השני" },
            { "ניסן", "לירח ניסן" },
            { "אייר", "לירח אייר" },
            { "סיון", "לירח סיון" },
            { "תמוז", "לירח תמוז" },
            { "אב", "לירח אב" },
            { "אלול", "לירח אלול" }
        };

        Dictionary<string, string> RoshCHodesh = new Dictionary<string, string>()
        {
            { "תשרי", "מרחשון" },
            { "מרחשון", "כסלו" },
            { "כסלו", "טבת" },
            { "שבט", "אדר" },
            { "אדר הראשון", "אדר השני" },
            { "ניסן", "אייר" },
            { "סיון", "תמוז" },
            { "אב", "אלול" },
        };

        Dictionary<string, string> Years = new Dictionary<string, string>()
        {
            { "תשפ''ד", "שנת חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם" },
            { "תשפ''ה", "שנת חמשת אלפים ושבע מאות ושמנים וחמש לבריאת העולם" },
            { "תשפ''ו", "שנת חמשת אלפים ושבע מאות ושמנים ושש לבריאת העולם" },
            { "תשפ''ז", "שנת חמשת אלפים ושבע מאות ושמנים ושבע לבריאת העולם" },
            { "תשפ''ח", "שנת חמשת אלפים ושבע מאות ושמנים ושמנה לבריאת העולם" },
            { "תשפ''ט", "שנת חמשת אלפים ושבע מאות ושמנים ותשע לבריאת העולם" },
            { "תש''צ", "שנת חמשת אלפים ושבע מאות ותשעים לבריאת העולם" },
            { "תשצ''א", "שנת חמשת אלפים ושבע מאות ותשעים ואחת לבריאת העולם" },
            { "תשצ''ב", "שנת חמשת אלפים ושבע מאות ותשעים ושתים לבריאת העולם" },
            { "תשצ''ג", "שנת חמשת אלפים ושבע מאות ותשעים ושלוש לבריאת העולם" }
        };
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_Month.Text == "" || comboBox_daysOfWeek.Text == "" || comboBox_daysOfMonth.Text == "" || comboBox_Years.Text =="")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            string strDaysOfWeek = comboBox_daysOfWeek.Text;
            int intDaysOfMonth = int.Parse(comboBox_daysOfMonth.Text);
            string strMonth = comboBox_Month.Text;
            string strYears = comboBox_Years.Text;


            daysOfWeek.TryGetValue(strDaysOfWeek, out string day);
            daysOfMonth.TryGetValue(intDaysOfMonth, out string dayMonth);
            Month.TryGetValue(strMonth, out string month);
            Years.TryGetValue(strYears, out string year);

            string rusult;
            if (intDaysOfMonth == 30)
            {
                if (!RoshCHodesh.TryGetValue(strMonth, out string roshCHodesh))
                {
                    MessageBox.Show($"אין יום שלושים בחודש {strMonth}");
                    return;
                }
                rusult = $"{day} {dayMonth} {month} שהוא ראש חודש {roshCHodesh} {year}";
            }
            else
            {
                rusult = $"{day} {dayMonth} {month} {year}";
            }


            textBox_reslut.Text = rusult;

            XDocument doc = XDocument.Load(Path);
            XElement Query =
                new("Query",
                    new XElement("Day", strDaysOfWeek),
                    new XElement("DayMonth", intDaysOfMonth),
                    new XElement("Month", strMonth),
                    new XElement("Year", strYears),
                    new XElement("Result", rusult)
                );

            doc.Root.Add(Query);
            doc.Save(Path);
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            comboBox_daysOfMonth.Text = string.Empty;
            comboBox_daysOfWeek.Text = string.Empty;
            comboBox_Years.Text = string.Empty;
            comboBox_Month.Text = string.Empty;
            textBox_reslut.Text = string.Empty;
        }
    }
}
