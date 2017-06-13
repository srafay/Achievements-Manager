namespace Achievements
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.achievementType = new System.Windows.Forms.CheckedListBox();
            this.membersName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.suspectsNames = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Members Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Achievement type :";
            // 
            // achievementType
            // 
            this.achievementType.CheckOnClick = true;
            this.achievementType.FormattingEnabled = true;
            this.achievementType.Items.AddRange(new object[] {
            "Chainsaw",
            "Sniper",
            "Bomb",
            "Drag Most Wanted",
            "Helicopter Drag"});
            this.achievementType.Location = new System.Drawing.Point(138, 57);
            this.achievementType.Name = "achievementType";
            this.achievementType.Size = new System.Drawing.Size(195, 79);
            this.achievementType.TabIndex = 2;
            // 
            // membersName
            // 
            this.membersName.Location = new System.Drawing.Point(138, 10);
            this.membersName.Name = "membersName";
            this.membersName.Size = new System.Drawing.Size(195, 20);
            this.membersName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Suspect\'s name(s) :";
            // 
            // suspectsNames
            // 
            this.suspectsNames.Location = new System.Drawing.Point(138, 165);
            this.suspectsNames.Name = "suspectsNames";
            this.suspectsNames.Size = new System.Drawing.Size(195, 246);
            this.suspectsNames.TabIndex = 5;
            this.suspectsNames.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Check and Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 559);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.suspectsNames);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.membersName);
            this.Controls.Add(this.achievementType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox achievementType;
        private System.Windows.Forms.TextBox membersName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox suspectsNames;
        private System.Windows.Forms.Button button1;
    }
}

