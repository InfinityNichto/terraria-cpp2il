using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000D4 RID: 212
	[global::Cpp2ILInjected.Token(Token = "0x2000100")]
	internal class Datatype_tokenV1Compat : Datatype_normalizedStringV1Compat
	{
		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x00004841 File Offset: 0x00002A41
		[global::Cpp2ILInjected.Token(Token = "0x1700026B")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000938")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC2020", Offset = "0x1DC2020", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00004844 File Offset: 0x00002A44
		[global::Cpp2ILInjected.Token(Token = "0x6000939")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC2028", Offset = "0x1DC2028", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_string), Member = ".ctor", ReturnType = typeof(void))]
		public Datatype_tokenV1Compat()
		{
			throw null;
		}
	}
}
