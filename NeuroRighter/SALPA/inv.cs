// NeuroRighter
// Copyright (c) 2008 John Rolston
//
// This file is part of NeuroRighter.
//
// NeuroRighter is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// NeuroRighter is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with NeuroRighter.  If not, see <http://www.gnu.org/licenses/>. 
//
// This code is a derivation of non-functioning code developed by Sergey Bochkanov (ALGLIB project),
// His code is in turn based on LAPACK: http://www.netlib.org/lapack/.


using System;
namespace NeuroRighter
{
    class inv
    {
        /*************************************************************************
        Inversion of a matrix given by its LU decomposition.

        Input parameters:
            A       -   LU decomposition of the matrix (output of LUDecomposition subroutine).
            Pivots  -   table of permutations which were made during the LU decomposition
                        (the output of LUDecomposition subroutine).
            N       -   size of matrix A.

        Output parameters:
            A       -   inverse of matrix A.
                        Array whose indexes range within [1..N, 1..N].

        Result:
            True, if the matrix is not singular.
            False, if the matrix is singular.

          -- LAPACK routine (version 3.0) --
             Univ. of Tennessee, Univ. of California Berkeley, NAG Ltd.,
             Courant Institute, Argonne National Lab, and Rice University
             February 29, 1992
        *************************************************************************/
        public static bool inverselu(ref double[,] a,
            ref int[] pivots,
            int n)
        {
            bool result = new bool();
            double[] work = new double[0];
            int i = 0;
//            int iws = 0;
            int j = 0;
//            int jb = 0;
//            int jj = 0;
            int jp = 0;
            int jp1 = 0;
            double v = 0;
            int i_ = 0;

            result = true;

            //
            // Quick return if possible
            //
            if (n == 0)
            {
                return result;
            }
            work = new double[n + 1];

            //
            // Form inv(U)
            //
            if (!trinverse.invtriangular(ref a, n, true, false))
            {
                result = false;
                return result;
            }

            //
            // Solve the equation inv(A)*L = inv(U) for inv(A).
            //
            for (j = n; j >= 1; j--)
            {

                //
                // Copy current column of L to WORK and replace with zeros.
                //
                for (i = j + 1; i <= n; i++)
                {
                    work[i] = a[i, j];
                    a[i, j] = 0;
                }

                //
                // Compute current column of inv(A).
                //
                if (j < n)
                {
                    jp1 = j + 1;
                    for (i = 1; i <= n; i++)
                    {
                        v = 0.0;
                        for (i_ = jp1; i_ <= n; i_++)
                        {
                            v += a[i, i_] * work[i_];
                        }
                        a[i, j] = a[i, j] - v;
                    }
                }
            }

            //
            // Apply column interchanges.
            //
            for (j = n - 1; j >= 1; j--)
            {
                jp = pivots[j];
                if (jp != j)
                {
                    for (i_ = 1; i_ <= n; i_++)
                    {
                        work[i_] = a[i_, j];
                    }
                    for (i_ = 1; i_ <= n; i_++)
                    {
                        a[i_, j] = a[i_, jp];
                    }
                    for (i_ = 1; i_ <= n; i_++)
                    {
                        a[i_, jp] = work[i_];
                    }
                }
            }
            return result;
        }


        /*************************************************************************
        Inversion of a general matrix.

        Input parameters:
            A   -   matrix. Array whose indexes range within [1..N, 1..N].
            N   -   size of matrix A.

        Output parameters:
            A   -   inverse of matrix A.
                    Array whose indexes range within [1..N, 1..N].

        Result:
            True, if the matrix is not singular.
            False, if the matrix is singular.

          -- ALGLIB --
             Copyright 2005 by Bochkanov Sergey
        *************************************************************************/
        public static bool inverse(ref double[,] a,
            int n)
        {
            bool result = new bool();
            int[] pivots = new int[0];

            lu.ludecomposition(ref a, n, n, ref pivots);
            result = inverselu(ref a, ref pivots, n);
            return result;
        }
    }
}