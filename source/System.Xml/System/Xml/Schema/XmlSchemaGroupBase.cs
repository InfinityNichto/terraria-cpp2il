using System;
using System.Xml.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x02000116 RID: 278
	[global::Cpp2ILInjected.Token(Token = "0x2000148")]
	public abstract class XmlSchemaGroupBase : XmlSchemaParticle
	{
		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000A4D RID: 2637
		[XmlIgnore]
		[global::Cpp2ILInjected.Token(Token = "0x17000320")]
		public abstract XmlSchemaObjectCollection Items
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AE7")]
			get;
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00004D06 File Offset: 0x00002F06
		[global::Cpp2ILInjected.Token(Token = "0x6000AE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCEAE0", Offset = "0x1DCEAE0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaSequence), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaParticle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected XmlSchemaGroupBase()
		{
			throw null;
		}
	}
}
