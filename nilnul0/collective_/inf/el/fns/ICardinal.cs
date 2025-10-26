using nilnul.num.quotient;
using nilnul.obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collective_.inf.el.fns
{
	///math.stackexchange.com/questions/413836/cardinality-of-all-real-sequences
	///, a conjecture?:
	///
	///
	///
	/// X => Y
	/// |Y^X| = max(
	///		|Y|
	///		,
	///		|2^X|
	/// )
	/// 
	///
	///;
	///When Y is N,
	///	Y^X = N^X
	///	,when X =N, then Y^X = N^N = N		#<see cref="nilnul.num.streams"/>
	///	, when X =R, then Y^X= N^((2^N)) = 2^R
	///	, when X >R, then Y^X = N^(2^N *X) = (2^R)^X = 2^(RX) = 2^X  
	///
	/// When Y is 2^Z
	/// , then Y^X = 2^(ZX)
	///
	/// if Z >= X (then Y >=X), then Y^X = 2^Z = Y
	/// if Z lt X (then Y=2^Z le X lt 2^X), then Y^X = 2^X 
	/// 
	/// 
	/// <summary>
	/// </summary>
	class ICardinal
    {
    }
}
