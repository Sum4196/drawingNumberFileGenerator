using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingNumberFileGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Remove Site + Project checkbox
            if(removeSiteProject.Checked == true)
            {
                siteNumber.Enabled = false;
                projectNumber.Enabled = false;
            } else
            {
                siteNumber.Enabled = true;
                projectNumber.Enabled = true;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Site # dropdown
        }

        private void ProjectNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AreaNumberDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DisciplineLetters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartSequenceNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void EndSequenceNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void VendorEngineerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Submit Button
            CreateFilesGenerator.createFiles(removeSiteProject.Checked, siteNumber.Text, projectNumber.Text, areaNumberDropdown.Text, disciplineLetters.Text, Convert.ToInt32(startSequenceNumber.Text), Convert.ToInt32(endSequenceNumber.Text), vendorEngineerName.Text, progressBar1);

            //System.Diagnostics.Debug.WriteLine("Submit button was pressed.");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Clear Fields Button
            siteNumber.SelectedIndex = -1;
            projectNumber.Text = "";
            areaNumberDropdown.SelectedIndex = -1;
            disciplineLetters.SelectedIndex = -1;
            startSequenceNumber.Text = "";
            endSequenceNumber.Text = "";
            vendorEngineerName.Text = "";
        }

    }
}
