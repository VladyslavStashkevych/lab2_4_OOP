using System;

namespace lab2_4 {
	public static class Program {
		static void Main(string[] args) {
			Matrix matrix1  = new Matrix(3, 3);
			matrix1.Read();
			Console.WriteLine("\nMatrix 1:\n");
			matrix1.Display();
			Console.WriteLine($"\nMatrix 1 norm: {matrix1.MatrixNorm}\n");

			int[,] arr = new int[,]{
				{ 3, 4, 5 },
				{ 8, 3, 8 },
				{ 1, 5, 6 }
			};
			Matrix matrix2 = new Matrix(arr);
			Console.WriteLine("\nMatrix 2:\n");
			matrix2.Display();
			Console.WriteLine($"\nMatrix 2 norm: {matrix2.MatrixNorm}\n");

			Matrix matrix3 = new Matrix(matrix2);
			matrix3 = matrix3.MatrixToScalar(3);
			Console.WriteLine("\nMatrix 3:\n");
			matrix3.Display();
			Console.WriteLine($"\nMatrix 3 norm: {matrix3.MatrixNorm}\n");
		}
	}
}