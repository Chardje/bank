
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
            this.SText = new System.Windows.Forms.Label();
            this.RText = new System.Windows.Forms.Label();
            this.NText = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.NumericUpDown();
            this.R = new System.Windows.Forms.NumericUpDown();
            this.N = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N)).BeginInit();
            this.SuspendLayout();
            // 
            // Вивод
            // 
            this.Вивод.Location = new System.Drawing.Point(12, 123);
            this.Вивод.Name = "Вивод";
            this.Вивод.Size = new System.Drawing.Size(75, 23);
            this.Вивод.TabIndex = 0;
            this.Вивод.Text = "Вивод";
            this.Вивод.UseVisualStyleBackColor = true;
            this.Вивод.Click += new System.EventHandler(this.Вивод_Click);
            // 
            // SText
            // 
            this.SText.AutoSize = true;
            this.SText.Location = new System.Drawing.Point(12, 9);
            this.SText.Name = "SText";
            this.SText.Size = new System.Drawing.Size(45, 13);
            this.SText.TabIndex = 1;
            this.SText.Text = "Деньги";
            // 
            // RText
            // 
            this.RText.AutoSize = true;
            this.RText.Location = new System.Drawing.Point(12, 46);
            this.RText.Name = "RText";
            this.RText.Size = new System.Drawing.Size(50, 13);
            this.RText.TabIndex = 2;
            this.RText.Text = "Процент";
            // 
            // NText
            // 
            this.NText.AutoSize = true;
            this.NText.Location = new System.Drawing.Point(12, 81);
            this.NText.Name = "NText";
            this.NText.Size = new System.Drawing.Size(104, 13);
            this.NText.TabIndex = 3;
            this.NText.Text = "Через сколько лет";
            // 
            // S
            // 
            this.S.Location = new System.Drawing.Point(15, 25);
            this.S.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(120, 20);
            this.S.TabIndex = 4;
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(15, 58);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(120, 20);
            this.R.TabIndex = 5;
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(15, 97);
            this.N.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(120, 20);
            this.N.TabIndex = 6;
            this.N.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.N);
            this.Controls.Add(this.R);
            this.Controls.Add(this.S);
            this.Controls.Add(this.NText);
            this.Controls.Add(this.RText);
            this.Controls.Add(this.SText);
            this.Controls.Add(this.Вивод);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Вивод;
        private System.Windows.Forms.Label SText;
        private System.Windows.Forms.Label RText;
        private System.Windows.Forms.Label NText;
        private System.Windows.Forms.NumericUpDown S;
        private System.Windows.Forms.NumericUpDown R;
        private System.Windows.Forms.NumericUpDown N;
    }
}

