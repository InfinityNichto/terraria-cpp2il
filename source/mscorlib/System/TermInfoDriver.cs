using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000146 RID: 326
	[global::Cpp2ILInjected.Token(Token = "0x200018D")]
	internal class TermInfoDriver : global::System.IConsoleDriver
	{
		// Token: 0x06000E8F RID: 3727 RVA: 0x00016E41 File Offset: 0x00015041
		[global::Cpp2ILInjected.Token(Token = "0x6000F7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C836F8", Offset = "0x1C836F8", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "SearchTerminfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static string TryTermInfoDir(string dir, string term)
		{
			throw null;
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00016E44 File Offset: 0x00015044
		[global::Cpp2ILInjected.Token(Token = "0x6000F7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83824", Offset = "0x1C83824", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "TryTermInfoDir", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static string SearchTerminfo(string term)
		{
			throw null;
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00016E47 File Offset: 0x00015047
		[global::Cpp2ILInjected.Token(Token = "0x6000F7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83978", Offset = "0x1C83978", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.CStreamWriter), Member = "InternalWriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		private void WriteConsole(string str)
		{
			throw null;
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00016E4A File Offset: 0x0001504A
		[global::Cpp2ILInjected.Token(Token = "0x6000F7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7B874", Offset = "0x1C7B874", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ConsoleDriver), Member = "CreateTermInfoDriver", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.IConsoleDriver))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "SearchTerminfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.KnownTerminals), Member = "get_xterm", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.KnownTerminals), Member = "get_linux", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.KnownTerminals), Member = "get_ansi", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "OpenStandardOutput", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.CStreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Text.Encoding),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public TermInfoDriver(string term)
		{
			throw null;
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x00016E4D File Offset: 0x0001504D
		[global::Cpp2ILInjected.Token(Token = "0x17000162")]
		public bool Initialized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F7E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C83CD0", Offset = "0x1C83CD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00016E50 File Offset: 0x00015050
		[global::Cpp2ILInjected.Token(Token = "0x6000F7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83CD8", Offset = "0x1C83CD8", Length = "0x7A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "get_WindowHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "get_WindowWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "ReadUntilConditionInternal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "SetCursorPosition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ConsoleDriver), Member = "get_IsConsole", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoReader), Member = "Get", MemberParameters = new object[] { typeof(global::System.TermInfoStrings) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.CStreamWriter), Member = "InternalWriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoReader), Member = "Get", MemberParameters = new object[] { typeof(global::System.TermInfoNumbers) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "OpenStandardInput", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.StreamReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "GetCursorPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 44)]
		public void Init()
		{
			throw null;
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00016E53 File Offset: 0x00015053
		[global::Cpp2ILInjected.Token(Token = "0x6000F80")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C847E0", Offset = "0x1C847E0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "WriteSpecialKey", MemberParameters = new object[] { typeof(global::System.ConsoleKeyInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "IsSpecialKey", MemberParameters = new object[] { typeof(global::System.ConsoleKeyInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "get_WindowWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "get_WindowHeight", ReturnType = typeof(int))]
		private void IncrementX()
		{
			throw null;
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x00016E56 File Offset: 0x00015056
		[global::Cpp2ILInjected.Token(Token = "0x6000F81")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C848A4", Offset = "0x1C848A4", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "WriteSpecialKey", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "Echo", MemberParameters = new object[] { typeof(global::System.ConsoleKeyInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "SetCursorPosition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.CStreamWriter), Member = "InternalWriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "IncrementX", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void WriteSpecialKey(global::System.ConsoleKeyInfo key)
		{
			throw null;
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00016E59 File Offset: 0x00015059
		[global::Cpp2ILInjected.Token(Token = "0x6000F82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C84B64", Offset = "0x1C84B64", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.CStreamWriter), Member = "Write", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.CStreamWriter), Member = "Write", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "CreateKeyInfoFromInt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "WriteSpecialKey", MemberParameters = new object[] { typeof(global::System.ConsoleKeyInfo) }, ReturnType = typeof(void))]
		public void WriteSpecialKey(char c)
		{
			throw null;
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00016E5C File Offset: 0x0001505C
		[global::Cpp2ILInjected.Token(Token = "0x6000F83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C84D10", Offset = "0x1C84D10", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "IsSpecialKey", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "Echo", MemberParameters = new object[] { typeof(global::System.ConsoleKeyInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "get_WindowHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "IncrementX", ReturnType = typeof(void))]
		public bool IsSpecialKey(global::System.ConsoleKeyInfo key)
		{
			throw null;
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00016E5F File Offset: 0x0001505F
		[global::Cpp2ILInjected.Token(Token = "0x6000F84")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C84D94", Offset = "0x1C84D94", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.CStreamWriter), Member = "Write", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.CStreamWriter), Member = "Write", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "CreateKeyInfoFromInt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "IsSpecialKey", MemberParameters = new object[] { typeof(global::System.ConsoleKeyInfo) }, ReturnType = typeof(bool))]
		public bool IsSpecialKey(char c)
		{
			throw null;
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00016E62 File Offset: 0x00015062
		[global::Cpp2ILInjected.Token(Token = "0x6000F85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C84574", Offset = "0x1C84574", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "ReadUntilConditionInternal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "AddToBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.CStreamWriter), Member = "InternalWriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void GetCursorPosition()
		{
			throw null;
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00016E65 File Offset: 0x00015065
		[global::Cpp2ILInjected.Token(Token = "0x6000F86")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C84E74", Offset = "0x1C84E74", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "get_WindowHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "get_WindowWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "SetCursorPosition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoReader), Member = "Get", MemberParameters = new object[] { typeof(global::System.TermInfoNumbers) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void CheckWindowDimensions()
		{
			throw null;
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x00016E68 File Offset: 0x00015068
		[global::Cpp2ILInjected.Token(Token = "0x17000163")]
		public int WindowHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F87")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C84878", Offset = "0x1C84878", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "IncrementX", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "IsSpecialKey", MemberParameters = new object[] { typeof(global::System.ConsoleKeyInfo) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "CheckWindowDimensions", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x00016E6B File Offset: 0x0001506B
		[global::Cpp2ILInjected.Token(Token = "0x17000164")]
		public int WindowWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F88")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C8484C", Offset = "0x1C8484C", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "IncrementX", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "CheckWindowDimensions", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00016E6E File Offset: 0x0001506E
		[global::Cpp2ILInjected.Token(Token = "0x6000F89")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C84F8C", Offset = "0x1C84F8C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.CStreamWriter), Member = "InternalWriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00016E71 File Offset: 0x00015071
		[global::Cpp2ILInjected.Token(Token = "0x6000F8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C84DBC", Offset = "0x1C84DBC", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "GetCursorPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "Read", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void AddToBuffer(int b)
		{
			throw null;
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00016E74 File Offset: 0x00015074
		[global::Cpp2ILInjected.Token(Token = "0x6000F8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C84FC4", Offset = "0x1C84FC4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void AdjustBuffer()
		{
			throw null;
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00016E77 File Offset: 0x00015077
		[global::Cpp2ILInjected.Token(Token = "0x6000F8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C84B8C", Offset = "0x1C84B8C", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "WriteSpecialKey", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "IsSpecialKey", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "GetKeyFromBuffer", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ConsoleKeyInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(char),
			typeof(global::System.ConsoleKey),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private global::System.ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt)
		{
			throw null;
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00016E7A File Offset: 0x0001507A
		[global::Cpp2ILInjected.Token(Token = "0x6000F8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C84FD8", Offset = "0x1C84FD8", Length = "0x284")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "Read", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ByteMatcher), Member = "StartsWith", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ByteMatcher), Member = "Match", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(global::System.TermInfoStrings))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "CreateKeyInfoFromInt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ConsoleKeyInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(char),
			typeof(global::System.ConsoleKey),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private object GetKeyFromBuffer(bool cooked)
		{
			throw null;
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00016E7D File Offset: 0x0001507D
		[global::Cpp2ILInjected.Token(Token = "0x6000F8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C85720", Offset = "0x1C85720", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "Read", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "ReadKey", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "ReadUntilConditionInternal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "InitKeys", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "GetKeyFromBuffer", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "AddToBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.StreamReader), Member = "DataAvailable", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private global::System.ConsoleKeyInfo ReadKeyInternal(out bool fresh)
		{
			throw null;
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x00016E80 File Offset: 0x00015080
		[global::Cpp2ILInjected.Token(Token = "0x6000F8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C859F0", Offset = "0x1C859F0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.StreamReader), Member = "DataAvailable", ReturnType = typeof(bool))]
		private bool InputPending()
		{
			throw null;
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00016E83 File Offset: 0x00015083
		[global::Cpp2ILInjected.Token(Token = "0x6000F90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C85A10", Offset = "0x1C85A10", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "Echo", MemberParameters = new object[] { typeof(global::System.ConsoleKeyInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.StreamReader), Member = "DataAvailable", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.CStreamWriter), Member = "InternalWriteChars", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void QueueEcho(char c)
		{
			throw null;
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00016E86 File Offset: 0x00015086
		[global::Cpp2ILInjected.Token(Token = "0x6000F91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C85AC4", Offset = "0x1C85AC4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "Read", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "ReadKey", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "ReadUntilConditionInternal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "IsSpecialKey", MemberParameters = new object[] { typeof(global::System.ConsoleKeyInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.CStreamWriter), Member = "InternalWriteChars", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "WriteSpecialKey", MemberParameters = new object[] { typeof(global::System.ConsoleKeyInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "QueueEcho", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		private void Echo(global::System.ConsoleKeyInfo key)
		{
			throw null;
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x00016E89 File Offset: 0x00015089
		[global::Cpp2ILInjected.Token(Token = "0x6000F92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C85B2C", Offset = "0x1C85B2C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.CStreamWriter), Member = "InternalWriteChars", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void EchoFlush()
		{
			throw null;
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00016E8C File Offset: 0x0001508C
		[global::Cpp2ILInjected.Token(Token = "0x6000F93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C85B58", Offset = "0x1C85B58", Length = "0x2E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.CStreamReader), Member = "Read", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "GetKeyFromBuffer", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "Echo", MemberParameters = new object[] { typeof(global::System.ConsoleKeyInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.CStreamWriter), Member = "InternalWriteChars", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "AddToBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public int Read([global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] char[] dest, int index, int count)
		{
			throw null;
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00016E8F File Offset: 0x0001508F
		[global::Cpp2ILInjected.Token(Token = "0x6000F94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C85E40", Offset = "0x1C85E40", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "Echo", MemberParameters = new object[] { typeof(global::System.ConsoleKeyInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.CStreamWriter), Member = "InternalWriteChars", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		public global::System.ConsoleKeyInfo ReadKey(bool intercept)
		{
			throw null;
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x00016E92 File Offset: 0x00015092
		[global::Cpp2ILInjected.Token(Token = "0x6000F95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C85EB8", Offset = "0x1C85EB8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.CStreamReader), Member = "ReadLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public string ReadLine()
		{
			throw null;
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00016E95 File Offset: 0x00015095
		[global::Cpp2ILInjected.Token(Token = "0x6000F96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C86080", Offset = "0x1C86080", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.CStreamReader), Member = "ReadToEnd", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "ReadUntilConditionInternal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		public string ReadToEnd()
		{
			throw null;
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00016E98 File Offset: 0x00015098
		[global::Cpp2ILInjected.Token(Token = "0x6000F97")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C85EC0", Offset = "0x1C85EC0", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "ReadToEnd", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "GetCursorPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "Echo", MemberParameters = new object[] { typeof(global::System.ConsoleKeyInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.CStreamWriter), Member = "InternalWriteChars", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private string ReadUntilConditionInternal(bool haltOnNewLine)
		{
			throw null;
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00016E9B File Offset: 0x0001509B
		[global::Cpp2ILInjected.Token(Token = "0x6000F98")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C849D4", Offset = "0x1C849D4", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "WriteSpecialKey", MemberParameters = new object[] { typeof(global::System.ConsoleKeyInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "CheckWindowDimensions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParameterizedStrings), Member = "Evaluate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.ParameterizedStrings.FormatParam[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.CStreamWriter), Member = "InternalWriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void SetCursorPosition(int left, int top)
		{
			throw null;
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00016E9E File Offset: 0x0001509E
		[global::Cpp2ILInjected.Token(Token = "0x6000F99")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C861F0", Offset = "0x1C861F0", Length = "0x1DA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "InitKeys", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ConsoleKeyInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(char),
			typeof(global::System.ConsoleKey),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 124)]
		private void CreateKeyMap()
		{
			throw null;
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00016EA1 File Offset: 0x000150A1
		[global::Cpp2ILInjected.Token(Token = "0x6000F9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C858C8", Offset = "0x1C858C8", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "CreateKeyMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ByteMatcher), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "AddStringMapping", MemberParameters = new object[] { typeof(global::System.TermInfoStrings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ByteMatcher), Member = "AddMapping", MemberParameters = new object[]
		{
			typeof(global::System.TermInfoStrings),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void InitKeys()
		{
			throw null;
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00016EA4 File Offset: 0x000150A4
		[global::Cpp2ILInjected.Token(Token = "0x6000F9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C88004", Offset = "0x1C88004", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "InitKeys", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoReader), Member = "GetStringBytes", MemberParameters = new object[] { typeof(global::System.TermInfoStrings) }, ReturnType = typeof(byte[]))]
		private void AddStringMapping(global::System.TermInfoStrings s)
		{
			throw null;
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00016EA7 File Offset: 0x000150A7
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000F9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C881DC", Offset = "0x1C881DC", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		static TermInfoDriver()
		{
			throw null;
		}

		// Token: 0x040004C7 RID: 1223
		[global::Cpp2ILInjected.Token(Token = "0x4000698")]
		private unsafe static int* native_terminal_size;

		// Token: 0x040004C8 RID: 1224
		[global::Cpp2ILInjected.Token(Token = "0x4000699")]
		private static int terminal_size;

		// Token: 0x040004C9 RID: 1225
		[global::Cpp2ILInjected.Token(Token = "0x400069A")]
		private static readonly string[] locations;

		// Token: 0x040004CA RID: 1226
		[global::Cpp2ILInjected.Token(Token = "0x400069B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.TermInfoReader reader;

		// Token: 0x040004CB RID: 1227
		[global::Cpp2ILInjected.Token(Token = "0x400069C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int cursorLeft;

		// Token: 0x040004CC RID: 1228
		[global::Cpp2ILInjected.Token(Token = "0x400069D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int cursorTop;

		// Token: 0x040004CD RID: 1229
		[global::Cpp2ILInjected.Token(Token = "0x400069E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string title;

		// Token: 0x040004CE RID: 1230
		[global::Cpp2ILInjected.Token(Token = "0x400069F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string titleFormat;

		// Token: 0x040004CF RID: 1231
		[global::Cpp2ILInjected.Token(Token = "0x40006A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool cursorVisible;

		// Token: 0x040004D0 RID: 1232
		[global::Cpp2ILInjected.Token(Token = "0x40006A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string csrVisible;

		// Token: 0x040004D1 RID: 1233
		[global::Cpp2ILInjected.Token(Token = "0x40006A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string csrInvisible;

		// Token: 0x040004D2 RID: 1234
		[global::Cpp2ILInjected.Token(Token = "0x40006A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string clear;

		// Token: 0x040004D3 RID: 1235
		[global::Cpp2ILInjected.Token(Token = "0x40006A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string bell;

		// Token: 0x040004D4 RID: 1236
		[global::Cpp2ILInjected.Token(Token = "0x40006A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string term;

		// Token: 0x040004D5 RID: 1237
		[global::Cpp2ILInjected.Token(Token = "0x40006A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private global::System.IO.StreamReader stdin;

		// Token: 0x040004D6 RID: 1238
		[global::Cpp2ILInjected.Token(Token = "0x40006A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private global::System.IO.CStreamWriter stdout;

		// Token: 0x040004D7 RID: 1239
		[global::Cpp2ILInjected.Token(Token = "0x40006A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private int windowWidth;

		// Token: 0x040004D8 RID: 1240
		[global::Cpp2ILInjected.Token(Token = "0x40006A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		private int windowHeight;

		// Token: 0x040004D9 RID: 1241
		[global::Cpp2ILInjected.Token(Token = "0x40006AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private int bufferHeight;

		// Token: 0x040004DA RID: 1242
		[global::Cpp2ILInjected.Token(Token = "0x40006AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		private int bufferWidth;

		// Token: 0x040004DB RID: 1243
		[global::Cpp2ILInjected.Token(Token = "0x40006AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private char[] buffer;

		// Token: 0x040004DC RID: 1244
		[global::Cpp2ILInjected.Token(Token = "0x40006AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private int readpos;

		// Token: 0x040004DD RID: 1245
		[global::Cpp2ILInjected.Token(Token = "0x40006AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		private int writepos;

		// Token: 0x040004DE RID: 1246
		[global::Cpp2ILInjected.Token(Token = "0x40006AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private string keypadXmit;

		// Token: 0x040004DF RID: 1247
		[global::Cpp2ILInjected.Token(Token = "0x40006B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private string keypadLocal;

		// Token: 0x040004E0 RID: 1248
		[global::Cpp2ILInjected.Token(Token = "0x40006B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private bool inited;

		// Token: 0x040004E1 RID: 1249
		[global::Cpp2ILInjected.Token(Token = "0x40006B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private object initLock;

		// Token: 0x040004E2 RID: 1250
		[global::Cpp2ILInjected.Token(Token = "0x40006B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private bool initKeys;

		// Token: 0x040004E3 RID: 1251
		[global::Cpp2ILInjected.Token(Token = "0x40006B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private string origPair;

		// Token: 0x040004E4 RID: 1252
		[global::Cpp2ILInjected.Token(Token = "0x40006B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private string origColors;

		// Token: 0x040004E5 RID: 1253
		[global::Cpp2ILInjected.Token(Token = "0x40006B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private string cursorAddress;

		// Token: 0x040004E6 RID: 1254
		[global::Cpp2ILInjected.Token(Token = "0x40006B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private global::System.ConsoleColor fgcolor;

		// Token: 0x040004E7 RID: 1255
		[global::Cpp2ILInjected.Token(Token = "0x40006B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private string setfgcolor;

		// Token: 0x040004E8 RID: 1256
		[global::Cpp2ILInjected.Token(Token = "0x40006B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private string setbgcolor;

		// Token: 0x040004E9 RID: 1257
		[global::Cpp2ILInjected.Token(Token = "0x40006BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private int maxColors;

		// Token: 0x040004EA RID: 1258
		[global::Cpp2ILInjected.Token(Token = "0x40006BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
		private bool noGetPosition;

		// Token: 0x040004EB RID: 1259
		[global::Cpp2ILInjected.Token(Token = "0x40006BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private global::System.Collections.Hashtable keymap;

		// Token: 0x040004EC RID: 1260
		[global::Cpp2ILInjected.Token(Token = "0x40006BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private global::System.ByteMatcher rootmap;

		// Token: 0x040004ED RID: 1261
		[global::Cpp2ILInjected.Token(Token = "0x40006BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private int rl_startx;

		// Token: 0x040004EE RID: 1262
		[global::Cpp2ILInjected.Token(Token = "0x40006BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x104")]
		private int rl_starty;

		// Token: 0x040004EF RID: 1263
		[global::Cpp2ILInjected.Token(Token = "0x40006C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private byte[] control_characters;

		// Token: 0x040004F0 RID: 1264
		[global::Cpp2ILInjected.Token(Token = "0x40006C1")]
		private static readonly int[] _consoleColorToAnsiCode;

		// Token: 0x040004F1 RID: 1265
		[global::Cpp2ILInjected.Token(Token = "0x40006C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private char[] echobuf;

		// Token: 0x040004F2 RID: 1266
		[global::Cpp2ILInjected.Token(Token = "0x40006C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		private int echon;
	}
}
