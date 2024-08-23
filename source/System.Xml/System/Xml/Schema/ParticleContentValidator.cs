using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000A9 RID: 169
	[global::Cpp2ILInjected.Token(Token = "0x20000D4")]
	internal sealed class ParticleContentValidator : ContentValidator
	{
		// Token: 0x060007C5 RID: 1989 RVA: 0x000045AA File Offset: 0x000027AA
		[global::Cpp2ILInjected.Token(Token = "0x6000854")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB6660", Offset = "0x1DB6660", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new object[] { typeof(XmlSchemaContentProcessing) }, ReturnType = typeof(XmlSchemaComplexType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public ParticleContentValidator(XmlSchemaContentType contentType)
		{
			throw null;
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x000045AD File Offset: 0x000027AD
		[global::Cpp2ILInjected.Token(Token = "0x6000855")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB6668", Offset = "0x1DB6668", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ParticleContentValidator(XmlSchemaContentType contentType, bool enableUpaCheck)
		{
			throw null;
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x000045B0 File Offset: 0x000027B0
		[global::Cpp2ILInjected.Token(Token = "0x6000856")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB66E4", Offset = "0x1DB66E4", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new object[] { typeof(XmlSchemaContentProcessing) }, ReturnType = typeof(XmlSchemaComplexType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymbolsDictionary), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Positions), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Start()
		{
			throw null;
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x000045B3 File Offset: 0x000027B3
		[global::Cpp2ILInjected.Token(Token = "0x6000857")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB6794", Offset = "0x1DB6794", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new object[] { typeof(XmlSchemaContentProcessing) }, ReturnType = typeof(XmlSchemaComplexType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void OpenGroup()
		{
			throw null;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x000045B6 File Offset: 0x000027B6
		[global::Cpp2ILInjected.Token(Token = "0x6000858")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB67AC", Offset = "0x1DB67AC", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new object[] { typeof(XmlSchemaContentProcessing) }, ReturnType = typeof(XmlSchemaComplexType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void CloseGroup()
		{
			throw null;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x000045B9 File Offset: 0x000027B9
		[global::Cpp2ILInjected.Token(Token = "0x6000859")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB68E8", Offset = "0x1DB68E8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool Exists(XmlQualifiedName name)
		{
			throw null;
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x000045BC File Offset: 0x000027BC
		[global::Cpp2ILInjected.Token(Token = "0x600085A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB6914", Offset = "0x1DB6914", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymbolsDictionary), Member = "AddName", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Positions), Member = "Add", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void AddName(XmlQualifiedName name, object particle)
		{
			throw null;
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x000045BF File Offset: 0x000027BF
		[global::Cpp2ILInjected.Token(Token = "0x600085B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB6A78", Offset = "0x1DB6A78", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new object[] { typeof(XmlSchemaContentProcessing) }, ReturnType = typeof(XmlSchemaComplexType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymbolsDictionary), Member = "AddNamespaceList", MemberParameters = new object[]
		{
			typeof(NamespaceList),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "AddLeafNode", MemberParameters = new object[] { typeof(SyntaxTreeNode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void AddNamespaceList(NamespaceList namespaceList, object particle)
		{
			throw null;
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x000045C2 File Offset: 0x000027C2
		[global::Cpp2ILInjected.Token(Token = "0x600085C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB69AC", Offset = "0x1DB69AC", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "AddNamespaceList", MemberParameters = new object[]
		{
			typeof(NamespaceList),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void AddLeafNode(SyntaxTreeNode node)
		{
			throw null;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x000045C5 File Offset: 0x000027C5
		[global::Cpp2ILInjected.Token(Token = "0x600085D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB6AFC", Offset = "0x1DB6AFC", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddChoice()
		{
			throw null;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x000045C8 File Offset: 0x000027C8
		[global::Cpp2ILInjected.Token(Token = "0x600085E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB6BCC", Offset = "0x1DB6BCC", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddSequence()
		{
			throw null;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x000045CB File Offset: 0x000027CB
		[global::Cpp2ILInjected.Token(Token = "0x600085F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB6C9C", Offset = "0x1DB6C9C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseHowMany", MemberParameters = new object[] { typeof(ParticleContentValidator) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new object[] { typeof(XmlSchemaContentProcessing) }, ReturnType = typeof(XmlSchemaComplexType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void AddStar()
		{
			throw null;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x000045CE File Offset: 0x000027CE
		[global::Cpp2ILInjected.Token(Token = "0x6000860")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB6E24", Offset = "0x1DB6E24", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseHowMany", MemberParameters = new object[] { typeof(ParticleContentValidator) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "Closure", MemberParameters = new object[] { typeof(InteriorNode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void AddPlus()
		{
			throw null;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x000045D1 File Offset: 0x000027D1
		[global::Cpp2ILInjected.Token(Token = "0x6000861")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB6E80", Offset = "0x1DB6E80", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseHowMany", MemberParameters = new object[] { typeof(ParticleContentValidator) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "Closure", MemberParameters = new object[] { typeof(InteriorNode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void AddQMark()
		{
			throw null;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x000045D4 File Offset: 0x000027D4
		[global::Cpp2ILInjected.Token(Token = "0x6000862")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB6CF8", Offset = "0x1DB6CF8", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "AddPlus", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "AddQMark", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void Closure(InteriorNode node)
		{
			throw null;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x000045D7 File Offset: 0x000027D7
		[global::Cpp2ILInjected.Token(Token = "0x6000863")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB6EDC", Offset = "0x1DB6EDC", Length = "0x4E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new object[] { typeof(XmlSchemaContentProcessing) }, ReturnType = typeof(XmlSchemaComplexType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymbolsDictionary), Member = "AddName", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Positions), Member = "Add", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet[]),
			typeof(ref BitSet)
		}, ReturnType = typeof(BitSet[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "GetApplicableMinMaxFollowPos", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(BitSet))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "CheckCMUPAWithLeafRangeNodes", MemberParameters = new object[] { typeof(BitSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RangeContentValidator), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet[]),
			typeof(SymbolsDictionary),
			typeof(Positions),
			typeof(int),
			typeof(XmlSchemaContentType),
			typeof(bool),
			typeof(BitSet),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "BuildTransitionTable", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet[]),
			typeof(int)
		}, ReturnType = typeof(int[][]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "CheckUniqueParticleAttribution", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NfaContentValidator), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet[]),
			typeof(SymbolsDictionary),
			typeof(Positions),
			typeof(int),
			typeof(XmlSchemaContentType),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DfaContentValidator), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int[][]),
			typeof(SymbolsDictionary),
			typeof(XmlSchemaContentType),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public ContentValidator Finish(bool useDFA)
		{
			throw null;
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x000045DA File Offset: 0x000027DA
		[global::Cpp2ILInjected.Token(Token = "0x6000864")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB73BC", Offset = "0x1DB73BC", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ContentValidator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Positions), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Position))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "Or", MemberParameters = new object[] { typeof(BitSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "NextSet", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "EnsureLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, out BitSet posWithRangeTerminals)
		{
			throw null;
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000045DD File Offset: 0x000027DD
		[global::Cpp2ILInjected.Token(Token = "0x6000865")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB77BC", Offset = "0x1DB77BC", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ContentValidator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "NextSet", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Positions), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Position))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UpaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void CheckCMUPAWithLeafRangeNodes(BitSet curpos)
		{
			throw null;
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x000045E0 File Offset: 0x000027E0
		[global::Cpp2ILInjected.Token(Token = "0x6000866")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB7680", Offset = "0x1DB7680", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ContentValidator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "Intersects", MemberParameters = new object[] { typeof(BitSet) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "Or", MemberParameters = new object[] { typeof(BitSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "And", MemberParameters = new object[] { typeof(BitSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "Clone", ReturnType = typeof(BitSet))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "NextSet", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Positions), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Position))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos)
		{
			throw null;
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000045E3 File Offset: 0x000027E3
		[global::Cpp2ILInjected.Token(Token = "0x6000867")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB79A0", Offset = "0x1DB79A0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ContentValidator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "CheckUniqueParticleAttribution", MemberParameters = new object[] { typeof(BitSet) }, ReturnType = typeof(void))]
		private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos)
		{
			throw null;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x000045E6 File Offset: 0x000027E6
		[global::Cpp2ILInjected.Token(Token = "0x6000868")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB80C8", Offset = "0x1DB80C8", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "CheckUniqueParticleAttribution", MemberParameters = new object[]
		{
			typeof(BitSet),
			typeof(BitSet[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "NextSet", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Positions), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Position))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UpaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void CheckUniqueParticleAttribution(BitSet curpos)
		{
			throw null;
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x000045E9 File Offset: 0x000027E9
		[global::Cpp2ILInjected.Token(Token = "0x6000869")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB7A18", Offset = "0x1DB7A18", Length = "0x554")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ContentValidator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "NextSet", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Positions), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Position))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitSet), Member = "Or", MemberParameters = new object[] { typeof(BitSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		private int[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos)
		{
			throw null;
		}

		// Token: 0x040002C0 RID: 704
		[global::Cpp2ILInjected.Token(Token = "0x4000437")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private SymbolsDictionary symbols;

		// Token: 0x040002C1 RID: 705
		[global::Cpp2ILInjected.Token(Token = "0x4000438")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Positions positions;

		// Token: 0x040002C2 RID: 706
		[global::Cpp2ILInjected.Token(Token = "0x4000439")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Stack stack;

		// Token: 0x040002C3 RID: 707
		[global::Cpp2ILInjected.Token(Token = "0x400043A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private SyntaxTreeNode contentNode;

		// Token: 0x040002C4 RID: 708
		[global::Cpp2ILInjected.Token(Token = "0x400043B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool isPartial;

		// Token: 0x040002C5 RID: 709
		[global::Cpp2ILInjected.Token(Token = "0x400043C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private int minMaxNodesCount;

		// Token: 0x040002C6 RID: 710
		[global::Cpp2ILInjected.Token(Token = "0x400043D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool enableUpaCheck;
	}
}
