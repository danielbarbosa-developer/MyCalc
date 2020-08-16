namespace MyCalc
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainBox = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.Comma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainBox
            // 
            this.MainBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainBox.Location = new System.Drawing.Point(12, 28);
            this.MainBox.Name = "MainBox";
            this.MainBox.ReadOnly = true;
            this.MainBox.Size = new System.Drawing.Size(206, 31);
            this.MainBox.TabIndex = 0;
            this.MainBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(12, 65);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 23);
            this.plus.TabIndex = 1;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(12, 94);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 2;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // times
            // 
            this.times.Location = new System.Drawing.Point(12, 123);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(75, 23);
            this.times.TabIndex = 3;
            this.times.Text = "*";
            this.times.UseVisualStyleBackColor = true;
            this.times.Click += new System.EventHandler(this.times_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(12, 152);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 23);
            this.division.TabIndex = 4;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(108, 65);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(34, 33);
            this.one.TabIndex = 5;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(188, 65);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(34, 33);
            this.three.TabIndex = 6;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(148, 182);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(34, 33);
            this.zero.TabIndex = 7;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(148, 143);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(34, 33);
            this.eight.TabIndex = 8;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(148, 104);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(34, 33);
            this.five.TabIndex = 9;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(148, 65);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(34, 33);
            this.two.TabIndex = 10;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(108, 182);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(34, 33);
            this.delete.TabIndex = 11;
            this.delete.Text = "Del";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(108, 143);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(34, 33);
            this.seven.TabIndex = 12;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(108, 104);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(34, 33);
            this.four.TabIndex = 13;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(188, 104);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(34, 33);
            this.six.TabIndex = 14;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(188, 143);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(34, 33);
            this.nine.TabIndex = 15;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(12, 182);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(75, 33);
            this.equals.TabIndex = 16;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // Comma
            // 
            this.Comma.Location = new System.Drawing.Point(188, 182);
            this.Comma.Name = "Comma";
            this.Comma.Size = new System.Drawing.Size(34, 33);
            this.Comma.TabIndex = 17;
            this.Comma.Text = ",";
            this.Comma.UseVisualStyleBackColor = true;
            this.Comma.Click += new System.EventHandler(this.Comma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 230);
            this.Controls.Add(this.Comma);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.six);
            this.Controls.Add(this.four);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.two);
            this.Controls.Add(this.five);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.three);
            this.Controls.Add(this.one);
            this.Controls.Add(this.division);
            this.Controls.Add(this.times);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.MainBox);
            this.Name = "Form1";
            this.Text = "MyCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MainBox;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button Comma;
    }
}

