using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000059 RID: 89
	[global::Cpp2ILInjected.Token(Token = "0x20000AB")]
	internal class MatchSparse : Match
	{
		// Token: 0x06000299 RID: 665 RVA: 0x00003581 File Offset: 0x00001781
		[global::Cpp2ILInjected.Token(Token = "0x6000328")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAA67C", Offset = "0x1EAA67C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexRunner), Member = "InitMatch", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Match), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Regex),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal MatchSparse(Regex regex, Hashtable caps, int capcount, string text, int begpos, int len, int startpos)
		{
			throw null;
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00003584 File Offset: 0x00001784
		[global::Cpp2ILInjected.Token(Token = "0x170000AF")]
		public override GroupCollection Groups
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000329")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAA72C", Offset = "0x1EAA72C", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400016F RID: 367
		[global::Cpp2ILInjected.Token(Token = "0x400029A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		internal new readonly Hashtable _caps;
	}
}
