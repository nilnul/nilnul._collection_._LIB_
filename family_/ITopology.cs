using System;
using System.Collections.Generic;
using System.Text;

namespace nilnul.collection.family_
{
	/// <summary>
	/// 	1) the family is closed over the nullary operator of omega (the universal set)
	///			also closed over the nullary operator of phi the empty set.
	///		2) closed over arbitrary union (sigma, or cumulated union, of a subset of the family)
	///			for finite family, union implies arbitrary union
	///		3)  intersection.
	///			implying closure over finite intersection, as repeatedly intersection resulted that the set is member of the family.
	/// member of top is also called open. and the complement of open set is called closed. a closed set might be member of the family, thus being both closed and open
	/// </summary>
	public interface ITopology
		:
		IFamily
	{
	}
}
