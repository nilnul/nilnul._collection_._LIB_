namespace nilnul.collective.family_.ring_.sigma
{
	/// we need to sigma the measure. So measure is defined on <see cref="family_.ring_.sigma"/>, not on <see cref="collective.IFamily"/>, not mention <see cref="nilnul.collective"/>
	/// <summary>
	/// Measures are defined as certain types of functions,μ from a σ-field to [0, ∞] such that:
	/// 1) μ(Φ)=0.
	///		Or at least one set has finite measure; this will deduces that μ(Φ)=0; and vice versa.
	/// 2) countable additivity or σ-additivity.
	///		that is,for pairwise disjoint sequence of sets A[i], μ(∪A)=sum( μ(A[i]) )
	/// on the other hand,  uncountable additivity (the extension of axiom 3 to an uncountable index set I) is unreasonable() for probability, just as it is for other measures.For example, an interval of positive length in ℝ is a union of uncountably	many points, each of which has length 0.
	/// 
	/// </summary>
	/// <remarks>
	///not only comparable, but also addable as well as sigmable.
	/// </remarks>
	/// alias:
	///		gauge
	///		
	///		
	public interface IMeasure
		//: nilnul.relation_.ITally
	{ }

}
