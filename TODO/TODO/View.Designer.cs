namespace TODO
{
    partial class View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxTasks = new ListBox();
            tasksViewLabel = new Label();
            btnDelTask = new Button();
            typeNlabel = new Label();
            nToDel = new TextBox();
            btnSubmDel = new Button();
            btnViewReturn = new Button();
            SuspendLayout();
            // 
            // listBoxTasks
            // 
            listBoxTasks.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 20;
            listBoxTasks.Location = new Point(36, 69);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(563, 364);
            listBoxTasks.TabIndex = 0;
            // 
            // tasksViewLabel
            // 
            tasksViewLabel.AutoSize = true;
            tasksViewLabel.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tasksViewLabel.Location = new Point(252, 9);
            tasksViewLabel.Name = "tasksViewLabel";
            tasksViewLabel.Size = new Size(231, 47);
            tasksViewLabel.TabIndex = 1;
            tasksViewLabel.Text = "YOUR TASKS:";
            // 
            // btnDelTask
            // 
            btnDelTask.BackColor = Color.Red;
            btnDelTask.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDelTask.ForeColor = SystemColors.ButtonHighlight;
            btnDelTask.Location = new Point(672, 38);
            btnDelTask.Name = "btnDelTask";
            btnDelTask.Size = new Size(116, 30);
            btnDelTask.TabIndex = 2;
            btnDelTask.Text = "DELETE TASK";
            btnDelTask.UseVisualStyleBackColor = false;
            btnDelTask.Click += btnDelTask_Click;
            // 
            // typeNlabel
            // 
            typeNlabel.AutoSize = true;
            typeNlabel.BackColor = Color.Red;
            typeNlabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            typeNlabel.ForeColor = SystemColors.ButtonHighlight;
            typeNlabel.Location = new Point(605, 84);
            typeNlabel.Name = "typeNlabel";
            typeNlabel.Size = new Size(159, 15);
            typeNlabel.TabIndex = 3;
            typeNlabel.Text = "Type number task to delete: ";
            // 
            // nToDel
            // 
            nToDel.BackColor = Color.White;
            nToDel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            nToDel.Location = new Point(605, 112);
            nToDel.Multiline = true;
            nToDel.Name = "nToDel";
            nToDel.Size = new Size(74, 24);
            nToDel.TabIndex = 4;
            // 
            // btnSubmDel
            // 
            btnSubmDel.BackColor = Color.Red;
            btnSubmDel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSubmDel.ForeColor = SystemColors.ButtonHighlight;
            btnSubmDel.Location = new Point(696, 108);
            btnSubmDel.Name = "btnSubmDel";
            btnSubmDel.Size = new Size(65, 28);
            btnSubmDel.TabIndex = 5;
            btnSubmDel.Text = "SUBMIT";
            btnSubmDel.UseVisualStyleBackColor = false;
            btnSubmDel.Click += btnSubmDel_Click;
            // 
            // btnViewReturn
            // 
            btnViewReturn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            btnViewReturn.Location = new Point(623, 391);
            btnViewReturn.Name = "btnViewReturn";
            btnViewReturn.Size = new Size(165, 42);
            btnViewReturn.TabIndex = 6;
            btnViewReturn.Text = "RETURN TO MENU";
            btnViewReturn.UseVisualStyleBackColor = true;
            btnViewReturn.Click += btnViewReturn_Click;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewReturn);
            Controls.Add(btnSubmDel);
            Controls.Add(nToDel);
            Controls.Add(typeNlabel);
            Controls.Add(btnDelTask);
            Controls.Add(tasksViewLabel);
            Controls.Add(listBoxTasks);
            Name = "View";
            Text = "View";
            Load += View_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxTasks;
        private Label tasksViewLabel;
        private Button btnDelTask;
        private Label typeNlabel;
        private TextBox nToDel;
        private Button btnSubmDel;
        private Button btnViewReturn;
    }
}