using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000BF RID: 191
	[global::Cpp2ILInjected.Token(Token = "0x20000EB")]
	internal class Datatype_dayTimeDuration : Datatype_duration
	{
		// Token: 0x06000853 RID: 2131 RVA: 0x00004751 File Offset: 0x00002951
		[global::Cpp2ILInjected.Token(Token = "0x60008E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBFF4C", Offset = "0x1DBFF4C", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDuration), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDuration.DurationType),
			typeof(ref XsdDuration)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDuration), Member = "TryToTimeSpan", MemberParameters = new object[]
		{
			typeof(XsdDuration.DurationType),
			typeof(ref TimeSpan)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x00004754 File Offset: 0x00002954
		[global::Cpp2ILInjected.Token(Token = "0x17000244")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC0100", Offset = "0x1DC0100", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00004757 File Offset: 0x00002957
		[global::Cpp2ILInjected.Token(Token = "0x60008EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC0108", Offset = "0x1DC0108", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_duration), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_dayTimeDuration()
		{
			throw null;
		}
	}
}
