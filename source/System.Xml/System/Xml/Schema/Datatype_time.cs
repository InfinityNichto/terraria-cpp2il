using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000C6 RID: 198
	[global::Cpp2ILInjected.Token(Token = "0x20000F2")]
	internal class Datatype_time : Datatype_dateTimeBase
	{
		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x00004787 File Offset: 0x00002987
		[global::Cpp2ILInjected.Token(Token = "0x1700024A")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC09B0", Offset = "0x1DC09B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x0000478A File Offset: 0x0000298A
		[global::Cpp2ILInjected.Token(Token = "0x60008FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC09B8", Offset = "0x1DC09B8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_dateTimeBase), Member = ".ctor", MemberParameters = new object[] { typeof(XsdDateTimeFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal Datatype_time()
		{
			throw null;
		}
	}
}
