﻿namespace SkProjectEdP
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button13 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(249, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(610, 544);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(15, 345);
            button1.Name = "button1";
            button1.Size = new Size(148, 29);
            button1.TabIndex = 1;
            button1.Text = "View Household";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(15, 310);
            button2.Name = "button2";
            button2.Size = new Size(145, 29);
            button2.TabIndex = 2;
            button2.Text = "Residents";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(15, 450);
            button3.Name = "button3";
            button3.Size = new Size(151, 29);
            button3.TabIndex = 3;
            button3.Text = "View Budget button ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 485);
            button4.Name = "button4";
            button4.Size = new Size(151, 29);
            button4.TabIndex = 6;
            button4.Text = "View Projects";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(15, 415);
            button5.Name = "button5";
            button5.Size = new Size(148, 29);
            button5.TabIndex = 5;
            button5.Text = "View Events";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 380);
            button6.Name = "button6";
            button6.Size = new Size(148, 29);
            button6.TabIndex = 4;
            button6.Text = "View Officials";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(15, 275);
            button7.Name = "button7";
            button7.Size = new Size(148, 29);
            button7.TabIndex = 10;
            button7.Text = "Add Projects";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(15, 240);
            button8.Name = "button8";
            button8.Size = new Size(145, 29);
            button8.TabIndex = 9;
            button8.Text = "Add Events";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(15, 205);
            button9.Name = "button9";
            button9.Size = new Size(148, 29);
            button9.TabIndex = 8;
            button9.Text = "Request Assistance";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(18, 170);
            button10.Name = "button10";
            button10.Size = new Size(145, 29);
            button10.TabIndex = 7;
            button10.Text = "Add Budget";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(12, 529);
            button11.Name = "button11";
            button11.Size = new Size(148, 29);
            button11.TabIndex = 11;
            button11.Text = "View Request Assitance";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button13
            // 
            button13.Location = new Point(9, 584);
            button13.Name = "button13";
            button13.Size = new Size(148, 29);
            button13.TabIndex = 13;
            button13.Text = "Print";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 738);
            Controls.Add(button13);
            Controls.Add(button11);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button13;
    }
}
