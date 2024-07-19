using Repositories.Entities;
using Services;

namespace BookManagement_HuyBuiHuaXuan
{
    public partial class BookManagerMainUI : Form
    {
        //backing field
        private Book _selected = null;
        public BookManagerMainUI()
        {
            InitializeComponent();
        }
        private BookService _service = new BookService();
        private void FillDataGridView()
        {
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = _service.GetAllBooks();
        }
        private void BookManagerMainUI_Load(object sender, EventArgs e) => FillDataGridView();
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes) { Application.Exit(); }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //goi man hinh detail len. Man hih nay ban chat la class BookDetailForm, khac truyen thong la no co phan render
            //No la 1 class nen no se co _field, prop, method nhu binh thuong
            //khai bao bien new nhu binh thuong
            //them phan render
            _selected = null;
            BookDetailForm f = new BookDetailForm();
            f.ShowDialog();
            FillDataGridView();
        }
        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            //nguoi dung co the chon 1 dong hay nhieu dong - chim chuot, cho nen ta se lay dong dau tien neu ng ta chon nhieu don
            if (dgvBookList.SelectedRows.Count > 0)
            {
                //neu chon it nhat 1 dong, thi cu dong dau tien dc chon la boc no ra, day qua form detail
                _selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem;


                //day sang FormDetail
                //khai bien, new , gan prop, show dialog
                //thang form detail: mo len, check selected khac null ko? khac NULL mode edit, show data dc gui sang

                //dua sach sang

            }//TODO: neu user chon cell?

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                BookDetailForm f = new BookDetailForm();
                f.SelectedBook = _selected;
                f.ShowDialog();
            }
            else
                MessageBox.Show("Please select one book to edit!", "Select one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            _selected = null;
            FillDataGridView();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var books = new BookService().GetAllBooks();
            dgvBookList.DataSource = null;

            {
                dgvBookList.DataSource = books.Where(x => x.BookName.ToLower().Contains(txtBookName.Text.ToLower()) || x.Description.ToLower().Contains(txtDescription.Text.ToLower())).ToList();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (_selected != null)
            {
                DialogResult message = MessageBox.Show("Do you really want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes) { _service.RemoveBookFromUI(_selected); }      
            }
            else
                MessageBox.Show("Please select one book to delete!", "Select one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            _selected = null;
            FillDataGridView();
        }
        private void dgvBookList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _selected = null;
        }
    }
}
