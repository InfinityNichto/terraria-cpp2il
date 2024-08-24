using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using ReLogic.IO;
using Terraria.Initializers;
using Terraria.Localization;
using Terraria.Social;
using Terraria.Utilities;

namespace Terraria
{
	// Token: 0x0200033E RID: 830
	[global::Cpp2ILInjected.Token(Token = "0x2000452")]
	public static class Program
	{
		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060026D2 RID: 9938 RVA: 0x00028EAD File Offset: 0x000270AD
		[global::Cpp2ILInjected.Token(Token = "0x170005C1")]
		public static float LoadedPercentage
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002972")]
			[global::Cpp2ILInjected.Address(RVA = "0x115B5E4", Offset = "0x115B5E4", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x00028EB0 File Offset: 0x000270B0
		[global::Cpp2ILInjected.Token(Token = "0x6002973")]
		[global::Cpp2ILInjected.Address(RVA = "0x115B670", Offset = "0x115B670", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void StartForceLoad()
		{
			throw null;
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x00028EB3 File Offset: 0x000270B3
		[global::Cpp2ILInjected.Token(Token = "0x6002974")]
		[global::Cpp2ILInjected.Address(RVA = "0x115B6CC", Offset = "0x115B6CC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Program), Member = "ForceLoadAssembly", MemberParameters = new object[]
		{
			typeof(Assembly),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void ForceLoadThread(object threadContext)
		{
			throw null;
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x00028EB6 File Offset: 0x000270B6
		[global::Cpp2ILInjected.Token(Token = "0x6002975")]
		[global::Cpp2ILInjected.Address(RVA = "0x115B810", Offset = "0x115B810", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Program), Member = "ForceLoadAssembly", MemberParameters = new object[]
		{
			typeof(Assembly),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetMethods", ReturnType = typeof(MethodInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "get_IsAbstract", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeMethodHandle), Member = "GetFunctionPointer", ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "PrepareMethod", MemberParameters = new object[] { typeof(RuntimeMethodHandle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void ForceJITOnAssembly(Assembly assembly)
		{
			throw null;
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x00028EB9 File Offset: 0x000270B9
		[global::Cpp2ILInjected.Token(Token = "0x6002976")]
		[global::Cpp2ILInjected.Address(RVA = "0x115B9F8", Offset = "0x115B9F8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Program), Member = "ForceLoadAssembly", MemberParameters = new object[]
		{
			typeof(Assembly),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "RunClassConstructor", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(void))]
		private static void ForceStaticInitializers(Assembly assembly)
		{
			throw null;
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x00028EBC File Offset: 0x000270BC
		[global::Cpp2ILInjected.Token(Token = "0x6002977")]
		[global::Cpp2ILInjected.Address(RVA = "0x115B758", Offset = "0x115B758", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Program), Member = "ForceLoadThread", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Program), Member = "ForceLoadAssembly", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Program), Member = "ForceJITOnAssembly", MemberParameters = new object[] { typeof(Assembly) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Program), Member = "ForceStaticInitializers", MemberParameters = new object[] { typeof(Assembly) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void ForceLoadAssembly(Assembly assembly, bool initializeStaticMembers)
		{
			throw null;
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x00028EBF File Offset: 0x000270BF
		[global::Cpp2ILInjected.Token(Token = "0x6002978")]
		[global::Cpp2ILInjected.Address(RVA = "0x115BA84", Offset = "0x115BA84", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AppDomain), Member = "get_CurrentDomain", ReturnType = typeof(AppDomain))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AppDomain), Member = "GetAssemblies", ReturnType = typeof(Assembly[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Assembly),
			typeof(Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Assembly), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Program), Member = "ForceLoadAssembly", MemberParameters = new object[]
		{
			typeof(Assembly),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void ForceLoadAssembly(string name, bool initializeStaticMembers)
		{
			throw null;
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x00028EC2 File Offset: 0x000270C2
		[global::Cpp2ILInjected.Token(Token = "0x6002979")]
		[global::Cpp2ILInjected.Address(RVA = "0x115BB7C", Offset = "0x115BB7C", Length = "0x3C0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Program), Member = "LaunchGame", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConsoleOutputMirror), Member = "ToFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrashWatcher), Member = "Inititialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrashWatcher), Member = "EnableCrashDumps", MemberParameters = new object[] { typeof(CrashDump.Options) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private static void SetupLogging()
		{
			throw null;
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x00028EC5 File Offset: 0x000270C5
		[global::Cpp2ILInjected.Token(Token = "0x600297A")]
		[global::Cpp2ILInjected.Address(RVA = "0x115BF3C", Offset = "0x115BF3C", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Program), Member = "LaunchGame", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debugger), Member = "get_IsAttached", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "set_OutputEncoding", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "set_InputEncoding", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static void InitializeConsoleOutput()
		{
			throw null;
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x00028EC8 File Offset: 0x000270C8
		[global::Cpp2ILInjected.Token(Token = "0x600297B")]
		[global::Cpp2ILInjected.Address(RVA = "0x115C058", Offset = "0x115C058", Length = "0x3D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "set_Name", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ConvertMonoArgsToDotNet", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ParseArguements", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(Dictionary<string, string>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "SetMinThreads", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageManager), Member = "SetLanguage", MemberParameters = new object[] { typeof(GameCulture) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Program), Member = "InitializeConsoleOutput", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Program), Member = "SetupLogging", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "InitializeLegacyLocalization", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocialAPI), Member = "Initialize", MemberParameters = new object[] { typeof(SocialMode?) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LaunchInitializer), Member = "LoadParameters", MemberParameters = new object[] { typeof(Main) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "add_OnEnginePreload", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "DedServ", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Game), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public static void LaunchGame(string[] args, bool monoArgs = false)
		{
			throw null;
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x00028ECB File Offset: 0x000270CB
		[global::Cpp2ILInjected.Token(Token = "0x600297C")]
		[global::Cpp2ILInjected.Address(RVA = "0x115C428", Offset = "0x115C428", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void DisplayException(Exception e)
		{
			throw null;
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x00028ECE File Offset: 0x000270CE
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600297D")]
		[global::Cpp2ILInjected.Address(RVA = "0x115C42C", Offset = "0x115C42C", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		static Program()
		{
			throw null;
		}

		// Token: 0x04002EDD RID: 11997
		[global::Cpp2ILInjected.Token(Token = "0x40036A2")]
		public static bool IsXna;

		// Token: 0x04002EDE RID: 11998
		[global::Cpp2ILInjected.Token(Token = "0x40036A3")]
		public static bool IsFna;

		// Token: 0x04002EDF RID: 11999
		[global::Cpp2ILInjected.Token(Token = "0x40036A4")]
		public static bool IsMono;

		// Token: 0x04002EE0 RID: 12000
		[global::Cpp2ILInjected.Token(Token = "0x40036A5")]
		public const bool IsDebug = false;

		// Token: 0x04002EE1 RID: 12001
		[global::Cpp2ILInjected.Token(Token = "0x40036A6")]
		public static Dictionary<string, string> LaunchParameters;

		// Token: 0x04002EE2 RID: 12002
		[global::Cpp2ILInjected.Token(Token = "0x40036A7")]
		public static string SavePath;

		// Token: 0x04002EE3 RID: 12003
		[global::Cpp2ILInjected.Token(Token = "0x40036A8")]
		public const string TerrariaSaveFolderPath = "Terraria";

		// Token: 0x04002EE4 RID: 12004
		[global::Cpp2ILInjected.Token(Token = "0x40036A9")]
		private static int ThingsToLoad;

		// Token: 0x04002EE5 RID: 12005
		[global::Cpp2ILInjected.Token(Token = "0x40036AA")]
		private static int ThingsLoaded;

		// Token: 0x04002EE6 RID: 12006
		[global::Cpp2ILInjected.Token(Token = "0x40036AB")]
		public static bool LoadedEverything;

		// Token: 0x04002EE7 RID: 12007
		[global::Cpp2ILInjected.Token(Token = "0x40036AC")]
		public static IntPtr JitForcedMethodCache;
	}
}
