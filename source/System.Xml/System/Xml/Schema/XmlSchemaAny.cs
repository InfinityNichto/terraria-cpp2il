using System;
using System.ComponentModel;
using System.Xml.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x200013C")]
	public class XmlSchemaAny : XmlSchemaParticle
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6000ABD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCD1F0", Offset = "0x1DCD1F0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new object[] { typeof(XmlSchemaContentProcessing) }, ReturnType = typeof(XmlSchemaComplexType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XmlSchemaAny()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400056F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string ns;

		[global::Cpp2ILInjected.Token(Token = "0x4000570")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private XmlSchemaContentProcessing processContents;

		[global::Cpp2ILInjected.Token(Token = "0x4000571")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private NamespaceList namespaceList;
	}
}
