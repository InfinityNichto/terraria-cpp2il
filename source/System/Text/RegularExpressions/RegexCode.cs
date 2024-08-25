using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	[global::Cpp2ILInjected.Token(Token = "0x20000B8")]
	internal sealed class RegexCode
	{
		[global::Cpp2ILInjected.Token(Token = "0x60003B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB7C1C", Offset = "0x1EB7C1C", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "RegexCodeFromRegexTree", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexCode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public RegexCode(int[] codes, List<string> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, RegexPrefix? fcPrefix, int anchors, bool rightToLeft)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB7CEC", Offset = "0x1EB7CEC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool OpcodeBacktracks(int Op)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40002EF")]
		public const int Onerep = 0;

		[global::Cpp2ILInjected.Token(Token = "0x40002F0")]
		public const int Notonerep = 1;

		[global::Cpp2ILInjected.Token(Token = "0x40002F1")]
		public const int Setrep = 2;

		[global::Cpp2ILInjected.Token(Token = "0x40002F2")]
		public const int Oneloop = 3;

		[global::Cpp2ILInjected.Token(Token = "0x40002F3")]
		public const int Notoneloop = 4;

		[global::Cpp2ILInjected.Token(Token = "0x40002F4")]
		public const int Setloop = 5;

		[global::Cpp2ILInjected.Token(Token = "0x40002F5")]
		public const int Onelazy = 6;

		[global::Cpp2ILInjected.Token(Token = "0x40002F6")]
		public const int Notonelazy = 7;

		[global::Cpp2ILInjected.Token(Token = "0x40002F7")]
		public const int Setlazy = 8;

		[global::Cpp2ILInjected.Token(Token = "0x40002F8")]
		public const int One = 9;

		[global::Cpp2ILInjected.Token(Token = "0x40002F9")]
		public const int Notone = 10;

		[global::Cpp2ILInjected.Token(Token = "0x40002FA")]
		public const int Set = 11;

		[global::Cpp2ILInjected.Token(Token = "0x40002FB")]
		public const int Multi = 12;

		[global::Cpp2ILInjected.Token(Token = "0x40002FC")]
		public const int Ref = 13;

		[global::Cpp2ILInjected.Token(Token = "0x40002FD")]
		public const int Bol = 14;

		[global::Cpp2ILInjected.Token(Token = "0x40002FE")]
		public const int Eol = 15;

		[global::Cpp2ILInjected.Token(Token = "0x40002FF")]
		public const int Boundary = 16;

		[global::Cpp2ILInjected.Token(Token = "0x4000300")]
		public const int Nonboundary = 17;

		[global::Cpp2ILInjected.Token(Token = "0x4000301")]
		public const int Beginning = 18;

		[global::Cpp2ILInjected.Token(Token = "0x4000302")]
		public const int Start = 19;

		[global::Cpp2ILInjected.Token(Token = "0x4000303")]
		public const int EndZ = 20;

		[global::Cpp2ILInjected.Token(Token = "0x4000304")]
		public const int End = 21;

		[global::Cpp2ILInjected.Token(Token = "0x4000305")]
		public const int Nothing = 22;

		[global::Cpp2ILInjected.Token(Token = "0x4000306")]
		public const int Lazybranch = 23;

		[global::Cpp2ILInjected.Token(Token = "0x4000307")]
		public const int Branchmark = 24;

		[global::Cpp2ILInjected.Token(Token = "0x4000308")]
		public const int Lazybranchmark = 25;

		[global::Cpp2ILInjected.Token(Token = "0x4000309")]
		public const int Nullcount = 26;

		[global::Cpp2ILInjected.Token(Token = "0x400030A")]
		public const int Setcount = 27;

		[global::Cpp2ILInjected.Token(Token = "0x400030B")]
		public const int Branchcount = 28;

		[global::Cpp2ILInjected.Token(Token = "0x400030C")]
		public const int Lazybranchcount = 29;

		[global::Cpp2ILInjected.Token(Token = "0x400030D")]
		public const int Nullmark = 30;

		[global::Cpp2ILInjected.Token(Token = "0x400030E")]
		public const int Setmark = 31;

		[global::Cpp2ILInjected.Token(Token = "0x400030F")]
		public const int Capturemark = 32;

		[global::Cpp2ILInjected.Token(Token = "0x4000310")]
		public const int Getmark = 33;

		[global::Cpp2ILInjected.Token(Token = "0x4000311")]
		public const int Setjump = 34;

		[global::Cpp2ILInjected.Token(Token = "0x4000312")]
		public const int Backjump = 35;

		[global::Cpp2ILInjected.Token(Token = "0x4000313")]
		public const int Forejump = 36;

		[global::Cpp2ILInjected.Token(Token = "0x4000314")]
		public const int Testref = 37;

		[global::Cpp2ILInjected.Token(Token = "0x4000315")]
		public const int Goto = 38;

		[global::Cpp2ILInjected.Token(Token = "0x4000316")]
		public const int Prune = 39;

		[global::Cpp2ILInjected.Token(Token = "0x4000317")]
		public const int Stop = 40;

		[global::Cpp2ILInjected.Token(Token = "0x4000318")]
		public const int ECMABoundary = 41;

		[global::Cpp2ILInjected.Token(Token = "0x4000319")]
		public const int NonECMABoundary = 42;

		[global::Cpp2ILInjected.Token(Token = "0x400031A")]
		public const int Mask = 63;

		[global::Cpp2ILInjected.Token(Token = "0x400031B")]
		public const int Rtl = 64;

		[global::Cpp2ILInjected.Token(Token = "0x400031C")]
		public const int Back = 128;

		[global::Cpp2ILInjected.Token(Token = "0x400031D")]
		public const int Back2 = 256;

		[global::Cpp2ILInjected.Token(Token = "0x400031E")]
		public const int Ci = 512;

		[global::Cpp2ILInjected.Token(Token = "0x400031F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly int[] Codes;

		[global::Cpp2ILInjected.Token(Token = "0x4000320")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly string[] Strings;

		[global::Cpp2ILInjected.Token(Token = "0x4000321")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly int TrackCount;

		[global::Cpp2ILInjected.Token(Token = "0x4000322")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public readonly Hashtable Caps;

		[global::Cpp2ILInjected.Token(Token = "0x4000323")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public readonly int CapSize;

		[global::Cpp2ILInjected.Token(Token = "0x4000324")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public readonly RegexPrefix? FCPrefix;

		[global::Cpp2ILInjected.Token(Token = "0x4000325")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public readonly RegexBoyerMoore BMPrefix;

		[global::Cpp2ILInjected.Token(Token = "0x4000326")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public readonly int Anchors;

		[global::Cpp2ILInjected.Token(Token = "0x4000327")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public readonly bool RightToLeft;
	}
}
