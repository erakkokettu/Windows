namespace H2Button
{
    partial class H2Button
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
            this.EkaPainike = new System.Windows.Forms.Button();
            this.tokaPainike = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EkaPainike
            // 
            this.EkaPainike.Location = new System.Drawing.Point(65, 125);
            this.EkaPainike.Name = "EkaPainike";
            this.EkaPainike.Size = new System.Drawing.Size(96, 23);
            this.EkaPainike.TabIndex = 0;
            this.EkaPainike.Text = "Piilota painike";
            this.EkaPainike.UseVisualStyleBackColor = true;
            this.EkaPainike.Click += new System.EventHandler(this.EkaPainike_Click);
            // 
            // tokaPainike
            // 
            this.tokaPainike.Location = new System.Drawing.Point(244, 125);
            this.tokaPainike.Name = "tokaPainike";
            this.tokaPainike.Size = new System.Drawing.Size(75, 23);
            this.tokaPainike.TabIndex = 1;
            this.tokaPainike.Text = "Painike";
            this.tokaPainike.UseVisualStyleBackColor = true;
            this.tokaPainike.Click += new System.EventHandler(this.tokaPainike_Click);
            this.tokaPainike.MouseLeave += new System.EventHandler(this.tokaPainike_MouseLeave);
            this.tokaPainike.MouseHover += new System.EventHandler(this.tokaPainike_MouseHover);
            // 
            // H2Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 193);
            this.Controls.Add(this.tokaPainike);
            this.Controls.Add(this.EkaPainike);
            this.Name = "H2Button";
            this.Text = "H2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EkaPainike;
        private System.Windows.Forms.Button tokaPainike;
    }
}

