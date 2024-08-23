using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001E0 RID: 480
	[global::Cpp2ILInjected.Token(Token = "0x2000265")]
	public abstract class DecoderFallbackBuffer
	{
		// Token: 0x060012ED RID: 4845
		[global::Cpp2ILInjected.Token(Token = "0x60014A7")]
		public abstract bool Fallback(byte[] bytesUnknown, int index);

		// Token: 0x060012EE RID: 4846
		[global::Cpp2ILInjected.Token(Token = "0x60014A8")]
		public abstract char GetNextChar();

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060012EF RID: 4847
		[global::Cpp2ILInjected.Token(Token = "0x1700020A")]
		public abstract int Remaining
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014A9")]
			get;
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00017A20 File Offset: 0x00015C20
		[global::Cpp2ILInjected.Token(Token = "0x60014AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB257C", Offset = "0x1CB257C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Reset()
		{
			throw null;
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00017A23 File Offset: 0x00015C23
		[global::Cpp2ILInjected.Token(Token = "0x60014AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB0F28", Offset = "0x1CB0F28", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF32Encoding), Member = "GetChars", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int),
			typeof(char*),
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnicodeEncoding), Member = "GetChars", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int),
			typeof(char*),
			typeof(int),
			typeof(DecoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding.EncodingCharBuffer), Member = "Fallback", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "ThrowCharsOverflow", MemberParameters = new object[]
		{
			typeof(DecoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal unsafe void InternalReset()
		{
			throw null;
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00017A26 File Offset: 0x00015C26
		[global::Cpp2ILInjected.Token(Token = "0x60014AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB0CB8", Offset = "0x1CB0CB8", Length = "0x8")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		internal unsafe void InternalInitialize(byte* byteStart, char* charEnd)
		{
			throw null;
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x00017A29 File Offset: 0x00015C29
		[global::Cpp2ILInjected.Token(Token = "0x60014AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB25A4", Offset = "0x1CB25A4", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal unsafe virtual bool InternalFallback(byte[] bytes, byte* pBytes, ref char* chars)
		{
			throw null;
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x00017A2C File Offset: 0x00015C2C
		[global::Cpp2ILInjected.Token(Token = "0x60014AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB2728", Offset = "0x1CB2728", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal unsafe virtual int InternalFallback(byte[] bytes, byte* pBytes)
		{
			throw null;
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00017A2F File Offset: 0x00015C2F
		[global::Cpp2ILInjected.Token(Token = "0x60014AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB288C", Offset = "0x1CB288C", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DecoderReplacementFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal void ThrowLastBytesRecursive(byte[] bytesUnknown)
		{
			throw null;
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x00017A32 File Offset: 0x00015C32
		[global::Cpp2ILInjected.Token(Token = "0x60014B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB1FD8", Offset = "0x1CB1FD8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.UTF7Encoding.DecoderUTF7Fallback", Member = "CreateFallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.UTF7Encoding.DecoderUTF7FallbackBuffer", Member = ".ctor", MemberParameters = new object[] { "System.Text.UTF7Encoding.DecoderUTF7Fallback" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected DecoderFallbackBuffer()
		{
			throw null;
		}

		// Token: 0x04000886 RID: 2182
		[global::Cpp2ILInjected.Token(Token = "0x4000AF2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal unsafe byte* byteStart;

		// Token: 0x04000887 RID: 2183
		[global::Cpp2ILInjected.Token(Token = "0x4000AF3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal unsafe char* charEnd;
	}
}
