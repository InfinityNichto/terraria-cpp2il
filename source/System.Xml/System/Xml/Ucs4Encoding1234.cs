using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000078 RID: 120
	[global::Cpp2ILInjected.Token(Token = "0x200009F")]
	internal class Ucs4Encoding1234 : Ucs4Encoding
	{
		// Token: 0x060006D6 RID: 1750 RVA: 0x00004331 File Offset: 0x00002531
		[global::Cpp2ILInjected.Token(Token = "0x600075F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DADF80", Offset = "0x1DADF80", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Ucs4Encoding), Member = "get_UCS4_Bigendian", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ucs4Decoder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Ucs4Encoding1234()
		{
			throw null;
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x00004334 File Offset: 0x00002534
		[global::Cpp2ILInjected.Token(Token = "0x170001C4")]
		public override string EncodingName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000760")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DAE14C", Offset = "0x1DAE14C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00004337 File Offset: 0x00002537
		[global::Cpp2ILInjected.Token(Token = "0x6000761")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAE18C", Offset = "0x1DAE18C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override byte[] GetPreamble()
		{
			throw null;
		}
	}
}
