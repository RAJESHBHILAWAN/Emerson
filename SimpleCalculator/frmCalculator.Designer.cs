namespace SimpleCalculator
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
            this.Display = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnequals = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.White;
            this.Display.Location = new System.Drawing.Point(18, 18);
            this.Display.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(326, 26);
            this.Display.TabIndex = 0;
            this.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(18, 67);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(57, 35);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(85, 67);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(57, 35);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(150, 67);
            this.btn3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(57, 35);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(224, 67);
            this.btndiv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(57, 35);
            this.btndiv.TabIndex = 4;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // btnequals
            // 
            this.btnequals.Location = new System.Drawing.Point(290, 67);
            this.btnequals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnequals.Name = "btnequals";
            this.btnequals.Size = new System.Drawing.Size(57, 35);
            this.btnequals.TabIndex = 5;
            this.btnequals.Text = "=";
            this.btnequals.UseVisualStyleBackColor = true;
            this.btnequals.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(224, 123);
            this.btnplus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(57, 35);
            this.btnplus.TabIndex = 6;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(290, 123);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(57, 35);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 402);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btnequals);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.Display);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCalculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnequals;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnclear;
    }
}

