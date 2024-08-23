using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000BE RID: 190
	[global::Cpp2ILInjected.Token(Token = "0x20000EA")]
	internal class Datatype_yearMonthDuration : Datatype_duration
	{
		// Token: 0x06000850 RID: 2128 RVA: 0x00004748 File Offset: 0x00002948
		[global::Cpp2ILInjected.Token(Token = "0x60008E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBFD3C", Offset = "0x1DBFD3C", Length = "0x1B4")]
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

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x0000474B File Offset: 0x0000294B
		[global::Cpp2ILInjected.Token(Token = "0x17000243")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBFEF0", Offset = "0x1DBFEF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0000474E File Offset: 0x0000294E
		[global::Cpp2ILInjected.Token(Token = "0x60008E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBFEF8", Offset = "0x1DBFEF8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_duration), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_yearMonthDuration()
		{
			throw null;
		}
	}
}
