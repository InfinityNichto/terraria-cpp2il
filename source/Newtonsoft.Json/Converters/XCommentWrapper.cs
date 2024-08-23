using System;
using System.Xml.Linq;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000D0 RID: 208
	[global::Cpp2ILInjected.Token(Token = "0x2000117")]
	internal class XCommentWrapper : XObjectWrapper
	{
		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x00003C7A File Offset: 0x00001E7A
		[global::Cpp2ILInjected.Token(Token = "0x1700020D")]
		private XComment Text
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AE5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2DF50", Offset = "0x1D2DF50", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XCommentWrapper), Member = "get_Value", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XCommentWrapper), Member = "set_Value", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XCommentWrapper), Member = "get_ParentNode", ReturnType = typeof(IXmlNode))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00003C7D File Offset: 0x00001E7D
		[global::Cpp2ILInjected.Token(Token = "0x6000AE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2DFC8", Offset = "0x1D2DFC8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainerWrapper), Member = "WrapNode", MemberParameters = new object[] { typeof(XObject) }, ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XCommentWrapper(XComment text)
		{
			throw null;
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x00003C80 File Offset: 0x00001E80
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x00003C83 File Offset: 0x00001E83
		[global::Cpp2ILInjected.Token(Token = "0x1700020E")]
		public override string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AE7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2E034", Offset = "0x1D2E034", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XCommentWrapper), Member = "get_Text", ReturnType = typeof(XComment))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000AE8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2E048", Offset = "0x1D2E048", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XCommentWrapper), Member = "get_Text", ReturnType = typeof(XComment))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XComment), Member = "set_Value", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x00003C86 File Offset: 0x00001E86
		[global::Cpp2ILInjected.Token(Token = "0x1700020F")]
		public override IXmlNode ParentNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AE9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2E064", Offset = "0x1D2E064", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XCommentWrapper), Member = "get_Text", ReturnType = typeof(XComment))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XObject), Member = "get_Parent", ReturnType = typeof(XElement))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainerWrapper), Member = "WrapNode", MemberParameters = new object[] { typeof(XObject) }, ReturnType = typeof(IXmlNode))]
			get
			{
				throw null;
			}
		}
	}
}
