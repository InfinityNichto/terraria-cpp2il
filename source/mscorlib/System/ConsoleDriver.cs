using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000129 RID: 297
	[global::Cpp2ILInjected.Token(Token = "0x200016E")]
	internal static class ConsoleDriver
	{
		// Token: 0x06000DCE RID: 3534 RVA: 0x00016C70 File Offset: 0x00014E70
		[global::Cpp2ILInjected.Token(Token = "0x6000EB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7B6C0", Offset = "0x1C7B6C0", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ConsoleDriver), Member = "get_IsConsole", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ConsoleDriver), Member = "CreateWindowsConsoleDriver", ReturnType = typeof(global::System.IConsoleDriver))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ConsoleDriver), Member = "CreateNullConsoleDriver", ReturnType = typeof(global::System.IConsoleDriver))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ConsoleDriver), Member = "CreateTermInfoDriver", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.IConsoleDriver))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static ConsoleDriver()
		{
			throw null;
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x00016C73 File Offset: 0x00014E73
		[global::Cpp2ILInjected.Token(Token = "0x6000EB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7B784", Offset = "0x1C7B784", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ConsoleDriver), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(8)]
		private static global::System.IConsoleDriver CreateNullConsoleDriver()
		{
			throw null;
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00016C76 File Offset: 0x00014E76
		[global::Cpp2ILInjected.Token(Token = "0x6000EB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7B7C4", Offset = "0x1C7B7C4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ConsoleDriver), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.WindowsConsoleDriver), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(8)]
		private static global::System.IConsoleDriver CreateWindowsConsoleDriver()
		{
			throw null;
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00016C79 File Offset: 0x00014E79
		[global::Cpp2ILInjected.Token(Token = "0x6000EB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7B818", Offset = "0x1C7B818", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ConsoleDriver), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(8)]
		private static global::System.IConsoleDriver CreateTermInfoDriver(string term)
		{
			throw null;
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00016C7C File Offset: 0x00014E7C
		[global::Cpp2ILInjected.Token(Token = "0x6000EB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7B000", Offset = "0x1C7B000", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void Clear()
		{
			throw null;
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00016C7F File Offset: 0x00014E7F
		[global::Cpp2ILInjected.Token(Token = "0x6000EB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7AD78", Offset = "0x1C7AD78", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static string ReadLine()
		{
			throw null;
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00016C82 File Offset: 0x00014E82
		[global::Cpp2ILInjected.Token(Token = "0x6000EBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7B174", Offset = "0x1C7B174", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "ReadKey", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static global::System.ConsoleKeyInfo ReadKey(bool intercept)
		{
			throw null;
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x00016C85 File Offset: 0x00014E85
		[global::Cpp2ILInjected.Token(Token = "0x17000155")]
		public static bool IsConsole
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EBB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7A3C4", Offset = "0x1C7A3C4", Length = "0x138")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "SetupStreams", MemberParameters = new object[]
			{
				typeof(global::System.Text.Encoding),
				typeof(global::System.Text.Encoding)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "ReadLine", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ConsoleDriver), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.MonoIO), Member = "get_ConsoleOutput", ReturnType = typeof(global::System.IntPtr))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.MonoIO), Member = "get_ConsoleInput", ReturnType = typeof(global::System.IntPtr))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000DD6 RID: 3542
		[global::Cpp2ILInjected.Token(Token = "0x6000EBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7BBAC", Offset = "0x1C7BBAC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool Isatty(global::System.IntPtr handle);

		// Token: 0x06000DD7 RID: 3543
		[global::Cpp2ILInjected.Token(Token = "0x6000EBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7BBB0", Offset = "0x1C7BBB0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern int InternalKeyAvailable(int ms_timeout);

		// Token: 0x06000DD8 RID: 3544
		[global::Cpp2ILInjected.Token(Token = "0x6000EBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7BBB4", Offset = "0x1C7BBB4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal unsafe static extern bool TtySetup(string keypadXmit, string teardown, out byte[] control_characters, out int* address);

		// Token: 0x06000DD9 RID: 3545
		[global::Cpp2ILInjected.Token(Token = "0x6000EBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7BBB8", Offset = "0x1C7BBB8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern bool SetEcho(bool wantEcho);

		// Token: 0x0400048E RID: 1166
		[global::Cpp2ILInjected.Token(Token = "0x4000656")]
		internal static global::System.IConsoleDriver driver;

		// Token: 0x0400048F RID: 1167
		[global::Cpp2ILInjected.Token(Token = "0x4000657")]
		private static bool is_console;

		// Token: 0x04000490 RID: 1168
		[global::Cpp2ILInjected.Token(Token = "0x4000658")]
		private static bool called_isatty;
	}
}
