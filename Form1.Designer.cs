namespace TugasPASGanjil
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
            this.intent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // intent
            // 
            this.intent.Location = new System.Drawing.Point(89, 208);
            this.intent.Name = "intent";
            this.intent.Size = new System.Drawing.Size(75, 23);
            this.intent.TabIndex = 0;
            this.intent.Text = "intent";
            this.intent.UseVisualStyleBackColor = true;
            this.intent.Click += new System.EventHandler(this.intent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 261);
            this.Controls.Add(this.intent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button intent;
    }
}

