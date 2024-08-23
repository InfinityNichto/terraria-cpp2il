using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000063 RID: 99
	[global::Cpp2ILInjected.Token(Token = "0x2000082")]
	public class XmlWhitespace : XmlCharacterData
	{
		// Token: 0x060005A8 RID: 1448 RVA: 0x00003FAD File Offset: 0x000021AD
		[global::Cpp2ILInjected.Token(Token = "0x600062A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D95DB8", Offset = "0x1D95DB8", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CreateWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XmlWhitespace))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadNodeDirect", ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharacterData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharacterData), Member = "CheckOnData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected internal XmlWhitespace(string strData, XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x00003FB0 File Offset: 0x000021B0
		[global::Cpp2ILInjected.Token(Token = "0x170001A7")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x600062B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9AD88", Offset = "0x1D9AD88", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x00003FB3 File Offset: 0x000021B3
		[global::Cpp2ILInjected.Token(Token = "0x170001A8")]
		public override string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600062C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9ADA8", Offset = "0x1D9ADA8", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x00003FB6 File Offset: 0x000021B6
		[global::Cpp2ILInjected.Token(Token = "0x170001A9")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600062D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9ADC8", Offset = "0x1D9ADC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x00003FB9 File Offset: 0x000021B9
		[global::Cpp2ILInjected.Token(Token = "0x170001AA")]
		public override XmlNode ParentNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600062E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9ADD0", Offset = "0x1D9ADD0", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "get_ParentNode", ReturnType = typeof(XmlNode))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x00003FBC File Offset: 0x000021BC
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x00003FBF File Offset: 0x000021BF
		[global::Cpp2ILInjected.Token(Token = "0x170001AB")]
		public override string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x600062F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9AE48", Offset = "0x1D9AE48", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000630")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9AE58", Offset = "0x1D9AE58", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharacterData), Member = "CheckOnData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00003FC2 File Offset: 0x000021C2
		[global::Cpp2ILInjected.Token(Token = "0x6000631")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9AEE4", Offset = "0x1D9AEE4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override XmlNode CloneNode(bool deep)
		{
			throw null;
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x00003FC5 File Offset: 0x000021C5
		[global::Cpp2ILInjected.Token(Token = "0x170001AC")]
		internal override bool IsText
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000632")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9AF38", Offset = "0x1D9AF38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}
	}
}
