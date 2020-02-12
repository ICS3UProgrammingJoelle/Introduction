namespace PerAreaVolJoelle
{
    partial class lblPerimeterVolumeArea
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
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnPerimeter = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnVolume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(489, 72);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(35, 13);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "label1";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(489, 209);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(489, 360);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(42, 13);
            this.lblVolume.TabIndex = 2;
            this.lblVolume.Text = "Volume";
            this.lblVolume.Click += new System.EventHandler(this.LblVolume_Click);
            // 
            // btnPerimeter
            // 
            this.btnPerimeter.Location = new System.Drawing.Point(35, 19);
            this.btnPerimeter.Name = "btnPerimeter";
            this.btnPerimeter.Size = new System.Drawing.Size(276, 118);
            this.btnPerimeter.TabIndex = 3;
            this.btnPerimeter.Text = "button1";
            this.btnPerimeter.UseVisualStyleBackColor = true;
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(35, 155);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(276, 120);
            this.btnArea.TabIndex = 4;
            this.btnArea.Text = "button2";
            this.btnArea.UseVisualStyleBackColor = true;
            // 
            // btnVolume
            // 
            this.btnVolume.Location = new System.Drawing.Point(35, 293);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(276, 119);
            this.btnVolume.TabIndex = 5;
            this.btnVolume.Text = "button3";
            this.btnVolume.UseVisualStyleBackColor = true;
            // 
            // lblPerimeterVolumeArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnPerimeter);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Name = "lblPerimeterVolumeArea";
            this.Text = "Perimeter, Area, Volume, Joelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnPerimeter;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnVolume;
    }
}

