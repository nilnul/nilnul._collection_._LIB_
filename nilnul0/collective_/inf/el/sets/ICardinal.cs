using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collective_.inf.el.sets
{
	/// <summary>
	/// Let X be an infinite set of cardinality |X|, and let S be the set of all finite subsets of X
	/// , we show that Card(S)=|X|
	/// </summary>
	/// <remarks>
	/// proof:
	///		a) The cardinality is at least |X|, since S contains all singletons.
	///		b) Let Sn be the subset of S consisting of all subsets of cardinality exactly n
	///		,
	///Now, for any positive integer n, the number of subsets of X of cardinality n is at most |X|^n=|X| (equality since |X| is infinite);
	///
	///
	///  ,
	///  |S[n]|
	///   = #X * (#X -1) * .. (#X -n+1)
	///   le
	///   #X *#X ... #X
	///    = #X)^n 
	///    = #X
	///
	/// ;
	///    #S0 + #S1 + ...
	///   le:
	///		#X + #X +...
	///   = n #X
	///   = #X
	///  ;
	///  combine (a) with (b), it's #X
	/// 
	/// </remarks>
	/// <see cref="el.collectives.ICardinal"/>
	class ICardinal
    {
    }
}
