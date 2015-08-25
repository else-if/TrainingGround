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
        public double[] X { get; private set; }
        public double[] E { get; private set; }
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

            Array.Clear(X, 0, X.Length);
            Array.Clear(E, 0, X.Length);
            ErrMsg = "";

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
                        A[j, k] -= A[i, k] * basicValue;
                    }
                    B[j] -= B[i] * basicValue;
                }

                Steps.Add(new GaussStep(varCount, A, B));
            }

            if (ErrMsg != "") return;

            //обратный ход
            for (int i = varCount - 1; i >= 0; i--)
            {
                for (int j = i + 1; j < varCount; j++)
                {
                    B[i] -= A[i, j] * X[j];
                    A[i, j] = 0;
                }

                X[i] = B[i] / A[i, i];

                if (i < varCount-1) Steps.Add(new GaussStep(varCount, A, B));
            }

            //Вычислим вектор ошибок
            for (int i = 0; i < varCount; i++)
            {
                E[i] = FirstStep.B[i];
                for (int j = 0; j < varCount; j++)
                    E[i] -= FirstStep.A[i, j] * X[j];
            }

        }
    }
}
