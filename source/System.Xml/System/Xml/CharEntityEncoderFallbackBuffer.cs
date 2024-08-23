using System;
using System.Globalization;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200000D RID: 13
	[global::Cpp2ILInjected.Token(Token = "0x200000D")]
	internal class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00003089 File Offset: 0x00001289
		[global::Cpp2ILInjected.Token(Token = "0x6000023")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5D6DC", Offset = "0x1D5D6DC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharEntityEncoderFallback), Member = "CreateFallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal CharEntityEncoderFallbackBuffer(CharEntityEncoderFallback parent)
		{
			throw null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000308C File Offset: 0x0000128C
		[global::Cpp2ILInjected.Token(Token = "0x6000024")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5D7B0", Offset = "0x1D5D7B0", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderExceptionFallback), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(IFormatProvider),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public override bool Fallback(char charUnknown, int index)
		{
			throw null;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000308F File Offset: 0x0000128F
		[global::Cpp2ILInjected.Token(Token = "0x6000025")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5D9B0", Offset = "0x1D5D9B0", Length = "0x290")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsSurrogatePair", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderExceptionFallback), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "CombineSurrogateChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(IFormatProvider),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "CreateInvalidSurrogatePairException", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			throw null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003092 File Offset: 0x00001292
		[global::Cpp2ILInjected.Token(Token = "0x6000026")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5DC50", Offset = "0x1D5DC50", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		public override char GetNextChar()
		{
			throw null;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003095 File Offset: 0x00001295
		[global::Cpp2ILInjected.Token(Token = "0x6000027")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5DC94", Offset = "0x1D5DC94", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool MovePrevious()
		{
			throw null;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00003098 File Offset: 0x00001298
		[global::Cpp2ILInjected.Token(Token = "0x17000004")]
		public override int Remaining
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000028")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D5DCB4", Offset = "0x1D5DCB4", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000309B File Offset: 0x0000129B
		[global::Cpp2ILInjected.Token(Token = "0x6000029")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5DCD8", Offset = "0x1D5DCD8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000309E File Offset: 0x0000129E
		[global::Cpp2ILInjected.Token(Token = "0x600002A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5DC40", Offset = "0x1D5DC40", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "CombineSurrogateChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		private int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate)
		{
			throw null;
		}

		// Token: 0x04000020 RID: 32
		[global::Cpp2ILInjected.Token(Token = "0x4000020")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private CharEntityEncoderFallback parent;

		// Token: 0x04000021 RID: 33
		[global::Cpp2ILInjected.Token(Token = "0x4000021")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string charEntity;

		// Token: 0x04000022 RID: 34
		[global::Cpp2ILInjected.Token(Token = "0x4000022")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int charEntityIndex;
	}
}
