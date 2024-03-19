namespace çalışma_1504
{
    partial class FromElestiri
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
            this.dgwelestiri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwelestiri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwelestiri
            // 
            this.dgwelestiri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwelestiri.Location = new System.Drawing.Point(32, 288);
            this.dgwelestiri.Name = "dgwelestiri";
            this.dgwelestiri.Size = new System.Drawing.Size(698, 150);
            this.dgwelestiri.TabIndex = 0;
            // 
            // FromElestiri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwelestiri);
            this.Name = "FromElestiri";
            this.Text = "FromElestiri";
            this.Load += new System.EventHandler(this.FromElestiri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwelestiri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwelestiri;
    }
}