namespace GrafyRysowanie
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DFS = new System.Windows.Forms.CheckBox();
            this.BFS = new System.Windows.Forms.CheckBox();
            this.Przeszukiwanie = new System.Windows.Forms.Button();
            this.Wyczysc = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(727, 520);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // DFS
            // 
            this.DFS.AutoSize = true;
            this.DFS.Location = new System.Drawing.Point(509, 162);
            this.DFS.Name = "DFS";
            this.DFS.Size = new System.Drawing.Size(50, 19);
            this.DFS.TabIndex = 1;
            this.DFS.Text = "DFS";
            this.DFS.UseVisualStyleBackColor = true;
            this.DFS.CheckedChanged += new System.EventHandler(this.DFS_CheckedChanged);
            // 
            // BFS
            // 
            this.BFS.AutoSize = true;
            this.BFS.Location = new System.Drawing.Point(509, 200);
            this.BFS.Name = "BFS";
            this.BFS.Size = new System.Drawing.Size(49, 19);
            this.BFS.TabIndex = 2;
            this.BFS.Text = "BFS";
            this.BFS.UseVisualStyleBackColor = true;
            this.BFS.CheckedChanged += new System.EventHandler(this.BFS_CheckedChanged);
            // 
            // Przeszukiwanie
            // 
            this.Przeszukiwanie.Location = new System.Drawing.Point(509, 254);
            this.Przeszukiwanie.Name = "Przeszukiwanie";
            this.Przeszukiwanie.Size = new System.Drawing.Size(111, 23);
            this.Przeszukiwanie.TabIndex = 3;
            this.Przeszukiwanie.Text = "Przeszukiwanie";
            this.Przeszukiwanie.UseVisualStyleBackColor = true;
            this.Przeszukiwanie.Click += new System.EventHandler(this.Przeszukiwanie_Click);
            // 
            // Wyczysc
            // 
            this.Wyczysc.Location = new System.Drawing.Point(626, 254);
            this.Wyczysc.Name = "Wyczysc";
            this.Wyczysc.Size = new System.Drawing.Size(86, 23);
            this.Wyczysc.TabIndex = 4;
            this.Wyczysc.Text = "Wyczysc";
            this.Wyczysc.UseVisualStyleBackColor = true;
            this.Wyczysc.Click += new System.EventHandler(this.Wyczysc_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(509, 295);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(203, 200);
            this.richTextBox.TabIndex = 5;
            this.richTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 520);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.Wyczysc);
            this.Controls.Add(this.Przeszukiwanie);
            this.Controls.Add(this.BFS);
            this.Controls.Add(this.DFS);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox DFS;
        private System.Windows.Forms.CheckBox BFS;
        private System.Windows.Forms.Button Przeszukiwanie;
        private System.Windows.Forms.Button Wyczysc;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}

