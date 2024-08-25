using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200000B")]
internal static class InteropErrorExtensions
{
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
