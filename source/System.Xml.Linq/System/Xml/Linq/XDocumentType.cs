using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Linq
{
	// Token: 0x02000009 RID: 9
	[global::Cpp2ILInjected.Token(Token = "0x200000A")]
	public class XDocumentType : XNode
	{
		// Token: 0x06000046 RID: 70 RVA: 0x0000211F File Offset: 0x0000031F
		[global::Cpp2ILInjected.Token(Token = "0x600004E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6C624", Offset = "0x1D6C624", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XDocumentWrapper", Member = "CreateXmlDocumentType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "VerifyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			throw null;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002122 File Offset: 0x00000322
		[global::Cpp2ILInjected.Token(Token = "0x600004F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6C6B4", Offset = "0x1D6C6B4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDocumentType), Member = "CloneNode", ReturnType = typeof(XNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public XDocumentType(XDocumentType other)
		{
			throw null;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002125 File Offset: 0x00000325
		[global::Cpp2ILInjected.Token(Token = "0x17000011")]
		public string InternalSubset
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000050")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6C734", Offset = "0x1D6C734", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002128 File Offset: 0x00000328
		[global::Cpp2ILInjected.Token(Token = "0x17000012")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000051")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6C73C", Offset = "0x1D6C73C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0000212B File Offset: 0x0000032B
		[global::Cpp2ILInjected.Token(Token = "0x17000013")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000052")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6C744", Offset = "0x1D6C744", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0000212E File Offset: 0x0000032E
		[global::Cpp2ILInjected.Token(Token = "0x17000014")]
		public string PublicId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000053")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6C74C", Offset = "0x1D6C74C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002131 File Offset: 0x00000331
		[global::Cpp2ILInjected.Token(Token = "0x17000015")]
		public string SystemId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000054")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6C754", Offset = "0x1D6C754", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002134 File Offset: 0x00000334
		[global::Cpp2ILInjected.Token(Token = "0x6000055")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6C75C", Offset = "0x1D6C75C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void WriteTo(XmlWriter writer)
		{
			throw null;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002137 File Offset: 0x00000337
		[global::Cpp2ILInjected.Token(Token = "0x6000056")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6C7CC", Offset = "0x1D6C7CC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XDocumentType), Member = ".ctor", MemberParameters = new object[] { typeof(XDocumentType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override XNode CloneNode()
		{
			throw null;
		}

		// Token: 0x0400000A RID: 10
		[global::Cpp2ILInjected.Token(Token = "0x400000F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string _name;

		// Token: 0x0400000B RID: 11
		[global::Cpp2ILInjected.Token(Token = "0x4000010")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string _publicId;

		// Token: 0x0400000C RID: 12
		[global::Cpp2ILInjected.Token(Token = "0x4000011")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string _systemId;

		// Token: 0x0400000D RID: 13
		[global::Cpp2ILInjected.Token(Token = "0x4000012")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string _internalSubset;
	}
}
