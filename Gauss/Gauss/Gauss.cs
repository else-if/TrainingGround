using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaussSolution
{
    class Gauss
    {
        public List<GaussStep> Steps { get; private set; }
        private GaussStep FirstStep; 
        private double[] X;
        private double[] E;
        private int varCount;
        public string ErrMsg { get; private set; }

        public Gauss(int variablesCount, double[,] A, double[] B)
        {
            varCount = variablesCount;
            X = new double[varCount];
            E = new double[varCount];

            FirstStep = new GaussStep(varCount, A, B);
            ErrMsg = "";
        }

        public void Calculate()
        {
            Steps = new List<GaussStep>();
            Steps.Add(FirstStep);

            double [,]A = new double[varCount, varCount];
            double[] B = new double[varCount];

            Array.Copy(FirstStep.A, A, FirstStep.A.Length);
            Array.Copy(FirstStep.B, B, FirstStep.B.Length);

            //прямой ход
            for (int i = 0; i < varCount; i++)
            {
                //возможно нужно переставить местами строки
                if (A[i, i] == 0)
                {
                    for (int j = i + 1; j < varCount; j++)
                    {
                        if (A[j, i] != 0)
                        {
                            //переставляем строки
                            for (int k = i; k < varCount; k++)
                            {
                                double temp = A[i, k];
                                A[i, k] = A[j, k];
                                A[j, k] = temp;
                            }

                            break;
                        }
                    }

                    if (A[i, i] == 0)
                    {
                        //методом Гаусса решить невозможно
                        ErrMsg = "методом Гаусса решить невозможно";
                        break;
                    }
                }

                double basicValue = A[i,i];
                for (int j = i; j < varCount; j++)
                {
                    A[i, j] = A[i, j] / basicValue;
                }
                B[i] = B[i] / basicValue;


                for (int j = i + 1; j < varCount; j++)
                {
                    basicValue = A[j, i];
                    for (int k = i; k < varCount; k++)
                    {
                        A[j, k] = A[j, k] - A[i, k] * basicValue;
                    }
                    B[j] = B[j] - B[i] / basicValue;
                }

                Steps.Add(new GaussStep(varCount, A, B));
            }

            for (int i = varCount - 1; i >= 0; i--)
            {
                for (int j = i + 1; j < varCount - 1; j++)
                {
                    B[i] = B[i] - A[i, j] * X[j];
                    A[i, j] = 0;
                }

                X[i] = B[i];

                Steps.Add(new GaussStep(varCount, A, B));
            }

        }
    }
}
