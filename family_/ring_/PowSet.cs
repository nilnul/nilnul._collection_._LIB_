using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection.family_.ring_
{
	/// <summary>
	/// this may be not denumerable
	/// </summary>
	public class PowSet<TElement,TCollection>
		where TCollection:nilnul.CollectionI<TElement>
	{
		private TCollection _omega;

		public TCollection omega
		{
			get { return _omega; }
			set { _omega = value; }
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="omega">may be empty</param>
		public PowSet(TCollection omega)
		{
			_omega = omega;
		}

		

	
	}
}
