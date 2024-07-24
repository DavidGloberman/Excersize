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
            { "�����", "���� ����" },
            { "���", "���� ����" },
            { "�����", "������ ����" },
            { "�����", "������ ����" },
            { "�����", "������ ����" },
            { "���", "���� ����" }
        };

        Dictionary<int, string> daysOfMonth = new Dictionary<int, string>()
        {
            { 1, "��� ���" },
            { 2, "��� ����" },
            { 3, "���� ����" },
            { 4, "����� ����" },
            { 5, "���� ����" },
            { 6, "��� ����" },
            { 7, "���� ����" },
            { 8, "���� ����" },
            { 9, "���� ����" },
            { 10, "���� ����" },
            { 11, "��� ��� ���" },
            { 12, "���� ��� ���" },
            { 13, "���� ��� ���" },
            { 14, "����� ��� ���" },
            { 15, "���� ��� ���" },
            { 16, "��� ��� ���" },
            { 17, "���� ��� ���" },
            { 18, "���� ��� ���" },
            { 19, "���� ��� ���" },
            { 20, "����� ���" },
            { 21, "��� ������ ���" },
            { 22, "���� ������ ���" },
            { 23, "���� ������ ���" },
            { 24, "����� ������ ���" },
            { 25, "���� ������ ���" },
            { 26, "��� ������ ���" },
            { 27, "���� ������ ���" },
            { 28, "���� ������ ���" },
            { 29, "���� ������ ���" },
            { 30, "��� ������" }
        };

        Dictionary<string, string> Month = new Dictionary<string, string>()
        {
            { "����", "���� ����" },
            { "������", "���� ������" },
            { "����", "���� ����" },
            { "���", "���� ���" },
            { "���", "���� ���" },
            { "���", "���� ���" },
            { "��� ������", "���� ��� ������" },
            { "��� ����", "���� ��� ����" },
            { "����", "���� ����" },
            { "����", "���� ����" },
            { "����", "���� ����" },
            { "����", "���� ����" },
            { "��", "���� ��" },
            { "����", "���� ����" }
        };

        Dictionary<string, string> RoshCHodesh = new Dictionary<string, string>()
        {
            { "����", "������" },
            { "������", "����" },
            { "����", "���" },
            { "���", "���" },
            { "��� ������", "��� ����" },
            { "����", "����" },
            { "����", "����" },
            { "��", "����" },
        };

        Dictionary<string, string> Years = new Dictionary<string, string>()
        {
            { "���''�", "��� ���� ����� ���� ���� ������ ����� ������ �����" },
            { "���''�", "��� ���� ����� ���� ���� ������ ���� ������ �����" },
            { "���''�", "��� ���� ����� ���� ���� ������ ��� ������ �����" },
            { "���''�", "��� ���� ����� ���� ���� ������ ���� ������ �����" },
            { "���''�", "��� ���� ����� ���� ���� ������ ����� ������ �����" },
            { "���''�", "��� ���� ����� ���� ���� ������ ���� ������ �����" },
            { "��''�", "��� ���� ����� ���� ���� ������ ������ �����" },
            { "���''�", "��� ���� ����� ���� ���� ������ ���� ������ �����" },
            { "���''�", "��� ���� ����� ���� ���� ������ ����� ������ �����" },
            { "���''�", "��� ���� ����� ���� ���� ������ ����� ������ �����" }
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
                    MessageBox.Show($"��� ��� ������ ����� {strMonth}");
                    return;
                }
                rusult = $"{day} {dayMonth} {month} ���� ��� ���� {roshCHodesh} {year}";
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
