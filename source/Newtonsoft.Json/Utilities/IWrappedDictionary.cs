using System;
using System.Collections;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000050 RID: 80
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000061")]
	internal interface IWrappedDictionary : IDictionary, ICollection, IEnumerable
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000354 RID: 852
		[global::Cpp2ILInjected.Token(Token = "0x170000A3")]
		object UnderlyingDictionary
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000376")]
			get;
		}
	}
}
