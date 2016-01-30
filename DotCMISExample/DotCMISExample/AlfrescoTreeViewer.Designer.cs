namespace DotCMISExample
    {
    partial class AlfrescoTreeViewer
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.folderDetailsGrid = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.propertiesGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.folderDetailsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(247, 631);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // folderDetailsGrid
            // 
            this.folderDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.folderDetailsGrid.Location = new System.Drawing.Point(276, 12);
            this.folderDetailsGrid.Name = "folderDetailsGrid";
            this.folderDetailsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.folderDetailsGrid.Size = new System.Drawing.Size(1179, 275);
            this.folderDetailsGrid.TabIndex = 1;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(725, 304);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(833, 304);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(945, 304);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // propertiesGrid
            // 
            this.propertiesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propertiesGrid.Location = new System.Drawing.Point(276, 333);
            this.propertiesGrid.Name = "propertiesGrid";
            this.propertiesGrid.Size = new System.Drawing.Size(1179, 310);
            this.propertiesGrid.TabIndex = 5;
            // 
            // AlfrescoTreeViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 646);
            this.Controls.Add(this.propertiesGrid);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.folderDetailsGrid);
            this.Controls.Add(this.treeView1);
            this.Name = "AlfrescoTreeViewer";
            this.Text = "Alfresco Tree Viewer";
            this.Load += new System.EventHandler(this.AlfrescoTreeViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.folderDetailsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesGrid)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView folderDetailsGrid;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView propertiesGrid;
        }
    }