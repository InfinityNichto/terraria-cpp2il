using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Profiling.Memory.Experimental
{
	// Token: 0x020000D9 RID: 217
	[global::Cpp2ILInjected.Token(Token = "0x20000F0")]
	public class MetaData
	{
		// Token: 0x060004FD RID: 1277 RVA: 0x00002AE2 File Offset: 0x00000CE2
		[global::Cpp2ILInjected.Token(Token = "0x600051B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F87E5C", Offset = "0x1F87E5C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MetaData()
		{
			throw null;
		}

		// Token: 0x040003CC RID: 972
		[global::Cpp2ILInjected.Token(Token = "0x4000409")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		[NonSerialized]
		public string content;

		// Token: 0x040003CD RID: 973
		[global::Cpp2ILInjected.Token(Token = "0x400040A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public string platform;
	}
}
