using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x20000A1")]
	internal class Ucs4Encoding2143 : Ucs4Encoding
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000765")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAE030", Offset = "0x1DAE030", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Ucs4Encoding), Member = "get_UCS4_2143", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ucs4Decoder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Ucs4Encoding2143()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001C6")]
		public override string EncodingName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000766")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DAE274", Offset = "0x1DAE274", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000767")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAE2B4", Offset = "0x1DAE2B4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override byte[] GetPreamble()
		{
			throw null;
		}
	}
}
