namespace WindowsFormsApp1
{
    partial class Form1
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
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_showLabel = new System.Windows.Forms.Button();
            this.button_copyText = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.groupBox_color = new System.Windows.Forms.GroupBox();
            this.radioButton_green = new System.Windows.Forms.RadioButton();
            this.radioButton_red = new System.Windows.Forms.RadioButton();
            this.label_helloWorld = new System.Windows.Forms.Label();
            this.button_color = new System.Windows.Forms.Button();
            this.label_copiedText = new System.Windows.Forms.Label();
            this.textBox_textToCopy = new System.Windows.Forms.TextBox();
            this.groupBox_color.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_showLabel
            // 
            this.button_showLabel.Location = new System.Drawing.Point(23, 30);
            this.button_showLabel.Name = "button_showLabel";
            this.button_showLabel.Size = new System.Drawing.Size(184, 85);
            this.button_showLabel.TabIndex = 0;
            this.button_showLabel.Text = "Show label";
            this.button_showLabel.UseVisualStyleBackColor = true;
            // 
            // button_copyText
            // 
            this.button_copyText.Location = new System.Drawing.Point(23, 121);
            this.button_copyText.Name = "button_copyText";
            this.button_copyText.Size = new System.Drawing.Size(184, 81);
            this.button_copyText.TabIndex = 0;
            this.button_copyText.Text = "Copy Text";
            this.button_copyText.UseVisualStyleBackColor = true;
            this.button_copyText.Click += new System.EventHandler(this.button_copyText_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(23, 285);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(184, 86);
            this.button_close.TabIndex = 0;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            // 
            // groupBox_color
            // 
            this.groupBox_color.Controls.Add(this.radioButton_red);
            this.groupBox_color.Controls.Add(this.radioButton_green);
            this.groupBox_color.Location = new System.Drawing.Point(23, 208);
            this.groupBox_color.Name = "groupBox_color";
            this.groupBox_color.Size = new System.Drawing.Size(79, 71);
            this.groupBox_color.TabIndex = 1;
            this.groupBox_color.TabStop = false;
            this.groupBox_color.Text = "Set color: ";
            this.groupBox_color.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton_green
            // 
            this.radioButton_green.AutoSize = true;
            this.radioButton_green.Location = new System.Drawing.Point(6, 42);
            this.radioButton_green.Name = "radioButton_green";
            this.radioButton_green.Size = new System.Drawing.Size(54, 17);
            this.radioButton_green.TabIndex = 0;
            this.radioButton_green.TabStop = true;
            this.radioButton_green.Text = "Green";
            this.radioButton_green.UseVisualStyleBackColor = true;
            // 
            // radioButton_red
            // 
            this.radioButton_red.AutoSize = true;
            this.radioButton_red.Location = new System.Drawing.Point(6, 19);
            this.radioButton_red.Name = "radioButton_red";
            this.radioButton_red.Size = new System.Drawing.Size(45, 17);
            this.radioButton_red.TabIndex = 0;
            this.radioButton_red.TabStop = true;
            this.radioButton_red.Text = "Red";
            this.radioButton_red.UseVisualStyleBackColor = true;
            // 
            // label_helloWorld
            // 
            this.label_helloWorld.AutoSize = true;
            this.label_helloWorld.Location = new System.Drawing.Point(227, 66);
            this.label_helloWorld.Name = "label_helloWorld";
            this.label_helloWorld.Size = new System.Drawing.Size(65, 13);
            this.label_helloWorld.TabIndex = 2;
            this.label_helloWorld.Text = "Hello World!";
            // 
            // button_color
            // 
            this.button_color.Location = new System.Drawing.Point(109, 209);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(98, 70);
            this.button_color.TabIndex = 3;
            this.button_color.UseVisualStyleBackColor = true;
            // 
            // label_copiedText
            // 
            this.label_copiedText.AutoSize = true;
            this.label_copiedText.Location = new System.Drawing.Point(348, 155);
            this.label_copiedText.Name = "label_copiedText";
            this.label_copiedText.Size = new System.Drawing.Size(0, 13);
            this.label_copiedText.TabIndex = 2;
            this.label_copiedText.Click += new System.EventHandler(this.label_copiedText_Click);
            // 
            // textBox_textToCopy
            // 
            this.textBox_textToCopy.Location = new System.Drawing.Point(230, 152);
            this.textBox_textToCopy.Name = "textBox_textToCopy";
            this.textBox_textToCopy.Size = new System.Drawing.Size(100, 20);
            this.textBox_textToCopy.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 418);
            this.Controls.Add(this.textBox_textToCopy);
            this.Controls.Add(this.button_color);
            this.Controls.Add(this.label_copiedText);
            this.Controls.Add(this.label_helloWorld);
            this.Controls.Add(this.groupBox_color);
            this.Controls.Add(this.button_copyText);
            this.Controls.Add(this.button_showLabel);
            this.Controls.Add(this.button_close);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_color.ResumeLayout(false);
            this.groupBox_color.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_showLabel;
        private System.Windows.Forms.Button button_copyText;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.GroupBox groupBox_color;
        private System.Windows.Forms.RadioButton radioButton_red;
        private System.Windows.Forms.RadioButton radioButton_green;
        private System.Windows.Forms.Label label_helloWorld;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.Label label_copiedText;
        private System.Windows.Forms.TextBox textBox_textToCopy;
    }
}

