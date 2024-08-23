using System;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020001B3 RID: 435
	[global::Cpp2ILInjected.Token(Token = "0x200027E")]
	internal class WebCompletionSource : WebCompletionSource<object>
	{
		// Token: 0x06000FC4 RID: 4036 RVA: 0x00005B73 File Offset: 0x00003D73
		[global::Cpp2ILInjected.Token(Token = "0x600118D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFEA40", Offset = "0x1DFEA40", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest.<MyGetResponseAsync>d__243", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteChunkTrailer>d__40", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequestStream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<ReadAsync>d__40", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public WebCompletionSource()
		{
			throw null;
		}
	}
}
