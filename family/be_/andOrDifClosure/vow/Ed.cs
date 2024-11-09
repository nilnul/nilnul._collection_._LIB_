using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection.family.be_.andOrDifClosure.vow
{
	public interface EdI<TElement, TCollection>
		where TCollection : nilnul.CollectionI<TElement>
	{
		/// <summary>
		/// The union of all sets is called Omega. We can do the union over all sets even the family is uncoutable under the assurance of the Axiom of Union.
		/// Note:
		/// Finite (or even countable, but for andOrDifClosure we have no countable operator such as sigma) operation of union doesn't guarantee that Omega is in the field though. For example, for the family of all natural number(a set)s, the union would be the set of natural number itself, which is not in the family.
		/// While we guarantee the closure of countable union, we don't gurantee the closure of uncountable union. So if the family is uncountable, we need to make sure by one extra constraint: the Omega must be in the family. So we change our proposition.
		/// </summary>
		TCollection omega { get; }

	}
}
