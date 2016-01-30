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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnTransform = new System.Windows.Forms.Button();
            this.lstSingleLine = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(27, 194);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(123, 194);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(97, 23);
            this.btnTransform.TabIndex = 3;
            this.btnTransform.Text = "Transform Text";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // lstSingleLine
            // 
            this.lstSingleLine.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstSingleLine.GridLines = true;
            this.lstSingleLine.HoverSelection = true;
            this.lstSingleLine.Location = new System.Drawing.Point(27, 23);
            this.lstSingleLine.Name = "lstSingleLine";
            this.lstSingleLine.Size = new System.Drawing.Size(464, 132);
            this.lstSingleLine.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstSingleLine.TabIndex = 4;
            this.lstSingleLine.UseCompatibleStateImageBehavior = false;
            this.lstSingleLine.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 237);
            this.Controls.Add(this.lstSingleLine);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.ListView lstSingleLine;
    }
}

