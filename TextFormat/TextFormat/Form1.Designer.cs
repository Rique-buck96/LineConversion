namespace TextFormat
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.lstSingleLine = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(51, 338);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(112, 35);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lstSingleLine
            // 
            this.lstSingleLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSingleLine.FormattingEnabled = true;
            this.lstSingleLine.ItemHeight = 20;
            this.lstSingleLine.Location = new System.Drawing.Point(51, 66);
            this.lstSingleLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstSingleLine.Name = "lstSingleLine";
            this.lstSingleLine.Size = new System.Drawing.Size(436, 222);
            this.lstSingleLine.TabIndex = 1;
            // 
            // btnSort
            // 
            this.btnSort.Enabled = false;
            this.btnSort.Location = new System.Drawing.Point(213, 338);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(112, 35);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 383);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lstSingleLine);
            this.Controls.Add(this.btnOpen);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ListBox lstSingleLine;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

