using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001DD RID: 477
	[global::Cpp2ILInjected.Token(Token = "0x2000262")]
	public sealed class DecoderExceptionFallbackBuffer : DecoderFallbackBuffer
	{
		// Token: 0x060012E0 RID: 4832 RVA: 0x000179FF File Offset: 0x00015BFF
		[global::Cpp2ILInjected.Token(Token = "0x600149A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB223C", Offset = "0x1CB223C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderExceptionFallbackBuffer), Member = "Throw", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		public override bool Fallback(byte[] bytesUnknown, int index)
		{
			throw null;
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00017A02 File Offset: 0x00015C02
		[global::Cpp2ILInjected.Token(Token = "0x600149B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB23F4", Offset = "0x1CB23F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override char GetNextChar()
		{
			throw null;
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060012E2 RID: 4834 RVA: 0x00017A05 File Offset: 0x00015C05
		[global::Cpp2ILInjected.Token(Token = "0x17000206")]
		public override int Remaining
		{
			[global::Cpp2ILInjected.Token(Token = "0x600149C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB23FC", Offset = "0x1CB23FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x00017A08 File Offset: 0x00015C08
		[global::Cpp2ILInjected.Token(Token = "0x600149D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB2244", Offset = "0x1CB2244", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DecoderExceptionFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallbackException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void Throw(byte[] bytesUnknown, int index)
		{
			throw null;
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00017A0B File Offset: 0x00015C0B
		[global::Cpp2ILInjected.Token(Token = "0x600149E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB21C8", Offset = "0x1CB21C8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DecoderExceptionFallbackBuffer()
		{
			throw null;
		}
	}
}
