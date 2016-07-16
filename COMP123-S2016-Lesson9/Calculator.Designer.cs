﻿namespace COMP123_S2016_Lesson9
{
    partial class Calculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.TimesButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.EqualsButton, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.DecimalButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.ZeroButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.PlusButton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.ThreeButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.TwoButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.OneButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.MinusButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.SixButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.FiveButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.FourButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TimesButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.NineButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.EightButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SevenButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DivideButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BackButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ClearButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 202);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 227);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // EqualsButton
            // 
            this.EqualsButton.BackColor = System.Drawing.Color.Green;
            this.EqualsButton.ForeColor = System.Drawing.Color.White;
            this.EqualsButton.Location = new System.Drawing.Point(213, 183);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(64, 41);
            this.EqualsButton.TabIndex = 19;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = false;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Location = new System.Drawing.Point(143, 183);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(64, 41);
            this.DecimalButton.TabIndex = 18;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            // 
            // ZeroButton
            // 
            this.ZeroButton.Location = new System.Drawing.Point(73, 183);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(64, 41);
            this.ZeroButton.TabIndex = 17;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.BackColor = System.Drawing.Color.Blue;
            this.PlusButton.ForeColor = System.Drawing.Color.White;
            this.PlusButton.Location = new System.Drawing.Point(213, 138);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(64, 39);
            this.PlusButton.TabIndex = 15;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.Click += new System.EventHandler(this.Operator_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Location = new System.Drawing.Point(143, 138);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(64, 39);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Location = new System.Drawing.Point(73, 138);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(64, 39);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Location = new System.Drawing.Point(3, 138);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(64, 39);
            this.OneButton.TabIndex = 12;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.Color.Blue;
            this.MinusButton.ForeColor = System.Drawing.Color.White;
            this.MinusButton.Location = new System.Drawing.Point(213, 93);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(64, 39);
            this.MinusButton.TabIndex = 11;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.Click += new System.EventHandler(this.Operator_Click);
            // 
            // SixButton
            // 
            this.SixButton.Location = new System.Drawing.Point(143, 93);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(64, 39);
            this.SixButton.TabIndex = 10;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Location = new System.Drawing.Point(73, 93);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(64, 39);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Location = new System.Drawing.Point(3, 93);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(64, 39);
            this.FourButton.TabIndex = 8;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // TimesButton
            // 
            this.TimesButton.BackColor = System.Drawing.Color.Blue;
            this.TimesButton.ForeColor = System.Drawing.Color.White;
            this.TimesButton.Location = new System.Drawing.Point(213, 48);
            this.TimesButton.Name = "TimesButton";
            this.TimesButton.Size = new System.Drawing.Size(64, 39);
            this.TimesButton.TabIndex = 7;
            this.TimesButton.Text = "X";
            this.TimesButton.UseVisualStyleBackColor = false;
            this.TimesButton.Click += new System.EventHandler(this.Operator_Click);
            // 
            // NineButton
            // 
            this.NineButton.Location = new System.Drawing.Point(143, 48);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(64, 39);
            this.NineButton.TabIndex = 6;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Location = new System.Drawing.Point(73, 48);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(64, 39);
            this.EightButton.TabIndex = 5;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Location = new System.Drawing.Point(3, 48);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(64, 39);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.BackColor = System.Drawing.Color.Blue;
            this.DivideButton.ForeColor = System.Drawing.Color.White;
            this.DivideButton.Location = new System.Drawing.Point(213, 3);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(64, 39);
            this.DivideButton.TabIndex = 3;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = false;
            this.DivideButton.Click += new System.EventHandler(this.Operator_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Blue;
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(143, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(64, 39);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "<-";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Blue;
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(73, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(64, 39);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.White;
            this.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.ForeColor = System.Drawing.Color.Black;
            this.ResultTextBox.Location = new System.Drawing.Point(11, 12);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ResultTextBox.Size = new System.Drawing.Size(281, 64);
            this.ResultTextBox.TabIndex = 1;
            this.ResultTextBox.Text = "0";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Lucida Sans", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button TimesButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}