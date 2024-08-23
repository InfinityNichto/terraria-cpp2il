using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000051 RID: 81
	[global::Cpp2ILInjected.Token(Token = "0x200006E")]
	public class XmlEntity : XmlNode
	{
		// Token: 0x060004D5 RID: 1237 RVA: 0x00003D4C File Offset: 0x00001F4C
		[global::Cpp2ILInjected.Token(Token = "0x600054D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D92624", Offset = "0x1D92624", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new object[]
		{
			typeof(IDtdInfo),
			typeof(XmlDocumentType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = ".ctor", MemberParameters = new object[] { typeof(XmlDocument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "get_NameTable", ReturnType = typeof(XmlNameTable))]
		internal XmlEntity(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00003D4F File Offset: 0x00001F4F
		[global::Cpp2ILInjected.Token(Token = "0x600054E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D92714", Offset = "0x1D92714", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override XmlNode CloneNode(bool deep)
		{
			throw null;
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00003D52 File Offset: 0x00001F52
		[global::Cpp2ILInjected.Token(Token = "0x17000147")]
		public override bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x600054F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9276C", Offset = "0x1D9276C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00003D55 File Offset: 0x00001F55
		[global::Cpp2ILInjected.Token(Token = "0x17000148")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000550")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D92774", Offset = "0x1D92774", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00003D58 File Offset: 0x00001F58
		[global::Cpp2ILInjected.Token(Token = "0x17000149")]
		public override string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000551")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9277C", Offset = "0x1D9277C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00003D5B File Offset: 0x00001F5B
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x00003D5E File Offset: 0x00001F5E
		[global::Cpp2ILInjected.Token(Token = "0x1700014A")]
		public override string InnerText
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000552")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D92784", Offset = "0x1D92784", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000553")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D92788", Offset = "0x1D92788", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00003D61 File Offset: 0x00001F61
		[global::Cpp2ILInjected.Token(Token = "0x1700014B")]
		internal override bool IsContainer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000554")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D927E0", Offset = "0x1D927E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00003D64 File Offset: 0x00001F64
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00003D67 File Offset: 0x00001F67
		[global::Cpp2ILInjected.Token(Token = "0x1700014C")]
		internal override XmlLinkedNode LastNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000555")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D927E8", Offset = "0x1D927E8", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "ExpandEntity", MemberParameters = new object[] { typeof(XmlEntity) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000556")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D928B0", Offset = "0x1D928B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00003D6A File Offset: 0x00001F6A
		[global::Cpp2ILInjected.Token(Token = "0x6000557")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D928B8", Offset = "0x1D928B8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override bool IsValidChildType(XmlNodeType type)
		{
			throw null;
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00003D6D File Offset: 0x00001F6D
		[global::Cpp2ILInjected.Token(Token = "0x1700014D")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000558")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D928F4", Offset = "0x1D928F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00003D70 File Offset: 0x00001F70
		[global::Cpp2ILInjected.Token(Token = "0x1700014E")]
		public string SystemId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000559")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D928FC", Offset = "0x1D928FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700012E RID: 302
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00003D73 File Offset: 0x00001F73
		[global::Cpp2ILInjected.Token(Token = "0x1700014F")]
		public override string InnerXml
		{
			[global::Cpp2ILInjected.Token(Token = "0x600055A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D92904", Offset = "0x1D92904", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00003D76 File Offset: 0x00001F76
		[global::Cpp2ILInjected.Token(Token = "0x17000150")]
		public override string BaseURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x600055B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9295C", Offset = "0x1D9295C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00003D79 File Offset: 0x00001F79
		[global::Cpp2ILInjected.Token(Token = "0x600055C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D92964", Offset = "0x1D92964", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetBaseURI(string inBaseURI)
		{
			throw null;
		}

		// Token: 0x040001D5 RID: 469
		[global::Cpp2ILInjected.Token(Token = "0x40002CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string publicId;

		// Token: 0x040001D6 RID: 470
		[global::Cpp2ILInjected.Token(Token = "0x40002D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string systemId;

		// Token: 0x040001D7 RID: 471
		[global::Cpp2ILInjected.Token(Token = "0x40002D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string notationName;

		// Token: 0x040001D8 RID: 472
		[global::Cpp2ILInjected.Token(Token = "0x40002D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string name;

		// Token: 0x040001D9 RID: 473
		[global::Cpp2ILInjected.Token(Token = "0x40002D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string unparsedReplacementStr;

		// Token: 0x040001DA RID: 474
		[global::Cpp2ILInjected.Token(Token = "0x40002D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string baseURI;

		// Token: 0x040001DB RID: 475
		[global::Cpp2ILInjected.Token(Token = "0x40002D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private XmlLinkedNode lastChild;

		// Token: 0x040001DC RID: 476
		[global::Cpp2ILInjected.Token(Token = "0x40002D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private bool childrenFoliating;
	}
}
