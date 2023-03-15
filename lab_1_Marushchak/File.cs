using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1_Marushchak
{
    internal class File
    {
        string name; // Закриті поля
        DateTime createdDate;
        int length; //
        
        public string Name // Властивості
        {
            get => name;
            set => name = value;
        }

        public DateTime CreatedDate
        {
            get => createdDate;
            set => createdDate = value;
        }

        public int Length
        {
            get => length;
            set => length = value;
        } //

        public File() // непараметризований конструктор
        {
            name = string.Empty;
            createdDate = DateTime.MinValue;
            length = 0;
        }

        public File(string name, DateTime createdDate, int length) // параметризований конструктор
        {
           this.name = name;
           this.createdDate = CreatedDate;
           this.length = length;
        }
        
        public void Print(TextBox textBox) // Вивід інформацію в textBox
        {
            textBox.Text += string.Format("\r\nНазва файлу: {0}; Дата створення файлу: {1}; Довжина файлу: {2}; \n", name, createdDate, length);
        }

        public void Add(TextBox name, DateTimePicker createdDate, TextBox length) // Зчитування з textBox i DateTimePicker
        {
            this.name = Convert.ToString(name.Text);
            this.createdDate = createdDate.Value;
            this.length = Convert.ToInt32(length.Text);

        }


    }
}
