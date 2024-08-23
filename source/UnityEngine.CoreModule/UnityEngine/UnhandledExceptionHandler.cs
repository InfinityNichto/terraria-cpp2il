using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000AA RID: 170
	[NativeHeader("PlatformDependent/iPhonePlayer/IOSScriptBindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000B9")]
	internal sealed class UnhandledExceptionHandler
	{
		// Token: 0x06000334 RID: 820 RVA: 0x000026A7 File Offset: 0x000008A7
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000343")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D72C", Offset = "0x1F7D72C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AppDomain), Member = "get_CurrentDomain", ReturnType = typeof(AppDomain))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnhandledExceptionEventHandler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AppDomain), Member = "add_UnhandledException", MemberParameters = new object[] { typeof(UnhandledExceptionEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void RegisterUECatcher()
		{
			throw null;
		}

		// Token: 0x0200016F RID: 367
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000BA")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060006C3 RID: 1731 RVA: 0x00002F95 File Offset: 0x00001195
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000344")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7D818", Offset = "0x1F7D818", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x060006C4 RID: 1732 RVA: 0x00002F98 File Offset: 0x00001198
			[global::Cpp2ILInjected.Token(Token = "0x6000345")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7D874", Offset = "0x1F7D874", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x060006C5 RID: 1733 RVA: 0x00002F9B File Offset: 0x0000119B
			[global::Cpp2ILInjected.Token(Token = "0x6000346")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7D87C", Offset = "0x1F7D87C", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void <RegisterUECatcher>b__0_0(object sender, UnhandledExceptionEventArgs e)
			{
				throw null;
			}

			// Token: 0x04000662 RID: 1634
			[global::Cpp2ILInjected.Token(Token = "0x4000370")]
			public static readonly UnhandledExceptionHandler.<>c <>9;

			// Token: 0x04000663 RID: 1635
			[global::Cpp2ILInjected.Token(Token = "0x4000371")]
			public static UnhandledExceptionEventHandler <>9__0_0;
		}
	}
}
