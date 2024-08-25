using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x20000F4")]
	internal class Datatype_yearMonth : Datatype_dateTimeBase
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700024C")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC0A70", Offset = "0x1DC0A70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC0A78", Offset = "0x1DC0A78", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_dateTimeBase), Member = ".ctor", MemberParameters = new object[] { typeof(XsdDateTimeFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal Datatype_yearMonth()
		{
			throw null;
		}
	}
}
