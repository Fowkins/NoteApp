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
    public partial class MainForm : Form
    {
        //public static string _filePath;
        //public static string _fileName = "json.txt";
        public MainForm()
        {
            InitializeComponent();
            CategorysComboBox.Items.Add("All");

            foreach (Category element in Enum.GetValues(typeof(Category)))
            {
                CategorysComboBox.Items.Add(element);
            }

            try
            {
                allNotes = ProjectManager.LoadFromFile(); //загрузка списка заметок
            }
            catch (Exception e)
            {
                ProjectManager.SaveToFile(allNotes);
            }

            CategorysComboBox.SelectedIndex = 0; //по умолчанию 1 категория 

            if (allNotes._currentNote != -1 && allNotes._currentNote < TitlesListBox.Items.Count)
            {
                TitlesListBox.SelectedIndex = allNotes._currentNote;
            }
            else
            {
                splitContainerNote.Panel2.Visible = false;
            }
        }
        Project allNotes = new Project();   //список свех заметок

        List<Note> sortNotes = new List<Note>();

        private void CategorysComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FillListbox();
        }

        private void TitlesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //завершение метода если элемент не выбран
            if (TitlesListBox.SelectedIndex == -1)
            {
                return;
            }

            allNotes._currentNote = allNotes.RealIndexes[TitlesListBox.SelectedIndex];

            ProjectManager.SaveToFile(allNotes);

            ClearRigthPanel();

            splitContainerNote.Panel2.Visible = true;

            sortNotes = allNotes.SortWithSelectionCategory(CategorysComboBox.SelectedIndex);

            //заполняем данными правую часть окна
            TitleTextBox.Text = sortNotes[TitlesListBox.SelectedIndex].Name;

            CategoryTextBox.Text = "Category: " + sortNotes[TitlesListBox.SelectedIndex].Category;

            CreateDateTimePicker.Value = sortNotes[TitlesListBox.SelectedIndex].TimeCreation;

            ChangeDateTimePicker.Value = sortNotes[TitlesListBox.SelectedIndex].TimeCreation;

            NoteTextBox.Text = sortNotes[TitlesListBox.SelectedIndex].Text;
        }

        private void ChangeButton_Click_1(object sender, EventArgs e)
        {
            ChangeNote();
        }

        private void NewButton_Click_1(object sender, EventArgs e)
        {
            CreateNote();
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            DeleteNote();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void addNoteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CreateNote();
        }

        private void editNoteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChangeNote();
        }

        private void removeNoteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DeleteNote();
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var about = new About(); //создаем форму

            about.ShowDialog();
        }

        //Очищает элементы правой панели
        private void ClearRigthPanel()
        {
            CategoryTextBox.Clear();

            TitleTextBox.Clear();

            NoteTextBox.Clear();
        }

        //заполнет TitleListBox заголовками заметок
        private void FillListbox()
        {
            //проверка на null(если заметок еще нет)
            if (allNotes != null)
            {
                TitlesListBox.Items.Clear();

                sortNotes = allNotes.SortWithSelectionCategory(CategorysComboBox.SelectedIndex);

                {
                    for (int i = 0; i < sortNotes.Count; i++)
                    {
                        TitlesListBox.Items.Add(sortNotes[i].Name);

                    }
                }
            }
        }

        //создание заметки
        private void CreateNote()
        {
            //получаем выбранную заметку
            Note newNote = new Note(string.Empty, Category.Work, string.Empty, DateTime.Now); //сама заметка

            newNote.TimeLastChange = DateTime.Now;

            var inner = new NoteForm(); //создаем форму

            inner.Note = newNote; //передаем форме данные

            //если было нажато Cancel завершаем выполнение обработчика
            if (inner.ShowDialog() == DialogResult.OK)
            {
                var updatedNote = inner.Note; //забираем измененные данные

                //добавляем новую заметку в список
                allNotes.Glossary.Add(updatedNote);

                var changeTitle = updatedNote.Name;

                FillListbox();

                TitlesListBox.SelectedItem = changeTitle;

                ProjectManager.SaveToFile(allNotes);
            }
        }

        //изменение заметки
        private void ChangeNote()
        {
            //если заметка не выбрана завершаем выполнение обработчика(ничего не происходит при нажатии на "Изменить")
            if (TitlesListBox.SelectedIndex == -1)
            {
                return;
            }

            //получаем выбранную заметку
            var selectedIndex = TitlesListBox.SelectedIndex; //индекс нашей заметки в списке всех заметок allNotes

            var selectedNote = sortNotes[selectedIndex]; //сама заметка

            var inner = new NoteForm(); //создаем форму

            inner.Note = selectedNote; //передаем форме данные

            //если было нажато Cancel завершаем выполнение обработчика
            if (inner.ShowDialog() == DialogResult.OK)
            {
                var updatedNote = inner.Note; //забираем измененные данные

                //удалить и заменить старые данные
                allNotes.Glossary.RemoveAt(allNotes.RealIndexes[selectedIndex]);

                allNotes.Glossary.Add(updatedNote);

                FillListbox();

                var changeTitle = updatedNote.Name;

                TitlesListBox.SelectedItem = changeTitle;

                ProjectManager.SaveToFile(allNotes);
            }
        }

        //удаление заметки
        private void DeleteNote()
        {
            //если заметка не выбрана завершаем выполнение обработчика(ничего не происходит при нажатии на "Удалить")
            if (TitlesListBox.SelectedIndex == -1)
            {
                return;
            }

            if (MessageBox.Show("Вы уверены что хотите удалить заметку?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //получаем выбранную заметку
                var selectedIndex = TitlesListBox.SelectedIndex; //индекс нашей заметки в списке всех заметок allNotes

                TitlesListBox.Items.RemoveAt(selectedIndex);

                allNotes.Glossary.RemoveAt(allNotes.RealIndexes[selectedIndex]);

                allNotes._currentNote = -1;

                FillListbox();

                ClearRigthPanel();

                splitContainerNote.Panel2.Visible = false;

                ProjectManager.SaveToFile(allNotes);
            }
        }

        //private void MainForm_Load(object sender, EventArgs e)
        //{
        //    _filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //    Project p=new Project();
        //    Note[] note = new Note[5];
        //    for (int i = 0; i < 2; i++)
        //    {
        //        note[i]=new Note("1"+i,Category.Work,"aaaa",DateTime.Today);
        //        p.Glossary.Add(note[i]);
        //    }
        //    ProjectManager.SaveToFile(p, _filePath + @"\" + _fileName);

        //    p = null;

        //    p = ProjectManager.LoadFromFile(_filePath + @"\" + _fileName);

        //}

    }
}
