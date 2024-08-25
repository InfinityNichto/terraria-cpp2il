using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000096")]
	public interface IContractResolver
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000539")]
		JsonContract ResolveContract(Type type);
	}
}
