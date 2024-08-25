using System;
using System.Xml;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Newtonsoft.Json.Converters
{
	[global::Cpp2ILInjected.Token(Token = "0x200010A")]
	internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A81")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2B920", Offset = "0x1D2B920", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public XmlElementWrapper(XmlElement element)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2BBB4", Offset = "0x1D2BBB4", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void SetAttributeNode(IXmlNode attribute)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2BC94", Offset = "0x1D2BC94", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string GetPrefixOfNamespace(string namespaceUri)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001DB")]
		public bool IsEmpty
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A84")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2BCA8", Offset = "0x1D2BCA8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlElement), Member = "get_IsEmpty", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x400040E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly XmlElement _element;
	}
}
