namespace ScreenSaver
{
    partial class MainScreen
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
            this.pbScreen = new System.Windows.Forms.PictureBox();
            this.btScreenAdd = new System.Windows.Forms.Button();
            this.btScreenDelete = new System.Windows.Forms.Button();
            this.btScreenSave = new System.Windows.Forms.Button();
            this.btScreenShot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbScreen
            // 
            this.pbScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbScreen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbScreen.Location = new System.Drawing.Point(12, 12);
            this.pbScreen.Name = "pbScreen";
            this.pbScreen.Size = new System.Drawing.Size(1160, 700);
            this.pbScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScreen.TabIndex = 0;
            this.pbScreen.TabStop = false;
            this.pbScreen.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbScreen_DragDrop);
            this.pbScreen.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbScreen_DragEnter);
            // 
            // btScreenAdd
            // 
            this.btScreenAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btScreenAdd.BackColor = System.Drawing.Color.Chartreuse;
            this.btScreenAdd.Location = new System.Drawing.Point(12, 720);
            this.btScreenAdd.Name = "btScreenAdd";
            this.btScreenAdd.Size = new System.Drawing.Size(90, 30);
            this.btScreenAdd.TabIndex = 1;
            this.btScreenAdd.Text = "Add Screen";
            this.btScreenAdd.UseVisualStyleBackColor = false;
            this.btScreenAdd.Click += new System.EventHandler(this.btScreenAdd_Click);
            // 
            // btScreenDelete
            // 
            this.btScreenDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btScreenDelete.BackColor = System.Drawing.Color.Tomato;
            this.btScreenDelete.Location = new System.Drawing.Point(108, 720);
            this.btScreenDelete.Name = "btScreenDelete";
            this.btScreenDelete.Size = new System.Drawing.Size(90, 30);
            this.btScreenDelete.TabIndex = 2;
            this.btScreenDelete.Text = "Delete Screen";
            this.btScreenDelete.UseVisualStyleBackColor = false;
            this.btScreenDelete.Click += new System.EventHandler(this.btScreenDelete_Click);
            // 
            // btScreenSave
            // 
            this.btScreenSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btScreenSave.BackColor = System.Drawing.Color.Khaki;
            this.btScreenSave.Location = new System.Drawing.Point(986, 720);
            this.btScreenSave.Name = "btScreenSave";
            this.btScreenSave.Size = new System.Drawing.Size(90, 30);
            this.btScreenSave.TabIndex = 1;
            this.btScreenSave.Text = "Save Screen";
            this.btScreenSave.UseVisualStyleBackColor = false;
            this.btScreenSave.Click += new System.EventHandler(this.btScreenSave_Click);
            // 
            // btScreenShot
            // 
            this.btScreenShot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btScreenShot.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btScreenShot.Location = new System.Drawing.Point(1082, 720);
            this.btScreenShot.Name = "btScreenShot";
            this.btScreenShot.Size = new System.Drawing.Size(90, 30);
            this.btScreenShot.TabIndex = 1;
            this.btScreenShot.Text = "ScreenShot";
            this.btScreenShot.UseVisualStyleBackColor = false;
            this.btScreenShot.Click += new System.EventHandler(this.btScreenShot_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.btScreenDelete);
            this.Controls.Add(this.btScreenShot);
            this.Controls.Add(this.btScreenSave);
            this.Controls.Add(this.btScreenAdd);
            this.Controls.Add(this.pbScreen);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen saver";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbScreen;
        private System.Windows.Forms.Button btScreenAdd;
        private System.Windows.Forms.Button btScreenDelete;
        private System.Windows.Forms.Button btScreenSave;
        private System.Windows.Forms.Button btScreenShot;
    }
}

