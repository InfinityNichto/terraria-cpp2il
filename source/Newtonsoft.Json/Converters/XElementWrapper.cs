using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Newtonsoft.Json.Converters
{
	[global::Cpp2ILInjected.Token(Token = "0x200011C")]
	internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000223")]
		private XElement Element
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B08")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2E4AC", Offset = "0x1D2E4AC", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XElementWrapper), Member = "SetAttributeNode", MemberParameters = new object[] { typeof(IXmlNode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XElementWrapper), Member = "get_Attributes", ReturnType = typeof(List<IXmlNode>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XElementWrapper), Member = "get_Value", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XElementWrapper), Member = "set_Value", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XElementWrapper), Member = "get_LocalName", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XElementWrapper), Member = "get_NamespaceUri", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XElementWrapper), Member = "GetPrefixOfNamespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XElementWrapper), Member = "get_IsEmpty", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B09")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2D518", Offset = "0x1D2D518", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainerWrapper), Member = ".ctor", MemberParameters = new object[] { typeof(XContainer) }, ReturnType = typeof(void))]
		public XElementWrapper(XElement element)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2E524", Offset = "0x1D2E524", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XElementWrapper), Member = "get_Element", ReturnType = typeof(XElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainer), Member = "Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetAttributeNode(IXmlNode attribute)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000224")]
		public override List<IXmlNode> Attributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B0B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2E5B8", Offset = "0x1D2E5B8", Length = "0x7D0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XElementWrapper), Member = "get_Element", ReturnType = typeof(XElement))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XElement), Member = "Attributes", ReturnType = typeof(IEnumerable<XAttribute>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XAttributeWrapper), Member = ".ctor", MemberParameters = new object[] { typeof(XAttribute) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XElementWrapper), Member = "GetPrefixOfNamespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XName), Member = "op_Implicit", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XName))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XAttribute), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(XName),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Insert", MemberParameters = new object[]
			{
				typeof(int),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2EDC0", Offset = "0x1D2EDC0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainerWrapper), Member = "AppendChild", MemberParameters = new object[] { typeof(IXmlNode) }, ReturnType = typeof(IXmlNode))]
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000225")]
		public override string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B0D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2EDD8", Offset = "0x1D2EDD8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XElementWrapper), Member = "get_Element", ReturnType = typeof(XElement))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XElement), Member = "get_Value", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B0E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2EDEC", Offset = "0x1D2EDEC", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XElementWrapper), Member = "get_Element", ReturnType = typeof(XElement))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XElement), Member = "set_Value", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000226")]
		public override string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B0F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2EE08", Offset = "0x1D2EE08", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XElementWrapper), Member = "get_Element", ReturnType = typeof(XElement))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000227")]
		public override string NamespaceUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B10")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2EE20", Offset = "0x1D2EE20", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XElementWrapper), Member = "get_Element", ReturnType = typeof(XElement))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XName), Member = "get_NamespaceName", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B11")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2ED88", Offset = "0x1D2ED88", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XElementWrapper), Member = "get_Attributes", ReturnType = typeof(List<IXmlNode>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XElementWrapper), Member = "get_Element", ReturnType = typeof(XElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNamespace), Member = "op_Implicit", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XNamespace))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XElement), Member = "GetPrefixOfNamespace", MemberParameters = new object[] { typeof(XNamespace) }, ReturnType = typeof(string))]
		public string GetPrefixOfNamespace(string namespaceUri)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000228")]
		public bool IsEmpty
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B12")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2EE38", Offset = "0x1D2EE38", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XElementWrapper), Member = "get_Element", ReturnType = typeof(XElement))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XElement), Member = "get_IsEmpty", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000419")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<IXmlNode> _attributes;
	}
}
