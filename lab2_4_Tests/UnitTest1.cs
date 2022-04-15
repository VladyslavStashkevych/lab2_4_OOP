using lab2_4;
using Xunit;

namespace lab2_4_Tests {
	public class UnitTest1 {
		[Theory]
		[InlineData(3)]
		[InlineData(5)]
		public void MatrixToScalar_ReturnsCorrectValue(int scalar) {
			//Arrange
			int[,] arr = new int[,]{
				{ 3, 4, 5 },
				{ 8, 3, 8 },
				{ 1, 5, 6 }
			};
			Matrix matrix1 = new Matrix(arr);
			for (int i = 0; i < arr.GetLength(0); i++)
				for (int j = 0; j < arr.GetLength(1); j++)
					arr[i, j] *= scalar;

			//Act
			matrix1 = matrix1.MatrixToScalar(scalar);

			//Assert
			Assert.Equal(arr, matrix1.Array);
		}
	}
}