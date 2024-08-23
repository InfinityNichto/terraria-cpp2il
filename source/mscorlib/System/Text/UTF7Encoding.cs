using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001F6 RID: 502
	[global::Cpp2ILInjected.Token(Token = "0x200027C")]
	[global::System.Serializable]
	public class UTF7Encoding : Encoding
	{
		// Token: 0x060013ED RID: 5101 RVA: 0x00017CF6 File Offset: 0x00015EF6
		[global::Cpp2ILInjected.Token(Token = "0x60015AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADA3DC", Offset = "0x1ADA3DC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "get_UTF7", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF7Encoding), Member = "MakeTables", ReturnType = typeof(void))]
		public UTF7Encoding()
		{
			throw null;
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x00017CF9 File Offset: 0x00015EF9
		[global::Cpp2ILInjected.Token(Token = "0x60015AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADA400", Offset = "0x1ADA400", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public UTF7Encoding(bool allowOptionals)
		{
			throw null;
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00017CFC File Offset: 0x00015EFC
		[global::Cpp2ILInjected.Token(Token = "0x60015AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADA430", Offset = "0x1ADA430", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void MakeTables()
		{
			throw null;
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x00017CFF File Offset: 0x00015EFF
		[global::Cpp2ILInjected.Token(Token = "0x60015AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADA668", Offset = "0x1ADA668", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderReplacementFallback), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallback), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal override void SetDefaultFallbacks()
		{
			throw null;
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00017D02 File Offset: 0x00015F02
		[global::Cpp2ILInjected.Token(Token = "0x60015AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADA71C", Offset = "0x1ADA71C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object value)
		{
			throw null;
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00017D05 File Offset: 0x00015F05
		[global::Cpp2ILInjected.Token(Token = "0x60015AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADA7DC", Offset = "0x1ADA7DC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x00017D08 File Offset: 0x00015F08
		[global::Cpp2ILInjected.Token(Token = "0x60015B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADA83C", Offset = "0x1ADA83C", Length = "0x178")]
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

		// Token: 0x060013F4 RID: 5108 RVA: 0x00017D0B File Offset: 0x00015F0B
		[global::Cpp2ILInjected.Token(Token = "0x60015B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADA9B4", Offset = "0x1ADA9B4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override int GetByteCount(string s)
		{
			throw null;
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00017D0E File Offset: 0x00015F0E
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60015B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADAA40", Offset = "0x1ADAA40", Length = "0xD0")]
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

		// Token: 0x060013F6 RID: 5110 RVA: 0x00017D11 File Offset: 0x00015F11
		[global::Cpp2ILInjected.Token(Token = "0x60015B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADAB10", Offset = "0x1ADAB10", Length = "0x248")]
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
		public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			throw null;
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x00017D14 File Offset: 0x00015F14
		[global::Cpp2ILInjected.Token(Token = "0x60015B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADAD58", Offset = "0x1ADAD58", Length = "0x264")]
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

		// Token: 0x060013F8 RID: 5112 RVA: 0x00017D17 File Offset: 0x00015F17
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60015B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADAFBC", Offset = "0x1ADAFBC", Length = "0xF8")]
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

		// Token: 0x060013F9 RID: 5113 RVA: 0x00017D1A File Offset: 0x00015F1A
		[global::Cpp2ILInjected.Token(Token = "0x60015B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADB0B4", Offset = "0x1ADB0B4", Length = "0x178")]
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

		// Token: 0x060013FA RID: 5114 RVA: 0x00017D1D File Offset: 0x00015F1D
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60015B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADB22C", Offset = "0x1ADB22C", Length = "0xD0")]
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

		// Token: 0x060013FB RID: 5115 RVA: 0x00017D20 File Offset: 0x00015F20
		[global::Cpp2ILInjected.Token(Token = "0x60015B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADB2FC", Offset = "0x1ADB2FC", Length = "0x264")]
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

		// Token: 0x060013FC RID: 5116 RVA: 0x00017D23 File Offset: 0x00015F23
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60015B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADB560", Offset = "0x1ADB560", Length = "0xF8")]
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

		// Token: 0x060013FD RID: 5117 RVA: 0x00017D26 File Offset: 0x00015F26
		[global::Cpp2ILInjected.Token(Token = "0x60015BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADB658", Offset = "0x1ADB658", Length = "0x1BC")]
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
		public unsafe override string GetString(byte[] bytes, int index, int count)
		{
			throw null;
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00017D29 File Offset: 0x00015F29
		[global::Cpp2ILInjected.Token(Token = "0x60015BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADB814", Offset = "0x1ADB814", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal unsafe override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder)
		{
			throw null;
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00017D2C File Offset: 0x00015F2C
		[global::Cpp2ILInjected.Token(Token = "0x60015BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADB830", Offset = "0x1ADB830", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding.EncodingByteBuffer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Encoding),
			typeof(EncoderNLS),
			typeof(byte*),
			typeof(int),
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding.EncodingByteBuffer), Member = "AddByte", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new object[]
		{
			typeof(EncoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding.EncodingByteBuffer), Member = "get_MoreData", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding.EncodingByteBuffer), Member = "GetNextChar", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding.EncodingByteBuffer), Member = "AddByte", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding.EncodingByteBuffer), Member = "get_CharsUsed", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder)
		{
			throw null;
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00017D2F File Offset: 0x00015F2F
		[global::Cpp2ILInjected.Token(Token = "0x60015BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADBB68", Offset = "0x1ADBB68", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder)
		{
			throw null;
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x00017D32 File Offset: 0x00015F32
		[global::Cpp2ILInjected.Token(Token = "0x60015BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADBB84", Offset = "0x1ADBB84", Length = "0x27C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding.EncodingCharBuffer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Encoding),
			typeof(DecoderNLS),
			typeof(char*),
			typeof(int),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding.EncodingCharBuffer), Member = "AddChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "ThrowCharsOverflow", MemberParameters = new object[]
		{
			typeof(DecoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding.EncodingCharBuffer), Member = "get_MoreData", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding.EncodingCharBuffer), Member = "GetNextByte", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding.EncodingCharBuffer), Member = "Fallback", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding.EncodingCharBuffer), Member = "AdjustBytes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding.EncodingCharBuffer), Member = "get_BytesUsed", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder)
		{
			throw null;
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x00017D35 File Offset: 0x00015F35
		[global::Cpp2ILInjected.Token(Token = "0x60015BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADBE00", Offset = "0x1ADBE00", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderNLS), Member = ".ctor", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override global::System.Text.Decoder GetDecoder()
		{
			throw null;
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x00017D38 File Offset: 0x00015F38
		[global::Cpp2ILInjected.Token(Token = "0x60015C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADBE64", Offset = "0x1ADBE64", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override global::System.Text.Encoder GetEncoder()
		{
			throw null;
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x00017D3B File Offset: 0x00015F3B
		[global::Cpp2ILInjected.Token(Token = "0x60015C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADBF14", Offset = "0x1ADBF14", Length = "0xBC")]
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

		// Token: 0x06001405 RID: 5125 RVA: 0x00017D3E File Offset: 0x00015F3E
		[global::Cpp2ILInjected.Token(Token = "0x60015C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADBFD0", Offset = "0x1ADBFD0", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override int GetMaxCharCount(int byteCount)
		{
			throw null;
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x00017D41 File Offset: 0x00015F41
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60015C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADC044", Offset = "0x1ADC044", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF7Encoding), Member = "MakeTables", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static UTF7Encoding()
		{
			throw null;
		}

		// Token: 0x040008CD RID: 2253
		[global::Cpp2ILInjected.Token(Token = "0x4000B3B")]
		internal static readonly UTF7Encoding s_default;

		// Token: 0x040008CE RID: 2254
		[global::Cpp2ILInjected.Token(Token = "0x4000B3C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private byte[] _base64Bytes;

		// Token: 0x040008CF RID: 2255
		[global::Cpp2ILInjected.Token(Token = "0x4000B3D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private sbyte[] _base64Values;

		// Token: 0x040008D0 RID: 2256
		[global::Cpp2ILInjected.Token(Token = "0x4000B3E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool[] _directEncode;

		// Token: 0x040008D1 RID: 2257
		[global::Cpp2ILInjected.Token(Token = "0x4000B3F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private bool _allowOptionals;

		// Token: 0x020005D1 RID: 1489
		[global::Cpp2ILInjected.Token(Token = "0x200027D")]
		[global::System.Serializable]
		private sealed class Decoder : DecoderNLS
		{
			// Token: 0x06004094 RID: 16532 RVA: 0x0001FC6D File Offset: 0x0001DE6D
			[global::Cpp2ILInjected.Token(Token = "0x60015C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ADBE5C", Offset = "0x1ADBE5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderNLS), Member = ".ctor", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
			public Decoder(UTF7Encoding encoding)
			{
				throw null;
			}

			// Token: 0x06004095 RID: 16533 RVA: 0x0001FC70 File Offset: 0x0001DE70
			[global::Cpp2ILInjected.Token(Token = "0x60015C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ADC0B0", Offset = "0x1ADC0B0", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override void Reset()
			{
				throw null;
			}

			// Token: 0x1700073F RID: 1855
			// (get) Token: 0x06004096 RID: 16534 RVA: 0x0001FC73 File Offset: 0x0001DE73
			[global::Cpp2ILInjected.Token(Token = "0x17000229")]
			internal override bool HasState
			{
				[global::Cpp2ILInjected.Token(Token = "0x60015C6")]
				[global::Cpp2ILInjected.Address(RVA = "0x1ADC0D8", Offset = "0x1ADC0D8", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x040018F6 RID: 6390
			[global::Cpp2ILInjected.Token(Token = "0x4000B40")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal int bits;

			// Token: 0x040018F7 RID: 6391
			[global::Cpp2ILInjected.Token(Token = "0x4000B41")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			internal int bitCount;

			// Token: 0x040018F8 RID: 6392
			[global::Cpp2ILInjected.Token(Token = "0x4000B42")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			internal bool firstByte;
		}

		// Token: 0x020005D2 RID: 1490
		[global::Cpp2ILInjected.Token(Token = "0x200027E")]
		[global::System.Serializable]
		private sealed class Encoder : EncoderNLS
		{
			// Token: 0x06004097 RID: 16535 RVA: 0x0001FC76 File Offset: 0x0001DE76
			[global::Cpp2ILInjected.Token(Token = "0x60015C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ADBED8", Offset = "0x1ADBED8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoder), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public Encoder(UTF7Encoding encoding)
			{
				throw null;
			}

			// Token: 0x06004098 RID: 16536 RVA: 0x0001FC79 File Offset: 0x0001DE79
			[global::Cpp2ILInjected.Token(Token = "0x60015C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ADC0E8", Offset = "0x1ADC0E8", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override void Reset()
			{
				throw null;
			}

			// Token: 0x17000740 RID: 1856
			// (get) Token: 0x06004099 RID: 16537 RVA: 0x0001FC7C File Offset: 0x0001DE7C
			[global::Cpp2ILInjected.Token(Token = "0x1700022A")]
			internal override bool HasState
			{
				[global::Cpp2ILInjected.Token(Token = "0x60015C9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1ADC10C", Offset = "0x1ADC10C", Length = "0x20")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x040018F9 RID: 6393
			[global::Cpp2ILInjected.Token(Token = "0x4000B43")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			internal int bits;

			// Token: 0x040018FA RID: 6394
			[global::Cpp2ILInjected.Token(Token = "0x4000B44")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
			internal int bitCount;
		}

		// Token: 0x020005D3 RID: 1491
		[global::Cpp2ILInjected.Token(Token = "0x200027F")]
		[global::System.Serializable]
		private sealed class DecoderUTF7Fallback : DecoderFallback
		{
			// Token: 0x0600409A RID: 16538 RVA: 0x0001FC7F File Offset: 0x0001DE7F
			[global::Cpp2ILInjected.Token(Token = "0x60015CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ADA714", Offset = "0x1ADA714", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallback), Member = ".ctor", ReturnType = typeof(void))]
			public DecoderUTF7Fallback()
			{
				throw null;
			}

			// Token: 0x0600409B RID: 16539 RVA: 0x0001FC82 File Offset: 0x0001DE82
			[global::Cpp2ILInjected.Token(Token = "0x60015CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ADC12C", Offset = "0x1ADC12C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallbackBuffer), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override DecoderFallbackBuffer CreateFallbackBuffer()
			{
				throw null;
			}

			// Token: 0x17000741 RID: 1857
			// (get) Token: 0x0600409C RID: 16540 RVA: 0x0001FC85 File Offset: 0x0001DE85
			[global::Cpp2ILInjected.Token(Token = "0x1700022B")]
			public override int MaxCharCount
			{
				[global::Cpp2ILInjected.Token(Token = "0x60015CC")]
				[global::Cpp2ILInjected.Address(RVA = "0x1ADC198", Offset = "0x1ADC198", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600409D RID: 16541 RVA: 0x0001FC88 File Offset: 0x0001DE88
			[global::Cpp2ILInjected.Token(Token = "0x60015CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ADC1A0", Offset = "0x1ADC1A0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override bool Equals(object value)
			{
				throw null;
			}

			// Token: 0x0600409E RID: 16542 RVA: 0x0001FC8B File Offset: 0x0001DE8B
			[global::Cpp2ILInjected.Token(Token = "0x60015CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ADC1FC", Offset = "0x1ADC1FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int GetHashCode()
			{
				throw null;
			}
		}

		// Token: 0x020005D4 RID: 1492
		[global::Cpp2ILInjected.Token(Token = "0x2000280")]
		private sealed class DecoderUTF7FallbackBuffer : DecoderFallbackBuffer
		{
			// Token: 0x0600409F RID: 16543 RVA: 0x0001FC8E File Offset: 0x0001DE8E
			[global::Cpp2ILInjected.Token(Token = "0x60015CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ADC188", Offset = "0x1ADC188", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallbackBuffer), Member = ".ctor", ReturnType = typeof(void))]
			public DecoderUTF7FallbackBuffer(UTF7Encoding.DecoderUTF7Fallback fallback)
			{
				throw null;
			}

			// Token: 0x060040A0 RID: 16544 RVA: 0x0001FC91 File Offset: 0x0001DE91
			[global::Cpp2ILInjected.Token(Token = "0x60015D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ADC204", Offset = "0x1ADC204", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool Fallback(byte[] bytesUnknown, int index)
			{
				throw null;
			}

			// Token: 0x060040A1 RID: 16545 RVA: 0x0001FC94 File Offset: 0x0001DE94
			[global::Cpp2ILInjected.Token(Token = "0x60015D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ADC228", Offset = "0x1ADC228", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override char GetNextChar()
			{
				throw null;
			}

			// Token: 0x17000742 RID: 1858
			// (get) Token: 0x060040A2 RID: 16546 RVA: 0x0001FC97 File Offset: 0x0001DE97
			[global::Cpp2ILInjected.Token(Token = "0x1700022C")]
			public override int Remaining
			{
				[global::Cpp2ILInjected.Token(Token = "0x60015D2")]
				[global::Cpp2ILInjected.Address(RVA = "0x1ADC248", Offset = "0x1ADC248", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060040A3 RID: 16547 RVA: 0x0001FC9A File Offset: 0x0001DE9A
			[global::Cpp2ILInjected.Token(Token = "0x60015D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ADC254", Offset = "0x1ADC254", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void Reset()
			{
				throw null;
			}

			// Token: 0x060040A4 RID: 16548 RVA: 0x0001FC9D File Offset: 0x0001DE9D
			[global::Cpp2ILInjected.Token(Token = "0x60015D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ADC264", Offset = "0x1ADC264", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal unsafe override int InternalFallback(byte[] bytes, byte* pBytes)
			{
				throw null;
			}

			// Token: 0x040018FB RID: 6395
			[global::Cpp2ILInjected.Token(Token = "0x4000B45")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private char cFallback;

			// Token: 0x040018FC RID: 6396
			[global::Cpp2ILInjected.Token(Token = "0x4000B46")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private int iCount;

			// Token: 0x040018FD RID: 6397
			[global::Cpp2ILInjected.Token(Token = "0x4000B47")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private int iSize;
		}
	}
}
