namespace WindowsFormsOddEvenNumber
{
    partial class OddEvenNumber
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.clickButton = new System.Windows.Forms.Button();
            this.inputNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clickButton
            // 
            this.clickButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clickButton.Location = new System.Drawing.Point(295, 253);
            this.clickButton.Name = "clickButton";
            this.clickButton.Size = new System.Drawing.Size(172, 23);
            this.clickButton.TabIndex = 0;
            this.clickButton.Text = "Check it!";
            this.clickButton.UseVisualStyleBackColor = true;
            this.clickButton.Click += new System.EventHandler(this.clickButton_Click);
            // 
            // inputNumber
            // 
            this.inputNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inputNumber.Location = new System.Drawing.Point(331, 190);
            this.inputNumber.Name = "inputNumber";
            this.inputNumber.Size = new System.Drawing.Size(100, 20);
            this.inputNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Location = new System.Drawing.Point(275, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Put number here. Check it is even or odd";
            // 
            // OddEvenNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputNumber);
            this.Controls.Add(this.clickButton);
            this.Name = "OddEvenNumber";
            this.Text = "OddEvenNumber";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickButton;
        private System.Windows.Forms.TextBox inputNumber;
        private System.Windows.Forms.Label label1;
    }
}

