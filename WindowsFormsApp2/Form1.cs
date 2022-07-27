using Microsoft.VisualStudio.TestPlatform.Utilities.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            var user = new CustomerQuestionnaires();
            user.Name = this.nameTextBox.Text;
            user.Surname = this.surnameTextBox.Text;
            user.Age = this.AgeTextBox.Text;
            user.FriendQuest = question1;
            user.WorryQuest = question2;
            user.SatisfiedQuest = question3;
            user.AffraidQuest = question4;
            user.AttentionQues = question5;
            user.RightWrongQuest = question6;
            user.ComfortabilityQuest = question7;
            user.CustomerComment = this.richTextBox1.Text;
            FileHelper.WriteFile(user);
            this.Close();

        }
        string question1 = string.Empty;
        string question2 = string.Empty;
        string question3 = string.Empty;
        string question4 = string.Empty;
        string question5 = string.Empty;
        string question6 = string.Empty;
        string question7 = string.Empty;



        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox2.Controls.Count; i++)
            {
                if (groupBox2.Controls[i] is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        if (i == 0)
                        {
                            question1 = "Low";
                        }
                        else if (i == 1)
                        {
                            question1 = "Normal";
                        }
                        else if (i == 2)
                        {
                            question1 = "High";
                        }
                    }
                }
            }
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox3.Controls.Count; i++)
            {
                if (groupBox3.Controls[i] is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        if (i == 0)
                        {
                            question2 = "Low";
                        }
                        else if (i == 1)
                        {
                            question2 = "Normal";

                        }
                        else if (i == 2)
                        {
                            question2 = "High";

                        }
                    }
                }
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox4.Controls.Count; i++)
            {
                if (groupBox4.Controls[i] is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        if (i == 0)
                        {
                            question3 = "Low";
                        }
                        else if (i == 1)
                        {
                            question3 = "Normal";
                        }
                        else if (i == 2)
                        {
                            question3 = "High";
                        }
                    }
                }
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox5.Controls.Count; i++)
            {
                if (groupBox5.Controls[i] is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        if (i == 0)
                        {
                            question4 = "Low";
                        }
                        else if (i == 1)
                        {
                            question4 = "Normal";
                        }
                        else if (i == 2)
                        {
                            question4 = "High";
                        }
                    }
                }
            }
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox6.Controls.Count; i++)
            {
                if (groupBox6.Controls[i] is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        if (i == 0)
                        {
                            question5 = "Low";
                        }
                        else if (i == 1)
                        {
                            question5 = "Normal";
                        }
                        else if (i == 2)
                        {
                            question5 = "High";
                        }
                    }
                }
            }
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox7.Controls.Count; i++)
            {
                if (groupBox7.Controls[i] is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        if (i == 0)
                        {
                            question6 = "Low";
                        }
                        else if (i == 1)
                        {
                            question6 = "Normal";
                        }
                        else if (i == 2)
                        {
                            question6 = "High";
                        }
                    }
                }
            }
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox8.Controls.Count; i++)
            {
                if (groupBox8.Controls[i] is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        if (i == 0)
                        {
                            question7 = "Low";
                        }
                        else if (i == 1)
                        {
                            question7 = "Normal";
                        }
                        else if (i == 2)
                        {
                            question7 = "High";
                        }
                    }
                }
            }
        }
    }
}
