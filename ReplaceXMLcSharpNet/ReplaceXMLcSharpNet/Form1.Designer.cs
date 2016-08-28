namespace ReplaceXMLcSharpNet
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
            this.btnBrowseXMLfile = new System.Windows.Forms.Button();
            this.tbXMLfilePath = new System.Windows.Forms.TextBox();
            this.lblStrToReplace = new System.Windows.Forms.Label();
            this.tbStrToReplace = new System.Windows.Forms.TextBox();
            this.tbReplacementStr = new System.Windows.Forms.TextBox();
            this.lblReplacementStr = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowseXMLfile
            // 
            this.btnBrowseXMLfile.Location = new System.Drawing.Point(12, 12);
            this.btnBrowseXMLfile.Name = "btnBrowseXMLfile";
            this.btnBrowseXMLfile.Size = new System.Drawing.Size(103, 25);
            this.btnBrowseXMLfile.TabIndex = 0;
            this.btnBrowseXMLfile.Text = "Browse XML file";
            this.btnBrowseXMLfile.UseVisualStyleBackColor = true;
            this.btnBrowseXMLfile.Click += new System.EventHandler(this.btnBrowseXMLfile_Click);
            // 
            // tbXMLfilePath
            // 
            this.tbXMLfilePath.Enabled = false;
            this.tbXMLfilePath.Location = new System.Drawing.Point(121, 15);
            this.tbXMLfilePath.Name = "tbXMLfilePath";
            this.tbXMLfilePath.Size = new System.Drawing.Size(362, 20);
            this.tbXMLfilePath.TabIndex = 1;
            // 
            // lblStrToReplace
            // 
            this.lblStrToReplace.AutoSize = true;
            this.lblStrToReplace.Location = new System.Drawing.Point(12, 55);
            this.lblStrToReplace.Name = "lblStrToReplace";
            this.lblStrToReplace.Size = new System.Drawing.Size(92, 13);
            this.lblStrToReplace.TabIndex = 2;
            this.lblStrToReplace.Text = "String to Replace:";
            // 
            // tbStrToReplace
            // 
            this.tbStrToReplace.Location = new System.Drawing.Point(121, 55);
            this.tbStrToReplace.Name = "tbStrToReplace";
            this.tbStrToReplace.Size = new System.Drawing.Size(235, 20);
            this.tbStrToReplace.TabIndex = 3;
            // 
            // tbReplacementStr
            // 
            this.tbReplacementStr.Location = new System.Drawing.Point(121, 91);
            this.tbReplacementStr.Name = "tbReplacementStr";
            this.tbReplacementStr.Size = new System.Drawing.Size(235, 20);
            this.tbReplacementStr.TabIndex = 5;
            // 
            // lblReplacementStr
            // 
            this.lblReplacementStr.AutoSize = true;
            this.lblReplacementStr.Location = new System.Drawing.Point(12, 91);
            this.lblReplacementStr.Name = "lblReplacementStr";
            this.lblReplacementStr.Size = new System.Drawing.Size(75, 13);
            this.lblReplacementStr.TabIndex = 4;
            this.lblReplacementStr.Text = "Replace With:";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(12, 140);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(103, 25);
            this.btnReplace.TabIndex = 6;
            this.btnReplace.Text = "REPLACE!";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 194);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.tbReplacementStr);
            this.Controls.Add(this.lblReplacementStr);
            this.Controls.Add(this.tbStrToReplace);
            this.Controls.Add(this.lblStrToReplace);
            this.Controls.Add(this.tbXMLfilePath);
            this.Controls.Add(this.btnBrowseXMLfile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseXMLfile;
        private System.Windows.Forms.TextBox tbXMLfilePath;
        private System.Windows.Forms.Label lblStrToReplace;
        private System.Windows.Forms.TextBox tbStrToReplace;
        private System.Windows.Forms.TextBox tbReplacementStr;
        private System.Windows.Forms.Label lblReplacementStr;
        private System.Windows.Forms.Button btnReplace;
    }
}

