namespace nilnul.collective.family_.ring_.sigma
{
	/// <summary>
	/// when one measure minus another.
	/// when subtraction can be carried out, it implies a negation which is 0 - measure. Hence a signed measure is implied.
	/// </summary>
	/// <remarks>
	/// an extension from <see cref="IMeasure"/> to be not only sigmable, but also subtractable;
	/// </remarks>
	/// alias:
	///		difference
	///	<see cref="obj.measure.ISigned"/>
	///
	/// vs:
	///		<see cref="nilnul.relation_.ITally"/> like temperature, used just for comparison, not for sigma addition.
	public interface IDiscern { }

}
