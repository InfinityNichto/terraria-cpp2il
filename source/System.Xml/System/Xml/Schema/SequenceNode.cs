using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000A2 RID: 162
	[global::Cpp2ILInjected.Token(Token = "0x20000CC")]
	internal sealed class SequenceNode : InteriorNode
	{
		// Token: 0x060007AA RID: 1962 RVA: 0x00004559 File Offset: 0x00002759
		[global::Cpp2ILInjected.Token(Token = "0x6000838")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB5CEC", Offset = "0x1DB5CEC", Length = "0x2F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack<SequenceNode.SequenceConstructPosContext>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack<SequenceNode.SequenceConstructPosContext>), Member = "Push", MemberParameters = new object[] { typeof(SequenceNode.SequenceConstructPosContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "Or", MemberParameters = new object[] { typeof(BitSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "NextSet", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "Clone", ReturnType = typeof(BitSet))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack<SequenceNode.SequenceConstructPosContext>), Member = "Pop", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
			throw null;
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x0000455C File Offset: 0x0000275C
		[global::Cpp2ILInjected.Token(Token = "0x170001FE")]
		public override bool IsNullable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000839")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB5FF0", Offset = "0x1DB5FF0", Length = "0x144")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(decimal),
				typeof(decimal)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0000455F File Offset: 0x0000275F
		[global::Cpp2ILInjected.Token(Token = "0x600083A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB6134", Offset = "0x1DB6134", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InteriorNode), Member = "ExpandTreeNoRecursive", MemberParameters = new object[]
		{
			typeof(InteriorNode),
			typeof(SymbolsDictionary),
			typeof(Positions)
		}, ReturnType = typeof(void))]
		public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
			throw null;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00004562 File Offset: 0x00002762
		[global::Cpp2ILInjected.Token(Token = "0x600083B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB6138", Offset = "0x1DB6138", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SequenceNode()
		{
			throw null;
		}

		// Token: 0x02000170 RID: 368
		[global::Cpp2ILInjected.Token(Token = "0x20000CD")]
		private struct SequenceConstructPosContext
		{
			// Token: 0x06000CC1 RID: 3265 RVA: 0x0000539F File Offset: 0x0000359F
			[global::Cpp2ILInjected.Token(Token = "0x600083C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB5FE0", Offset = "0x1DB5FE0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public SequenceConstructPosContext(SequenceNode node, BitSet firstpos, BitSet lastpos)
			{
				throw null;
			}

			// Token: 0x04000660 RID: 1632
			[global::Cpp2ILInjected.Token(Token = "0x4000428")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public SequenceNode this_;

			// Token: 0x04000661 RID: 1633
			[global::Cpp2ILInjected.Token(Token = "0x4000429")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public BitSet firstpos;

			// Token: 0x04000662 RID: 1634
			[global::Cpp2ILInjected.Token(Token = "0x400042A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public BitSet lastpos;

			// Token: 0x04000663 RID: 1635
			[global::Cpp2ILInjected.Token(Token = "0x400042B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public BitSet lastposLeft;

			// Token: 0x04000664 RID: 1636
			[global::Cpp2ILInjected.Token(Token = "0x400042C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public BitSet firstposRight;
		}
	}
}
