using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000070 RID: 112
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000089")]
	internal class DefaultContractResolverState
	{
		// Token: 0x06000490 RID: 1168 RVA: 0x00002E10 File Offset: 0x00001010
		[global::Cpp2ILInjected.Token(Token = "0x60004D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE3D98", Offset = "0x1CE3D98", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyNameTable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DefaultContractResolverState()
		{
			throw null;
		}

		// Token: 0x040001E0 RID: 480
		[global::Cpp2ILInjected.Token(Token = "0x4000225")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Dictionary<ResolverContractKey, JsonContract> ContractCache;

		// Token: 0x040001E1 RID: 481
		[global::Cpp2ILInjected.Token(Token = "0x4000226")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public PropertyNameTable NameTable;
	}
}
