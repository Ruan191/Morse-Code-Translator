namespace Morse_Code_Translator
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
            this.Mors_Code = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NormalText = new System.Windows.Forms.RichTextBox();
            this.ToMorse = new System.Windows.Forms.Button();
            this.ToText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mors_Code
            // 
            this.Mors_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mors_Code.Location = new System.Drawing.Point(434, 31);
            this.Mors_Code.Name = "Mors_Code";
            this.Mors_Code.Size = new System.Drawing.Size(354, 392);
            this.Mors_Code.TabIndex = 0;
            this.Mors_Code.Text = "";
            this.Mors_Code.TextChanged += new System.EventHandler(this.Mors_Code_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(806, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mors Code";
            // 
            // NormalText
            // 
            this.NormalText.Location = new System.Drawing.Point(12, 31);
            this.NormalText.Name = "NormalText";
            this.NormalText.Size = new System.Drawing.Size(354, 392);
            this.NormalText.TabIndex = 5;
            this.NormalText.Text = "";
            this.NormalText.TextChanged += new System.EventHandler(this.NormalText_TextChanged);
            this.NormalText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NormalText_KeyDown);
            this.NormalText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NormalText_KeyPress);
            // 
            // ToMorse
            // 
            this.ToMorse.Location = new System.Drawing.Point(372, 201);
            this.ToMorse.Name = "ToMorse";
            this.ToMorse.Size = new System.Drawing.Size(56, 23);
            this.ToMorse.TabIndex = 6;
            this.ToMorse.Text = "ToMorse";
            this.ToMorse.UseVisualStyleBackColor = true;
            this.ToMorse.Click += new System.EventHandler(this.ToMorse_Click);
            // 
            // ToText
            // 
            this.ToText.Location = new System.Drawing.Point(372, 230);
            this.ToText.Name = "ToText";
            this.ToText.Size = new System.Drawing.Size(56, 23);
            this.ToText.TabIndex = 7;
            this.ToText.Text = "ToText";
            this.ToText.UseVisualStyleBackColor = true;
            this.ToText.Click += new System.EventHandler(this.ToText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.ToText);
            this.Controls.Add(this.ToMorse);
            this.Controls.Add(this.NormalText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Mors_Code);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Mors_Code;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox NormalText;
        private System.Windows.Forms.Button ToMorse;
        private System.Windows.Forms.Button ToText;
    }
}

