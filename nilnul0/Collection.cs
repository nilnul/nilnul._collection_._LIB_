using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using nilnul._colletion_;

namespace nilnul
{

	/// <summary>
	/// by axio of choice, every collection is enumerable.
	/// but for discrete set, the enumerable covers all elements; for continuum or bigger collection, the enumerable cannot covers all elements, as proven by cantor diagonal
	/// </summary>
	public interface CollectionI {

	}

	public interface CollectionI<T>:CollectionI, _colletion_.ContainI<T>
	{

	}
	/// <summary>
	/// parameterless construtor always constructs an empty collection.
	/// </summary>
	/// <remarks>
	/// The difference between collection and set:
	///		collection is defined with "contain"  ("c" is defined by "c"). this collection may be finite, countable, or continuum or more
	///		set is defined by a str (finite).
	///		some recursion is defined by recursion, which is enumerable.
	/// 
	/// </remarks>
	public class Collection:CollectionI
	{

	}

	public abstract class CollectionA<T> : ContainI<T>
	{
		public abstract bool contain(T element);
	}
}
