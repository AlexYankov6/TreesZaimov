namespace Trees_Zaimov
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtNamebg = new TextBox();
            lbl1 = new Label();
            lbl2 = new Label();
            btn1 = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(31, 52);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtNamebg
            // 
            txtNamebg.Location = new Point(170, 52);
            txtNamebg.Name = "txtNamebg";
            txtNamebg.Size = new Size(100, 23);
            txtNamebg.TabIndex = 9;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(38, 30);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(39, 15);
            lbl1.TabIndex = 21;
            lbl1.Text = "Name";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(183, 34);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(59, 15);
            lbl2.TabIndex = 22;
            lbl2.Text = "Name_BG";
            // 
            // btn1
            // 
            btn1.Location = new Point(60, 116);
            btn1.Name = "btn1";
            btn1.Size = new Size(182, 23);
            btn1.TabIndex = 23;
            btn1.Text = "Insert into...";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn1);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(txtNamebg);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Populvane na pomoshtnite tablici";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtName;
        private TextBox txtNamebg;
        private Label lbl1;
        private Label lbl2;
        private Button btn1;
    }
}
