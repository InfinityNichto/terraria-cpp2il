using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000086 RID: 134
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000AF")]
	public class JsonStringContract : JsonPrimitiveContract
	{
		// Token: 0x06000631 RID: 1585 RVA: 0x000032AE File Offset: 0x000014AE
		[global::Cpp2ILInjected.Token(Token = "0x60006A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D018B4", Offset = "0x1D018B4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateStringContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonStringContract))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPrimitiveContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JsonStringContract(Type underlyingType)
		{
			throw null;
		}
	}
}
