using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.family_.ring_
{

	/// <summary>
	/// 
	/// a field  may be not a σ-algebra
	/// Finite (or even countable ) operation of union doesn't guarantee that Omega is in the family though. For example, for the family of all natural number(a set)s, the union would be the set of natural number itself, which is not in the family.
	/// 
	/// </summary>
	/// <remarks>
	/// Real has to be defined first as well as real func before , then , we can define measure over Some sets called SigmaAlgebra.
	/// 
	/// This is, of course, not all Axiomatic. This is only part of Axiomatic we can handle. Those who cannot, such as those are not Sigma Algebra, should be peeled off to a higher level project should this project become large or should there is a need or should we have to do so because the dependency issues (Sigma algebra dependent less; some projects might need to insert into between Sigma Algebra and remaining Axiomatic set theory.)
	/// 
	/// 
	/// </remarks>
	public interface SigmableI:ISigmable
    {
		/// A sigma-field has a property named Omega(the universal set).


	}
}
