using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200004E RID: 78
	[global::Cpp2ILInjected.Token(Token = "0x200006B")]
	public class XmlDocumentFragment : XmlNode
	{
		// Token: 0x0600049C RID: 1180 RVA: 0x00003CA1 File Offset: 0x00001EA1
		[global::Cpp2ILInjected.Token(Token = "0x6000514")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D90E80", Offset = "0x1D90E80", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CreateDocumentFragment", ReturnType = typeof(XmlDocumentFragment))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected internal XmlDocumentFragment(XmlDocument ownerDocument)
		{
			throw null;
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00003CA4 File Offset: 0x00001EA4
		[global::Cpp2ILInjected.Token(Token = "0x17000124")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000515")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D90F04", Offset = "0x1D90F04", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x00003CA7 File Offset: 0x00001EA7
		[global::Cpp2ILInjected.Token(Token = "0x17000125")]
		public override string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000516")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D90F24", Offset = "0x1D90F24", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00003CAA File Offset: 0x00001EAA
		[global::Cpp2ILInjected.Token(Token = "0x17000126")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000517")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D90F44", Offset = "0x1D90F44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00003CAD File Offset: 0x00001EAD
		[global::Cpp2ILInjected.Token(Token = "0x17000127")]
		public override XmlNode ParentNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000518")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D90F4C", Offset = "0x1D90F4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00003CB0 File Offset: 0x00001EB0
		[global::Cpp2ILInjected.Token(Token = "0x17000128")]
		public override XmlDocument OwnerDocument
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000519")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D90F54", Offset = "0x1D90F54", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000108 RID: 264
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00003CB3 File Offset: 0x00001EB3
		[global::Cpp2ILInjected.Token(Token = "0x17000129")]
		public override string InnerXml
		{
			[global::Cpp2ILInjected.Token(Token = "0x600051A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D90FCC", Offset = "0x1D90FCC", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new object[]
			{
				typeof(XmlNode),
				typeof(string),
				typeof(XmlNodeType)
			}, ReturnType = typeof(XmlNamespaceManager))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00003CB6 File Offset: 0x00001EB6
		[global::Cpp2ILInjected.Token(Token = "0x600051B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D91208", Offset = "0x1D91208", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override XmlNode CloneNode(bool deep)
		{
			throw null;
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00003CB9 File Offset: 0x00001EB9
		[global::Cpp2ILInjected.Token(Token = "0x1700012A")]
		internal override bool IsContainer
		{
			[global::Cpp2ILInjected.Token(Token = "0x600051C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D91280", Offset = "0x1D91280", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00003CBC File Offset: 0x00001EBC
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00003CBF File Offset: 0x00001EBF
		[global::Cpp2ILInjected.Token(Token = "0x1700012B")]
		internal override XmlLinkedNode LastNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600051D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D91288", Offset = "0x1D91288", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600051E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D91290", Offset = "0x1D91290", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00003CC2 File Offset: 0x00001EC2
		[global::Cpp2ILInjected.Token(Token = "0x600051F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D91298", Offset = "0x1D91298", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override bool IsValidChildType(XmlNodeType type)
		{
			throw null;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00003CC5 File Offset: 0x00001EC5
		[global::Cpp2ILInjected.Token(Token = "0x6000520")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D91304", Offset = "0x1D91304", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild)
		{
			throw null;
		}

		// Token: 0x040001C9 RID: 457
		[global::Cpp2ILInjected.Token(Token = "0x40002C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XmlLinkedNode lastChild;
	}
}
