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
            this.inter = new System.Windows.Forms.Button();
            this.union = new System.Windows.Forms.Button();
            this.except = new System.Windows.Forms.Button();
            this.SrcContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SrcView)).BeginInit();
            this.SuspendLayout();
            // 
            // Src
            // 
            this.Src.FormattingEnabled = true;
            this.Src.HorizontalScrollbar = true;
            this.Src.ItemHeight = 24;
            this.Src.Location = new System.Drawing.Point(222, 40);
            this.Src.Margin = new System.Windows.Forms.Padding(4);
            this.Src.Name = "Src";
            this.Src.Size = new System.Drawing.Size(137, 388);
            this.Src.TabIndex = 1;
            this.Src.SelectedIndexChanged += new System.EventHandler(this.Src_SelectedIndexChanged);
            this.Src.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Src_MouseDown);
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
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // Formula
            // 
            this.Formula.Location = new System.Drawing.Point(303, 513);
            this.Formula.Margin = new System.Windows.Forms.Padding(4);
            this.Formula.Name = "Formula";
            this.Formula.Size = new System.Drawing.Size(528, 31);
            this.Formula.TabIndex = 3;
            // 
            // Result
            // 
            this.Result.FormattingEnabled = true;
            this.Result.HorizontalScrollbar = true;
            this.Result.ItemHeight = 24;
            this.Result.Location = new System.Drawing.Point(1011, 40);
            this.Result.Margin = new System.Windows.Forms.Padding(4);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(147, 388);
            this.Result.TabIndex = 4;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(860, 494);
            this.Calculate.Margin = new System.Windows.Forms.Padding(4);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(127, 50);
            this.Calculate.TabIndex = 5;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(1023, 494);
            this.Export.Margin = new System.Windows.Forms.Padding(4);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(135, 50);
            this.Export.TabIndex = 6;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(63, 91);
            this.Import.Margin = new System.Windows.Forms.Padding(4);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(116, 47);
            this.Import.TabIndex = 7;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(63, 246);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(116, 46);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ClearAll
            // 
            this.ClearAll.Location = new System.Drawing.Point(63, 331);
            this.ClearAll.Margin = new System.Windows.Forms.Padding(4);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(116, 44);
            this.ClearAll.TabIndex = 9;
            this.ClearAll.Text = "Clear All";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // RegexText
            // 
            this.RegexText.Location = new System.Drawing.Point(303, 458);
            this.RegexText.Margin = new System.Windows.Forms.Padding(4);
            this.RegexText.Name = "RegexText";
            this.RegexText.Size = new System.Drawing.Size(207, 31);
            this.RegexText.TabIndex = 11;
            this.RegexText.Text = "AT(\\d{1})G(\\d{5}\\.\\d{1})";
            // 
            // SrcView
            // 
            this.SrcView.AllowUserToAddRows = false;
            this.SrcView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SrcView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dcpt});
            this.SrcView.Location = new System.Drawing.Point(394, 39);
            this.SrcView.Margin = new System.Windows.Forms.Padding(4);
            this.SrcView.MultiSelect = false;
            this.SrcView.Name = "SrcView";
            this.SrcView.RowHeadersVisible = false;
            this.SrcView.RowTemplate.Height = 30;
            this.SrcView.Size = new System.Drawing.Size(579, 389);
            this.SrcView.TabIndex = 12;
            // 
            // ID
            // 
            this.ID.FillWeight = 34.72222F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // dcpt
            // 
            this.dcpt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcpt.FillWeight = 165.2778F;
            this.dcpt.HeaderText = "Description";
            this.dcpt.Name = "dcpt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 458);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "RegEx:";
            // 
            // inter
            // 
            this.inter.Location = new System.Drawing.Point(33, 440);
            this.inter.Name = "inter";
            this.inter.Size = new System.Drawing.Size(137, 42);
            this.inter.TabIndex = 15;
            this.inter.Text = "Intersect(&&)";
            this.inter.UseVisualStyleBackColor = true;
            this.inter.Click += new System.EventHandler(this.inter_Click);
            // 
            // union
            // 
            this.union.Location = new System.Drawing.Point(33, 501);
            this.union.Name = "union";
            this.union.Size = new System.Drawing.Size(137, 36);
            this.union.TabIndex = 16;
            this.union.Text = "Union(+)";
            this.union.UseVisualStyleBackColor = true;
            this.union.Click += new System.EventHandler(this.union_Click);
            // 
            // except
            // 
            this.except.Location = new System.Drawing.Point(33, 556);
            this.except.Name = "except";
            this.except.Size = new System.Drawing.Size(137, 39);
            this.except.TabIndex = 17;
            this.except.Text = "Except(-)";
            this.except.UseVisualStyleBackColor = true;
            this.except.Click += new System.EventHandler(this.except_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1203, 618);
            this.Controls.Add(this.except);
            this.Controls.Add(this.union);
            this.Controls.Add(this.inter);
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
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcpt;
        private System.Windows.Forms.Button inter;
        private System.Windows.Forms.Button union;
        private System.Windows.Forms.Button except;
    }
}

