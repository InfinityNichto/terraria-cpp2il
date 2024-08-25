using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000C0")]
	public interface IJEnumerable<T> : IEnumerable<T>, IEnumerable where T : JToken
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000156")]
		IJEnumerable<JToken> this[object key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006F1")]
			get;
		}
	}
}
