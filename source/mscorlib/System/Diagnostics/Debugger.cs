using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	// Token: 0x020004E0 RID: 1248
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20005D2")]
	public sealed class Debugger
	{
		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x060029F4 RID: 10740 RVA: 0x0001BA25 File Offset: 0x00019C25
		[global::Cpp2ILInjected.Token(Token = "0x170006E7")]
		public static bool IsAttached
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D55")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C04A1C", Offset = "0x1C04A1C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Program", Member = "InitializeConsoleOutput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LanguageManager", Member = "LoadFilesForCulture", MemberParameters = new object[] { "Terraria.Localization.GameCulture" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060029F5 RID: 10741
		[global::Cpp2ILInjected.Token(Token = "0x6002D56")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04A68", Offset = "0x1C04A68", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool IsAttached_internal();

		// Token: 0x060029F6 RID: 10742 RVA: 0x0001BA28 File Offset: 0x00019C28
		[global::Cpp2ILInjected.Token(Token = "0x6002D57")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04A6C", Offset = "0x1C04A6C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Break()
		{
			throw null;
		}

		// Token: 0x060029F7 RID: 10743
		[global::Cpp2ILInjected.Token(Token = "0x6002D58")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04A70", Offset = "0x1C04A70", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.DefaultTraceListener", Member = "WriteImpl", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern bool IsLogging();

		// Token: 0x060029F8 RID: 10744
		[global::Cpp2ILInjected.Token(Token = "0x6002D59")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04A74", Offset = "0x1C04A74", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void Log_icall(int level, ref string category, ref string message);

		// Token: 0x060029F9 RID: 10745 RVA: 0x0001BA2B File Offset: 0x00019C2B
		[global::Cpp2ILInjected.Token(Token = "0x6002D5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04A78", Offset = "0x1C04A78", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.DefaultTraceListener", Member = "WriteImpl", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Log(int level, string category, string message)
		{
			throw null;
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x0001BA2E File Offset: 0x00019C2E
		[global::Cpp2ILInjected.Token(Token = "0x6002D5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04AE4", Offset = "0x1C04AE4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ThreadLocal<>), Member = "GetValueSlow", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncMethodBuilderCore), Member = "GetCompletionAction", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task),
			typeof(ref global::System.Runtime.CompilerServices.AsyncMethodBuilderCore.MoveNextRunner)
		}, ReturnType = typeof(global::System.Action))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static void NotifyOfCrossThreadDependency()
		{
			throw null;
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x0001BA31 File Offset: 0x00019C31
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002D5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04AE8", Offset = "0x1C04AE8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static Debugger()
		{
			throw null;
		}

		// Token: 0x04001576 RID: 5494
		[global::Cpp2ILInjected.Token(Token = "0x400195F")]
		public static readonly string DefaultCategory;
	}
}
