using System.Windows.Forms;

namespace Faer.Src.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.paramsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lnlFileName = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.lblCreatedFileDate = new System.Windows.Forms.Label();
            this.dtpCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.lblEditedFileDate = new System.Windows.Forms.Label();
            this.dtpLastEditedDate = new System.Windows.Forms.DateTimePicker();
            this.lblOpenedFileDate = new System.Windows.Forms.Label();
            this.dtpLastOpenedDate = new System.Windows.Forms.DateTimePicker();
            this.attributesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cbNoScrubData = new System.Windows.Forms.CheckBox();
            this.cbNotContentIndexed = new System.Windows.Forms.CheckBox();
            this.cbEncrypted = new System.Windows.Forms.CheckBox();
            this.cbIntegrityStream = new System.Windows.Forms.CheckBox();
            this.cbReparsePoint = new System.Windows.Forms.CheckBox();
            this.cbCompressed = new System.Windows.Forms.CheckBox();
            this.cbOffline = new System.Windows.Forms.CheckBox();
            this.cbNormal = new System.Windows.Forms.CheckBox();
            this.cbTemporary = new System.Windows.Forms.CheckBox();
            this.cbSparseFile = new System.Windows.Forms.CheckBox();
            this.cbDevice = new System.Windows.Forms.CheckBox();
            this.cbArchive = new System.Windows.Forms.CheckBox();
            this.cbDirectory = new System.Windows.Forms.CheckBox();
            this.cbSystem = new System.Windows.Forms.CheckBox();
            this.cbHidden = new System.Windows.Forms.CheckBox();
            this.cbReadOnly = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainPanel.SuspendLayout();
            this.paramsPanel.SuspendLayout();
            this.attributesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Controls.Add(this.btnOpen, 0, 0);
            this.mainPanel.Controls.Add(this.btnSave, 0, 1);
            this.mainPanel.Controls.Add(this.paramsPanel, 1, 0);
            this.mainPanel.Controls.Add(this.attributesPanel, 0, 2);
            this.mainPanel.Name = "mainPanel";
            // 
            // btnOpen
            // 
            resources.ApplyResources(this.btnOpen, "btnOpen");
            this.btnOpen.ImageList = this.imageList;
            this.btnOpen.Name = "btnOpen";
            this.toolTip.SetToolTip(this.btnOpen, resources.GetString("btnOpen.ToolTip"));
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Open.png");
            this.imageList.Images.SetKeyName(1, "Save.png");
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.ImageList = this.imageList;
            this.btnSave.Name = "btnSave";
            this.toolTip.SetToolTip(this.btnSave, resources.GetString("btnSave.ToolTip"));
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // paramsPanel
            // 
            resources.ApplyResources(this.paramsPanel, "paramsPanel");
            this.paramsPanel.Controls.Add(this.lnlFileName, 0, 0);
            this.paramsPanel.Controls.Add(this.tbFileName, 1, 0);
            this.paramsPanel.Controls.Add(this.lblCreatedFileDate, 0, 1);
            this.paramsPanel.Controls.Add(this.dtpCreatedDate, 1, 1);
            this.paramsPanel.Controls.Add(this.lblEditedFileDate, 0, 2);
            this.paramsPanel.Controls.Add(this.dtpLastEditedDate, 1, 2);
            this.paramsPanel.Controls.Add(this.lblOpenedFileDate, 0, 3);
            this.paramsPanel.Controls.Add(this.dtpLastOpenedDate, 1, 3);
            this.paramsPanel.Name = "paramsPanel";
            this.mainPanel.SetRowSpan(this.paramsPanel, 2);
            // 
            // lnlFileName
            // 
            resources.ApplyResources(this.lnlFileName, "lnlFileName");
            this.lnlFileName.Name = "lnlFileName";
            // 
            // tbFileName
            // 
            resources.ApplyResources(this.tbFileName, "tbFileName");
            this.tbFileName.Name = "tbFileName";
            // 
            // lblCreatedFileDate
            // 
            resources.ApplyResources(this.lblCreatedFileDate, "lblCreatedFileDate");
            this.lblCreatedFileDate.Name = "lblCreatedFileDate";
            // 
            // dtpCreatedDate
            // 
            resources.ApplyResources(this.dtpCreatedDate, "dtpCreatedDate");
            this.dtpCreatedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCreatedDate.Name = "dtpCreatedDate";
            // 
            // lblEditedFileDate
            // 
            resources.ApplyResources(this.lblEditedFileDate, "lblEditedFileDate");
            this.lblEditedFileDate.Name = "lblEditedFileDate";
            // 
            // dtpLastEditedDate
            // 
            resources.ApplyResources(this.dtpLastEditedDate, "dtpLastEditedDate");
            this.dtpLastEditedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLastEditedDate.Name = "dtpLastEditedDate";
            // 
            // lblOpenedFileDate
            // 
            resources.ApplyResources(this.lblOpenedFileDate, "lblOpenedFileDate");
            this.lblOpenedFileDate.Name = "lblOpenedFileDate";
            // 
            // dtpLastOpenedDate
            // 
            resources.ApplyResources(this.dtpLastOpenedDate, "dtpLastOpenedDate");
            this.dtpLastOpenedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLastOpenedDate.Name = "dtpLastOpenedDate";
            // 
            // attributesPanel
            // 
            resources.ApplyResources(this.attributesPanel, "attributesPanel");
            this.mainPanel.SetColumnSpan(this.attributesPanel, 2);
            this.attributesPanel.Controls.Add(this.cbNoScrubData, 1, 5);
            this.attributesPanel.Controls.Add(this.cbNotContentIndexed, 0, 4);
            this.attributesPanel.Controls.Add(this.cbEncrypted, 0, 4);
            this.attributesPanel.Controls.Add(this.cbIntegrityStream, 0, 4);
            this.attributesPanel.Controls.Add(this.cbReparsePoint, 0, 3);
            this.attributesPanel.Controls.Add(this.cbCompressed, 0, 3);
            this.attributesPanel.Controls.Add(this.cbOffline, 0, 3);
            this.attributesPanel.Controls.Add(this.cbNormal, 0, 2);
            this.attributesPanel.Controls.Add(this.cbTemporary, 0, 2);
            this.attributesPanel.Controls.Add(this.cbSparseFile, 0, 2);
            this.attributesPanel.Controls.Add(this.cbDevice, 2, 1);
            this.attributesPanel.Controls.Add(this.cbArchive, 1, 1);
            this.attributesPanel.Controls.Add(this.cbDirectory, 0, 1);
            this.attributesPanel.Controls.Add(this.cbSystem, 2, 0);
            this.attributesPanel.Controls.Add(this.cbHidden, 1, 0);
            this.attributesPanel.Controls.Add(this.cbReadOnly, 0, 0);
            this.attributesPanel.Name = "attributesPanel";
            // 
            // cbNoScrubData
            // 
            resources.ApplyResources(this.cbNoScrubData, "cbNoScrubData");
            this.cbNoScrubData.Name = "cbNoScrubData";
            this.cbNoScrubData.UseVisualStyleBackColor = true;
            // 
            // cbNotContentIndexed
            // 
            resources.ApplyResources(this.cbNotContentIndexed, "cbNotContentIndexed");
            this.cbNotContentIndexed.Name = "cbNotContentIndexed";
            this.cbNotContentIndexed.UseVisualStyleBackColor = true;
            // 
            // cbEncrypted
            // 
            resources.ApplyResources(this.cbEncrypted, "cbEncrypted");
            this.cbEncrypted.Name = "cbEncrypted";
            this.cbEncrypted.UseVisualStyleBackColor = true;
            // 
            // cbIntegrityStream
            // 
            resources.ApplyResources(this.cbIntegrityStream, "cbIntegrityStream");
            this.cbIntegrityStream.Name = "cbIntegrityStream";
            this.cbIntegrityStream.UseVisualStyleBackColor = true;
            // 
            // cbReparsePoint
            // 
            resources.ApplyResources(this.cbReparsePoint, "cbReparsePoint");
            this.cbReparsePoint.Name = "cbReparsePoint";
            this.cbReparsePoint.UseVisualStyleBackColor = true;
            // 
            // cbCompressed
            // 
            resources.ApplyResources(this.cbCompressed, "cbCompressed");
            this.cbCompressed.Name = "cbCompressed";
            this.cbCompressed.UseVisualStyleBackColor = true;
            // 
            // cbOffline
            // 
            resources.ApplyResources(this.cbOffline, "cbOffline");
            this.cbOffline.Name = "cbOffline";
            this.cbOffline.UseVisualStyleBackColor = true;
            // 
            // cbNormal
            // 
            resources.ApplyResources(this.cbNormal, "cbNormal");
            this.cbNormal.Name = "cbNormal";
            this.cbNormal.UseVisualStyleBackColor = true;
            // 
            // cbTemporary
            // 
            resources.ApplyResources(this.cbTemporary, "cbTemporary");
            this.cbTemporary.Name = "cbTemporary";
            this.cbTemporary.UseVisualStyleBackColor = true;
            // 
            // cbSparseFile
            // 
            resources.ApplyResources(this.cbSparseFile, "cbSparseFile");
            this.cbSparseFile.Name = "cbSparseFile";
            this.cbSparseFile.UseVisualStyleBackColor = true;
            // 
            // cbDevice
            // 
            resources.ApplyResources(this.cbDevice, "cbDevice");
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.UseVisualStyleBackColor = true;
            // 
            // cbArchive
            // 
            resources.ApplyResources(this.cbArchive, "cbArchive");
            this.cbArchive.Name = "cbArchive";
            this.cbArchive.UseVisualStyleBackColor = true;
            // 
            // cbDirectory
            // 
            resources.ApplyResources(this.cbDirectory, "cbDirectory");
            this.cbDirectory.Name = "cbDirectory";
            this.cbDirectory.UseVisualStyleBackColor = true;
            // 
            // cbSystem
            // 
            resources.ApplyResources(this.cbSystem, "cbSystem");
            this.cbSystem.Name = "cbSystem";
            this.cbSystem.UseVisualStyleBackColor = true;
            // 
            // cbHidden
            // 
            resources.ApplyResources(this.cbHidden, "cbHidden");
            this.cbHidden.Name = "cbHidden";
            this.cbHidden.UseVisualStyleBackColor = true;
            // 
            // cbReadOnly
            // 
            resources.ApplyResources(this.cbReadOnly, "cbReadOnly");
            this.cbReadOnly.Name = "cbReadOnly";
            this.cbReadOnly.UseVisualStyleBackColor = true;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.paramsPanel.ResumeLayout(false);
            this.paramsPanel.PerformLayout();
            this.attributesPanel.ResumeLayout(false);
            this.attributesPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lnlFileName;
        private System.Windows.Forms.TableLayoutPanel paramsPanel;
        private System.Windows.Forms.Label lblCreatedFileDate;
        private System.Windows.Forms.Label lblOpenedFileDate;
        private System.Windows.Forms.Label lblEditedFileDate;
        private System.Windows.Forms.TableLayoutPanel attributesPanel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.DateTimePicker dtpLastOpenedDate;
        private System.Windows.Forms.DateTimePicker dtpLastEditedDate;
        private System.Windows.Forms.DateTimePicker dtpCreatedDate;
        private System.Windows.Forms.CheckBox cbHidden;
        private System.Windows.Forms.CheckBox cbReadOnly;
        private System.Windows.Forms.CheckBox cbSystem;
        private System.Windows.Forms.CheckBox cbDirectory;
        private System.Windows.Forms.CheckBox cbDevice;
        private System.Windows.Forms.CheckBox cbArchive;
        private System.Windows.Forms.CheckBox cbSparseFile;
        private System.Windows.Forms.CheckBox cbNoScrubData;
        private System.Windows.Forms.CheckBox cbNotContentIndexed;
        private System.Windows.Forms.CheckBox cbEncrypted;
        private System.Windows.Forms.CheckBox cbIntegrityStream;
        private System.Windows.Forms.CheckBox cbReparsePoint;
        private System.Windows.Forms.CheckBox cbCompressed;
        private System.Windows.Forms.CheckBox cbOffline;
        private System.Windows.Forms.CheckBox cbNormal;
        private System.Windows.Forms.CheckBox cbTemporary;
    }
}

