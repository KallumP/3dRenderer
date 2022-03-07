using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Drenderer {
    class Matrix {

        /// <summary>
        /// the rotation matrix for the x axis
        /// </summary>
        /// <param name="angle">the angle to rotate by</param>
        /// <returns></returns>
        public static double[,] yzRotation(double angle) {

            double[,] newMatrix = new double[4, 4] {
                {1, 0, 0, 0 },
                {0, Math.Cos(angle), -Math.Sin(angle), 0 },
                {0, Math.Sin(angle), Math.Cos(angle), 0},
                {0, 0, 0, 1 } };

            return newMatrix;
        }

        /// <summary>
        /// the rotation matrix for the y axis
        /// </summary>
        /// <param name="angle">the angle to rotate by</param>
        /// <returns></returns>
        public static double[,] xzRotation(double angle) {

            double[,] newMatrix = new double[4, 4] {
                {Math.Cos(angle), 0, Math.Sin(angle), 0 },
                {0,1,0, 0 },
                {-Math.Sin(angle), 0, Math.Cos(angle), 0},
                {0, 0, 0, 1 } };

            return newMatrix;
        }

        /// <summary>
        /// the rotation matrix for the z axis
        /// </summary>
        /// <param name="angle">the angle to rotate by</param>
        /// <returns></returns>
        public static double[,] xyRotation(double angle) {

            double[,] newMatrix = new double[4, 4] {
                {Math.Cos(angle), -Math.Sin(angle), 0 ,0 },
                {Math.Sin(angle), Math.Cos(angle), 0, 0 },
                {0, 0, 1 , 0},
                {0, 0, 0, 1 } };

            return newMatrix;
        }

        public static double[,] xwRotation(double angle) {

            double[,] newMatrix = new double[4, 4] {
                { Math.Cos(angle), 0, 0 ,-Math.Sin(angle) },
                { 0, 1, 0, 0 },
                { 0, 0, 1,0 },
                { Math.Sin(angle), 0, 0, Math.Cos(angle)} };

            return newMatrix;
        }

        public static double[,] projection4to3(double _w) {

            double p = 1 / (Object.distance - _w);

            double[,] newMatrix = new double[4, 3] {
                {p, 0, 0 },
                {0, p, 0 },
                {0, 0, p },
                {0, 0, 0 } };

            return newMatrix;
        }

        public static double[,] projection3to2(double _z) {

            double p = 1 / (Object.distance - _z);

            double[,] newMatrix = new double[3, 2] {
                {p, 0 },
                {0, p },
                {0, 0 } };

            return newMatrix;
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
                double[,] newMatrix = new double[first.GetLength(0), second.GetLength(1)];

                //multiplies the matrixes together
                for (int i = 0; i < first.GetLength(0); i++) {
                    for (int j = 0; j < second.GetLength(1); j++) {
                        for (int k = 0; k < second.GetLength(1); k++) {
                            newMatrix[i, j] += first[i, k] * second[k, j];
                        }
                    }
                }

                //returns the matrix
                return newMatrix;
            }

            //returns nothing if the matrixes werent compatible
            return null;
        }

        public static bool distance(double[,] first, double[,] second, double scale) {

            double distance = 0;

            //makes sure that the two matrixes are the compatible
            if (first.GetLength(0) == 1 && second.GetLength(0) == 1 && first.GetLength(1) == second.GetLength(1)) {


                for (int i = 0; i < first.GetLength(1); i++)
                    distance += Math.Pow(first[0, i] - second[0, i], 2);


                distance = Math.Round(Math.Sqrt(distance));

            }

            if (distance > 1 * 2)
                return false;
            else
                return true;
        }
    }
}


