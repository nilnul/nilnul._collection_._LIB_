using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection.family_.ring_.sigma
{
	/// <summary>
	/// Measures are defined as certain types of functions,μ from a σ-field to [0, ∞] such that:
	/// 1) μ(Φ)=0.
	///		Or at least one set has finite meansure; this will deduces that μ(Φ)=0; and vice versa.
	/// 2) countable additivity or σ-additivity.
	///		that is,for pairwise disjoint sequence of sets A[i], μ(∪A)=sum( μ(A[i]) )
	/// on the other hand,  uncountable additivity (the extension of axiom 3 to an uncountable index set I) is unreasonable() for probability, just as it is for other measures.For example, an interval of positive length in ℝ is a union of uncountably	many points, each of which has length 0.
	/// 
	/// </summary>
	public interface IMeasure { }
	public interface MeasureI
	{

	}
}
