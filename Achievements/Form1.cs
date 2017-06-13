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
                MessageBox.Show("Please enter the members name in the field", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                fileName = membersName.Text;

                if (achievementType.CheckedIndices.Count == 0)
                    MessageBox.Show("Please select the achievement type for the user", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (achievementType.CheckedIndices.Count > 1)
                        MessageBox.Show("You can only select one achievement at a time", "Error",
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
                                if (i + 1 != numOfLines)
                                    buffer += Environment.NewLine;
                            }
                            File.WriteAllText(fileName, buffer);
                        }
                        else
                        {

                        }
                    }
                }
            }
        }
    }
}
