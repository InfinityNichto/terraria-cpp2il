using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	[global::Cpp2ILInjected.Token(Token = "0x200025E")]
	[global::System.Serializable]
	public abstract class Decoder
	{
		[global::Cpp2ILInjected.Token(Token = "0x600147A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB12F0", Offset = "0x1CB12F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding.DefaultDecoder), Member = ".ctor", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding.DefaultDecoder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetDecoder", ReturnType = typeof(Decoder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.UTF16Decoder", Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.SafeAsciiDecoder", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Ucs4Decoder", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected Decoder()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001FF")]
		public DecoderFallback Fallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x600147B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB12F8", Offset = "0x1CB12F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000200")]
		public unsafe DecoderFallbackBuffer FallbackBuffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x600147C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB0C84", Offset = "0x1CB0C84", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ASCIIEncoding), Member = "GetCharCount", MemberParameters = new object[]
			{
				typeof(byte*),
				typeof(int),
				typeof(DecoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ASCIIEncoding), Member = "GetChars", MemberParameters = new object[]
			{
				typeof(byte*),
				typeof(int),
				typeof(char*),
				typeof(int),
				typeof(DecoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF32Encoding), Member = "GetCharCount", MemberParameters = new object[]
			{
				typeof(byte*),
				typeof(int),
				typeof(DecoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF32Encoding), Member = "GetChars", MemberParameters = new object[]
			{
				typeof(byte*),
				typeof(int),
				typeof(char*),
				typeof(int),
				typeof(DecoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = "GetCharCount", MemberParameters = new object[]
			{
				typeof(byte*),
				typeof(int),
				typeof(DecoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = "GetChars", MemberParameters = new object[]
			{
				typeof(byte*),
				typeof(int),
				typeof(char*),
				typeof(int),
				typeof(DecoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnicodeEncoding), Member = "GetCharCount", MemberParameters = new object[]
			{
				typeof(byte*),
				typeof(int),
				typeof(DecoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnicodeEncoding), Member = "GetChars", MemberParameters = new object[]
			{
				typeof(byte*),
				typeof(int),
				typeof(char*),
				typeof(int),
				typeof(DecoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding.EncodingCharBuffer), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Encoding),
				typeof(DecoderNLS),
				typeof(char*),
				typeof(int),
				typeof(byte*),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "ThrowCharsOverflow", MemberParameters = new object[]
			{
				typeof(DecoderNLS),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallback), Member = "get_ReplacementFallback", ReturnType = typeof(DecoderFallback))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000201")]
		internal bool InternalHasFallbackBuffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x600147D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB1300", Offset = "0x1CB1300", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "ThrowCharsOverflow", MemberParameters = new object[]
			{
				typeof(DecoderNLS),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600147E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB1310", Offset = "0x1CB1310", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public virtual void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600147F")]
		public abstract int GetCharCount(byte[] bytes, int index, int count);

		[global::Cpp2ILInjected.Token(Token = "0x6001480")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB1418", Offset = "0x1CB1418", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush)
		{
			throw null;
		}

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001481")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB1424", Offset = "0x1CB1424", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public unsafe virtual int GetCharCount(byte* bytes, int count, bool flush)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001482")]
		public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

		[global::Cpp2ILInjected.Token(Token = "0x6001483")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB1560", Offset = "0x1CB1560", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
		{
			throw null;
		}

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001484")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB156C", Offset = "0x1CB156C", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001485")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB1754", Offset = "0x1CB1754", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual int GetChars(global::System.ReadOnlySpan<byte> bytes, global::System.Span<char> chars, bool flush)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001486")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB17FC", Offset = "0x1CB17FC", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			throw null;
		}

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001487")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB1AD8", Offset = "0x1CB1AD8", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public unsafe virtual void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000AE4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal DecoderFallback _fallback;

		[global::Cpp2ILInjected.Token(Token = "0x4000AE5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal DecoderFallbackBuffer _fallbackBuffer;
	}
}
