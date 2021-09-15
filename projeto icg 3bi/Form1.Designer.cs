namespace projeto_icg_3bi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureC = new System.Windows.Forms.PictureBox();
            this.pictureB = new System.Windows.Forms.PictureBox();
            this.pictureA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureA)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureC
            // 
            this.pictureC.Location = new System.Drawing.Point(920, 33);
            this.pictureC.Name = "pictureC";
            this.pictureC.Size = new System.Drawing.Size(323, 278);
            this.pictureC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureC.TabIndex = 6;
            this.pictureC.TabStop = false;
            // 
            // pictureB
            // 
            this.pictureB.Image = ((System.Drawing.Image)(resources.GetObject("pictureB.Image")));
            this.pictureB.Location = new System.Drawing.Point(486, 33);
            this.pictureB.Name = "pictureB";
            this.pictureB.Size = new System.Drawing.Size(323, 278);
            this.pictureB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureB.TabIndex = 5;
            this.pictureB.TabStop = false;
            // 
            // pictureA
            // 
            this.pictureA.Image = ((System.Drawing.Image)(resources.GetObject("pictureA.Image")));
            this.pictureA.Location = new System.Drawing.Point(60, 33);
            this.pictureA.Name = "pictureA";
            this.pictureA.Size = new System.Drawing.Size(323, 278);
            this.pictureA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureA.TabIndex = 4;
            this.pictureA.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 579);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureC);
            this.Controls.Add(this.pictureB);
            this.Controls.Add(this.pictureA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureC;
        private System.Windows.Forms.PictureBox pictureB;
        private System.Windows.Forms.PictureBox pictureA;
    }
}

