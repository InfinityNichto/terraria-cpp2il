using System;

namespace Cpp2ILInjected
{
	public sealed class AddressAttribute : Attribute
	{
		public AddressAttribute()
		{
			throw null;
		}

		public string RVA;

		public string Offset;

		public string Length;
	}
}
