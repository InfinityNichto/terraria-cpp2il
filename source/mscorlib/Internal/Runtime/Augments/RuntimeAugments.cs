using System;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Internal.Runtime.Augments
{
	// Token: 0x02000048 RID: 72
	[global::Cpp2ILInjected.Token(Token = "0x2000063")]
	internal class RuntimeAugments
	{
		// Token: 0x060001D3 RID: 467 RVA: 0x00014B16 File Offset: 0x00012D16
		[global::Cpp2ILInjected.Token(Token = "0x600022F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC6E80", Offset = "0x1AC6E80", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.AwaitTaskContinuation), Member = "ThrowAsyncIfNecessary", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo), Member = "Capture", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		public static void ReportUnhandledException(global::System.Exception exception)
		{
			throw null;
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00014B19 File Offset: 0x00012D19
		[global::Cpp2ILInjected.Token(Token = "0x1700003C")]
		internal static ReflectionExecutionDomainCallbacks Callbacks
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000230")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC6E98", Offset = "0x1AC6E98", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00014B1C File Offset: 0x00012D1C
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000231")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC6EF0", Offset = "0x1AC6EF0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static RuntimeAugments()
		{
			throw null;
		}

		// Token: 0x040000E2 RID: 226
		[global::Cpp2ILInjected.Token(Token = "0x4000195")]
		private static ReflectionExecutionDomainCallbacks s_reflectionExecutionDomainCallbacks;
	}
}
