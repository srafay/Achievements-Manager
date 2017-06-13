using System;
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
                                        if (suspectsNames.Lines[i] == newLines[j])
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
                                        repeated += Environment.NewLine;
                                    }

                                    found = false;          // Reset found
                                }

                                File.AppendAllText(fileName, toAppend);
                                MessageBox.Show("Following names are repeated and are discarded : " + Environment.NewLine +
                                    repeated, "File updated");
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
