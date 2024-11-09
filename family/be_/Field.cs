using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection.family.be_
{
	/// <summary>
	/// a family ℱ is called Field of Sets or Algebra of Set if it is closed under the operation of: 
	///		1) Omega(a nullary operator that always return Omega which is the superset of all elements).
	///			this is the biggest set. and there is only one biggest set.
	///		2) (complement)
	///			a unary op
	///		3) (union)
	///			a binary op
	/// 
	/// the closure of union doesn't imply the closure of Omega. so the 3) is necessary.
	///		for example, N is not closed on union, but ( N union {Inf}) is closed on union
	///
	/// 
	/// 
	///  the definition implicitly requires the field is not empty. Also note that Omega here must be the superset of all sets.
	/// </summary>
	/// <remarks>
	/// Some Family Closed under {∨,−,Ω}
	/// The closure of Complement is implied.
	/// The closure of And is implied by DeMorgan rule with {Or, Complement}
	/// Note that:
	/// 1) Complement operations imply both Omega and Dif, so our definition is not redundant in comparsion with the conventional definition using {and,or, complement}; Nontheless
	/// 2) { and, or, diff, omega} is corresponding to bit operators { and, or, diff, 1} which is complete while {and,or,dif} is incomplete.
	/// </remarks>
	/// <typeparam name="TElement"></typeparam>
	/// <typeparam name="TCollection"></typeparam>
	public class FieldAlgebra<TElement, TCollection>
		: nilnul.collection.family.BeI<TElement, TCollection>
		where TCollection : nilnul.CollectionI<TElement>
	{
		public bool be(FamilyI<TElement, TCollection> obj)
		{
			throw new NotImplementedException();
		}
	}
}
