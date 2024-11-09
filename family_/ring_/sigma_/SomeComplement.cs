using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection.family_.ring_.sigmable_
{
	/// <summary>
	/// 0, omega, x, !x
	/// </summary>
	public interface IQuad {

	}
	public interface SomeComplementI<TElement,TCollection>
		:IQuad

		where TCollection:nilnul.CollectionI<TElement>
	{

	
	}
}
