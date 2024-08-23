using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000D2 RID: 210
	[global::Cpp2ILInjected.Token(Token = "0x20000FE")]
	internal class Datatype_normalizedStringV1Compat : Datatype_string
	{
		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x00004832 File Offset: 0x00002A32
		[global::Cpp2ILInjected.Token(Token = "0x17000268")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000933")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC2000", Offset = "0x1DC2000", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00004835 File Offset: 0x00002A35
		[global::Cpp2ILInjected.Token(Token = "0x6000934")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC2008", Offset = "0x1DC2008", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_string), Member = ".ctor", ReturnType = typeof(void))]
		public Datatype_normalizedStringV1Compat()
		{
			throw null;
		}
	}
}
