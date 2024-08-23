using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000CC RID: 204
	[global::Cpp2ILInjected.Token(Token = "0x20000F8")]
	internal class Datatype_month : Datatype_dateTimeBase
	{
		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x000047AB File Offset: 0x000029AB
		[global::Cpp2ILInjected.Token(Token = "0x17000250")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000906")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC0BF0", Offset = "0x1DC0BF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x000047AE File Offset: 0x000029AE
		[global::Cpp2ILInjected.Token(Token = "0x6000907")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC0BF8", Offset = "0x1DC0BF8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_dateTimeBase), Member = ".ctor", MemberParameters = new object[] { typeof(XsdDateTimeFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal Datatype_month()
		{
			throw null;
		}
	}
}
