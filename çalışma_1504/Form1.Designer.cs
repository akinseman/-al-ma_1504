namespace çalışma_1504
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
            this.dgwfılmler = new System.Windows.Forms.DataGridView();
            this.bntelestiri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwfılmler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwfılmler
            // 
            this.dgwfılmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwfılmler.Location = new System.Drawing.Point(12, 226);
            this.dgwfılmler.Name = "dgwfılmler";
            this.dgwfılmler.Size = new System.Drawing.Size(669, 212);
            this.dgwfılmler.TabIndex = 0;
            // 
            // bntelestiri
            // 
            this.bntelestiri.Location = new System.Drawing.Point(441, 116);
            this.bntelestiri.Name = "bntelestiri";
            this.bntelestiri.Size = new System.Drawing.Size(75, 70);
            this.bntelestiri.TabIndex = 1;
            this.bntelestiri.Text = "button1";
            this.bntelestiri.UseVisualStyleBackColor = true;
            this.bntelestiri.Click += new System.EventHandler(this.bntelestiri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntelestiri);
            this.Controls.Add(this.dgwfılmler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwfılmler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwfılmler;
        private System.Windows.Forms.Button bntelestiri;
    }
}

