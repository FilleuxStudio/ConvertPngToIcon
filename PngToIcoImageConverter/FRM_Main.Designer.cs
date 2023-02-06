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
            this.SuspendLayout();
            // 
            // TXT_Source
            // 
            this.TXT_Source.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_Source.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TXT_Source.Location = new System.Drawing.Point(52, 51);
            this.TXT_Source.Name = "TXT_Source";
            this.TXT_Source.Size = new System.Drawing.Size(559, 22);
            this.TXT_Source.TabIndex = 0;
            // 
            // BT_OpenFolderDest
            // 
            this.BT_OpenFolderDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_OpenFolderDest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_OpenFolderDest.BackgroundImage")));
            this.BT_OpenFolderDest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_OpenFolderDest.FlatAppearance.BorderSize = 0;
            this.BT_OpenFolderDest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_OpenFolderDest.Location = new System.Drawing.Point(16, 189);
            this.BT_OpenFolderDest.Name = "BT_OpenFolderDest";
            this.BT_OpenFolderDest.Size = new System.Drawing.Size(74, 74);
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
            this.BT_SetSource.Location = new System.Drawing.Point(12, 44);
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
            this.BT_Convert.Size = new System.Drawing.Size(157, 32);
            this.BT_Convert.TabIndex = 3;
            this.BT_Convert.Text = "Convert";
            this.BT_Convert.UseVisualStyleBackColor = true;
            this.BT_Convert.Click += new System.EventHandler(this.BT_Convert_Click);
            // 
            // LBL_title
            // 
            this.LBL_title.AutoSize = true;
            this.LBL_title.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_title.Location = new System.Drawing.Point(54, 18);
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
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 273);
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
    }
}

