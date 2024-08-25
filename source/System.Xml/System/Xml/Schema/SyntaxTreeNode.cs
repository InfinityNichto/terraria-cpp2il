using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x20000C8")]
	internal abstract class SyntaxTreeNode
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000821")]
		public abstract void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions);

		[global::Cpp2ILInjected.Token(Token = "0x6000822")]
		public abstract void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos);

		[global::Cpp2ILInjected.Token(Token = "0x170001F7")]
		public abstract bool IsNullable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000823")]
			get;
		}

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
