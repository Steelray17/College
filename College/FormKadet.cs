using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College
{
    public partial class FormKadet : Form
    {
        public FormKadet()
        {
            InitializeComponent();
            ShowKad();
        }

        private void FormKadet_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxLastName.Text != ""  && textBoxFirstName.Text != "" && textBoxMidName.Text != "" && textBoxAge.Text != "" && textBoxPhone.Text != "" && textBoxEmail.Text != "")
            {

                Student kad = new Student();
                kad.LastName = textBoxLastName.Text;
                kad.FirstName = textBoxFirstName.Text;
                kad.MiddleName = textBoxMidName.Text;
                kad.Age = textBoxAge.Text;
                kad.Phone = textBoxPhone.Text;
                kad.Email = textBoxEmail.Text;
                Program.College.Student.Add(kad);
                Program.College.SaveChanges();
                ShowKad();
            }
            else MessageBox.Show("Введены не все данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void ShowKad()
        {
            listViewKadet.Items.Clear();
            foreach (Student kad in Program.College.Student)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        kad.FirstName,
                        kad.LastName,
                        kad.MiddleName,
                        kad.Age,
                        kad.Phone,
                        kad.Email
                    });
                item.Tag = kad;
                listViewKadet.Items.Add(item);
            }
            listViewKadet.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
                if (listViewKadet.SelectedItems.Count == 1 && textBoxLastName.Text != "" && textBoxFirstName.Text != "" && textBoxMidName.Text != "" && textBoxAge.Text != "" && textBoxPhone.Text != "" && textBoxEmail.Text != "")
                {
                    Student kad = listViewKadet.SelectedItems[0].Tag as Student;
                    kad.LastName = textBoxLastName.Text;
                    kad.FirstName = textBoxFirstName.Text;
                    kad.MiddleName = textBoxMidName.Text;
                    kad.Age = textBoxAge.Text;
                    kad.Phone = textBoxPhone.Text;
                    kad.Email = textBoxEmail.Text;
                    Program.College.SaveChanges();
                    ShowKad();
                }
            else MessageBox.Show("Введены не все данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try 
            {
                if (listViewKadet.SelectedItems.Count == 1)
                {
                    Student kad = listViewKadet.SelectedItems[0].Tag as Student;
                    Program.College.Student.Remove(kad);
                    Program.College.SaveChanges();
                    ShowKad();
                }
                textBoxLastName.Text = "";
                textBoxFirstName.Text = "";
                textBoxMidName.Text = "";
                textBoxAge.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewKadet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewKadet.SelectedItems.Count == 1)
            {
                Student kad = listViewKadet.SelectedItems[0].Tag as Student;
                textBoxLastName.Text = kad.LastName;
                textBoxFirstName.Text = kad.FirstName;
                textBoxMidName.Text = kad.MiddleName;
                textBoxAge.Text = kad.Age;
                textBoxPhone.Text = kad.Phone;
                textBoxEmail.Text = kad.Email;
            }
            else
            {
                textBoxLastName.Text = "";
                textBoxFirstName.Text = "";
                textBoxMidName.Text = "";
                textBoxAge.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }
    }
}
