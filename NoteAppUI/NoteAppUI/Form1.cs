using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class Form1 : Form
    {
        public static string _filePath;
        public static string _fileName = "json.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Project p=new Project();
            Note[] note = new Note[5];
            for (int i = 0; i < 5; i++)
            {
                note[i]=new Note("1"+i,Category.Work,"aaaa",DateTime.Today);
                p._glossary.Add(note[i]);
            }
            ProjectManager.SaveToFile(p, _filePath + @"\" + _fileName);

            p = null;

            p = ProjectManager.LoadFromFile(_filePath + @"\" + _fileName);
        }
    }
}
