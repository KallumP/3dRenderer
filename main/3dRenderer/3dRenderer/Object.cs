using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace _3dRenderer {
    class Object {
        List<double[,]> coords = new List<double[,]>();
        int scale = 100;
        double angle = 0.01;

        Point center;

        /// <summary>
        /// The constructor to the object class
        /// </summary>
        /// <param name="dimension">lets the class know how many dimentions to make points to</param>
        /// <param name="_center">lets the class know where to translate to before drawing</param>
        public Object(int dimension, Point _center) {

            //sets what coordinate to tranlate to before drawing
            center = _center;

            //creates a new object with the right amonut of points and the right coords
            if (dimension == 2) {

                coords.Add(new double[1, 3] { { -1 * scale, -1 * scale, 0 } });
                coords.Add(new double[1, 3] { { 1 * scale, -1 * scale, 0 } });
                coords.Add(new double[1, 3] { { -1 * scale, 1 * scale, 0 } });
                coords.Add(new double[1, 3] { { 1 * scale, 1 * scale, 0 } });


            } else if (dimension == 3) {

                coords.Add(new double[1, 3] { { -1 * scale, -1 * scale, -1 * scale } });
                coords.Add(new double[1, 3] { { 1 * scale, -1 * scale, -1 * scale } });
                coords.Add(new double[1, 3] { { -1 * scale, 1 * scale, -1 * scale } });
                coords.Add(new double[1, 3] { { 1 * scale, 1 * scale, -1 * scale } });

                coords.Add(new double[1, 3] { { -1 * scale, -1 * scale, 1 * scale } });
                coords.Add(new double[1, 3] { { 1 * scale, -1 * scale, 1 * scale } });
                coords.Add(new double[1, 3] { { -1 * scale, 1 * scale, 1 * scale } });
                coords.Add(new double[1, 3] { { 1 * scale, 1 * scale, 1 * scale } });

            }
        }

        /// <summary>
        /// rotates the points in the object, and allows checks which axis to rotate on
        /// </summary>
        /// <param name="xRot">a value that states whether to rotate on this axis</param>
        /// <param name="yRot">a value that states whether to rotate on this axis</param>
        /// <param name="zRot">a value that states whether to rotate on this axis</param>
        public void Rotate(bool xRot, bool yRot, bool zRot) {

            if (xRot == true) 
                for (int i = 0; i < coords.Count; i++)
                    coords[i] = Matrix.multiply(coords[i], Matrix.xRotation(angle));

            if (yRot == true)
                for (int i = 0; i < coords.Count; i++)
                    coords[i] = Matrix.multiply(coords[i], Matrix.yRotation(angle));

            if (zRot == true)
                for (int i = 0; i < coords.Count; i++)
                    coords[i] = Matrix.multiply(coords[i], Matrix.zRotation(angle));
        }

        /// <summary>
        /// Draws the object out
        /// </summary>
        /// <param name="e"></param>
        public void Draw(PaintEventArgs e) {

            //allows the program to draw from the center of the screen
            e.Graphics.TranslateTransform(center.X, center.Y);

            //checks to see how many points there are before drawing them out
            if (coords.Count == 4) {
                e.Graphics.DrawLine(Pens.Black, (float)coords[0][0, 0], (float)coords[0][0, 1], (float)coords[1][0, 0], (float)coords[1][0, 1]);
                e.Graphics.DrawLine(Pens.Black, (float)coords[1][0, 0], (float)coords[1][0, 1], (float)coords[3][0, 0], (float)coords[3][0, 1]);
                e.Graphics.DrawLine(Pens.Black, (float)coords[0][0, 0], (float)coords[0][0, 1], (float)coords[2][0, 0], (float)coords[2][0, 1]);
                e.Graphics.DrawLine(Pens.Black, (float)coords[2][0, 0], (float)coords[2][0, 1], (float)coords[3][0, 0], (float)coords[3][0, 1]);
            } else if (coords.Count == 8) {

                e.Graphics.DrawLine(Pens.Black, (float)coords[0][0, 0], (float)coords[0][0, 1], (float)coords[1][0, 0], (float)coords[1][0, 1]);
                e.Graphics.DrawLine(Pens.Black, (float)coords[1][0, 0], (float)coords[1][0, 1], (float)coords[3][0, 0], (float)coords[3][0, 1]);
                e.Graphics.DrawLine(Pens.Black, (float)coords[0][0, 0], (float)coords[0][0, 1], (float)coords[2][0, 0], (float)coords[2][0, 1]);
                e.Graphics.DrawLine(Pens.Black, (float)coords[2][0, 0], (float)coords[2][0, 1], (float)coords[3][0, 0], (float)coords[3][0, 1]);

                e.Graphics.DrawLine(Pens.Black, (float)coords[0][0, 0], (float)coords[0][0, 1], (float)coords[4][0, 0], (float)coords[4][0, 1]);
                e.Graphics.DrawLine(Pens.Black, (float)coords[1][0, 0], (float)coords[1][0, 1], (float)coords[5][0, 0], (float)coords[5][0, 1]);
                e.Graphics.DrawLine(Pens.Black, (float)coords[2][0, 0], (float)coords[2][0, 1], (float)coords[6][0, 0], (float)coords[6][0, 1]);
                e.Graphics.DrawLine(Pens.Black, (float)coords[3][0, 0], (float)coords[3][0, 1], (float)coords[7][0, 0], (float)coords[7][0, 1]);

                e.Graphics.DrawLine(Pens.Black, (float)coords[4][0, 0], (float)coords[4][0, 1], (float)coords[5][0, 0], (float)coords[5][0, 1]);
                e.Graphics.DrawLine(Pens.Black, (float)coords[5][0, 0], (float)coords[5][0, 1], (float)coords[7][0, 0], (float)coords[7][0, 1]);
                e.Graphics.DrawLine(Pens.Black, (float)coords[4][0, 0], (float)coords[4][0, 1], (float)coords[6][0, 0], (float)coords[6][0, 1]);
                e.Graphics.DrawLine(Pens.Black, (float)coords[6][0, 0], (float)coords[6][0, 1], (float)coords[7][0, 0], (float)coords[7][0, 1]);
            }
        }
    }
}
