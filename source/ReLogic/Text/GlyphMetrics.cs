using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.Text
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B14")]
	public struct GlyphMetrics
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x600531B")]
		[global::Cpp2ILInjected.Address(RVA = "0x940FD0", Offset = "0x940FD0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private GlyphMetrics(float leftPadding, float characterWidth, float rightPadding)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600531C")]
		[global::Cpp2ILInjected.Address(RVA = "0x940FDC", Offset = "0x940FDC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static GlyphMetrics FromKerningData(float leftPadding, float characterWidth, float rightPadding)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008AF2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly float LeftPadding;

		[global::Cpp2ILInjected.Token(Token = "0x4008AF3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public readonly float CharacterWidth;

		[global::Cpp2ILInjected.Token(Token = "0x4008AF4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public readonly float RightPadding;
	}
}
