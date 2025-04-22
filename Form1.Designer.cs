namespace WinFormsApp1
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
            Button btnRecordOrder1;
            Button btnCloseOrder1;
            btnNewBill1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCurrentOrder1 = new Button();
            btnFinalOrder1 = new Button();
            lblCurrentBill1 = new Label();
            lblFinalBill1 = new Label();
            btnRecordOrder1 = new Button();
            btnCloseOrder1 = new Button();
            SuspendLayout();
            // 
            // btnRecordOrder1
            // 
            btnRecordOrder1.Location = new Point(21, 147);
            btnRecordOrder1.Name = "btnRecordOrder1";
            btnRecordOrder1.Size = new Size(119, 23);
            btnRecordOrder1.TabIndex = 6;
            btnRecordOrder1.Text = "Запиши Поръчка";
            btnRecordOrder1.TextAlign = ContentAlignment.MiddleRight;
            btnRecordOrder1.UseVisualStyleBackColor = true;
            btnRecordOrder1.Click += btnRecordOrder_Click;
            // 
            // btnCloseOrder1
            // 
            btnCloseOrder1.Location = new Point(21, 192);
            btnCloseOrder1.Name = "btnCloseOrder1";
            btnCloseOrder1.Size = new Size(119, 23);
            btnCloseOrder1.TabIndex = 7;
            btnCloseOrder1.Text = "Закрий Сметка";
            btnCloseOrder1.UseVisualStyleBackColor = true;
            // 
            // btnNewBill1
            // 
            btnNewBill1.Location = new Point(21, 104);
            btnNewBill1.Name = "btnNewBill1";
            btnNewBill1.Size = new Size(98, 23);
            btnNewBill1.TabIndex = 0;
            btnNewBill1.Text = "Нова Сметка";
            btnNewBill1.UseVisualStyleBackColor = true;
            btnNewBill1.Click += btnNewBill_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 70);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Маса 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 70);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Маса 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 70);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 3;
            label3.Text = "Маса 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(448, 70);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 4;
            label4.Text = "Маса 4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(601, 70);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 5;
            label5.Text = "Маса 5";
            // 
            // btnCurrentOrder1
            // 
            btnCurrentOrder1.Location = new Point(21, 233);
            btnCurrentOrder1.Name = "btnCurrentOrder1";
            btnCurrentOrder1.Size = new Size(119, 23);
            btnCurrentOrder1.TabIndex = 8;
            btnCurrentOrder1.Text = "Текуща Сметка";
            btnCurrentOrder1.UseVisualStyleBackColor = true;
            btnCurrentOrder1.Click += btnCurrentOrder_Click;
            // 
            // btnFinalOrder1
            // 
            btnFinalOrder1.Location = new Point(21, 321);
            btnFinalOrder1.Name = "btnFinalOrder1";
            btnFinalOrder1.Size = new Size(119, 23);
            btnFinalOrder1.TabIndex = 9;
            btnFinalOrder1.Text = "Крайна Сметка";
            btnFinalOrder1.UseVisualStyleBackColor = true;
            // 
            // lblCurrentBill1
            // 
            lblCurrentBill1.AutoSize = true;
            lblCurrentBill1.Location = new Point(33, 259);
            lblCurrentBill1.Name = "lblCurrentBill1";
            lblCurrentBill1.Size = new Size(91, 15);
            lblCurrentBill1.TabIndex = 10;
            lblCurrentBill1.Text = "Текуща Сметка";
            lblCurrentBill1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblFinalBill1
            // 
            lblFinalBill1.AutoSize = true;
            lblFinalBill1.Location = new Point(33, 347);
            lblFinalBill1.Name = "lblFinalBill1";
            lblFinalBill1.Size = new Size(90, 15);
            lblFinalBill1.TabIndex = 11;
            lblFinalBill1.Text = "Крайна Сметка";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFinalBill1);
            Controls.Add(lblCurrentBill1);
            Controls.Add(btnFinalOrder1);
            Controls.Add(btnCurrentOrder1);
            Controls.Add(btnCloseOrder1);
            Controls.Add(btnRecordOrder1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNewBill1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewBill1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnRecordOrder1;
        private Button btnCloseOrder1;
        private Button btnCurrentOrder1;
        private Button btnFinalOrder1;
        private Label lblCurrentBill1;
        private Label lblFinalBill1;
    }
}
