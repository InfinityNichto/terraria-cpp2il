﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	[global::Cpp2ILInjected.Token(Token = "0x20000C1")]
	internal sealed class RegexReplacement
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000466")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBD954", Offset = "0x1EBD954", Length = "0x4B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ParseReplacement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Hashtable),
			typeof(int),
			typeof(Hashtable),
			typeof(RegexOptions)
		}, ReturnType = typeof(RegexReplacement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexNode), Member = "Child", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Text.StringBuilderCache", Member = "Release", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public RegexReplacement(string rep, RegexNode concat, Hashtable _caps)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000467")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC239C", Offset = "0x1EC239C", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WeakReference<>), Member = "TryGetTarget", MemberParameters = new object[] { "T&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ParseReplacement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Hashtable),
			typeof(int),
			typeof(Hashtable),
			typeof(RegexOptions)
		}, ReturnType = typeof(RegexReplacement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WeakReference<>), Member = "SetTarget", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static RegexReplacement GetOrCreate(WeakReference<RegexReplacement> replRef, string replacement, Hashtable caps, int capsize, Hashtable capnames, RegexOptions roptions)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000C5")]
		public string Pattern
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000468")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC24A0", Offset = "0x1EC24A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000469")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC24A8", Offset = "0x1EC24A8", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new object[]
		{
			typeof(Regex),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(ReadOnlySpan<char>) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Match), Member = "LastGroupToStringImpl", ReturnType = typeof(ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Capture), Member = "GetRightSubstring", ReturnType = typeof(ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Capture), Member = "GetLeftSubstring", ReturnType = typeof(ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void ReplacementImpl(StringBuilder sb, Match match)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600046A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC2620", Offset = "0x1EC2620", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new object[]
		{
			typeof(Regex),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlySpan<char>), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Match), Member = "LastGroupToStringImpl", ReturnType = typeof(ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Capture), Member = "GetRightSubstring", ReturnType = typeof(ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Capture), Member = "GetLeftSubstring", ReturnType = typeof(ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void ReplacementImplRTL(List<string> al, Match match)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600046B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC2824", Offset = "0x1EC2824", Length = "0x36C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Match", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Group), Member = "get_Success", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "get_RightToLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexReplacement), Member = "ReplacementImplRTL", MemberParameters = new object[]
		{
			typeof(List<string>),
			typeof(Match)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Match), Member = "NextMatch", ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexReplacement), Member = "ReplacementImpl", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(Match)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public string Replace(Regex regex, string input, int count, int startat)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000363")]
		private const int Specials = 4;

		[global::Cpp2ILInjected.Token(Token = "0x4000364")]
		public const int LeftPortion = -1;

		[global::Cpp2ILInjected.Token(Token = "0x4000365")]
		public const int RightPortion = -2;

		[global::Cpp2ILInjected.Token(Token = "0x4000366")]
		public const int LastGroup = -3;

		[global::Cpp2ILInjected.Token(Token = "0x4000367")]
		public const int WholeString = -4;

		[global::Cpp2ILInjected.Token(Token = "0x4000368")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly List<string> _strings;

		[global::Cpp2ILInjected.Token(Token = "0x4000369")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly List<int> _rules;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400036A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly string <Pattern>k__BackingField;
	}
}
