namespace TODO
{
    partial class Add
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
            btnAddReturn = new Button();
            addLabel = new Label();
            taskBox = new TextBox();
            btnAddSubm = new Button();
            SuspendLayout();
            // 
            // btnAddReturn
            // 
            btnAddReturn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAddReturn.Location = new Point(12, 402);
            btnAddReturn.Name = "btnAddReturn";
            btnAddReturn.Size = new Size(161, 36);
            btnAddReturn.TabIndex = 0;
            btnAddReturn.Text = "RETURN TO MENU";
            btnAddReturn.UseVisualStyleBackColor = true;
            btnAddReturn.Click += btnAddReturn_Click;
            // 
            // addLabel
            // 
            addLabel.AutoSize = true;
            addLabel.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            addLabel.Location = new Point(275, 9);
            addLabel.Name = "addLabel";
            addLabel.Size = new Size(207, 40);
            addLabel.TabIndex = 1;
            addLabel.Text = "WRITE BELOW";
            // 
            // taskBox
            // 
            taskBox.Location = new Point(199, 64);
            taskBox.Multiline = true;
            taskBox.Name = "taskBox";
            taskBox.Size = new Size(355, 112);
            taskBox.TabIndex = 2;
            // 
            // btnAddSubm
            // 
            btnAddSubm.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAddSubm.Location = new Point(453, 182);
            btnAddSubm.Name = "btnAddSubm";
            btnAddSubm.Size = new Size(101, 45);
            btnAddSubm.TabIndex = 3;
            btnAddSubm.Text = "SUBMIT";
            btnAddSubm.UseVisualStyleBackColor = true;
            btnAddSubm.Click += btnAddSubm_Click;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddSubm);
            Controls.Add(taskBox);
            Controls.Add(addLabel);
            Controls.Add(btnAddReturn);
            Name = "Add";
            Text = "Add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddReturn;
        private Label addLabel;
        private TextBox taskBox;
        private Button btnAddSubm;
    }
}