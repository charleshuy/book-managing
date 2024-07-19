using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_HuyBuiHuaXuan
{
    public partial class BookDetailForm : Form
    {
        private BookService bookService = new();
        //vi BookDetailForm cung la 1 class nen no co prop nhu bt. Hon bt o cho la no la class co the render (daddy class Form cua SDK se lo phan render - quan he ke thua)
        public Book SelectedBook { get; set; } = null;
        //mac dich form nay mo len thi ko co book nao ca 
        //neu muon co book thi phai .SelectedBook = cuon muon gan vao

        public BookDetailForm()
        {
            InitializeComponent();
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            //MO MAN HINH DETAIL THI TA SE
            //1. FILL DAY CATEGORY DROPDOWN - LAY DU LIEU TU TABLE CATEGORY
            //2. NEU LA EDIT 1 CUAN SACH THI FILL DATA CUA CUON SACH MUON EDIT VAO CAC O TUONG UNG
            //3. NEU LA TAO MOI THI KO LAM GI NUA

            BookCategoryService cat = new BookCategoryService();
            //do full data vao cbo
            cboBookCategoryId.DataSource = cat.GetAllCategories();
            //chon cot de hien thi tren cbo
            cboBookCategoryId.DisplayMember = "BookGenreType";
            //chon code de lay value thuc su can dung - what you see is not what you get, 
            //chon Self Helf de cho user nhung dev phai map sang valye 5 cua cot BookCategoryId, dung lam FK day vao table book
            cboBookCategoryId.ValueMember = "BookCategoryId";
            //vi dieu: nhay den gia tri bat ki nao minh thich trong cbo
            //mac dinh la dau danh sach xo 1
            cboBookCategoryId.SelectedValue = 1;

            //  CHECK HANG CO PHAI EDIT HAY KO
            //CHECK BIEN SELECTEDBOOK COI CO != NULL KO
            //NEU CO SACH THI FIL VAO CAC O
            if (SelectedBook != null)
            {
                txtBookId.Text = SelectedBook.BookId.ToString();
                txtBookName.Text = SelectedBook.BookName;
                txtDescription.Text = SelectedBook.Description;
                dtpPublicationDate.Value = SelectedBook.PublicationDate;
                txtQuantity.Text = SelectedBook.Quantity.ToString();
                txtPrice.Text = SelectedBook.Price.ToString();
                txtAuthor.Text = SelectedBook.Author;
                cboBookCategoryId.SelectedValue = SelectedBook.BookCategoryId;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                BookId = int.Parse(txtBookId.Text),
                BookName = txtBookName.Text,
                Description = txtDescription.Text,
                PublicationDate = dtpPublicationDate.Value,
                Quantity = int.Parse(txtQuantity.Text),
                Price = double.Parse(txtPrice.Text),
                Author = txtAuthor.Text,
                BookCategoryId = int.Parse(cboBookCategoryId.SelectedValue.ToString()),
            };   
            //new 1 cuon sach voi cac info lay tu o text
            if (SelectedBook == null)   
                bookService.AddBookFromUI(book);
            else bookService.UpgradeBookfromUI(book);
            this.Close();
        }
    }
}
