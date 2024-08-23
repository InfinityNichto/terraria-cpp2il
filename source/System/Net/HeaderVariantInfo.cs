using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000173 RID: 371
	[global::Cpp2ILInjected.Token(Token = "0x2000215")]
	internal struct HeaderVariantInfo
	{
		// Token: 0x06000BCE RID: 3022 RVA: 0x00004FCA File Offset: 0x000031CA
		[global::Cpp2ILInjected.Token(Token = "0x6000D29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F30BB8", Offset = "0x1F30BB8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal HeaderVariantInfo(string name, CookieVariant variant)
		{
			throw null;
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x00004FCD File Offset: 0x000031CD
		[global::Cpp2ILInjected.Token(Token = "0x170002BF")]
		internal string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D2A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F30BC4", Offset = "0x1F30BC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x00004FD0 File Offset: 0x000031D0
		[global::Cpp2ILInjected.Token(Token = "0x170002C0")]
		internal CookieVariant Variant
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D2B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F30BCC", Offset = "0x1F30BCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040008D6 RID: 2262
		[global::Cpp2ILInjected.Token(Token = "0x4000B42")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private string m_name;

		// Token: 0x040008D7 RID: 2263
		[global::Cpp2ILInjected.Token(Token = "0x4000B43")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private CookieVariant m_variant;
	}
}
