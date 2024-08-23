using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200007B RID: 123
	[global::Cpp2ILInjected.Token(Token = "0x20000A2")]
	internal class Ucs4Encoding3412 : Ucs4Encoding
	{
		// Token: 0x060006DF RID: 1759 RVA: 0x0000434C File Offset: 0x0000254C
		[global::Cpp2ILInjected.Token(Token = "0x6000768")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAE0E0", Offset = "0x1DAE0E0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Ucs4Encoding), Member = "get_UCS4_3412", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ucs4Decoder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Ucs4Encoding3412()
		{
			throw null;
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x0000434F File Offset: 0x0000254F
		[global::Cpp2ILInjected.Token(Token = "0x170001C7")]
		public override string EncodingName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000769")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DAE308", Offset = "0x1DAE308", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00004352 File Offset: 0x00002552
		[global::Cpp2ILInjected.Token(Token = "0x600076A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAE348", Offset = "0x1DAE348", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override byte[] GetPreamble()
		{
			throw null;
		}
	}
}
