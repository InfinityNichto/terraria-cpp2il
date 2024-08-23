using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200005F RID: 95
	[global::Cpp2ILInjected.Token(Token = "0x200007E")]
	public class XmlProcessingInstruction : XmlLinkedNode
	{
		// Token: 0x06000584 RID: 1412 RVA: 0x00003F41 File Offset: 0x00002141
		[global::Cpp2ILInjected.Token(Token = "0x6000606")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D95E4C", Offset = "0x1D95E4C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CreateProcessingInstruction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XmlProcessingInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = ".ctor", MemberParameters = new object[] { typeof(XmlDocument) }, ReturnType = typeof(void))]
		protected internal XmlProcessingInstruction(string target, string data, XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x00003F44 File Offset: 0x00002144
		[global::Cpp2ILInjected.Token(Token = "0x17000193")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000607")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A6F4", Offset = "0x1D9A6F4", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x00003F47 File Offset: 0x00002147
		[global::Cpp2ILInjected.Token(Token = "0x17000194")]
		public override string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000608")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A748", Offset = "0x1D9A748", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00003F4A File Offset: 0x0000214A
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x00003F4D File Offset: 0x0000214D
		[global::Cpp2ILInjected.Token(Token = "0x17000195")]
		public override string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000609")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A754", Offset = "0x1D9A754", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600060A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A75C", Offset = "0x1D9A75C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000172 RID: 370
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x00003F50 File Offset: 0x00002150
		[global::Cpp2ILInjected.Token(Token = "0x17000196")]
		public string Data
		{
			[global::Cpp2ILInjected.Token(Token = "0x600060B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A760", Offset = "0x1D9A760", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlProcessingInstruction), Member = "set_InnerText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00003F53 File Offset: 0x00002153
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x00003F56 File Offset: 0x00002156
		[global::Cpp2ILInjected.Token(Token = "0x17000197")]
		public override string InnerText
		{
			[global::Cpp2ILInjected.Token(Token = "0x600060C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A800", Offset = "0x1D9A800", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600060D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A808", Offset = "0x1D9A808", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlProcessingInstruction), Member = "set_Data", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x00003F59 File Offset: 0x00002159
		[global::Cpp2ILInjected.Token(Token = "0x17000198")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600060E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A80C", Offset = "0x1D9A80C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00003F5C File Offset: 0x0000215C
		[global::Cpp2ILInjected.Token(Token = "0x600060F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9A814", Offset = "0x1D9A814", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override XmlNode CloneNode(bool deep)
		{
			throw null;
		}

		// Token: 0x040001FF RID: 511
		[global::Cpp2ILInjected.Token(Token = "0x40002FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string target;

		// Token: 0x04000200 RID: 512
		[global::Cpp2ILInjected.Token(Token = "0x40002FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string data;
	}
}
