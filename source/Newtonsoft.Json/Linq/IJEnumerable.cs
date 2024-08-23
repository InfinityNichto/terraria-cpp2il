using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000095 RID: 149
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000C0")]
	public interface IJEnumerable<T> : IEnumerable<T>, IEnumerable where T : JToken
	{
		// Token: 0x1700014E RID: 334
		[global::Cpp2ILInjected.Token(Token = "0x17000156")]
		IJEnumerable<JToken> this[object key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006F1")]
			get;
		}
	}
}
