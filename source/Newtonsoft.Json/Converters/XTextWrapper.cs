using System;
using System.Xml.Linq;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000CF RID: 207
	[global::Cpp2ILInjected.Token(Token = "0x2000116")]
	internal class XTextWrapper : XObjectWrapper
	{
		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x00003C6B File Offset: 0x00001E6B
		[global::Cpp2ILInjected.Token(Token = "0x1700020A")]
		private XText Text
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AE0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2D994", Offset = "0x1D2D994", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XTextWrapper), Member = "get_Value", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XTextWrapper), Member = "set_Value", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XTextWrapper), Member = "get_ParentNode", ReturnType = typeof(IXmlNode))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x00003C6E File Offset: 0x00001E6E
		[global::Cpp2ILInjected.Token(Token = "0x6000AE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2DA0C", Offset = "0x1D2DA0C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainerWrapper), Member = "WrapNode", MemberParameters = new object[] { typeof(XObject) }, ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XTextWrapper(XText text)
		{
			throw null;
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x00003C71 File Offset: 0x00001E71
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x00003C74 File Offset: 0x00001E74
		[global::Cpp2ILInjected.Token(Token = "0x1700020B")]
		public override string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AE2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2DA78", Offset = "0x1D2DA78", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XTextWrapper), Member = "get_Text", ReturnType = typeof(XText))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000AE3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2DA8C", Offset = "0x1D2DA8C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XTextWrapper), Member = "get_Text", ReturnType = typeof(XText))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XText), Member = "set_Value", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x00003C77 File Offset: 0x00001E77
		[global::Cpp2ILInjected.Token(Token = "0x1700020C")]
		public override IXmlNode ParentNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AE4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2DAA8", Offset = "0x1D2DAA8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XTextWrapper), Member = "get_Text", ReturnType = typeof(XText))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XObject), Member = "get_Parent", ReturnType = typeof(XElement))]
			get
			{
				throw null;
			}
		}
	}
}
