using System;
using System.Xml.Schema;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200004F RID: 79
	[global::Cpp2ILInjected.Token(Token = "0x200006C")]
	public class XmlDocumentType : XmlLinkedNode
	{
		// Token: 0x060004A9 RID: 1193 RVA: 0x00003CC8 File Offset: 0x00001EC8
		[global::Cpp2ILInjected.Token(Token = "0x6000521")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9136C", Offset = "0x1D9136C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CreateDocumentType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XmlDocumentType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = ".ctor", MemberParameters = new object[] { typeof(XmlDocument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new object[] { typeof(XmlDocumentType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected internal XmlDocumentType(string name, string publicId, string systemId, string internalSubset, XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x00003CCB File Offset: 0x00001ECB
		[global::Cpp2ILInjected.Token(Token = "0x1700012C")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000522")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D91494", Offset = "0x1D91494", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00003CCE File Offset: 0x00001ECE
		[global::Cpp2ILInjected.Token(Token = "0x1700012D")]
		public override string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000523")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9149C", Offset = "0x1D9149C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x00003CD1 File Offset: 0x00001ED1
		[global::Cpp2ILInjected.Token(Token = "0x1700012E")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000524")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D914A4", Offset = "0x1D914A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00003CD4 File Offset: 0x00001ED4
		[global::Cpp2ILInjected.Token(Token = "0x6000525")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D914AC", Offset = "0x1D914AC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override XmlNode CloneNode(bool deep)
		{
			throw null;
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00003CD7 File Offset: 0x00001ED7
		[global::Cpp2ILInjected.Token(Token = "0x1700012F")]
		public override bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000526")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D914E0", Offset = "0x1D914E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00003CDA File Offset: 0x00001EDA
		[global::Cpp2ILInjected.Token(Token = "0x17000130")]
		public XmlNamedNodeMap Entities
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000527")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D914E8", Offset = "0x1D914E8", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "GetEntityNode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XmlEntity))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new object[]
			{
				typeof(IDtdInfo),
				typeof(XmlDocumentType)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00003CDD File Offset: 0x00001EDD
		[global::Cpp2ILInjected.Token(Token = "0x17000131")]
		public XmlNamedNodeMap Notations
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000528")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D91578", Offset = "0x1D91578", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new object[]
			{
				typeof(IDtdInfo),
				typeof(XmlDocumentType)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00003CE0 File Offset: 0x00001EE0
		[global::Cpp2ILInjected.Token(Token = "0x17000132")]
		public string PublicId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000529")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D915E0", Offset = "0x1D915E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00003CE3 File Offset: 0x00001EE3
		[global::Cpp2ILInjected.Token(Token = "0x17000133")]
		public string SystemId
		{
			[global::Cpp2ILInjected.Token(Token = "0x600052A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D915E8", Offset = "0x1D915E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00003CE6 File Offset: 0x00001EE6
		[global::Cpp2ILInjected.Token(Token = "0x17000134")]
		public string InternalSubset
		{
			[global::Cpp2ILInjected.Token(Token = "0x600052B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D915F0", Offset = "0x1D915F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00003CE9 File Offset: 0x00001EE9
		[global::Cpp2ILInjected.Token(Token = "0x17000135")]
		internal bool ParseWithNamespaces
		{
			[global::Cpp2ILInjected.Token(Token = "0x600052C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D915F8", Offset = "0x1D915F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00003CEC File Offset: 0x00001EEC
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00003CEF File Offset: 0x00001EEF
		[global::Cpp2ILInjected.Token(Token = "0x17000136")]
		internal SchemaInfo DtdSchemaInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x600052D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D91600", Offset = "0x1D91600", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600052E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D91608", Offset = "0x1D91608", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x040001CA RID: 458
		[global::Cpp2ILInjected.Token(Token = "0x40002C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string name;

		// Token: 0x040001CB RID: 459
		[global::Cpp2ILInjected.Token(Token = "0x40002C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string publicId;

		// Token: 0x040001CC RID: 460
		[global::Cpp2ILInjected.Token(Token = "0x40002C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string systemId;

		// Token: 0x040001CD RID: 461
		[global::Cpp2ILInjected.Token(Token = "0x40002C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string internalSubset;

		// Token: 0x040001CE RID: 462
		[global::Cpp2ILInjected.Token(Token = "0x40002C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool namespaces;

		// Token: 0x040001CF RID: 463
		[global::Cpp2ILInjected.Token(Token = "0x40002C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private XmlNamedNodeMap entities;

		// Token: 0x040001D0 RID: 464
		[global::Cpp2ILInjected.Token(Token = "0x40002CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private XmlNamedNodeMap notations;

		// Token: 0x040001D1 RID: 465
		[global::Cpp2ILInjected.Token(Token = "0x40002CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private SchemaInfo schemaInfo;
	}
}
