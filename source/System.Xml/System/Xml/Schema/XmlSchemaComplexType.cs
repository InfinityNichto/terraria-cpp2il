using System;
using System.ComponentModel;
using System.Xml.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x0200010F RID: 271
	[global::Cpp2ILInjected.Token(Token = "0x2000141")]
	public class XmlSchemaComplexType : XmlSchemaType
	{
		// Token: 0x06000A29 RID: 2601 RVA: 0x00004CB8 File Offset: 0x00002EB8
		[global::Cpp2ILInjected.Token(Token = "0x6000AC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCD36C", Offset = "0x1DCD36C", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new object[] { typeof(XmlSchemaContentProcessing) }, ReturnType = typeof(XmlSchemaComplexType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaComplexType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaElementDecl), Member = "CreateAnyTypeElementDecl", ReturnType = typeof(SchemaElementDecl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaComplexType), Member = "get_AnyTypeContentValidator", ReturnType = typeof(ContentValidator))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		static XmlSchemaComplexType()
		{
			throw null;
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00004CBB File Offset: 0x00002EBB
		[global::Cpp2ILInjected.Token(Token = "0x6000AC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCD500", Offset = "0x1DCD500", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaComplexType), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaComplexType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaAny), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaParticle), Member = "set_MinOccurs", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaParticle), Member = "set_MaxOccurs", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaAny), Member = "BuildNamespaceList", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaSequence), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new object[] { typeof(XmlSchemaObject) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaElementDecl), Member = "CreateAnyTypeElementDecl", ReturnType = typeof(SchemaElementDecl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaContentType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "OpenGroup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "AddNamespaceList", MemberParameters = new object[]
		{
			typeof(NamespaceList),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "AddStar", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "CloseGroup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ContentValidator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaAnyAttribute), Member = "BuildNamespaceList", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents)
		{
			throw null;
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00004CBE File Offset: 0x00002EBE
		[global::Cpp2ILInjected.Token(Token = "0x6000AC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCD7C4", Offset = "0x1DCD7C4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaComplexType), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new object[] { typeof(XmlSchemaContentProcessing) }, ReturnType = typeof(XmlSchemaComplexType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XmlSchemaComplexType()
		{
			throw null;
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00004CC1 File Offset: 0x00002EC1
		[XmlIgnore]
		[global::Cpp2ILInjected.Token(Token = "0x17000312")]
		internal static XmlSchemaComplexType AnyType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AC6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCDD04", Offset = "0x1DCDD04", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x00004CC4 File Offset: 0x00002EC4
		[global::Cpp2ILInjected.Token(Token = "0x17000313")]
		internal static ContentValidator AnyTypeContentValidator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AC7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCD890", Offset = "0x1DCD890", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaComplexType), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002EE RID: 750
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x00004CC7 File Offset: 0x00002EC7
		[XmlAttribute("mixed")]
		[DefaultValue(false)]
		[global::Cpp2ILInjected.Token(Token = "0x17000314")]
		public override bool IsMixed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AC8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCDD5C", Offset = "0x1DCDD5C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x00004CCA File Offset: 0x00002ECA
		[XmlIgnore]
		[global::Cpp2ILInjected.Token(Token = "0x17000315")]
		public XmlSchemaParticle ContentTypeParticle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AC9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCDD78", Offset = "0x1DCDD78", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00004CCD File Offset: 0x00002ECD
		[global::Cpp2ILInjected.Token(Token = "0x6000ACA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCDD80", Offset = "0x1DCDD80", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetContentTypeParticle(XmlSchemaParticle value)
		{
			throw null;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00004CD0 File Offset: 0x00002ED0
		[global::Cpp2ILInjected.Token(Token = "0x6000ACB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCDD88", Offset = "0x1DCDD88", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetAttributeWildcard(XmlSchemaAnyAttribute value)
		{
			throw null;
		}

		// Token: 0x040003E8 RID: 1000
		[global::Cpp2ILInjected.Token(Token = "0x4000577")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private XmlSchemaDerivationMethod block;

		// Token: 0x040003E9 RID: 1001
		[global::Cpp2ILInjected.Token(Token = "0x4000578")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private XmlSchemaParticle contentTypeParticle;

		// Token: 0x040003EA RID: 1002
		[global::Cpp2ILInjected.Token(Token = "0x4000579")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private XmlSchemaAnyAttribute attributeWildcard;

		// Token: 0x040003EB RID: 1003
		[global::Cpp2ILInjected.Token(Token = "0x400057A")]
		private static XmlSchemaComplexType anyTypeLax;

		// Token: 0x040003EC RID: 1004
		[global::Cpp2ILInjected.Token(Token = "0x400057B")]
		private static XmlSchemaComplexType anyTypeSkip;

		// Token: 0x040003ED RID: 1005
		[global::Cpp2ILInjected.Token(Token = "0x400057C")]
		private static XmlSchemaComplexType untypedAnyType;

		// Token: 0x040003EE RID: 1006
		[global::Cpp2ILInjected.Token(Token = "0x400057D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private byte pvFlags;
	}
}
