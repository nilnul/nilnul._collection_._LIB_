using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection
{
	/// <summary>
	/// a collection of collection
	/// </summary>
	public interface FamilyI<T, TCollection>
		:nilnul.CollectionI<TCollection>
		where TCollection: nilnul.CollectionI<T>
	{


	}
}
