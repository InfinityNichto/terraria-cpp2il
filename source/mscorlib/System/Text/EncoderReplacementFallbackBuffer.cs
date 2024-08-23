using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001EE RID: 494
	[global::Cpp2ILInjected.Token(Token = "0x2000273")]
	public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x06001361 RID: 4961 RVA: 0x00017B58 File Offset: 0x00015D58
		[global::Cpp2ILInjected.Token(Token = "0x600151B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD1A00", Offset = "0x1AD1A00", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		public EncoderReplacementFallbackBuffer(EncoderReplacementFallback fallback)
		{
			throw null;
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00017B5B File Offset: 0x00015D5B
		[global::Cpp2ILInjected.Token(Token = "0x600151C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD1AD0", Offset = "0x1AD1AD0", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsLowSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ConvertToUtf32", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "ThrowLastCharRecursive", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Fallback(char charUnknown, int index)
		{
			throw null;
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00017B5E File Offset: 0x00015D5E
		[global::Cpp2ILInjected.Token(Token = "0x600151D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD1C10", Offset = "0x1AD1C10", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsLowSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ConvertToUtf32", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "ThrowLastCharRecursive", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			throw null;
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00017B61 File Offset: 0x00015D61
		[global::Cpp2ILInjected.Token(Token = "0x600151E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD1E28", Offset = "0x1AD1E28", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		public override char GetNextChar()
		{
			throw null;
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x00017B64 File Offset: 0x00015D64
		[global::Cpp2ILInjected.Token(Token = "0x600151F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD1E64", Offset = "0x1AD1E64", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool MovePrevious()
		{
			throw null;
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x00017B67 File Offset: 0x00015D67
		[global::Cpp2ILInjected.Token(Token = "0x17000221")]
		public override int Remaining
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001520")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AD1E94", Offset = "0x1AD1E94", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x00017B6A File Offset: 0x00015D6A
		[global::Cpp2ILInjected.Token(Token = "0x6001521")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD1EA0", Offset = "0x1AD1EA0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x040008AC RID: 2220
		[global::Cpp2ILInjected.Token(Token = "0x4000B18")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string _strDefault;

		// Token: 0x040008AD RID: 2221
		[global::Cpp2ILInjected.Token(Token = "0x4000B19")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int _fallbackCount;

		// Token: 0x040008AE RID: 2222
		[global::Cpp2ILInjected.Token(Token = "0x4000B1A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private int _fallbackIndex;
	}
}
