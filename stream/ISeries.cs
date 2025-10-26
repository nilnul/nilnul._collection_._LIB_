using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collective.stream
{

	/// <summary>
	/// eg:
	///		for stream: (1/(n+1), n+2), ...
	///		the series is:  (1,2)  , (1/2, 3), ...,
	///	note: 0 is not in any terms. vs:<see cref="serie"/>
	/// </summary>
	internal class ISeries:cumulus_.IUnion
	{
	}
}
