using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Cache
{
	// Token: 0x020001FE RID: 510
	[global::Cpp2ILInjected.Token(Token = "0x20002E3")]
	internal class RequestCacheValidator
	{
		// Token: 0x060010FE RID: 4350 RVA: 0x00005EF1 File Offset: 0x000040F1
		[global::Cpp2ILInjected.Token(Token = "0x60012F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E21770", Offset = "0x1E21770", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "InternalSetCachePolicy", MemberParameters = new object[] { typeof(RequestCachePolicy) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public object CreateValidator()
		{
			throw null;
		}
	}
}
