using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection.family
{
	//extern alias obj;
	public interface BeI<TElement, TSet>
		:
		//obj::
		nilnul.obj.BeI1<nilnul.collection.FamilyI<TElement,TSet>>
		where TSet: nilnul.CollectionI<TElement>
	{
	}
}
