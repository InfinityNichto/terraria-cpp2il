using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000C7 RID: 199
	[global::Cpp2ILInjected.Token(Token = "0x20000F3")]
	internal class Datatype_date : Datatype_dateTimeBase
	{
		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x0000478D File Offset: 0x0000298D
		[global::Cpp2ILInjected.Token(Token = "0x1700024B")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC0A10", Offset = "0x1DC0A10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00004790 File Offset: 0x00002990
		[global::Cpp2ILInjected.Token(Token = "0x60008FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC0A18", Offset = "0x1DC0A18", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_dateTimeBase), Member = ".ctor", MemberParameters = new object[] { typeof(XsdDateTimeFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal Datatype_date()
		{
			throw null;
		}
	}
}
