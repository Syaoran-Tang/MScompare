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

            public MSset()
            {
                Name = "";
                Content = new List<Item>();
            }
            public void readFile(String FilePath,String regexstr)
            {
                Name = Path.GetFileNameWithoutExtension(FilePath);
                StreamReader sr = new StreamReader(FilePath, Encoding.Default);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    Match mat = Regex.Match(line, regexstr);
                    String id = mat.Value;
                    Item item = new Item(id, line);
                    Content.Add(item);
                }
            }
        }
        public List<MSset> SRC;
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            SRC = new List<MSset>();

        }
        private void Import_Click(object sender, EventArgs e)
        {
            this.importDialog.Filter = "ASCII File(*.txt)|*.txt";
            if (this.importDialog.ShowDialog() == DialogResult.OK)
            {
                MSset curMSset = new MSset();
                curMSset.readFile(importDialog.FileName, RegexText.Text);
                Src.Items.Add(curMSset.Name);
                SRC.Add(curMSset);

                foreach (MSset.Item line in curMSset.Content)
                {
                    int index = SrcView.Rows.Add();
                    SrcView.Rows[index].Cells[0].Value = line.name;
                    SrcView.Rows[index].Cells[1].Value = line.dcpt;
                }
            }
        }
    }
}
