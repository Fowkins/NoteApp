using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class NoteForm : Form
    {
        private Note _note;

        public Note Note
        {
            get { return _note; }
            set
            {
                _note = value;
                if (_note != null)
                {
                    TitleTextBox.Text = _note.Name; //при отправлении заметки в это окно, автоматом заполнятся компоненты формы

                    CategorysComboBox.SelectedItem = _note.Category;

                    CreateDateTimePicker.Value = _note.TimeCreation;

                    ChangeDateTimePicker.Value = _note.TimeLastChange;

                    NoteTextBox.Text = _note.Text;
                }
            }
        }

        public NoteForm()
        {
            InitializeComponent();

            foreach (Category element in Enum.GetValues(typeof(Category)))
            {
                CategorysComboBox.Items.Add(element);
            }
        }

        private bool CheckTitle
        {
            get
            {
                if (TitleTextBox.Text == string.Empty)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private bool CheckText
        {
            get
            {
                if (NoteTextBox.Text == string.Empty)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private bool CheckCategory
        {
            get
            {
                if (CategorysComboBox.SelectedIndex == -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void OkButton_Click_1(object sender, EventArgs e)
        {
            if (CheckTitle || CheckText || CheckCategory)
            {
                MessageBox.Show("Введите название,текст и категорию");
            }
            else
            {
                _note.TimeLastChange = DateTime.Now; // Изменение даты редактирования

                _note.Name = TitleTextBox.Text;

                _note.Text = NoteTextBox.Text;

                var selectedIndex = CategorysComboBox.SelectedIndex;

                _note.Category = (Category)CategorysComboBox.Items[selectedIndex];

                DialogResult = DialogResult.OK;

                this.Close();
            }
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            this.Close();
        }


    }
}
