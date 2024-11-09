using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._colletion_
{
	public interface ContainI
	{
	}

	public interface ContainI<T> : ContainI {
		bool contain(T element);
	}
}
