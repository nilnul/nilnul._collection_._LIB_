using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collective_
{
	/// <summary>
	/// a collection that is, in terms of cardinality, equipotent to Real, which is in turn equipotent to PowerSet of NaturalNum <see cref="nameof(nilnul.collective_.countable_.OfStream)"/>
	/// </summary>
	/// 
	/// alias:
	///		set.continuum

	public interface IContinuum
		:
		collective_.in2real_.IUncountable
	{
	}
}
