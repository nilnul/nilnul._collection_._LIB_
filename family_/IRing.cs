using System;
using System.Collections.Generic;
using System.Text;

namespace nilnul.collective.family_
{
	/// <summary>
	/// a ring over delta, and intersect;
	/// </summary>
	/// <remarks>
	/// it's deduced that it's a closed algebra for common operators:
	///		complement
	///		,
	///		union
	///		,
	///		intersect
	/// </remarks>
	/// alias:
	///		filed, which might be confusing as <see cref="nilnul.abgebra_.cobi_.ring_.field"/> (not realm of a raletion, which is named by some as field)
	public interface IRing
		:IFamily
	{
	}
}
