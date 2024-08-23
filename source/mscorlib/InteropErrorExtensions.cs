using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000003 RID: 3
[global::Cpp2ILInjected.Token(Token = "0x200000B")]
internal static class InteropErrorExtensions
{
	// Token: 0x06000007 RID: 7 RVA: 0x000145F7 File Offset: 0x000127F7
	[global::Cpp2ILInjected.Token(Token = "0x600002D")]
	[global::Cpp2ILInjected.Address(RVA = "0x1AAA644", Offset = "0x1AAA644", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "DeleteFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	public static global::Interop.ErrorInfo Info(this global::Interop.Error error)
	{
		throw null;
	}
}
