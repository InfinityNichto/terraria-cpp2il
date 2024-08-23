using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000052 RID: 82
	[global::Cpp2ILInjected.Token(Token = "0x200006F")]
	public class XmlEntityReference : XmlLinkedNode
	{
		// Token: 0x060004E5 RID: 1253 RVA: 0x00003D7C File Offset: 0x00001F7C
		[global::Cpp2ILInjected.Token(Token = "0x600055D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9296C", Offset = "0x1D9296C", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CreateEntityReference", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XmlEntityReference))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadAttributeValue", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadEntityReferenceNode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlEntityReference))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = ".ctor", MemberParameters = new object[] { typeof(XmlDocument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "get_NameTable", ReturnType = typeof(XmlNameTable))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected internal XmlEntityReference(string name, XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00003D7F File Offset: 0x00001F7F
		[global::Cpp2ILInjected.Token(Token = "0x17000151")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x600055E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D92A40", Offset = "0x1D92A40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00003D82 File Offset: 0x00001F82
		[global::Cpp2ILInjected.Token(Token = "0x17000152")]
		public override string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600055F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D92A48", Offset = "0x1D92A48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00003D85 File Offset: 0x00001F85
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x00003D88 File Offset: 0x00001F88
		[global::Cpp2ILInjected.Token(Token = "0x17000153")]
		public override string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000560")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D92A50", Offset = "0x1D92A50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000561")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D92A58", Offset = "0x1D92A58", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x00003D8B File Offset: 0x00001F8B
		[global::Cpp2ILInjected.Token(Token = "0x17000154")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000562")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D92AB0", Offset = "0x1D92AB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00003D8E File Offset: 0x00001F8E
		[global::Cpp2ILInjected.Token(Token = "0x6000563")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D92AB8", Offset = "0x1D92AB8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override XmlNode CloneNode(bool deep)
		{
			throw null;
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00003D91 File Offset: 0x00001F91
		[global::Cpp2ILInjected.Token(Token = "0x17000155")]
		public override bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000564")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D92AE8", Offset = "0x1D92AE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00003D94 File Offset: 0x00001F94
		[global::Cpp2ILInjected.Token(Token = "0x17000156")]
		internal override bool IsContainer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000565")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D92AF0", Offset = "0x1D92AF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00003D97 File Offset: 0x00001F97
		[global::Cpp2ILInjected.Token(Token = "0x6000566")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D92AF8", Offset = "0x1D92AF8", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "ExpandEntityReference", MemberParameters = new object[] { typeof(XmlEntityReference) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override void SetParent(XmlNode node)
		{
			throw null;
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00003D9A File Offset: 0x00001F9A
		[global::Cpp2ILInjected.Token(Token = "0x6000567")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D931A0", Offset = "0x1D931A0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void SetParentForLoad(XmlNode node)
		{
			throw null;
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00003D9D File Offset: 0x00001F9D
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00003DA0 File Offset: 0x00001FA0
		[global::Cpp2ILInjected.Token(Token = "0x17000157")]
		internal override XmlLinkedNode LastNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000568")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D931B0", Offset = "0x1D931B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000569")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D931B8", Offset = "0x1D931B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00003DA3 File Offset: 0x00001FA3
		[global::Cpp2ILInjected.Token(Token = "0x600056A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D931C0", Offset = "0x1D931C0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override bool IsValidChildType(XmlNodeType type)
		{
			throw null;
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00003DA6 File Offset: 0x00001FA6
		[global::Cpp2ILInjected.Token(Token = "0x17000158")]
		public override string BaseURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x600056B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D931E4", Offset = "0x1D931E4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00003DA9 File Offset: 0x00001FA9
		[global::Cpp2ILInjected.Token(Token = "0x600056C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9320C", Offset = "0x1D9320C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEntityReference), Member = "get_ChildBaseURI", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private string ConstructBaseURI(string baseURI, string systemId)
		{
			throw null;
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00003DAC File Offset: 0x00001FAC
		[global::Cpp2ILInjected.Token(Token = "0x17000159")]
		internal string ChildBaseURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x600056D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D932D8", Offset = "0x1D932D8", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNode), Member = "get_BaseURI", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "GetEntityNode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XmlEntity))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEntityReference), Member = "ConstructBaseURI", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040001DD RID: 477
		[global::Cpp2ILInjected.Token(Token = "0x40002D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string name;

		// Token: 0x040001DE RID: 478
		[global::Cpp2ILInjected.Token(Token = "0x40002D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private XmlLinkedNode lastChild;
	}
}
