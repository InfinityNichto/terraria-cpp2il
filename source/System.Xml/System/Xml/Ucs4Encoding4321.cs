using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x20000A0")]
	internal class Ucs4Encoding4321 : Ucs4Encoding
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000762")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DADED0", Offset = "0x1DADED0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Ucs4Encoding), Member = "get_UCS4_Littleendian", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ucs4Decoder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Ucs4Encoding4321()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001C5")]
		public override string EncodingName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000763")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DAE1E0", Offset = "0x1DAE1E0", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000764")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAE220", Offset = "0x1DAE220", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override byte[] GetPreamble()
		{
			throw null;
		}
	}
}
