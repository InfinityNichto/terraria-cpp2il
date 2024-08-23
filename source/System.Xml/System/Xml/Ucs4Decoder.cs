using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200007C RID: 124
	[global::Cpp2ILInjected.Token(Token = "0x20000A3")]
	internal abstract class Ucs4Decoder : Decoder
	{
		// Token: 0x060006E2 RID: 1762 RVA: 0x00004355 File Offset: 0x00002555
		[global::Cpp2ILInjected.Token(Token = "0x600076B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAE398", Offset = "0x1DAE398", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			throw null;
		}

		// Token: 0x060006E3 RID: 1763
		[global::Cpp2ILInjected.Token(Token = "0x600076C")]
		internal abstract int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

		// Token: 0x060006E4 RID: 1764 RVA: 0x00004358 File Offset: 0x00002558
		[global::Cpp2ILInjected.Token(Token = "0x600076D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAE3B4", Offset = "0x1DAE3B4", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			throw null;
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0000435B File Offset: 0x0000255B
		[global::Cpp2ILInjected.Token(Token = "0x600076E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAE4E4", Offset = "0x1DAE4E4", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			throw null;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0000435E File Offset: 0x0000255E
		[global::Cpp2ILInjected.Token(Token = "0x600076F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAE690", Offset = "0x1DAE690", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Ucs4ToUTF16(uint code, char[] chars, int charIndex)
		{
			throw null;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00004361 File Offset: 0x00002561
		[global::Cpp2ILInjected.Token(Token = "0x6000770")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAE6BC", Offset = "0x1DAE6BC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Ucs4Encoding1234), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Ucs4Encoding4321), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Ucs4Encoding2143), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Ucs4Encoding3412), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Ucs4Decoder4321), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Ucs4Decoder1234), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Ucs4Decoder2143), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Ucs4Decoder3412), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Decoder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected Ucs4Decoder()
		{
			throw null;
		}

		// Token: 0x04000252 RID: 594
		[global::Cpp2ILInjected.Token(Token = "0x40003BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal byte[] lastBytes;

		// Token: 0x04000253 RID: 595
		[global::Cpp2ILInjected.Token(Token = "0x40003BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal int lastBytesCount;
	}
}
