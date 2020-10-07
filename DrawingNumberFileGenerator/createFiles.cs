using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DrawingNumberFileGenerator
{
    public class CreateFilesGenerator
    {
        public static void createFiles(Boolean removeSiteProject, String siteNumber, String projectNumber, String areaNumber, String discLetters, int seqStartNumber, int seqEndNumber, String vendorText, ProgressBar pBar1)
        {
            int seqLength = seqEndNumber - seqStartNumber;
            //System.Diagnostics.Debug.WriteLine("\nSequence Length: " + seqLength);

            //String currentDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            //System.Diagnostics.Debug.WriteLine(currentDirectory);

            //Check whether to remove site&project number or not
            if (removeSiteProject == true)
            {
                if (areaNumber != "" && discLetters != "" && vendorText != "")
                {
                    //run/create files
                    var saveDirectory = new FolderBrowserDialog();
                    DialogResult result = saveDirectory.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string folderName = saveDirectory.SelectedPath;

                        pBar1.Visible = true;
                        pBar1.Minimum = 0;
                        pBar1.Maximum = seqLength + 1;
                        pBar1.Value = 1;
                        pBar1.Step = 1;

                        //build filename
                        for (int i = 0; i < seqLength + 1; i++)
                        {
                            String seqNumber = seqStartNumber.ToString().PadLeft(4, '0');
                            String currentFilename = areaNumber + discLetters + seqNumber + '.' + vendorText;
                            //System.Diagnostics.Debug.WriteLine("\ncurFilename: " + currentFilename + "\n");

                            FileStream fs = File.Create(folderName + "/" + currentFilename);
                            fs.Close();

                            seqStartNumber++;
                            pBar1.PerformStep();
                        }

                        pBar1.Value = 0;
                        MessageBox.Show("Files have been created!");

                    }

                }
                else
                {
                    //give user an error
                    MessageBox.Show("Please fill in all fields.");
                }
            }
            else
            {
                //Remove Site+Project is unchecked
                if (siteNumber != "" && projectNumber != "" && areaNumber != "" && discLetters != "" && vendorText != "")
                {
                    //run/create files
                    var saveDirectory = new FolderBrowserDialog();
                    DialogResult result = saveDirectory.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string folderName = saveDirectory.SelectedPath;

                        pBar1.Visible = true;
                        pBar1.Minimum = 0;
                        pBar1.Maximum = seqLength + 1;
                        pBar1.Value = 1;
                        pBar1.Step = 1;

                        //build filename
                        for (int i = 0; i < seqLength + 1; i++)
                        {
                            String seqNumber = seqStartNumber.ToString().PadLeft(4, '0');
                            String currentFilename = siteNumber + projectNumber + areaNumber + discLetters + seqNumber + '.' + vendorText;
                            //System.Diagnostics.Debug.WriteLine("\ncurFilename: " + currentFilename + "\n");

                            FileStream fs = File.Create(folderName + "/" + currentFilename);
                            fs.Close();

                            seqStartNumber++;
                            pBar1.PerformStep();
                        }

                        pBar1.Value = 0;
                        MessageBox.Show("Files have been created!");
                    }
                    else
                    {
                        //give user an error
                        MessageBox.Show("Please fill in all fields.");
                    }

                }

                return;

            }
        }
    }
}