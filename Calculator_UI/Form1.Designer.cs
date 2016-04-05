namespace Calculator_UI
{
    partial class Calc
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
            this.MainTextBox = new System.Windows.Forms.TextBox();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Siz = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Eval = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.space = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainTextBox
            // 
            this.MainTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTextBox.Location = new System.Drawing.Point(12, 12);
            this.MainTextBox.Multiline = true;
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.ReadOnly = true;
            this.MainTextBox.Size = new System.Drawing.Size(274, 62);
            this.MainTextBox.TabIndex = 0;
            this.MainTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(12, 80);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(46, 39);
            this.One.TabIndex = 1;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(64, 80);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(46, 39);
            this.Two.TabIndex = 2;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(116, 80);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(46, 39);
            this.Three.TabIndex = 3;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Siz
            // 
            this.Siz.Location = new System.Drawing.Point(116, 125);
            this.Siz.Name = "Siz";
            this.Siz.Size = new System.Drawing.Size(46, 39);
            this.Siz.TabIndex = 6;
            this.Siz.Text = "6";
            this.Siz.UseVisualStyleBackColor = true;
            this.Siz.Click += new System.EventHandler(this.Siz_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(64, 125);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(46, 39);
            this.Five.TabIndex = 5;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(12, 125);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(46, 39);
            this.Four.TabIndex = 4;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(116, 170);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(46, 39);
            this.Nine.TabIndex = 9;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(64, 170);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(46, 39);
            this.Eight.TabIndex = 8;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Seven
            // 
            this.Seven.Location = new System.Drawing.Point(12, 170);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(46, 39);
            this.Seven.TabIndex = 7;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(188, 80);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(46, 39);
            this.Add.TabIndex = 10;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Subtract
            // 
            this.Subtract.Location = new System.Drawing.Point(240, 80);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(46, 39);
            this.Subtract.TabIndex = 11;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(188, 125);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(46, 39);
            this.Divide.TabIndex = 13;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply.Location = new System.Drawing.Point(240, 125);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(46, 39);
            this.Multiply.TabIndex = 12;
            this.Multiply.Text = "x";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Eval
            // 
            this.Eval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eval.Location = new System.Drawing.Point(188, 215);
            this.Eval.Name = "Eval";
            this.Eval.Size = new System.Drawing.Size(98, 39);
            this.Eval.TabIndex = 14;
            this.Eval.Text = "=";
            this.Eval.UseVisualStyleBackColor = true;
            this.Eval.Click += new System.EventHandler(this.Eval_Click);
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(240, 170);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(46, 39);
            this.Check.TabIndex = 15;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(188, 170);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(46, 39);
            this.delete.TabIndex = 16;
            this.delete.Text = "Del";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // space
            // 
            this.space.Location = new System.Drawing.Point(12, 260);
            this.space.Name = "space";
            this.space.Size = new System.Drawing.Size(150, 39);
            this.space.TabIndex = 17;
            this.space.Text = "Space";
            this.space.UseVisualStyleBackColor = true;
            this.space.Click += new System.EventHandler(this.space_Click);
            // 
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(12, 215);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(46, 39);
            this.Zero.TabIndex = 18;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(64, 215);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(98, 39);
            this.Clear.TabIndex = 19;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 314);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.space);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Eval);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Siz);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.MainTextBox);
            this.Name = "Calc";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MainTextBox;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Siz;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Eval;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button space;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Clear;
    }
}

