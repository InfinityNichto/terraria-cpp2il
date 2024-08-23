using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	// Token: 0x020001B0 RID: 432
	[global::Cpp2ILInjected.Token(Token = "0x2000225")]
	internal static class TaskAwaiters
	{
		// Token: 0x06001189 RID: 4489 RVA: 0x00017621 File Offset: 0x00015821
		[global::Cpp2ILInjected.Token(Token = "0x6001317")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4D14", Offset = "0x1CA4D14", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.CryptoStream.<ReadAsyncInternal>d__37", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.CryptoStream.<WriteAsyncInternal>d__46", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static ForceAsyncAwaiter ForceAsync(this Task task)
		{
			throw null;
		}
	}
}
