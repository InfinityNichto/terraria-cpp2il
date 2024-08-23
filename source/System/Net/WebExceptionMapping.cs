using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000144 RID: 324
	[global::Cpp2ILInjected.Token(Token = "0x20001CB")]
	internal static class WebExceptionMapping
	{
		// Token: 0x060009E7 RID: 2535 RVA: 0x00004A2D File Offset: 0x00002C2D
		[global::Cpp2ILInjected.Token(Token = "0x6000AF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F11978", Offset = "0x1F11978", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetRes), Member = "GetWebStatusString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetRes), Member = "GetWebStatusString", MemberParameters = new object[] { typeof(WebExceptionStatus) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal static string GetWebStatusString(WebExceptionStatus status)
		{
			throw null;
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00004A30 File Offset: 0x00002C30
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000AF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F11ADC", Offset = "0x1F11ADC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static WebExceptionMapping()
		{
			throw null;
		}

		// Token: 0x0400079A RID: 1946
		[global::Cpp2ILInjected.Token(Token = "0x40009B3")]
		private static readonly string[] s_Mapping;
	}
}
