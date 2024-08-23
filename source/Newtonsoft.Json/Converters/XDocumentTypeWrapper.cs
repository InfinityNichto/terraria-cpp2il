using System;
using System.Xml.Linq;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000CD RID: 205
	[global::Cpp2ILInjected.Token(Token = "0x2000114")]
	internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode
	{
		// Token: 0x0600098D RID: 2445 RVA: 0x00003C26 File Offset: 0x00001E26
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

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x00003C29 File Offset: 0x00001E29
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

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x00003C2C File Offset: 0x00001E2C
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

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x00003C2F File Offset: 0x00001E2F
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

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x00003C32 File Offset: 0x00001E32
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

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x00003C35 File Offset: 0x00001E35
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

		// Token: 0x040002FB RID: 763
		[global::Cpp2ILInjected.Token(Token = "0x4000415")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly XDocumentType _documentType;
	}
}
