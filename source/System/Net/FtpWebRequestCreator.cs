using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000E6 RID: 230
	[global::Cpp2ILInjected.Token(Token = "0x2000155")]
	internal class FtpWebRequestCreator : IWebRequestCreate
	{
		// Token: 0x060007C5 RID: 1989 RVA: 0x000044A2 File Offset: 0x000026A2
		[global::Cpp2ILInjected.Token(Token = "0x6000895")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF916C", Offset = "0x1EF916C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "PopulatePrefixList", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal FtpWebRequestCreator()
		{
			throw null;
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x000044A5 File Offset: 0x000026A5
		[global::Cpp2ILInjected.Token(Token = "0x6000896")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF9174", Offset = "0x1EF9174", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public WebRequest Create(Uri uri)
		{
			throw null;
		}
	}
}
