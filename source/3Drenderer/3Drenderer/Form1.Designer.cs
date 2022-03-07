namespace _3Drenderer {
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
            this.yzRot = new System.Windows.Forms.Button();
            this.xzRot = new System.Windows.Forms.Button();
            this.xyRot = new System.Windows.Forms.Button();
            this.loop = new System.Windows.Forms.Timer(this.components);
            this.reset = new System.Windows.Forms.Button();
            this.xwRot = new System.Windows.Forms.Button();
            this.createSquare_btn = new System.Windows.Forms.Button();
            this.createCube_btn = new System.Windows.Forms.Button();
            this.createHyper_btn = new System.Windows.Forms.Button();
            this.xwRot_lbl = new System.Windows.Forms.Label();
            this.xyRot_lbl = new System.Windows.Forms.Label();
            this.xzRot_lbl = new System.Windows.Forms.Label();
            this.yzRot_lbl = new System.Windows.Forms.Label();
            this.angle_bar = new System.Windows.Forms.TrackBar();
            this.angle_lbl = new System.Windows.Forms.Label();
            this.distance_bar = new System.Windows.Forms.TrackBar();
            this.distance_lbl = new System.Windows.Forms.Label();
            this.scale_lbl = new System.Windows.Forms.Label();
            this.scale_bar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.angle_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scale_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // yzRot
            // 
            this.yzRot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yzRot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yzRot.Location = new System.Drawing.Point(697, 12);
            this.yzRot.Name = "yzRot";
            this.yzRot.Size = new System.Drawing.Size(91, 23);
            this.yzRot.TabIndex = 0;
            this.yzRot.Text = "Rotate YZ Axis";
            this.yzRot.UseVisualStyleBackColor = true;
            this.yzRot.Click += new System.EventHandler(this.yzRot_Click);
            // 
            // xzRot
            // 
            this.xzRot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xzRot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xzRot.Location = new System.Drawing.Point(697, 42);
            this.xzRot.Name = "xzRot";
            this.xzRot.Size = new System.Drawing.Size(91, 23);
            this.xzRot.TabIndex = 1;
            this.xzRot.Text = "Rotate XZ Axis";
            this.xzRot.UseVisualStyleBackColor = true;
            this.xzRot.Click += new System.EventHandler(this.xzRot_Click);
            // 
            // xyRot
            // 
            this.xyRot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xyRot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xyRot.Location = new System.Drawing.Point(697, 72);
            this.xyRot.Name = "xyRot";
            this.xyRot.Size = new System.Drawing.Size(91, 23);
            this.xyRot.TabIndex = 2;
            this.xyRot.Text = "Rotate XY Axis";
            this.xyRot.UseVisualStyleBackColor = true;
            this.xyRot.Click += new System.EventHandler(this.xyRot_Click);
            // 
            // loop
            // 
            this.loop.Enabled = true;
            this.loop.Interval = 50;
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
            // xwRot
            // 
            this.xwRot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xwRot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xwRot.Location = new System.Drawing.Point(697, 101);
            this.xwRot.Name = "xwRot";
            this.xwRot.Size = new System.Drawing.Size(91, 23);
            this.xwRot.TabIndex = 4;
            this.xwRot.Text = "Rotate XW Axis";
            this.xwRot.UseVisualStyleBackColor = true;
            this.xwRot.Click += new System.EventHandler(this.xwRot_Click);
            // 
            // createSquare_btn
            // 
            this.createSquare_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createSquare_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createSquare_btn.Location = new System.Drawing.Point(697, 182);
            this.createSquare_btn.Name = "createSquare_btn";
            this.createSquare_btn.Size = new System.Drawing.Size(91, 23);
            this.createSquare_btn.TabIndex = 5;
            this.createSquare_btn.Text = "Create Square";
            this.createSquare_btn.UseVisualStyleBackColor = true;
            this.createSquare_btn.Click += new System.EventHandler(this.createSquare_btn_Click);
            // 
            // createCube_btn
            // 
            this.createCube_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createCube_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCube_btn.Location = new System.Drawing.Point(697, 211);
            this.createCube_btn.Name = "createCube_btn";
            this.createCube_btn.Size = new System.Drawing.Size(91, 23);
            this.createCube_btn.TabIndex = 6;
            this.createCube_btn.Text = "Create Cube";
            this.createCube_btn.UseVisualStyleBackColor = true;
            this.createCube_btn.Click += new System.EventHandler(this.createCube_btn_Click);
            // 
            // createHyper_btn
            // 
            this.createHyper_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createHyper_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createHyper_btn.Location = new System.Drawing.Point(697, 240);
            this.createHyper_btn.Name = "createHyper_btn";
            this.createHyper_btn.Size = new System.Drawing.Size(91, 39);
            this.createHyper_btn.TabIndex = 7;
            this.createHyper_btn.Text = "Create Hypercube";
            this.createHyper_btn.UseVisualStyleBackColor = true;
            this.createHyper_btn.Click += new System.EventHandler(this.createHyper_btn_Click);
            // 
            // xwRot_lbl
            // 
            this.xwRot_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xwRot_lbl.AutoSize = true;
            this.xwRot_lbl.Location = new System.Drawing.Point(644, 106);
            this.xwRot_lbl.Name = "xwRot_lbl";
            this.xwRot_lbl.Size = new System.Drawing.Size(35, 13);
            this.xwRot_lbl.TabIndex = 8;
            this.xwRot_lbl.Text = "label1";
            // 
            // xyRot_lbl
            // 
            this.xyRot_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xyRot_lbl.AutoSize = true;
            this.xyRot_lbl.Location = new System.Drawing.Point(644, 77);
            this.xyRot_lbl.Name = "xyRot_lbl";
            this.xyRot_lbl.Size = new System.Drawing.Size(35, 13);
            this.xyRot_lbl.TabIndex = 9;
            this.xyRot_lbl.Text = "label2";
            // 
            // xzRot_lbl
            // 
            this.xzRot_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xzRot_lbl.AutoSize = true;
            this.xzRot_lbl.Location = new System.Drawing.Point(644, 47);
            this.xzRot_lbl.Name = "xzRot_lbl";
            this.xzRot_lbl.Size = new System.Drawing.Size(35, 13);
            this.xzRot_lbl.TabIndex = 10;
            this.xzRot_lbl.Text = "label3";
            // 
            // yzRot_lbl
            // 
            this.yzRot_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yzRot_lbl.AutoSize = true;
            this.yzRot_lbl.Location = new System.Drawing.Point(644, 17);
            this.yzRot_lbl.Name = "yzRot_lbl";
            this.yzRot_lbl.Size = new System.Drawing.Size(35, 13);
            this.yzRot_lbl.TabIndex = 11;
            this.yzRot_lbl.Text = "label4";
            // 
            // angle_bar
            // 
            this.angle_bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.angle_bar.Location = new System.Drawing.Point(12, 393);
            this.angle_bar.Maximum = 100;
            this.angle_bar.Name = "angle_bar";
            this.angle_bar.Size = new System.Drawing.Size(295, 45);
            this.angle_bar.TabIndex = 12;
            this.angle_bar.Scroll += new System.EventHandler(this.angle_bar_Scroll);
            // 
            // angle_lbl
            // 
            this.angle_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.angle_lbl.AutoSize = true;
            this.angle_lbl.Location = new System.Drawing.Point(195, 428);
            this.angle_lbl.Name = "angle_lbl";
            this.angle_lbl.Size = new System.Drawing.Size(46, 13);
            this.angle_lbl.TabIndex = 13;
            this.angle_lbl.Text = "Angle: 0";
            // 
            // distance_bar
            // 
            this.distance_bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.distance_bar.Location = new System.Drawing.Point(313, 393);
            this.distance_bar.Maximum = 2000;
            this.distance_bar.Minimum = 200;
            this.distance_bar.Name = "distance_bar";
            this.distance_bar.Size = new System.Drawing.Size(295, 45);
            this.distance_bar.TabIndex = 14;
            this.distance_bar.TickFrequency = 10;
            this.distance_bar.Value = 200;
            this.distance_bar.Scroll += new System.EventHandler(this.distance_bar_Scroll);
            // 
            // distance_lbl
            // 
            this.distance_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.distance_lbl.AutoSize = true;
            this.distance_lbl.Location = new System.Drawing.Point(493, 425);
            this.distance_lbl.Name = "distance_lbl";
            this.distance_lbl.Size = new System.Drawing.Size(61, 13);
            this.distance_lbl.TabIndex = 15;
            this.distance_lbl.Text = "Distance: 0";
            // 
            // scale_lbl
            // 
            this.scale_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scale_lbl.AutoSize = true;
            this.scale_lbl.Location = new System.Drawing.Point(195, 377);
            this.scale_lbl.Name = "scale_lbl";
            this.scale_lbl.Size = new System.Drawing.Size(46, 13);
            this.scale_lbl.TabIndex = 17;
            this.scale_lbl.Text = "Scale: 0";
            // 
            // scale_bar
            // 
            this.scale_bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scale_bar.Location = new System.Drawing.Point(12, 342);
            this.scale_bar.Maximum = 5000;
            this.scale_bar.Minimum = 100;
            this.scale_bar.Name = "scale_bar";
            this.scale_bar.Size = new System.Drawing.Size(295, 45);
            this.scale_bar.TabIndex = 16;
            this.scale_bar.TickFrequency = 10;
            this.scale_bar.Value = 100;
            this.scale_bar.Scroll += new System.EventHandler(this.scale_bar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scale_lbl);
            this.Controls.Add(this.scale_bar);
            this.Controls.Add(this.distance_lbl);
            this.Controls.Add(this.distance_bar);
            this.Controls.Add(this.angle_lbl);
            this.Controls.Add(this.angle_bar);
            this.Controls.Add(this.yzRot_lbl);
            this.Controls.Add(this.xzRot_lbl);
            this.Controls.Add(this.xyRot_lbl);
            this.Controls.Add(this.xwRot_lbl);
            this.Controls.Add(this.createHyper_btn);
            this.Controls.Add(this.createCube_btn);
            this.Controls.Add(this.createSquare_btn);
            this.Controls.Add(this.xwRot);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.xyRot);
            this.Controls.Add(this.xzRot);
            this.Controls.Add(this.yzRot);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "3D Renderer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.angle_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scale_bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yzRot;
        private System.Windows.Forms.Button xzRot;
        private System.Windows.Forms.Button xyRot;
        private System.Windows.Forms.Timer loop;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button xwRot;
        private System.Windows.Forms.Button createSquare_btn;
        private System.Windows.Forms.Button createCube_btn;
        private System.Windows.Forms.Button createHyper_btn;
        private System.Windows.Forms.Label xwRot_lbl;
        private System.Windows.Forms.Label xyRot_lbl;
        private System.Windows.Forms.Label xzRot_lbl;
        private System.Windows.Forms.Label yzRot_lbl;
        private System.Windows.Forms.TrackBar angle_bar;
        private System.Windows.Forms.Label angle_lbl;
        private System.Windows.Forms.TrackBar distance_bar;
        private System.Windows.Forms.Label distance_lbl;
        private System.Windows.Forms.Label scale_lbl;
        private System.Windows.Forms.TrackBar scale_bar;
    }
}

