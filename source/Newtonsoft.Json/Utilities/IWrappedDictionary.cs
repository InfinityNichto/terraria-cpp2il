using System;
using System.Collections;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000061")]
	internal interface IWrappedDictionary : IDictionary, ICollection, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x170000A3")]
		object UnderlyingDictionary
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000376")]
			get;
		}
	}
}
