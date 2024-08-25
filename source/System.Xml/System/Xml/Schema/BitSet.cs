using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x20000C3")]
	internal sealed class BitSet
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000801")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3E6C", Offset = "0x1DB3E6C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private BitSet()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000802")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3E74", Offset = "0x1DB3E74", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SequenceNode), Member = "ConstructPos", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChoiceNode), Member = "ConstructChildPos", MemberParameters = new object[]
		{
			typeof(SyntaxTreeNode),
			typeof(BitSet),
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChoiceNode), Member = "ConstructPos", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ContentValidator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet[]),
			typeof(ref BitSet)
		}, ReturnType = typeof(BitSet[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "GetApplicableMinMaxFollowPos", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(BitSet))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "BuildTransitionTable", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet[]),
			typeof(int)
		}, ReturnType = typeof(int[][]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BitSet(int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001F1")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000803")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB3EEC", Offset = "0x1DB3EEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001F2")]
		public bool this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000804")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB3EF4", Offset = "0x1DB3EF4", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000805")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3F6C", Offset = "0x1DB3F6C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000806")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3FB0", Offset = "0x1DB3FB0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "EnsureLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public void Set(int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000807")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3F30", Offset = "0x1DB3F30", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Get(int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000808")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB407C", Offset = "0x1DB407C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SequenceNode), Member = "ConstructPos", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlusNode), Member = "ConstructPos", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StarNode), Member = "ConstructPos", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet[]),
			typeof(ref BitSet)
		}, ReturnType = typeof(BitSet[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "CheckCMUPAWithLeafRangeNodes", MemberParameters = new object[] { typeof(BitSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "GetApplicableMinMaxFollowPos", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(BitSet))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "CheckUniqueParticleAttribution", MemberParameters = new object[] { typeof(BitSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "BuildTransitionTable", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet[]),
			typeof(int)
		}, ReturnType = typeof(int[][]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		public int NextSet(int startFrom)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000809")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB40F8", Offset = "0x1DB40F8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "GetApplicableMinMaxFollowPos", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(BitSet))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void And(BitSet other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600080A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB4170", Offset = "0x1DB4170", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SequenceNode), Member = "ConstructPos", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChoiceNode), Member = "ConstructChildPos", MemberParameters = new object[]
		{
			typeof(SyntaxTreeNode),
			typeof(BitSet),
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChoiceNode), Member = "ConstructPos", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlusNode), Member = "ConstructPos", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StarNode), Member = "ConstructPos", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet[]),
			typeof(ref BitSet)
		}, ReturnType = typeof(BitSet[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "GetApplicableMinMaxFollowPos", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(BitSet))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "BuildTransitionTable", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet[]),
			typeof(int)
		}, ReturnType = typeof(int[][]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "EnsureLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public void Or(BitSet other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600080B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB41E0", Offset = "0x1DB41E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600080C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB41E8", Offset = "0x1DB41E8", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600080D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB430C", Offset = "0x1DB430C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SequenceNode), Member = "ConstructPos", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "GetApplicableMinMaxFollowPos", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(BitSet))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public BitSet Clone()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600080E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB43D4", Offset = "0x1DB43D4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "GetApplicableMinMaxFollowPos", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(BitSet))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Intersects(BitSet other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600080F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3EE4", Offset = "0x1DB3EE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int Subscript(int bitIndex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000810")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3FF4", Offset = "0x1DB3FF4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BitSet), Member = "Set", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BitSet), Member = "Or", MemberParameters = new object[] { typeof(BitSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LeafNode), Member = "ConstructPos", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet[]),
			typeof(ref BitSet)
		}, ReturnType = typeof(BitSet[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void EnsureLength(int nRequiredLength)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000416")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int count;

		[global::Cpp2ILInjected.Token(Token = "0x4000417")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private uint[] bits;
	}
}
