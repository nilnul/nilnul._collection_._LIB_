using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection.family_.ring_.nonsigma_
{
	/*
	let X=N, define m={N}∪{A⊆N:|A|<∞ or |N−A|<∞}.
	m is closed under completion and finite union and contains ∅ and X but it's not closed under infinite countable union. Because for every odd number 2n−1 we have |{2n−1}|=1<∞ so {2n−1}∈m but
			⋃{2n−1}, where n =1 to ∞
	,is the whole odd numbers which is not finite and its completion is the whole even numbers which again is not finite.



In the above example you can easily check that the smallest sigma-field containing that field, m, is the whole power set of N.

	Denote the smallest sigma-field containing m (which we haven't compute it yet) by M. Because every subset of N, say A, can be written as

	A=
		∪{a},where a∈A
	,  And |{a}|=1<∞ so ∀a∈A:{a}∈m⊆M plus A⊆N⟹|A|≤|N|. A is a countable union of elements of M and thus it should be at M. But we showed this for an arbitrary subset of N so M=P(N).

	And there is a simple famous exercise that infinite sigma-fields are uncountable.	 */
	/// <summary>
	/// 
	/// </summary>
	class Eg0r
	{
	}
}
