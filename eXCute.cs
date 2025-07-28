using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace eXCute
{
    public partial class eXCute : Form
    {
        public string setWMPlocation
        {
            get { return this.cBset_MPFile.Text; }
            set { this.setWMPlocation = cBset_MPFile.Text; }
        }

        public eXCute()
        {
            InitializeComponent();
            //keine Bilslaufleiste;
            /*int myLeft = Properties.Settings.Default.locationLeft;
            int myTop = Properties.Settings.Default.locationTop;
            MessageBox.Show("" + myLeft + " " + myTop);
            this.Location = new Point (myLeft, myTop);
            this.Refresh();*/
            //Load Form Settings
            this.BackColor = Properties.Settings.Default.frmNeBCol;
            this.ForeColor = Properties.Settings.Default.frmNeFCol;
            this.Size = Properties.Settings.Default.frmNewSize;

            this.Location = Properties.Settings.Default.Loc;
            this.Opacity = Properties.Settings.Default.FrmOpac;
            this.BackColor = Properties.Settings.Default.DefaultBCol;
            //this.FormBorderStyle = FormBorderStyle.None;
            //immer im Vordergrund;
            this.TopMost = true;
            this.Refresh();


            /*
             * Combobox Links  startPath START >>>
             * **/
            //Start Bedingungen prüfen und Combo Box mit Properties füllen
            try
            {
                //string mynewPath = Properties.Settings.Default.newPath;
                //check the startpath isnt empty
                if ((Properties.Settings.Default.linkPath == "") || (Properties.Settings.Default.linkPath == " ") || (Properties.Settings.Default.linkPath == null))
                {
                    //if startpath is empty take the default path (C:\)
                    string[] startpath = Directory.GetFiles(Properties.Settings.Default.deflinksPath);
                    cBlinkPath.Items.AddRange(startpath);
                }
                else
                {

                    //If the start path isnt empty take the startpath.
                    string[] startPath = Directory.GetFiles(Properties.Settings.Default.linkPath);
                    //string[] links = Directory.GetFiles("C:\\develop\\xcute\\links\\");
                    cBlinkPath.Items.AddRange(startPath);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("" + x);
            }

            /*
             * Combobox Links STOP <<<
             *========================
             * Combobox WMP Path startWMP_Path START >>>
             * **/
            try
            {
                //string mynewPath = Properties.Settings.Default.newPath;
                //check the startpath isnt empty
                if ((Properties.Settings.Default.startWMP_Path == "") || (Properties.Settings.Default.startWMP_Path == " ") || (Properties.Settings.Default.startWMP_Path == null))
                {
                    //if startpath is empty take the default path (C:\)
                    string[] startpath = Directory.GetFiles(Properties.Settings.Default.defWMP_Path);
                    cBset_MPFile.Items.AddRange(startpath);
                    //listBox1.Items.AddRange(startpath);
                }
                else
                {

                    //If the start path isnt empty take the startpath.
                    string[] startPath = Directory.GetFiles(Properties.Settings.Default.startWMP_Path);
                    //string[] links = Directory.GetFiles("C:\\develop\\xcute\\links\\");
                    cBset_MPFile.Items.AddRange(startPath);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("" + x);
            }


        }


        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                WMP frmInfo = new WMP(setWMPlocation);
                frmInfo.Show();
            }
            catch (Exception x)
            {
                MessageBox.Show("" + x);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ActiveForm.Opacity = .99;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ActiveForm.Opacity = .75;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ActiveForm.Opacity = .55;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ActiveForm.Opacity = .25;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ActiveForm.Opacity = .15;
        }

        private void execute_Click(object sender, EventArgs e)
        {
            try
            {

                Process proc = new Process();
                proc.StartInfo.FileName = doit.Text;
                proc.Start();
                //proc.WaitForExit();
                Form leer = new Form();
                leer.Close();
                //MessageBox.Show("Ausgeführt");
            }

            catch (Exception x)
            {
                MessageBox.Show("" + x);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //string star = comboBox1.Text;
                Process proc = new Process();
                //textBox1.Text = star;
                proc.StartInfo.FileName = cBlinkPath.Text;
                proc.Start();
                //proc.WaitForExit();
                Form leer = new Form();
                leer.Close();
                //MessageBox.Show("Ausgeführt");         
                this.Refresh();
            }
            catch (Exception x)
            {
                MessageBox.Show("" + x);
            }
        }

        private void kill_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("" + x);
            }
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            string xval = toolStripComboBox1.Text.ToString();
            string yval = toolStripComboBox2.Text.ToString();
            int XVal = Convert.ToInt16(xval);
            int YVal = Convert.ToInt16(yval);
            this.Location = new Point(XVal, YVal);
            this.Refresh();
            //write new Values into Settings            
            
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            string xval = toolStripComboBox1.Text.ToString();
            string yval = toolStripComboBox2.Text.ToString();
            int XVal = Convert.ToInt16(xval);
            int YVal = Convert.ToInt16(yval);
            this.Location = new Point(XVal, YVal);
            this.Refresh();
        }

        private void eXCute_Closing(object sender, FormClosingEventArgs e)
        {
            
            
            try
            {
                Properties.Settings.Default.Loc = this.Location;
                Properties.Settings.Default.FrmOpac = this.Opacity;
                if ((tbnewPAth.Text == null) || (tbsetLinkPath == null))
                {
                    Properties.Settings.Default.linkPath = Properties.Settings.Default.deflinksPath;
                    Properties.Settings.Default.startPath = Properties.Settings.Default.defaultPath;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.linkPath = tbsetLinkPath.Text;
                    Properties.Settings.Default.startPath = Properties.Settings.Default.newPath;
                    Properties.Settings.Default.frmNeFCol = this.ForeColor;
                    Properties.Settings.Default.frmNeBCol = this.BackColor;
                    Properties.Settings.Default.frmNewSize = this.Size;
                }
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void tbnewPAth_Click(object sender, EventArgs e)
        {
            tbnewPAth.KeyDown += new KeyEventHandler(tbnewPAth_KeyDown);
        }

        private void tbnewPath_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        if ((tbnewPAth.Text == " ") || (tbnewPAth.Text == "") || (tbnewPAth.Text == null))
                        {
                            MessageBox.Show("Sie haben keinen Pfad eingegeben! \n Der Default Pfad wird eingesetzt werden\n!");
                            Properties.Settings.Default.newPath = Properties.Settings.Default.defaultPath;
                            Properties.Settings.Default.startPath = Properties.Settings.Default.defaultPath;
                            Properties.Settings.Default.Save();
                            MessageBox.Show("Gespeichert:\n" + Properties.Settings.Default.newPath.ToString());

                        }
                        else
                        {
                            string path = this.tbnewPAth.Text;
                            Properties.Settings.Default.newPath = path;
                            Properties.Settings.Default.startPath = Properties.Settings.Default.newPath;
                            Properties.Settings.Default.Save();
                            MessageBox.Show("Gespeichert\n" + Properties.Settings.Default.newPath.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }

        }

        public KeyEventHandler tbnewPAth_KeyDown { get; set; }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ColorDialog Select_Color = new ColorDialog();
            colorDialog1.ShowDialog();
            MessageBox.Show("Farbe " + colorDialog1.Color.ToString() + "gewählt");
            this.BackColor = colorDialog1.Color;
            Properties.Settings.Default.frmNeBCol = this.BackColor;
            Properties.Settings.Default.Save();

            
        }

        private void selectForeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            MessageBox.Show("Farbe " + colorDialog1.Color.ToString() + "gewählt");
            this.ForeColor = colorDialog1.Color;
            Properties.Settings.Default.frmNeFCol = this.ForeColor;
            Properties.Settings.Default.Save();
            
        }

        private void widthSelect_Click(object sender, EventArgs e)
        {
            string strWidth= widthSelect.Text.ToString();
            int myWidth = Convert.ToInt32(strWidth);
            this.Width = myWidth;
            string strHeight = heightSelect.Text.ToString();
            int myHeight = Convert.ToInt32(strHeight);
            //this.Height += heightSelect.Height;
            this.Size = new Size(myWidth, myHeight);
        }

        private void heightSelect_Click(object sender, EventArgs e)
        {
            string strWidth = widthSelect.Text.ToString();
            int myWidth = Convert.ToInt32(strWidth);
            this.Width = myWidth;
            string strHeight = heightSelect.Text.ToString();
            int myHeight = Convert.ToInt32(strHeight);
            //this.Height += heightSelect.Height;

        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle == System.Windows.Forms.FormBorderStyle.None)
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
            else
            {
                MessageBox.Show("Wurde bereits eingeschaltet");
            }

        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle == System.Windows.Forms.FormBorderStyle.Sizable)
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
            else
            {
                MessageBox.Show("Wurde bereits ausgeschaltet");
            }
        }

        private void doit_TextChanged(object sender, EventArgs e)
        {
            doit.KeyDown += new KeyEventHandler(doit_KeyDown); 
           
        }

         private void doit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    Process proc = new Process();
                    proc.StartInfo.FileName = doit.Text;
                    proc.Start();
                    //proc.WaitForExit();
                    Form leer = new Form();
                    leer.Close();
                    //MessageBox.Show("Ausgeführt");
                    this.Refresh();
                }

                catch (Exception x)
                {
                    MessageBox.Show("" + x);
                }
            }
        }

         private void tbsetMusicP_Click(object sender, EventArgs e)
         {
             tbsetMusicP.KeyDown += new KeyEventHandler(tbsetMusic_KeyDown);
         }

         private void tbsetMusicP_KeyDown(object sender, KeyEventArgs e)
         {
              if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
               
             
                        if ((tbsetMusicP.Text == " ") || (tbsetMusicP.Text == "") || (tbsetMusicP.Text == null))
                        {
                            MessageBox.Show("Sie haben keinen Pfad eingegeben! \n Der Default Pfad wird eingesetzt werden\n!");
                            Properties.Settings.Default.currMPDrive = Properties.Settings.Default.defMPDrive;
                            Properties.Settings.Default.defWMP_Path = Properties.Settings.Default.defWMP_Path;
                            Properties.Settings.Default.currMPFile =Properties.Settings.Default.defMPFileName;
                            Properties.Settings.Default.currWMP_Path = Properties.Settings.Default.defWMP_Path;

                            Properties.Settings.Default.Save();
                            MessageBox.Show("Gespeichert:\n" + Properties.Settings.Default.defWMP_Path.ToString());

                        }
                        else
                        {
                            string path = this.tbsetMusicP.Text;
                            Properties.Settings.Default.currWMP_Path = path;
                            Properties.Settings.Default.startWMP_Path = Properties.Settings.Default.currWMP_Path;
                            Properties.Settings.Default.Save();
                            MessageBox.Show("Gespeichert\n" + Properties.Settings.Default.startWMP_Path.ToString());
                        }
                        this.Refresh();

                        //Access on frmInfo
                        string setInfWMPLocation = tbsetMusicP.Text.ToString();
                        
                        
                    }
                    
                    
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
              
         }

         public KeyEventHandler tbsetMusic_KeyDown { get; set; }
        
 
         public void cBset_MPFile_KDown(object sender, KeyEventArgs e)
         {
             if (e.KeyCode == Keys.Enter)
             {
                 try
                 {
                     //this.setWMPlocation = cBset_MPFile.Text.ToString();
                     MessageBox.Show("gespeichert " + setWMPlocation);
                     Properties.Settings.Default.fileMPpath = cBset_MPFile.Text;
                     Properties.Settings.Default.Save();
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("" + ex);
                 }
             }

         }

         private void tbsetLinkPath_Click(object sender, EventArgs e)
         {
            tbsetLinkPath.KeyDown += new KeyEventHandler(tbsetLinkPath_KeyDown);
         }

         public void tbsetLinkPath_KeyDown(object sender, KeyEventArgs e)
         {
            
             if (e.KeyCode == Keys.Enter)
             {
                 try
                 {
                     if ((tbsetLinkPath.Text == " ") || (tbsetLinkPath.Text == "") || (tbsetLinkPath.Text == null))
                     {
                         Properties.Settings.Default.linkPath = Properties.Settings.Default.deflinksPath;
                         Properties.Settings.Default.Save();
                         MessageBox.Show("Sie haben keinen Pfad eingegeben! \n Der Default Pfad wird eingesetzt werden\n!");
                     }
                     else
                     {
                         Properties.Settings.Default.linkPath = tbsetLinkPath.Text;
                         Properties.Settings.Default.Save();
                         MessageBox.Show("gespeichert: \n" + tbsetLinkPath.Text);
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(""+ex);
                 }
             }
         
         }

         //public KeyEventHandler tbsetLinkPath_KeyDown { get; set; }
    }
}
