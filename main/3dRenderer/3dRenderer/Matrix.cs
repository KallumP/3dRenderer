using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3dRenderer {
    class Matrix {


        public static double[,] xRotation(double angle) {

            double[,] toReturn = new double[3, 3] {
                {1, 0, 0 },
                {0, Math.Cos(angle), -Math.Sin(angle) },
                {0, Math.Sin(angle), Math.Cos(angle)} };

            return toReturn;
        }

        public static double[,] yRotation(double angle) {

            double[,] toReturn = new double[3, 3] {
                {Math.Cos(angle), 0, Math.Sin(angle) },
                {0,1,0 },
                {-Math.Sin(angle), 0, Math.Cos(angle)} };

            return toReturn;
        }

        public static double[,] zRotation(double angle) {

            double[,] toReturn = new double[3, 3] {
                {Math.Cos(angle), -Math.Sin(angle), 0 },
                {Math.Sin(angle), Math.Cos(angle), 0 },
                {0, 0, 1 } };

            return toReturn;
        }




        public static double[,] multiply(double[,] first, double[,] second) {


            if (first.GetLength(1) == second.GetLength(0)) {

                double[,] toReturn = new double[first.GetLength(0), second.GetLength(1)];

                for (int i = 0; i < first.GetLength(0); i++) {
                    for (int j = 0; j < second.GetLength(1); j++) {

                        double sum = 0;

                        for (int k = 0; k < second.GetLength(1); k++) {
                            sum += first[i, k] * second[k, j];
                        }
                        toReturn[i, j] = sum;


                    }
                }

                return toReturn;
            }

            return null;
        }
    }
}

