using Xceed.Document.NET;
using Xceed.Words.NET;

namespace CoverLetterFormatter
{
    public partial class Form1 : Form
    {
        protected DocX? template;

        string company = "";
        string jobTitleStr = "";
        string? outputFileName;
        DateTime availabilityDate;
        static Dictionary<string, string>? _replacePatterns;
        string dateTimeStr = "";
        private string city = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void baseFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string fileName = baseFile.FileName;
            if (File.Exists(fileName))
            {
                template = DocX.Load(fileName);
            }
            templateName.Text = fileName;
        }

        private void templateName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baseFile.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            saveFileDialog1.FileName = updateFileName();
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            outputFileName = saveFileDialog1.FileName;
        }

        private string updateFileName()
        {
            outputFileName = $"Ethan Green Cover Letter for {jobTitleStr} at {company}";
            return outputFileName;
        }

        private void companyName_TextChanged(object sender, EventArgs e)
        {
            company = companyName.Text;
            updateFileName();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            availabilityDate = dateTimePicker1.Value;
            if (checkBox1.Checked)
            {
                dateTimeStr = $"{availabilityDate.ToShortDateString()} (if my presence will be required onsite)";
            }
            else if (!checkBox1.Checked)
            {
                dateTimeStr = availabilityDate.ToShortDateString();
            }
        }



        private void createReplacementDictionary()
        {
            _replacePatterns = new Dictionary<string, string>()
            {
                {"Position Here", jobTitleStr},
                {"Availability Date", dateTimeStr },
                {"Company Name", company },
                {"Metro Area", city }
            };
        }

        private bool replaceContents()
        {
            var functionReplaceTextOptions = new FunctionReplaceTextOptions()
            {
                FindPattern = "<(.*?)>",
                RegexMatchHandler = Form1.ReplaceTextHandler,
                RegExOptions = System.Text.RegularExpressions.RegexOptions.IgnoreCase
            };
            template.ReplaceText(functionReplaceTextOptions);
            template.SaveAs(saveFileDialog1.FileName);
            return false;
        }
        #region Private Methods

        private static string ReplaceTextHandler(string findStr)
        {
            if (_replacePatterns.ContainsKey(findStr))
            {
                return _replacePatterns[findStr];
            }
            return findStr;
        }

        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (availabilityDate != null && checkBox1.Checked)
            {
                dateTimeStr = $"{availabilityDate.ToShortDateString()} (if my presence is required onsite)";
            }
            else if (!checkBox1.Checked)
            {
                dateTimeStr = availabilityDate.ToShortDateString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            city = cityNameBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createReplacementDictionary();
            replaceContents();
        }

        private void jobTitle_TextChanged(object sender, EventArgs e)
        {
            jobTitleStr = jobTitle.Text;
            updateFileName();
        }

        
    }
}