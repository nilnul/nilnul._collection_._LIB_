using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection.family.be_.field_
{
	/// <summary>
	/// A family is called sigma-algebra if it's closed under { omega , complement, stream union }.
	/// cuz it's closed over stream union, then it's closed over union
	/// The stream ∧ is implied by DeMorgan rule.
	/// </summary>
	/// <remarks>
	/// alias:
	///		sigma-field
	///		
	/// Note here the closure of (stream union) doesn't imply Omega is closed (in the family) in that:
	/// 1) For example, for the family of all natural number(a set)s, the union would be the set of natural number itself, which is not in the family.
	/// Due to the above reason, we have to including "Omega" operation in the definition
	///	
	/// Why is the σ? Here σ stands for the summing of countable set(while + stands for binary operator which can recursively apply to finite set); the σ algebra constraints guarantee the family being defined is σ-summable, while a simple field that is just a simple algebra, not σ-algebra, guarantee only finite union.
	/// 
	/// Theorems:
	/// A σ-algebra is also closed under countable intersetion due to De' Morgan law. 
	/// A σ-algebra over X also contains X as a member, and ∅ as a member as well.
	/// a sigmaField is a field, as  countable union (a union b union b union b) is equiv to (a union b)
	/// </remarks>
	public class Sigmable
	{

	}
}
