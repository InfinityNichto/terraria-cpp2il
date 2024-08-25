using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	[global::Cpp2ILInjected.Token(Token = "0x20000C4")]
	internal sealed class RegexTree
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000486")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBD62C", Offset = "0x1EBD62C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal RegexTree(RegexNode root, Hashtable caps, int[] capNumList, int capTop, Hashtable capNames, string[] capsList, RegexOptions options)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400037E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly RegexNode Root;

		[global::Cpp2ILInjected.Token(Token = "0x400037F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly Hashtable Caps;

		[global::Cpp2ILInjected.Token(Token = "0x4000380")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly int[] CapNumList;

		[global::Cpp2ILInjected.Token(Token = "0x4000381")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public readonly int CapTop;

		[global::Cpp2ILInjected.Token(Token = "0x4000382")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public readonly Hashtable CapNames;

		[global::Cpp2ILInjected.Token(Token = "0x4000383")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public readonly string[] CapsList;

		[global::Cpp2ILInjected.Token(Token = "0x4000384")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public readonly RegexOptions Options;
	}
}
