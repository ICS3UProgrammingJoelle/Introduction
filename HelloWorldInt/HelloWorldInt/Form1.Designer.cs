namespace HelloWorldInt
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
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.grpLanguages = new System.Windows.Forms.GroupBox();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.radFrançais = new System.Windows.Forms.RadioButton();
            this.radEspañol = new System.Windows.Forms.RadioButton();
            this.radTürk = new System.Windows.Forms.RadioButton();
            this.grpLanguages.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Font = new System.Drawing.Font("Microsoft YaHei", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.Location = new System.Drawing.Point(279, 124);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(336, 64);
            this.lblHelloWorld.TabIndex = 0;
            this.lblHelloWorld.Text = "Hello World!";
            this.lblHelloWorld.Click += new System.EventHandler(this.LblHelloWorld_Click);
            // 
            // grpLanguages
            // 
            this.grpLanguages.Controls.Add(this.radTürk);
            this.grpLanguages.Controls.Add(this.radEspañol);
            this.grpLanguages.Controls.Add(this.radFrançais);
            this.grpLanguages.Controls.Add(this.radEnglish);
            this.grpLanguages.Location = new System.Drawing.Point(174, 307);
            this.grpLanguages.Name = "grpLanguages";
            this.grpLanguages.Size = new System.Drawing.Size(574, 179);
            this.grpLanguages.TabIndex = 5;
            this.grpLanguages.TabStop = false;
            this.grpLanguages.Text = "Languages";
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Location = new System.Drawing.Point(45, 91);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(64, 20);
            this.radEnglish.TabIndex = 5;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.RadEnglish_CheckedChanged);
            // 
            // radFrançais
            // 
            this.radFrançais.AutoSize = true;
            this.radFrançais.Location = new System.Drawing.Point(179, 91);
            this.radFrançais.Name = "radFrançais";
            this.radFrançais.Size = new System.Drawing.Size(70, 20);
            this.radFrançais.TabIndex = 6;
            this.radFrançais.TabStop = true;
            this.radFrançais.Text = "Français";
            this.radFrançais.UseVisualStyleBackColor = true;
            this.radFrançais.CheckedChanged += new System.EventHandler(this.RadFrançais_CheckedChanged);
            // 
            // radEspañol
            // 
            this.radEspañol.AutoSize = true;
            this.radEspañol.Location = new System.Drawing.Point(316, 91);
            this.radEspañol.Name = "radEspañol";
            this.radEspañol.Size = new System.Drawing.Size(67, 20);
            this.radEspañol.TabIndex = 7;
            this.radEspañol.TabStop = true;
            this.radEspañol.Text = "Español";
            this.radEspañol.UseVisualStyleBackColor = true;
            this.radEspañol.CheckedChanged += new System.EventHandler(this.RadEspañol_CheckedChanged);
            // 
            // radTürk
            // 
            this.radTürk.AutoSize = true;
            this.radTürk.Location = new System.Drawing.Point(455, 91);
            this.radTürk.Name = "radTürk";
            this.radTürk.Size = new System.Drawing.Size(52, 20);
            this.radTürk.TabIndex = 8;
            this.radTürk.TabStop = true;
            this.radTürk.Text = "Türk";
            this.radTürk.UseVisualStyleBackColor = true;
            this.radTürk.CheckedChanged += new System.EventHandler(this.RadTürk_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.grpLanguages);
            this.Controls.Add(this.lblHelloWorld);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpLanguages.ResumeLayout(false);
            this.grpLanguages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.GroupBox grpLanguages;
        private System.Windows.Forms.RadioButton radTürk;
        private System.Windows.Forms.RadioButton radEspañol;
        private System.Windows.Forms.RadioButton radFrançais;
        private System.Windows.Forms.RadioButton radEnglish;
    }
}

