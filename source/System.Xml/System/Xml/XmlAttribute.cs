using System;
using System.Xml.Schema;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000045 RID: 69
	[global::Cpp2ILInjected.Token(Token = "0x2000062")]
	public class XmlAttribute : XmlNode
	{
		// Token: 0x060003EB RID: 1003 RVA: 0x00003A8E File Offset: 0x00001C8E
		[global::Cpp2ILInjected.Token(Token = "0x6000463")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8B2A0", Offset = "0x1D8B2A0", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = ".ctor", MemberParameters = new object[] { typeof(XmlDocument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "CheckName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal XmlAttribute(XmlName name, XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00003A91 File Offset: 0x00001C91
		[global::Cpp2ILInjected.Token(Token = "0x6000464")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8B45C", Offset = "0x1D8B45C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadAttributeNodeDirect", ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "AddAttrXmlName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlName),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		protected internal XmlAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00003A94 File Offset: 0x00001C94
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x00003A97 File Offset: 0x00001C97
		[global::Cpp2ILInjected.Token(Token = "0x170000E2")]
		internal XmlName XmlName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000465")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8B584", Offset = "0x1D8B584", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000466")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8B58C", Offset = "0x1D8B58C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00003A9A File Offset: 0x00001C9A
		[global::Cpp2ILInjected.Token(Token = "0x6000467")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8B594", Offset = "0x1D8B594", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override XmlNode CloneNode(bool deep)
		{
			throw null;
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00003A9D File Offset: 0x00001C9D
		[global::Cpp2ILInjected.Token(Token = "0x170000E3")]
		public override XmlNode ParentNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000468")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8B650", Offset = "0x1D8B650", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00003AA0 File Offset: 0x00001CA0
		[global::Cpp2ILInjected.Token(Token = "0x170000E4")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000469")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8B658", Offset = "0x1D8B658", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlName), Member = "get_Name", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00003AA3 File Offset: 0x00001CA3
		[global::Cpp2ILInjected.Token(Token = "0x170000E5")]
		public override string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600046A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8B664", Offset = "0x1D8B664", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00003AA6 File Offset: 0x00001CA6
		[global::Cpp2ILInjected.Token(Token = "0x170000E6")]
		public override string NamespaceURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x600046B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8B670", Offset = "0x1D8B670", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00003AA9 File Offset: 0x00001CA9
		[global::Cpp2ILInjected.Token(Token = "0x170000E7")]
		public override string Prefix
		{
			[global::Cpp2ILInjected.Token(Token = "0x600046C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8B67C", Offset = "0x1D8B67C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00003AAC File Offset: 0x00001CAC
		[global::Cpp2ILInjected.Token(Token = "0x170000E8")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600046D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8B688", Offset = "0x1D8B688", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00003AAF File Offset: 0x00001CAF
		[global::Cpp2ILInjected.Token(Token = "0x170000E9")]
		public override XmlDocument OwnerDocument
		{
			[global::Cpp2ILInjected.Token(Token = "0x600046E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8B690", Offset = "0x1D8B690", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00003AB2 File Offset: 0x00001CB2
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00003AB5 File Offset: 0x00001CB5
		[global::Cpp2ILInjected.Token(Token = "0x170000EA")]
		public override string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x600046F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8B69C", Offset = "0x1D8B69C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000470")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8B6AC", Offset = "0x1D8B6AC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000CA RID: 202
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x00003AB8 File Offset: 0x00001CB8
		[global::Cpp2ILInjected.Token(Token = "0x170000EB")]
		public override string InnerText
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000471")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8B6BC", Offset = "0x1D8B6BC", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "set_InnerText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "set_InnerText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00003ABB File Offset: 0x00001CBB
		[global::Cpp2ILInjected.Token(Token = "0x6000472")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8B720", Offset = "0x1D8B720", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttribute), Member = "set_InnerText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttribute), Member = "RemoveChild", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttribute), Member = "AppendChild", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttributeCollection), Member = "PrepareParentInElementIdAttrMap", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		internal bool PrepareOwnerElementInElementIdAttrMap()
		{
			throw null;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00003ABE File Offset: 0x00001CBE
		[global::Cpp2ILInjected.Token(Token = "0x6000473")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8B7C4", Offset = "0x1D8B7C4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttribute), Member = "set_InnerText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttribute), Member = "RemoveChild", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttribute), Member = "AppendChild", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttributeCollection), Member = "ResetParentInElementIdAttrMap", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText)
		{
			throw null;
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x00003AC1 File Offset: 0x00001CC1
		[global::Cpp2ILInjected.Token(Token = "0x170000EC")]
		internal override bool IsContainer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000474")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8B9D0", Offset = "0x1D8B9D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00003AC4 File Offset: 0x00001CC4
		[global::Cpp2ILInjected.Token(Token = "0x6000475")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8B9D8", Offset = "0x1D8B9D8", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "GetInsertEventArgsForLoad", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlNode)
		}, ReturnType = typeof(XmlNodeChangedEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "NestTextNodes", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlNode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00003AC7 File Offset: 0x00001CC7
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00003ACA File Offset: 0x00001CCA
		[global::Cpp2ILInjected.Token(Token = "0x170000ED")]
		internal override XmlLinkedNode LastNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000476")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8BBE0", Offset = "0x1D8BBE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000477")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8BBE8", Offset = "0x1D8BBE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00003ACD File Offset: 0x00001CCD
		[global::Cpp2ILInjected.Token(Token = "0x6000478")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8BBF0", Offset = "0x1D8BBF0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override bool IsValidChildType(XmlNodeType type)
		{
			throw null;
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x00003AD0 File Offset: 0x00001CD0
		[global::Cpp2ILInjected.Token(Token = "0x170000EE")]
		public virtual bool Specified
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000479")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8BC08", Offset = "0x1D8BC08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00003AD3 File Offset: 0x00001CD3
		[global::Cpp2ILInjected.Token(Token = "0x600047A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8BC10", Offset = "0x1D8BC10", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "RemoveChild", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "RemoveChild", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override XmlNode RemoveChild(XmlNode oldChild)
		{
			throw null;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00003AD6 File Offset: 0x00001CD6
		[global::Cpp2ILInjected.Token(Token = "0x600047B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8BC88", Offset = "0x1D8BC88", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "AppendChild", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "AppendChild", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override XmlNode AppendChild(XmlNode newChild)
		{
			throw null;
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00003AD9 File Offset: 0x00001CD9
		[global::Cpp2ILInjected.Token(Token = "0x170000EF")]
		public virtual XmlElement OwnerElement
		{
			[global::Cpp2ILInjected.Token(Token = "0x600047C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8BD00", Offset = "0x1D8BD00", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000CF RID: 207
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00003ADC File Offset: 0x00001CDC
		[global::Cpp2ILInjected.Token(Token = "0x170000F0")]
		public override string InnerXml
		{
			[global::Cpp2ILInjected.Token(Token = "0x600047D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8BD7C", Offset = "0x1D8BD7C", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "LoadInnerXmlAttribute", MemberParameters = new object[]
			{
				typeof(XmlAttribute),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00003ADF File Offset: 0x00001CDF
		[global::Cpp2ILInjected.Token(Token = "0x170000F1")]
		public override string BaseURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x600047E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8BE00", Offset = "0x1D8BE00", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00003AE2 File Offset: 0x00001CE2
		[global::Cpp2ILInjected.Token(Token = "0x600047F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8BE90", Offset = "0x1D8BE90", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void SetParent(XmlNode node)
		{
			throw null;
		}

		// Token: 0x04000193 RID: 403
		[global::Cpp2ILInjected.Token(Token = "0x400028D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XmlName name;

		// Token: 0x04000194 RID: 404
		[global::Cpp2ILInjected.Token(Token = "0x400028E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private XmlLinkedNode lastChild;
	}
}
