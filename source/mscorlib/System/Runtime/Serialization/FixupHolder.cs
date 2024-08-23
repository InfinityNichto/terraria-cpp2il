using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x02000336 RID: 822
	[global::Cpp2ILInjected.Token(Token = "0x20003DE")]
	[global::System.Serializable]
	internal class FixupHolder
	{
		// Token: 0x06001D29 RID: 7465 RVA: 0x00019685 File Offset: 0x00017885
		[global::Cpp2ILInjected.Token(Token = "0x6001F67")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B57F10", Offset = "0x1B57F10", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal FixupHolder(long id, object fixupInfo, int fixupType)
		{
			throw null;
		}

		// Token: 0x04000CBE RID: 3262
		[global::Cpp2ILInjected.Token(Token = "0x4000FB0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal long m_id;

		// Token: 0x04000CBF RID: 3263
		[global::Cpp2ILInjected.Token(Token = "0x4000FB1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal object m_fixupInfo;

		// Token: 0x04000CC0 RID: 3264
		[global::Cpp2ILInjected.Token(Token = "0x4000FB2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int m_fixupType;
	}
}
