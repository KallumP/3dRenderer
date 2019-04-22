using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3dRenderer {
    public partial class Form1 : Form {

        Object item;

        bool rotateYZ;
        bool rotateXZ;
        bool rotateXY;
        bool rotateXW;

        public Form1() {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// creates an object on spawn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e) {
            angle_lbl.Text = "Angle: " + Object.angle.ToString();
            distance_lbl.Text = "Distance: " + Object.distance.ToString();
            scale_lbl.Text = "Scale: " + Object.scale.ToString();

            CreateSquare();
        }


        /// <summary>
        /// draws the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Paint(object sender, PaintEventArgs e) {
            item.Draw(e);
        }

        /// <summary>
        /// every tick of the timer, the object rotates and the screen redraws
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loop_Tick(object sender, EventArgs e) {

            item.Rotate(rotateYZ, rotateXZ, rotateXY, rotateXW);
            Invalidate();


            yzRot_lbl.Text = rotateYZ.ToString();
            xzRot_lbl.Text = rotateXZ.ToString();
            xyRot_lbl.Text = rotateXY.ToString();
            xwRot_lbl.Text = rotateXW.ToString();
        }

        /// <summary>
        /// allows the user to reset the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset_Click(object sender, EventArgs e) {
            item = new Object(Object.dimension, new Point(Width / 2, Height / 2));

            rotateYZ = false;
            rotateXZ = false;
            rotateXY = false;
            rotateXW = false;

        }

        /// <summary>
        /// Allows the use to make different objects by clicking buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createSquare_btn_Click(object sender, EventArgs e) {
            CreateSquare();
        }
        private void createCube_btn_Click(object sender, EventArgs e) {
            CreateCube();
        }
        private void createHyper_btn_Click(object sender, EventArgs e) {
            CreateHyperCube();
        }

        /// <summary>
        /// creates an object of a certain dimension
        /// </summary>
        void CreateSquare() {
            item = new Object(2, new Point(Width / 2, Height / 2));
        }
        void CreateCube() {
            item = new Object(3, new Point(Width / 2, Height / 2));
        }
        void CreateHyperCube() {
            item = new Object(4, new Point(Width / 2, Height / 2));
        }

        /// <summary>
        /// inverts the selected rotation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xyRot_Click(object sender, EventArgs e) {
            rotateXY = !rotateXY;
        }
        private void xzRot_Click(object sender, EventArgs e) {
            rotateXZ = !rotateXZ;
        }
        private void yzRot_Click(object sender, EventArgs e) {
            rotateYZ = !rotateYZ;
        }
        private void xwRot_Click(object sender, EventArgs e) {
            rotateXW = !rotateXW;
        }

        /// <summary>
        /// lets the user change the angle, distance and scale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void angle_bar_Scroll(object sender, EventArgs e) {
            double barValue = angle_bar.Value;
            Object.angle = barValue / 1000;
            angle_lbl.Text = "Angle: " + Object.angle.ToString();
        }
        private void distance_bar_Scroll(object sender, EventArgs e) {
            double barValue = distance_bar.Value;
            Object.distance = barValue / 100;
            distance_lbl.Text = "Distance: " + Object.distance.ToString();
        }
        private void scale_bar_Scroll(object sender, EventArgs e) {
            Object.scale = scale_bar.Value;
            scale_lbl.Text = "Scale: " + Object.scale.ToString();
        }
    }
}
