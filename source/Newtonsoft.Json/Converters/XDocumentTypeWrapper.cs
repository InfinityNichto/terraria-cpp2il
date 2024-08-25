using System;
using System.Xml.Linq;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Newtonsoft.Json.Converters
{
	[global::Cpp2ILInjected.Token(Token = "0x2000114")]
	internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000AC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2C8C0", Offset = "0x1D2C8C0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDocumentWrapper), Member = "CreateXmlDocumentType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainerWrapper), Member = "WrapNode", MemberParameters = new object[] { typeof(XObject) }, ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XDocumentTypeWrapper(XDocumentType documentType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000202")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ACA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2C92C", Offset = "0x1D2C92C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000203")]
		public string System
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ACB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2C938", Offset = "0x1D2C938", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000204")]
		public string Public
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ACC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2C944", Offset = "0x1D2C944", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000205")]
		public string InternalSubset
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ACD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2C950", Offset = "0x1D2C950", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000206")]
		public override string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ACE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2C95C", Offset = "0x1D2C95C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000415")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly XDocumentType _documentType;
	}
}
