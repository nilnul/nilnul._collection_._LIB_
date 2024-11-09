using System;
using System.Collections.Generic;
using System.Text;

namespace nilnul.num.real.clamp_.unial.xpn_
{
	/// <summary>
	/// addd all the reals in [-1,1]; but add is only defined on discrete set of reals;
	/// even for <see cref="collection_.IDenumerous"/>, the order of elements cannot be changed; (for finite one, we can have commutative rule;).
	/// </summary>
	/// <remarks>
	/// for continuum, we can only define integration.
	/// the integration from [-1,1] of 1 is 0. 
	/// </remarks>
	/// <see cref="num.real.interval_.full.xpn_.ISum"/>
	/// <seealso cref="nilnul.num.real.IClamp"/>
	internal class ISum
	{
		/*
		 
		 [-1,0)为甲阵营，(0,1]为乙阵营，两大阵营对决，一对一单挑。
甲派出任意x，乙就派出0.5(1-x)，
x+0.5(1-x)=0.5(1+x)≥0
这样双方派出来的数，之和为正，且乙方还有(0,0.5)的一半人马没有动用。
如果乙方先出，甲方可以同样方法使得这些数的和为负

如果对甲方的 x，乙方直接出 -x，结果为零


		
		 */

		/*
		 但首先如果不可数的集合，你写不出一个有效的公式来把所有这些数字加起来。
就好比证明R是不可数一样的对角线法，当你声称你写出了这样的公式时，我总能找到某个实数r，不在你的连加公式里。
		 */

		/*
	集合里元素个数为不可数无穷时，连排成一列加起来都做不到，因为能排成一列就意味着能和自然数集建立一一对应关系。	 
		 */
	}
}
