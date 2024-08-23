using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	// Token: 0x020001B1 RID: 433
	[global::Cpp2ILInjected.Token(Token = "0x2000226")]
	internal readonly struct ForceAsyncAwaiter : global::System.Runtime.CompilerServices.ICriticalNotifyCompletion
	{
		// Token: 0x0600118A RID: 4490 RVA: 0x00017624 File Offset: 0x00015824
		[global::Cpp2ILInjected.Token(Token = "0x6001318")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4D18", Offset = "0x1CA4D18", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal ForceAsyncAwaiter(Task task)
		{
			throw null;
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00017627 File Offset: 0x00015827
		[global::Cpp2ILInjected.Token(Token = "0x6001319")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4D20", Offset = "0x1CA4D20", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.CryptoStream.<ReadAsyncInternal>d__37", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.CryptoStream.<WriteAsyncInternal>d__46", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public ForceAsyncAwaiter GetAwaiter()
		{
			throw null;
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x0001762A File Offset: 0x0001582A
		[global::Cpp2ILInjected.Token(Token = "0x170001CF")]
		public bool IsCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x600131A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA4D28", Offset = "0x1CA4D28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.CryptoStream.<ReadAsyncInternal>d__37", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.CryptoStream.<WriteAsyncInternal>d__46", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x0001762D File Offset: 0x0001582D
		[global::Cpp2ILInjected.Token(Token = "0x600131B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4D30", Offset = "0x1CA4D30", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.CryptoStream.<ReadAsyncInternal>d__37", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.CryptoStream.<WriteAsyncInternal>d__46", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
		public void GetResult()
		{
			throw null;
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x00017630 File Offset: 0x00015830
		[global::Cpp2ILInjected.Token(Token = "0x600131C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4D50", Offset = "0x1CA4D50", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		public void UnsafeOnCompleted(global::System.Action action)
		{
			throw null;
		}

		// Token: 0x040007EB RID: 2027
		[global::Cpp2ILInjected.Token(Token = "0x4000A35")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Task _task;
	}
}
