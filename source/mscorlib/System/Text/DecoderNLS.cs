using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001E1 RID: 481
	[global::Cpp2ILInjected.Token(Token = "0x2000266")]
	internal class DecoderNLS : Decoder
	{
		// Token: 0x060012F7 RID: 4855 RVA: 0x00017A35 File Offset: 0x00015C35
		[global::Cpp2ILInjected.Token(Token = "0x60014B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB1190", Offset = "0x1CB1190", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncodingNLS), Member = "GetDecoder", ReturnType = typeof(Decoder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.UTF32Encoding.UTF32Decoder", Member = ".ctor", MemberParameters = new object[] { typeof(UTF32Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF32Encoding), Member = "GetDecoder", ReturnType = typeof(Decoder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.UTF7Encoding.Decoder", Member = ".ctor", MemberParameters = new object[] { typeof(UTF7Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = "GetDecoder", ReturnType = typeof(Decoder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.UTF8Encoding.UTF8Decoder", Member = ".ctor", MemberParameters = new object[] { typeof(UTF8Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = "GetDecoder", ReturnType = typeof(Decoder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.UnicodeEncoding.Decoder", Member = ".ctor", MemberParameters = new object[] { typeof(UnicodeEncoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal DecoderNLS(Encoding encoding)
		{
			throw null;
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00017A38 File Offset: 0x00015C38
		[global::Cpp2ILInjected.Token(Token = "0x60014B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB2A60", Offset = "0x1CB2A60", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00017A3B File Offset: 0x00015C3B
		[global::Cpp2ILInjected.Token(Token = "0x60014B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB2A78", Offset = "0x1CB2A78", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			throw null;
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x00017A3E File Offset: 0x00015C3E
		[global::Cpp2ILInjected.Token(Token = "0x60014B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB2A88", Offset = "0x1CB2A88", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "GetReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = "T&")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public override int GetCharCount(byte[] bytes, int index, int count, bool flush)
		{
			throw null;
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00017A41 File Offset: 0x00015C41
		[global::Cpp2ILInjected.Token(Token = "0x60014B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB2C54", Offset = "0x1CB2C54", Length = "0xE8")]
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
		public unsafe override int GetCharCount(byte* bytes, int count, bool flush)
		{
			throw null;
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x00017A44 File Offset: 0x00015C44
		[global::Cpp2ILInjected.Token(Token = "0x60014B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB2D3C", Offset = "0x1CB2D3C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			throw null;
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x00017A47 File Offset: 0x00015C47
		[global::Cpp2ILInjected.Token(Token = "0x60014B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB2D4C", Offset = "0x1CB2D4C", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "GetReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = "T&")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
		{
			throw null;
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x00017A4A File Offset: 0x00015C4A
		[global::Cpp2ILInjected.Token(Token = "0x60014B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB2FCC", Offset = "0x1CB2FCC", Length = "0x110")]
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
		public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
		{
			throw null;
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00017A4D File Offset: 0x00015C4D
		[global::Cpp2ILInjected.Token(Token = "0x60014B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB30DC", Offset = "0x1CB30DC", Length = "0x2B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "GetReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = "T&")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			throw null;
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x00017A50 File Offset: 0x00015C50
		[global::Cpp2ILInjected.Token(Token = "0x60014BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB3394", Offset = "0x1CB3394", Length = "0x1A0")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public unsafe override void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			throw null;
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x00017A53 File Offset: 0x00015C53
		[global::Cpp2ILInjected.Token(Token = "0x1700020B")]
		public bool MustFlush
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB3534", Offset = "0x1CB3534", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x00017A56 File Offset: 0x00015C56
		[global::Cpp2ILInjected.Token(Token = "0x1700020C")]
		internal virtual bool HasState
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB353C", Offset = "0x1CB353C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x00017A59 File Offset: 0x00015C59
		[global::Cpp2ILInjected.Token(Token = "0x60014BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB3544", Offset = "0x1CB3544", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "ThrowCharsOverflow", MemberParameters = new object[]
		{
			typeof(DecoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void ClearMustFlush()
		{
			throw null;
		}

		// Token: 0x04000888 RID: 2184
		[global::Cpp2ILInjected.Token(Token = "0x4000AF4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Encoding _encoding;

		// Token: 0x04000889 RID: 2185
		[global::Cpp2ILInjected.Token(Token = "0x4000AF5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _mustFlush;

		// Token: 0x0400088A RID: 2186
		[global::Cpp2ILInjected.Token(Token = "0x4000AF6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		internal bool _throwOnOverflow;

		// Token: 0x0400088B RID: 2187
		[global::Cpp2ILInjected.Token(Token = "0x4000AF7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		internal int _bytesUsed;
	}
}
