using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO.Enumeration
{
	// Token: 0x020004A2 RID: 1186
	[global::Cpp2ILInjected.Token(Token = "0x2000580")]
	public static class FileSystemName
	{
		// Token: 0x0600271B RID: 10011 RVA: 0x0001B1F1 File Offset: 0x000193F1
		[global::Cpp2ILInjected.Token(Token = "0x6002A4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD3544", Offset = "0x1BD3544", Length = "0x370")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemEnumerableFactory), Member = "NormalizeInputs", MemberParameters = new object[]
		{
			typeof(ref string),
			typeof(ref string),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static string TranslateWin32Expression(string expression)
		{
			throw null;
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x0001B1F4 File Offset: 0x000193F4
		[global::Cpp2ILInjected.Token(Token = "0x6002A4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD3B54", Offset = "0x1BD3B54", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemEnumerableFactory), Member = "MatchesPattern", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemName), Member = "MatchPattern", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool MatchesWin32Expression(global::System.ReadOnlySpan<char> expression, global::System.ReadOnlySpan<char> name, bool ignoreCase = true)
		{
			throw null;
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x0001B1F7 File Offset: 0x000193F7
		[global::Cpp2ILInjected.Token(Token = "0x6002A4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD3ACC", Offset = "0x1BD3ACC", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemName), Member = "MatchPattern", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool MatchesSimpleExpression(global::System.ReadOnlySpan<char> expression, global::System.ReadOnlySpan<char> name, bool ignoreCase = true)
		{
			throw null;
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x0001B1FA File Offset: 0x000193FA
		[global::Cpp2ILInjected.Token(Token = "0x6002A4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD4408", Offset = "0x1BD4408", Length = "0x6B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemName), Member = "MatchesWin32Expression", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemName), Member = "MatchesSimpleExpression", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<int>), Member = "op_Implicit", MemberParameters = new object[] { typeof(int[]) }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<int>), Member = "CopyTo", MemberParameters = new object[] { typeof(global::System.Span<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToUpperInvariant", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MemoryExtensions), Member = "EndsWith", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private static bool MatchPattern(global::System.ReadOnlySpan<char> expression, global::System.ReadOnlySpan<char> name, bool ignoreCase, bool useExtendedWildcards)
		{
			throw null;
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x0001B1FD File Offset: 0x000193FD
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002A4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD4AC0", Offset = "0x1BD4AC0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static FileSystemName()
		{
			throw null;
		}

		// Token: 0x04001359 RID: 4953
		[global::Cpp2ILInjected.Token(Token = "0x40016B4")]
		private static readonly char[] s_wildcardChars;

		// Token: 0x0400135A RID: 4954
		[global::Cpp2ILInjected.Token(Token = "0x40016B5")]
		private static readonly char[] s_simpleWildcardChars;
	}
}
