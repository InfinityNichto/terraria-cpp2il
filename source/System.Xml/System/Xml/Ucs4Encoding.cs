using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x200009E")]
	internal class Ucs4Encoding : Encoding
	{
		[global::Cpp2ILInjected.Token(Token = "0x170001BE")]
		public override string WebName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600074F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DADDAC", Offset = "0x1DADDAC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000750")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DADDB8", Offset = "0x1DADDB8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override Decoder GetDecoder()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000751")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DADDC0", Offset = "0x1DADDC0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override int GetByteCount(char[] chars, int index, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000752")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DADE20", Offset = "0x1DADE20", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override byte[] GetBytes(string s)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000753")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DADE28", Offset = "0x1DADE28", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000754")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DADE30", Offset = "0x1DADE30", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetMaxByteCount(int charCount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000755")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DADE38", Offset = "0x1DADE38", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000756")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DADE48", Offset = "0x1DADE48", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000757")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DADE58", Offset = "0x1DADE58", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetMaxCharCount(int byteCount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001BF")]
		public override int CodePage
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000758")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DADE70", Offset = "0x1DADE70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000759")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DADE78", Offset = "0x1DADE78", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override Encoder GetEncoder()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001C0")]
		internal static Encoding UCS4_Littleendian
		{
			[global::Cpp2ILInjected.Token(Token = "0x600075A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DADE80", Offset = "0x1DADE80", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ucs4Encoding4321), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001C1")]
		internal static Encoding UCS4_Bigendian
		{
			[global::Cpp2ILInjected.Token(Token = "0x600075B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DADF30", Offset = "0x1DADF30", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ucs4Encoding1234), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001C2")]
		internal static Encoding UCS4_2143
		{
			[global::Cpp2ILInjected.Token(Token = "0x600075C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DADFE0", Offset = "0x1DADFE0", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ucs4Encoding2143), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001C3")]
		internal static Encoding UCS4_3412
		{
			[global::Cpp2ILInjected.Token(Token = "0x600075D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DAE090", Offset = "0x1DAE090", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ucs4Encoding3412), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600075E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAE140", Offset = "0x1DAE140", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
		public Ucs4Encoding()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40003B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal Ucs4Decoder ucs4Decoder;
	}
}
