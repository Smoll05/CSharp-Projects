namespace Calculator_Intelligent_System
{
    partial class calculator
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
            resultDisplay = new TextBox();
            buttonAc = new Button();
            buttonDiv = new Button();
            buttonMul = new Button();
            buttonMinus = new Button();
            buttonPlus = new Button();
            buttonEqual = new Button();
            equationDisplay = new TextBox();
            buttonDel = new Button();
            buttonPow = new Button();
            buttonNine = new Button();
            buttonSix = new Button();
            buttonThree = new Button();
            buttonDot = new Button();
            buttonNeg = new Button();
            buttonEight = new Button();
            buttonFive = new Button();
            buttonTwo = new Button();
            buttonSeven = new Button();
            buttonFour = new Button();
            buttonOne = new Button();
            buttonZero = new Button();
            SuspendLayout();
            // 
            // resultDisplay
            // 
            resultDisplay.BackColor = Color.White;
            resultDisplay.BorderStyle = BorderStyle.None;
            resultDisplay.Font = new Font("Inter", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultDisplay.ForeColor = Color.Black;
            resultDisplay.Location = new Point(29, 99);
            resultDisplay.Name = "resultDisplay";
            resultDisplay.ReadOnly = true;
            resultDisplay.Size = new Size(550, 73);
            resultDisplay.TabIndex = 0;
            resultDisplay.Text = "0";
            resultDisplay.TextAlign = HorizontalAlignment.Right;
            resultDisplay.GotFocus += textBox_GotFocus;
            // 
            // buttonAc
            // 
            buttonAc.BackColor = SystemColors.ButtonShadow;
            buttonAc.FlatAppearance.BorderColor = Color.White;
            buttonAc.FlatAppearance.BorderSize = 0;
            buttonAc.FlatStyle = FlatStyle.Flat;
            buttonAc.Font = new Font("Inter", 16.2F);
            buttonAc.ForeColor = Color.Black;
            buttonAc.Location = new Point(308, 191);
            buttonAc.Name = "buttonAc";
            buttonAc.Size = new Size(271, 58);
            buttonAc.TabIndex = 4;
            buttonAc.Text = "AC";
            buttonAc.UseVisualStyleBackColor = false;
            buttonAc.Click += buttonAc_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.BackColor = Color.FromArgb(217, 234, 253);
            buttonDiv.FlatAppearance.BorderColor = Color.White;
            buttonDiv.FlatAppearance.BorderSize = 0;
            buttonDiv.FlatStyle = FlatStyle.Flat;
            buttonDiv.Font = new Font("Inter", 16.2F);
            buttonDiv.ForeColor = Color.Black;
            buttonDiv.Location = new Point(449, 255);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(130, 58);
            buttonDiv.TabIndex = 5;
            buttonDiv.Text = "÷";
            buttonDiv.UseVisualStyleBackColor = false;
            buttonDiv.Click += buttonDiv_Click;
            // 
            // buttonMul
            // 
            buttonMul.BackColor = Color.FromArgb(217, 234, 253);
            buttonMul.FlatAppearance.BorderColor = Color.White;
            buttonMul.FlatAppearance.BorderSize = 0;
            buttonMul.FlatStyle = FlatStyle.Flat;
            buttonMul.Font = new Font("Inter", 16.2F);
            buttonMul.ForeColor = Color.Black;
            buttonMul.Location = new Point(449, 319);
            buttonMul.Name = "buttonMul";
            buttonMul.Size = new Size(130, 58);
            buttonMul.TabIndex = 6;
            buttonMul.Text = "x";
            buttonMul.UseVisualStyleBackColor = false;
            buttonMul.Click += buttonMul_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = Color.FromArgb(217, 234, 253);
            buttonMinus.FlatAppearance.BorderColor = Color.White;
            buttonMinus.FlatAppearance.BorderSize = 0;
            buttonMinus.FlatStyle = FlatStyle.Flat;
            buttonMinus.Font = new Font("Inter", 16.2F);
            buttonMinus.ForeColor = Color.Black;
            buttonMinus.Location = new Point(449, 383);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(130, 58);
            buttonMinus.TabIndex = 7;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.BackColor = Color.FromArgb(217, 234, 253);
            buttonPlus.FlatAppearance.BorderColor = Color.White;
            buttonPlus.FlatAppearance.BorderSize = 0;
            buttonPlus.FlatStyle = FlatStyle.Flat;
            buttonPlus.Font = new Font("Inter", 16.2F);
            buttonPlus.ForeColor = Color.Black;
            buttonPlus.Location = new Point(449, 447);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(130, 58);
            buttonPlus.TabIndex = 8;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.BackColor = Color.FromArgb(217, 234, 253);
            buttonEqual.FlatAppearance.BorderColor = Color.White;
            buttonEqual.FlatAppearance.BorderSize = 0;
            buttonEqual.FlatStyle = FlatStyle.Flat;
            buttonEqual.Font = new Font("Inter", 16.2F);
            buttonEqual.ForeColor = Color.Black;
            buttonEqual.Location = new Point(449, 511);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(130, 58);
            buttonEqual.TabIndex = 9;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = false;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // equationDisplay
            // 
            equationDisplay.BackColor = Color.White;
            equationDisplay.BorderStyle = BorderStyle.None;
            equationDisplay.CausesValidation = false;
            equationDisplay.Font = new Font("Inter", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            equationDisplay.ForeColor = Color.Black;
            equationDisplay.Location = new Point(29, 56);
            equationDisplay.Name = "equationDisplay";
            equationDisplay.ReadOnly = true;
            equationDisplay.Size = new Size(551, 37);
            equationDisplay.TabIndex = 10;
            equationDisplay.TextAlign = HorizontalAlignment.Right;
            equationDisplay.GotFocus += textBox_GotFocus;
            // 
            // buttonDel
            // 
            buttonDel.BackColor = SystemColors.ButtonShadow;
            buttonDel.FlatAppearance.BorderColor = Color.White;
            buttonDel.FlatAppearance.BorderSize = 0;
            buttonDel.FlatStyle = FlatStyle.Flat;
            buttonDel.Font = new Font("Inter", 16.2F);
            buttonDel.ForeColor = Color.Black;
            buttonDel.Location = new Point(29, 191);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(270, 58);
            buttonDel.TabIndex = 4;
            buttonDel.Text = "DEL";
            buttonDel.UseVisualStyleBackColor = false;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonPow
            // 
            buttonPow.BackColor = SystemColors.ButtonShadow;
            buttonPow.FlatAppearance.BorderColor = Color.White;
            buttonPow.FlatAppearance.BorderSize = 0;
            buttonPow.FlatStyle = FlatStyle.Flat;
            buttonPow.Font = new Font("Inter", 16.2F);
            buttonPow.ForeColor = Color.Black;
            buttonPow.Location = new Point(239, 255);
            buttonPow.Name = "buttonPow";
            buttonPow.Size = new Size(199, 58);
            buttonPow.TabIndex = 5;
            buttonPow.Text = "^";
            buttonPow.UseVisualStyleBackColor = false;
            buttonPow.Click += buttonPow_Click;
            // 
            // buttonNine
            // 
            buttonNine.BackColor = Color.WhiteSmoke;
            buttonNine.FlatAppearance.BorderColor = Color.White;
            buttonNine.FlatAppearance.BorderSize = 0;
            buttonNine.FlatStyle = FlatStyle.Flat;
            buttonNine.Font = new Font("Inter", 16.2F);
            buttonNine.ForeColor = Color.Black;
            buttonNine.Location = new Point(308, 319);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(130, 58);
            buttonNine.TabIndex = 6;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = false;
            buttonNine.Click += buttonNine_Click;
            // 
            // buttonSix
            // 
            buttonSix.BackColor = Color.WhiteSmoke;
            buttonSix.FlatAppearance.BorderColor = Color.White;
            buttonSix.FlatAppearance.BorderSize = 0;
            buttonSix.FlatStyle = FlatStyle.Flat;
            buttonSix.Font = new Font("Inter", 16.2F);
            buttonSix.ForeColor = Color.Black;
            buttonSix.Location = new Point(308, 383);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(130, 58);
            buttonSix.TabIndex = 7;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = false;
            buttonSix.Click += buttonSix_Click;
            // 
            // buttonThree
            // 
            buttonThree.BackColor = Color.WhiteSmoke;
            buttonThree.FlatAppearance.BorderColor = Color.White;
            buttonThree.FlatAppearance.BorderSize = 0;
            buttonThree.FlatStyle = FlatStyle.Flat;
            buttonThree.Font = new Font("Inter", 16.2F);
            buttonThree.ForeColor = Color.Black;
            buttonThree.Location = new Point(308, 447);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(130, 58);
            buttonThree.TabIndex = 8;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = false;
            buttonThree.Click += buttonThree_Click;
            // 
            // buttonDot
            // 
            buttonDot.BackColor = Color.WhiteSmoke;
            buttonDot.FlatAppearance.BorderColor = Color.White;
            buttonDot.FlatAppearance.BorderSize = 0;
            buttonDot.FlatStyle = FlatStyle.Flat;
            buttonDot.Font = new Font("Inter", 16.2F);
            buttonDot.ForeColor = Color.Black;
            buttonDot.Location = new Point(308, 511);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(130, 58);
            buttonDot.TabIndex = 9;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = false;
            buttonDot.Click += buttonDot_Click;
            // 
            // buttonNeg
            // 
            buttonNeg.BackColor = SystemColors.ButtonShadow;
            buttonNeg.FlatAppearance.BorderColor = Color.White;
            buttonNeg.FlatAppearance.BorderSize = 0;
            buttonNeg.FlatStyle = FlatStyle.Flat;
            buttonNeg.Font = new Font("Inter", 16.2F);
            buttonNeg.ForeColor = Color.Black;
            buttonNeg.Location = new Point(29, 255);
            buttonNeg.Name = "buttonNeg";
            buttonNeg.Size = new Size(204, 58);
            buttonNeg.TabIndex = 5;
            buttonNeg.Text = "+/-";
            buttonNeg.UseVisualStyleBackColor = false;
            buttonNeg.Click += buttonNeg_Click;
            // 
            // buttonEight
            // 
            buttonEight.BackColor = Color.WhiteSmoke;
            buttonEight.FlatAppearance.BorderColor = Color.White;
            buttonEight.FlatAppearance.BorderSize = 0;
            buttonEight.FlatStyle = FlatStyle.Flat;
            buttonEight.Font = new Font("Inter", 16.2F);
            buttonEight.ForeColor = Color.Black;
            buttonEight.Location = new Point(169, 319);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(130, 58);
            buttonEight.TabIndex = 6;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = false;
            buttonEight.Click += buttonEight_Click;
            // 
            // buttonFive
            // 
            buttonFive.BackColor = Color.WhiteSmoke;
            buttonFive.FlatAppearance.BorderColor = Color.White;
            buttonFive.FlatAppearance.BorderSize = 0;
            buttonFive.FlatStyle = FlatStyle.Flat;
            buttonFive.Font = new Font("Inter", 16.2F);
            buttonFive.ForeColor = Color.Black;
            buttonFive.Location = new Point(169, 383);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(130, 58);
            buttonFive.TabIndex = 7;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = false;
            buttonFive.Click += buttonFive_Click;
            // 
            // buttonTwo
            // 
            buttonTwo.BackColor = Color.WhiteSmoke;
            buttonTwo.FlatAppearance.BorderColor = Color.White;
            buttonTwo.FlatAppearance.BorderSize = 0;
            buttonTwo.FlatStyle = FlatStyle.Flat;
            buttonTwo.Font = new Font("Inter", 16.2F);
            buttonTwo.ForeColor = Color.Black;
            buttonTwo.Location = new Point(169, 447);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(130, 58);
            buttonTwo.TabIndex = 8;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = false;
            buttonTwo.Click += buttonTwo_Click;
            // 
            // buttonSeven
            // 
            buttonSeven.BackColor = Color.WhiteSmoke;
            buttonSeven.FlatAppearance.BorderColor = Color.White;
            buttonSeven.FlatAppearance.BorderSize = 0;
            buttonSeven.FlatStyle = FlatStyle.Flat;
            buttonSeven.Font = new Font("Inter", 16.2F);
            buttonSeven.ForeColor = Color.Black;
            buttonSeven.Location = new Point(29, 319);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(130, 58);
            buttonSeven.TabIndex = 6;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = false;
            buttonSeven.Click += buttonSeven_Click;
            // 
            // buttonFour
            // 
            buttonFour.BackColor = Color.WhiteSmoke;
            buttonFour.FlatAppearance.BorderColor = Color.White;
            buttonFour.FlatAppearance.BorderSize = 0;
            buttonFour.FlatStyle = FlatStyle.Flat;
            buttonFour.Font = new Font("Inter", 16.2F);
            buttonFour.ForeColor = Color.Black;
            buttonFour.Location = new Point(29, 383);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(130, 58);
            buttonFour.TabIndex = 7;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = false;
            buttonFour.Click += buttonFour_Click;
            // 
            // buttonOne
            // 
            buttonOne.BackColor = Color.WhiteSmoke;
            buttonOne.FlatAppearance.BorderColor = Color.White;
            buttonOne.FlatAppearance.BorderSize = 0;
            buttonOne.FlatStyle = FlatStyle.Flat;
            buttonOne.Font = new Font("Inter", 16.2F);
            buttonOne.ForeColor = Color.Black;
            buttonOne.Location = new Point(29, 447);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(130, 58);
            buttonOne.TabIndex = 8;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = false;
            buttonOne.Click += buttonOne_Click;
            // 
            // buttonZero
            // 
            buttonZero.BackColor = Color.WhiteSmoke;
            buttonZero.FlatAppearance.BorderColor = Color.White;
            buttonZero.FlatAppearance.BorderSize = 0;
            buttonZero.FlatStyle = FlatStyle.Flat;
            buttonZero.Font = new Font("Inter", 16.2F);
            buttonZero.ForeColor = Color.Black;
            buttonZero.Location = new Point(29, 511);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(270, 58);
            buttonZero.TabIndex = 9;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = false;
            buttonZero.Click += buttonZero_Click;
            // 
            // calculator
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(606, 596);
            Controls.Add(equationDisplay);
            Controls.Add(buttonZero);
            Controls.Add(buttonDot);
            Controls.Add(buttonEqual);
            Controls.Add(buttonOne);
            Controls.Add(buttonTwo);
            Controls.Add(buttonThree);
            Controls.Add(buttonPlus);
            Controls.Add(buttonFour);
            Controls.Add(buttonFive);
            Controls.Add(buttonSix);
            Controls.Add(buttonMinus);
            Controls.Add(buttonSeven);
            Controls.Add(buttonEight);
            Controls.Add(buttonNine);
            Controls.Add(buttonMul);
            Controls.Add(buttonNeg);
            Controls.Add(buttonPow);
            Controls.Add(buttonDiv);
            Controls.Add(buttonDel);
            Controls.Add(buttonAc);
            Controls.Add(resultDisplay);
            Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "calculator";
            Text = "Simple Calculator";
            Load += calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox resultDisplay;
        private Button buttonAc;
        private Button buttonDiv;
        private Button buttonMul;
        private Button buttonMinus;
        private Button buttonPlus;
        private Button buttonEqual;
        private TextBox equationDisplay;
        private Button buttonDel;
        private Button buttonPow;
        private Button buttonNine;
        private Button buttonSix;
        private Button buttonThree;
        private Button buttonDot;
        private Button buttonSqrt;
        private Button buttonEight;
        private Button buttonFive;
        private Button buttonTwo;
        private Button buttonSeven;
        private Button buttonFour;
        private Button buttonOne;
        private Button buttonZero;
        private Button buttonNeg;
    }
}
