﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Project p=new Project();
            Note[] note = new Note[5];
            for (int i = 0; i < 5; i++)
            {
                note[i]=new Note("1"+i,Category.Work,"aaaa",DateTime.Today);
                p._glossary.Add(note[i]);
            }
        }
    }
}
