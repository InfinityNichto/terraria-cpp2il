using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x20000FE")]
	internal class Datatype_normalizedStringV1Compat : Datatype_string
	{
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
