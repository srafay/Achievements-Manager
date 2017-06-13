﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Achievements
{
    public partial class Form1 : Form
    {
        public int numberOfLinesInFile(string fileName)
        {
            var lineCount = 0;
            using (var reader = File.OpenText(fileName))
            {
                string line;
                while ((line=reader.ReadLine()) != null)
                {
                    if (line.Length != 0)
                        lineCount++;
                }
            }
            return lineCount;
        }

        public Form1()
        {
            InitializeComponent();
            this.Text = "SWAT Achievements Manager v1.0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = "";

            if (membersName.TextLength == 0)
                MessageBox.Show("Please enter the members name in the field", "ERROR!!",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                fileName = membersName.Text;

                if (achievementType.CheckedIndices.Count == 0)
                    MessageBox.Show("Please select the achievement type for the user", "ERROR!!",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (achievementType.CheckedIndices.Count > 1)
                        MessageBox.Show("You can only select one achievement at a time", "ERROR!!",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (suspectsNames.Lines.Length == 0)
                                MessageBox.Show("Please enter the suspect names in the text box below", "ERROR! SUSPECTS NAME LIST IS EMPTY",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if (achievementType.GetItemCheckState(0) == CheckState.Checked)
                                fileName += @"\Chainsaw.txt";
                            else if (achievementType.GetItemCheckState(1) == CheckState.Checked)
                                fileName += @"\Sniper.txt";
                            else if (achievementType.GetItemCheckState(2) == CheckState.Checked)
                                fileName += @"\Bomb.txt";
                            else if (achievementType.GetItemCheckState(3) == CheckState.Checked)
                                fileName += @"\DragMW.txt";
                            else if (achievementType.GetItemCheckState(4) == CheckState.Checked)
                                fileName += @"\HeliDrag.txt";

                            if (!File.Exists(fileName))
                            {
                                string buffer = "";
                                int numOfLines = suspectsNames.Lines.Length;
                                FileInfo file = new FileInfo(fileName);
                                file.Directory.Create(); // If the directory already exists, this method does nothing.
                                for (int i = 0; i < numOfLines; ++i)
                                {
                                    buffer += suspectsNames.Lines[i];
                                    buffer += Environment.NewLine;
                                }
                                File.WriteAllText(fileName, buffer);
                                MessageBox.Show("Created a new file '" + fileName + "' and added the following names to it : " +
                                    Environment.NewLine + buffer, "Succesfully created a new file!");
                            }
                            else
                            {
                                string lines = "", toAppend = "", repeated = "";
                                int suspectsInFile = 0;
                                using (StreamReader sr = new StreamReader(fileName))
                                {
                                    string temp;
                                    // Read and display lines from the file until 
                                    // the end of the file is reached. 
                                    while ((temp = sr.ReadLine()) != null)
                                    {
                                        lines += temp;
                                        lines += Environment.NewLine;
                                        ++suspectsInFile;
                                    }
                                }
                                string[] newLines = lines.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                                int numOfSuspects = suspectsNames.Lines.Count();
                                bool found = false;

                                for (int i = 0; i < numOfSuspects; ++i)
                                {
                                    for (int j = 0; j < suspectsInFile; ++j)
                                    {
                                        if (suspectsNames.Lines[i].ToLower() == newLines[j].ToLower())
                                            found = true;
                                    }
                                    if (!found)
                                    {
                                        // will be added to the file
                                        toAppend += suspectsNames.Lines[i];
                                        toAppend += Environment.NewLine;
                                    }
                                    else
                                    {
                                        // they will be discarded
                                        repeated += suspectsNames.Lines[i];
                                        if (i+1 != numOfSuspects)
                                            repeated += Environment.NewLine;
                                    }

                                    found = false;          // Reset found
                                }

                                File.AppendAllText(fileName, toAppend);

                                string message = "";

                                if (toAppend.Length != 0)
                                    message = "Following names are added to the file succesfully : " +
                                        Environment.NewLine + toAppend + Environment.NewLine;

                                if (repeated.Length != 0)
                                {
                                    message += "Following names are repeated and are not added to the file : ";
                                            message = message + Environment.NewLine + repeated;
                                }

                                suspectsNames.Text = repeated;

                                    MessageBox.Show(message, "File updated",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool info = false;

            if (membersName.TextLength == 0)
                MessageBox.Show("Please enter the name of the SWAT Member if you want to check his achievements", "ERROR!!",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string fileName = membersName.Text;

                if (File.Exists(fileName + @"\Chainsaw.txt"))
                {
                    int lineCount = numberOfLinesInFile(fileName + @"\Chainsaw.txt");
                    chainsawCount.Text = lineCount.ToString();
                    info = true;
                }

                if (File.Exists(fileName + @"\Sniper.txt"))
                {
                    int lineCount = numberOfLinesInFile(fileName + @"\Sniper.txt");
                    sniperCount.Text = lineCount.ToString();
                    info = true;
                }

                if (File.Exists(fileName + @"\Bomb.txt"))
                {
                    int lineCount = numberOfLinesInFile(fileName + @"\Bomb.txt");
                    bombCount.Text = lineCount.ToString();
                    info = true;
                }

                if (File.Exists(fileName + @"\DragMW.txt"))
                {
                    int lineCount = numberOfLinesInFile(fileName + @"\DragMW.txt");
                    MWCount.Text = lineCount.ToString();
                    info = true;
                }

                if (File.Exists(fileName + @"\HeliDrag.txt"))
                {
                    int lineCount = numberOfLinesInFile(fileName + @"\HeliDrag.txt");
                    heliCount.Text = lineCount.ToString();
                    info = true;
                }

                if (info)
                    MessageBox.Show("All the information has been updated", "UPDATED SUCCESSFULLY");
                else
                    MessageBox.Show("No information found for user : '" + fileName + "'. Please provide valid files for this user"
                        + " OR ask the developer if you are unaware of the usage of this software", "Something's not right",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void codeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/srafay/Achievements-Manager");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ls-rcr.com/forum/memberlist.php?mode=viewprofile&u=18265");
        }

    }
}
