using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x0200009F RID: 159
	[global::Cpp2ILInjected.Token(Token = "0x20000C9")]
	internal class LeafNode : SyntaxTreeNode
	{
		// Token: 0x06000798 RID: 1944 RVA: 0x00004523 File Offset: 0x00002723
		[global::Cpp2ILInjected.Token(Token = "0x6000826")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB54C8", Offset = "0x1DB54C8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LeafNode(int pos)
		{
			throw null;
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00004526 File Offset: 0x00002726
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x00004529 File Offset: 0x00002729
		[global::Cpp2ILInjected.Token(Token = "0x170001F9")]
		public int Pos
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000827")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB54F0", Offset = "0x1DB54F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000828")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB54F8", Offset = "0x1DB54F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0000452C File Offset: 0x0000272C
		[global::Cpp2ILInjected.Token(Token = "0x6000829")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB5500", Offset = "0x1DB5500", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
			throw null;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0000452F File Offset: 0x0000272F
		[global::Cpp2ILInjected.Token(Token = "0x600082A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB5504", Offset = "0x1DB5504", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "EnsureLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
			throw null;
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x00004532 File Offset: 0x00002732
		[global::Cpp2ILInjected.Token(Token = "0x170001FA")]
		public override bool IsNullable
		{
			[global::Cpp2ILInjected.Token(Token = "0x600082B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB5588", Offset = "0x1DB5588", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040002B1 RID: 689
		[global::Cpp2ILInjected.Token(Token = "0x4000423")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int pos;
	}
}
