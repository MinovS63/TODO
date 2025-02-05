using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODO
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {
            listBoxTasks.Items.Clear();

            for (int i = 0; i < Main.tasks.Count; i++)
            {
                listBoxTasks.Items.Add($"{i + 1}. {Main.tasks[i]}");
            }
            typeNlabel.Visible = false;
            nToDel.Visible = false;
            btnSubmDel.Visible = false;
        }

        private void btnDelTask_Click(object sender, EventArgs e)
        {
            if (Main.tasks.Count == 0)
            {
                MessageBox.Show("No tasks to delete...");
            }
            else if (Main.tasks.Count >= 1)
            {
                typeNlabel.Visible = true;
                nToDel.Visible = true;
                btnSubmDel.Visible = true;
            }
        }

        private void btnSubmDel_Click(object sender, EventArgs e)
        {
            try
            {
                int delElement = Convert.ToInt32(nToDel.Text);
                if (delElement > Main.tasks.Count || delElement < 0)
                {
                    MessageBox.Show("Invalid element... Try again.");
                    nToDel.Clear();
                    typeNlabel.Visible = false;
                    nToDel.Visible = false;
                    btnSubmDel.Visible = false;
                }
                else
                {
                    Main.tasks.RemoveAt(delElement - 1);
                    Refresh();
                    typeNlabel.Visible = false;
                    nToDel.Visible = false;
                    btnSubmDel.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Accepting only whole numbers... try again");
                nToDel.Clear();
                typeNlabel.Visible = false;
                nToDel.Visible = false;
                btnSubmDel.Visible = false;
            }
        }
        private void Refresh()
        {
            typeNlabel.Visible = false;
            nToDel.Visible = false;
            btnSubmDel.Visible = false;
            nToDel.Clear();
            listBoxTasks.Items.Clear();
            for (int i = 0; i < Main.tasks.Count; i++)
            {
                listBoxTasks.Items.Add($"{i + 1}. {Main.tasks[i]}");
            }
        }

        private void btnViewReturn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
