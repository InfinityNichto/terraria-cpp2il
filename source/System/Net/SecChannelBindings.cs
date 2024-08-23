using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200012A RID: 298
	[global::Cpp2ILInjected.Token(Token = "0x20001B1")]
	[StructLayout(0)]
	internal class SecChannelBindings
	{
		// Token: 0x0600098F RID: 2447 RVA: 0x0000494C File Offset: 0x00002B4C
		[global::Cpp2ILInjected.Token(Token = "0x6000A9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0F7B0", Offset = "0x1F0F7B0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SecChannelBindings()
		{
			throw null;
		}

		// Token: 0x040006EA RID: 1770
		[global::Cpp2ILInjected.Token(Token = "0x4000903")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int dwInitiatorAddrType;

		// Token: 0x040006EB RID: 1771
		[global::Cpp2ILInjected.Token(Token = "0x4000904")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int cbInitiatorLength;

		// Token: 0x040006EC RID: 1772
		[global::Cpp2ILInjected.Token(Token = "0x4000905")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int dwInitiatorOffset;

		// Token: 0x040006ED RID: 1773
		[global::Cpp2ILInjected.Token(Token = "0x4000906")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		internal int dwAcceptorAddrType;

		// Token: 0x040006EE RID: 1774
		[global::Cpp2ILInjected.Token(Token = "0x4000907")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int cbAcceptorLength;

		// Token: 0x040006EF RID: 1775
		[global::Cpp2ILInjected.Token(Token = "0x4000908")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		internal int dwAcceptorOffset;

		// Token: 0x040006F0 RID: 1776
		[global::Cpp2ILInjected.Token(Token = "0x4000909")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal int cbApplicationDataLength;

		// Token: 0x040006F1 RID: 1777
		[global::Cpp2ILInjected.Token(Token = "0x400090A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		internal int dwApplicationDataOffset;
	}
}
