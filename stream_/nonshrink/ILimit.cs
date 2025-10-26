using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collective.stream_.nonshrink
{
	/// <summary>
	/// if the stream is :
	///		convergent, or absorbent (that is once an element is in it, that el will not be excluded)
	///		, then the limit is regarded as a collection contains any element that is once in a term.
	///	eg:
	///		
	///		(1,2), (1/2,3), (1/3, 4) ,...
	///		the limit is (0, inf)

	/// </summary>
	/// 
	/// alias:
	///		approach
	///		convergent
	///		eventual
	internal class ILimit
	{
	}
}
