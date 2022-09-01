using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n_01419012_Project1
{
    public partial class FormManage : Form
    {
        public FormManage()
        {
            InitializeComponent();
        }
        private void FormManage_Load(object sender, EventArgs e)
        {
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            if (conn.connect())
            {
                if(!string.IsNullOrWhiteSpace(txtISBN.Text) && !string.IsNullOrWhiteSpace(txtTitle.Text) && !string.IsNullOrWhiteSpace(txtAuthor3.Text) && !string.IsNullOrWhiteSpace(txtCategory.Text) && !string.IsNullOrWhiteSpace(txtPublisher.Text))
                {
                    conn.add(int.Parse(txtISBN.Text), txtTitle.Text, txtAuthor3.Text, txtCategory.Text, "available", txtPublisher.Text, string.Format(timePickerDate.Text));
                    MessageBox.Show($"The new book was added to the list");
                }
                else
                {
                    MessageBox.Show("You need to fill in all the fields.");
                }      
            }
            conn.close();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            if (conn.connect())
            {
                if (!string.IsNullOrWhiteSpace(txtISBN.Text))
                    {
                    Book book = conn.find(int.Parse(txtISBN.Text));
                    conn.close();
                    txtTextArea.Items.Add(book);
                } else
                    MessageBox.Show("The field is enpty. You need to enter the ISBN .");
            }
        }
        private void btnReserve_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            if (conn.connect())
            {
                if (rdbNotAvailable.Checked && (!string.IsNullOrWhiteSpace(txtISBN.Text)))
                {
                    conn.reserve(int.Parse(txtISBN.Text), "not available");
                    MessageBox.Show($"You have reserved the book.");
                }         
                else if (rdbAvailable.Checked && (!string.IsNullOrWhiteSpace(txtISBN.Text)))
                {
                    conn.reserve(int.Parse(txtISBN.Text), "available");
                    MessageBox.Show($"You have removed the reserve from the book.");
                }
                else
                    MessageBox.Show("Please select the Status or enter the ISBN");     
            }
            conn.close();
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            if (conn.connect())
            {
                List<Book> books = conn.displayAll();
                conn.close();
                foreach (var item in books)
                {
                    txtTextArea.Items.Add(item.ToString());
                }
            }
        }
        private void timePickerDate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txtTextArea_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            if (conn.connect())
            {
                conn.remove(int.Parse(txtISBN.Text));
                MessageBox.Show($"The book was removed from the list");
            }
            conn.close();
        }

        private void btbClear_Click(object sender, EventArgs e)
        {
            txtISBN.Clear();
            txtAuthor3.Clear();
            txtTitle.Clear();
            txtPublisher.Clear();
            txtCategory.Clear();
        }
    }
}
