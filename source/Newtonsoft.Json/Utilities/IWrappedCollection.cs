using System;
using System.Collections;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200005E")]
	internal interface IWrappedCollection : IList, ICollection, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700009B")]
		object UnderlyingCollection
		{
			[global::Cpp2ILInjected.Token(Token = "0x600033A")]
			get;
		}
	}
}
