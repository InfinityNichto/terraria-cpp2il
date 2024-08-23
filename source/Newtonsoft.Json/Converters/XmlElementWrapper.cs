using System;
using System.Xml;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000C3 RID: 195
	[global::Cpp2ILInjected.Token(Token = "0x200010A")]
	internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode
	{
		// Token: 0x06000945 RID: 2373 RVA: 0x00003BB7 File Offset: 0x00001DB7
		[global::Cpp2ILInjected.Token(Token = "0x6000A81")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2B920", Offset = "0x1D2B920", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public XmlElementWrapper(XmlElement element)
		{
			throw null;
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00003BBA File Offset: 0x00001DBA
		[global::Cpp2ILInjected.Token(Token = "0x6000A82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2BBB4", Offset = "0x1D2BBB4", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void SetAttributeNode(IXmlNode attribute)
		{
			throw null;
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00003BBD File Offset: 0x00001DBD
		[global::Cpp2ILInjected.Token(Token = "0x6000A83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2BC94", Offset = "0x1D2BC94", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string GetPrefixOfNamespace(string namespaceUri)
		{
			throw null;
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x00003BC0 File Offset: 0x00001DC0
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

		// Token: 0x040002F4 RID: 756
		[global::Cpp2ILInjected.Token(Token = "0x400040E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly XmlElement _element;
	}
}
