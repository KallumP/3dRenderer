using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace _3Drenderer {
    class Object {

        List<double[,]> coords = new List<double[,]>();
        public static int dimension;
        Point center;

        public static int scale = 1000;
        public static double angle = 0.007;
        public static double distance = 3;

        /// <summary>
        /// The constructor to the object class
        /// </summary>
        /// <param name="_dimension">lets the class know how many dimentions to make points to</param>
        /// <param name="_center">lets the class know where to translate to before drawing</param>
        public Object(int _dimension, Point _center) {

            dimension = _dimension;

            //sets what coordinate to tranlate to before drawing
            center = _center;

            //creates a new object with the right amonut of points and the right coords
            if (_dimension == 2) {

                coords.Add(new double[1, 4] { { -1, -1, 0, 0 } });
                coords.Add(new double[1, 4] { { 1, -1, 0, 0 } });
                coords.Add(new double[1, 4] { { -1, 1, 0, 0 } });
                coords.Add(new double[1, 4] { { 1, 1, 0, 0 } });

            } else if (_dimension == 3) {

                coords.Add(new double[1, 4] { { -1, -1, -1, 0 } });
                coords.Add(new double[1, 4] { { 1, -1, -1, 0 } });
                coords.Add(new double[1, 4] { { -1, 1, -1, 0 } });
                coords.Add(new double[1, 4] { { 1, 1, -1, 0 } });

                coords.Add(new double[1, 4] { { -1, -1, 1, 0 } });
                coords.Add(new double[1, 4] { { 1, -1, 1, 0 } });
                coords.Add(new double[1, 4] { { -1, 1, 1, 0 } });
                coords.Add(new double[1, 4] { { 1, 1, 1, 0 } });

            } else if (_dimension == 4) {

                coords.Add(new double[1, 4] { { -1, -1, -1, 1 } });
                coords.Add(new double[1, 4] { { 1, -1, -1, 1 } });
                coords.Add(new double[1, 4] { { -1, 1, -1, 1 } });
                coords.Add(new double[1, 4] { { 1, 1, -1, 1 } });

                coords.Add(new double[1, 4] { { -1, -1, 1, 1 } });
                coords.Add(new double[1, 4] { { 1, -1, 1, 1 } });
                coords.Add(new double[1, 4] { { -1, 1, 1, 1 } });
                coords.Add(new double[1, 4] { { 1, 1, 1, 1 } });


                coords.Add(new double[1, 4] { { -1, -1, -1, -1 } });
                coords.Add(new double[1, 4] { { 1, -1, -1, -1 } });
                coords.Add(new double[1, 4] { { -1, 1, -1, -1 } });
                coords.Add(new double[1, 4] { { 1, 1, -1, -1 } });

                coords.Add(new double[1, 4] { { -1, -1, 1, -1 } });
                coords.Add(new double[1, 4] { { 1, -1, 1, -1 } });
                coords.Add(new double[1, 4] { { -1, 1, 1, -1 } });
                coords.Add(new double[1, 4] { { 1, 1, 1, -1 } });
            }
        }

        /// <summary>
        /// rotates the points in the object, and allows checks which axis to rotate on
        /// </summary>
        /// <param name="yxRot">a value that states whether to rotate on this axis</param>
        /// <param name="xzRot">a value that states whether to rotate on this axis</param>
        /// <param name="xyRot">a value that states whether to rotate on this axis</param>
        public void Rotate(bool yxRot, bool xzRot, bool xyRot, bool xwRot) {

            if (yxRot == true)
                for (int i = 0; i < coords.Count; i++)
                    coords[i] = Matrix.multiply(coords[i], Matrix.yzRotation(angle));

            if (xzRot == true)
                for (int i = 0; i < coords.Count; i++)
                    coords[i] = Matrix.multiply(coords[i], Matrix.xzRotation(angle));

            if (xyRot == true)
                for (int i = 0; i < coords.Count; i++)
                    coords[i] = Matrix.multiply(coords[i], Matrix.xyRotation(angle));

            if (xwRot == true)
                for (int i = 0; i < coords.Count; i++)
                    coords[i] = Matrix.multiply(coords[i], Matrix.xwRotation(angle));
        }

        /// <summary>
        /// Draws the object out
        /// </summary>
        /// <param name="e"></param>
        public void Draw(PaintEventArgs e) {

            double dotSize;

            //forces the program to draw to the center of the screen
            e.Graphics.TranslateTransform(center.X, center.Y);

            //checks to see if the vertexes are the right distance apart
            for (int i = 0; i < coords.Count; i++) {
                for (int j = i + 1; j < coords.Count; j++) {

                    if (Matrix.distance(coords[i], coords[j], scale)) {

                        double[,] first = coords[i];
                        double[,] second = coords[j];

                        //projects the higher dimensional points to 2d
                        first = Matrix.multiply(first, Matrix.projection4to3(coords[i][0, 3]));
                        second = Matrix.multiply(second, Matrix.projection4to3(coords[j][0, 3]));

                        first = Matrix.multiply(first, Matrix.projection3to2(coords[i][0, 2]));
                        second = Matrix.multiply(second, Matrix.projection3to2(coords[j][0, 2]));

                        //the second set was meant to be sending in the 3rd dimention ([0,2]) I put in [0,3] by accident :)



                        //draws the vertexes
                        dotSize = (10 + coords[i][0, 2]) * 1;
                        e.Graphics.FillEllipse(Brushes.Black, (float)first[0, 0] * scale - (float)dotSize / 2, (float)first[0, 1] * scale - (float)dotSize / 2, (float)dotSize, (float)dotSize);
                        dotSize = (10 + coords[j][0, 2]) * 1;
                        e.Graphics.FillEllipse(Brushes.Black, (float)second[0, 0] * scale - (float)dotSize / 2, (float)second[0, 1] * scale - (float)dotSize / 2, (float)dotSize, (float)dotSize);

                        //draws the edges
                        e.Graphics.DrawLine(Pens.Black, (float)first[0, 0] * scale, (float)first[0, 1] * scale, (float)second[0, 0] * scale, (float)second[0, 1] * scale);
                    }
                }


            }
        }
    }
}
