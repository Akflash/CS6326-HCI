namespace Asg4_axk180196
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
            this.lowerBoundtextBox = new System.Windows.Forms.TextBox();
            this.upperBoundtextBox = new System.Windows.Forms.TextBox();
            this.calculatePrimeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.primeCalculateprogressBar = new System.Windows.Forms.ProgressBar();
            this.primeFactorsprogressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultView = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHPrimeFactors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lowerBoundtextBox
            // 
            this.lowerBoundtextBox.Location = new System.Drawing.Point(124, 21);
            this.lowerBoundtextBox.Name = "lowerBoundtextBox";
            this.lowerBoundtextBox.Size = new System.Drawing.Size(100, 20);
            this.lowerBoundtextBox.TabIndex = 1;
            // 
            // upperBoundtextBox
            // 
            this.upperBoundtextBox.Location = new System.Drawing.Point(382, 21);
            this.upperBoundtextBox.Name = "upperBoundtextBox";
            this.upperBoundtextBox.Size = new System.Drawing.Size(100, 20);
            this.upperBoundtextBox.TabIndex = 2;
            // 
            // calculatePrimeButton
            // 
            this.calculatePrimeButton.Location = new System.Drawing.Point(596, 16);
            this.calculatePrimeButton.Name = "calculatePrimeButton";
            this.calculatePrimeButton.Size = new System.Drawing.Size(79, 29);
            this.calculatePrimeButton.TabIndex = 3;
            this.calculatePrimeButton.Text = "Calculate";
            this.calculatePrimeButton.UseVisualStyleBackColor = true;
            this.calculatePrimeButton.Click += new System.EventHandler(this.calculatePrimeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter UpperBound";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter LowerBound";
            // 
            // primeCalculateprogressBar
            // 
            this.primeCalculateprogressBar.Location = new System.Drawing.Point(184, 76);
            this.primeCalculateprogressBar.Name = "primeCalculateprogressBar";
            this.primeCalculateprogressBar.Size = new System.Drawing.Size(545, 23);
            this.primeCalculateprogressBar.TabIndex = 7;
            // 
            // primeFactorsprogressBar
            // 
            this.primeFactorsprogressBar.Location = new System.Drawing.Point(184, 134);
            this.primeFactorsprogressBar.Name = "primeFactorsprogressBar";
            this.primeFactorsprogressBar.Size = new System.Drawing.Size(545, 23);
            this.primeFactorsprogressBar.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Calculating Primes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Calculating PrimeFactors";
            // 
            // resultView
            // 
            this.resultView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.colHPrimeFactors});
            this.resultView.HideSelection = false;
            this.resultView.Location = new System.Drawing.Point(269, 183);
            this.resultView.Margin = new System.Windows.Forms.Padding(2);
            this.resultView.Name = "resultView";
            this.resultView.Size = new System.Drawing.Size(299, 244);
            this.resultView.TabIndex = 26;
            this.resultView.UseCompatibleStateImageBehavior = false;
            this.resultView.View = System.Windows.Forms.View.Details;
            // 
            // Number
            // 
            this.Number.Text = "Number";
            this.Number.Width = 100;
            // 
            // colHPrimeFactors
            // 
            this.colHPrimeFactors.Text = "Total  Unique Prime Factors";
            this.colHPrimeFactors.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.primeFactorsprogressBar);
            this.Controls.Add(this.primeCalculateprogressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculatePrimeButton);
            this.Controls.Add(this.upperBoundtextBox);
            this.Controls.Add(this.lowerBoundtextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox lowerBoundtextBox;
        private System.Windows.Forms.TextBox upperBoundtextBox;
        private System.Windows.Forms.Button calculatePrimeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar primeCalculateprogressBar;
        private System.Windows.Forms.ProgressBar primeFactorsprogressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView resultView;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader colHPrimeFactors;
    }
}

