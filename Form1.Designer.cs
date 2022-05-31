
namespace bonk
{
    partial class Form1
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
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsTextBox.Location = new System.Drawing.Point(12, 12);
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.ReadOnly = true;
            this.resultsTextBox.Size = new System.Drawing.Size(169, 38);
            this.resultsTextBox.TabIndex = 0;
            this.resultsTextBox.Text = "0";
            this.resultsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(12, 63);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(36, 36);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.numButton_click);
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(66, 63);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(36, 36);
            this.n2.TabIndex = 2;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.numButton_click);
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(119, 63);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(36, 36);
            this.n3.TabIndex = 3;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.numButton_click);
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(12, 105);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(36, 36);
            this.n4.TabIndex = 4;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.numButton_click);
            // 
            // n5
            // 
            this.n5.Location = new System.Drawing.Point(66, 105);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(36, 36);
            this.n5.TabIndex = 5;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.numButton_click);
            // 
            // n6
            // 
            this.n6.Location = new System.Drawing.Point(119, 105);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(36, 36);
            this.n6.TabIndex = 6;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.numButton_click);
            // 
            // n7
            // 
            this.n7.Location = new System.Drawing.Point(12, 147);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(36, 36);
            this.n7.TabIndex = 7;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.numButton_click);
            // 
            // n8
            // 
            this.n8.Location = new System.Drawing.Point(66, 147);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(36, 36);
            this.n8.TabIndex = 8;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.numButton_click);
            // 
            // n9
            // 
            this.n9.Location = new System.Drawing.Point(119, 147);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(36, 36);
            this.n9.TabIndex = 9;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.numButton_click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(161, 63);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(36, 36);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(161, 105);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(36, 36);
            this.subtractButton.TabIndex = 11;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            // 
            // equalsButton
            // 
            this.equalsButton.Location = new System.Drawing.Point(161, 189);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(36, 36);
            this.equalsButton.TabIndex = 12;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(119, 189);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(36, 36);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 335);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.resultsTextBox);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button clearButton;
    }
}

