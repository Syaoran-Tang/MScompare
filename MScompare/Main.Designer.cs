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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.ResultGroup = new System.Windows.Forms.GroupBox();
            this.result_num = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.src_num = new System.Windows.Forms.Label();
            this.ViewGroup = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rightbrac = new System.Windows.Forms.Button();
            this.leftbrac = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Save = new System.Windows.Forms.Button();
            this.helplink = new System.Windows.Forms.LinkLabel();
            this.import_bw = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadlabel = new System.Windows.Forms.Label();
            this.SrcContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SrcView)).BeginInit();
            this.ResultGroup.SuspendLayout();
            this.ViewGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Src
            // 
            resources.ApplyResources(this.Src, "Src");
            this.Src.FormattingEnabled = true;
            this.Src.Name = "Src";
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
            resources.ApplyResources(this.SrcContext, "SrcContext");
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            resources.ApplyResources(this.renameToolStripMenuItem, "renameToolStripMenuItem");
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            resources.ApplyResources(this.insertToolStripMenuItem, "insertToolStripMenuItem");
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // Formula
            // 
            resources.ApplyResources(this.Formula, "Formula");
            this.Formula.Name = "Formula";
            // 
            // Result
            // 
            resources.ApplyResources(this.Result, "Result");
            this.Result.FormattingEnabled = true;
            this.Result.Name = "Result";
            this.Result.SelectedIndexChanged += new System.EventHandler(this.Result_SelectedIndexChanged);
            this.Result.Leave += new System.EventHandler(this.Result_Leave);
            // 
            // Calculate
            // 
            resources.ApplyResources(this.Calculate, "Calculate");
            this.Calculate.Name = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Export
            // 
            resources.ApplyResources(this.Export, "Export");
            this.Export.Name = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Import
            // 
            resources.ApplyResources(this.Import, "Import");
            this.Import.Name = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Delete
            // 
            resources.ApplyResources(this.Delete, "Delete");
            this.Delete.Name = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ClearAll
            // 
            resources.ApplyResources(this.ClearAll, "ClearAll");
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // RegexText
            // 
            resources.ApplyResources(this.RegexText, "RegexText");
            this.RegexText.Name = "RegexText";
            // 
            // SrcView
            // 
            resources.ApplyResources(this.SrcView, "SrcView");
            this.SrcView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.SrcView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SrcView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dcpt});
            this.SrcView.Name = "SrcView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SrcView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SrcView.RowTemplate.Height = 30;
            this.SrcView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SrcView.ShowCellErrors = false;
            this.SrcView.ShowRowErrors = false;
            // 
            // ID
            // 
            this.ID.FillWeight = 34.72222F;
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            // 
            // dcpt
            // 
            this.dcpt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcpt.FillWeight = 165.2778F;
            resources.ApplyResources(this.dcpt, "dcpt");
            this.dcpt.Name = "dcpt";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // inter
            // 
            resources.ApplyResources(this.inter, "inter");
            this.inter.Name = "inter";
            this.inter.UseVisualStyleBackColor = true;
            this.inter.Click += new System.EventHandler(this.inter_Click);
            // 
            // union
            // 
            resources.ApplyResources(this.union, "union");
            this.union.Name = "union";
            this.union.UseVisualStyleBackColor = true;
            this.union.Click += new System.EventHandler(this.union_Click);
            // 
            // except
            // 
            resources.ApplyResources(this.except, "except");
            this.except.Name = "except";
            this.except.UseVisualStyleBackColor = true;
            this.except.Click += new System.EventHandler(this.except_Click);
            // 
            // ResultGroup
            // 
            resources.ApplyResources(this.ResultGroup, "ResultGroup");
            this.ResultGroup.Controls.Add(this.result_num);
            this.ResultGroup.Controls.Add(this.label2);
            this.ResultGroup.Controls.Add(this.Result);
            this.ResultGroup.Controls.Add(this.Export);
            this.ResultGroup.Name = "ResultGroup";
            this.ResultGroup.TabStop = false;
            // 
            // result_num
            // 
            resources.ApplyResources(this.result_num, "result_num");
            this.result_num.Name = "result_num";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // src_num
            // 
            resources.ApplyResources(this.src_num, "src_num");
            this.src_num.Name = "src_num";
            // 
            // ViewGroup
            // 
            resources.ApplyResources(this.ViewGroup, "ViewGroup");
            this.ViewGroup.Controls.Add(this.loadlabel);
            this.ViewGroup.Controls.Add(this.SrcView);
            this.ViewGroup.Controls.Add(this.src_num);
            this.ViewGroup.Controls.Add(this.Src);
            this.ViewGroup.Controls.Add(this.label3);
            this.ViewGroup.Controls.Add(this.splitter1);
            this.ViewGroup.Name = "ViewGroup";
            this.ViewGroup.TabStop = false;
            // 
            // splitter1
            // 
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.RegexText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Formula);
            this.groupBox1.Controls.Add(this.Calculate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rightbrac);
            this.groupBox2.Controls.Add(this.leftbrac);
            this.groupBox2.Controls.Add(this.inter);
            this.groupBox2.Controls.Add(this.union);
            this.groupBox2.Controls.Add(this.except);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // rightbrac
            // 
            resources.ApplyResources(this.rightbrac, "rightbrac");
            this.rightbrac.Name = "rightbrac";
            this.rightbrac.UseVisualStyleBackColor = true;
            this.rightbrac.Click += new System.EventHandler(this.rightbrac_Click);
            // 
            // leftbrac
            // 
            resources.ApplyResources(this.leftbrac, "leftbrac");
            this.leftbrac.Name = "leftbrac";
            this.leftbrac.UseVisualStyleBackColor = true;
            this.leftbrac.Click += new System.EventHandler(this.leftbrac_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Save);
            this.groupBox3.Controls.Add(this.Delete);
            this.groupBox3.Controls.Add(this.Import);
            this.groupBox3.Controls.Add(this.ClearAll);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // Save
            // 
            resources.ApplyResources(this.Save, "Save");
            this.Save.Name = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // helplink
            // 
            resources.ApplyResources(this.helplink, "helplink");
            this.helplink.Name = "helplink";
            this.helplink.TabStop = true;
            this.helplink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.helplink_LinkClicked);
            // 
            // import_bw
            // 
            this.import_bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.import_bw_DoWork);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // loadlabel
            // 
            resources.ApplyResources(this.loadlabel, "loadlabel");
            this.loadlabel.BackColor = System.Drawing.SystemColors.Window;
            this.loadlabel.Image = global::MScompare.Properties.Resources.load;
            this.loadlabel.Name = "loadlabel";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.helplink);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ViewGroup);
            this.Controls.Add(this.ResultGroup);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.SrcContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SrcView)).EndInit();
            this.ResultGroup.ResumeLayout(false);
            this.ResultGroup.PerformLayout();
            this.ViewGroup.ResumeLayout(false);
            this.ViewGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.GroupBox ResultGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label result_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label src_num;
        private System.Windows.Forms.GroupBox ViewGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button rightbrac;
        private System.Windows.Forms.Button leftbrac;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel helplink;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label loadlabel;
        private System.ComponentModel.BackgroundWorker import_bw;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

