using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBook
{
    public partial class Form1 : Form
    {
        NonStaticData dataNonStatic = new NonStaticData();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // static 
            listBox1.Items.Clear();
            listBox1.DataSource = StaticData.Books();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear(); // clear the listbox
            listBox1.DataSource = null; // clear the listbox
            var books = dataNonStatic.Books(); // get the books  
            listBox1.DataSource = books; // bind the books to the listbox
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // Add Non static

            Book book = new Book();
            book.ID = int.Parse(textBox1.Text);
            book.Name = textBox2.Text;


            NonStaticData dataNonStatic = new NonStaticData();
            listBox1.DataSource = null; // verwijder de huidige gegevensbron
            dataNonStatic.BooksCollection.Add(book); // voeg het nieuwe boek toe aan de lijst
            
            var books = dataNonStatic.Books(); // haal de boeken op
            listBox1.DataSource = books; // stel de nieuwe gegevensbron in
            listBox1.Refresh(); // vernieuw de ListBox om de nieuwe gegevens weer te geven
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Add Static
            // Maak een nieuw boek aan en voeg het toe aan de lijst
            Book book = new Book(); 
            book.ID = int.Parse(textBox1.Text);
            book.Name = textBox2.Text;
            StaticData.BooksCollection.Add(book);

            // Haal de boeken rechtstreeks op uit de collectie
            var books = StaticData.BooksCollection;

            // Vernieuw de ListBox met de bijgewerkte gegevens
            listBox1.DataSource = null;
            listBox1.DataSource = books;

        }
    }
}
