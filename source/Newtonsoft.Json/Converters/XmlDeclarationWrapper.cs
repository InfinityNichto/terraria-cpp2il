using System;
using System.Xml;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Newtonsoft.Json.Converters
{
	[global::Cpp2ILInjected.Token(Token = "0x200010B")]
	internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2B70C", Offset = "0x1D2B70C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public XmlDeclarationWrapper(XmlDeclaration declaration)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001DC")]
		public string Version
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A86")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2BCB4", Offset = "0x1D2BCB4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001DD")]
		public string Encoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A87")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2BCC0", Offset = "0x1D2BCC0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A88")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2BCCC", Offset = "0x1D2BCCC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDeclaration), Member = "set_Encoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001DE")]
		public string Standalone
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A89")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2BCD8", Offset = "0x1D2BCD8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A8A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2BCE4", Offset = "0x1D2BCE4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDeclaration), Member = "set_Standalone", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x400040F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly XmlDeclaration _declaration;
	}
}
