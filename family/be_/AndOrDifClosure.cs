using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection.family.be_
{

	/// <summary>
	///some family ℱ is closed under the operation of:
	/// 1) And,
	/// 2) Or,
	/// 3) Dif
	///Note: 
	/// 1) the operator is binary so the number of operands are always finite even the expression is compound such as x and y or z.
	/// 2) the family may be finite or enumerable or continume or bigger.
	/// 3) {and, or, dif } in Bit operations are not complete.
	/// </summary>
	/// <typeparam name="TElement"></typeparam>
	/// <typeparam name="TSet"></typeparam>
	public class AndOrDifClosure<TElement, TSet> : BeI<TElement, TSet>
		where TSet:nilnul.CollectionI<TElement>
	{
		public bool be(FamilyI<TElement, TSet> obj)
		{
			throw new NotImplementedException();
		}
	}
}
