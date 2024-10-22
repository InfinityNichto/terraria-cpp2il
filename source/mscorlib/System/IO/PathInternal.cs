﻿using System;
using System.IO.Enumeration;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	[global::Cpp2ILInjected.Token(Token = "0x200053A")]
	internal static class PathInternal
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002776")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B99358", Offset = "0x1B99358", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PathInternal), Member = "IsRoot", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Directory), Member = "InternalGetDirectoryRoot", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystem), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static int GetRootLength(global::System.ReadOnlySpan<char> path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002777")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B993D4", Offset = "0x1B993D4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "JoinInternal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "JoinInternal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		internal static bool IsDirectorySeparator(char c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002778")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B993E4", Offset = "0x1B993E4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PathInternal), Member = "TrimEndingDirectorySeparator", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PathInternal), Member = "TrimEndingDirectorySeparator", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystem), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "TryJoin", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEntry), Member = "ToSpecifiedFullPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static bool EndsInDirectorySeparator(global::System.ReadOnlySpan<char> path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002779")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9946C", Offset = "0x1B9946C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "TryJoin", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEntry), Member = "ToSpecifiedFullPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static bool StartsWithDirectorySeparator(global::System.ReadOnlySpan<char> path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600277A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B994E8", Offset = "0x1B994E8", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystem), Member = "DeleteFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemInfo), Member = "ThrowNotFound", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerator<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PathInternal), Member = "EndsInDirectorySeparator", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PathInternal), Member = "IsRoot", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static string TrimEndingDirectorySeparator(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600277B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9969C", Offset = "0x1B9969C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DirectoryInfo), Member = "Init", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStatus), Member = "Refresh", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystem), Member = "FileExists", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PathInternal), Member = "EndsInDirectorySeparator", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PathInternal), Member = "IsRoot", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static global::System.ReadOnlySpan<char> TrimEndingDirectorySeparator(global::System.ReadOnlySpan<char> path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600277C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B99620", Offset = "0x1B99620", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PathInternal), Member = "TrimEndingDirectorySeparator", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PathInternal), Member = "TrimEndingDirectorySeparator", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DirectoryInfo), Member = "Init", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PathInternal), Member = "GetRootLength", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static bool IsRoot(global::System.ReadOnlySpan<char> path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005AF")]
		internal static bool IsCaseSensitive
		{
			[global::Cpp2ILInjected.Token(Token = "0x600277D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9977C", Offset = "0x1B9977C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600277E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B997D4", Offset = "0x1B997D4", Length = "0x2FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PathInternal), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetTempPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "NewGuid", ReturnType = typeof(global::System.Guid))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare),
			typeof(int),
			typeof(FileOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private static bool GetIsCaseSensitive()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600277F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B99C80", Offset = "0x1B99C80", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__Error), Member = "GetDisplayablePath", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool IsPartiallyQualified(string path)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002780")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B99C88", Offset = "0x1B99C88", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PathInternal), Member = "GetIsCaseSensitive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static PathInternal()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400158D")]
		private static readonly bool s_isCaseSensitive;
	}
}
