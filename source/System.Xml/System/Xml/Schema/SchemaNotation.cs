using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x02000104 RID: 260
	[global::Cpp2ILInjected.Token(Token = "0x2000134")]
	internal sealed class SchemaNotation
	{
		// Token: 0x060009FF RID: 2559 RVA: 0x00004C40 File Offset: 0x00002E40
		[global::Cpp2ILInjected.Token(Token = "0x6000A96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCBDA8", Offset = "0x1DCBDA8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal SchemaNotation(XmlQualifiedName name)
		{
			throw null;
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x00004C43 File Offset: 0x00002E43
		[global::Cpp2ILInjected.Token(Token = "0x17000300")]
		internal XmlQualifiedName Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A97")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCBDD0", Offset = "0x1DCBDD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x00004C46 File Offset: 0x00002E46
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x00004C49 File Offset: 0x00002E49
		[global::Cpp2ILInjected.Token(Token = "0x17000301")]
		internal string SystemLiteral
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A98")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCBDD8", Offset = "0x1DCBDD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A99")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCBDE0", Offset = "0x1DCBDE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x00004C4C File Offset: 0x00002E4C
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x00004C4F File Offset: 0x00002E4F
		[global::Cpp2ILInjected.Token(Token = "0x17000302")]
		internal string Pubid
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A9A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCBDE8", Offset = "0x1DCBDE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A9B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCBDF0", Offset = "0x1DCBDF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x040003D1 RID: 977
		[global::Cpp2ILInjected.Token(Token = "0x4000559")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlQualifiedName name;

		// Token: 0x040003D2 RID: 978
		[global::Cpp2ILInjected.Token(Token = "0x400055A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string systemLiteral;

		// Token: 0x040003D3 RID: 979
		[global::Cpp2ILInjected.Token(Token = "0x400055B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string pubid;
	}
}
