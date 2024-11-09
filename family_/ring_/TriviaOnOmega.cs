using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection.family_.ring_
{
	/// <summary>
	/// {phi, omega}. some times omega = phi such that {phi, omega} can be rewritten as {phi}
	/// </summary>
	public class TriviaOnOmega<TElement,TCollection>
		:nilnul.enumerable.AsEnumerableA<TCollection>
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
		public TriviaOnOmega(TCollection omega)
		{
			_omega = omega;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override IEnumerator<TCollection> GetEnumerator()
		{
			if (true)	//if omega is not empty
			{
				//yield return empty;
			}
				//yield return omega

			throw new NotImplementedException();
		}

	
	}
}
