using System;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Linq;

namespace DDTankFlashDownloader
{
    public partial class Form1 : MetroForm
    {
        public string downloadingText;
        public string startDownloadText;
        public string errorOccurredText;
        public string downloadCompletedText;
        public string fieldFlashNameText;
        public string fieldFlashUrlText;
        public string fieldFlashLangText;
        public string invalidFileMessage;
        public string allowedExtensionsText;
        public string allowedExtensionsPngText;
        public string allowedExtensionsSwfText;
        public string allowedExtensionsLangText;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Enable the Add buttons only when corresponding text boxes are not empty
            txtAdd.TextChanged += (s, ev) => btnAdd.Enabled = txtAdd.Text.Trim().Length > 0;
            txtAddLang.TextChanged += (s, ev) => btnAddLang.Enabled = txtAddLang.Text.Trim().Length > 0;
            txtAddSwf.TextChanged += (s, ev) => btnAddSwf.Enabled = txtAddSwf.Text.Trim().Length > 0;
            txtAddXml.TextChanged += (s, ev) => btnAddXml.Enabled = txtAddXml.Text.Trim().Length > 0;
            // Trigger button visibility on mouse click (helps with re-clicking the same item)
            listFlash.MouseClick += (s, ev) => btnDel.Enabled = listFlash.SelectedIndex != -1;
            listLang.MouseClick += (s, ev) => btnDelLang.Enabled = listLang.SelectedIndex != -1;
            listSwf.MouseClick += (s, ev) => btnDelSwf.Enabled = listSwf.SelectedIndex != -1;
            listXml.MouseClick += (s, ev) => btnDelXml.Enabled = listXml.SelectedIndex != -1;
            // Initialize default items in the lists if empty
            FlashFileInitializer.InitializeDefaultItems(this);
            // Set language
            if (Properties.Settings.Default.selectLang == "Vietnamese")
            {
                cboLang.SelectedIndex = 0;
                switchLang();
            }
            else if (Properties.Settings.Default.selectLang == "English")
            {
                cboLang.SelectedIndex = 1;
                switchLang();
            }
            else if (Properties.Settings.Default.selectLang == "Russian")
            {
                cboLang.SelectedIndex = 2;
                switchLang();
            }
        }

        private void switchLang()
        {
            LanguageManager.ApplyLanguage(this);
        }

        private bool IsValidExtension(string fileName, string[] allowedExtensions = null)
        {
            if (allowedExtensions == null)
            {
                allowedExtensions = new[] { ".png", ".swf", ".xml", ".txt" };
            }
            string extension = Path.GetExtension(fileName).ToLower();
            return allowedExtensions.Contains(extension);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = txtAdd.Text.Trim();
                if (fileName.Length > 0 && IsValidExtension(fileName, new[] { ".png", ".swf", ".xml" }))
                {
                    listFlash.Items.Add(fileName);
                }
                else
                {
                    MessageBox.Show(invalidFileMessage + "\n" + allowedExtensionsText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show(errorOccurredText + "!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddLang_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = txtAddLang.Text.Trim();
                if (fileName.Length > 0 && IsValidExtension(fileName, new[] { ".png", ".txt", ".xml" }))
                {
                    listLang.Items.Add(fileName);
                }
                else
                {
                    MessageBox.Show(invalidFileMessage + "\n" + allowedExtensionsLangText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show(errorOccurredText + "!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddSwf_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = txtAddSwf.Text.Trim();
                if (fileName.Length > 0 && IsValidExtension(fileName, new[] { ".swf" }))
                {
                    listSwf.Items.Add(fileName);
                }
                else
                {
                    MessageBox.Show(invalidFileMessage + "\n" + allowedExtensionsSwfText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show(errorOccurredText + "!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddXml_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = txtAddXml.Text.Trim();
                if (fileName.Length > 0 && IsValidExtension(fileName, new[] { ".xml" }))
                {
                    listXml.Items.Add(fileName);
                }
                else
                {
                    MessageBox.Show(invalidFileMessage + "\n" + allowedExtensionsPngText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show(errorOccurredText + "!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listFlash);
                selectedItems = listFlash.SelectedItems;
                if (listFlash.SelectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                    {
                        listFlash.Items.Remove(selectedItems[i]);
                    }
                }
            }
            catch
            {
                MessageBox.Show(errorOccurredText + "!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelLang_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listLang);
                selectedItems = listLang.SelectedItems;
                if (listLang.SelectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                    {
                        listLang.Items.Remove(selectedItems[i]);
                    }
                }
            }
            catch
            {
                MessageBox.Show(errorOccurredText + "!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelSwf_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listSwf);
                selectedItems = listSwf.SelectedItems;
                if (listSwf.SelectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                    {
                        listSwf.Items.Remove(selectedItems[i]);
                    }
                }
            }
            catch
            {
                MessageBox.Show(errorOccurredText + "!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelXml_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listXml);
                selectedItems = listXml.SelectedItems;
                if (listXml.SelectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                    {
                        listXml.Items.Remove(selectedItems[i]);
                    }
                }
            }
            catch
            {
                MessageBox.Show(errorOccurredText + "!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnFetch_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMessages = "";
                if (string.IsNullOrWhiteSpace(txtFlashName.Text))
                {
                    errorMessages += "- " + fieldFlashNameText + Environment.NewLine + Environment.NewLine;
                }
                if (string.IsNullOrWhiteSpace(txtFlashUrl.Text))
                {
                    errorMessages += "- " + fieldFlashUrlText + Environment.NewLine + Environment.NewLine;
                }
                if (string.IsNullOrWhiteSpace(txtFlashLang.Text))
                {
                    errorMessages += "- " + fieldFlashLangText + Environment.NewLine + Environment.NewLine;
                }
                if (!string.IsNullOrWhiteSpace(errorMessages))
                {
                    MessageBox.Show(errorMessages.TrimEnd(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                btnFetch.Enabled = false;
                btnFetch.Text = downloadingText;
                fileControl();
                await DownloadAllFilesAsync();
                MessageBox.Show(downloadCompletedText, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, errorOccurredText + ": " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnFetch.Enabled = true;
                btnFetch.Text = startDownloadText;
            }
        }

        private async Task DownloadAllFilesAsync()
        {
            int totalFiles = listFlash.Items.Count + listLang.Items.Count + listSwf.Items.Count + listXml.Items.Count;
            int downloadedFiles = 0;
            progressDownload.Maximum = totalFiles;
            progressDownload.Value = 0;
            lblProgress.Text = "";
            using (WebClient webClient = new WebClient())
            {
                // Download Flash
                foreach (string file in listFlash.Items)
                {
                    string url = $"{txtFlashUrl.Text}{file}";
                    string localPath = Path.Combine(Application.StartupPath, "Downloads", txtFlashName.Text, file);
                    await DownloadFileSafeAsync(webClient, url, localPath);
                    downloadedFiles++;
                    UpdateProgress(downloadedFiles, totalFiles, file);
                }
                // Download Ui
                foreach (string file in listLang.Items)
                {
                    string url = $"{txtFlashUrl.Text}ui\\{txtFlashLang.Text}\\{file}";
                    string localPath = Path.Combine(Application.StartupPath, "Downloads", txtFlashName.Text, "ui", txtFlashLang.Text, file);
                    await DownloadFileSafeAsync(webClient, url, localPath);
                    downloadedFiles++;
                    UpdateProgress(downloadedFiles, totalFiles, file);
                }
                // Download Swf
                foreach (string file in listSwf.Items)
                {
                    string url = $"{txtFlashUrl.Text}ui\\{txtFlashLang.Text}\\swf\\{file}";
                    string localPath = Path.Combine(Application.StartupPath, "Downloads", txtFlashName.Text, "ui", txtFlashLang.Text, "swf", file);
                    await DownloadFileSafeAsync(webClient, url, localPath);
                    downloadedFiles++;
                    UpdateProgress(downloadedFiles, totalFiles, file);
                }
                // Download Xml
                foreach (string file in listXml.Items)
                {
                    string url = $"{txtFlashUrl.Text}ui\\{txtFlashLang.Text}\\xml\\{file}";
                    string localPath = Path.Combine(Application.StartupPath, "Downloads", txtFlashName.Text, "ui", txtFlashLang.Text, "xml", file);
                    await DownloadFileSafeAsync(webClient, url, localPath);
                    downloadedFiles++;
                    UpdateProgress(downloadedFiles, totalFiles, file);
                }
            }
        }

        private void UpdateProgress(int downloadedFiles, int totalFiles, string currentFile)
        {
            progressDownload.Value = downloadedFiles;
            double percent = (downloadedFiles * 100.0) / totalFiles;
            lblProgress.Text = $"{(int)percent}%";
            lblProgress.Refresh();
        }

        private async Task DownloadFileSafeAsync(WebClient webClient, string url, string localPath)
        {
            try
            {
                string directory = Path.GetDirectoryName(localPath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                await webClient.DownloadFileTaskAsync(new Uri(url), localPath);
            }
            catch (WebException ex)
            {
                if (ex.Response is HttpWebResponse response && response.StatusCode == HttpStatusCode.NotFound)
                {
                    // File not found, skip
                }
                else
                {
                    throw;
                }
            }
        }

        private void fileControl()
        {
            if (!Directory.Exists(Application.StartupPath + "\\Downloads"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Downloads");
            }
            if (!Directory.Exists(Application.StartupPath + "\\Downloads\\" + txtFlashName.Text))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Downloads\\" + txtFlashName.Text);
            }
            if (!Directory.Exists(Application.StartupPath + "\\Downloads\\" + txtFlashName.Text + "\\ui"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Downloads\\" + txtFlashName.Text + "\\ui");
            }
            if (!Directory.Exists(Application.StartupPath + "\\Downloads\\" + txtFlashName.Text + "\\ui\\" + txtFlashLang.Text))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Downloads\\" + txtFlashName.Text + "\\ui\\" + txtFlashLang.Text);
            }
            if (!Directory.Exists(Application.StartupPath + "\\Downloads\\" + txtFlashName.Text + "\\ui\\" + txtFlashLang.Text + "\\swf"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Downloads\\" + txtFlashName.Text + "\\ui\\" + txtFlashLang.Text + "\\swf");
            }
            if (!Directory.Exists(Application.StartupPath + "\\Downloads\\" + txtFlashName.Text + "\\ui\\" + txtFlashLang.Text + "\\xml"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Downloads\\" + txtFlashName.Text + "\\ui\\" + txtFlashLang.Text + "\\xml");
            }
        }

        private void cboLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            switchLang();
            if (cboLang.SelectedIndex == 0)
            {
                Properties.Settings.Default.selectLang = "Vietnamese";
                Properties.Settings.Default.Save();
            }
            else if (cboLang.SelectedIndex == 1)
            {
                Properties.Settings.Default.selectLang = "English";
                Properties.Settings.Default.Save();
            }
            else if (cboLang.SelectedIndex == 2)
            {
                Properties.Settings.Default.selectLang = "Russian";
                Properties.Settings.Default.Save();
            }
        }

        private void linkGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/duyplus");
        }

        private void linkRageZone_Click(object sender, EventArgs e)
        {
            Process.Start("https://forum.ragezone.com");
        }
    }
}
