using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000C9 RID: 201
	[global::Cpp2ILInjected.Token(Token = "0x20000F5")]
	internal class Datatype_year : Datatype_dateTimeBase
	{
		// Token: 0x17000227 RID: 551
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x00004799 File Offset: 0x00002999
		[global::Cpp2ILInjected.Token(Token = "0x1700024D")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000900")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC0AD0", Offset = "0x1DC0AD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x0000479C File Offset: 0x0000299C
		[global::Cpp2ILInjected.Token(Token = "0x6000901")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC0AD8", Offset = "0x1DC0AD8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_dateTimeBase), Member = ".ctor", MemberParameters = new object[] { typeof(XsdDateTimeFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal Datatype_year()
		{
			throw null;
		}
	}
}
