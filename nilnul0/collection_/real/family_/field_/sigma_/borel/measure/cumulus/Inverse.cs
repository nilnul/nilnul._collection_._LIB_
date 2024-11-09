using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection_.real.family_.field_.sigma_.borel.measure.cumulus
{
	/// <summary>
	/// if there are nonempty null sets, the increased measure may corresponds to a nonempty set; thence, the image is a set rather than a single value. If we need a single value, we may take the midpoint of the interval set; so we better take the image as interval first.
	/// </summary>
	static public class _InverseX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="measureCumulatedS">
		///  the set is implicit: a equidistant partition of a unital interval [0,1]
		/// </param>
		/// <param name="_measureCumulated_inScope">
		/// 
		/// </param>
		/// <returns>
		/// not the measure, but the set.
		/// </returns>
		/// <remarks>
		/// this is useful in parameterize bezier cubic curve of arcLength rather than time by converting arcLength to time parameter
		/// </remarks>
		static public double _Prob_assumeProbEquiPartite(
			List<double> measureCumulatedS
			,
			double _measureCumulated_inScope
		)
		{

			/// 
			var index1 = nilnul.num.real.sortie._FindX._IndexRange(measureCumulatedS, _measureCumulated_inScope);

			var measureSpan = measureCumulatedS[index1.Item2.Value] -
measureCumulatedS[index1.Item1.Value];

			if (
				measureSpan == 0    ///null set found
			)
			{
				return (index1.Item1.Value + index1.Item2.Value) / 2;
			}

			return index1.Item1.Value
				+
				(
					_measureCumulated_inScope
					-
					measureCumulatedS[index1.Item1.Value]
				)
				/
				measureSpan
				*
				(index1.Item2.Value - index1.Item1.Value);
			;


		}

		static public double _Prob_assumeProbEquiPartite(
			double[] measureCumulatedS
			,
			double _measureCumulated_inScope
		)
		{

			/// 
			var index1 = nilnul.num.real.sortie._FindX._IndexRange(measureCumulatedS, _measureCumulated_inScope);

			var measureSpan = measureCumulatedS[index1.Item2.Value] -
measureCumulatedS[index1.Item1.Value];

			if (
				measureSpan == 0    ///null set found
			)
			{
				return (index1.Item1.Value + index1.Item2.Value) / 2;
			}

			return index1.Item1.Value
				+
				(
					_measureCumulated_inScope
					-
					measureCumulatedS[index1.Item1.Value]
				)
				/
				measureSpan
				*
				(index1.Item2.Value - index1.Item1.Value);
			;


		}
	}
}
