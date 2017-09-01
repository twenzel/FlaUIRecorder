namespace FlaUIRecorder
{
    partial class RecorderForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecorderForm));
            this.btnPausePlay = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAddComment = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnPausePlay
            // 
            this.btnPausePlay.ImageIndex = 0;
            this.btnPausePlay.ImageList = this.imageList1;
            this.btnPausePlay.Location = new System.Drawing.Point(12, 12);
            this.btnPausePlay.Name = "btnPausePlay";
            this.btnPausePlay.Size = new System.Drawing.Size(23, 23);
            this.btnPausePlay.TabIndex = 0;
            this.btnPausePlay.UseVisualStyleBackColor = true;
            this.btnPausePlay.Click += new System.EventHandler(this.btnPausePlay_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Pause_grey_16x.png");
            this.imageList1.Images.SetKeyName(1, "Record_16x.png");
            this.imageList1.Images.SetKeyName(2, "Stop_grey_16x.png");
            this.imageList1.Images.SetKeyName(3, "AddComment_16x.png");
            this.imageList1.Images.SetKeyName(4, "GenerateRecordCode_16x.png");
            // 
            // btnAddComment
            // 
            this.btnAddComment.ImageIndex = 3;
            this.btnAddComment.ImageList = this.imageList1;
            this.btnAddComment.Location = new System.Drawing.Point(70, 12);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(23, 23);
            this.btnAddComment.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnAddComment, "Add comment to the code");
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.ImageIndex = 4;
            this.btnGenerate.ImageList = this.imageList1;
            this.btnGenerate.Location = new System.Drawing.Point(99, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(23, 23);
            this.btnGenerate.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnGenerate, "Stops recording and generate code");
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageIndex = 2;
            this.btnCancel.ImageList = this.imageList1;
            this.btnCancel.Location = new System.Drawing.Point(41, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(23, 23);
            this.btnCancel.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnCancel, "Cancel the recording");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Pause_grey_32xLG.png");
            this.imageList2.Images.SetKeyName(1, "RecordScreen_32x.png");
            this.imageList2.Images.SetKeyName(2, "Stop_grey_32xLG.png");
            this.imageList2.Images.SetKeyName(3, "Comment_24x.png");
            this.imageList2.Images.SetKeyName(4, "FrameworkDesignStudio_32x.png");
            // 
            // RecorderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(139, 45);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnAddComment);
            this.Controls.Add(this.btnPausePlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RecorderForm";
            this.Text = "FlaUI Recorder";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPausePlay;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}