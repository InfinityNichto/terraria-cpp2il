using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000CA RID: 202
	[global::Cpp2ILInjected.Token(Token = "0x20000F6")]
	internal class Datatype_monthDay : Datatype_dateTimeBase
	{
		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x0000479F File Offset: 0x0000299F
		[global::Cpp2ILInjected.Token(Token = "0x1700024E")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000902")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC0B30", Offset = "0x1DC0B30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x000047A2 File Offset: 0x000029A2
		[global::Cpp2ILInjected.Token(Token = "0x6000903")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC0B38", Offset = "0x1DC0B38", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_dateTimeBase), Member = ".ctor", MemberParameters = new object[] { typeof(XsdDateTimeFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal Datatype_monthDay()
		{
			throw null;
		}
	}
}
