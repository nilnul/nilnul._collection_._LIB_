using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{

	/// we may also include some measure theory;
	/// 
	/// <summary>
	/// an extension of finite set, with the inner is not rigidly defined, and we only require some outside behavior, that's how axiomatic way works, such as "has";
	/// axiomatic set theory. This is collective_.axiomatic, and collective_.discrete is regarded as a case for axiomatic set as it is where the axiomatic theory is based, and infinitely countable set's cardinality equivalence still requires axiomatic theory;
	/// </summary>
	/// <remarks>
	/// the collection can be finite, discrete, or continuum, or beyond as fully a blackbox leaving us only the axiomatic way to express it from outside.
	/// </remarks>
	/// a container and the content.
	/// alias:
	///		set_.Axiomatic
	///		set.Axiomatic
	///		collection, occupied by <see cref="System.Collections.ICollection"/>
	///		collective, as this is an interface, and no concrete implementation til subtypes like <see cref="collective_.IFinite"/> or <see cref="collective_.IDenumerous"/>
	/// vs:
	///		<see cref="nilnul.obj.IGenre{T}"/>
	///		type, which can be regarded as a collection that might be infinite.
	///	<see cref="nilnul.CollectionI"/>
	public interface ICollective {
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// vs:
	///		<see cref="nilnul.obj.IGenre{T}"/> can be regarded as a collection:
	///			:: the type must be exactly the one specified;
	///			:: the eq is used to determine whether an element is already in the collection
	///			:: the instances can be infinite.
	/// 
	/// 
	public interface ICollective<T>:ICollective {

	}



	
}
