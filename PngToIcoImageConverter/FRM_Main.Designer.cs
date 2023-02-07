namespace PngToIcoImageConverter
{
    partial class FRM_Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.TXT_Source = new System.Windows.Forms.TextBox();
            this.BT_OpenFolderDest = new System.Windows.Forms.Button();
            this.BT_SetSource = new System.Windows.Forms.Button();
            this.BT_Convert = new System.Windows.Forms.Button();
            this.LBL_title = new System.Windows.Forms.Label();
            this.LBL_Message = new System.Windows.Forms.Label();
            this.RB_16 = new System.Windows.Forms.RadioButton();
            this.RB_32 = new System.Windows.Forms.RadioButton();
            this.RB_64 = new System.Windows.Forms.RadioButton();
            this.RB_72 = new System.Windows.Forms.RadioButton();
            this.RB_128 = new System.Windows.Forms.RadioButton();
            this.RB_Origin = new System.Windows.Forms.RadioButton();
            this.RB_256 = new System.Windows.Forms.RadioButton();
            this.RB_48 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // TXT_Source
            // 
            this.TXT_Source.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_Source.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TXT_Source.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Source.Location = new System.Drawing.Point(12, 58);
            this.TXT_Source.Name = "TXT_Source";
            this.TXT_Source.Size = new System.Drawing.Size(559, 25);
            this.TXT_Source.TabIndex = 0;
            // 
            // BT_OpenFolderDest
            // 
            this.BT_OpenFolderDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_OpenFolderDest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_OpenFolderDest.BackgroundImage")));
            this.BT_OpenFolderDest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_OpenFolderDest.FlatAppearance.BorderSize = 0;
            this.BT_OpenFolderDest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_OpenFolderDest.Location = new System.Drawing.Point(12, 189);
            this.BT_OpenFolderDest.Name = "BT_OpenFolderDest";
            this.BT_OpenFolderDest.Size = new System.Drawing.Size(72, 72);
            this.BT_OpenFolderDest.TabIndex = 2;
            this.BT_OpenFolderDest.UseVisualStyleBackColor = true;
            this.BT_OpenFolderDest.Click += new System.EventHandler(this.BT_OpenFolderDest_Click);
            // 
            // BT_SetSource
            // 
            this.BT_SetSource.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_SetSource.BackgroundImage")));
            this.BT_SetSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_SetSource.FlatAppearance.BorderSize = 0;
            this.BT_SetSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_SetSource.Location = new System.Drawing.Point(577, 53);
            this.BT_SetSource.Name = "BT_SetSource";
            this.BT_SetSource.Size = new System.Drawing.Size(34, 34);
            this.BT_SetSource.TabIndex = 1;
            this.BT_SetSource.UseVisualStyleBackColor = true;
            this.BT_SetSource.Click += new System.EventHandler(this.BT_SetSource_Click);
            // 
            // BT_Convert
            // 
            this.BT_Convert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Convert.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Convert.Location = new System.Drawing.Point(454, 89);
            this.BT_Convert.Name = "BT_Convert";
            this.BT_Convert.Size = new System.Drawing.Size(157, 46);
            this.BT_Convert.TabIndex = 3;
            this.BT_Convert.Text = "Convert";
            this.BT_Convert.UseVisualStyleBackColor = true;
            this.BT_Convert.Click += new System.EventHandler(this.BT_Convert_Click);
            // 
            // LBL_title
            // 
            this.LBL_title.AutoSize = true;
            this.LBL_title.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_title.Location = new System.Drawing.Point(18, 32);
            this.LBL_title.Name = "LBL_title";
            this.LBL_title.Size = new System.Drawing.Size(135, 23);
            this.LBL_title.TabIndex = 4;
            this.LBL_title.Text = "Select picture :";
            // 
            // LBL_Message
            // 
            this.LBL_Message.AutoSize = true;
            this.LBL_Message.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Message.ForeColor = System.Drawing.Color.Black;
            this.LBL_Message.Location = new System.Drawing.Point(300, 164);
            this.LBL_Message.Name = "LBL_Message";
            this.LBL_Message.Size = new System.Drawing.Size(0, 20);
            this.LBL_Message.TabIndex = 5;
            // 
            // RB_16
            // 
            this.RB_16.AutoSize = true;
            this.RB_16.Location = new System.Drawing.Point(12, 89);
            this.RB_16.Name = "RB_16";
            this.RB_16.Size = new System.Drawing.Size(62, 20);
            this.RB_16.TabIndex = 6;
            this.RB_16.Text = "16x16";
            this.RB_16.UseVisualStyleBackColor = true;
            // 
            // RB_32
            // 
            this.RB_32.AutoSize = true;
            this.RB_32.Location = new System.Drawing.Point(80, 89);
            this.RB_32.Name = "RB_32";
            this.RB_32.Size = new System.Drawing.Size(62, 20);
            this.RB_32.TabIndex = 6;
            this.RB_32.Text = "32x32";
            this.RB_32.UseVisualStyleBackColor = true;
            // 
            // RB_64
            // 
            this.RB_64.AutoSize = true;
            this.RB_64.Location = new System.Drawing.Point(225, 89);
            this.RB_64.Name = "RB_64";
            this.RB_64.Size = new System.Drawing.Size(62, 20);
            this.RB_64.TabIndex = 6;
            this.RB_64.Text = "64x64";
            this.RB_64.UseVisualStyleBackColor = true;
            // 
            // RB_72
            // 
            this.RB_72.AutoSize = true;
            this.RB_72.Location = new System.Drawing.Point(293, 89);
            this.RB_72.Name = "RB_72";
            this.RB_72.Size = new System.Drawing.Size(62, 20);
            this.RB_72.TabIndex = 6;
            this.RB_72.Text = "72x72";
            this.RB_72.UseVisualStyleBackColor = true;
            // 
            // RB_128
            // 
            this.RB_128.AutoSize = true;
            this.RB_128.Location = new System.Drawing.Point(362, 89);
            this.RB_128.Name = "RB_128";
            this.RB_128.Size = new System.Drawing.Size(76, 20);
            this.RB_128.TabIndex = 6;
            this.RB_128.Text = "128x128";
            this.RB_128.UseVisualStyleBackColor = true;
            // 
            // RB_Origin
            // 
            this.RB_Origin.AutoSize = true;
            this.RB_Origin.Checked = true;
            this.RB_Origin.Location = new System.Drawing.Point(100, 115);
            this.RB_Origin.Name = "RB_Origin";
            this.RB_Origin.Size = new System.Drawing.Size(101, 20);
            this.RB_Origin.TabIndex = 6;
            this.RB_Origin.TabStop = true;
            this.RB_Origin.Text = "Original size";
            this.RB_Origin.UseVisualStyleBackColor = true;
            // 
            // RB_256
            // 
            this.RB_256.AutoSize = true;
            this.RB_256.Location = new System.Drawing.Point(12, 115);
            this.RB_256.Name = "RB_256";
            this.RB_256.Size = new System.Drawing.Size(76, 20);
            this.RB_256.TabIndex = 6;
            this.RB_256.Text = "256x256";
            this.RB_256.UseVisualStyleBackColor = true;
            // 
            // RB_48
            // 
            this.RB_48.AutoSize = true;
            this.RB_48.Location = new System.Drawing.Point(153, 89);
            this.RB_48.Name = "RB_48";
            this.RB_48.Size = new System.Drawing.Size(62, 20);
            this.RB_48.TabIndex = 6;
            this.RB_48.Text = "48x48";
            this.RB_48.UseVisualStyleBackColor = true;
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 273);
            this.Controls.Add(this.RB_Origin);
            this.Controls.Add(this.RB_256);
            this.Controls.Add(this.RB_128);
            this.Controls.Add(this.RB_72);
            this.Controls.Add(this.RB_48);
            this.Controls.Add(this.RB_64);
            this.Controls.Add(this.RB_32);
            this.Controls.Add(this.RB_16);
            this.Controls.Add(this.LBL_Message);
            this.Controls.Add(this.LBL_title);
            this.Controls.Add(this.BT_Convert);
            this.Controls.Add(this.BT_OpenFolderDest);
            this.Controls.Add(this.BT_SetSource);
            this.Controls.Add(this.TXT_Source);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Format Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_Source;
        private System.Windows.Forms.Button BT_SetSource;
        private System.Windows.Forms.Button BT_OpenFolderDest;
        private System.Windows.Forms.Button BT_Convert;
        private System.Windows.Forms.Label LBL_title;
        private System.Windows.Forms.Label LBL_Message;
        private System.Windows.Forms.RadioButton RB_16;
        private System.Windows.Forms.RadioButton RB_32;
        private System.Windows.Forms.RadioButton RB_64;
        private System.Windows.Forms.RadioButton RB_72;
        private System.Windows.Forms.RadioButton RB_128;
        private System.Windows.Forms.RadioButton RB_Origin;
        private System.Windows.Forms.RadioButton RB_256;
        private System.Windows.Forms.RadioButton RB_48;
    }
}

