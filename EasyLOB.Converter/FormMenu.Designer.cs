namespace EasyLOB_Converter
{
    partial class FormMenu
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonModel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonModel
            // 
            this.buttonModel.Location = new System.Drawing.Point(12, 12);
            this.buttonModel.Name = "buttonModel";
            this.buttonModel.Size = new System.Drawing.Size(360, 30);
            this.buttonModel.TabIndex = 0;
            this.buttonModel.Text = "Convert Model Directory";
            this.buttonModel.UseVisualStyleBackColor = true;
            this.buttonModel.Click += new System.EventHandler(this.buttonModel_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 56);
            this.Controls.Add(this.buttonModel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMenu";
            this.Text = "EasyLOB Converter";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonModel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

