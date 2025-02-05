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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void btnAddReturn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void btnAddSubm_Click(object sender, EventArgs e)
        {
            string task = taskBox.Text;

            if (!string.IsNullOrEmpty(task))
            {
                Main.tasks.Add(task);
                MessageBox.Show("Succesfully added!");
            }
            else if (string.IsNullOrEmpty(task))
            {
                MessageBox.Show("Empty task box...\nWrite something or return to menu...");
            }
            taskBox.Clear();
        }
    }
}
