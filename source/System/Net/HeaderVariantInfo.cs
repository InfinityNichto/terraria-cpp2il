using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000215")]
	internal struct HeaderVariantInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F30BB8", Offset = "0x1F30BB8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal HeaderVariantInfo(string name, CookieVariant variant)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000B42")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private string m_name;

		[global::Cpp2ILInjected.Token(Token = "0x4000B43")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private CookieVariant m_variant;
	}
}
