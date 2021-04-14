
namespace bank
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
            this.Вивод = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.S)).BeginInit();
            this.SuspendLayout();
            // 
            // Вивод
            // 
            this.Вивод.Location = new System.Drawing.Point(15, 51);
            this.Вивод.Name = "Вивод";
            this.Вивод.Size = new System.Drawing.Size(75, 23);
            this.Вивод.TabIndex = 0;
            this.Вивод.Text = "Вивод";
            this.Вивод.UseVisualStyleBackColor = true;
            this.Вивод.Click += new System.EventHandler(this.Вивод_Click);
            // 
            // S
            // 
            this.S.Location = new System.Drawing.Point(15, 25);
            this.S.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.S.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(120, 20);
            this.S.TabIndex = 4;
            this.S.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 56);
            this.listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.S);
            this.Controls.Add(this.Вивод);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.S)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Вивод;
        private System.Windows.Forms.NumericUpDown S;
        private System.Windows.Forms.ListBox listBox1;
    }
}

