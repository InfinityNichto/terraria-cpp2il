using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000060 RID: 96
	[global::Cpp2ILInjected.Token(Token = "0x20000B8")]
	internal sealed class RegexCode
	{
		// Token: 0x06000318 RID: 792 RVA: 0x000036F8 File Offset: 0x000018F8
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

		// Token: 0x06000319 RID: 793 RVA: 0x000036FB File Offset: 0x000018FB
		[global::Cpp2ILInjected.Token(Token = "0x60003B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB7CEC", Offset = "0x1EB7CEC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool OpcodeBacktracks(int Op)
		{
			throw null;
		}

		// Token: 0x040001AE RID: 430
		[global::Cpp2ILInjected.Token(Token = "0x40002EF")]
		public const int Onerep = 0;

		// Token: 0x040001AF RID: 431
		[global::Cpp2ILInjected.Token(Token = "0x40002F0")]
		public const int Notonerep = 1;

		// Token: 0x040001B0 RID: 432
		[global::Cpp2ILInjected.Token(Token = "0x40002F1")]
		public const int Setrep = 2;

		// Token: 0x040001B1 RID: 433
		[global::Cpp2ILInjected.Token(Token = "0x40002F2")]
		public const int Oneloop = 3;

		// Token: 0x040001B2 RID: 434
		[global::Cpp2ILInjected.Token(Token = "0x40002F3")]
		public const int Notoneloop = 4;

		// Token: 0x040001B3 RID: 435
		[global::Cpp2ILInjected.Token(Token = "0x40002F4")]
		public const int Setloop = 5;

		// Token: 0x040001B4 RID: 436
		[global::Cpp2ILInjected.Token(Token = "0x40002F5")]
		public const int Onelazy = 6;

		// Token: 0x040001B5 RID: 437
		[global::Cpp2ILInjected.Token(Token = "0x40002F6")]
		public const int Notonelazy = 7;

		// Token: 0x040001B6 RID: 438
		[global::Cpp2ILInjected.Token(Token = "0x40002F7")]
		public const int Setlazy = 8;

		// Token: 0x040001B7 RID: 439
		[global::Cpp2ILInjected.Token(Token = "0x40002F8")]
		public const int One = 9;

		// Token: 0x040001B8 RID: 440
		[global::Cpp2ILInjected.Token(Token = "0x40002F9")]
		public const int Notone = 10;

		// Token: 0x040001B9 RID: 441
		[global::Cpp2ILInjected.Token(Token = "0x40002FA")]
		public const int Set = 11;

		// Token: 0x040001BA RID: 442
		[global::Cpp2ILInjected.Token(Token = "0x40002FB")]
		public const int Multi = 12;

		// Token: 0x040001BB RID: 443
		[global::Cpp2ILInjected.Token(Token = "0x40002FC")]
		public const int Ref = 13;

		// Token: 0x040001BC RID: 444
		[global::Cpp2ILInjected.Token(Token = "0x40002FD")]
		public const int Bol = 14;

		// Token: 0x040001BD RID: 445
		[global::Cpp2ILInjected.Token(Token = "0x40002FE")]
		public const int Eol = 15;

		// Token: 0x040001BE RID: 446
		[global::Cpp2ILInjected.Token(Token = "0x40002FF")]
		public const int Boundary = 16;

		// Token: 0x040001BF RID: 447
		[global::Cpp2ILInjected.Token(Token = "0x4000300")]
		public const int Nonboundary = 17;

		// Token: 0x040001C0 RID: 448
		[global::Cpp2ILInjected.Token(Token = "0x4000301")]
		public const int Beginning = 18;

		// Token: 0x040001C1 RID: 449
		[global::Cpp2ILInjected.Token(Token = "0x4000302")]
		public const int Start = 19;

		// Token: 0x040001C2 RID: 450
		[global::Cpp2ILInjected.Token(Token = "0x4000303")]
		public const int EndZ = 20;

		// Token: 0x040001C3 RID: 451
		[global::Cpp2ILInjected.Token(Token = "0x4000304")]
		public const int End = 21;

		// Token: 0x040001C4 RID: 452
		[global::Cpp2ILInjected.Token(Token = "0x4000305")]
		public const int Nothing = 22;

		// Token: 0x040001C5 RID: 453
		[global::Cpp2ILInjected.Token(Token = "0x4000306")]
		public const int Lazybranch = 23;

		// Token: 0x040001C6 RID: 454
		[global::Cpp2ILInjected.Token(Token = "0x4000307")]
		public const int Branchmark = 24;

		// Token: 0x040001C7 RID: 455
		[global::Cpp2ILInjected.Token(Token = "0x4000308")]
		public const int Lazybranchmark = 25;

		// Token: 0x040001C8 RID: 456
		[global::Cpp2ILInjected.Token(Token = "0x4000309")]
		public const int Nullcount = 26;

		// Token: 0x040001C9 RID: 457
		[global::Cpp2ILInjected.Token(Token = "0x400030A")]
		public const int Setcount = 27;

		// Token: 0x040001CA RID: 458
		[global::Cpp2ILInjected.Token(Token = "0x400030B")]
		public const int Branchcount = 28;

		// Token: 0x040001CB RID: 459
		[global::Cpp2ILInjected.Token(Token = "0x400030C")]
		public const int Lazybranchcount = 29;

		// Token: 0x040001CC RID: 460
		[global::Cpp2ILInjected.Token(Token = "0x400030D")]
		public const int Nullmark = 30;

		// Token: 0x040001CD RID: 461
		[global::Cpp2ILInjected.Token(Token = "0x400030E")]
		public const int Setmark = 31;

		// Token: 0x040001CE RID: 462
		[global::Cpp2ILInjected.Token(Token = "0x400030F")]
		public const int Capturemark = 32;

		// Token: 0x040001CF RID: 463
		[global::Cpp2ILInjected.Token(Token = "0x4000310")]
		public const int Getmark = 33;

		// Token: 0x040001D0 RID: 464
		[global::Cpp2ILInjected.Token(Token = "0x4000311")]
		public const int Setjump = 34;

		// Token: 0x040001D1 RID: 465
		[global::Cpp2ILInjected.Token(Token = "0x4000312")]
		public const int Backjump = 35;

		// Token: 0x040001D2 RID: 466
		[global::Cpp2ILInjected.Token(Token = "0x4000313")]
		public const int Forejump = 36;

		// Token: 0x040001D3 RID: 467
		[global::Cpp2ILInjected.Token(Token = "0x4000314")]
		public const int Testref = 37;

		// Token: 0x040001D4 RID: 468
		[global::Cpp2ILInjected.Token(Token = "0x4000315")]
		public const int Goto = 38;

		// Token: 0x040001D5 RID: 469
		[global::Cpp2ILInjected.Token(Token = "0x4000316")]
		public const int Prune = 39;

		// Token: 0x040001D6 RID: 470
		[global::Cpp2ILInjected.Token(Token = "0x4000317")]
		public const int Stop = 40;

		// Token: 0x040001D7 RID: 471
		[global::Cpp2ILInjected.Token(Token = "0x4000318")]
		public const int ECMABoundary = 41;

		// Token: 0x040001D8 RID: 472
		[global::Cpp2ILInjected.Token(Token = "0x4000319")]
		public const int NonECMABoundary = 42;

		// Token: 0x040001D9 RID: 473
		[global::Cpp2ILInjected.Token(Token = "0x400031A")]
		public const int Mask = 63;

		// Token: 0x040001DA RID: 474
		[global::Cpp2ILInjected.Token(Token = "0x400031B")]
		public const int Rtl = 64;

		// Token: 0x040001DB RID: 475
		[global::Cpp2ILInjected.Token(Token = "0x400031C")]
		public const int Back = 128;

		// Token: 0x040001DC RID: 476
		[global::Cpp2ILInjected.Token(Token = "0x400031D")]
		public const int Back2 = 256;

		// Token: 0x040001DD RID: 477
		[global::Cpp2ILInjected.Token(Token = "0x400031E")]
		public const int Ci = 512;

		// Token: 0x040001DE RID: 478
		[global::Cpp2ILInjected.Token(Token = "0x400031F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly int[] Codes;

		// Token: 0x040001DF RID: 479
		[global::Cpp2ILInjected.Token(Token = "0x4000320")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly string[] Strings;

		// Token: 0x040001E0 RID: 480
		[global::Cpp2ILInjected.Token(Token = "0x4000321")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly int TrackCount;

		// Token: 0x040001E1 RID: 481
		[global::Cpp2ILInjected.Token(Token = "0x4000322")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public readonly Hashtable Caps;

		// Token: 0x040001E2 RID: 482
		[global::Cpp2ILInjected.Token(Token = "0x4000323")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public readonly int CapSize;

		// Token: 0x040001E3 RID: 483
		[global::Cpp2ILInjected.Token(Token = "0x4000324")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public readonly RegexPrefix? FCPrefix;

		// Token: 0x040001E4 RID: 484
		[global::Cpp2ILInjected.Token(Token = "0x4000325")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public readonly RegexBoyerMoore BMPrefix;

		// Token: 0x040001E5 RID: 485
		[global::Cpp2ILInjected.Token(Token = "0x4000326")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public readonly int Anchors;

		// Token: 0x040001E6 RID: 486
		[global::Cpp2ILInjected.Token(Token = "0x4000327")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public readonly bool RightToLeft;
	}
}
