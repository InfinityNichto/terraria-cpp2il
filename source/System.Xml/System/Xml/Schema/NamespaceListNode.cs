using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000A0 RID: 160
	[global::Cpp2ILInjected.Token(Token = "0x20000CA")]
	internal class NamespaceListNode : SyntaxTreeNode
	{
		// Token: 0x0600079E RID: 1950 RVA: 0x00004535 File Offset: 0x00002735
		[global::Cpp2ILInjected.Token(Token = "0x600082C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB5590", Offset = "0x1DB5590", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public NamespaceListNode(NamespaceList namespaceList, object particle)
		{
			throw null;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00004538 File Offset: 0x00002738
		[global::Cpp2ILInjected.Token(Token = "0x600082D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB55BC", Offset = "0x1DB55BC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymbolsDictionary), Member = "GetNamespaceListSymbols", MemberParameters = new object[] { typeof(NamespaceList) }, ReturnType = typeof(ICollection))]
		public virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols)
		{
			throw null;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0000453B File Offset: 0x0000273B
		[global::Cpp2ILInjected.Token(Token = "0x600082E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB55CC", Offset = "0x1DB55CC", Length = "0x43C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Positions), Member = "Add", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
			throw null;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x0000453E File Offset: 0x0000273E
		[global::Cpp2ILInjected.Token(Token = "0x600082F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB5A10", Offset = "0x1DB5A10", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
			throw null;
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x00004541 File Offset: 0x00002741
		[global::Cpp2ILInjected.Token(Token = "0x170001FB")]
		public override bool IsNullable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000830")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB5A48", Offset = "0x1DB5A48", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040002B2 RID: 690
		[global::Cpp2ILInjected.Token(Token = "0x4000424")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected NamespaceList namespaceList;

		// Token: 0x040002B3 RID: 691
		[global::Cpp2ILInjected.Token(Token = "0x4000425")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected object particle;
	}
}
