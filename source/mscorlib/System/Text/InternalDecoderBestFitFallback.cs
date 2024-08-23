using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001DA RID: 474
	[global::Cpp2ILInjected.Token(Token = "0x200025F")]
	[global::System.Serializable]
	internal sealed class InternalDecoderBestFitFallback : DecoderFallback
	{
		// Token: 0x060012CE RID: 4814 RVA: 0x000179C9 File Offset: 0x00015BC9
		[global::Cpp2ILInjected.Token(Token = "0x6001488")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB1CF8", Offset = "0x1CB1CF8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal InternalDecoderBestFitFallback(Encoding encoding)
		{
			throw null;
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x000179CC File Offset: 0x00015BCC
		[global::Cpp2ILInjected.Token(Token = "0x6001489")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB1D30", Offset = "0x1CB1D30", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalDecoderBestFitFallbackBuffer), Member = ".ctor", MemberParameters = new object[] { typeof(InternalDecoderBestFitFallback) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override DecoderFallbackBuffer CreateFallbackBuffer()
		{
			throw null;
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060012D0 RID: 4816 RVA: 0x000179CF File Offset: 0x00015BCF
		[global::Cpp2ILInjected.Token(Token = "0x17000202")]
		public override int MaxCharCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x600148A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB1E90", Offset = "0x1CB1E90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x000179D2 File Offset: 0x00015BD2
		[global::Cpp2ILInjected.Token(Token = "0x600148B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB1E98", Offset = "0x1CB1E98", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object value)
		{
			throw null;
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x000179D5 File Offset: 0x00015BD5
		[global::Cpp2ILInjected.Token(Token = "0x600148C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB1F30", Offset = "0x1CB1F30", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0400087A RID: 2170
		[global::Cpp2ILInjected.Token(Token = "0x4000AE6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal Encoding _encoding;

		// Token: 0x0400087B RID: 2171
		[global::Cpp2ILInjected.Token(Token = "0x4000AE7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal char[] _arrayBestFit;

		// Token: 0x0400087C RID: 2172
		[global::Cpp2ILInjected.Token(Token = "0x4000AE8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal char _cReplacement;
	}
}
