using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20005D2")]
	public sealed class Debugger
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6002D56")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04A68", Offset = "0x1C04A68", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool IsAttached_internal();

		[global::Cpp2ILInjected.Token(Token = "0x6002D57")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04A6C", Offset = "0x1C04A6C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Break()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002D58")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04A70", Offset = "0x1C04A70", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.DefaultTraceListener", Member = "WriteImpl", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern bool IsLogging();

		[global::Cpp2ILInjected.Token(Token = "0x6002D59")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04A74", Offset = "0x1C04A74", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void Log_icall(int level, ref string category, ref string message);

		[global::Cpp2ILInjected.Token(Token = "0x6002D5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04A78", Offset = "0x1C04A78", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.DefaultTraceListener", Member = "WriteImpl", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Log(int level, string category, string message)
		{
			throw null;
		}

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

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002D5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04AE8", Offset = "0x1C04AE8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static Debugger()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400195F")]
		public static readonly string DefaultCategory;
	}
}
