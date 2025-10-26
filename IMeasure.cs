namespace nilnul.collective
{
	/// <summary>
	/// if the collection is measurable (that is, from <see cref="collection.family_.ring_.sigma"/>),<see cref="nilnul.collective_.measurable.IMeasure"/>;
	/// otherwise, exception is thrown;
	/// </summary>
	/// alias:
	///		euclidean
	///		lebesgue
	///		length
	///			,distance
	///		cardinal
	///		
	/// vs:
	///		<see cref="collection.family_.ring_.sigma.IDiscern"/>, which is a directed set (a collection with a total order, or tally; <see cref=" nilnul.relation"/>)
	///		
	///	vs:，<see cref="nilnul.obj.ITally"/>, which requires the objs are linearly sortable.
	///		but measure requires the collection is measurable (from sigmaring.)
	///		<see cref="collection.family_.ring_.sigma.IDiscern"/> is also a tally but requires a relation ( a collection with an association/mapping that is linearly)
	///	vs:
	///		<see cref="collection.ICardinality"/>, which is unitless, whileas this is with a unit so the quantity can change according to the unit. 
	public interface IMeasure
		:
		nilnul.collective_.measurable.IMeasure
	{
	}




}
