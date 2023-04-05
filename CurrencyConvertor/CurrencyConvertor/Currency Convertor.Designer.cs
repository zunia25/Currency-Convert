namespace CurrencyConvertor
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
            this.label1 = new System.Windows.Forms.Label();
            this.Amount_Txt = new System.Windows.Forms.TextBox();
            this.fromcombo1 = new System.Windows.Forms.ComboBox();
            this.tocombo2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.display_txt = new System.Windows.Forms.Label();
            this.Cnvrt_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Amount";
            // 
            // Amount_Txt
            // 
            this.Amount_Txt.Location = new System.Drawing.Point(209, 76);
            this.Amount_Txt.Name = "Amount_Txt";
            this.Amount_Txt.Size = new System.Drawing.Size(150, 22);
            this.Amount_Txt.TabIndex = 1;
            // 
            // fromcombo1
            // 
            this.fromcombo1.FormattingEnabled = true;
            this.fromcombo1.Items.AddRange(new object[] {
            "Rupees",
            "Dollar",
            "Euro"});
            this.fromcombo1.Location = new System.Drawing.Point(209, 136);
            this.fromcombo1.Name = "fromcombo1";
            this.fromcombo1.Size = new System.Drawing.Size(150, 24);
            this.fromcombo1.TabIndex = 2;
            // 
            // tocombo2
            // 
            this.tocombo2.FormattingEnabled = true;
            this.tocombo2.Items.AddRange(new object[] {
            "Rupees",
            "Dollar",
            "Euro"});
            this.tocombo2.Location = new System.Drawing.Point(209, 197);
            this.tocombo2.Name = "tocombo2";
            this.tocombo2.Size = new System.Drawing.Size(150, 24);
            this.tocombo2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Convert From";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Convert To";
            // 
            // display_txt
            // 
            this.display_txt.AutoSize = true;
            this.display_txt.Location = new System.Drawing.Point(120, 268);
            this.display_txt.Name = "display_txt";
            this.display_txt.Size = new System.Drawing.Size(123, 16);
            this.display_txt.TabIndex = 6;
            this.display_txt.Text = "Converted Amount :";
            // 
            // Cnvrt_btn
            // 
            this.Cnvrt_btn.Location = new System.Drawing.Point(376, 76);
            this.Cnvrt_btn.Name = "Cnvrt_btn";
            this.Cnvrt_btn.Size = new System.Drawing.Size(75, 23);
            this.Cnvrt_btn.TabIndex = 7;
            this.Cnvrt_btn.Text = "Convert";
            this.Cnvrt_btn.UseVisualStyleBackColor = true;
            this.Cnvrt_btn.Click += new System.EventHandler(this.Cnvrt_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 365);
            this.Controls.Add(this.Cnvrt_btn);
            this.Controls.Add(this.display_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tocombo2);
            this.Controls.Add(this.fromcombo1);
            this.Controls.Add(this.Amount_Txt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Convertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Amount_Txt;
        private System.Windows.Forms.ComboBox fromcombo1;
        private System.Windows.Forms.ComboBox tocombo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label display_txt;
        private System.Windows.Forms.Button Cnvrt_btn;
    }
}

