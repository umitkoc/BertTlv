namespace BertTlv
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.decToHexBtn = new System.Windows.Forms.Button();
            this.hexToDec = new System.Windows.Forms.Button();
            this.decText = new System.Windows.Forms.TextBox();
            this.hexText = new System.Windows.Forms.TextBox();
            this.decodeBtn = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.inputText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.decToHexBtn);
            this.panel1.Controls.Add(this.hexToDec);
            this.panel1.Controls.Add(this.decText);
            this.panel1.Controls.Add(this.hexText);
            this.panel1.Controls.Add(this.decodeBtn);
            this.panel1.Controls.Add(this.outputText);
            this.panel1.Controls.Add(this.inputText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1737, 783);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(976, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "DEC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(669, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "HEX";
            // 
            // decToHexBtn
            // 
            this.decToHexBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decToHexBtn.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decToHexBtn.Location = new System.Drawing.Point(800, 78);
            this.decToHexBtn.Name = "decToHexBtn";
            this.decToHexBtn.Size = new System.Drawing.Size(106, 32);
            this.decToHexBtn.TabIndex = 6;
            this.decToHexBtn.Text = ">>";
            this.decToHexBtn.UseVisualStyleBackColor = true;
            this.decToHexBtn.Click += new System.EventHandler(this.decToHexBtn_Click);
            // 
            // hexToDec
            // 
            this.hexToDec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hexToDec.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hexToDec.Location = new System.Drawing.Point(800, 39);
            this.hexToDec.Name = "hexToDec";
            this.hexToDec.Size = new System.Drawing.Size(106, 33);
            this.hexToDec.TabIndex = 5;
            this.hexToDec.Text = "<<";
            this.hexToDec.UseVisualStyleBackColor = true;
            this.hexToDec.Click += new System.EventHandler(this.hexToDec_Click);
            // 
            // decText
            // 
            this.decText.BackColor = System.Drawing.SystemColors.Info;
            this.decText.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decText.Location = new System.Drawing.Point(912, 39);
            this.decText.MaxLength = 4;
            this.decText.Multiline = true;
            this.decText.Name = "decText";
            this.decText.Size = new System.Drawing.Size(184, 71);
            this.decText.TabIndex = 4;
            this.decText.Text = "00";
            this.decText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hexText
            // 
            this.hexText.BackColor = System.Drawing.SystemColors.Info;
            this.hexText.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hexText.Location = new System.Drawing.Point(600, 39);
            this.hexText.MaxLength = 4;
            this.hexText.Multiline = true;
            this.hexText.Name = "hexText";
            this.hexText.Size = new System.Drawing.Size(194, 71);
            this.hexText.TabIndex = 3;
            this.hexText.Text = "00";
            this.hexText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // decodeBtn
            // 
            this.decodeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decodeBtn.Location = new System.Drawing.Point(782, 708);
            this.decodeBtn.Name = "decodeBtn";
            this.decodeBtn.Size = new System.Drawing.Size(152, 72);
            this.decodeBtn.TabIndex = 2;
            this.decodeBtn.Text = "DECODE";
            this.decodeBtn.UseVisualStyleBackColor = true;
            this.decodeBtn.Click += new System.EventHandler(this.decodeBtn_Click);
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.SystemColors.Info;
            this.outputText.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.outputText.Location = new System.Drawing.Point(1114, 0);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(623, 783);
            this.outputText.TabIndex = 1;
            // 
            // inputText
            // 
            this.inputText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.inputText.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputText.Location = new System.Drawing.Point(0, 0);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(578, 783);
            this.inputText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1737, 783);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button decodeBtn;
        private TextBox outputText;
        private TextBox inputText;
        private Label label2;
        private Label label1;
        private Button decToHexBtn;
        private Button hexToDec;
        private TextBox decText;
        private TextBox hexText;
    }
}