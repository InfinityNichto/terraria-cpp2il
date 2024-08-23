using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000058 RID: 88
	[global::Cpp2ILInjected.Token(Token = "0x20000AA")]
	[Serializable]
	public class Match : Group
	{
		// Token: 0x06000289 RID: 649 RVA: 0x00003551 File Offset: 0x00001751
		[global::Cpp2ILInjected.Token(Token = "0x6000318")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA9B98", Offset = "0x1EA9B98", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Match), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MatchSparse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Regex),
			typeof(Hashtable),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexRunner), Member = "InitMatch", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal Match(Regex regex, int capcount, string text, int begpos, int len, int startpos)
		{
			throw null;
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00003554 File Offset: 0x00001754
		[global::Cpp2ILInjected.Token(Token = "0x170000AD")]
		public static Match Empty
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000319")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA9CF4", Offset = "0x1EA9CF4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00003557 File Offset: 0x00001757
		[global::Cpp2ILInjected.Token(Token = "0x600031A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA9D4C", Offset = "0x1EA9D4C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart)
		{
			throw null;
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000355A File Offset: 0x0000175A
		[global::Cpp2ILInjected.Token(Token = "0x170000AE")]
		public virtual GroupCollection Groups
		{
			[global::Cpp2ILInjected.Token(Token = "0x600031B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA9D90", Offset = "0x1EA9D90", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000355D File Offset: 0x0000175D
		[global::Cpp2ILInjected.Token(Token = "0x600031C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA9DF8", Offset = "0x1EA9DF8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new object[]
		{
			typeof(MatchEvaluator),
			typeof(Regex),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "Split", MemberParameters = new object[]
		{
			typeof(Regex),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new object[]
		{
			typeof(Regex),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public Match NextMatch()
		{
			throw null;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00003560 File Offset: 0x00001760
		[global::Cpp2ILInjected.Token(Token = "0x600031D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAA080", Offset = "0x1EAA080", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[] { "System.ExceptionArgument" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal virtual ReadOnlySpan<char> GroupToStringImpl(int groupnum)
		{
			throw null;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00003563 File Offset: 0x00001763
		[global::Cpp2ILInjected.Token(Token = "0x600031E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAA1D4", Offset = "0x1EAA1D4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexReplacement), Member = "ReplacementImpl", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(Match)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexReplacement), Member = "ReplacementImplRTL", MemberParameters = new object[]
		{
			typeof(List<string>),
			typeof(Match)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal ReadOnlySpan<char> LastGroupToStringImpl()
		{
			throw null;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00003566 File Offset: 0x00001766
		[global::Cpp2ILInjected.Token(Token = "0x600031F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAA1EC", Offset = "0x1EAA1EC", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal virtual void AddMatch(int cap, int start, int len)
		{
			throw null;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00003569 File Offset: 0x00001769
		[global::Cpp2ILInjected.Token(Token = "0x6000320")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAA354", Offset = "0x1EAA354", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal virtual void BalanceMatch(int cap)
		{
			throw null;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000356C File Offset: 0x0000176C
		[global::Cpp2ILInjected.Token(Token = "0x6000321")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAA3D4", Offset = "0x1EAA3D4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void RemoveMatch(int cap)
		{
			throw null;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000356F File Offset: 0x0000176F
		[global::Cpp2ILInjected.Token(Token = "0x6000322")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAA3EC", Offset = "0x1EAA3EC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual bool IsMatched(int cap)
		{
			throw null;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00003572 File Offset: 0x00001772
		[global::Cpp2ILInjected.Token(Token = "0x6000323")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAA440", Offset = "0x1EAA440", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual int MatchIndex(int cap)
		{
			throw null;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00003575 File Offset: 0x00001775
		[global::Cpp2ILInjected.Token(Token = "0x6000324")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAA480", Offset = "0x1EAA480", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual int MatchLength(int cap)
		{
			throw null;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00003578 File Offset: 0x00001778
		[global::Cpp2ILInjected.Token(Token = "0x6000325")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAA4C0", Offset = "0x1EAA4C0", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void Tidy(int textpos)
		{
			throw null;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000357B File Offset: 0x0000177B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000326")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAA5B4", Offset = "0x1EAA5B4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Match), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Regex),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static Match()
		{
			throw null;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000357E File Offset: 0x0000177E
		[global::Cpp2ILInjected.Token(Token = "0x6000327")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAA644", Offset = "0x1EAA644", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal Match()
		{
			throw null;
		}

		// Token: 0x04000165 RID: 357
		[global::Cpp2ILInjected.Token(Token = "0x4000290")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal GroupCollection _groupcoll;

		// Token: 0x04000166 RID: 358
		[global::Cpp2ILInjected.Token(Token = "0x4000291")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal Regex _regex;

		// Token: 0x04000167 RID: 359
		[global::Cpp2ILInjected.Token(Token = "0x4000292")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal int _textbeg;

		// Token: 0x04000168 RID: 360
		[global::Cpp2ILInjected.Token(Token = "0x4000293")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		internal int _textpos;

		// Token: 0x04000169 RID: 361
		[global::Cpp2ILInjected.Token(Token = "0x4000294")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal int _textend;

		// Token: 0x0400016A RID: 362
		[global::Cpp2ILInjected.Token(Token = "0x4000295")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		internal int _textstart;

		// Token: 0x0400016B RID: 363
		[global::Cpp2ILInjected.Token(Token = "0x4000296")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal int[][] _matches;

		// Token: 0x0400016C RID: 364
		[global::Cpp2ILInjected.Token(Token = "0x4000297")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		internal int[] _matchcount;

		// Token: 0x0400016D RID: 365
		[global::Cpp2ILInjected.Token(Token = "0x4000298")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		internal bool _balancing;

		// Token: 0x0400016E RID: 366
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000299")]
		private static readonly Match <Empty>k__BackingField;
	}
}
