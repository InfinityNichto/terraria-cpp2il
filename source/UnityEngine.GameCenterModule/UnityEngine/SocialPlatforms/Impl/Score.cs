using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x02000011 RID: 17
	[global::Cpp2ILInjected.Token(Token = "0x2000011")]
	public class Score : IScore
	{
		// Token: 0x0600002A RID: 42 RVA: 0x000020B9 File Offset: 0x000002B9
		[global::Cpp2ILInjected.Token(Token = "0x600002A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F941E8", Offset = "0x1F941E8", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Leaderboard), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Score(string leaderboardID, long value)
		{
			throw null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000020BC File Offset: 0x000002BC
		[global::Cpp2ILInjected.Token(Token = "0x600002B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F939D4", Offset = "0x1F939D4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Score(string leaderboardID, long value, string userID, DateTime date, string formattedValue, int rank)
		{
			throw null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000020BF File Offset: 0x000002BF
		[global::Cpp2ILInjected.Token(Token = "0x600002C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F942AC", Offset = "0x1F942AC", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000020C2 File Offset: 0x000002C2
		// (set) Token: 0x0600002E RID: 46 RVA: 0x000020C5 File Offset: 0x000002C5
		[global::Cpp2ILInjected.Token(Token = "0x17000014")]
		public string leaderboardID
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600002D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F944F4", Offset = "0x1F944F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600002E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F944FC", Offset = "0x1F944FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000020C8 File Offset: 0x000002C8
		// (set) Token: 0x06000030 RID: 48 RVA: 0x000020CB File Offset: 0x000002CB
		[global::Cpp2ILInjected.Token(Token = "0x17000015")]
		public long value
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600002F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F94504", Offset = "0x1F94504", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000030")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9450C", Offset = "0x1F9450C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04000029 RID: 41
		[global::Cpp2ILInjected.Token(Token = "0x4000029")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private DateTime m_Date;

		// Token: 0x0400002A RID: 42
		[global::Cpp2ILInjected.Token(Token = "0x400002A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string m_FormattedValue;

		// Token: 0x0400002B RID: 43
		[global::Cpp2ILInjected.Token(Token = "0x400002B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string m_UserID;

		// Token: 0x0400002C RID: 44
		[global::Cpp2ILInjected.Token(Token = "0x400002C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int m_Rank;

		// Token: 0x0400002D RID: 45
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400002D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string <leaderboardID>k__BackingField;

		// Token: 0x0400002E RID: 46
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400002E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private long <value>k__BackingField;
	}
}
