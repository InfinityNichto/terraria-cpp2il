using System;
using System.ComponentModel;
using System.Xml.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x200013D")]
	public class XmlSchemaAnyAttribute : XmlSchemaAnnotated
	{
		[DefaultValue(/*Failed to decode CustomAttribute blob!*/)]
		[XmlAttribute("processContents")]
		[global::Cpp2ILInjected.Token(Token = "0x17000310")]
		public XmlSchemaContentProcessing ProcessContents
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ABE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCD2B8", Offset = "0x1DCD2B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ABF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCD2C0", Offset = "0x1DCD2C0", Length = "0x7C")]
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

		[global::Cpp2ILInjected.Token(Token = "0x6000AC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCD33C", Offset = "0x1DCD33C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public XmlSchemaAnyAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000572")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string ns;

		[global::Cpp2ILInjected.Token(Token = "0x4000573")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XmlSchemaContentProcessing processContents;

		[global::Cpp2ILInjected.Token(Token = "0x4000574")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private NamespaceList namespaceList;
	}
}
