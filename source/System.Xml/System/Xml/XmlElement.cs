using System;
using System.Threading;
using System.Xml.Schema;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000050 RID: 80
	[global::Cpp2ILInjected.Token(Token = "0x200006D")]
	public class XmlElement : XmlLinkedNode
	{
		// Token: 0x060004B7 RID: 1207 RVA: 0x00003CF2 File Offset: 0x00001EF2
		[global::Cpp2ILInjected.Token(Token = "0x600052F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D91610", Offset = "0x1D91610", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XmlElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlElement), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadNodeDirect", ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = ".ctor", MemberParameters = new object[] { typeof(XmlDocument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "CheckName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal XmlElement(XmlName name, bool empty, XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00003CF5 File Offset: 0x00001EF5
		[global::Cpp2ILInjected.Token(Token = "0x6000530")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D91710", Offset = "0x1D91710", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "AddXmlName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlElement), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlName),
			typeof(bool),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		protected internal XmlElement(string prefix, string localName, string namespaceURI, XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00003CF8 File Offset: 0x00001EF8
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00003CFB File Offset: 0x00001EFB
		[global::Cpp2ILInjected.Token(Token = "0x17000137")]
		internal XmlName XmlName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000531")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9174C", Offset = "0x1D9174C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000532")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D91754", Offset = "0x1D91754", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00003CFE File Offset: 0x00001EFE
		[global::Cpp2ILInjected.Token(Token = "0x6000533")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9175C", Offset = "0x1D9175C", Length = "0x520")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttributeCollection), Member = "InternalAppendAttribute", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public override XmlNode CloneNode(bool deep)
		{
			throw null;
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00003D01 File Offset: 0x00001F01
		[global::Cpp2ILInjected.Token(Token = "0x17000138")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000534")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D91CC4", Offset = "0x1D91CC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00003D04 File Offset: 0x00001F04
		[global::Cpp2ILInjected.Token(Token = "0x17000139")]
		public override string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000535")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D91E4C", Offset = "0x1D91E4C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x00003D07 File Offset: 0x00001F07
		[global::Cpp2ILInjected.Token(Token = "0x1700013A")]
		public override string NamespaceURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000536")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D91E58", Offset = "0x1D91E58", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00003D0A File Offset: 0x00001F0A
		[global::Cpp2ILInjected.Token(Token = "0x1700013B")]
		public override string Prefix
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000537")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D91E64", Offset = "0x1D91E64", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00003D0D File Offset: 0x00001F0D
		[global::Cpp2ILInjected.Token(Token = "0x1700013C")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000538")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D91E70", Offset = "0x1D91E70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00003D10 File Offset: 0x00001F10
		[global::Cpp2ILInjected.Token(Token = "0x1700013D")]
		public override XmlNode ParentNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000539")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D91E78", Offset = "0x1D91E78", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00003D13 File Offset: 0x00001F13
		[global::Cpp2ILInjected.Token(Token = "0x1700013E")]
		public override XmlDocument OwnerDocument
		{
			[global::Cpp2ILInjected.Token(Token = "0x600053A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D91E80", Offset = "0x1D91E80", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00003D16 File Offset: 0x00001F16
		[global::Cpp2ILInjected.Token(Token = "0x1700013F")]
		internal override bool IsContainer
		{
			[global::Cpp2ILInjected.Token(Token = "0x600053B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D91E8C", Offset = "0x1D91E8C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00003D19 File Offset: 0x00001F19
		[global::Cpp2ILInjected.Token(Token = "0x600053C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D91E94", Offset = "0x1D91E94", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "GetInsertEventArgsForLoad", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlNode)
		}, ReturnType = typeof(XmlNodeChangedEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00003D1C File Offset: 0x00001F1C
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00003D1F File Offset: 0x00001F1F
		[global::Cpp2ILInjected.Token(Token = "0x17000140")]
		public bool IsEmpty
		{
			[global::Cpp2ILInjected.Token(Token = "0x600053D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D91C7C", Offset = "0x1D91C7C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XmlElementWrapper", Member = "get_IsEmpty", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600053E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D91C8C", Offset = "0x1D91C8C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00003D22 File Offset: 0x00001F22
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00003D25 File Offset: 0x00001F25
		[global::Cpp2ILInjected.Token(Token = "0x17000141")]
		internal override XmlLinkedNode LastNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600053F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D91FF8", Offset = "0x1D91FF8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000540")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D92008", Offset = "0x1D92008", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00003D28 File Offset: 0x00001F28
		[global::Cpp2ILInjected.Token(Token = "0x6000541")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D92010", Offset = "0x1D92010", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override bool IsValidChildType(XmlNodeType type)
		{
			throw null;
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x00003D2B File Offset: 0x00001F2B
		[global::Cpp2ILInjected.Token(Token = "0x17000142")]
		public override XmlAttributeCollection Attributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000542")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D92034", Offset = "0x1D92034", Length = "0x130")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttributeCollection), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x00003D2E File Offset: 0x00001F2E
		[global::Cpp2ILInjected.Token(Token = "0x17000143")]
		public virtual bool HasAttributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000543")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D92164", Offset = "0x1D92164", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00003D31 File Offset: 0x00001F31
		[global::Cpp2ILInjected.Token(Token = "0x6000544")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9218C", Offset = "0x1D9218C", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr)
		{
			throw null;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00003D34 File Offset: 0x00001F34
		[global::Cpp2ILInjected.Token(Token = "0x6000545")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D92290", Offset = "0x1D92290", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttributeCollection), Member = "RemoveAll", ReturnType = typeof(void))]
		public virtual void RemoveAllAttributes()
		{
			throw null;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00003D37 File Offset: 0x00001F37
		[global::Cpp2ILInjected.Token(Token = "0x6000546")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D922C4", Offset = "0x1D922C4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void RemoveAll()
		{
			throw null;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00003D3A File Offset: 0x00001F3A
		[global::Cpp2ILInjected.Token(Token = "0x6000547")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D91FF4", Offset = "0x1D91FF4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
		internal void RemoveAllChildren()
		{
			throw null;
		}

		// Token: 0x17000123 RID: 291
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x00003D3D File Offset: 0x00001F3D
		[global::Cpp2ILInjected.Token(Token = "0x17000144")]
		public override string InnerXml
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000548")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D92350", Offset = "0x1D92350", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00003D40 File Offset: 0x00001F40
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00003D43 File Offset: 0x00001F43
		[global::Cpp2ILInjected.Token(Token = "0x17000145")]
		public override string InnerText
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000549")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9242C", Offset = "0x1D9242C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600054A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D92530", Offset = "0x1D92530", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00003D46 File Offset: 0x00001F46
		[global::Cpp2ILInjected.Token(Token = "0x17000146")]
		public override XmlNode NextSibling
		{
			[global::Cpp2ILInjected.Token(Token = "0x600054B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D925E0", Offset = "0x1D925E0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00003D49 File Offset: 0x00001F49
		[global::Cpp2ILInjected.Token(Token = "0x600054C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9261C", Offset = "0x1D9261C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void SetParent(XmlNode node)
		{
			throw null;
		}

		// Token: 0x040001D2 RID: 466
		[global::Cpp2ILInjected.Token(Token = "0x40002CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private XmlName name;

		// Token: 0x040001D3 RID: 467
		[global::Cpp2ILInjected.Token(Token = "0x40002CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private XmlAttributeCollection attributes;

		// Token: 0x040001D4 RID: 468
		[global::Cpp2ILInjected.Token(Token = "0x40002CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private XmlLinkedNode lastChild;
	}
}
