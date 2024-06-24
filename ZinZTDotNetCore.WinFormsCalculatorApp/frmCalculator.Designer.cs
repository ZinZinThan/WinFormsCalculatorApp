namespace ZinZTDotNetCore.WinFormsCalculatorApp
{
    partial class frmCalculator
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
            this.btnAc = new System.Windows.Forms.Button();
            this.btnModulo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivided = new System.Windows.Forms.Button();
            this.btnDzero = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAc
            // 
            this.btnAc.BackColor = System.Drawing.Color.Orange;
            this.btnAc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAc.Location = new System.Drawing.Point(67, 109);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(75, 32);
            this.btnAc.TabIndex = 0;
            this.btnAc.Text = "AC";
            this.btnAc.UseVisualStyleBackColor = false;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // btnModulo
            // 
            this.btnModulo.BackColor = System.Drawing.Color.Orange;
            this.btnModulo.Location = new System.Drawing.Point(259, 109);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(75, 32);
            this.btnModulo.TabIndex = 1;
            this.btnModulo.Text = "%";
            this.btnModulo.UseVisualStyleBackColor = false;
            this.btnModulo.Click += new System.EventHandler(this.btn_onClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Orange;
            this.btnDelete.Location = new System.Drawing.Point(162, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Orange;
            this.btnAdd.Location = new System.Drawing.Point(356, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btn_onClick);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(67, 147);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 32);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_onClick);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(162, 147);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 32);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_onClick);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(259, 147);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 32);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_onClick);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.Orange;
            this.btnSub.Location = new System.Drawing.Point(356, 185);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 32);
            this.btnSub.TabIndex = 3;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btn_onClick);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(67, 185);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 32);
            this.btn4.TabIndex = 0;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_onClick);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(67, 223);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 32);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_onClick);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(162, 185);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 32);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_onClick);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(162, 223);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 32);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_onClick);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(259, 185);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 32);
            this.btn6.TabIndex = 2;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_onClick);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(259, 223);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 32);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_onClick);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.Orange;
            this.btnMultiply.Location = new System.Drawing.Point(356, 147);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 32);
            this.btnMultiply.TabIndex = 3;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btn_onClick);
            // 
            // btnDivided
            // 
            this.btnDivided.BackColor = System.Drawing.Color.Orange;
            this.btnDivided.Location = new System.Drawing.Point(356, 109);
            this.btnDivided.Name = "btnDivided";
            this.btnDivided.Size = new System.Drawing.Size(75, 32);
            this.btnDivided.TabIndex = 3;
            this.btnDivided.Text = "/";
            this.btnDivided.UseVisualStyleBackColor = false;
            this.btnDivided.Click += new System.EventHandler(this.btn_onClick);
            // 
            // btnDzero
            // 
            this.btnDzero.Location = new System.Drawing.Point(67, 261);
            this.btnDzero.Name = "btnDzero";
            this.btnDzero.Size = new System.Drawing.Size(75, 32);
            this.btnDzero.TabIndex = 0;
            this.btnDzero.Text = "00";
            this.btnDzero.UseVisualStyleBackColor = true;
            this.btnDzero.Click += new System.EventHandler(this.btn_onClick);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(162, 261);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(75, 32);
            this.btnZero.TabIndex = 1;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btn_onClick);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(259, 261);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(75, 32);
            this.btnDot.TabIndex = 2;
            this.btnDot.Tag = "";
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btn_onClick);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.Orange;
            this.btnEqual.Location = new System.Drawing.Point(356, 261);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(75, 32);
            this.btnEqual.TabIndex = 3;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(67, 62);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(364, 32);
            this.txtDisplay.TabIndex = 4;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(453, 62);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 32);
            this.txtResult.TabIndex = 5;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 352);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnDivided);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnModulo);
            this.Controls.Add(this.btnDzero);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnAc);
            this.Name = "frmCalculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivided;
        private System.Windows.Forms.Button btnDzero;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TextBox txtResult;
    }
}

