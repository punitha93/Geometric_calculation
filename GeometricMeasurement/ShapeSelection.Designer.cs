namespace GeometricMeasurement
{
    partial class ShapeSelection
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
            this.squarebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.circlebtn = new System.Windows.Forms.Button();
            this.rectanglebtn = new System.Windows.Forms.Button();
            this.trianglebtn = new System.Windows.Forms.Button();
            this.cubebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // squarebtn
            // 
            this.squarebtn.BackColor = System.Drawing.Color.Teal;
            this.squarebtn.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squarebtn.Location = new System.Drawing.Point(101, 98);
            this.squarebtn.Name = "squarebtn";
            this.squarebtn.Size = new System.Drawing.Size(160, 56);
            this.squarebtn.TabIndex = 0;
            this.squarebtn.Text = "Square";
            this.squarebtn.UseVisualStyleBackColor = false;
            this.squarebtn.Click += new System.EventHandler(this.squarebtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Shape";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // circlebtn
            // 
            this.circlebtn.BackColor = System.Drawing.Color.Teal;
            this.circlebtn.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circlebtn.Location = new System.Drawing.Point(521, 98);
            this.circlebtn.Name = "circlebtn";
            this.circlebtn.Size = new System.Drawing.Size(160, 56);
            this.circlebtn.TabIndex = 2;
            this.circlebtn.Text = "Circle";
            this.circlebtn.UseVisualStyleBackColor = false;
            this.circlebtn.Click += new System.EventHandler(this.circlebtn_Click);
            // 
            // rectanglebtn
            // 
            this.rectanglebtn.BackColor = System.Drawing.Color.Teal;
            this.rectanglebtn.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rectanglebtn.Location = new System.Drawing.Point(101, 284);
            this.rectanglebtn.Name = "rectanglebtn";
            this.rectanglebtn.Size = new System.Drawing.Size(160, 56);
            this.rectanglebtn.TabIndex = 3;
            this.rectanglebtn.Text = "Rectangle";
            this.rectanglebtn.UseVisualStyleBackColor = false;
            this.rectanglebtn.Click += new System.EventHandler(this.rectanglebtn_Click);
            // 
            // trianglebtn
            // 
            this.trianglebtn.BackColor = System.Drawing.Color.Teal;
            this.trianglebtn.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trianglebtn.Location = new System.Drawing.Point(521, 275);
            this.trianglebtn.Name = "trianglebtn";
            this.trianglebtn.Size = new System.Drawing.Size(160, 56);
            this.trianglebtn.TabIndex = 4;
            this.trianglebtn.Text = "Triangle";
            this.trianglebtn.UseVisualStyleBackColor = false;
            this.trianglebtn.Click += new System.EventHandler(this.trianglebtn_Click);
            // 
            // cubebtn
            // 
            this.cubebtn.BackColor = System.Drawing.Color.Teal;
            this.cubebtn.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cubebtn.Location = new System.Drawing.Point(316, 196);
            this.cubebtn.Name = "cubebtn";
            this.cubebtn.Size = new System.Drawing.Size(160, 56);
            this.cubebtn.TabIndex = 5;
            this.cubebtn.Text = "Cube";
            this.cubebtn.UseVisualStyleBackColor = false;
            this.cubebtn.Click += new System.EventHandler(this.cubebtn_Click);
            // 
            // ShapeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cubebtn);
            this.Controls.Add(this.trianglebtn);
            this.Controls.Add(this.rectanglebtn);
            this.Controls.Add(this.circlebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.squarebtn);
            this.Name = "ShapeSelection";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button squarebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button circlebtn;
        private System.Windows.Forms.Button rectanglebtn;
        private System.Windows.Forms.Button trianglebtn;
        private System.Windows.Forms.Button cubebtn;
    }
}