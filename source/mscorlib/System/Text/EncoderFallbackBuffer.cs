using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001EB RID: 491
	[global::Cpp2ILInjected.Token(Token = "0x2000270")]
	public abstract class EncoderFallbackBuffer
	{
		// Token: 0x06001340 RID: 4928
		[global::Cpp2ILInjected.Token(Token = "0x60014FA")]
		public abstract bool Fallback(char charUnknown, int index);

		// Token: 0x06001341 RID: 4929
		[global::Cpp2ILInjected.Token(Token = "0x60014FB")]
		public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index);

		// Token: 0x06001342 RID: 4930
		[global::Cpp2ILInjected.Token(Token = "0x60014FC")]
		public abstract char GetNextChar();

		// Token: 0x06001343 RID: 4931
		[global::Cpp2ILInjected.Token(Token = "0x60014FD")]
		public abstract bool MovePrevious();

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06001344 RID: 4932
		[global::Cpp2ILInjected.Token(Token = "0x1700021B")]
		public abstract int Remaining
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014FE")]
			get;
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00017B04 File Offset: 0x00015D04
		[global::Cpp2ILInjected.Token(Token = "0x60014FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB5050", Offset = "0x1CB5050", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Reset()
		{
			throw null;
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00017B07 File Offset: 0x00015D07
		[global::Cpp2ILInjected.Token(Token = "0x6001500")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB5078", Offset = "0x1CB5078", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Latin1Encoding), Member = "GetBytes", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(byte*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new object[]
		{
			typeof(EncoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal unsafe void InternalReset()
		{
			throw null;
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00017B0A File Offset: 0x00015D0A
		[global::Cpp2ILInjected.Token(Token = "0x6001501")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB0700", Offset = "0x1CB0700", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Latin1Encoding), Member = "GetByteCount", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Latin1Encoding), Member = "GetBytes", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(byte*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF32Encoding), Member = "GetByteCount", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF32Encoding), Member = "GetBytes", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(byte*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = "GetByteCount", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = "GetBytes", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(byte*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnicodeEncoding), Member = "GetByteCount", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnicodeEncoding), Member = "GetBytes", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(byte*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding.EncodingByteBuffer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Encoding),
			typeof(EncoderNLS),
			typeof(byte*),
			typeof(int),
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		internal unsafe void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder)
		{
			throw null;
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x00017B0D File Offset: 0x00015D0D
		[global::Cpp2ILInjected.Token(Token = "0x6001502")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB071C", Offset = "0x1CB071C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Latin1Encoding), Member = "GetByteCount", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Latin1Encoding), Member = "GetBytes", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(byte*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF32Encoding), Member = "GetByteCount", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF32Encoding), Member = "GetBytes", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(byte*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = "GetByteCount", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = "GetBytes", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(byte*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnicodeEncoding), Member = "GetByteCount", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnicodeEncoding), Member = "GetBytes", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(byte*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding.EncodingByteBuffer), Member = "GetNextChar", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		internal unsafe char InternalGetNextChar()
		{
			throw null;
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x00017B10 File Offset: 0x00015D10
		[global::Cpp2ILInjected.Token(Token = "0x6001503")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB5090", Offset = "0x1CB5090", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsLowSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "ThrowLastCharRecursive", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ConvertToUtf32", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal unsafe virtual bool InternalFallback(char ch, ref char* chars)
		{
			throw null;
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x00017B13 File Offset: 0x00015D13
		[global::Cpp2ILInjected.Token(Token = "0x6001504")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB5238", Offset = "0x1CB5238", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncoderFallbackBuffer), Member = "InternalFallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(ref char*)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncoderReplacementFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncoderReplacementFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal unsafe void ThrowLastCharRecursive(int charRecursive)
		{
			throw null;
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x00017B16 File Offset: 0x00015D16
		[global::Cpp2ILInjected.Token(Token = "0x6001505")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB4620", Offset = "0x1CB4620", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncoderReplacementFallback), Member = "CreateFallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncoderReplacementFallbackBuffer), Member = ".ctor", MemberParameters = new object[] { typeof(EncoderReplacementFallback) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.CharEntityEncoderFallbackBuffer", Member = ".ctor", MemberParameters = new object[] { "System.Xml.CharEntityEncoderFallback" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected EncoderFallbackBuffer()
		{
			throw null;
		}

		// Token: 0x0400089F RID: 2207
		[global::Cpp2ILInjected.Token(Token = "0x4000B0B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal unsafe char* charStart;

		// Token: 0x040008A0 RID: 2208
		[global::Cpp2ILInjected.Token(Token = "0x4000B0C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal unsafe char* charEnd;

		// Token: 0x040008A1 RID: 2209
		[global::Cpp2ILInjected.Token(Token = "0x4000B0D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal EncoderNLS encoder;

		// Token: 0x040008A2 RID: 2210
		[global::Cpp2ILInjected.Token(Token = "0x4000B0E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal bool setEncoder;

		// Token: 0x040008A3 RID: 2211
		[global::Cpp2ILInjected.Token(Token = "0x4000B0F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		internal bool bUsedEncoder;

		// Token: 0x040008A4 RID: 2212
		[global::Cpp2ILInjected.Token(Token = "0x4000B10")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
		internal bool bFallingBack;

		// Token: 0x040008A5 RID: 2213
		[global::Cpp2ILInjected.Token(Token = "0x4000B11")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		internal int iRecursionCount;
	}
}
