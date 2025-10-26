using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collective.measure.bi_
{
	/// <summary>
	/// compare the measure, then use the big one to minus the smaller one.
	/// Note:
	///		when smaller one minus big one, it's exception, as negative measure is undefined. (there is no negative measure. for signed measure, see in latter prj: nilnul._relation_)
	/// </summary>
	/// alias:
	///		delta
	///		span
	///		length
	///	vs:
	///		difference, can be negative.
	///		
	///	vs:
	///		length
	///			,which <see cref="nilnul.collective.ICardinality"/>
	///		
	internal class IDistance
	{
	}
}
