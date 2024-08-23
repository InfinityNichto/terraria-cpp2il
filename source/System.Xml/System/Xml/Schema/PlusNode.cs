using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000A4 RID: 164
	[global::Cpp2ILInjected.Token(Token = "0x20000CF")]
	internal sealed class PlusNode : InteriorNode
	{
		// Token: 0x060007B3 RID: 1971 RVA: 0x00004574 File Offset: 0x00002774
		[global::Cpp2ILInjected.Token(Token = "0x6000842")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB637C", Offset = "0x1DB637C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "NextSet", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "Or", MemberParameters = new object[] { typeof(BitSet) }, ReturnType = typeof(void))]
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
			throw null;
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x00004577 File Offset: 0x00002777
		[global::Cpp2ILInjected.Token(Token = "0x17000200")]
		public override bool IsNullable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000843")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB63F4", Offset = "0x1DB63F4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0000457A File Offset: 0x0000277A
		[global::Cpp2ILInjected.Token(Token = "0x6000844")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB6404", Offset = "0x1DB6404", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PlusNode()
		{
			throw null;
		}
	}
}
