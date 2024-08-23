using System;
using System.ComponentModel;
using System.Xml.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x0200010A RID: 266
	[global::Cpp2ILInjected.Token(Token = "0x200013C")]
	public class XmlSchemaAny : XmlSchemaParticle
	{
		// Token: 0x170002E8 RID: 744
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x00004C9D File Offset: 0x00002E9D
		[XmlAttribute("processContents")]
		[DefaultValue(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x1700030E")]
		public XmlSchemaContentProcessing ProcessContents
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ABA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCD164", Offset = "0x1DCD164", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00004CA0 File Offset: 0x00002EA0
		[XmlIgnore]
		[global::Cpp2ILInjected.Token(Token = "0x1700030F")]
		internal NamespaceList NamespaceList
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ABB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCD16C", Offset = "0x1DCD16C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00004CA3 File Offset: 0x00002EA3
		[global::Cpp2ILInjected.Token(Token = "0x6000ABC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCD174", Offset = "0x1DCD174", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new object[] { typeof(XmlSchemaContentProcessing) }, ReturnType = typeof(XmlSchemaComplexType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NamespaceList), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void BuildNamespaceList(string targetNamespace)
		{
			throw null;
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00004CA6 File Offset: 0x00002EA6
		[global::Cpp2ILInjected.Token(Token = "0x6000ABD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCD1F0", Offset = "0x1DCD1F0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new object[] { typeof(XmlSchemaContentProcessing) }, ReturnType = typeof(XmlSchemaComplexType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XmlSchemaAny()
		{
			throw null;
		}

		// Token: 0x040003E0 RID: 992
		[global::Cpp2ILInjected.Token(Token = "0x400056F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string ns;

		// Token: 0x040003E1 RID: 993
		[global::Cpp2ILInjected.Token(Token = "0x4000570")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private XmlSchemaContentProcessing processContents;

		// Token: 0x040003E2 RID: 994
		[global::Cpp2ILInjected.Token(Token = "0x4000571")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private NamespaceList namespaceList;
	}
}
