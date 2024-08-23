using System;
using System.Threading;
using System.Xml.Schema;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000057 RID: 87
	[global::Cpp2ILInjected.Token(Token = "0x2000074")]
	internal class XmlName : IXmlSchemaInfo
	{
		// Token: 0x06000517 RID: 1303 RVA: 0x00003E12 File Offset: 0x00002012
		[global::Cpp2ILInjected.Token(Token = "0x600058F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D96FCC", Offset = "0x1D96FCC", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DomNameTable), Member = "AddName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNameEx), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(XmlDocument),
			typeof(XmlName),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo)
		{
			throw null;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00003E15 File Offset: 0x00002015
		[global::Cpp2ILInjected.Token(Token = "0x6000590")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D970B4", Offset = "0x1D970B4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal XmlName(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next)
		{
			throw null;
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00003E18 File Offset: 0x00002018
		[global::Cpp2ILInjected.Token(Token = "0x1700015D")]
		public string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000591")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D974D4", Offset = "0x1D974D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00003E1B File Offset: 0x0000201B
		[global::Cpp2ILInjected.Token(Token = "0x1700015E")]
		public string NamespaceURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000592")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D974DC", Offset = "0x1D974DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x00003E1E File Offset: 0x0000201E
		[global::Cpp2ILInjected.Token(Token = "0x1700015F")]
		public string Prefix
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000593")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D974E4", Offset = "0x1D974E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x00003E21 File Offset: 0x00002021
		[global::Cpp2ILInjected.Token(Token = "0x17000160")]
		public int HashCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000594")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D974EC", Offset = "0x1D974EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00003E24 File Offset: 0x00002024
		[global::Cpp2ILInjected.Token(Token = "0x17000161")]
		public XmlDocument OwnerDocument
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000595")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D974F4", Offset = "0x1D974F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x00003E27 File Offset: 0x00002027
		[global::Cpp2ILInjected.Token(Token = "0x17000162")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000596")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D91CCC", Offset = "0x1D91CCC", Length = "0x180")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttribute), Member = "get_Name", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "get_NameTable", ReturnType = typeof(XmlNameTable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x00003E2A File Offset: 0x0000202A
		[global::Cpp2ILInjected.Token(Token = "0x17000163")]
		public virtual XmlSchemaValidity Validity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000597")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D974FC", Offset = "0x1D974FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x00003E2D File Offset: 0x0000202D
		[global::Cpp2ILInjected.Token(Token = "0x17000164")]
		public virtual bool IsDefault
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000598")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D97504", Offset = "0x1D97504", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x00003E30 File Offset: 0x00002030
		[global::Cpp2ILInjected.Token(Token = "0x17000165")]
		public virtual bool IsNil
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000599")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9750C", Offset = "0x1D9750C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x00003E33 File Offset: 0x00002033
		[global::Cpp2ILInjected.Token(Token = "0x17000166")]
		public virtual XmlSchemaSimpleType MemberType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600059A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D97514", Offset = "0x1D97514", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00003E36 File Offset: 0x00002036
		[global::Cpp2ILInjected.Token(Token = "0x17000167")]
		public virtual XmlSchemaType SchemaType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600059B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9751C", Offset = "0x1D9751C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00003E39 File Offset: 0x00002039
		[global::Cpp2ILInjected.Token(Token = "0x17000168")]
		public virtual XmlSchemaElement SchemaElement
		{
			[global::Cpp2ILInjected.Token(Token = "0x600059C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D97524", Offset = "0x1D97524", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x00003E3C File Offset: 0x0000203C
		[global::Cpp2ILInjected.Token(Token = "0x17000169")]
		public virtual XmlSchemaAttribute SchemaAttribute
		{
			[global::Cpp2ILInjected.Token(Token = "0x600059D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9752C", Offset = "0x1D9752C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00003E3F File Offset: 0x0000203F
		[global::Cpp2ILInjected.Token(Token = "0x600059E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D97534", Offset = "0x1D97534", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual bool Equals(IXmlSchemaInfo schemaInfo)
		{
			throw null;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00003E42 File Offset: 0x00002042
		[global::Cpp2ILInjected.Token(Token = "0x600059F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D97540", Offset = "0x1D97540", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DomNameTable), Member = "GetName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DomNameTable), Member = "AddName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		public static int GetHashCode(string name)
		{
			throw null;
		}

		// Token: 0x040001E8 RID: 488
		[global::Cpp2ILInjected.Token(Token = "0x40002E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string prefix;

		// Token: 0x040001E9 RID: 489
		[global::Cpp2ILInjected.Token(Token = "0x40002E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string localName;

		// Token: 0x040001EA RID: 490
		[global::Cpp2ILInjected.Token(Token = "0x40002E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string ns;

		// Token: 0x040001EB RID: 491
		[global::Cpp2ILInjected.Token(Token = "0x40002E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string name;

		// Token: 0x040001EC RID: 492
		[global::Cpp2ILInjected.Token(Token = "0x40002E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int hashCode;

		// Token: 0x040001ED RID: 493
		[global::Cpp2ILInjected.Token(Token = "0x40002E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal XmlDocument ownerDoc;

		// Token: 0x040001EE RID: 494
		[global::Cpp2ILInjected.Token(Token = "0x40002E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal XmlName next;
	}
}
