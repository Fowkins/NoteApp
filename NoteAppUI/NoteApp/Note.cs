﻿using System;

namespace NoteApp
{
    /// <summary>
    /// Класс заметки, хранящий информацию о заголовке, категории, тексте и времени создания и изменении
    /// </summary>
    public class Note : ICloneable
    {
        private string _name;
        private Category _category;
        private string _text;
        private DateTime _timecreation;
        private DateTime _timelastchange;

        /// <summary>
        /// Возвращает и задает название заметки
        /// </summary>
        public string Name
        {
            get => _name;

            set
            {
                _name = value;
                if (_name.Length > 50)
                {
                    throw new ArgumentException("Длина названия не должна превышать 50 символов");
                }

                if (_name.Length == 0)
                {
                    _name = "Без названия";
                }
            }
        }

        /// <summary>
        /// Возвращает и задает категорию заметки
        /// </summary>
        public Category Category
        {
            get => _category;

            set => _category = value;
        }

        /// <summary>
        /// Возвращает и задает текст заметки
        /// </summary>
        public string Text
        {
            get => _text;

            set => _text = value;
        }

        /// <summary>
        /// Возвращает время создания заметки
        /// </summary>
        public DateTime TimeCreation { get; private set; }


        /// <summary>
        /// Возвращает время изменения заметки
        /// </summary>
        public DateTime TimeLastChange
        {
            get => _timelastchange;

            set => _timelastchange = value;
        }

        /// <summary>
        /// Создание заметки
        /// </summary>
        public Note(string name,Category category,string text, DateTime timecreation)
        {
            Name = name;
            Category = category;
            Text = text;
            TimeCreation = timecreation;
        }

        /// <summary>
        /// Клонирование заметки
        /// </summary>
        public object Clone()
        {
            return new Note(this.Name, this.Category, this.Text, this.TimeCreation)
            {
                TimeLastChange = this.TimeLastChange
            };
        }
    }
}
