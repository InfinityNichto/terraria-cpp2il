﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO.Enumeration
{
	[global::Cpp2ILInjected.Token(Token = "0x200057A")]
	internal static class FileSystemEnumerableFactory
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002A23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD3110", Offset = "0x1BD3110", Length = "0x434")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Directory), Member = "InternalEnumeratePaths", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(SearchTarget),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(global::System.Collections.Generic.IEnumerable<string>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "IsPathRooted", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Join", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemName), Member = "TranslateWin32Expression", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		internal static void NormalizeInputs(ref string directory, ref string expression, EnumerationOptions options)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A24")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD38B4", Offset = "0x1BD38B4", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemEnumerableFactory.<>c__DisplayClass3_0), Member = "<UserFiles>b__1", MemberParameters = new object[] { typeof(ref FileSystemEntry) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemEnumerableFactory.<>c__DisplayClass4_0), Member = "<UserDirectories>b__1", MemberParameters = new object[] { typeof(ref FileSystemEntry) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemEnumerableFactory.<>c__DisplayClass5_0), Member = "<UserEntries>b__1", MemberParameters = new object[] { typeof(ref FileSystemEntry) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemName), Member = "MatchesWin32Expression", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private static bool MatchesPattern(string expression, global::System.ReadOnlySpan<char> name, EnumerationOptions options)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD3BDC", Offset = "0x1BD3BDC", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Directory), Member = "InternalEnumeratePaths", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(SearchTarget),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(global::System.Collections.Generic.IEnumerable<string>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEnumerable<>.FindTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEnumerable<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			"FindTransform<TResult>",
			typeof(EnumerationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEnumerable<>.FindPredicate), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal static global::System.Collections.Generic.IEnumerable<string> UserFiles(string directory, string expression, EnumerationOptions options)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD3DA4", Offset = "0x1BD3DA4", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Directory), Member = "InternalEnumeratePaths", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(SearchTarget),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(global::System.Collections.Generic.IEnumerable<string>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEnumerable<>.FindTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEnumerable<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			"FindTransform<TResult>",
			typeof(EnumerationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEnumerable<>.FindPredicate), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal static global::System.Collections.Generic.IEnumerable<string> UserDirectories(string directory, string expression, EnumerationOptions options)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A27")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD3F6C", Offset = "0x1BD3F6C", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Directory), Member = "InternalEnumeratePaths", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(SearchTarget),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(global::System.Collections.Generic.IEnumerable<string>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEnumerable<>.FindTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEnumerable<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			"FindTransform<TResult>",
			typeof(EnumerationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEnumerable<>.FindPredicate), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal static global::System.Collections.Generic.IEnumerable<string> UserEntries(string directory, string expression, EnumerationOptions options)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002A28")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD4134", Offset = "0x1BD4134", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static FileSystemEnumerableFactory()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400169D")]
		private static readonly char[] s_unixEscapeChars;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200057B")]
		private sealed class <>c__DisplayClass3_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A29")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD3D9C", Offset = "0x1BD3D9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass3_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002A2A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD41C8", Offset = "0x1BD41C8", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEntry), Member = "get_FileName", ReturnType = typeof(global::System.ReadOnlySpan<char>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEnumerableFactory), Member = "MatchesPattern", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(EnumerationOptions)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool <UserFiles>b__1(ref FileSystemEntry entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400169E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string expression;

			[global::Cpp2ILInjected.Token(Token = "0x400169F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public EnumerationOptions options;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200057C")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6002A2B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD4268", Offset = "0x1BD4268", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002A2C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD42C4", Offset = "0x1BD42C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002A2D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD42CC", Offset = "0x1BD42CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEntry), Member = "ToSpecifiedFullPath", ReturnType = typeof(string))]
			internal string <UserFiles>b__3_0(ref FileSystemEntry entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002A2E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD42D4", Offset = "0x1BD42D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEntry), Member = "ToSpecifiedFullPath", ReturnType = typeof(string))]
			internal string <UserDirectories>b__4_0(ref FileSystemEntry entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002A2F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD42DC", Offset = "0x1BD42DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEntry), Member = "ToSpecifiedFullPath", ReturnType = typeof(string))]
			internal string <UserEntries>b__5_0(ref FileSystemEntry entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40016A0")]
			public static readonly FileSystemEnumerableFactory.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x40016A1")]
			public static FileSystemEnumerable<string>.FindTransform <>9__3_0;

			[global::Cpp2ILInjected.Token(Token = "0x40016A2")]
			public static FileSystemEnumerable<string>.FindTransform <>9__4_0;

			[global::Cpp2ILInjected.Token(Token = "0x40016A3")]
			public static FileSystemEnumerable<string>.FindTransform <>9__5_0;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200057D")]
		private sealed class <>c__DisplayClass4_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A30")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD3F64", Offset = "0x1BD3F64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass4_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002A31")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD42E4", Offset = "0x1BD42E4", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEntry), Member = "get_FileName", ReturnType = typeof(global::System.ReadOnlySpan<char>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEnumerableFactory), Member = "MatchesPattern", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(EnumerationOptions)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool <UserDirectories>b__1(ref FileSystemEntry entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40016A4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string expression;

			[global::Cpp2ILInjected.Token(Token = "0x40016A5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public EnumerationOptions options;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200057E")]
		private sealed class <>c__DisplayClass5_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A32")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD412C", Offset = "0x1BD412C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass5_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002A33")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD4384", Offset = "0x1BD4384", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEntry), Member = "get_FileName", ReturnType = typeof(global::System.ReadOnlySpan<char>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEnumerableFactory), Member = "MatchesPattern", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(EnumerationOptions)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool <UserEntries>b__1(ref FileSystemEntry entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40016A6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string expression;

			[global::Cpp2ILInjected.Token(Token = "0x40016A7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public EnumerationOptions options;
		}
	}
}
