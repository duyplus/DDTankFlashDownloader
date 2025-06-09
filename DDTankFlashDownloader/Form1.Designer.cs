using System;
using System.Drawing;

namespace DDTankFlashDownloader
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
            this.lblFlashUrl = new MetroFramework.Controls.MetroLabel();
            this.txtFlashUrl = new MetroFramework.Controls.MetroTextBox();
            this.lblFlashLang = new MetroFramework.Controls.MetroLabel();
            this.txtFlashLang = new MetroFramework.Controls.MetroTextBox();
            this.listFlash = new System.Windows.Forms.ListBox();
            this.btnDel = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.txtAdd = new MetroFramework.Controls.MetroTextBox();
            this.txtFlashName = new MetroFramework.Controls.MetroTextBox();
            this.lblFlashName = new MetroFramework.Controls.MetroLabel();
            this.btnFetch = new MetroFramework.Controls.MetroButton();
            this.listLang = new System.Windows.Forms.ListBox();
            this.lblUrlFlash = new MetroFramework.Controls.MetroLabel();
            this.lblUrlUi = new MetroFramework.Controls.MetroLabel();
            this.listSwf = new System.Windows.Forms.ListBox();
            this.lblUrlSwf = new MetroFramework.Controls.MetroLabel();
            this.listXml = new System.Windows.Forms.ListBox();
            this.lblUrlXml = new MetroFramework.Controls.MetroLabel();
            this.btnDelLang = new MetroFramework.Controls.MetroButton();
            this.txtAddLang = new MetroFramework.Controls.MetroTextBox();
            this.btnDelSwf = new MetroFramework.Controls.MetroButton();
            this.btnAddSwf = new MetroFramework.Controls.MetroButton();
            this.txtAddSwf = new MetroFramework.Controls.MetroTextBox();
            this.btnDelXml = new MetroFramework.Controls.MetroButton();
            this.btnAddXml = new MetroFramework.Controls.MetroButton();
            this.txtAddXml = new MetroFramework.Controls.MetroTextBox();
            this.btnAddLang = new MetroFramework.Controls.MetroButton();
            this.gbLang = new System.Windows.Forms.GroupBox();
            this.cboLang = new MetroFramework.Controls.MetroComboBox();
            this.linkGithub = new MetroFramework.Controls.MetroLink();
            this.linkRageZone = new MetroFramework.Controls.MetroLink();
            this.progressDownload = new MetroFramework.Controls.MetroProgressBar();
            this.lblProgress = new MetroFramework.Controls.MetroLabel();
            this.gbLang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFlashUrl
            // 
            this.lblFlashUrl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblFlashUrl.Location = new System.Drawing.Point(41, 104);
            this.lblFlashUrl.Name = "lblFlashUrl";
            this.lblFlashUrl.Size = new System.Drawing.Size(98, 21);
            this.lblFlashUrl.TabIndex = 0;
            this.lblFlashUrl.Text = "Flash URL:";
            this.lblFlashUrl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFlashUrl
            // 
            // 
            // 
            // 
            this.txtFlashUrl.CustomButton.Image = null;
            this.txtFlashUrl.CustomButton.Location = new System.Drawing.Point(377, 1);
            this.txtFlashUrl.CustomButton.Name = "";
            this.txtFlashUrl.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtFlashUrl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFlashUrl.CustomButton.TabIndex = 1;
            this.txtFlashUrl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFlashUrl.CustomButton.UseSelectable = true;
            this.txtFlashUrl.CustomButton.Visible = false;
            this.txtFlashUrl.DisplayIcon = true;
            this.txtFlashUrl.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFlashUrl.Lines = new string[0];
            this.txtFlashUrl.Location = new System.Drawing.Point(142, 102);
            this.txtFlashUrl.MaxLength = 32767;
            this.txtFlashUrl.Name = "txtFlashUrl";
            this.txtFlashUrl.PasswordChar = '\0';
            this.txtFlashUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFlashUrl.SelectedText = "";
            this.txtFlashUrl.SelectionLength = 0;
            this.txtFlashUrl.SelectionStart = 0;
            this.txtFlashUrl.ShortcutsEnabled = true;
            this.txtFlashUrl.Size = new System.Drawing.Size(405, 29);
            this.txtFlashUrl.TabIndex = 1;
            this.txtFlashUrl.UseSelectable = true;
            this.txtFlashUrl.WaterMark = "Required *";
            this.txtFlashUrl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFlashUrl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblFlashLang
            // 
            this.lblFlashLang.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblFlashLang.Location = new System.Drawing.Point(28, 138);
            this.lblFlashLang.Name = "lblFlashLang";
            this.lblFlashLang.Size = new System.Drawing.Size(111, 21);
            this.lblFlashLang.TabIndex = 2;
            this.lblFlashLang.Text = "Ngôn ngữ Flash:";
            this.lblFlashLang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFlashLang
            // 
            // 
            // 
            // 
            this.txtFlashLang.CustomButton.Image = null;
            this.txtFlashLang.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.txtFlashLang.CustomButton.Name = "";
            this.txtFlashLang.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtFlashLang.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFlashLang.CustomButton.TabIndex = 1;
            this.txtFlashLang.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFlashLang.CustomButton.UseSelectable = true;
            this.txtFlashLang.CustomButton.Visible = false;
            this.txtFlashLang.DisplayIcon = true;
            this.txtFlashLang.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFlashLang.Lines = new string[0];
            this.txtFlashLang.Location = new System.Drawing.Point(142, 136);
            this.txtFlashLang.MaxLength = 32767;
            this.txtFlashLang.Name = "txtFlashLang";
            this.txtFlashLang.PasswordChar = '\0';
            this.txtFlashLang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFlashLang.SelectedText = "";
            this.txtFlashLang.SelectionLength = 0;
            this.txtFlashLang.SelectionStart = 0;
            this.txtFlashLang.ShortcutsEnabled = true;
            this.txtFlashLang.Size = new System.Drawing.Size(191, 29);
            this.txtFlashLang.TabIndex = 3;
            this.txtFlashLang.UseSelectable = true;
            this.txtFlashLang.WaterMark = "Required *";
            this.txtFlashLang.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFlashLang.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // listFlash
            // 
            this.listFlash.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.listFlash.FormattingEnabled = true;
            this.listFlash.ItemHeight = 17;
            this.listFlash.Location = new System.Drawing.Point(28, 204);
            this.listFlash.Name = "listFlash";
            this.listFlash.Size = new System.Drawing.Size(225, 106);
            this.listFlash.TabIndex = 5;
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(27, 323);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 29);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Xoá";
            this.btnDel.UseSelectable = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(104, 323);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 29);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAdd
            // 
            // 
            // 
            // 
            this.txtAdd.CustomButton.Image = null;
            this.txtAdd.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txtAdd.CustomButton.Name = "";
            this.txtAdd.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtAdd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdd.CustomButton.TabIndex = 1;
            this.txtAdd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdd.CustomButton.UseSelectable = true;
            this.txtAdd.CustomButton.Visible = false;
            this.txtAdd.DisplayIcon = true;
            this.txtAdd.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAdd.Lines = new string[0];
            this.txtAdd.Location = new System.Drawing.Point(104, 357);
            this.txtAdd.MaxLength = 32767;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.PasswordChar = '\0';
            this.txtAdd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdd.SelectedText = "";
            this.txtAdd.SelectionLength = 0;
            this.txtAdd.SelectionStart = 0;
            this.txtAdd.ShortcutsEnabled = true;
            this.txtAdd.Size = new System.Drawing.Size(151, 29);
            this.txtAdd.TabIndex = 8;
            this.txtAdd.UseSelectable = true;
            this.txtAdd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtFlashName
            // 
            // 
            // 
            // 
            this.txtFlashName.CustomButton.Image = null;
            this.txtFlashName.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.txtFlashName.CustomButton.Name = "";
            this.txtFlashName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtFlashName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFlashName.CustomButton.TabIndex = 1;
            this.txtFlashName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFlashName.CustomButton.UseSelectable = true;
            this.txtFlashName.CustomButton.Visible = false;
            this.txtFlashName.DisplayIcon = true;
            this.txtFlashName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFlashName.Lines = new string[0];
            this.txtFlashName.Location = new System.Drawing.Point(142, 68);
            this.txtFlashName.MaxLength = 32767;
            this.txtFlashName.Name = "txtFlashName";
            this.txtFlashName.PasswordChar = '\0';
            this.txtFlashName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFlashName.SelectedText = "";
            this.txtFlashName.SelectionLength = 0;
            this.txtFlashName.SelectionStart = 0;
            this.txtFlashName.ShortcutsEnabled = true;
            this.txtFlashName.Size = new System.Drawing.Size(191, 29);
            this.txtFlashName.TabIndex = 9;
            this.txtFlashName.UseSelectable = true;
            this.txtFlashName.WaterMark = "Required *";
            this.txtFlashName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFlashName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblFlashName
            // 
            this.lblFlashName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblFlashName.Location = new System.Drawing.Point(41, 69);
            this.lblFlashName.Name = "lblFlashName";
            this.lblFlashName.Size = new System.Drawing.Size(98, 21);
            this.lblFlashName.TabIndex = 10;
            this.lblFlashName.Text = "Tên thư mục:";
            this.lblFlashName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFetch
            // 
            this.btnFetch.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnFetch.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnFetch.Location = new System.Drawing.Point(28, 414);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(142, 43);
            this.btnFetch.TabIndex = 11;
            this.btnFetch.Text = "Start Download !";
            this.btnFetch.UseSelectable = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // listLang
            // 
            this.listLang.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.listLang.FormattingEnabled = true;
            this.listLang.ItemHeight = 17;
            this.listLang.Location = new System.Drawing.Point(259, 204);
            this.listLang.Name = "listLang";
            this.listLang.Size = new System.Drawing.Size(225, 106);
            this.listLang.TabIndex = 14;
            // 
            // lblUrlFlash
            // 
            this.lblUrlFlash.AutoSize = true;
            this.lblUrlFlash.Location = new System.Drawing.Point(25, 186);
            this.lblUrlFlash.Name = "lblUrlFlash";
            this.lblUrlFlash.Size = new System.Drawing.Size(40, 19);
            this.lblUrlFlash.TabIndex = 15;
            this.lblUrlFlash.Text = "flash/";
            // 
            // lblUrlUi
            // 
            this.lblUrlUi.AutoSize = true;
            this.lblUrlUi.Location = new System.Drawing.Point(256, 186);
            this.lblUrlUi.Name = "lblUrlUi";
            this.lblUrlUi.Size = new System.Drawing.Size(95, 19);
            this.lblUrlUi.TabIndex = 16;
            this.lblUrlUi.Text = "flash/ui/LANG/";
            // 
            // listSwf
            // 
            this.listSwf.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.listSwf.FormattingEnabled = true;
            this.listSwf.ItemHeight = 17;
            this.listSwf.Location = new System.Drawing.Point(490, 204);
            this.listSwf.Name = "listSwf";
            this.listSwf.Size = new System.Drawing.Size(225, 106);
            this.listSwf.TabIndex = 17;
            // 
            // lblUrlSwf
            // 
            this.lblUrlSwf.AutoSize = true;
            this.lblUrlSwf.Location = new System.Drawing.Point(487, 186);
            this.lblUrlSwf.Name = "lblUrlSwf";
            this.lblUrlSwf.Size = new System.Drawing.Size(118, 19);
            this.lblUrlSwf.TabIndex = 18;
            this.lblUrlSwf.Text = "flash/ui/LANG/swf/";
            // 
            // listXml
            // 
            this.listXml.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.listXml.FormattingEnabled = true;
            this.listXml.ItemHeight = 17;
            this.listXml.Location = new System.Drawing.Point(721, 204);
            this.listXml.Name = "listXml";
            this.listXml.Size = new System.Drawing.Size(225, 106);
            this.listXml.TabIndex = 19;
            // 
            // lblUrlXml
            // 
            this.lblUrlXml.AutoSize = true;
            this.lblUrlXml.Location = new System.Drawing.Point(718, 186);
            this.lblUrlXml.Name = "lblUrlXml";
            this.lblUrlXml.Size = new System.Drawing.Size(121, 19);
            this.lblUrlXml.TabIndex = 20;
            this.lblUrlXml.Text = "flash/ui/LANG/xml/";
            // 
            // btnDelLang
            // 
            this.btnDelLang.Enabled = false;
            this.btnDelLang.Location = new System.Drawing.Point(258, 323);
            this.btnDelLang.Name = "btnDelLang";
            this.btnDelLang.Size = new System.Drawing.Size(75, 29);
            this.btnDelLang.TabIndex = 6;
            this.btnDelLang.Text = "Xoá";
            this.btnDelLang.UseSelectable = true;
            this.btnDelLang.Click += new System.EventHandler(this.btnDelLang_Click);
            // 
            // txtAddLang
            // 
            // 
            // 
            // 
            this.txtAddLang.CustomButton.Image = null;
            this.txtAddLang.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txtAddLang.CustomButton.Name = "";
            this.txtAddLang.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtAddLang.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddLang.CustomButton.TabIndex = 1;
            this.txtAddLang.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddLang.CustomButton.UseSelectable = true;
            this.txtAddLang.CustomButton.Visible = false;
            this.txtAddLang.DisplayIcon = true;
            this.txtAddLang.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAddLang.Lines = new string[0];
            this.txtAddLang.Location = new System.Drawing.Point(335, 357);
            this.txtAddLang.MaxLength = 32767;
            this.txtAddLang.Name = "txtAddLang";
            this.txtAddLang.PasswordChar = '\0';
            this.txtAddLang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddLang.SelectedText = "";
            this.txtAddLang.SelectionLength = 0;
            this.txtAddLang.SelectionStart = 0;
            this.txtAddLang.ShortcutsEnabled = true;
            this.txtAddLang.Size = new System.Drawing.Size(151, 29);
            this.txtAddLang.TabIndex = 8;
            this.txtAddLang.UseSelectable = true;
            this.txtAddLang.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddLang.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnDelSwf
            // 
            this.btnDelSwf.Enabled = false;
            this.btnDelSwf.Location = new System.Drawing.Point(489, 323);
            this.btnDelSwf.Name = "btnDelSwf";
            this.btnDelSwf.Size = new System.Drawing.Size(75, 29);
            this.btnDelSwf.TabIndex = 21;
            this.btnDelSwf.Text = "Xoá";
            this.btnDelSwf.UseSelectable = true;
            this.btnDelSwf.Click += new System.EventHandler(this.btnDelSwf_Click);
            // 
            // btnAddSwf
            // 
            this.btnAddSwf.Enabled = false;
            this.btnAddSwf.Location = new System.Drawing.Point(566, 323);
            this.btnAddSwf.Name = "btnAddSwf";
            this.btnAddSwf.Size = new System.Drawing.Size(150, 29);
            this.btnAddSwf.TabIndex = 22;
            this.btnAddSwf.Text = "Thêm mới";
            this.btnAddSwf.UseSelectable = true;
            this.btnAddSwf.Click += new System.EventHandler(this.btnAddSwf_Click);
            // 
            // txtAddSwf
            // 
            // 
            // 
            // 
            this.txtAddSwf.CustomButton.Image = null;
            this.txtAddSwf.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txtAddSwf.CustomButton.Name = "";
            this.txtAddSwf.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtAddSwf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddSwf.CustomButton.TabIndex = 1;
            this.txtAddSwf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddSwf.CustomButton.UseSelectable = true;
            this.txtAddSwf.CustomButton.Visible = false;
            this.txtAddSwf.DisplayIcon = true;
            this.txtAddSwf.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAddSwf.Lines = new string[0];
            this.txtAddSwf.Location = new System.Drawing.Point(566, 357);
            this.txtAddSwf.MaxLength = 32767;
            this.txtAddSwf.Name = "txtAddSwf";
            this.txtAddSwf.PasswordChar = '\0';
            this.txtAddSwf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddSwf.SelectedText = "";
            this.txtAddSwf.SelectionLength = 0;
            this.txtAddSwf.SelectionStart = 0;
            this.txtAddSwf.ShortcutsEnabled = true;
            this.txtAddSwf.Size = new System.Drawing.Size(151, 29);
            this.txtAddSwf.TabIndex = 23;
            this.txtAddSwf.UseSelectable = true;
            this.txtAddSwf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddSwf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnDelXml
            // 
            this.btnDelXml.Enabled = false;
            this.btnDelXml.Location = new System.Drawing.Point(720, 323);
            this.btnDelXml.Name = "btnDelXml";
            this.btnDelXml.Size = new System.Drawing.Size(75, 29);
            this.btnDelXml.TabIndex = 21;
            this.btnDelXml.Text = "Xoá";
            this.btnDelXml.UseSelectable = true;
            this.btnDelXml.Click += new System.EventHandler(this.btnDelXml_Click);
            // 
            // btnAddXml
            // 
            this.btnAddXml.Enabled = false;
            this.btnAddXml.Location = new System.Drawing.Point(797, 323);
            this.btnAddXml.Name = "btnAddXml";
            this.btnAddXml.Size = new System.Drawing.Size(150, 29);
            this.btnAddXml.TabIndex = 22;
            this.btnAddXml.Text = "Thêm mới";
            this.btnAddXml.UseSelectable = true;
            this.btnAddXml.Click += new System.EventHandler(this.btnAddXml_Click);
            // 
            // txtAddXml
            // 
            // 
            // 
            // 
            this.txtAddXml.CustomButton.Image = null;
            this.txtAddXml.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txtAddXml.CustomButton.Name = "";
            this.txtAddXml.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtAddXml.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddXml.CustomButton.TabIndex = 1;
            this.txtAddXml.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddXml.CustomButton.UseSelectable = true;
            this.txtAddXml.CustomButton.Visible = false;
            this.txtAddXml.DisplayIcon = true;
            this.txtAddXml.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAddXml.Lines = new string[0];
            this.txtAddXml.Location = new System.Drawing.Point(797, 357);
            this.txtAddXml.MaxLength = 32767;
            this.txtAddXml.Name = "txtAddXml";
            this.txtAddXml.PasswordChar = '\0';
            this.txtAddXml.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddXml.SelectedText = "";
            this.txtAddXml.SelectionLength = 0;
            this.txtAddXml.SelectionStart = 0;
            this.txtAddXml.ShortcutsEnabled = true;
            this.txtAddXml.Size = new System.Drawing.Size(151, 29);
            this.txtAddXml.TabIndex = 23;
            this.txtAddXml.UseSelectable = true;
            this.txtAddXml.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddXml.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAddLang
            // 
            this.btnAddLang.Enabled = false;
            this.btnAddLang.Location = new System.Drawing.Point(335, 323);
            this.btnAddLang.Name = "btnAddLang";
            this.btnAddLang.Size = new System.Drawing.Size(150, 29);
            this.btnAddLang.TabIndex = 24;
            this.btnAddLang.Text = "Thêm mới";
            this.btnAddLang.UseSelectable = true;
            this.btnAddLang.Click += new System.EventHandler(this.btnAddLang_Click);
            // 
            // gbLang
            // 
            this.gbLang.Controls.Add(this.cboLang);
            this.gbLang.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbLang.Location = new System.Drawing.Point(553, 58);
            this.gbLang.Name = "gbLang";
            this.gbLang.Size = new System.Drawing.Size(200, 107);
            this.gbLang.TabIndex = 27;
            this.gbLang.TabStop = false;
            this.gbLang.Text = "Ngôn ngữ";
            // 
            // cboLang
            // 
            this.cboLang.BackColor = System.Drawing.SystemColors.Window;
            this.cboLang.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboLang.FormattingEnabled = true;
            this.cboLang.ItemHeight = 23;
            this.cboLang.Items.AddRange(new object[] {
            "Vietnamese",
            "English",
            "Russian"});
            this.cboLang.Location = new System.Drawing.Point(6, 19);
            this.cboLang.Name = "cboLang";
            this.cboLang.Size = new System.Drawing.Size(188, 29);
            this.cboLang.TabIndex = 0;
            this.cboLang.UseSelectable = true;
            this.cboLang.SelectedIndexChanged += new System.EventHandler(this.cboLang_SelectedIndexChanged);
            // 
            // linkGithub
            // 
            this.linkGithub.Cursor = System.Windows.Forms.Cursors.Default;
            this.linkGithub.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.linkGithub.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.linkGithub.ForeColor = System.Drawing.Color.Black;
            this.linkGithub.Location = new System.Drawing.Point(815, 111);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(136, 23);
            this.linkGithub.TabIndex = 31;
            this.linkGithub.Text = "github.com/duyplus";
            this.linkGithub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkGithub.UseCustomForeColor = true;
            this.linkGithub.UseSelectable = true;
            this.linkGithub.Click += new System.EventHandler(this.linkGithub_Click);
            // 
            // linkRageZone
            // 
            this.linkRageZone.AutoSize = true;
            this.linkRageZone.Cursor = System.Windows.Forms.Cursors.Default;
            this.linkRageZone.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.linkRageZone.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.linkRageZone.ForeColor = System.Drawing.Color.Black;
            this.linkRageZone.Location = new System.Drawing.Point(815, 89);
            this.linkRageZone.Name = "linkRageZone";
            this.linkRageZone.Size = new System.Drawing.Size(136, 23);
            this.linkRageZone.TabIndex = 30;
            this.linkRageZone.Text = "forum.ragezone.com";
            this.linkRageZone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkRageZone.UseCustomForeColor = true;
            this.linkRageZone.UseSelectable = true;
            this.linkRageZone.Click += new System.EventHandler(this.linkRageZone_Click);
            // 
            // progressDownload
            // 
            this.progressDownload.Location = new System.Drawing.Point(28, 460);
            this.progressDownload.Name = "progressDownload";
            this.progressDownload.Size = new System.Drawing.Size(107, 10);
            this.progressDownload.Style = MetroFramework.MetroColorStyle.Teal;
            this.progressDownload.TabIndex = 0;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblProgress.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblProgress.Location = new System.Drawing.Point(137, 457);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(23, 15);
            this.lblProgress.TabIndex = 1;
            this.lblProgress.Text = "0%";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 495);
            this.Controls.Add(this.progressDownload);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.linkRageZone);
            this.Controls.Add(this.linkGithub);
            this.Controls.Add(this.gbLang);
            this.Controls.Add(this.btnAddLang);
            this.Controls.Add(this.txtAddXml);
            this.Controls.Add(this.txtAddSwf);
            this.Controls.Add(this.btnAddXml);
            this.Controls.Add(this.btnDelXml);
            this.Controls.Add(this.btnAddSwf);
            this.Controls.Add(this.btnDelSwf);
            this.Controls.Add(this.lblUrlXml);
            this.Controls.Add(this.listXml);
            this.Controls.Add(this.lblUrlSwf);
            this.Controls.Add(this.listSwf);
            this.Controls.Add(this.lblUrlUi);
            this.Controls.Add(this.lblUrlFlash);
            this.Controls.Add(this.listLang);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.lblFlashName);
            this.Controls.Add(this.txtFlashName);
            this.Controls.Add(this.txtAddLang);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.btnDelLang);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.listFlash);
            this.Controls.Add(this.txtFlashLang);
            this.Controls.Add(this.txtFlashUrl);
            this.Controls.Add(this.lblFlashUrl);
            this.Controls.Add(this.lblFlashLang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(975, 495);
            this.MinimumSize = new System.Drawing.Size(975, 495);
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "DDTank Flash Downloader v1.1.0";
            this.TransparencyKey = System.Drawing.Color.MidnightBlue;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbLang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblFlashUrl;
        private MetroFramework.Controls.MetroTextBox txtFlashUrl;
        public MetroFramework.Controls.MetroLabel lblFlashLang;
        private MetroFramework.Controls.MetroTextBox txtFlashLang;
        public System.Windows.Forms.ListBox listFlash;
        public MetroFramework.Controls.MetroButton btnDel;
        public MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroTextBox txtAdd;
        private MetroFramework.Controls.MetroTextBox txtFlashName;
        public MetroFramework.Controls.MetroLabel lblFlashName;
        public MetroFramework.Controls.MetroButton btnFetch;
        public System.Windows.Forms.ListBox listLang;
        private MetroFramework.Controls.MetroLabel lblUrlFlash;
        private MetroFramework.Controls.MetroLabel lblUrlUi;
        public System.Windows.Forms.ListBox listSwf;
        private MetroFramework.Controls.MetroLabel lblUrlSwf;
        public System.Windows.Forms.ListBox listXml;
        private MetroFramework.Controls.MetroLabel lblUrlXml;
        public MetroFramework.Controls.MetroButton btnDelLang;
        private MetroFramework.Controls.MetroTextBox txtAddLang;
        public MetroFramework.Controls.MetroButton btnDelSwf;
        public MetroFramework.Controls.MetroButton btnAddSwf;
        private MetroFramework.Controls.MetroTextBox txtAddSwf;
        public MetroFramework.Controls.MetroButton btnDelXml;
        public MetroFramework.Controls.MetroButton btnAddXml;
        private MetroFramework.Controls.MetroTextBox txtAddXml;
        public MetroFramework.Controls.MetroButton btnAddLang;
        public System.Windows.Forms.GroupBox gbLang;
        public MetroFramework.Controls.MetroComboBox cboLang;
        private MetroFramework.Controls.MetroLink linkGithub;
        private MetroFramework.Controls.MetroLink linkRageZone;
        private MetroFramework.Controls.MetroProgressBar progressDownload;
        private MetroFramework.Controls.MetroLabel lblProgress;
    }
}
