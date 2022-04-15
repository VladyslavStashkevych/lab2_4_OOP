using System.Text;

namespace lab2_4 {
	public class Matrix {
		public int K { get => Array.GetLength(0); }
		public int N { get => Array.GetLength(1); }
		public int[,] Array { get; set; }

		public Matrix(int rows, int columns) {
			this.Array = new int[rows, columns];
		}
		public Matrix(int[,] array) {
			int rows = array.GetLength(0);
			int columns = array.GetLength(1);
			this.Array = new int[rows, columns];
			for (int i = 0; i < rows; i++)
				for (int j = 0; j < columns; j++)
					this[i, j] = array[i, j];
		}
		public Matrix(Matrix m) {
			this.Array = m.Array;
		}

		public int this[int row, int column] {
			get {
				return Array[row, column];
			}
			set {
				Array[row, column] = value;
			}
		}

		public Matrix MatrixToScalar(int scalar) {
			Matrix res = new Matrix(this);
			for (int i = 0; i < this.K; i++)
				for (int j = 0; j < this.N; j++)
					res[i, j] *= scalar;
			return res;
		}
		public int MatrixNorm() {
			int max = this[0,0];
			int min = this[0,0];
			for (int i = 0; i < this.K; i++)
				for (int j = 0; j < this.N; j++)
					if (this[i, j] > max)
						max = this[i, j];
					else if (this[i, j] < min)
						min = this[i, j];
			return Math.Abs(max - min);
		}

		public static bool operator ==(Matrix m1, Matrix m2) {
			if (m1.K == m2.K && m1.N == m2.N) {
				for (int i = 0; i < m1.K; i++)
					for (int j = 0; j < m2.N; j++)
						if (m1[i, j] != m2[i, j])
							return false;
			}
			else
				return false;
			return true;
		}
		public static bool operator !=(Matrix m1, Matrix m2)
			=> !(m1 == m2);

		public void ChangeTo(Matrix m2) {
			this.Array = m2.Array;
		}
		public void Read() {
			int [,] arr;
			int rows = 0;
			int cols = 0;
			bool validNumbersEntered = false;
			while (!validNumbersEntered) {
				Console.Write("Enter number of rows: ");
				rows = Convert.ToInt32(Console.ReadLine());
				Console.Write("Enter number of columns: ");
				cols = Convert.ToInt32(Console.ReadLine());
				if (rows >= 0 && cols >= 0) {
					break;
				}
				Console.WriteLine("Numbers should be greater than zero! Try again.");
			}
			arr = new int[rows, cols];
			for (int i = 0; i < rows; i++) {
				for (int j = 0; j < cols; j++) {
					Console.Write($"Enter element[{i}, {j}]: ");
					arr[i, j] = Convert.ToInt32(Console.ReadLine());
				}
			}
			this.Array = arr;
		}
		public void Display() {
			Console.WriteLine(this.ToString());
		}
		public override string ToString() {
			StringBuilder result = new StringBuilder();
			for (int i = 0; i < this.K; i++) {
				for (int j = 0; j < this.N; j++) {
					result = result.Append($"{this.Array[i, j]} ");
				}
				result = result.Append("\n");
			}
			return result.ToString();
		}
	}
}

//namespace lab2_4 {
//	public class Matrix {
//		int k;
//		int n;
//		int[,] array;

//		public int K {
//			get => k;
//			set {
//				k = value;
//				Array = new int[K, N];
//			}
//		}
//		public int N {
//			get => n;
//			set {
//				n = value;
//				Array = new int[K, N];
//			}
//		}
//		public int[,] Array {
//			get => array;
//			set {
//				K = value.GetLength(0);
//				N = value.GetLength(1);
//				array = value;
//			}
//		}

//		public Matrix(int rows, int columns) {
//			this.K = rows;
//			this.N = columns;
//		}
//		public Matrix(int[,] array) {
//			this.K = array.GetLength(0);
//			this.N = array.GetLength(1);
//			for (int i = 0; i < this.K; i++)
//				for (int j = 0; j < this.N; j++)
//					this.Array[i, j] = array[i, j];
//		}
//		public Matrix(Matrix m) {
//			this.Array = m.Array;
//		}

//		public int this[int row, int column] {
//			get {
//				return Array[row, column];
//			}
//			set {
//				Array[row, column] = value;
//			}
//		}
//	}
//}
