
namespace Ders30_RadioButton
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
            this.rbKirmizi = new System.Windows.Forms.RadioButton();
            this.rbMavi = new System.Windows.Forms.RadioButton();
            this.rbTuruncu = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbKirmizi
            // 
            this.rbKirmizi.AutoSize = true;
            this.rbKirmizi.Location = new System.Drawing.Point(140, 115);
            this.rbKirmizi.Name = "rbKirmizi";
            this.rbKirmizi.Size = new System.Drawing.Size(61, 19);
            this.rbKirmizi.TabIndex = 0;
            this.rbKirmizi.TabStop = true;
            this.rbKirmizi.Text = "Kırmızı";
            this.rbKirmizi.UseVisualStyleBackColor = true;
            // 
            // rbMavi
            // 
            this.rbMavi.AutoSize = true;
            this.rbMavi.Location = new System.Drawing.Point(140, 154);
            this.rbMavi.Name = "rbMavi";
            this.rbMavi.Size = new System.Drawing.Size(51, 19);
            this.rbMavi.TabIndex = 1;
            this.rbMavi.TabStop = true;
            this.rbMavi.Text = "Mavi";
            this.rbMavi.UseVisualStyleBackColor = true;
            // 
            // rbTuruncu
            // 
            this.rbTuruncu.AutoSize = true;
            this.rbTuruncu.Location = new System.Drawing.Point(140, 200);
            this.rbTuruncu.Name = "rbTuruncu";
            this.rbTuruncu.Size = new System.Drawing.Size(69, 19);
            this.rbTuruncu.TabIndex = 2;
            this.rbTuruncu.TabStop = true;
            this.rbTuruncu.Text = "Turuncu";
            this.rbTuruncu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbTuruncu);
            this.Controls.Add(this.rbMavi);
            this.Controls.Add(this.rbKirmizi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbKirmizi;
        private System.Windows.Forms.RadioButton rbMavi;
        private System.Windows.Forms.RadioButton rbTuruncu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

