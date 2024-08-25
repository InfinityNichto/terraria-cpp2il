using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Newtonsoft.Json.Converters
{
	[global::Cpp2ILInjected.Token(Token = "0x2000113")]
	internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode
	{
		[global::Cpp2ILInjected.Token(Token = "0x170001FD")]
		internal XDeclaration Declaration
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000AC0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2C7D8", Offset = "0x1D2C7D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000AC1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2C7E0", Offset = "0x1D2C7E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000AC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2C7E8", Offset = "0x1D2C7E8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDocumentWrapper), Member = "get_ChildNodes", ReturnType = typeof(List<IXmlNode>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDocumentWrapper), Member = "CreateXmlDeclaration", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XDeclarationWrapper(XDeclaration declaration)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001FE")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AC3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2C87C", Offset = "0x1D2C87C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001FF")]
		public string Version
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AC4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2C884", Offset = "0x1D2C884", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000200")]
		public string Encoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AC5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2C890", Offset = "0x1D2C890", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000AC6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2C89C", Offset = "0x1D2C89C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000201")]
		public string Standalone
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AC7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2C8A8", Offset = "0x1D2C8A8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000AC8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2C8B4", Offset = "0x1D2C8B4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000414")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XDeclaration <Declaration>k__BackingField;
	}
}
