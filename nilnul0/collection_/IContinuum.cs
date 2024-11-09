using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection_
{
	/// <summary>
	/// a collection that is, in terms of cardinality, equipotent to Real, which is in turn equipotent to PowerSet of NaturalNum <see cref="nameof(nilnul.collection_.discrete_.OfStream)"/>
	/// </summary>
	/// 
	/// alias:
	///		set.continuum

	interface IContinuum
		:
		collection_.IInfinite
	{
	}
}
