using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zlib
{
	[global::Cpp2ILInjected.Token(Token = "0x2000054")]
	internal sealed class StaticTree
	{
		[global::Cpp2ILInjected.Token(Token = "0x60003A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A746E0", Offset = "0x1A746E0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private StaticTree(short[] treeCodes, int[] extraBits, int extraBase, int elems, int maxLength)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A74730", Offset = "0x1A74730", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		static StaticTree()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40002DA")]
		internal static readonly short[] lengthAndLiteralsTreeCodes;

		[global::Cpp2ILInjected.Token(Token = "0x40002DB")]
		internal static readonly short[] distTreeCodes;

		[global::Cpp2ILInjected.Token(Token = "0x40002DC")]
		internal static readonly StaticTree Literals;

		[global::Cpp2ILInjected.Token(Token = "0x40002DD")]
		internal static readonly StaticTree Distances;

		[global::Cpp2ILInjected.Token(Token = "0x40002DE")]
		internal static readonly StaticTree BitLengths;

		[global::Cpp2ILInjected.Token(Token = "0x40002DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal short[] treeCodes;

		[global::Cpp2ILInjected.Token(Token = "0x40002E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int[] extraBits;

		[global::Cpp2ILInjected.Token(Token = "0x40002E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int extraBase;

		[global::Cpp2ILInjected.Token(Token = "0x40002E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		internal int elems;

		[global::Cpp2ILInjected.Token(Token = "0x40002E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal int maxLength;
	}
}
