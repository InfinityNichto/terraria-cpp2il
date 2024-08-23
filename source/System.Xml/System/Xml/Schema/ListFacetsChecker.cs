using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000FB RID: 251
	[global::Cpp2ILInjected.Token(Token = "0x2000128")]
	internal class ListFacetsChecker : FacetsChecker
	{
		// Token: 0x06000973 RID: 2419 RVA: 0x00004AB1 File Offset: 0x00002CB1
		[global::Cpp2ILInjected.Token(Token = "0x6000A0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC9A0C", Offset = "0x1DC9A0C", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00004AB4 File Offset: 0x00002CB4
		[global::Cpp2ILInjected.Token(Token = "0x6000A0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC9C10", Offset = "0x1DC9C10", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00004AB7 File Offset: 0x00002CB7
		[global::Cpp2ILInjected.Token(Token = "0x6000A0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC9CBC", Offset = "0x1DC9CBC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ListFacetsChecker()
		{
			throw null;
		}
	}
}
