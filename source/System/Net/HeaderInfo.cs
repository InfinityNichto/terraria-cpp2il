using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000158 RID: 344
	[global::Cpp2ILInjected.Token(Token = "0x20001EB")]
	internal class HeaderInfo
	{
		// Token: 0x06000AE1 RID: 2785 RVA: 0x00004D0F File Offset: 0x00002F0F
		[global::Cpp2ILInjected.Token(Token = "0x6000C0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F24678", Offset = "0x1F24678", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal HeaderInfo(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p)
		{
			throw null;
		}

		// Token: 0x04000832 RID: 2098
		[global::Cpp2ILInjected.Token(Token = "0x4000A76")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal readonly bool IsRequestRestricted;

		// Token: 0x04000833 RID: 2099
		[global::Cpp2ILInjected.Token(Token = "0x4000A77")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		internal readonly bool IsResponseRestricted;

		// Token: 0x04000834 RID: 2100
		[global::Cpp2ILInjected.Token(Token = "0x4000A78")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal readonly HeaderParser Parser;

		// Token: 0x04000835 RID: 2101
		[global::Cpp2ILInjected.Token(Token = "0x4000A79")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal readonly string HeaderName;

		// Token: 0x04000836 RID: 2102
		[global::Cpp2ILInjected.Token(Token = "0x4000A7A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal readonly bool AllowMultiValues;
	}
}
