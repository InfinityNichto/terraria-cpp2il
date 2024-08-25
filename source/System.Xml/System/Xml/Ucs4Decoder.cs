using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x20000A3")]
	internal abstract class Ucs4Decoder : Decoder
	{
		[global::Cpp2ILInjected.Token(Token = "0x600076B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAE398", Offset = "0x1DAE398", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600076C")]
		internal abstract int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

		[global::Cpp2ILInjected.Token(Token = "0x600076D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAE3B4", Offset = "0x1DAE3B4", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600076E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAE4E4", Offset = "0x1DAE4E4", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600076F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAE690", Offset = "0x1DAE690", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Ucs4ToUTF16(uint code, char[] chars, int charIndex)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x40003BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal byte[] lastBytes;

		[global::Cpp2ILInjected.Token(Token = "0x40003BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal int lastBytesCount;
	}
}
