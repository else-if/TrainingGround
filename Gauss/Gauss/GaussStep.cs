using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaussSolution
{
    class GaussStep
    {
        public double[,] A { get; private set; }
        public double[] B { get; private set; }

        public GaussStep(int variablesCount, double[,] AMatrix, double[] BMatrix)
        {
            A = new double[variablesCount, variablesCount];
            B = new double[variablesCount];

            Array.Copy(AMatrix, A, AMatrix.Length);
            Array.Copy(BMatrix, B, BMatrix.Length);
        }
    }
}
