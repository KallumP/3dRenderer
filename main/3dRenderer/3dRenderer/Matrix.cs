using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3dRenderer {
    class Matrix {

        /// <summary>
        /// the rotation matrix for the x axis
        /// </summary>
        /// <param name="angle">the angle to rotate by</param>
        /// <returns></returns>
        public static double[,] xRotation(double angle) {

            double[,] toReturn = new double[3, 3] {
                {1, 0, 0 },
                {0, Math.Cos(angle), -Math.Sin(angle) },
                {0, Math.Sin(angle), Math.Cos(angle)} };

            return toReturn;
        }

        /// <summary>
        /// the rotation matrix for the y axis
        /// </summary>
        /// <param name="angle">the angle to rotate by</param>
        /// <returns></returns>
        public static double[,] yRotation(double angle) {

            double[,] toReturn = new double[3, 3] {
                {Math.Cos(angle), 0, Math.Sin(angle) },
                {0,1,0 },
                {-Math.Sin(angle), 0, Math.Cos(angle)} };

            return toReturn;
        }

        /// <summary>
        /// the rotation matrix for the z axis
        /// </summary>
        /// <param name="angle">the angle to rotate by</param>
        /// <returns></returns>
        public static double[,] zRotation(double angle) {

            double[,] toReturn = new double[3, 3] {
                {Math.Cos(angle), -Math.Sin(angle), 0 },
                {Math.Sin(angle), Math.Cos(angle), 0 },
                {0, 0, 1 } };

            return toReturn;
        }

        /// <summary>
        /// takes in two matrixes and matrix multiplies them together
        /// </summary>
        /// <param name="first">the first matrix to multiply</param>
        /// <param name="second">the second matrix to multiply to</param>
        /// <returns></returns>
        public static double[,] multiply(double[,] first, double[,] second) {
            
            //makes sure that the matrixes are the right sizes to multiply
            if (first.GetLength(1) == second.GetLength(0)) {

                //creates a matrix to return at the end
                double[,] toReturn = new double[first.GetLength(0), second.GetLength(1)];

                //multiplies the matrixes together
                for (int i = 0; i < first.GetLength(0); i++) {
                    for (int j = 0; j < second.GetLength(1); j++) {

                        double sum = 0;

                        for (int k = 0; k < second.GetLength(1); k++) {
                            sum += first[i, k] * second[k, j];
                        }

                        toReturn[i, j] = sum;
                    }
                }

                //returns the matrix
                return toReturn;
            }

            return null;
        }
    }
}

