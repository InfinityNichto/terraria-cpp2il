using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x20000CB")]
	internal abstract class InteriorNode : SyntaxTreeNode
	{
		[global::Cpp2ILInjected.Token(Token = "0x170001FC")]
		public SyntaxTreeNode LeftChild
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000831")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB5A80", Offset = "0x1DB5A80", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000832")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB5A88", Offset = "0x1DB5A88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001FD")]
		public SyntaxTreeNode RightChild
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000833")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB5A90", Offset = "0x1DB5A90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000834")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB5A98", Offset = "0x1DB5A98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000835")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB5AA0", Offset = "0x1DB5AA0", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SequenceNode), Member = "ExpandTree", MemberParameters = new object[]
		{
			typeof(InteriorNode),
			typeof(SymbolsDictionary),
			typeof(Positions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChoiceNode), Member = "ExpandTree", MemberParameters = new object[]
		{
			typeof(InteriorNode),
			typeof(SymbolsDictionary),
			typeof(Positions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack<>), Member = "Push", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack<>), Member = "Pop", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000836")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB5C88", Offset = "0x1DB5C88", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000837")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB5CE4", Offset = "0x1DB5CE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected InteriorNode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000426")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private SyntaxTreeNode leftChild;

		[global::Cpp2ILInjected.Token(Token = "0x4000427")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private SyntaxTreeNode rightChild;
	}
}
