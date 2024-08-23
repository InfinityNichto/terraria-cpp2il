using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200019C RID: 412
	[global::Cpp2ILInjected.Token(Token = "0x2000253")]
	internal class HttpRequestCreator : IWebRequestCreate
	{
		// Token: 0x06000DF6 RID: 3574 RVA: 0x00005621 File Offset: 0x00003821
		[global::Cpp2ILInjected.Token(Token = "0x6000F80")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F516F8", Offset = "0x1F516F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "PopulatePrefixList", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal HttpRequestCreator()
		{
			throw null;
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00005624 File Offset: 0x00003824
		[global::Cpp2ILInjected.Token(Token = "0x6000F81")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F51700", Offset = "0x1F51700", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public WebRequest Create(Uri uri)
		{
			throw null;
		}
	}
}
