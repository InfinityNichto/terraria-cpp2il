using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001E8 RID: 488
	[global::Cpp2ILInjected.Token(Token = "0x200026D")]
	public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x06001331 RID: 4913 RVA: 0x00017ADD File Offset: 0x00015CDD
		[global::Cpp2ILInjected.Token(Token = "0x60014EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB49AC", Offset = "0x1CB49AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EncoderExceptionFallbackBuffer()
		{
			throw null;
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x00017AE0 File Offset: 0x00015CE0
		[global::Cpp2ILInjected.Token(Token = "0x60014EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB4A20", Offset = "0x1CB4A20", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override bool Fallback(char charUnknown, int index)
		{
			throw null;
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x00017AE3 File Offset: 0x00015CE3
		[global::Cpp2ILInjected.Token(Token = "0x60014ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB4AFC", Offset = "0x1CB4AFC", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsLowSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ConvertToUtf32", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(char),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			throw null;
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x00017AE6 File Offset: 0x00015CE6
		[global::Cpp2ILInjected.Token(Token = "0x60014EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB4F3C", Offset = "0x1CB4F3C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override char GetNextChar()
		{
			throw null;
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00017AE9 File Offset: 0x00015CE9
		[global::Cpp2ILInjected.Token(Token = "0x60014EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB4F44", Offset = "0x1CB4F44", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool MovePrevious()
		{
			throw null;
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x00017AEC File Offset: 0x00015CEC
		[global::Cpp2ILInjected.Token(Token = "0x17000217")]
		public override int Remaining
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB4F4C", Offset = "0x1CB4F4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}
	}
}
