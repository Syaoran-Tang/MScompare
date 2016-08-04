namespace MScompare
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Src = new System.Windows.Forms.ListBox();
            this.SrcContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Formula = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.ListBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            this.importDialog = new System.Windows.Forms.OpenFileDialog();
            this.exportDialog = new System.Windows.Forms.SaveFileDialog();
            this.RegexText = new System.Windows.Forms.TextBox();
            this.SrcView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcpt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SrcContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SrcView)).BeginInit();
            this.SuspendLayout();
            // 
            // Src
            // 
            this.Src.ContextMenuStrip = this.SrcContext;
            this.Src.FormattingEnabled = true;
            this.Src.HorizontalScrollbar = true;
            this.Src.ItemHeight = 18;
            this.Src.Location = new System.Drawing.Point(170, 44);
            this.Src.Name = "Src";
            this.Src.Size = new System.Drawing.Size(145, 292);
            this.Src.TabIndex = 1;
            // 
            // SrcContext
            // 
            this.SrcContext.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.SrcContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.insertToolStripMenuItem});
            this.SrcContext.Name = "SrcContext";
            this.SrcContext.Size = new System.Drawing.Size(164, 64);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.renameToolStripMenuItem.Text = "Rename";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // Formula
            // 
            this.Formula.Location = new System.Drawing.Point(25, 484);
            this.Formula.Name = "Formula";
            this.Formula.Size = new System.Drawing.Size(433, 28);
            this.Formula.TabIndex = 3;
            // 
            // Result
            // 
            this.Result.FormattingEnabled = true;
            this.Result.HorizontalScrollbar = true;
            this.Result.ItemHeight = 18;
            this.Result.Location = new System.Drawing.Point(872, 44);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(205, 292);
            this.Result.TabIndex = 4;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(489, 470);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(124, 53);
            this.Calculate.TabIndex = 5;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(679, 470);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(144, 57);
            this.Export.TabIndex = 6;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(25, 44);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(113, 34);
            this.Import.TabIndex = 7;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(25, 103);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(113, 38);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // ClearAll
            // 
            this.ClearAll.Location = new System.Drawing.Point(25, 171);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(113, 33);
            this.ClearAll.TabIndex = 9;
            this.ClearAll.Text = "Clear All";
            this.ClearAll.UseVisualStyleBackColor = true;
            // 
            // RegexText
            // 
            this.RegexText.Location = new System.Drawing.Point(145, 394);
            this.RegexText.Name = "RegexText";
            this.RegexText.Size = new System.Drawing.Size(170, 28);
            this.RegexText.TabIndex = 11;
            this.RegexText.Text = "AT(\\d{1})G(\\d{5})";
            // 
            // SrcView
            // 
            this.SrcView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SrcView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dcpt});
            this.SrcView.Location = new System.Drawing.Point(349, 44);
            this.SrcView.MultiSelect = false;
            this.SrcView.Name = "SrcView";
            this.SrcView.RowHeadersVisible = false;
            this.SrcView.RowTemplate.Height = 30;
            this.SrcView.Size = new System.Drawing.Size(474, 292);
            this.SrcView.TabIndex = 12;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // dcpt
            // 
            this.dcpt.HeaderText = "Description";
            this.dcpt.Name = "dcpt";
            this.dcpt.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "RegEx:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(897, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 54);
            this.label2.TabIndex = 14;
            this.label2.Text = "交A^B\r\n差A-B\r\n并A+B";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 623);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SrcView);
            this.Controls.Add(this.RegexText);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Formula);
            this.Controls.Add(this.Src);
            this.Name = "Main";
            this.Text = "Elementary Calculator for MS";
            this.Load += new System.EventHandler(this.Main_Load);
            this.SrcContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SrcView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Src;
        private System.Windows.Forms.TextBox Formula;
        private System.Windows.Forms.ListBox Result;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.ContextMenuStrip SrcContext;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog importDialog;
        private System.Windows.Forms.SaveFileDialog exportDialog;
        private System.Windows.Forms.TextBox RegexText;
        private System.Windows.Forms.DataGridView SrcView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcpt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

