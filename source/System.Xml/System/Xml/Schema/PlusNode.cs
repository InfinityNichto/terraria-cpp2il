using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x20000CF")]
	internal sealed class PlusNode : InteriorNode
	{
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
