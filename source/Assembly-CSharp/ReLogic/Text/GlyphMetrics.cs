using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.Text
{
	// Token: 0x0200071A RID: 1818
	[global::Cpp2ILInjected.Token(Token = "0x2000B14")]
	public struct GlyphMetrics
	{
		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06004670 RID: 18032 RVA: 0x0002E9B8 File Offset: 0x0002CBB8
		[global::Cpp2ILInjected.Token(Token = "0x170008F3")]
		public float KernedWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005319")]
			[global::Cpp2ILInjected.Address(RVA = "0x940F44", Offset = "0x940F44", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06004671 RID: 18033 RVA: 0x0002E9BB File Offset: 0x0002CBBB
		[global::Cpp2ILInjected.Token(Token = "0x170008F4")]
		public float KernedWidthOnNewLine
		{
			[global::Cpp2ILInjected.Token(Token = "0x600531A")]
			[global::Cpp2ILInjected.Address(RVA = "0x940F58", Offset = "0x940F58", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004672 RID: 18034 RVA: 0x0002E9BE File Offset: 0x0002CBBE
		[global::Cpp2ILInjected.Token(Token = "0x600531B")]
		[global::Cpp2ILInjected.Address(RVA = "0x940FD0", Offset = "0x940FD0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private GlyphMetrics(float leftPadding, float characterWidth, float rightPadding)
		{
			throw null;
		}

		// Token: 0x06004673 RID: 18035 RVA: 0x0002E9C1 File Offset: 0x0002CBC1
		[global::Cpp2ILInjected.Token(Token = "0x600531C")]
		[global::Cpp2ILInjected.Address(RVA = "0x940FDC", Offset = "0x940FDC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static GlyphMetrics FromKerningData(float leftPadding, float characterWidth, float rightPadding)
		{
			throw null;
		}

		// Token: 0x04007167 RID: 29031
		[global::Cpp2ILInjected.Token(Token = "0x4008AF2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly float LeftPadding;

		// Token: 0x04007168 RID: 29032
		[global::Cpp2ILInjected.Token(Token = "0x4008AF3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public readonly float CharacterWidth;

		// Token: 0x04007169 RID: 29033
		[global::Cpp2ILInjected.Token(Token = "0x4008AF4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public readonly float RightPadding;
	}
}
