using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000A6 RID: 166
	[global::Cpp2ILInjected.Token(Token = "0x20000D1")]
	internal sealed class StarNode : InteriorNode
	{
		// Token: 0x060007B9 RID: 1977 RVA: 0x00004586 File Offset: 0x00002786
		[global::Cpp2ILInjected.Token(Token = "0x6000848")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB642C", Offset = "0x1DB642C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "NextSet", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "Or", MemberParameters = new object[] { typeof(BitSet) }, ReturnType = typeof(void))]
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
			throw null;
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x00004589 File Offset: 0x00002789
		[global::Cpp2ILInjected.Token(Token = "0x17000202")]
		public override bool IsNullable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000849")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB64A4", Offset = "0x1DB64A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0000458C File Offset: 0x0000278C
		[global::Cpp2ILInjected.Token(Token = "0x600084A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB64AC", Offset = "0x1DB64AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public StarNode()
		{
			throw null;
		}
	}
}
