using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000167 RID: 359
	[global::Cpp2ILInjected.Token(Token = "0x20001FD")]
	internal sealed class Semaphore : WaitHandle
	{
		// Token: 0x06000B49 RID: 2889 RVA: 0x00004E3E File Offset: 0x0000303E
		[global::Cpp2ILInjected.Token(Token = "0x6000C7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F28388", Offset = "0x1F28388", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Semaphore), Member = "CreateSemaphore_internal", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal Semaphore(int initialCount, int maxCount)
		{
			throw null;
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00004E41 File Offset: 0x00003041
		[global::Cpp2ILInjected.Token(Token = "0x6000C7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F284D8", Offset = "0x1F284D8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Semaphore), Member = "ReleaseSemaphore_internal", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		internal bool ReleaseSemaphore()
		{
			throw null;
		}
	}
}
