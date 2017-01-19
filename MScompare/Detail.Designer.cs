namespace MScompare
{
    partial class Detail
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
            this.DetailText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DetailText
            // 
            this.DetailText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailText.BackColor = System.Drawing.SystemColors.Info;
            this.DetailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetailText.CausesValidation = false;
            this.DetailText.Cursor = System.Windows.Forms.Cursors.Default;
            this.DetailText.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DetailText.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DetailText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DetailText.Location = new System.Drawing.Point(0, 0);
            this.DetailText.Margin = new System.Windows.Forms.Padding(0);
            this.DetailText.Multiline = true;
            this.DetailText.Name = "DetailText";
            this.DetailText.ReadOnly = true;
            this.DetailText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DetailText.Size = new System.Drawing.Size(472, 473);
            this.DetailText.TabIndex = 0;
            this.DetailText.TabStop = false;
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(471, 471);
            this.Controls.Add(this.DetailText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Detail";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Detail";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Detail_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Detail_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DetailText;
    }
}