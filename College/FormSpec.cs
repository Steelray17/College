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
    public partial class FormSpec : Form
    {
        public FormSpec()
        {
            InitializeComponent();
            textBoxGroup.ReadOnly = true;
            Showlist();
        }


        private void comboBoxSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSpec.SelectedIndex == 0)
            {
                listViewSpec.Visible = true;
                labelSpec.Visible = true;
                labelGroup.Visible = true;
                textBoxGroup.Visible = true;

                
                textBoxGroup.Text = "ПД";
            }
            else if (comboBoxSpec.SelectedIndex == 1)
            {
                listViewSpec.Visible = true;
                labelSpec.Visible = true;
                labelGroup.Visible = true;
                textBoxGroup.Visible = true;

                
                textBoxGroup.Text = "МЧС";
            }
            else if (comboBoxSpec.SelectedIndex == 2)
            {
                listViewSpec.Visible = true;
                labelSpec.Visible = true;
                labelGroup.Visible = true;
                textBoxGroup.Visible = true;


                textBoxGroup.Text = "ЮР";
            }
            else if (comboBoxSpec.SelectedIndex == 3)
            {
                listViewSpec.Visible = true;
                labelSpec.Visible = true;
                labelGroup.Visible = true;
                textBoxGroup.Visible = true;


                textBoxGroup.Text = "Тех";
            }
        }

        private void listViewSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSpec.SelectedItems.Count == 1)
            {
                Specialty spec = listViewSpec.SelectedItems[0].Tag as Specialty;

                comboBoxSpec.Text = spec.Specialty1;
                textBoxGroup.Text = spec.Groupp;
            }
            else 
            {
                textBoxGroup.Text = "";
                comboBoxSpec.SelectedItem = null;
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxSpec.SelectedItem != null)
            {
                Specialty spec = new Specialty();
                spec.Specialty1 = comboBoxSpec.Text;
                spec.Groupp = textBoxGroup.Text;
                Program.College.Specialty.Add(spec);
                Program.College.SaveChanges();
                Showlist();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void Showlist()
        {
            listViewSpec.Items.Clear();
            foreach (Specialty spec in Program.College.Specialty)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        spec.Specialty1,
                        spec.Groupp,
                    });
                item.Tag = spec;
                listViewSpec.Items.Add(item);
            }
            listViewSpec.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(listViewSpec.SelectedItems.Count == 1 && comboBoxSpec.SelectedItem != null)
                {
                Specialty spec = listViewSpec.SelectedItems[0].Tag as Specialty;
                spec.Specialty1 = comboBoxSpec.Text;
                spec.Groupp = textBoxGroup.Text;
                Program.College.SaveChanges();
                Showlist();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSpec.SelectedItems.Count == 1 )
                {
                    Specialty spec = listViewSpec.SelectedItems[0].Tag as Specialty;
                    Program.College.Specialty.Remove(spec);
                    Program.College.SaveChanges();
                    Showlist();
                }
                textBoxGroup.Text = "";
                comboBoxSpec.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
