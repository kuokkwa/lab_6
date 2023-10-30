namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quaternion q1 = new Quaternion(1.0, 2.0, 3.0, 4.0);
            Quaternion q2 = new Quaternion(4.0, 3.0, 2.0, 1.0);

            Console.WriteLine("Quaternion 1: " + q1);
            Console.WriteLine("Quaternion 2: " + q2);

            Quaternion sum = q1 + q2;
            Quaternion difference = q1 - q2;
            Quaternion product = q1 * q2;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);

            double norm = q1.Norm();
            Quaternion conjugate = q1.Conjugate();
            Quaternion inverse = q1.Inverse();

            Console.WriteLine("Norm of quaternion 1: " + norm);
            Console.WriteLine("Conjugate of quaternion 1: " + conjugate);
            Console.WriteLine("Inverse of quaternion 1: " + inverse);

            Matrix4x4 rotationMatrix = q1.ToRotationMatrix();
            Console.WriteLine("Rotation matrix from quaternion 1:\n" +
                              $"{rotationMatrix.M11}, {rotationMatrix.M12}, {rotationMatrix.M13}\n" +
                              $"{rotationMatrix.M21}, {rotationMatrix.M22}, {rotationMatrix.M23}\n" +
                              $"{rotationMatrix.M31}, {rotationMatrix.M32}, {rotationMatrix.M33}");

            Quaternion fromMatrix = Quaternion.FromRotationMatrix(rotationMatrix);
            Console.WriteLine("Quaternion from rotation matrix:\n" + fromMatrix);
        }
    }
}