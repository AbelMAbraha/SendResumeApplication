using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendCV
{
    public partial class Form1 : Form
    {
        string cvFile = "";
        string body = "";
        public Form1()
        {
            InitializeComponent();
            ListObjects list = new ListObjects();
            dropdownOccupations.DataSource = list.ListOfOccupations();
        }
        public void cv_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            DialogResult dr = OFD.ShowDialog();
            cvLabel.Text = OFD.SafeFileName;
            cvFile = OFD.FileName;
        }

        private void coverLetter_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            DialogResult dr = OFD.ShowDialog();
            coverLetterLabel.Text = OFD.FileName;
        }

        private void sendCV_Click(object sender, EventArgs e)
        {
            if (coverLetterLabel.Text == "")
            {

            }
            else
            {
                RichTextBox rtBox = new RichTextBox();
                string content = System.IO.File.ReadAllText(coverLetterLabel.Text);
                rtBox.Rtf = content;
                body = rtBox.Text;
            }

            foreach (DataGridViewRow dgrv in dataGridView1.Rows)
            {
                string companyEmail = dgrv.Cells["companyEmail"].Value.ToString();
                string occupation = dgrv.Cells["occupation"].Value.ToString().ToLower();
                string companyName = dgrv.Cells["companyName"].Value.ToString();
                MailMessageInformation mmi = new MailMessageInformation(emailAccount.Text, companyEmail, occupation, companyName, emailPassword.Text, cvFile, subjectEmail.Text, body);
            }
        }

        private void registerCompInfo_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(compEmail.Text, subjectEmail.Text, dropdownOccupations.Text, compName.Text);
            compName.Text = "";
            compEmail.Text = "";
            subjectEmail.Text = "";
        }
    }
}
