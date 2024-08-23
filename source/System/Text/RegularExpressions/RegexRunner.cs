using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	// Token: 0x0200006A RID: 106
	[global::Cpp2ILInjected.Token(Token = "0x20000C2")]
	public abstract class RegexRunner
	{
		// Token: 0x060003CC RID: 972 RVA: 0x00003914 File Offset: 0x00001B14
		[global::Cpp2ILInjected.Token(Token = "0x600046C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB8F40", Offset = "0x1EB8F40", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected internal RegexRunner()
		{
			throw null;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00003917 File Offset: 0x00001B17
		[global::Cpp2ILInjected.Token(Token = "0x600046D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC2B90", Offset = "0x1EC2B90", Length = "0x2F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "Run", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "ValidateMatchTimeout", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "get_RightToLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexRunner), Member = "InitMatch", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexRunner), Member = "DoCheckTimeout", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected internal Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout)
		{
			throw null;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000391A File Offset: 0x00001B1A
		[global::Cpp2ILInjected.Token(Token = "0x600046E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC2E88", Offset = "0x1EC2E88", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		private void StartTimeoutWatch()
		{
			throw null;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000391D File Offset: 0x00001B1D
		[global::Cpp2ILInjected.Token(Token = "0x600046F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBB1F4", Offset = "0x1EBB1F4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexRunner), Member = "DoCheckTimeout", ReturnType = typeof(void))]
		protected void CheckTimeout()
		{
			throw null;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00003920 File Offset: 0x00001B20
		[global::Cpp2ILInjected.Token(Token = "0x6000470")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC30BC", Offset = "0x1EC30BC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexRunner), Member = "Scan", MemberParameters = new object[]
		{
			typeof(Regex),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(TimeSpan)
		}, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexRunner), Member = "CheckTimeout", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromMilliseconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexMatchTimeoutException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void DoCheckTimeout()
		{
			throw null;
		}

		// Token: 0x060003D1 RID: 977
		[global::Cpp2ILInjected.Token(Token = "0x6000471")]
		protected abstract void Go();

		// Token: 0x060003D2 RID: 978
		[global::Cpp2ILInjected.Token(Token = "0x6000472")]
		protected abstract bool FindFirstChar();

		// Token: 0x060003D3 RID: 979
		[global::Cpp2ILInjected.Token(Token = "0x6000473")]
		protected abstract void InitTrackCount();

		// Token: 0x060003D4 RID: 980 RVA: 0x00003923 File Offset: 0x00001B23
		[global::Cpp2ILInjected.Token(Token = "0x6000474")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC2EBC", Offset = "0x1EC2EBC", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexRunner), Member = "Scan", MemberParameters = new object[]
		{
			typeof(Regex),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(TimeSpan)
		}, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MatchSparse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Regex),
			typeof(Hashtable),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Match), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Regex),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void InitMatch()
		{
			throw null;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00003926 File Offset: 0x00001B26
		[global::Cpp2ILInjected.Token(Token = "0x6000475")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC3080", Offset = "0x1EC3080", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private Match TidyMatch(bool quick)
		{
			throw null;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00003929 File Offset: 0x00001B29
		[global::Cpp2ILInjected.Token(Token = "0x6000476")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB9014", Offset = "0x1EB9014", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexInterpreter), Member = "Goto", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexInterpreter), Member = "Backtrack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexRunner), Member = "DoubleStack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexRunner), Member = "DoubleTrack", ReturnType = typeof(void))]
		protected void EnsureStorage()
		{
			throw null;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000392C File Offset: 0x00001B2C
		[global::Cpp2ILInjected.Token(Token = "0x6000477")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBB3FC", Offset = "0x1EBB3FC", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "IsWordChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected bool IsBoundary(int index, int startpos, int endpos)
		{
			throw null;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000392F File Offset: 0x00001B2F
		[global::Cpp2ILInjected.Token(Token = "0x6000478")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBB4E8", Offset = "0x1EBB4E8", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "IsECMAWordChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected bool IsECMABoundary(int index, int startpos, int endpos)
		{
			throw null;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00003932 File Offset: 0x00001B32
		[global::Cpp2ILInjected.Token(Token = "0x6000479")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC3210", Offset = "0x1EC3210", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexRunner), Member = "EnsureStorage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void DoubleTrack()
		{
			throw null;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00003935 File Offset: 0x00001B35
		[global::Cpp2ILInjected.Token(Token = "0x600047A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC3180", Offset = "0x1EC3180", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexRunner), Member = "EnsureStorage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void DoubleStack()
		{
			throw null;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00003938 File Offset: 0x00001B38
		[global::Cpp2ILInjected.Token(Token = "0x600047B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC32A0", Offset = "0x1EC32A0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexRunner), Member = "Crawl", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexRunner), Member = "Capture", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexRunner), Member = "TransferCapture", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void DoubleCrawl()
		{
			throw null;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000393B File Offset: 0x00001B3B
		[global::Cpp2ILInjected.Token(Token = "0x600047C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC3330", Offset = "0x1EC3330", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexRunner), Member = "DoubleCrawl", ReturnType = typeof(void))]
		protected void Crawl(int i)
		{
			throw null;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000393E File Offset: 0x00001B3E
		[global::Cpp2ILInjected.Token(Token = "0x600047D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC3374", Offset = "0x1EC3374", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected int Popcrawl()
		{
			throw null;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00003941 File Offset: 0x00001B41
		[global::Cpp2ILInjected.Token(Token = "0x600047E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBB3E8", Offset = "0x1EBB3E8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected int Crawlpos()
		{
			throw null;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00003944 File Offset: 0x00001B44
		[global::Cpp2ILInjected.Token(Token = "0x600047F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBB34C", Offset = "0x1EBB34C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexRunner), Member = "DoubleCrawl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected void Capture(int capnum, int start, int end)
		{
			throw null;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00003947 File Offset: 0x00001B47
		[global::Cpp2ILInjected.Token(Token = "0x6000480")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBB214", Offset = "0x1EBB214", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexRunner), Member = "DoubleCrawl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected void TransferCapture(int capnum, int uncapnum, int start, int end)
		{
			throw null;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000394A File Offset: 0x00001B4A
		[global::Cpp2ILInjected.Token(Token = "0x6000481")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBB3BC", Offset = "0x1EBB3BC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected void Uncapture()
		{
			throw null;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000394D File Offset: 0x00001B4D
		[global::Cpp2ILInjected.Token(Token = "0x6000482")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBB204", Offset = "0x1EBB204", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected bool IsMatched(int cap)
		{
			throw null;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00003950 File Offset: 0x00001B50
		[global::Cpp2ILInjected.Token(Token = "0x6000483")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBB5D4", Offset = "0x1EBB5D4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected int MatchIndex(int cap)
		{
			throw null;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00003953 File Offset: 0x00001B53
		[global::Cpp2ILInjected.Token(Token = "0x6000484")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBB5E4", Offset = "0x1EBB5E4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected int MatchLength(int cap)
		{
			throw null;
		}

		// Token: 0x0400022A RID: 554
		[global::Cpp2ILInjected.Token(Token = "0x400036B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected internal int runtextbeg;

		// Token: 0x0400022B RID: 555
		[global::Cpp2ILInjected.Token(Token = "0x400036C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		protected internal int runtextend;

		// Token: 0x0400022C RID: 556
		[global::Cpp2ILInjected.Token(Token = "0x400036D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected internal int runtextstart;

		// Token: 0x0400022D RID: 557
		[global::Cpp2ILInjected.Token(Token = "0x400036E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected internal string runtext;

		// Token: 0x0400022E RID: 558
		[global::Cpp2ILInjected.Token(Token = "0x400036F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected internal int runtextpos;

		// Token: 0x0400022F RID: 559
		[global::Cpp2ILInjected.Token(Token = "0x4000370")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		protected internal int[] runtrack;

		// Token: 0x04000230 RID: 560
		[global::Cpp2ILInjected.Token(Token = "0x4000371")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		protected internal int runtrackpos;

		// Token: 0x04000231 RID: 561
		[global::Cpp2ILInjected.Token(Token = "0x4000372")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		protected internal int[] runstack;

		// Token: 0x04000232 RID: 562
		[global::Cpp2ILInjected.Token(Token = "0x4000373")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		protected internal int runstackpos;

		// Token: 0x04000233 RID: 563
		[global::Cpp2ILInjected.Token(Token = "0x4000374")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		protected internal int[] runcrawl;

		// Token: 0x04000234 RID: 564
		[global::Cpp2ILInjected.Token(Token = "0x4000375")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		protected internal int runcrawlpos;

		// Token: 0x04000235 RID: 565
		[global::Cpp2ILInjected.Token(Token = "0x4000376")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		protected internal int runtrackcount;

		// Token: 0x04000236 RID: 566
		[global::Cpp2ILInjected.Token(Token = "0x4000377")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		protected internal Match runmatch;

		// Token: 0x04000237 RID: 567
		[global::Cpp2ILInjected.Token(Token = "0x4000378")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		protected internal Regex runregex;

		// Token: 0x04000238 RID: 568
		[global::Cpp2ILInjected.Token(Token = "0x4000379")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private int _timeout;

		// Token: 0x04000239 RID: 569
		[global::Cpp2ILInjected.Token(Token = "0x400037A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		private bool _ignoreTimeout;

		// Token: 0x0400023A RID: 570
		[global::Cpp2ILInjected.Token(Token = "0x400037B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private int _timeoutOccursAt;

		// Token: 0x0400023B RID: 571
		[global::Cpp2ILInjected.Token(Token = "0x400037C")]
		private const int TimeoutCheckFrequency = 1000;

		// Token: 0x0400023C RID: 572
		[global::Cpp2ILInjected.Token(Token = "0x400037D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		private int _timeoutChecksToSkip;
	}
}
