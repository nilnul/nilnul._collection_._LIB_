using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection.family_.uncountable_.nontopo_
{
	/// <summary>
	/// Let X be an uncountable set. Also let τ = {O ⊆X∣ O = X or O is at most countable}
	/// For this example,  τ is closed under finite intersections and under countable unions. But it isn't a topology on X as it isn't closed under arbitrary unions.
	/// eg:
	///		Let X=R, and consider the set [0,1]. Then:
	///		[0,1] is a union of sets in τ, namely
	///		[0,1]=⋃{x}, where x∈[0,1],
	///		so [0,1] had better be in τ if τ is to be a topology.
	///		But [0,1] isn't X itself and it also isn't countable, so it's not in τ. What's going on here is that while we can write it as a union of a bunch of sets in τ (as above), we can't write it as a union of only countably many sets in τ.
	/// </summary>
	class ClosedOverCountableOp
	{
	}
}
