using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Media;
using System.Runtime.InteropServices;
using System.IO;
using WMPLib;
using AxWMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using eXCute.Properties;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace eXCute
{
    public partial class WMP : Form
    {
        /*public WMP()
        {
            // TODO: Complete member initialization
        }*/
        //WMPLib.WindowsMediaPlayer axWindowsMediaPlayer1 = new WindowsMediaPlayer();




        public WMP(string setWMPlocation)
        {
            InitializeComponent();
            //string path = "develop\\xcute\\music";
            //string filename = "";
            //AxInterop.WMPLib.dll

            //** START MEDIAPLAYER INSTANCE **/
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();


            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            // this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(705, 425);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.OpenPlaylistSwitch += new AxWMPLib._WMPOCXEvents_OpenPlaylistSwitchEventHandler(this.axWindowsMediaPlayer1_OpenPlaylistSwitch);
            // 
            // WMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 425);
            this.Controls.Add(this.cBPlaylist);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chkLooping);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pictureBox1);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WMP";
            this.Text = "WMP";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sel_List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();

            //** END MEDIAPLAYER INSTANCE **/

            string localpath = Properties.Settings.Default.fileMPpath;
            string lcldrive = Properties.Settings.Default.currMPDrive;
            string newWMPlocation = setWMPlocation;
            //comboBox füllen
            string[] playpath = Directory.GetFiles(localpath);
            cBPlaylist.Items.AddRange(playpath);

            //ListBox1 Fill START
            try
            {
                //string mynewPath = Properties.Settings.Default.newPath;
                //check the startpath isnt empty

                string[] startpath = Directory.GetFiles(Properties.Settings.Default.fileMPpath);
                //cBset_MPFile.Items.AddRange(startpath);
                listBox1.Items.AddRange(startpath);
                listBox1.Update();
                listBox1.Refresh();

                if ((Properties.Settings.Default.startWMP_Path == "") || (Properties.Settings.Default.startWMP_Path == " ") || (Properties.Settings.Default.startWMP_Path == null))
                {
                    //if startpath is empty take the default path (C:\)
                    MessageBox.Show("Paths 'Default startWMP are empty, verify Settings Paths!");

                }
                else
                {
                    if ((Properties.Settings.Default.fileMPpath == "") || (Properties.Settings.Default.fileMPpath == " ") || (Properties.Settings.Default.fileMPpath == null))
                    {
                        MessageBox.Show("Paths 'Default fileMPpath are empty, verify Settings Paths!");
                    }
                }
                MessageBox.Show(localpath);

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }



        //listBox1 FILL END


        //localpath = (lcldrive+":\\" + path + "\\");
        //localpath = ("C:"+ filename);
        //loop file


        /**
         * Verschiedene Optionen
         * **/
        //AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        //axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
        //axWindowsMediaPlayer1.settings.setMode("loop", true);
        //play this file 

        //MessageBox.Show(""+newWMPlocation);
        //defaultPath;

        //axWindowsMediaPlayer1.URL = newWMPlocation;

        /* //Changing 26.09.2024
        using (OpenFileDialog openFileDlg3 = new OpenFileDialog())
        {
            //openFileDialog1.Multiselect = true;
            openFileDlg3.Multiselect = true;
            openFileDialog1.Multiselect = true;
            //openFileDlg.Multiselect = true;
            openFileDlg3.InitialDirectory = localpath;
            openFileDlg3.Filter = "All Files | *.*";

            string[] mylist;
            string mypath;
            //listBox1.Items.AddRange(mylist);

            mylist = openFileDlg3.SafeFileNames;
            mypath = Directory.GetCurrentDirectory();

            string[] ComboToList = Directory.GetFiles(localpath);
            for (int i = listBox1.Items.Count; i < mylist.Length; i++)
            {
                if (listBox1.Items != null)
                {

                    listBox1.Items.Add(mylist[i]);
                    listBox1.Refresh();
                }
                else
                {

                    listBox1.Items.Add(mylist[i]);
                    listBox1.Refresh();
                }

            }
            try
            {

                //axWindowsMediaPlayer1.URL = path[listBox1.SelectedIndex];
                axWindowsMediaPlayer1.URL = openFileDlg3.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }


        try
        {
            //string mynewPath = Properties.Settings.Default.newPath;
            //check the startpath isnt empty
            if ((localpath == "") || (localpath == " ") || (localpath == null))
            {
                //if startpath is empty take the default path (C:\)
                MessageBox.Show("Der angegebene Pfad ist leer");
            }
            else
            {


                /*listBox loading on Form_Load
                string[] mylist = Directory.GetFiles(localpath);
                listBox1.Items.AddRange(mylist);
                */
        //;axWindowsMediaPlayer1.settings.setMode("loop", true)


        //    axWindowsMediaPlayer1.uiMode = "Full";


        /*DEBUG PArt Übermittlung
        foreach (var item in cBPlaylist.Items)
        {
            //axWindowsMediaPlayer1.settings.setMode("shuffle", true);
            string mysong = Convert.ToString(item);
            axWindowsMediaPlayer1.URL = mysong;


        }

    }
}

catch (Exception ex)
{
    MessageBox.Show("" + ex);
}*/




        /*DEBUG Check if file is persistant
        try
        // If the Player encounters a corrupt or missing file, 
        // show the hexadecimal error code and URL.
        {
            IWMPMedia2 errSource = e.pMediaObject as IWMPMedia2;
            IWMPErrorItem errorItem = errSource.Error;
            MessageBox.Show("Error " + errorItem.errorCode.ToString("X")
                            + " in " + errSource.sourceURL);
        }
        catch (InvalidCastException)
        // In case pMediaObject is not an IWMPMedia item.
        {
            MessageBox.Show("Error.");
        } */
        //axWindowsMediaPlayer1.currentPlaylist = axWindowsMediaPlayer1.mediaCollection.getByName("mediafile");




        public string[] files, path;


        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //public System.String uiMode { get; set; }
        //public IWMPSettings settings { get; }

        public object media { get; set; }

        public void cBPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FitListBox();
            path = openFileDialog1.FileNames;
            //ShowDialog();
            string playFile;
            playFile = cBPlaylist.SelectedItem.ToString();
            axWindowsMediaPlayer1.URL = playFile;
            //playFile = openFileDialog1.FileName;
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listB_check();


        }
        //Fill ListBox by Menu ToolStrip & by Button openDialog
        List<string> filteredFiles = new List<string>();
        FolderBrowserDialog browser = new FolderBrowserDialog();
        int currentFile = 0;

        private void LoadFolderEvent(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            /*if(filteredFiles.Count > 1)
            {
                filteredFiles.Clear();
                filteredFiles = null;
                listBox1.Items.Clear();
                currentFile = 0;
            }
            DialogResult result = browser.ShowDialog();

            if(result == DialogResult.OK)
            {
                filteredFiles = Directory.GetFiles(browser.SelectedPath, "*.*").Where(
                    file => file.ToLower().EndsWith("webm") || 
                file.ToLower().EndsWith("mp4") || 
                file.ToLower().EndsWith("wmv") || 
                file.ToLower().EndsWith("mkv") || 
                file.ToLower().EndsWith("avi")).ToList();

                LoadPlayList();

            }*/
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter for file types and the default filter
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 2; // Default to "All Files"
            openFileDialog.Title = "Select a Text File";

            // Show the dialog and check if the user clicked "OK"
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of the selected file
                string selectedFilePath = openFileDialog.FileName;

                // Do something with the file, like reading its content
                //MessageBox.Show("File selected: " + selectedFilePath);
                // string fileContent = File.ReadAllText(selectedFilePath);
                PlayFile(selectedFilePath);
                //LoadPlayList();
            }


        }

        private void LoadPlayList()
        {
            axWindowsMediaPlayer1.currentPlaylist = axWindowsMediaPlayer1.newPlaylist("Playlist", "");

            foreach (string video in filteredFiles)
            {
                axWindowsMediaPlayer1.currentPlaylist.appendItem(axWindowsMediaPlayer1.newMedia(video));
                listBox1.Items.Add(video);
            }
            if (filteredFiles.Count > 0)
            {
                lblfileName.Name = "Files Found" + filteredFiles.Count;
                listBox1.SelectedIndex = currentFile;
                PlayFile(listBox1.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("no video Files found in this folder");
            }
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            timer1.Stop();
        }



        private void PlayFile(string url)
        {
            axWindowsMediaPlayer1.URL = url;
        }

        private void ShowFileName(Label name)
        {
            string file = Path.GetFileName(listBox1.SelectedItem.ToString());
            name.Text = "Currently Playing: " + file;
        }


        private void FitListBox(string wplFilePath)
        {
            try
            {
                // WPL-Datei als XML-Dokument laden
                XDocument wplDocument = XDocument.Load(wplFilePath);

                // Alle 'media'-Elemente finden und deren 'src'-Attribut auslesen
                var mediaPaths = wplDocument.Descendants("media")
                                            .Select(media => media.Attribute("src")?.Value)
                                            .Where(src => !string.IsNullOrEmpty(src)); // Leere Einträge ignorieren

                // ListBox vor dem Füllen leeren
                listBox1.Items.Clear();

                // Jeden gefundenen Pfad zur ListBox hinzufügen
                foreach (var path in mediaPaths)
                {
                    listBox1.Items.Add(path);
                   // MessageBox.Show(path);
                }
                listBox1.Refresh();
            }
            catch (Exception ex)
            {
                // Fehler behandeln, falls die Datei nicht gelesen werden kann
                MessageBox.Show("Fehler beim Laden der Playlist: " + ex.Message);
            }
        }
    

        // Beispiel: Button-Klick, um den OpenFileDialog zu starten
        private void BtnOpenPlaylist_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Windows Playlist (*.wpl)|*.wpl|All files (*.*)|*.*";
            openFileDialog.Title = "Wähle eine Playlist";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Die Methode mit dem ausgewählten Dateipfad aufrufen
                FitListBox(openFileDialog.FileName);
            }
        }

        /*try
        {
            //AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
            //axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();


            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.InitialDirectory = "C:\\Users\\Janine Servais\\Music\\Wiedergabelisten\\";
                openFileDialog.Filter = "|wmv files (*.wmv)|*.wmv|wav files|(*.wav)|*.wav| mp4 files (*.mp4)|*.mp4| mp3 files (*.mp3)|*.mp3|wpl files (*.wpl)|*.wpl|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    //var fileStream = openFileDialog.OpenFile();
                    MessageBox.Show(filePath.ToString());

                    axWindowsMediaPlayer1.CreateControl();
                    axWindowsMediaPlayer1.URL = filePath.ToString();
                    //axWindowsMediaPlayer1.Ctlcontrols.play();
                    /*
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }*/
        //}
        /*
        using (OpenFileDialog openFileDlg = new OpenFileDialog())
    {


        string localpath = Properties.Settings.Default.fileMPpath;
        openFileDialog1.InitialDirectory = localpath;
        openFileDialog1.FileName = openFileDialog1.FileName;
        string path = openFileDialog1.FileName;
        openFileDialog1.Multiselect = true;
        openFileDlg.Multiselect = true;
        var fileContent = string.Empty;
        var filePath = string.Empty;
        try
        { 

            openFileDlg.Filter = "All Files | *.*";
            if (openFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //openFileDialog1.FileName = openFileDialog1.FileName;
                //string path = "C:\\Users\\Janine Servais\\Music\\Wiedergabelisten\\" + "aufnahme1.wpl";
                // string[] filteredFiles = Directory.GetFiles(path);
                var fileStream = openFileDialog1.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
                /* listBox1.ResetText();
                 foreach (string video in filteredFiles)
                 {
                     //axWindowsMediaPlayer1.currentPlaylist.appendItem(axWindowsMediaPlayer1.newMedia(video));                                
                     listBox1.Items.Add(video);
                     axWindowsMediaPlayer1.URL = openFileDlg.FileName;

                 }
                */
        /*
        string path = localpath;//"C:\\Users\\Janine Servais\\Music\\Wiedergabelisten\\" + "aufnahme1.wpl";
        string[] filteredFiles = Directory.GetFiles(path);

        //files = openFileDlg.SafeFileNames;
        //path = openFileDlg.FileNames;
        /*
        axWindowsMediaPlayer1.currentPlaylist = axWindowsMediaPlayer1.newPlaylist("Playlist", "");

        foreach (string video in filteredFiles)
        {
            axWindowsMediaPlayer1.currentPlaylist.appendItem(axWindowsMediaPlayer1.newMedia(video));
            listBox1.Items.Add(video);
        }*/

        /*
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);

    }
        //listBox1.Items.Clear();
        //Array clear - each count per line in folder Add new Item
        /*for (int i = listBox1.Items.Count; i < files.Length; i++)
        {
            if (listBox1.Items != null)
            {

                listBox1.Items.Add(files[i]);
                listBox1.Refresh();
            }
            //Becomes unavailable if 2 different Folder puts together
            else
            {
                /*
                listBox1.Items.Add(files[i]);
                listBox1.Refresh();*/
        //   }
        //}
        /*try
        {
            axWindowsMediaPlayer1.URL = path.ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Dateneintrag kann nicht geladen werden");
        }

        //}
    }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }*/

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Erstellen Sie einen OpenFileDialog, um den Benutzer eine Datei auswählen zu lassen
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Setzen Sie den Filter, um WPL-Dateien anzuzeigen
            openFileDialog.Filter = "Windows Playlist (*.wpl)|*.wpl|Alle Dateien (*.*)|*.*";
            openFileDialog.Title = "Wähle eine Playlist";

            // Zeigen Sie den Dialog an und prüfen Sie, ob der Benutzer auf "OK" geklickt hat
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Holen Sie sich den Pfad der ausgewählten Datei
                string selectedWplPath = openFileDialog.FileName;

                // Rufen Sie Ihre Methode mit dem ausgewählten Pfad auf
                // (Angenommen, FitListBox ist der neue Name für LoadPlaylistIntoListBox)
                FitListBox(selectedWplPath);
            }
        }

        /*Player Modul Steuerung*/
        private void PlayTrack(int trackIndex)
        {
            // Sicherstellen, dass der Index im gültigen Bereich liegt
            if (trackIndex < 0 || trackIndex >= listBox1.Items.Count)
            {
                return;
            }

            // 1. Den Eintrag in der ListBox markieren
            listBox1.SelectedIndex = trackIndex;

            // 2. Den Dateipfad aus der ListBox holen
            string trackPath = listBox1.Items[trackIndex].ToString();

            // 3. Den Song im Mediaplayer laden und abspielen
            axWindowsMediaPlayer1.URL = trackPath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }


        // ▶️ Event für den Play/Pause-Button
        private void btnPlay_Click(object sender, EventArgs e)
        {
            // Wenn ein Song markiert ist, aber nicht abgespielt wird, starte ihn
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused ||
                axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsReady ||
                axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                if (listBox1.SelectedIndex != -1)
                {
                    PlayTrack(listBox1.SelectedIndex);
                }
            }
            // Wenn er bereits spielt, pausiere ihn
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
        }


        // ⏩ Event für den "Vor"-Button
        private void btnNext_Click(object sender, EventArgs e)
        {
            int currentIndex = listBox1.SelectedIndex;

            // Wenn nicht das letzte Lied, gehe einen vor
            if (currentIndex < listBox1.Items.Count - 1)
            {
                PlayTrack(currentIndex + 1);
            }
        }

        // ⏪ Event für den "Zurück"-Button
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int currentIndex = listBox1.SelectedIndex;

            // Wenn nicht das erste Lied, gehe einen zurück
            if (currentIndex > 0)
            {
                PlayTrack(currentIndex - 1);
            }
        }

        // 🎵 Automatischer Übergang zum nächsten Lied, wenn ein Song endet
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // e.newState == 8 bedeutet 'MediaEnded' (Lied ist fertig)
            if (e.newState == 8)
            {
                // Einfach die Logik des "Vor"-Buttons erneut ausführen
                btnNext_Click(null, null);
            }
        }

        // Optional: Abspielen per Doppelklick auf einen Eintrag in der ListBox
        private void listBoxPlaylist_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                PlayTrack(listBox1.SelectedIndex);
            }
        }

        // public int currentSongIndex;
        //public int curindex = listBox1.FindString(curitem);

        //plays a file only by clicking once but is stable
        /*void btnPlay_Click(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.settings.setMode("shuffle", true);
            axWindowsMediaPlayer1.Ctlcontrols.play();


        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();

        }

        //Works fine but only one by one
        private void btnOpen_Click(string wplFilePath)
        {

            try
            {
                FitListBox(wplFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.previous();
        }

        //No action yet ...
        private void btnNext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("haha");

        }*/

        private void hideListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MenuPlayer Visible & Unhide
            //mnuply_open
            if (mnuply_open.Visible == true)
            {
                mnuply_open.Visible = false;
            }
            else
            {
                mnuply_open.Visible = true;
            }

            //mnuply_next
            if (mnuply_next.Visible == true)
            {
                mnuply_next.Visible = false;
            }
            else
            {
                mnuply_next.Visible = true;
            }

            //mnuply_play
            if (mnuply_play.Visible == true)
            {
                mnuply_play.Visible = false;
            }
            else
            {
                mnuply_play.Visible = true;
            }

            //mnuply_stop
            if (mnuply_stop.Visible == true)
            {
                mnuply_stop.Visible = false;
            }
            else
            {
                mnuply_stop.Visible = true;
            }

            //mnuply_prev
            if (mnuply_prev.Visible == true)
            {
                mnuply_prev.Visible = false;
            }
            else
            {
                mnuply_prev.Visible = true;
            }

            //listbox 
            if (listBox1.Visible == true)
            {
                listBox1.Hide();
            }
            else
            {
                listBox1.Show();
            }
        }

        private void loopToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool looping = false;

            if (looping != true)
            {
                axWindowsMediaPlayer1.settings.setMode("loop", true);
                looping = true;
            }
            else
            {
                axWindowsMediaPlayer1.settings.setMode("loop", false);
                looping = false;
            }

        }

        private void chkLooping_CheckedChanged(object sender, EventArgs e)
        {

            if (chkLooping.Checked)
            {
                axWindowsMediaPlayer1.settings.setMode("loop", true);
            }
            else
            {
                axWindowsMediaPlayer1.settings.setMode("loop", false);
            }
        }

        private void hideWMPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void listB_check()
        {
            try
            {

                //axWindowsMediaPlayer1.URL = path[listBox1.SelectedIndex];
                if (listBox1.Items == null)
                {
                    MessageBox.Show("Öffnen Sie Playlisten \n");
                    listBox1.SelectedIndex = listBox1.TopIndex;
                }
                else
                {
                    listBox1.SelectedItem = listBox1.SelectedIndex;
                    listBox1.Focus();
                    Cursor = Cursors.Arrow;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        public void Next_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
        }

        public string True { get; set; }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }


        /*public void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            /*typedef enum WMPPlayState { 
  wmppsUndefined      = 0,
  wmppsStopped        = 1,
  wmppsPaused         = 2,
  wmppsPlaying        = 3,
  wmppsScanForward    = 4,
  wmppsScanReverse    = 5,
  wmppsBuffering      = 6,
  wmppsWaiting        = 7,
  wmppsMediaEnded     = 8,
  wmppsTransitioning  = 9,
  wmppsReady          = 10,
  wmppsReconnecting   = 11,
  wmppsLast           = 12
} WMPPlayState;

            //MessageBox.Show("Status " + axWindowsMediaPlayer1.playState);
            //axWindowsMediaPlayer1.settings.setMode("shuffle", true);
            this.PlayStateChange(11);
            if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsStopped)
            {
                //listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                this.PlayStateChange(10);
                //btnNext_Click();

            }
            /*
         if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsPlaying)
         {
             this.PlayStateChange(11);
             listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
         }
            if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsMediaEnded)
            {
                this.PlayStateChange(11);
                //listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            }
        }


        public void PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)

            {
                //listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                //NewState = '11';
            }

        }


        public void btnNext_Click()
        {

            axWindowsMediaPlayer1.Ctlcontrols.next();


        }
        */
        private void axWindowsMediaPlayer1_OpenPlaylistSwitch(object sender, AxWMPLib._WMPOCXEvents_OpenPlaylistSwitchEvent e)
        {
            listBox1.Visible = true;
        }
        /*
        private void nextButton_Click(object o, System.EventArgs args)
        {
            // To get all of the available functionality of the player controls, cast the
            // value returned by player.Ctlcontrols to a WMPLib.IWMPControls3 interface. 
            WMPLib.IWMPControls3 controls = (WMPLib.IWMPControls3)axWindowsMediaPlayer1.Ctlcontrols;

            // Check first to be sure the operation is valid.
            if (controls.get_isAvailable("next"))
            {
                controls.next();
            }
        }*/

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AxWMPLib.AxWindowsMediaPlayer player = new AxWMPLib.AxWindowsMediaPlayer();

            try
            {
                string mysong = Convert.ToString(listBox1.SelectedItem);
                WMPLib.IWMPPlaylist playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("myplaylist");
                WMPLib.IWMPMedia media;

                using (OpenFileDialog openFileDlg3 = new OpenFileDialog())
                {
                    //openFileDialog1.Multiselect = true;
                    openFileDlg3.Multiselect = true;
                    openFileDialog1.Multiselect = true;
                    //openFileDlg.Multiselect = true;
                    string localpath = Properties.Settings.Default.fileMPpath;
                    openFileDlg3.InitialDirectory = localpath;
                    openFileDlg3.Filter = "All Files | *.*";

                    string[] mylist;
                    string mypath;

                    //listBox1.Items.AddRange(mylist);

                    mylist = openFileDlg3.SafeFileNames;
                    mypath = Directory.GetCurrentDirectory();

                    string[] ComboToList = Directory.GetFiles(localpath);
                    for (int i = listBox1.Items.Count; i < mylist.Length; i++)
                    {
                        if (listBox1.Items != null)
                        {

                            listBox1.Items.Add(mylist[i]);
                            listBox1.Refresh();
                        }
                        else
                        {

                            listBox1.Items.Add(mylist[i]);
                            listBox1.Refresh();
                        }

                    }
                    try
                    {
                        if (listBox1.SelectedItems == null)
                        {
                            MessageBox.Show("keine Daten ausgewählt");
                        }

                        else
                        {

                            foreach (string item in listBox1.Items)
                            {
                                media = axWindowsMediaPlayer1.newMedia(item);
                                playlist.appendItem(media);
                            }

                        }
                        //axWindowsMediaPlayer1.URL = path[listBox1.SelectedIndex];
                        axWindowsMediaPlayer1.URL = openFileDlg3.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex.Message);
                    }
                }
            //}
            

                
                 
                if (listBox1.SelectedItems == null)
                {
                    MessageBox.Show("keine Daten ausgewählt");
                }

                else
                {

                    foreach (string file in listBox1.SelectedItems)
                    {
                        media = axWindowsMediaPlayer1.newMedia(file);
                        playlist.appendItem(media);
                    }

                }
                axWindowsMediaPlayer1.currentPlaylist = playlist;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem1_Click(string wplFilePath)
        {

            try
            {
                FitListBox(wplFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            listB_check();

        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        public void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            listB_check();
        }

        private void hidePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.Visible == false)
            {
                axWindowsMediaPlayer1.Visible = true;
            }
            else
            {
                axWindowsMediaPlayer1.Visible = false;
            }
        }

        private void loopToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
        private void boxToPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AxWMPLib.AxWindowsMediaPlayer player = new AxWMPLib.AxWindowsMediaPlayer();

            try
            {
                string mysong = Convert.ToString(listBox1.SelectedItem);
                WMPLib.IWMPPlaylist playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("myplaylist");
                WMPLib.IWMPMedia media;

                using (OpenFileDialog openFileDlg3 = new OpenFileDialog())
                {
                    //openFileDialog1.Multiselect = true;
                    openFileDlg3.Multiselect = true;
                    openFileDialog1.Multiselect = true;
                    //openFileDlg.Multiselect = true;
                    string localpath = Properties.Settings.Default.fileMPpath;
                    openFileDlg3.InitialDirectory = localpath;
                    openFileDlg3.Filter = "All Files | *.*";

                    string[] mylist;
                    string mypath;

                    //listBox1.Items.AddRange(mylist);

                    mylist = openFileDlg3.SafeFileNames;
                    mypath = Directory.GetCurrentDirectory();

                    string[] ComboToList = Directory.GetFiles(localpath);
                    for (int i = listBox1.Items.Count; i < mylist.Length; i++)
                    {
                        if (listBox1.Items != null)
                        {

                            listBox1.Items.Add(mylist[i]);
                            listBox1.Refresh();
                        }
                        else
                        {

                            listBox1.Items.Add(mylist[i]);
                            listBox1.Refresh();
                        }

                    }
                    try
                    {
                        if (listBox1.SelectedItems == null)
                        {
                            MessageBox.Show("keine Daten ausgewählt");
                        }

                        else
                        {

                            foreach (string item in listBox1.Items)
                            {
                                media = axWindowsMediaPlayer1.newMedia(item);
                                playlist.appendItem(media);
                            }

                        }
                        //axWindowsMediaPlayer1.URL = path[listBox1.SelectedIndex];
                        axWindowsMediaPlayer1.URL = openFileDlg3.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }*/

        void cBPlayList_Saving()
        {
            //string mysong = Convert.ToString(listBox1.SelectedItem);
            try
            {
                WMPLib.IWMPPlaylist playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist(cBPlaylist_tbSaveAs.Text);
                WMPLib.IWMPMedia media;
                foreach (string item in cBPlaylist.Items)
                {
                    media = axWindowsMediaPlayer1.newMedia(item);
                    playlist.appendItem(media);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        void listBox_saving()
        {
            try
            {
                string savefileName = null;
                savefileName = tT_savelistBox1.Text + "txt";
                
                StreamWriter streamWriter = null;
                WMPLib.IWMPPlaylist playlist2 = axWindowsMediaPlayer1.playlistCollection.newPlaylist(tT_savelistBox1.Text);
                WMPLib.IWMPMedia media;
                using (System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(@"C:\\excute\\playlist\\" + savefileName))
                {
                    foreach (var item in listBox1.Items)
                    {
                        SaveFile.WriteLine(item.ToString());
                    }
                }
                foreach (string item in listBox1.Items)
                {
                    media = axWindowsMediaPlayer1.newMedia(item);
                    
                    playlist2.appendItem(media);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void comboBoxToPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try //try once
            {
                using (OpenFileDialog openFileDlg = new OpenFileDialog())//Use MS DCL DialogControl Class Library
                {
                    string mysong = Convert.ToString(listBox1.SelectedItem);//Create string out of an array list
                    WMPLib.IWMPPlaylist playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("myplaylist"); //create playlist as windows media playlist in directory of playlists
                    WMPLib.IWMPMedia media; // wmp library declares a media at the following fileMPath adress to play as a media

                    string localpath = Properties.Settings.Default.fileMPpath; //set local path from Properties eXCute
                    openFileDialog1.InitialDirectory = localpath; //Initial Directory for Openfile Dialog (takes each time last opened Path in the history!!!)
                    openFileDialog1.Multiselect = true; //enables selection of more than 1 file in openFileDialog1
                    openFileDlg.Multiselect = true; //enables selection of more than 1 file in openFileDlg
                    

                    openFileDlg.Filter = "All Files | *.*"; //set Filter for file types
                    if (openFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) //in case of hitting button OK try the following
                    {
                        try
                        {

                            files = openFileDlg.SafeFileNames; //selected files to save
                            string[] myItems = openFileDlg.FileNames; //create an array named myItems
                            //listBox1.Items.Clear();
                            cBPlaylist.ResetText(); //cBPlaylist unload 
                            foreach (string item in myItems) //for each item in myItems fill Array with data, as long there are data
                            {
                                cBPlaylist.Items.Add(item); //Add Items foreach line 

                            }
                            //Array clear - each count per line in folder Add new Item
                        }

                        catch (Exception ex)//catch errors ex
                        {
                            MessageBox.Show("" + ex); //show me the error
                        }

                        try
                        {
                            foreach (string item in cBPlaylist.Items) // foreach item in cBPlaylist
                            {
                                media = axWindowsMediaPlayer1.newMedia(item);//create new item in media myplalist
                                playlist.appendItem(media);//playlist fill file named myplaylist in Directory
                            }
                            axWindowsMediaPlayer1.URL = openFileDlg.FileName; //play direct the path of URL OpenfileDlg
                        }
                        catch (Exception ex)//show me some errors if any
                        {
                            MessageBox.Show("" + ex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void clearComboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr;
                dr = MessageBox.Show("JA Wirklich löschen! ", "Nein Nichts unternehmen", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    cBPlaylist.Items.Clear();                    
                    cBPlaylist.Refresh();
                    MessageBox.Show("Combo Box gelöscht!");
                }
                else
                {
                    MessageBox.Show("Hab NICHTS gemacht!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string PLName = cBPlaylist_tbSaveAs.Text;
            
            try
            {
                if (PLName == null || PLName == "" || PLName == " ")
                {
                    MessageBox.Show("Bitte einen Namen für die Playliste eingeben");
                }

                else
                {
                    MessageBox.Show("Danke, es wurde \n " + PLName + "\neingegeben!\n");
                    
                    try
                    {
                        DialogResult dr;
                        dr = MessageBox.Show("JA \n" + PLName+ " \nspeichern! ", "Nein Nichts unternehmen", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            cBPlayList_Saving();
                            MessageBox.Show("Gespeichert: \n" + PLName + "\n");                            
                        }
                        else
                        {
                            MessageBox.Show("Hab NICHTS gemacht!");
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
                MessageBox.Show("" + ex);
            }
        }

        
        private void combList_RightClick(object sender, MouseEventArgs e)
        {
            try
            {
                //ContextMenu menu = sender as ContextMenu;

                if (e.Button == MouseButtons.Right)
                {
                    /*MouseTest*/

                    //sel_List.Left = MousePosition.X;
                    //sel_List.Top = MousePosition.Y;

                    
                    //MessageBox.Show("Mausposi X: " + MousePosition.X.ToString()+"\n" + "Mausposi Y: " + MousePosition.Y + "\n");
                    
                    //Point pictureBoxPoint = sel_List.SourceControl.PointToClient(screenPoint);
                    Point Cursor_P= new Point(MousePosition.X, MousePosition.Y);
                    sel_List.Show(PointToScreen(e.Location));
                    //sel_List.CreateControl();
                    //this.sel_List.Visible= true;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        //Context Menu for Combo Box List *
        /**
        *-> Sel_List Menue Right Click cBPlaylist as Array (Handler required?)
         *  
         * TO DO: Check Loaded Values from: 
         * 
         * string localpath = Properties.Settings.Default.fileMPpath;
         * 
         * if existant, Options in Context Menu
         * 
         *   Insert behind last Entry
         *   Move Selected Index +1 Down -1 Up in Position of Array
         *   Open OpenFile Directory Append to cBPlaylist
         *   Save Current cBPlaylist Save File Dialog
         * 
         * if not, Show Error Message "Empty Folder"
         *  
         *  Avoid Exception: Set Default Path -> p.ex.: "'C:\\'"
         * 
         * ***/

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wird gelöscht - Sicher");
            string item_Name = cBPlaylist.SelectedItem.ToString();
            int item_nr = cBPlaylist.SelectedIndex;
            cBPlaylist.Items.Remove(item_Name);
            
            cBPlaylist.Refresh();
                
        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try //try once
            {
                using (OpenFileDialog openFileDlg = new OpenFileDialog())//Use MS DCL DialogControl Class Library
                {
                    string mysong = Convert.ToString(listBox1.SelectedItem);//Create string out of an array list
                    WMPLib.IWMPPlaylist playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("myplaylist"); //create playlist as windows media playlist in directory of playlists
                    WMPLib.IWMPMedia media; // wmp library declares a media at the following fileMPath adress to play as a media

                    string localpath = Properties.Settings.Default.fileMPpath; //set local path from Properties eXCute
                    openFileDialog1.InitialDirectory = localpath; //Initial Directory for Openfile Dialog (takes each time last opened Path in the history!!!)
                    openFileDialog1.Multiselect = true; //enables selection of more than 1 file in openFileDialog1
                    openFileDlg.Multiselect = true; //enables selection of more than 1 file in openFileDlg


                    openFileDlg.Filter = "All Files | *.*"; //set Filter for file types
                    if (openFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) //in case of hitting button OK try the following
                    {
                        try
                        {

                            files = openFileDlg.SafeFileNames; //selected files to save
                            string[] myItems = openFileDlg.FileNames; //create an array named myItems
                            //listBox1.Items.Clear();
                            cBPlaylist.ResetText(); //cBPlaylist unload 
                            foreach (string item in myItems) //for each item in myItems fill Array with data, as long there are data
                            {
                                cBPlaylist.Items.Add(item); //Add Items foreach line 

                            }
                            //Array clear - each count per line in folder Add new Item
                        }

                        catch (Exception ex)//catch errors ex
                        {
                            MessageBox.Show("" + ex); //show me the error
                        }

                        try
                        {
                            foreach (string item in cBPlaylist.Items) // foreach item in cBPlaylist
                            {
                                media = axWindowsMediaPlayer1.newMedia(item);//create new item in media myplalist
                                playlist.appendItem(media);//playlist fill file named myplaylist in Directory
                            }
                            axWindowsMediaPlayer1.URL = openFileDlg.FileName; //play direct the path of URL OpenfileDlg
                        }
                        catch (Exception ex)//show me some errors if any
                        {
                            MessageBox.Show("" + ex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void upToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string mvItem = cBPlaylist.SelectedItem.ToString();
                int mvItm_nr = cBPlaylist.SelectedIndex;
                string clone_Item = Convert.ToString(mvItem.Clone());
                int clone_Itemnr = mvItm_nr -1;
                MessageBox.Show("Index: " + mvItm_nr + "  Ort: "+ mvItem.ToString() + "\n"+
                                "Index: " + clone_Itemnr + "  Ort: " + clone_Item.ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void downToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem1_Click_1(string wplFilePath)
        {
            try
            {
                FitListBox(wplFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help help = new help();
            help.Show();

        }
        [System.ComponentModel.TypeConverter(typeof(System.Windows.Forms.OpacityConverter))]
        public double Opacity { get; set; }
        public override System.Drawing.Color BackColor { get; set; }
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            int trackBVal = TrackBar1.Value;

            ActiveForm.Opacity = ((double)(TrackBar1.Value) / 10);
        }

        private void listBox1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {

            string[] files = (string[])e.Data.GetData("FileDrop", false);
            foreach (string s in files)
            {
                //just filename 
                listBox1.Items.Add(s);//s.Substring(1 + s.LastIndexOf(@"\")));
        
                //or fullpathname 
                //     listBox1.Items.Add(s); 
            }

            /*
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    listBox1.Items.Add(fileNames[0]);
                }
            }*/

        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

        }

        private void listBox1_itemDblClick(object sender, EventArgs e)
        {
            string selectURL = listBox1.SelectedItem.ToString();
            axWindowsMediaPlayer1.URL = selectURL;
        }

        private void listBox1_DragLeave(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
        
        private void List_RightClick(object sender, MouseEventArgs e)
        {
            try
            {

            

                    this.listBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.List_RightClick);
            
                    if (e.Button == MouseButtons.Right)
                    {

                        ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBox1);
                        selectedItems = listBox1.SelectedItems;

                        if (listBox1.SelectedIndex != -1)
                        {
                            for (int i = selectedItems.Count - 1; i >= 0; i--)
                            {
                                listBox1.Items.Remove(selectedItems[i]);
                            }
                            
                        }                  
               
               
                        /*int index = this.listBox1.IndexFromPoint(e.Location);
                        if (index != ListBox.NoMatches)
                        {
                    
                        }*/
                    }
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.SelectedIndex = listBox1.SelectedIndex;
            
            listBox1.SelectedItem = true;
        }

        private void saveAsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string PLName = tT_savelistBox1.Text;//cBPlaylist_tbSaveAs.Text;

            try
            {
                if (PLName == null || PLName == "" || PLName == " ")
                {
                    MessageBox.Show("Bitte einen Namen für die Playliste eingeben");
                }

                else
                {
                    MessageBox.Show("Danke, es wurde \n " + PLName + "\neingegeben!\n");

                    try
                    {
                        DialogResult dr;
                        dr = MessageBox.Show("JA \n" + PLName + " \nspeichern! ", "Nein Nichts unternehmen", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            listBox_saving();
                            MessageBox.Show("Gespeichert: \n" + PLName + "\n");
                        }
                        else
                        {
                            MessageBox.Show("Hab NICHTS gemacht!");
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
                MessageBox.Show("" + ex);
            }
        }

        private void listBoxToPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void lOADListBoxFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var fileContent = string.Empty;
            var filePath = string.Empty;
            string path = "C:\\excute\\playlist\\";
            

            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = path ;
                    openFileDialog.Filter = "Textfile (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;
                    



                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                       listBox1.Items.Clear();
                        string conpletepath = path + openFileDialog.SafeFileName;
                        MessageBox.Show(conpletepath);
                        if (System.IO.File.Exists(conpletepath.ToString()))
                        {
                            using (StreamReader sr = new StreamReader(conpletepath))
                            {

                                //string fileName = openFileDialog.FileName;
                                string line;
                                while ((line = sr.ReadLine()) != null)
                                {
                                  listBox1.Items.Add(line);
                                }
                                //sr.ReadToEnd();
                                sr.Close();
                                MessageBox.Show(conpletepath.ToString());
                            }

                        }
                        
                            
                        
                    
                        //Get the path of specified file
                        //filePath = openFileDialog.FileName;

                        //Read the contents of the file into a stream
                        //var fileStream = openFileDialog.OpenFile();
                        //MessageBox.Show(filePath.ToString());

                        /*
                        axWindowsMediaPlayer1.CreateControl();
                        axWindowsMediaPlayer1.URL = filePath.ToString();
                        //axWindowsMediaPlayer1.Ctlcontrols.play();
                        /*
                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();
                        }*/
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
}

        private void textfileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textfileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string path = "C:\\excute\\playlist\\";
            //string complPath = path + "\\Music\\Wiedergabelisten\\";
            try
            {
                string savefileName = null;
                savefileName = tT_savelistBox1.Text + ".txt";

                StreamWriter streamWriter = null;
                WMPLib.IWMPPlaylist playlist2 = axWindowsMediaPlayer1.playlistCollection.newPlaylist(tT_savelistBox1.Text);
                WMPLib.IWMPMedia media;
                using (System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(path + savefileName))
                {
                    foreach (var item in listBox1.Items)
                    {
                        SaveFile.WriteLine(item.ToString());
                    }
                }
                MessageBox.Show(path + savefileName);
                /*
                foreach (string item in listBox1.Items)
                {
                    media = axWindowsMediaPlayer1.newMedia(item);

                    playlist2.appendItem(media);
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void sel_List_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
