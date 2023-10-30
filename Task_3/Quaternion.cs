using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Quaternion
    {
        public double W { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Quaternion(double w, double x, double y, double z)
        {
            W = w;
            X = x;
            Y = y;
            Z = z;
        }

        public static Quaternion operator +(Quaternion a, Quaternion b)
        {
            return new Quaternion(a.W + b.W, a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static Quaternion operator -(Quaternion a, Quaternion b)
        {
            return new Quaternion(a.W - b.W, a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        public static Quaternion operator *(Quaternion q, double scalar)
        {
            return new Quaternion(q.W * scalar, q.X * scalar, q.Y * scalar, q.Z * scalar);
        }

        public static Quaternion operator *(Quaternion a, Quaternion b)
        {
            double w = a.W * b.W - a.X * b.X - a.Y * b.Y - a.Z * b.Z;
            double x = a.W * b.X + a.X * b.W + a.Y * b.Z - a.Z * b.Y;
            double y = a.W * b.Y - a.X * b.Z + a.Y * b.W + a.Z * b.X;
            double z = a.W * b.Z + a.X * b.Y - a.Y * b.X + a.Z * b.W;

            return new Quaternion(w, x, y, z);
        }

        public double Norm()
        {
            return Math.Sqrt(W * W + X * X + Y * Y + Z * Z);
        }

        public Quaternion Conjugate()
        {
            return new Quaternion(W, -X, -Y, -Z);
        }

        public Quaternion Inverse()
        {
            double normSquared = W * W + X * X + Y * Y + Z * Z;
            if (normSquared == 0)
                throw new InvalidOperationException("Cannot invert a quaternion with zero norm.");

            double invNormSquared = 1.0 / normSquared;
            return new Quaternion(W * invNormSquared, -X * invNormSquared, -Y * invNormSquared, -Z * invNormSquared);
        }

        public static bool operator ==(Quaternion a, Quaternion b)
        {
            return a.W == b.W && a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }

        public static bool operator !=(Quaternion a, Quaternion b)
        {
            return !(a == b);
        }

        public Matrix4x4 ToRotationMatrix()
        {
            double xx = X * X;
            double xy = X * Y;
            double xz = X * Z;
            double xw = X * W;
            double yy = Y * Y;
            double yz = Y * Z;
            double yw = Y * W;
            double zz = Z * Z;
            double zw = Z * W;

            return new Matrix4x4(
                1 - 2 * (yy + zz), 2 * (xy - zw), 2 * (xz + yw), 0,
                2 * (xy + zw), 1 - 2 * (xx + zz), 2 * (yz - xw), 0,
                2 * (xz - yw), 2 * (yz + xw), 1 - 2 * (xx + yy), 0,
                0, 0, 0, 1
            );
        }

        public static Quaternion FromRotationMatrix(Matrix4x4 matrix)
        {
            double trace = matrix.M11 + matrix.M22 + matrix.M33;
            double w;
            double x;
            double y;
            double z;

            if (trace > 0)
            {
                double s = 0.5 / Math.Sqrt(trace + 1.0);
                w = 0.25 / s;
                x = (matrix.M32 - matrix.M23) * s;
                y = (matrix.M13 - matrix.M31) * s;
                z = (matrix.M21 - matrix.M12) * s;
            }
            else if (matrix.M11 > matrix.M22 && matrix.M11 > matrix.M33)
            {
                double s = 2.0 * Math.Sqrt(1.0 + matrix.M11 - matrix.M22 - matrix.M33);
                w = (matrix.M32 - matrix.M23) / s;
                x = 0.25 * s;
                y = (matrix.M12 + matrix.M21) / s;
                z = (matrix.M13 + matrix.M31) / s;
            }
            else if (matrix.M22 > matrix.M33)
            {
                double s = 2.0 * Math.Sqrt(1.0 + matrix.M22 - matrix.M11 - matrix.M33);
                w = (matrix.M13 - matrix.M31) / s;
                x = (matrix.M12 + matrix.M21) / s;
                y = 0.25 * s;
                z = (matrix.M23 + matrix.M32) / s;
            }
            else
            {
                double s = 2.0 * Math.Sqrt(1.0 + matrix.M33 - matrix.M11 - matrix.M22);
                w = (matrix.M21 - matrix.M12) / s;
                x = (matrix.M13 + matrix.M31) / s;
                y = (matrix.M23 + matrix.M32) / s;
                z = 0.25 * s;
            }

            return new Quaternion(w, x, y, z);
        }

        public override string ToString()
        {
            return $"W: {W}, X: {X}, Y: {Y}, Z: {Z}";
        }
    }
}
