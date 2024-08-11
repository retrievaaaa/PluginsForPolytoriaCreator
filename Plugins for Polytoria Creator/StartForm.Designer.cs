namespace Plugins_for_Polytoria_Creator {
    partial class StartForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            LabelPolytoriaCreator = new Label();
            ButtonInstallLoader = new Button();
            statusStrip1 = new StatusStrip();
            ProgessBarState = new ToolStripProgressBar();
            LabelState = new ToolStripStatusLabel();
            ListBoxMods = new ListBox();
            LabelInstalled = new Label();
            LabelModTitle = new Label();
            LabelMinVersion = new Label();
            LabelMaxVersion = new Label();
            ButtonRemove = new Button();
            ButtonInstallFromZip = new Button();
            OpenFileDialogZipFile = new OpenFileDialog();
            installFromFolder = new Button();
            OpenFolderDialog = new FolderBrowserDialog();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // LabelPolytoriaCreator
            // 
            LabelPolytoriaCreator.AutoSize = true;
            LabelPolytoriaCreator.Location = new Point(15, 13);
            LabelPolytoriaCreator.Margin = new Padding(4, 0, 4, 0);
            LabelPolytoriaCreator.Name = "LabelPolytoriaCreator";
            LabelPolytoriaCreator.Size = new Size(466, 27);
            LabelPolytoriaCreator.TabIndex = 0;
            LabelPolytoriaCreator.Text = "Polytoria Creator Version: 0.0.0; Loader installed: No";
            // 
            // ButtonInstallLoader
            // 
            ButtonInstallLoader.Location = new Point(629, 13);
            ButtonInstallLoader.Name = "ButtonInstallLoader";
            ButtonInstallLoader.Size = new Size(162, 36);
            ButtonInstallLoader.TabIndex = 1;
            ButtonInstallLoader.Text = "Install Loader/Sync";
            ButtonInstallLoader.UseVisualStyleBackColor = true;
            ButtonInstallLoader.Click += ButtonInstallLoader_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { ProgessBarState, LabelState });
            statusStrip1.Location = new Point(0, 385);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(803, 25);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // ProgessBarState
            // 
            ProgessBarState.Name = "ProgessBarState";
            ProgessBarState.Size = new Size(250, 17);
            // 
            // LabelState
            // 
            LabelState.Margin = new Padding(10, 3, 0, 2);
            LabelState.Name = "LabelState";
            LabelState.Size = new Size(146, 20);
            LabelState.Text = "State: Doing nothing";
            // 
            // ListBoxMods
            // 
            ListBoxMods.FormattingEnabled = true;
            ListBoxMods.ItemHeight = 27;
            ListBoxMods.Location = new Point(12, 65);
            ListBoxMods.Name = "ListBoxMods";
            ListBoxMods.Size = new Size(305, 247);
            ListBoxMods.TabIndex = 3;
            // 
            // LabelInstalled
            // 
            LabelInstalled.AutoSize = true;
            LabelInstalled.Location = new Point(12, 41);
            LabelInstalled.Name = "LabelInstalled";
            LabelInstalled.Size = new Size(145, 27);
            LabelInstalled.TabIndex = 4;
            LabelInstalled.Text = "Isntalled mods:";
            // 
            // LabelModTitle
            // 
            LabelModTitle.AutoSize = true;
            LabelModTitle.Font = new Font("Segoe UI Variable Display", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LabelModTitle.Location = new Point(323, 65);
            LabelModTitle.Name = "LabelModTitle";
            LabelModTitle.Size = new Size(563, 36);
            LabelModTitle.TabIndex = 5;
            LabelModTitle.Text = "Click an installed mod to see more information";
            // 
            // LabelMinVersion
            // 
            LabelMinVersion.AutoSize = true;
            LabelMinVersion.Location = new Point(323, 95);
            LabelMinVersion.Name = "LabelMinVersion";
            LabelMinVersion.Size = new Size(251, 27);
            LabelMinVersion.TabIndex = 6;
            LabelMinVersion.Text = "Minimum creator version: ?";
            // 
            // LabelMaxVersion
            // 
            LabelMaxVersion.AutoSize = true;
            LabelMaxVersion.Location = new Point(323, 116);
            LabelMaxVersion.Name = "LabelMaxVersion";
            LabelMaxVersion.Size = new Size(254, 27);
            LabelMaxVersion.TabIndex = 7;
            LabelMaxVersion.Text = "Maximum creator version: ?";
            // 
            // ButtonRemove
            // 
            ButtonRemove.Location = new Point(323, 345);
            ButtonRemove.Name = "ButtonRemove";
            ButtonRemove.Size = new Size(460, 40);
            ButtonRemove.TabIndex = 8;
            ButtonRemove.Text = "Remove";
            ButtonRemove.UseVisualStyleBackColor = true;
            ButtonRemove.Click += ButtonRemove_Click;
            // 
            // ButtonInstallFromZip
            // 
            ButtonInstallFromZip.Location = new Point(12, 349);
            ButtonInstallFromZip.Name = "ButtonInstallFromZip";
            ButtonInstallFromZip.Size = new Size(305, 33);
            ButtonInstallFromZip.TabIndex = 9;
            ButtonInstallFromZip.Text = "Install from zip file";
            ButtonInstallFromZip.UseVisualStyleBackColor = true;
            ButtonInstallFromZip.Click += ButtonInstallFromZip_Click;
            // 
            // OpenFileDialogZipFile
            // 
            OpenFileDialogZipFile.Filter = "ZIP-Files|*.zip";
            OpenFileDialogZipFile.FileOk += OpenFileDialogZipFile_FileOk;
            // 
            // installFromFolder
            // 
            installFromFolder.Location = new Point(12, 318);
            installFromFolder.Name = "installFromFolder";
            installFromFolder.Size = new Size(305, 35);
            installFromFolder.TabIndex = 10;
            installFromFolder.Text = "Install from folder";
            installFromFolder.UseVisualStyleBackColor = true;
            installFromFolder.Click += installFromFolder_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 410);
            Controls.Add(installFromFolder);
            Controls.Add(ButtonInstallFromZip);
            Controls.Add(ButtonRemove);
            Controls.Add(LabelMaxVersion);
            Controls.Add(LabelMinVersion);
            Controls.Add(LabelModTitle);
            Controls.Add(LabelInstalled);
            Controls.Add(ListBoxMods);
            Controls.Add(statusStrip1);
            Controls.Add(ButtonInstallLoader);
            Controls.Add(LabelPolytoriaCreator);
            Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "StartForm";
            Text = "MainForm";
            Load += StartForm_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelPolytoriaCreator;
        private Button ButtonInstallLoader;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar ProgessBarState;
        private ToolStripStatusLabel LabelState;
        private ListBox ListBoxMods;
        private Label LabelInstalled;
        private Label LabelModTitle;
        private Label LabelMinVersion;
        private Label LabelMaxVersion;
        private Button ButtonRemove;
        private Button ButtonInstallFromZip;
        private OpenFileDialog OpenFileDialogZipFile;
        private Button installFromFolder;
        private FolderBrowserDialog OpenFolderDialog;
    }
}