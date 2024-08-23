using System;
using System.Xml;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000C4 RID: 196
	[global::Cpp2ILInjected.Token(Token = "0x200010B")]
	internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode
	{
		// Token: 0x06000949 RID: 2377 RVA: 0x00003BC3 File Offset: 0x00001DC3
		[global::Cpp2ILInjected.Token(Token = "0x6000A85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2B70C", Offset = "0x1D2B70C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public XmlDeclarationWrapper(XmlDeclaration declaration)
		{
			throw null;
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x00003BC6 File Offset: 0x00001DC6
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

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x00003BC9 File Offset: 0x00001DC9
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x00003BCC File Offset: 0x00001DCC
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

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x00003BCF File Offset: 0x00001DCF
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x00003BD2 File Offset: 0x00001DD2
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

		// Token: 0x040002F5 RID: 757
		[global::Cpp2ILInjected.Token(Token = "0x400040F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly XmlDeclaration _declaration;
	}
}
