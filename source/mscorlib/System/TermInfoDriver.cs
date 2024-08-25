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
	[global::Cpp2ILInjected.Token(Token = "0x200018D")]
	internal class TermInfoDriver : global::System.IConsoleDriver
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6000F7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83978", Offset = "0x1C83978", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.CStreamWriter), Member = "InternalWriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		private void WriteConsole(string str)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000F89")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C84F8C", Offset = "0x1C84F8C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.CStreamWriter), Member = "InternalWriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public void Clear()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000F8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C84FC4", Offset = "0x1C84FC4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void AdjustBuffer()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000F8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C859F0", Offset = "0x1C859F0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.StreamReader), Member = "DataAvailable", ReturnType = typeof(bool))]
		private bool InputPending()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000F95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C85EB8", Offset = "0x1C85EB8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.CStreamReader), Member = "ReadLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public string ReadLine()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C86080", Offset = "0x1C86080", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.CStreamReader), Member = "ReadToEnd", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "ReadUntilConditionInternal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		public string ReadToEnd()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000F9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C88004", Offset = "0x1C88004", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "InitKeys", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoReader), Member = "GetStringBytes", MemberParameters = new object[] { typeof(global::System.TermInfoStrings) }, ReturnType = typeof(byte[]))]
		private void AddStringMapping(global::System.TermInfoStrings s)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000698")]
		private unsafe static int* native_terminal_size;

		[global::Cpp2ILInjected.Token(Token = "0x4000699")]
		private static int terminal_size;

		[global::Cpp2ILInjected.Token(Token = "0x400069A")]
		private static readonly string[] locations;

		[global::Cpp2ILInjected.Token(Token = "0x400069B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.TermInfoReader reader;

		[global::Cpp2ILInjected.Token(Token = "0x400069C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int cursorLeft;

		[global::Cpp2ILInjected.Token(Token = "0x400069D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int cursorTop;

		[global::Cpp2ILInjected.Token(Token = "0x400069E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string title;

		[global::Cpp2ILInjected.Token(Token = "0x400069F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string titleFormat;

		[global::Cpp2ILInjected.Token(Token = "0x40006A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool cursorVisible;

		[global::Cpp2ILInjected.Token(Token = "0x40006A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string csrVisible;

		[global::Cpp2ILInjected.Token(Token = "0x40006A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string csrInvisible;

		[global::Cpp2ILInjected.Token(Token = "0x40006A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string clear;

		[global::Cpp2ILInjected.Token(Token = "0x40006A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string bell;

		[global::Cpp2ILInjected.Token(Token = "0x40006A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string term;

		[global::Cpp2ILInjected.Token(Token = "0x40006A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private global::System.IO.StreamReader stdin;

		[global::Cpp2ILInjected.Token(Token = "0x40006A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private global::System.IO.CStreamWriter stdout;

		[global::Cpp2ILInjected.Token(Token = "0x40006A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private int windowWidth;

		[global::Cpp2ILInjected.Token(Token = "0x40006A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		private int windowHeight;

		[global::Cpp2ILInjected.Token(Token = "0x40006AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private int bufferHeight;

		[global::Cpp2ILInjected.Token(Token = "0x40006AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		private int bufferWidth;

		[global::Cpp2ILInjected.Token(Token = "0x40006AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private char[] buffer;

		[global::Cpp2ILInjected.Token(Token = "0x40006AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private int readpos;

		[global::Cpp2ILInjected.Token(Token = "0x40006AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		private int writepos;

		[global::Cpp2ILInjected.Token(Token = "0x40006AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private string keypadXmit;

		[global::Cpp2ILInjected.Token(Token = "0x40006B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private string keypadLocal;

		[global::Cpp2ILInjected.Token(Token = "0x40006B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private bool inited;

		[global::Cpp2ILInjected.Token(Token = "0x40006B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private object initLock;

		[global::Cpp2ILInjected.Token(Token = "0x40006B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private bool initKeys;

		[global::Cpp2ILInjected.Token(Token = "0x40006B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private string origPair;

		[global::Cpp2ILInjected.Token(Token = "0x40006B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private string origColors;

		[global::Cpp2ILInjected.Token(Token = "0x40006B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private string cursorAddress;

		[global::Cpp2ILInjected.Token(Token = "0x40006B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private global::System.ConsoleColor fgcolor;

		[global::Cpp2ILInjected.Token(Token = "0x40006B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private string setfgcolor;

		[global::Cpp2ILInjected.Token(Token = "0x40006B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private string setbgcolor;

		[global::Cpp2ILInjected.Token(Token = "0x40006BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private int maxColors;

		[global::Cpp2ILInjected.Token(Token = "0x40006BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
		private bool noGetPosition;

		[global::Cpp2ILInjected.Token(Token = "0x40006BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private global::System.Collections.Hashtable keymap;

		[global::Cpp2ILInjected.Token(Token = "0x40006BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private global::System.ByteMatcher rootmap;

		[global::Cpp2ILInjected.Token(Token = "0x40006BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private int rl_startx;

		[global::Cpp2ILInjected.Token(Token = "0x40006BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x104")]
		private int rl_starty;

		[global::Cpp2ILInjected.Token(Token = "0x40006C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private byte[] control_characters;

		[global::Cpp2ILInjected.Token(Token = "0x40006C1")]
		private static readonly int[] _consoleColorToAnsiCode;

		[global::Cpp2ILInjected.Token(Token = "0x40006C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private char[] echobuf;

		[global::Cpp2ILInjected.Token(Token = "0x40006C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		private int echon;
	}
}
