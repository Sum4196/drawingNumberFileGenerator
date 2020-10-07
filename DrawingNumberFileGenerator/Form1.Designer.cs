namespace DrawingNumberFileGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.removeSiteProject = new System.Windows.Forms.CheckBox();
            this.siteNumber = new System.Windows.Forms.ComboBox();
            this.areaNumberDropdown = new System.Windows.Forms.ComboBox();
            this.projectNumber = new System.Windows.Forms.TextBox();
            this.disciplineLetters = new System.Windows.Forms.ComboBox();
            this.startSequenceNumber = new System.Windows.Forms.TextBox();
            this.endSequenceNumber = new System.Windows.Forms.TextBox();
            this.vendorEngineerName = new System.Windows.Forms.TextBox();
            this.siteNumberLabel = new System.Windows.Forms.Label();
            this.projectNumberLabel = new System.Windows.Forms.Label();
            this.areaNumberLabel = new System.Windows.Forms.Label();
            this.disciplineLettersLabel = new System.Windows.Forms.Label();
            this.startSequenceNumberLabel = new System.Windows.Forms.Label();
            this.endSequenceNumberLabel = new System.Windows.Forms.Label();
            this.vendorEngineerLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // removeSiteProject
            // 
            this.removeSiteProject.AutoSize = true;
            this.removeSiteProject.Location = new System.Drawing.Point(168, 16);
            this.removeSiteProject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeSiteProject.Name = "removeSiteProject";
            this.removeSiteProject.Size = new System.Drawing.Size(176, 22);
            this.removeSiteProject.TabIndex = 0;
            this.removeSiteProject.Text = "Remove Site + Project";
            this.removeSiteProject.UseVisualStyleBackColor = true;
            this.removeSiteProject.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // siteNumber
            // 
            this.siteNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.siteNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.siteNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siteNumber.ItemHeight = 18;
            this.siteNumber.Items.AddRange(new object[] {
            "70",
            "71"});
            this.siteNumber.Location = new System.Drawing.Point(168, 48);
            this.siteNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siteNumber.Name = "siteNumber";
            this.siteNumber.Size = new System.Drawing.Size(196, 26);
            this.siteNumber.TabIndex = 1;
            this.siteNumber.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // areaNumberDropdown
            // 
            this.areaNumberDropdown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.areaNumberDropdown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.areaNumberDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.areaNumberDropdown.FormattingEnabled = true;
            this.areaNumberDropdown.Items.AddRange(new object[] {
            "008",
            "010",
            "011",
            "012",
            "013",
            "014",
            "015",
            "016",
            "017",
            "018",
            "020",
            "021",
            "022",
            "023",
            "024",
            "025",
            "026",
            "027",
            "028",
            "029",
            "032",
            "034",
            "035",
            "037",
            "038",
            "039",
            "040",
            "041",
            "042",
            "043",
            "067",
            "068",
            "069",
            "075",
            "079",
            "080",
            "083",
            "085",
            "086",
            "088",
            "089",
            "134",
            "139",
            "234",
            "239",
            "301",
            "410",
            "413",
            "437",
            "438",
            "439"});
            this.areaNumberDropdown.Location = new System.Drawing.Point(168, 124);
            this.areaNumberDropdown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.areaNumberDropdown.Name = "areaNumberDropdown";
            this.areaNumberDropdown.Size = new System.Drawing.Size(196, 26);
            this.areaNumberDropdown.TabIndex = 3;
            this.areaNumberDropdown.SelectedIndexChanged += new System.EventHandler(this.AreaNumberDropdown_SelectedIndexChanged);
            // 
            // projectNumber
            // 
            this.projectNumber.Location = new System.Drawing.Point(168, 88);
            this.projectNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.projectNumber.Name = "projectNumber";
            this.projectNumber.Size = new System.Drawing.Size(196, 24);
            this.projectNumber.TabIndex = 2;
            this.projectNumber.TextChanged += new System.EventHandler(this.ProjectNumber_TextChanged);
            // 
            // disciplineLetters
            // 
            this.disciplineLetters.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.disciplineLetters.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.disciplineLetters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disciplineLetters.FormattingEnabled = true;
            this.disciplineLetters.Items.AddRange(new object[] {
            "AA",
            "AB",
            "AC",
            "AD",
            "AE",
            "AF",
            "AG",
            "AH",
            "AI",
            "AJ",
            "AK",
            "AL",
            "AM",
            "AN",
            "AO",
            "AP",
            "AQ",
            "AR",
            "AS",
            "AT",
            "AU",
            "AV",
            "AW",
            "AX",
            "AY",
            "AZ",
            "CA",
            "CB",
            "CC",
            "CD",
            "CE",
            "CF",
            "CG",
            "CH",
            "CI",
            "CJ",
            "CK",
            "CL",
            "CM",
            "CN",
            "CO",
            "CP",
            "CQ",
            "CR",
            "CS",
            "CT",
            "CU",
            "CV",
            "CW",
            "CX",
            "CY",
            "CZ",
            "EA",
            "EB",
            "EC",
            "ED",
            "EE",
            "EF",
            "EG",
            "EH",
            "EI",
            "EJ",
            "EK",
            "EL",
            "EM",
            "EO",
            "EP",
            "EQ",
            "ER",
            "ES",
            "ET",
            "EU",
            "EV",
            "EW",
            "EX",
            "EY",
            "EZ",
            "GA",
            "GB",
            "GC",
            "GD",
            "GE",
            "GF",
            "GG",
            "GH",
            "GI",
            "GJ",
            "GK",
            "GL",
            "GM",
            "GN",
            "GO",
            "GP",
            "GQ",
            "GR",
            "GS",
            "GT",
            "GU",
            "GV",
            "GW",
            "GX",
            "GY",
            "GZ",
            "HA",
            "HB",
            "HC",
            "HD",
            "HE",
            "HF",
            "HG",
            "HH",
            "HI",
            "HJ",
            "HK",
            "HL",
            "HM",
            "HN",
            "HO",
            "HP",
            "HQ",
            "HR",
            "HS",
            "HT",
            "HU",
            "HV",
            "HW",
            "HX",
            "HY",
            "HZ",
            "IA",
            "IB",
            "IC",
            "ID",
            "IE",
            "IF",
            "IG",
            "IH",
            "II",
            "IJ",
            "IK",
            "IL",
            "IM",
            "IN",
            "IO",
            "IP",
            "IQ",
            "IR",
            "IS",
            "IT",
            "IU",
            "IV",
            "IW",
            "IX",
            "IY",
            "IZ",
            "KA",
            "KB",
            "KC",
            "KD",
            "KE",
            "KF",
            "KG",
            "KH",
            "KI",
            "KJ",
            "KK",
            "KL",
            "KM",
            "KN",
            "KO",
            "KP",
            "KQ",
            "KR",
            "KS",
            "KT",
            "KU",
            "KV",
            "KW",
            "KX",
            "KY",
            "KZ",
            "LA",
            "LB",
            "LC",
            "LD",
            "LE",
            "LF",
            "LG",
            "LH",
            "LI",
            "LJ",
            "LK",
            "LL",
            "LM",
            "LN",
            "LO",
            "LP",
            "LQ",
            "LR",
            "LS",
            "LT",
            "LU",
            "LV",
            "LW",
            "LX",
            "LY",
            "LZ",
            "MA",
            "MB",
            "MC",
            "MD",
            "ME",
            "MF",
            "MG",
            "MH",
            "MI",
            "MJ",
            "MK",
            "ML",
            "MM",
            "MN",
            "MO",
            "MP",
            "MQ",
            "MR",
            "MS",
            "MT",
            "MU",
            "MV",
            "MW",
            "MX",
            "MY",
            "MZ",
            "SA",
            "SB",
            "SC",
            "SD",
            "SE",
            "SF",
            "SG",
            "SH",
            "SI",
            "SJ",
            "SK",
            "SL",
            "SM",
            "SN",
            "SO",
            "SP",
            "SQ",
            "SR",
            "SS",
            "ST",
            "SU",
            "SV",
            "SW",
            "SX",
            "SY",
            "SZ",
            "VA",
            "VB",
            "VC",
            "VD",
            "VE",
            "VF",
            "VG",
            "VH",
            "VI",
            "VJ",
            "VK",
            "VL",
            "VM",
            "VO",
            "VP",
            "VQ",
            "VR",
            "VS",
            "VT",
            "VU",
            "VV",
            "VW",
            "VX",
            "VY",
            "VZ",
            "XA",
            "XB",
            "XC",
            "XD",
            "XE",
            "XF",
            "XG",
            "XH",
            "XI",
            "XJ",
            "XK",
            "XL",
            "XM",
            "XN",
            "XO",
            "XP",
            "XQ",
            "XR",
            "XS",
            "XT",
            "XU",
            "XV",
            "XW",
            "XX",
            "XY",
            "XZ"});
            this.disciplineLetters.Location = new System.Drawing.Point(168, 160);
            this.disciplineLetters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.disciplineLetters.Name = "disciplineLetters";
            this.disciplineLetters.Size = new System.Drawing.Size(196, 26);
            this.disciplineLetters.TabIndex = 4;
            this.disciplineLetters.SelectedIndexChanged += new System.EventHandler(this.DisciplineLetters_SelectedIndexChanged);
            // 
            // startSequenceNumber
            // 
            this.startSequenceNumber.Location = new System.Drawing.Point(168, 198);
            this.startSequenceNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startSequenceNumber.Name = "startSequenceNumber";
            this.startSequenceNumber.Size = new System.Drawing.Size(196, 24);
            this.startSequenceNumber.TabIndex = 5;
            this.startSequenceNumber.TextChanged += new System.EventHandler(this.StartSequenceNumber_TextChanged);
            // 
            // endSequenceNumber
            // 
            this.endSequenceNumber.Location = new System.Drawing.Point(168, 234);
            this.endSequenceNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endSequenceNumber.Name = "endSequenceNumber";
            this.endSequenceNumber.Size = new System.Drawing.Size(196, 24);
            this.endSequenceNumber.TabIndex = 6;
            this.endSequenceNumber.TextChanged += new System.EventHandler(this.EndSequenceNumber_TextChanged);
            // 
            // vendorEngineerName
            // 
            this.vendorEngineerName.Location = new System.Drawing.Point(168, 270);
            this.vendorEngineerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vendorEngineerName.Name = "vendorEngineerName";
            this.vendorEngineerName.Size = new System.Drawing.Size(196, 24);
            this.vendorEngineerName.TabIndex = 7;
            this.vendorEngineerName.TextChanged += new System.EventHandler(this.VendorEngineerName_TextChanged);
            // 
            // siteNumberLabel
            // 
            this.siteNumberLabel.AutoSize = true;
            this.siteNumberLabel.Location = new System.Drawing.Point(102, 60);
            this.siteNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.siteNumberLabel.Name = "siteNumberLabel";
            this.siteNumberLabel.Size = new System.Drawing.Size(49, 18);
            this.siteNumberLabel.TabIndex = 8;
            this.siteNumberLabel.Text = "Site #:";
            // 
            // projectNumberLabel
            // 
            this.projectNumberLabel.AutoSize = true;
            this.projectNumberLabel.Location = new System.Drawing.Point(80, 97);
            this.projectNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectNumberLabel.Name = "projectNumberLabel";
            this.projectNumberLabel.Size = new System.Drawing.Size(71, 18);
            this.projectNumberLabel.TabIndex = 9;
            this.projectNumberLabel.Text = "Project #:";
            // 
            // areaNumberLabel
            // 
            this.areaNumberLabel.AutoSize = true;
            this.areaNumberLabel.Location = new System.Drawing.Point(96, 134);
            this.areaNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.areaNumberLabel.Name = "areaNumberLabel";
            this.areaNumberLabel.Size = new System.Drawing.Size(54, 18);
            this.areaNumberLabel.TabIndex = 10;
            this.areaNumberLabel.Text = "Area #:";
            // 
            // disciplineLettersLabel
            // 
            this.disciplineLettersLabel.AutoSize = true;
            this.disciplineLettersLabel.Location = new System.Drawing.Point(24, 172);
            this.disciplineLettersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.disciplineLettersLabel.Name = "disciplineLettersLabel";
            this.disciplineLettersLabel.Size = new System.Drawing.Size(124, 18);
            this.disciplineLettersLabel.TabIndex = 11;
            this.disciplineLettersLabel.Text = "Discipline Letters:";
            // 
            // startSequenceNumberLabel
            // 
            this.startSequenceNumberLabel.AutoSize = true;
            this.startSequenceNumberLabel.Location = new System.Drawing.Point(18, 208);
            this.startSequenceNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startSequenceNumberLabel.Name = "startSequenceNumberLabel";
            this.startSequenceNumberLabel.Size = new System.Drawing.Size(125, 18);
            this.startSequenceNumberLabel.TabIndex = 12;
            this.startSequenceNumberLabel.Text = "Start Sequence #:";
            // 
            // endSequenceNumberLabel
            // 
            this.endSequenceNumberLabel.AutoSize = true;
            this.endSequenceNumberLabel.Location = new System.Drawing.Point(22, 244);
            this.endSequenceNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endSequenceNumberLabel.Name = "endSequenceNumberLabel";
            this.endSequenceNumberLabel.Size = new System.Drawing.Size(120, 18);
            this.endSequenceNumberLabel.TabIndex = 13;
            this.endSequenceNumberLabel.Text = "End Sequence #:";
            // 
            // vendorEngineerLabel
            // 
            this.vendorEngineerLabel.AutoSize = true;
            this.vendorEngineerLabel.Location = new System.Drawing.Point(22, 280);
            this.vendorEngineerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vendorEngineerLabel.Name = "vendorEngineerLabel";
            this.vendorEngineerLabel.Size = new System.Drawing.Size(121, 18);
            this.vendorEngineerLabel.TabIndex = 14;
            this.vendorEngineerLabel.Text = "Vendor/Engineer:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(28, 322);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(130, 32);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 322);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clear All Fields";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(28, 386);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(338, 32);
            this.progressBar1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(398, 448);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.vendorEngineerLabel);
            this.Controls.Add(this.endSequenceNumberLabel);
            this.Controls.Add(this.startSequenceNumberLabel);
            this.Controls.Add(this.disciplineLettersLabel);
            this.Controls.Add(this.areaNumberLabel);
            this.Controls.Add(this.projectNumberLabel);
            this.Controls.Add(this.siteNumberLabel);
            this.Controls.Add(this.vendorEngineerName);
            this.Controls.Add(this.endSequenceNumber);
            this.Controls.Add(this.startSequenceNumber);
            this.Controls.Add(this.disciplineLetters);
            this.Controls.Add(this.projectNumber);
            this.Controls.Add(this.areaNumberDropdown);
            this.Controls.Add(this.siteNumber);
            this.Controls.Add(this.removeSiteProject);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drawing Number File Generator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox removeSiteProject;
        private System.Windows.Forms.ComboBox siteNumber;
        private System.Windows.Forms.ComboBox areaNumberDropdown;
        private System.Windows.Forms.TextBox projectNumber;
        private System.Windows.Forms.ComboBox disciplineLetters;
        private System.Windows.Forms.TextBox startSequenceNumber;
        private System.Windows.Forms.TextBox endSequenceNumber;
        private System.Windows.Forms.TextBox vendorEngineerName;
        private System.Windows.Forms.Label siteNumberLabel;
        private System.Windows.Forms.Label projectNumberLabel;
        private System.Windows.Forms.Label areaNumberLabel;
        private System.Windows.Forms.Label disciplineLettersLabel;
        private System.Windows.Forms.Label startSequenceNumberLabel;
        private System.Windows.Forms.Label endSequenceNumberLabel;
        private System.Windows.Forms.Label vendorEngineerLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

