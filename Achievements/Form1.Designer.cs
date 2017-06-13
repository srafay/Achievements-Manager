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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.achievementType = new System.Windows.Forms.CheckedListBox();
            this.membersName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.suspectsNames = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.codeLink = new System.Windows.Forms.LinkLabel();
            this.profileLink = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.infoChainsaw = new System.Windows.Forms.Label();
            this.infoSniper = new System.Windows.Forms.Label();
            this.infoBomb = new System.Windows.Forms.Label();
            this.infoMWDrags = new System.Windows.Forms.Label();
            this.infoHeli = new System.Windows.Forms.Label();
            this.chainsawCount = new System.Windows.Forms.Label();
            this.sniperCount = new System.Windows.Forms.Label();
            this.bombCount = new System.Windows.Forms.Label();
            this.MWCount = new System.Windows.Forms.Label();
            this.heliCount = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.achievementsPanel = new System.Windows.Forms.Panel();
            this.achievementsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
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
            this.membersName.Location = new System.Drawing.Point(138, 12);
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
            this.button1.Location = new System.Drawing.Point(173, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 67);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add and Validate achievements";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // codeLink
            // 
            this.codeLink.AutoSize = true;
            this.codeLink.Location = new System.Drawing.Point(578, 514);
            this.codeLink.Name = "codeLink";
            this.codeLink.Size = new System.Drawing.Size(132, 13);
            this.codeLink.TabIndex = 20;
            this.codeLink.TabStop = true;
            this.codeLink.Text = "Click to view Source Code";
            this.codeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.codeLink_LinkClicked);
            // 
            // profileLink
            // 
            this.profileLink.AutoSize = true;
            this.profileLink.LinkColor = System.Drawing.Color.Black;
            this.profileLink.Location = new System.Drawing.Point(572, 537);
            this.profileLink.Name = "profileLink";
            this.profileLink.Size = new System.Drawing.Size(146, 13);
            this.profileLink.TabIndex = 21;
            this.profileLink.TabStop = true;
            this.profileLink.Text = "Developed By: [Lsrcr]Wajeeh";
            this.profileLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Member Achievements ";
            // 
            // infoChainsaw
            // 
            this.infoChainsaw.AutoSize = true;
            this.infoChainsaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoChainsaw.Location = new System.Drawing.Point(40, 44);
            this.infoChainsaw.Name = "infoChainsaw";
            this.infoChainsaw.Size = new System.Drawing.Size(98, 16);
            this.infoChainsaw.TabIndex = 8;
            this.infoChainsaw.Text = "Chainsaw kills :";
            // 
            // infoSniper
            // 
            this.infoSniper.AutoSize = true;
            this.infoSniper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoSniper.Location = new System.Drawing.Point(40, 77);
            this.infoSniper.Name = "infoSniper";
            this.infoSniper.Size = new System.Drawing.Size(79, 16);
            this.infoSniper.TabIndex = 9;
            this.infoSniper.Text = "Sniper kills :";
            // 
            // infoBomb
            // 
            this.infoBomb.AutoSize = true;
            this.infoBomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBomb.Location = new System.Drawing.Point(40, 109);
            this.infoBomb.Name = "infoBomb";
            this.infoBomb.Size = new System.Drawing.Size(76, 16);
            this.infoBomb.TabIndex = 10;
            this.infoBomb.Text = "Bomb kills :";
            // 
            // infoMWDrags
            // 
            this.infoMWDrags.AutoSize = true;
            this.infoMWDrags.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoMWDrags.Location = new System.Drawing.Point(40, 139);
            this.infoMWDrags.Name = "infoMWDrags";
            this.infoMWDrags.Size = new System.Drawing.Size(133, 16);
            this.infoMWDrags.TabIndex = 11;
            this.infoMWDrags.Text = "Most Wanted Drags :";
            // 
            // infoHeli
            // 
            this.infoHeli.AutoSize = true;
            this.infoHeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoHeli.Location = new System.Drawing.Point(40, 169);
            this.infoHeli.Name = "infoHeli";
            this.infoHeli.Size = new System.Drawing.Size(78, 16);
            this.infoHeli.TabIndex = 12;
            this.infoHeli.Text = "Heli Drags :";
            // 
            // chainsawCount
            // 
            this.chainsawCount.AutoSize = true;
            this.chainsawCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chainsawCount.Location = new System.Drawing.Point(136, 44);
            this.chainsawCount.Name = "chainsawCount";
            this.chainsawCount.Size = new System.Drawing.Size(16, 16);
            this.chainsawCount.TabIndex = 13;
            this.chainsawCount.Text = "0";
            // 
            // sniperCount
            // 
            this.sniperCount.AutoSize = true;
            this.sniperCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sniperCount.Location = new System.Drawing.Point(117, 77);
            this.sniperCount.Name = "sniperCount";
            this.sniperCount.Size = new System.Drawing.Size(16, 16);
            this.sniperCount.TabIndex = 14;
            this.sniperCount.Text = "0";
            // 
            // bombCount
            // 
            this.bombCount.AutoSize = true;
            this.bombCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bombCount.Location = new System.Drawing.Point(113, 109);
            this.bombCount.Name = "bombCount";
            this.bombCount.Size = new System.Drawing.Size(16, 16);
            this.bombCount.TabIndex = 15;
            this.bombCount.Text = "0";
            // 
            // MWCount
            // 
            this.MWCount.AutoSize = true;
            this.MWCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MWCount.Location = new System.Drawing.Point(171, 140);
            this.MWCount.Name = "MWCount";
            this.MWCount.Size = new System.Drawing.Size(16, 16);
            this.MWCount.TabIndex = 16;
            this.MWCount.Text = "0";
            // 
            // heliCount
            // 
            this.heliCount.AutoSize = true;
            this.heliCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heliCount.Location = new System.Drawing.Point(116, 170);
            this.heliCount.Name = "heliCount";
            this.heliCount.Size = new System.Drawing.Size(16, 16);
            this.heliCount.TabIndex = 17;
            this.heliCount.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(511, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 62);
            this.button2.TabIndex = 18;
            this.button2.Text = "Display Achievements";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // achievementsPanel
            // 
            this.achievementsPanel.Controls.Add(this.heliCount);
            this.achievementsPanel.Controls.Add(this.MWCount);
            this.achievementsPanel.Controls.Add(this.bombCount);
            this.achievementsPanel.Controls.Add(this.sniperCount);
            this.achievementsPanel.Controls.Add(this.chainsawCount);
            this.achievementsPanel.Controls.Add(this.infoHeli);
            this.achievementsPanel.Controls.Add(this.infoMWDrags);
            this.achievementsPanel.Controls.Add(this.infoBomb);
            this.achievementsPanel.Controls.Add(this.infoSniper);
            this.achievementsPanel.Controls.Add(this.infoChainsaw);
            this.achievementsPanel.Controls.Add(this.label4);
            this.achievementsPanel.Location = new System.Drawing.Point(455, 42);
            this.achievementsPanel.Name = "achievementsPanel";
            this.achievementsPanel.Size = new System.Drawing.Size(225, 196);
            this.achievementsPanel.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(730, 559);
            this.Controls.Add(this.achievementsPanel);
            this.Controls.Add(this.profileLink);
            this.Controls.Add(this.codeLink);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.suspectsNames);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.membersName);
            this.Controls.Add(this.achievementType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.achievementsPanel.ResumeLayout(false);
            this.achievementsPanel.PerformLayout();
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
        private System.Windows.Forms.LinkLabel codeLink;
        private System.Windows.Forms.LinkLabel profileLink;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label infoChainsaw;
        private System.Windows.Forms.Label infoSniper;
        private System.Windows.Forms.Label infoBomb;
        private System.Windows.Forms.Label infoMWDrags;
        private System.Windows.Forms.Label infoHeli;
        private System.Windows.Forms.Label chainsawCount;
        private System.Windows.Forms.Label sniperCount;
        private System.Windows.Forms.Label bombCount;
        private System.Windows.Forms.Label MWCount;
        private System.Windows.Forms.Label heliCount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel achievementsPanel;
    }
}

