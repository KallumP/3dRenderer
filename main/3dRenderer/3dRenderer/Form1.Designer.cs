namespace _3dRenderer {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.xRot = new System.Windows.Forms.Button();
            this.yRot = new System.Windows.Forms.Button();
            this.zRot = new System.Windows.Forms.Button();
            this.loop = new System.Windows.Forms.Timer(this.components);
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xRot
            // 
            this.xRot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xRot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xRot.Location = new System.Drawing.Point(697, 12);
            this.xRot.Name = "xRot";
            this.xRot.Size = new System.Drawing.Size(91, 23);
            this.xRot.TabIndex = 0;
            this.xRot.Text = "Rotate X Axis";
            this.xRot.UseVisualStyleBackColor = true;
            this.xRot.Click += new System.EventHandler(this.xRot_Click);
            // 
            // yRot
            // 
            this.yRot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yRot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yRot.Location = new System.Drawing.Point(697, 42);
            this.yRot.Name = "yRot";
            this.yRot.Size = new System.Drawing.Size(91, 23);
            this.yRot.TabIndex = 1;
            this.yRot.Text = "Rotate Y Axis";
            this.yRot.UseVisualStyleBackColor = true;
            this.yRot.Click += new System.EventHandler(this.yRot_Click);
            // 
            // zRot
            // 
            this.zRot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zRot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zRot.Location = new System.Drawing.Point(697, 72);
            this.zRot.Name = "zRot";
            this.zRot.Size = new System.Drawing.Size(91, 23);
            this.zRot.TabIndex = 2;
            this.zRot.Text = "Rotate Z Axis";
            this.zRot.UseVisualStyleBackColor = true;
            this.zRot.Click += new System.EventHandler(this.zRot_Click);
            // 
            // loop
            // 
            this.loop.Enabled = true;
            this.loop.Interval = 30;
            this.loop.Tick += new System.EventHandler(this.loop_Tick);
            // 
            // reset
            // 
            this.reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Location = new System.Drawing.Point(697, 415);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(91, 23);
            this.reset.TabIndex = 3;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.zRot);
            this.Controls.Add(this.yRot);
            this.Controls.Add(this.xRot);
            this.Name = "Form1";
            this.Text = "3D Renderer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button xRot;
        private System.Windows.Forms.Button yRot;
        private System.Windows.Forms.Button zRot;
        private System.Windows.Forms.Timer loop;
        private System.Windows.Forms.Button reset;
    }
}

