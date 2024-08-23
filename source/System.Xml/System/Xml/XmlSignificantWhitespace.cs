using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000060 RID: 96
	[global::Cpp2ILInjected.Token(Token = "0x200007F")]
	public class XmlSignificantWhitespace : XmlCharacterData
	{
		// Token: 0x0600058E RID: 1422 RVA: 0x00003F5F File Offset: 0x0000215F
		[global::Cpp2ILInjected.Token(Token = "0x6000610")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D95D24", Offset = "0x1D95D24", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CreateSignificantWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XmlSignificantWhitespace))]
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
		protected internal XmlSignificantWhitespace(string strData, XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00003F62 File Offset: 0x00002162
		[global::Cpp2ILInjected.Token(Token = "0x17000199")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000611")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A844", Offset = "0x1D9A844", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00003F65 File Offset: 0x00002165
		[global::Cpp2ILInjected.Token(Token = "0x1700019A")]
		public override string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000612")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A864", Offset = "0x1D9A864", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00003F68 File Offset: 0x00002168
		[global::Cpp2ILInjected.Token(Token = "0x1700019B")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000613")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A884", Offset = "0x1D9A884", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00003F6B File Offset: 0x0000216B
		[global::Cpp2ILInjected.Token(Token = "0x1700019C")]
		public override XmlNode ParentNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000614")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A88C", Offset = "0x1D9A88C", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "get_ParentNode", ReturnType = typeof(XmlNode))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00003F6E File Offset: 0x0000216E
		[global::Cpp2ILInjected.Token(Token = "0x6000615")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9A904", Offset = "0x1D9A904", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override XmlNode CloneNode(bool deep)
		{
			throw null;
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x00003F71 File Offset: 0x00002171
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x00003F74 File Offset: 0x00002174
		[global::Cpp2ILInjected.Token(Token = "0x1700019D")]
		public override string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000616")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A958", Offset = "0x1D9A958", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000617")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A968", Offset = "0x1D9A968", Length = "0x8C")]
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

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x00003F77 File Offset: 0x00002177
		[global::Cpp2ILInjected.Token(Token = "0x1700019E")]
		internal override bool IsText
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000618")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A9F4", Offset = "0x1D9A9F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}
	}
}
