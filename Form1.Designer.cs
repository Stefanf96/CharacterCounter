
namespace CharacterCounter
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
            this.CheckCharacterCount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DocumentName = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.CharComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CheckCharacterCount
            // 
            this.CheckCharacterCount.Location = new System.Drawing.Point(350, 291);
            this.CheckCharacterCount.Name = "CheckCharacterCount";
            this.CheckCharacterCount.Size = new System.Drawing.Size(94, 29);
            this.CheckCharacterCount.TabIndex = 0;
            this.CheckCharacterCount.Text = "Check";
            this.CheckCharacterCount.UseVisualStyleBackColor = true;
            this.CheckCharacterCount.Click += new System.EventHandler(this.CheckCharacterCount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(265, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Character Counter";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DocumentName
            // 
            this.DocumentName.Location = new System.Drawing.Point(239, 183);
            this.DocumentName.Name = "DocumentName";
            this.DocumentName.Size = new System.Drawing.Size(231, 27);
            this.DocumentName.TabIndex = 2;
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(476, 181);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(94, 29);
            this.Browse.TabIndex = 3;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // CharComboBox
            // 
            this.CharComboBox.FormattingEnabled = true;
            this.CharComboBox.Location = new System.Drawing.Point(239, 233);
            this.CharComboBox.Name = "CharComboBox";
            this.CharComboBox.Size = new System.Drawing.Size(331, 28);
            this.CharComboBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CharComboBox);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.DocumentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckCharacterCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.ComboBox CharComboBox;
        private System.Windows.Forms.TextBox DocumentName;
        private System.Windows.Forms.Button CheckCharacterCount;
    }
}

