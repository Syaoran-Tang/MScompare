using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
//Using PDFBox.net to read pdf file.
//The .dll package is downloaded from http://www.antoniob.com/pdfbox-121-for-net-binaries.html

namespace MScompare
{
    public partial class Main : Form
    {
        public class MSset
        { 
            public class Item
            {
                public String name;
                public String dcpt;

                public Item(String n,String d)
                {
                    name = n;
                    dcpt = d;
                }
            }
            public String Name;
            public List<Item> Content;
            public List<String> Index;

            public MSset()
            {
                Name = "";
                Content = new List<Item>();
                Index = new List<String>();
            }
            public void clear()
            {
                Content = new List<Item>();
                Index = new List<String>();
            }
            public void readFile(String FilePath,String regexstr)
            {
                Name = Path.GetFileNameWithoutExtension(FilePath);
                String FileType = Path.GetExtension(FilePath);
                if (FileType == ".txt")
                {
                    StreamReader sr = new StreamReader(FilePath, Encoding.Default);
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Match mat = Regex.Match(line, regexstr);
                        String id = mat.Value;
                        if (id.Length > 0)
                        {
                            if (!Index.Contains(id))
                            {
                                String cont = line.Replace(id, "$");
                                Item item = new Item(id, cont);
                                Content.Add(item);
                                Index.Add(id);
                            }
                        }
                    }
                }
                else if (FileType == ".pdf")
                {
                    PDDocument pdf = PDDocument.load(FilePath);
                    PDFTextStripper pdfStripper = new PDFTextStripper();
                    String[] all_text = pdfStripper.getText(pdf).Replace("\r\n", "\\"). Split('\\');
                    foreach (String line in all_text)
                    {
                        Match mat = Regex.Match(line, regexstr);
                        String id = mat.Value;
                        if (id.Length > 0)
                        {
                            if (!Index.Contains(id))
                            {
                                String cont = line.Replace(id, "$");
                                Item item = new Item(id, cont);
                                Content.Add(item);
                                Index.Add(id);
                            }
                        }
                    }
                }
            }
        }
        public List<MSset> SRC;
        public List<String> AnsList;
        public MSset curMSset;
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            SRC = new List<MSset>();
            AnsList = new List<String>();
            import_bw.DoWork += new DoWorkEventHandler(import_bw_DoWork);
            import_bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(import_bw_CompletedWork);
            SrcView.AllowUserToAddRows = false;
        }
        private void Import_Click(object sender, EventArgs e)
        {
            this.importDialog.Filter = "ASCII File(*.txt)|*.txt|PDF File(*.pdf)|*.pdf";
            if (this.importDialog.ShowDialog() == DialogResult.OK)
            {
                Import.Enabled = Save.Enabled = Delete.Enabled = ClearAll.Enabled = SrcView.Enabled = Src.Enabled = false;
                loadlabel.Visible = true;
                import_bw.RunWorkerAsync(this);
            }
        }

        private void Src_SelectedIndexChanged(object sender, EventArgs e)
        {   
            int index = Src.SelectedIndex;
            if (index >= 0)
            {
                SrcView.Rows.Clear();
                foreach (MSset.Item line in SRC[index].Content)
                {
                    int i = SrcView.Rows.Add();
                    SrcView.Rows[i].Cells[0].Value = line.name;
                    SrcView.Rows[i].Cells[1].Value = line.dcpt;
                }
                SrcView.AllowUserToAddRows = true;
                SrcView_refresh();

                src_num.Text = SRC[index].Content.Count().ToString();
            }
            else
                src_num.Text = "";
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Sure to clear all?", "WARNING", messButton, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                SrcView.Rows.Clear();
                Src.Items.Clear();
                SRC = new List<MSset>();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int index = Src.SelectedIndex;
            if (index<0)
            {
                MessageBox.Show("Please select a item in list first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Src.Items.RemoveAt(index);
                SrcView.Rows.Clear();
                if (index < SRC.Count() - 1)
                {
                    SRC.RemoveAt(index);
                    for (int i = index; i < SRC.Count(); i++)
                    {
                        Src.Items[i] = "#" + i.ToString() + "_" + SRC[i].Name + "#";
                    }
                }
                else
                    SRC.RemoveAt(index);
                SrcView_refresh();
            }
        }

        private void Src_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = Src.SelectedIndex;
                if (index >= 0)
                    SrcContext.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = Src.SelectedIndex;
            Rename RNform = new Rename(this);
            RNform.rn_input.Text = SRC[index].Name;
            RNform.Show();
            this.Enabled = false;
        }
        public void newname(String newname)
        {
            int i = Src.SelectedIndex;
            SRC[i].Name = newname;
            Src.Items[i] = "#" + i.ToString() + "_" + SRC[i].Name + "#";
        }
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Text += Src.SelectedItem.ToString();
        }
        private void Calculate_Click(object sender, EventArgs e)
        {
            RPN calcu = new RPN(Formula.Text, SRC);
            AnsList=calcu.Evaluate();
            foreach (String ans in AnsList)
            {
                Result.Items.Add(ans);
            }
            result_num.Text = AnsList.Count().ToString();
        }

        private void inter_Click(object sender, EventArgs e)
        {
            if (Formula.SelectionStart < 1)
                Formula.Text += @"&";
            else
                Formula.Paste(@"&");
        }

        private void union_Click(object sender, EventArgs e)
        {
            if (Formula.SelectionStart < 1)
                Formula.Text += @"+";
            else
                Formula.Paste(@"+");
        }

        private void except_Click(object sender, EventArgs e)
        {
            if (Formula.SelectionStart<1)
                Formula.Text += @"-";
            else
                Formula.Paste(@"-");
        }
        private void leftbrac_Click(object sender, EventArgs e)
        {
            if (Formula.SelectionStart < 1)
                Formula.Text += @"(";
            else
                Formula.Paste(@"(");
        }
        private void rightbrac_Click(object sender, EventArgs e)
        {
            if (Formula.SelectionStart < 1)
                Formula.Text += @")";
            else
                Formula.Paste(@")");
        }
        private void Export_Click(object sender, EventArgs e)
        {
            this.exportDialog.Filter = "ASCII File(*.txt)|*.txt";
            if (this.exportDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(exportDialog.FileName, true);
                foreach (String re in Result.Items)
                    sw.WriteLine(re);
                sw.Close();
                MessageBox.Show("Save successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void helplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/Syaoran-Tang/MScompare");  
        }

        private void SrcView_refresh()
        {
            for (int i = 0; i < this.SrcView.Rows.Count-1; i++)
            {
                SrcView.Rows[i].HeaderCell.Value = (i + 1).ToString();
                SrcView.Rows[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            SrcView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            int index = Src.SelectedIndex;
            if (index >= 0)
            {
                SRC[index].clear();
                for (int i = 0; i < this.SrcView.Rows.Count - 1; i++)
                {
                    String temp_name = SrcView.Rows[i].Cells[0].Value.ToString();
                    String temp_dcpt = SrcView.Rows[i].Cells[1].Value.ToString();
                    MSset.Item temp = new MSset.Item(temp_name, temp_dcpt);
                    SRC[index].Content.Add(temp);
                    SRC[index].Index.Add(temp_name);
                }
                MessageBox.Show("Save successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SrcView_refresh();
            }
        }

        private void import_bw_DoWork(object sender, DoWorkEventArgs e)
        {
            curMSset = new MSset();
            curMSset.readFile(importDialog.FileName, RegexText.Text);
            
        }
        private void import_bw_CompletedWork(object sender, RunWorkerCompletedEventArgs e)
        {
            SRC.Add(curMSset);
            int num = SRC.Count()-1;
            String ShowName = "#" + num.ToString() + "_" + curMSset.Name + "#";
            Src.Items.Add(ShowName);
            Src.SelectedIndex = Src.Items.Count - 1;

            foreach (MSset.Item line in curMSset.Content)
            {
                int index = SrcView.Rows.Add();
                SrcView.Rows[index].Cells[0].Value = line.name;
                SrcView.Rows[index].Cells[1].Value = line.dcpt;
            }
            SrcView_refresh();
            Import.Enabled = Save.Enabled = Delete.Enabled = ClearAll.Enabled = SrcView.Enabled = Src.Enabled = true;
            loadlabel.Visible = false;
        }
    }
}
