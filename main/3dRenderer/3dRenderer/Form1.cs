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

        bool rotateX;
        bool rotateY;
        bool rotateZ;

        public Form1() {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e) {


            CreateObject();
        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            item.Draw(e);
        }

        private void loop_Tick(object sender, EventArgs e) {
            item.Rotate(rotateX, rotateY, rotateZ);
            Invalidate();
        }

        /// <summary>
        /// allows the user to reset the render
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset_Click(object sender, EventArgs e) {
            CreateObject();
        }

        /// <summary>
        /// creates a square type object
        /// </summary>
        void CreateObject() {

            //passing in 3 (for dimension) and the center of the screen
            item = new Object(3, new Point(Width / 2, Height / 2));
        }

        /// <summary>
        /// inverts the rotation status of the Z axis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zRot_Click(object sender, EventArgs e) {
            rotateZ = !rotateZ;
        }

        /// <summary>
        /// inverts the rotation status of the Y axis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yRot_Click(object sender, EventArgs e) {
            rotateY = !rotateY;
        }

        /// <summary>
        /// inverts the rotation status of the X axis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xRot_Click(object sender, EventArgs e) {
            rotateX = !rotateX;
        }
    }
}
