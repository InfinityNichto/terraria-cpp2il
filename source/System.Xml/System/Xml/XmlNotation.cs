using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200005E RID: 94
	[global::Cpp2ILInjected.Token(Token = "0x200007D")]
	public class XmlNotation : XmlNode
	{
		// Token: 0x0600057D RID: 1405 RVA: 0x00003F2C File Offset: 0x0000212C
		[global::Cpp2ILInjected.Token(Token = "0x60005FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9617C", Offset = "0x1D9617C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new object[]
		{
			typeof(IDtdInfo),
			typeof(XmlDocumentType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = ".ctor", MemberParameters = new object[] { typeof(XmlDocument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "get_NameTable", ReturnType = typeof(XmlNameTable))]
		internal XmlNotation(string name, string publicId, string systemId, XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x00003F2F File Offset: 0x0000212F
		[global::Cpp2ILInjected.Token(Token = "0x1700018E")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000600")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A624", Offset = "0x1D9A624", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00003F32 File Offset: 0x00002132
		[global::Cpp2ILInjected.Token(Token = "0x1700018F")]
		public override string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000601")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A62C", Offset = "0x1D9A62C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x00003F35 File Offset: 0x00002135
		[global::Cpp2ILInjected.Token(Token = "0x17000190")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000602")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A634", Offset = "0x1D9A634", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00003F38 File Offset: 0x00002138
		[global::Cpp2ILInjected.Token(Token = "0x6000603")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9A63C", Offset = "0x1D9A63C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override XmlNode CloneNode(bool deep)
		{
			throw null;
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x00003F3B File Offset: 0x0000213B
		[global::Cpp2ILInjected.Token(Token = "0x17000191")]
		public override bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000604")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A694", Offset = "0x1D9A694", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700016E RID: 366
		// (set) Token: 0x06000583 RID: 1411 RVA: 0x00003F3E File Offset: 0x0000213E
		[global::Cpp2ILInjected.Token(Token = "0x17000192")]
		public override string InnerXml
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000605")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A69C", Offset = "0x1D9A69C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x040001FC RID: 508
		[global::Cpp2ILInjected.Token(Token = "0x40002F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string publicId;

		// Token: 0x040001FD RID: 509
		[global::Cpp2ILInjected.Token(Token = "0x40002FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string systemId;

		// Token: 0x040001FE RID: 510
		[global::Cpp2ILInjected.Token(Token = "0x40002FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string name;
	}
}
