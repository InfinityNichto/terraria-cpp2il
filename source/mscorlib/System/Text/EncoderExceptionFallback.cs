using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001E7 RID: 487
	[global::Cpp2ILInjected.Token(Token = "0x200026C")]
	[global::System.Serializable]
	public sealed class EncoderExceptionFallback : EncoderFallback
	{
		// Token: 0x0600132C RID: 4908 RVA: 0x00017ACE File Offset: 0x00015CCE
		[global::Cpp2ILInjected.Token(Token = "0x60014E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB4950", Offset = "0x1CB4950", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequestUriBuilder", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.CharEntityEncoderFallbackBuffer", Member = "Fallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.CharEntityEncoderFallbackBuffer", Member = "Fallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EncoderExceptionFallback()
		{
			throw null;
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x00017AD1 File Offset: 0x00015CD1
		[global::Cpp2ILInjected.Token(Token = "0x60014E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB4958", Offset = "0x1CB4958", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			throw null;
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x00017AD4 File Offset: 0x00015CD4
		[global::Cpp2ILInjected.Token(Token = "0x17000216")]
		public override int MaxCharCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB49B4", Offset = "0x1CB49B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x00017AD7 File Offset: 0x00015CD7
		[global::Cpp2ILInjected.Token(Token = "0x60014E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB49BC", Offset = "0x1CB49BC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object value)
		{
			throw null;
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x00017ADA File Offset: 0x00015CDA
		[global::Cpp2ILInjected.Token(Token = "0x60014EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB4A18", Offset = "0x1CB4A18", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}
	}
}
