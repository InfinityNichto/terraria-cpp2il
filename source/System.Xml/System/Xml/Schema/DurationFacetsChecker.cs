using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000F5 RID: 245
	[global::Cpp2ILInjected.Token(Token = "0x2000122")]
	internal class DurationFacetsChecker : FacetsChecker
	{
		// Token: 0x06000956 RID: 2390 RVA: 0x00004A5A File Offset: 0x00002C5A
		[global::Cpp2ILInjected.Token(Token = "0x60009ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC81C4", Offset = "0x1DC81C4", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00004A5D File Offset: 0x00002C5D
		[global::Cpp2ILInjected.Token(Token = "0x60009EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC82D0", Offset = "0x1DC82D0", Length = "0x2E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "Compare", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(TimeSpan)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DurationFacetsChecker), Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(ArrayList)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00004A60 File Offset: 0x00002C60
		[global::Cpp2ILInjected.Token(Token = "0x60009EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC86B0", Offset = "0x1DC86B0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DurationFacetsChecker), Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(ArrayList)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00004A63 File Offset: 0x00002C63
		[global::Cpp2ILInjected.Token(Token = "0x60009F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC85B0", Offset = "0x1DC85B0", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DurationFacetsChecker), Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DurationFacetsChecker), Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ArrayList),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "Compare", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(TimeSpan)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool MatchEnumeration(TimeSpan value, ArrayList enumeration)
		{
			throw null;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00004A66 File Offset: 0x00002C66
		[global::Cpp2ILInjected.Token(Token = "0x60009F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC8728", Offset = "0x1DC8728", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DurationFacetsChecker()
		{
			throw null;
		}
	}
}
