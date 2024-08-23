using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x02000106 RID: 262
	[global::Cpp2ILInjected.Token(Token = "0x2000136")]
	public class ValidationEventArgs : EventArgs
	{
		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x00004C52 File Offset: 0x00002E52
		[global::Cpp2ILInjected.Token(Token = "0x17000303")]
		public XmlSeverityType Severity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A9C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCBDF8", Offset = "0x1DCBDF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00004C55 File Offset: 0x00002E55
		[global::Cpp2ILInjected.Token(Token = "0x17000304")]
		public XmlSchemaException Exception
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A9D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCBE00", Offset = "0x1DCBE00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040003D9 RID: 985
		[global::Cpp2ILInjected.Token(Token = "0x4000561")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlSchemaException ex;

		// Token: 0x040003DA RID: 986
		[global::Cpp2ILInjected.Token(Token = "0x4000562")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XmlSeverityType severity;
	}
}
