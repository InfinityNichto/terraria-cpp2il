using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000074 RID: 116
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000096")]
	public interface IContractResolver
	{
		// Token: 0x060004D7 RID: 1239
		[global::Cpp2ILInjected.Token(Token = "0x6000539")]
		JsonContract ResolveContract(Type type);
	}
}
