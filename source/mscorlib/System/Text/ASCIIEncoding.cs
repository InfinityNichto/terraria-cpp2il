using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001D8 RID: 472
	[global::Cpp2ILInjected.Token(Token = "0x200025C")]
	[global::System.Serializable]
	public class ASCIIEncoding : Encoding
	{
		// Token: 0x060012AA RID: 4778 RVA: 0x00017963 File Offset: 0x00015B63
		[global::Cpp2ILInjected.Token(Token = "0x6001463")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAF2C8", Offset = "0x1CAF2C8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public ASCIIEncoding()
		{
			throw null;
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x00017966 File Offset: 0x00015B66
		[global::Cpp2ILInjected.Token(Token = "0x6001464")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAF2D4", Offset = "0x1CAF2D4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallback), Member = "get_ReplacementFallback", ReturnType = typeof(EncoderFallback))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallback), Member = "get_ReplacementFallback", ReturnType = typeof(DecoderFallback))]
		internal override void SetDefaultFallbacks()
		{
			throw null;
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x00017969 File Offset: 0x00015B69
		[global::Cpp2ILInjected.Token(Token = "0x6001465")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAF41C", Offset = "0x1CAF41C", Length = "0x178")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public override int GetByteCount(char[] chars, int index, int count)
		{
			throw null;
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x0001796C File Offset: 0x00015B6C
		[global::Cpp2ILInjected.Token(Token = "0x6001466")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAF594", Offset = "0x1CAF594", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override int GetByteCount(string chars)
		{
			throw null;
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x0001796F File Offset: 0x00015B6F
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001467")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAF620", Offset = "0x1CAF620", Length = "0xD0")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public unsafe override int GetByteCount(char* chars, int count)
		{
			throw null;
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00017972 File Offset: 0x00015B72
		[global::Cpp2ILInjected.Token(Token = "0x6001468")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAF6F0", Offset = "0x1CAF6F0", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "GetReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = "T&")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			throw null;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00017975 File Offset: 0x00015B75
		[global::Cpp2ILInjected.Token(Token = "0x6001469")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAF938", Offset = "0x1CAF938", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "GetReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = "T&")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			throw null;
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00017978 File Offset: 0x00015B78
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600146A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAFB9C", Offset = "0x1CAFB9C", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
		{
			throw null;
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x0001797B File Offset: 0x00015B7B
		[global::Cpp2ILInjected.Token(Token = "0x600146B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAFC94", Offset = "0x1CAFC94", Length = "0x178")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			throw null;
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x0001797E File Offset: 0x00015B7E
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600146C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAFE0C", Offset = "0x1CAFE0C", Length = "0xD0")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public unsafe override int GetCharCount(byte* bytes, int count)
		{
			throw null;
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00017981 File Offset: 0x00015B81
		[global::Cpp2ILInjected.Token(Token = "0x600146D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAFEDC", Offset = "0x1CAFEDC", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = "T&")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			throw null;
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00017984 File Offset: 0x00015B84
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600146E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB0140", Offset = "0x1CB0140", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
		{
			throw null;
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00017987 File Offset: 0x00015B87
		[global::Cpp2ILInjected.Token(Token = "0x600146F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB0238", Offset = "0x1CB0238", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateStringFromEncoding", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int),
			typeof(Encoding)
		}, ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public unsafe override string GetString(byte[] bytes, int byteIndex, int byteCount)
		{
			throw null;
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x0001798A File Offset: 0x00015B8A
		[global::Cpp2ILInjected.Token(Token = "0x6001470")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB03F4", Offset = "0x1CB03F4", Length = "0x2C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal unsafe override int GetByteCount(char* chars, int charCount, EncoderNLS encoder)
		{
			throw null;
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x0001798D File Offset: 0x00015B8D
		[global::Cpp2ILInjected.Token(Token = "0x6001471")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB0750", Offset = "0x1CB0750", Length = "0x400")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new object[]
		{
			typeof(EncoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
		{
			throw null;
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00017990 File Offset: 0x00015B90
		[global::Cpp2ILInjected.Token(Token = "0x6001472")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB0B50", Offset = "0x1CB0B50", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS decoder)
		{
			throw null;
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x00017993 File Offset: 0x00015B93
		[global::Cpp2ILInjected.Token(Token = "0x6001473")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB0CC0", Offset = "0x1CB0CC0", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "ThrowCharsOverflow", MemberParameters = new object[]
		{
			typeof(DecoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder)
		{
			throw null;
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x00017996 File Offset: 0x00015B96
		[global::Cpp2ILInjected.Token(Token = "0x6001474")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB0F38", Offset = "0x1CB0F38", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override int GetMaxByteCount(int charCount)
		{
			throw null;
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x00017999 File Offset: 0x00015B99
		[global::Cpp2ILInjected.Token(Token = "0x6001475")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB102C", Offset = "0x1CB102C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override int GetMaxCharCount(int byteCount)
		{
			throw null;
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x0001799C File Offset: 0x00015B9C
		[global::Cpp2ILInjected.Token(Token = "0x6001476")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB111C", Offset = "0x1CB111C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override Decoder GetDecoder()
		{
			throw null;
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x0001799F File Offset: 0x00015B9F
		[global::Cpp2ILInjected.Token(Token = "0x6001477")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB11CC", Offset = "0x1CB11CC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderNLS), Member = ".ctor", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override Encoder GetEncoder()
		{
			throw null;
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x000179A2 File Offset: 0x00015BA2
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001478")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB1228", Offset = "0x1CB1228", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASCIIEncoding.ASCIIEncodingSealed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static ASCIIEncoding()
		{
			throw null;
		}

		// Token: 0x04000877 RID: 2167
		[global::Cpp2ILInjected.Token(Token = "0x4000AE3")]
		internal static readonly ASCIIEncoding.ASCIIEncodingSealed s_default;

		// Token: 0x020005CF RID: 1487
		[global::Cpp2ILInjected.Token(Token = "0x200025D")]
		internal sealed class ASCIIEncodingSealed : ASCIIEncoding
		{
			// Token: 0x06004090 RID: 16528 RVA: 0x0001FC61 File Offset: 0x0001DE61
			[global::Cpp2ILInjected.Token(Token = "0x6001479")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB1294", Offset = "0x1CB1294", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ASCIIEncoding), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public ASCIIEncodingSealed()
			{
				throw null;
			}
		}
	}
}
