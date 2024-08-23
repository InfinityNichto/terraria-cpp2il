using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000A8 RID: 168
	[global::Cpp2ILInjected.Token(Token = "0x20000D3")]
	internal class ContentValidator
	{
		// Token: 0x060007C0 RID: 1984 RVA: 0x0000459B File Offset: 0x0000279B
		[global::Cpp2ILInjected.Token(Token = "0x600084F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB64DC", Offset = "0x1DB64DC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ContentValidator(XmlSchemaContentType contentType)
		{
			throw null;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0000459E File Offset: 0x0000279E
		[global::Cpp2ILInjected.Token(Token = "0x6000850")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB650C", Offset = "0x1DB650C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected ContentValidator(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable)
		{
			throw null;
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x000045A1 File Offset: 0x000027A1
		[global::Cpp2ILInjected.Token(Token = "0x17000206")]
		public XmlSchemaContentType ContentType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000851")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB654C", Offset = "0x1DB654C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x000045A4 File Offset: 0x000027A4
		[global::Cpp2ILInjected.Token(Token = "0x17000207")]
		public bool IsOpen
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000852")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB6554", Offset = "0x1DB6554", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000045A7 File Offset: 0x000027A7
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000853")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB6578", Offset = "0x1DB6578", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static ContentValidator()
		{
			throw null;
		}

		// Token: 0x040002B9 RID: 697
		[global::Cpp2ILInjected.Token(Token = "0x4000430")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlSchemaContentType contentType;

		// Token: 0x040002BA RID: 698
		[global::Cpp2ILInjected.Token(Token = "0x4000431")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private bool isOpen;

		// Token: 0x040002BB RID: 699
		[global::Cpp2ILInjected.Token(Token = "0x4000432")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x15")]
		private bool isEmptiable;

		// Token: 0x040002BC RID: 700
		[global::Cpp2ILInjected.Token(Token = "0x4000433")]
		public static readonly ContentValidator Empty;

		// Token: 0x040002BD RID: 701
		[global::Cpp2ILInjected.Token(Token = "0x4000434")]
		public static readonly ContentValidator TextOnly;

		// Token: 0x040002BE RID: 702
		[global::Cpp2ILInjected.Token(Token = "0x4000435")]
		public static readonly ContentValidator Mixed;

		// Token: 0x040002BF RID: 703
		[global::Cpp2ILInjected.Token(Token = "0x4000436")]
		public static readonly ContentValidator Any;
	}
}
