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
    public partial class FormList : Form
    {
        public FormList()
        {
            InitializeComponent();
            ShowKad();
            ShowSpec();
            ShowList();
        }

        void ShowKad()
        {
            comboBoxKad.Items.Clear();
            foreach (Student kad in Program.College.Student)
            {
                string[] item = { kad.id.ToString() + ".", kad.FirstName, kad.LastName,kad.MiddleName };
                comboBoxKad.Items.Add(string.Join(" ", item));
            }
        }

        void ShowSpec()
        {
            comboBoxSpec.Items.Clear();
            foreach (Specialty spec in Program.College.Specialty)
            {
                string[] item = { spec.id.ToString() + ".", spec.Specialty1 };
                comboBoxSpec.Items.Add(string.Join(" ", item));
            }
        }

        private void comboBoxSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxKad.SelectedItem != null && comboBoxSpec.SelectedItem != null)
            {
                ListStudents list = new ListStudents();

                list.idSpecialty = Convert.ToInt32(comboBoxSpec.SelectedItem.ToString().Split('.')[0]);
                list.idFirstName = Convert.ToInt32(comboBoxKad.SelectedItem.ToString().Split('.')[0]);

                Program.College.ListStudents.Add(list);
                Program.College.SaveChanges();
                ShowList();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void ShowList()
        {
            listViewList.Items.Clear();
            foreach (ListStudents list in Program.College.ListStudents)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        list.Student.FirstName+" "+list.Student.LastName+" "+list.Student.MiddleName,
                        list.Specialty.Specialty1,
                        list.Specialty.Groupp
                    });
                item.Tag = list;
                listViewList.Items.Add(item);
            }
            listViewList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewList.SelectedItems.Count == 1)
            {
                ListStudents list = listViewList.SelectedItems[0].Tag as ListStudents;

                comboBoxSpec.SelectedIndex = comboBoxSpec.FindString(list.idSpecialty.ToString());
                comboBoxKad.SelectedIndex = comboBoxKad.FindString(list.idFirstName.ToString());
            }
            else
            {
                comboBoxKad.SelectedItem = null;
                comboBoxSpec.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewList.SelectedItems.Count == 1)
                {
                    ListStudents list = listViewList.SelectedItems[0].Tag as ListStudents;
                    Program.College.ListStudents.Remove(list);
                    Program.College.SaveChanges();
                    ShowList();
                }
                comboBoxKad.SelectedItem = null;
                comboBoxSpec.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewList.SelectedItems.Count == 1 && comboBoxKad.SelectedItem != null && comboBoxSpec.SelectedItem != null)
            {
                ListStudents list = listViewList.SelectedItems[0].Tag as ListStudents;

                list.idSpecialty = Convert.ToInt32(comboBoxSpec.SelectedItem.ToString().Split('.')[0]);
                list.idFirstName = Convert.ToInt32(comboBoxKad.SelectedItem.ToString().Split('.')[0]);

                Program.College.SaveChanges();
                ShowList();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
