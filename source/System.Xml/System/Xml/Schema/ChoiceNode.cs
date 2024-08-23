using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000A3 RID: 163
	[global::Cpp2ILInjected.Token(Token = "0x20000CE")]
	internal sealed class ChoiceNode : InteriorNode
	{
		// Token: 0x060007AE RID: 1966 RVA: 0x00004565 File Offset: 0x00002765
		[global::Cpp2ILInjected.Token(Token = "0x600083D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB6140", Offset = "0x1DB6140", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChoiceNode), Member = "ConstructPos", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "Or", MemberParameters = new object[] { typeof(BitSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void ConstructChildPos(SyntaxTreeNode child, BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
			throw null;
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00004568 File Offset: 0x00002768
		[global::Cpp2ILInjected.Token(Token = "0x600083E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB61FC", Offset = "0x1DB61FC", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChoiceNode), Member = "ConstructChildPos", MemberParameters = new object[]
		{
			typeof(SyntaxTreeNode),
			typeof(BitSet),
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "Or", MemberParameters = new object[] { typeof(BitSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
			throw null;
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x0000456B File Offset: 0x0000276B
		[global::Cpp2ILInjected.Token(Token = "0x170001FF")]
		public override bool IsNullable
		{
			[global::Cpp2ILInjected.Token(Token = "0x600083F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB62F8", Offset = "0x1DB62F8", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0000456E File Offset: 0x0000276E
		[global::Cpp2ILInjected.Token(Token = "0x6000840")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB6378", Offset = "0x1DB6378", Length = "0x4")]
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

		// Token: 0x060007B2 RID: 1970 RVA: 0x00004571 File Offset: 0x00002771
		[global::Cpp2ILInjected.Token(Token = "0x6000841")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB5A08", Offset = "0x1DB5A08", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ChoiceNode()
		{
			throw null;
		}
	}
}
