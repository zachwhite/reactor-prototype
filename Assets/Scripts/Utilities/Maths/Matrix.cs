using System.Linq;

namespace MonoConcept { namespace Utilities { namespace Maths {

public sealed class Matrix
{
#region Properties
	private double[][] _Cells;
	public double[][] Cells
	{
		get { return _Cells; }
		set { _Cells = value; }
	}
	
	public int Rows { get { return Cells.Length; } }
	
	public int Columns 
	{ 
		get { 
			if (Cells.Length == 0) return 0;
			
			return Cells[0].Length; 
		} 
	}
	
	public RowIndexer Row { get; set; }
	public ColumnIndexer Column { get; set; }
#endregion
	
	
#region Indexers
	public double this [ int row, int column ]
	{
		get { return Cells[row][column]; }
		set { Cells[row][column] = value; }
	}
	
	public class RowIndexer
	{
		readonly Matrix ParentMatrix;
		public double[] this[int index]
		{
			get { return ParentMatrix.GetRow(index); }
			set { ParentMatrix.SetRow(index, value); }
		}
		
		internal RowIndexer(Matrix parentMatrix)
		{
			ParentMatrix = parentMatrix;
		}
	}
	
	public class ColumnIndexer
	{
		readonly Matrix ParentMatrix;
		public double[] this[int index]
		{
			get { return ParentMatrix.GetColumn(index); }
			set { ParentMatrix.SetColumn(index, value); }
		}
		
		internal ColumnIndexer(Matrix parentMatrix)
		{
			ParentMatrix = parentMatrix;
		}
	}
#endregion
	
	
#region Constructors
	public Matrix (int rows, int columns)
	{
		Cells = new double[rows][];
		for (int i = 0; i < rows; i++)
		{
			Cells[i] = new double[columns];
			for (int j = 0; i < columns; i++)
				Cells[i][j] = 0;
		}
	}
#endregion
	
	
#region Utility Methods
	public static double[] AddRange(double[] rowOne, double[] rowTwo)
	{
		// Not equivalent row types.
		if (rowOne.Length != rowTwo.Length)
			return null;
		
		double[] rowResult = new double[rowOne.Length];
		
		for (int i = 0; i < rowOne.Length; i++)
		{
			rowResult[i] = rowOne[i] + rowTwo[i];
		}
		
		return rowResult;
	}
	
	
	public static double[] MultiplyRange(double[] row, double scalar)
	{
		double[] rowResult = new double[row.Length];
		
		for (int i = 0; i < row.Length; i++)
		{
			rowResult[i] = row[i] * scalar;
		}
		
		return rowResult;
	}
	
	
	public static double[] SimplifyRange(double[] row)
	{
		double sign = 0;
		
		// Simplify rows.
		for (int i = 0; i < row.Length; i++)
		{
			if (row[i] > 0)
			{
				sign = 1;
				break;
			}
			
			else if (row[i] < 0)
			{
				sign = -1;
				break;
			}
		}
		
		double[] rowResult = row;
		if (sign == 0)
			return rowResult;
		
		double gcdRow = Maths.GreatestCommonDivisor(row) * sign;
		
		for (int i = 0; i < rowResult.Length; i++)
		{
			rowResult[i] /= gcdRow;
		}
		
		return rowResult;		
	}
#endregion
	
	
#region Helper Methods
	private double[] GetRow(int row)
	{
		return Cells[row];
	}
	
	private bool SetRow(int row, double[] newValue)
	{
		// Out of bounds.
		if (newValue.Length != GetRow(row).Length)
			return false;
		
		Cells[row] = newValue;
		
		return true;
	}


	private double[] GetColumn(int column)
	{
		return (double[]) Cells.Select(row => row[column]);
	}
	
	private bool SetColumn(int column, double[] newValue)
	{
		// Out of bounds.
		if (newValue.Length != Rows)
			return false; 
		
		for (int row = 0; row < Rows; row++)
		{
			Cells[row][column] = newValue[row];
		}
		
		return true;
	}
#endregion
	
	
	public void SwapRows(int rowOne, int rowTwo)
	{
		double[] original = Cells[rowOne];
		Row[rowOne] = Row[rowTwo];
		Row[rowTwo] = original;
	}
	
	
	public void SwapColumns (int columnOne, int columnTwo)
	{
		double[] original = Column[columnOne];
		Column[columnOne] = Column[columnTwo];
		Column[columnTwo] = original;
	}
	
	
	public void GaussJordanEliminate()
	{
		// Simplify all rows.
		for (int i = 0; i < Rows; i++)
		{
			Cells[i] = SimplifyRange(Cells[i]);
		}
		
		// Compute REF
		int numberOfPivots = 0;
		for (int i = 0; i < Columns; i++)
		{
			int pivotRow = numberOfPivots;
			
			while (pivotRow < Rows && Cells[pivotRow][i] == 0)
			{
				pivotRow++;
			}
			
			if (pivotRow == Rows) continue;
			
			int pivot = (int) Cells[pivotRow][i];
			SwapRows(numberOfPivots, pivotRow);
			numberOfPivots++;
			
			for (int j = numberOfPivots; j < Rows; j++)
			{
				double gcd = Maths.GreatestCommonDivisor( (double) pivot, Cells[j][i] );
				Cells[j] = SimplifyRange( 
					AddRange( 
				        MultiplyRange(Cells[j], pivot / gcd), 
				        MultiplyRange(Cells[i], -Cells[j][i] / gcd)
					)
				);
			}
		}
		
		// Computed RREF
		for (int i = Rows - 1; i >= 0; i--)
		{
			int pivotColumn = 0;
			while (pivotColumn < Columns && Cells[i][pivotColumn] == 0)
			{
				pivotColumn++;
			}
			
			if (pivotColumn == Columns) continue;
			
			int pivot = (int) Cells[i][pivotColumn];
			
			for (int j = i - 1; j >= 0; j--)
			{
				int gcd = (int) Maths.GreatestCommonDivisor( (double) pivot, Cells[j][pivotColumn]);
				Cells[j] = SimplifyRange(
					AddRange(
						MultiplyRange(Cells[j], pivot / gcd),
						MultiplyRange(Cells[i], -Cells[j][pivotColumn] / gcd)
					)
				);
			}
		}
	}
	
	
	public override string ToString()
	{
		string result = "[";
		
		for (int i = 0; i < Rows; i++)
		{
			if (i != 0) 
			{
				result += "],\n";
			}
			
			result += "[";
			
			for (int j = 0; j < Columns; j++)
			{
				if (j != 0)
				{
					result += ", ";
				}
				
				result += Cells[i][j];
			}
			
			result += "]";
		}
		
		result += "]";
		
		return result;
	}
}
}}}
