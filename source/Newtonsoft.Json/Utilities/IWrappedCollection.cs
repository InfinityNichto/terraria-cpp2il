using System;
using System.Collections;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200004D RID: 77
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200005E")]
	internal interface IWrappedCollection : IList, ICollection, IEnumerable
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000318 RID: 792
		[global::Cpp2ILInjected.Token(Token = "0x1700009B")]
		object UnderlyingCollection
		{
			[global::Cpp2ILInjected.Token(Token = "0x600033A")]
			get;
		}
	}
}
