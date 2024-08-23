using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001F8 RID: 504
	[global::Cpp2ILInjected.Token(Token = "0x2000285")]
	[global::System.Serializable]
	public class UnicodeEncoding : Encoding
	{
		// Token: 0x06001429 RID: 5161 RVA: 0x00017DAA File Offset: 0x00015FAA
		[global::Cpp2ILInjected.Token(Token = "0x60015FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADF8CC", Offset = "0x1ADF8CC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Player_OldConsole", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Player_OldSwitch", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public UnicodeEncoding()
		{
			throw null;
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x00017DAD File Offset: 0x00015FAD
		[global::Cpp2ILInjected.Token(Token = "0x6001600")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADF900", Offset = "0x1ADF900", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "get_BigEndianUnicode", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.StringWriter), Member = "get_Encoding", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public UnicodeEncoding(bool bigEndian, bool byteOrderMark)
		{
			throw null;
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x00017DB0 File Offset: 0x00015FB0
		[global::Cpp2ILInjected.Token(Token = "0x6001601")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADF948", Offset = "0x1ADF948", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.TextAsset.EncodingUtility", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public UnicodeEncoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes)
		{
			throw null;
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00017DB3 File Offset: 0x00015FB3
		[global::Cpp2ILInjected.Token(Token = "0x6001602")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADF9C0", Offset = "0x1ADF9C0", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallback), Member = "get_ExceptionFallback", ReturnType = typeof(EncoderFallback))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallback), Member = "get_ExceptionFallback", ReturnType = typeof(DecoderFallback))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderReplacementFallback), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderReplacementFallback), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal override void SetDefaultFallbacks()
		{
			throw null;
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00017DB6 File Offset: 0x00015FB6
		[global::Cpp2ILInjected.Token(Token = "0x6001603")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADFA88", Offset = "0x1ADFA88", Length = "0x178")]
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

		// Token: 0x0600142E RID: 5166 RVA: 0x00017DB9 File Offset: 0x00015FB9
		[global::Cpp2ILInjected.Token(Token = "0x6001604")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADFC00", Offset = "0x1ADFC00", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override int GetByteCount(string s)
		{
			throw null;
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x00017DBC File Offset: 0x00015FBC
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001605")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADFC8C", Offset = "0x1ADFC8C", Length = "0xD0")]
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

		// Token: 0x06001430 RID: 5168 RVA: 0x00017DBF File Offset: 0x00015FBF
		[global::Cpp2ILInjected.Token(Token = "0x6001606")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADFD5C", Offset = "0x1ADFD5C", Length = "0x248")]
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

		// Token: 0x06001431 RID: 5169 RVA: 0x00017DC2 File Offset: 0x00015FC2
		[global::Cpp2ILInjected.Token(Token = "0x6001607")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADFFA4", Offset = "0x1ADFFA4", Length = "0x264")]
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

		// Token: 0x06001432 RID: 5170 RVA: 0x00017DC5 File Offset: 0x00015FC5
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001608")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE0208", Offset = "0x1AE0208", Length = "0xF8")]
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

		// Token: 0x06001433 RID: 5171 RVA: 0x00017DC8 File Offset: 0x00015FC8
		[global::Cpp2ILInjected.Token(Token = "0x6001609")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE0300", Offset = "0x1AE0300", Length = "0x178")]
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

		// Token: 0x06001434 RID: 5172 RVA: 0x00017DCB File Offset: 0x00015FCB
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600160A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE0478", Offset = "0x1AE0478", Length = "0xD0")]
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

		// Token: 0x06001435 RID: 5173 RVA: 0x00017DCE File Offset: 0x00015FCE
		[global::Cpp2ILInjected.Token(Token = "0x600160B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE0548", Offset = "0x1AE0548", Length = "0x264")]
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

		// Token: 0x06001436 RID: 5174 RVA: 0x00017DD1 File Offset: 0x00015FD1
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600160C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE07AC", Offset = "0x1AE07AC", Length = "0xF8")]
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

		// Token: 0x06001437 RID: 5175 RVA: 0x00017DD4 File Offset: 0x00015FD4
		[global::Cpp2ILInjected.Token(Token = "0x600160D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE08A4", Offset = "0x1AE08A4", Length = "0x1BC")]
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

		// Token: 0x06001438 RID: 5176 RVA: 0x00017DD7 File Offset: 0x00015FD7
		[global::Cpp2ILInjected.Token(Token = "0x600160E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE0A60", Offset = "0x1AE0A60", Length = "0x514")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = "get_InternalHasFallbackBuffer", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(EncoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalGetNextChar", ReturnType = typeof(char))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal unsafe override int GetByteCount(char* chars, int count, EncoderNLS encoder)
		{
			throw null;
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00017DDA File Offset: 0x00015FDA
		[global::Cpp2ILInjected.Token(Token = "0x600160F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE0F74", Offset = "0x1AE0F74", Length = "0x708")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = "get_InternalHasFallbackBuffer", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(EncoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalGetNextChar", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new object[]
		{
			typeof(EncoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
		{
			throw null;
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00017DDD File Offset: 0x00015FDD
		[global::Cpp2ILInjected.Token(Token = "0x6001610")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE167C", Offset = "0x1AE167C", Length = "0x620")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder)
		{
			throw null;
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x00017DE0 File Offset: 0x00015FE0
		[global::Cpp2ILInjected.Token(Token = "0x6001611")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE1C9C", Offset = "0x1AE1C9C", Length = "0x820")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalReset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "ThrowCharsOverflow", MemberParameters = new object[]
		{
			typeof(DecoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder)
		{
			throw null;
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x00017DE3 File Offset: 0x00015FE3
		[global::Cpp2ILInjected.Token(Token = "0x6001612")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE24BC", Offset = "0x1AE24BC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override Encoder GetEncoder()
		{
			throw null;
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x00017DE6 File Offset: 0x00015FE6
		[global::Cpp2ILInjected.Token(Token = "0x6001613")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE2530", Offset = "0x1AE2530", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnicodeEncoding.Decoder), Member = ".ctor", MemberParameters = new object[] { typeof(UnicodeEncoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override global::System.Text.Decoder GetDecoder()
		{
			throw null;
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00017DE9 File Offset: 0x00015FE9
		[global::Cpp2ILInjected.Token(Token = "0x6001614")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE258C", Offset = "0x1AE258C", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override byte[] GetPreamble()
		{
			throw null;
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600143F RID: 5183 RVA: 0x00017DEC File Offset: 0x00015FEC
		[global::Cpp2ILInjected.Token(Token = "0x17000231")]
		public override global::System.ReadOnlySpan<byte> Preamble
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001615")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE2650", Offset = "0x1AE2650", Length = "0x170")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.ReadOnlySpan`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x00017DEF File Offset: 0x00015FEF
		[global::Cpp2ILInjected.Token(Token = "0x6001616")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE27C0", Offset = "0x1AE27C0", Length = "0xF4")]
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

		// Token: 0x06001441 RID: 5185 RVA: 0x00017DF2 File Offset: 0x00015FF2
		[global::Cpp2ILInjected.Token(Token = "0x6001617")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE28B4", Offset = "0x1AE28B4", Length = "0xF8")]
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

		// Token: 0x06001442 RID: 5186 RVA: 0x00017DF5 File Offset: 0x00015FF5
		[global::Cpp2ILInjected.Token(Token = "0x6001618")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE29AC", Offset = "0x1AE29AC", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object value)
		{
			throw null;
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x00017DF8 File Offset: 0x00015FF8
		[global::Cpp2ILInjected.Token(Token = "0x6001619")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE2AB0", Offset = "0x1AE2AB0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x00017DFB File Offset: 0x00015FFB
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600161A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE2B20", Offset = "0x1AE2B20", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static UnicodeEncoding()
		{
			throw null;
		}

		// Token: 0x040008D6 RID: 2262
		[global::Cpp2ILInjected.Token(Token = "0x4000B4E")]
		internal static readonly UnicodeEncoding s_bigEndianDefault;

		// Token: 0x040008D7 RID: 2263
		[global::Cpp2ILInjected.Token(Token = "0x4000B4F")]
		internal static readonly UnicodeEncoding s_littleEndianDefault;

		// Token: 0x040008D8 RID: 2264
		[global::Cpp2ILInjected.Token(Token = "0x4000B50")]
		private static readonly byte[] s_bigEndianPreamble;

		// Token: 0x040008D9 RID: 2265
		[global::Cpp2ILInjected.Token(Token = "0x4000B51")]
		private static readonly byte[] s_littleEndianPreamble;

		// Token: 0x040008DA RID: 2266
		[global::Cpp2ILInjected.Token(Token = "0x4000B52")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal bool isThrowException;

		// Token: 0x040008DB RID: 2267
		[global::Cpp2ILInjected.Token(Token = "0x4000B53")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x39")]
		internal bool bigEndian;

		// Token: 0x040008DC RID: 2268
		[global::Cpp2ILInjected.Token(Token = "0x4000B54")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3A")]
		internal bool byteOrderMark;

		// Token: 0x040008DD RID: 2269
		[global::Cpp2ILInjected.Token(Token = "0x4000B55")]
		private static readonly ulong highLowPatternMask;

		// Token: 0x020005D8 RID: 1496
		[global::Cpp2ILInjected.Token(Token = "0x2000286")]
		[global::System.Serializable]
		private sealed class Decoder : DecoderNLS
		{
			// Token: 0x060040AD RID: 16557 RVA: 0x0001FCB8 File Offset: 0x0001DEB8
			[global::Cpp2ILInjected.Token(Token = "0x600161B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE2C84", Offset = "0x1AE2C84", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnicodeEncoding), Member = "GetDecoder", ReturnType = typeof(global::System.Text.Decoder))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderNLS), Member = ".ctor", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
			public Decoder(UnicodeEncoding encoding)
			{
				throw null;
			}

			// Token: 0x060040AE RID: 16558 RVA: 0x0001FCBB File Offset: 0x0001DEBB
			[global::Cpp2ILInjected.Token(Token = "0x600161C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE2C94", Offset = "0x1AE2C94", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override void Reset()
			{
				throw null;
			}

			// Token: 0x17000746 RID: 1862
			// (get) Token: 0x060040AF RID: 16559 RVA: 0x0001FCBE File Offset: 0x0001DEBE
			[global::Cpp2ILInjected.Token(Token = "0x17000232")]
			internal override bool HasState
			{
				[global::Cpp2ILInjected.Token(Token = "0x600161D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1AE2CBC", Offset = "0x1AE2CBC", Length = "0x24")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x04001900 RID: 6400
			[global::Cpp2ILInjected.Token(Token = "0x4000B56")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal int lastByte;

			// Token: 0x04001901 RID: 6401
			[global::Cpp2ILInjected.Token(Token = "0x4000B57")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			internal char lastChar;
		}
	}
}
