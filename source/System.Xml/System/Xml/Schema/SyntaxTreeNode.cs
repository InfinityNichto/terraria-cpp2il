using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x0200009E RID: 158
	[global::Cpp2ILInjected.Token(Token = "0x20000C8")]
	internal abstract class SyntaxTreeNode
	{
		// Token: 0x06000793 RID: 1939
		[global::Cpp2ILInjected.Token(Token = "0x6000821")]
		public abstract void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions);

		// Token: 0x06000794 RID: 1940
		[global::Cpp2ILInjected.Token(Token = "0x6000822")]
		public abstract void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos);

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000795 RID: 1941
		[global::Cpp2ILInjected.Token(Token = "0x170001F7")]
		public abstract bool IsNullable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000823")]
			get;
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x0000451D File Offset: 0x0000271D
		[global::Cpp2ILInjected.Token(Token = "0x170001F8")]
		public virtual bool IsRangeNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000824")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB54B8", Offset = "0x1DB54B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00004520 File Offset: 0x00002720
		[global::Cpp2ILInjected.Token(Token = "0x6000825")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB54C0", Offset = "0x1DB54C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected SyntaxTreeNode()
		{
			throw null;
		}
	}
}
