namespace CSC240_08_01_EnterInvoices_DG
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            invoiceBox = new TextBox();
            nameBox = new TextBox();
            amountBox = new TextBox();
            enterButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(69, 46);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 0;
            label1.Text = "Enter invoice data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 123);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Invoice number";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 195);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Last name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 268);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Amount";
            // 
            // invoiceBox
            // 
            invoiceBox.Location = new Point(236, 115);
            invoiceBox.Name = "invoiceBox";
            invoiceBox.Size = new Size(100, 23);
            invoiceBox.TabIndex = 4;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(236, 192);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(100, 23);
            nameBox.TabIndex = 5;
            // 
            // amountBox
            // 
            amountBox.Location = new Point(236, 260);
            amountBox.Name = "amountBox";
            amountBox.Size = new Size(100, 23);
            amountBox.TabIndex = 6;
            // 
            // enterButton
            // 
            enterButton.Location = new Point(130, 352);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(93, 23);
            enterButton.TabIndex = 7;
            enterButton.Text = "Enter record";
            enterButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 450);
            Controls.Add(enterButton);
            Controls.Add(amountBox);
            Controls.Add(nameBox);
            Controls.Add(invoiceBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Invoice Data";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox invoiceBox;
        private TextBox nameBox;
        private TextBox amountBox;
        private Button enterButton;
    }
}
