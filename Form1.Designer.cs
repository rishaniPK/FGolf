namespace FGolf
{
    partial class GolfBD
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
            this.golf_GDV = new System.Windows.Forms.DataGridView();
            this.btn_loaddata = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.golf_GDV)).BeginInit();
            this.SuspendLayout();
            // 
            // golf_GDV
            // 
            this.golf_GDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.golf_GDV.Location = new System.Drawing.Point(136, 12);
            this.golf_GDV.Name = "golf_GDV";
            this.golf_GDV.Size = new System.Drawing.Size(405, 259);
            this.golf_GDV.TabIndex = 0;
            // 
            // btn_loaddata
            // 
            this.btn_loaddata.Location = new System.Drawing.Point(22, 77);
            this.btn_loaddata.Name = "btn_loaddata";
            this.btn_loaddata.Size = new System.Drawing.Size(80, 31);
            this.btn_loaddata.TabIndex = 1;
            this.btn_loaddata.Text = "Load button";
            this.btn_loaddata.UseVisualStyleBackColor = true;
            this.btn_loaddata.Click += new System.EventHandler(this.Btn_loaddata_Click);
            // 
            // GolfBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 283);
            this.Controls.Add(this.btn_loaddata);
            this.Controls.Add(this.golf_GDV);
            this.Name = "GolfBD";
            this.Text = "Golf";
            this.Load += new System.EventHandler(this.GolfBD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.golf_GDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView golf_GDV;
        private System.Windows.Forms.Button btn_loaddata;
    }
}

