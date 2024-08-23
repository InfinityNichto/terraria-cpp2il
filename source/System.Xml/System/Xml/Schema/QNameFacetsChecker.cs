using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000F8 RID: 248
	[global::Cpp2ILInjected.Token(Token = "0x2000125")]
	internal class QNameFacetsChecker : FacetsChecker
	{
		// Token: 0x06000968 RID: 2408 RVA: 0x00004A90 File Offset: 0x00002C90
		[global::Cpp2ILInjected.Token(Token = "0x60009FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC9188", Offset = "0x1DC9188", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00004A93 File Offset: 0x00002C93
		[global::Cpp2ILInjected.Token(Token = "0x6000A00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC92B0", Offset = "0x1DC92B0", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(QNameFacetsChecker), Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(ArrayList)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal override Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00004A96 File Offset: 0x00002C96
		[global::Cpp2ILInjected.Token(Token = "0x6000A01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC9548", Offset = "0x1DC9548", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(QNameFacetsChecker), Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(ArrayList)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00004A99 File Offset: 0x00002C99
		[global::Cpp2ILInjected.Token(Token = "0x6000A02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC9444", Offset = "0x1DC9444", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(QNameFacetsChecker), Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(QNameFacetsChecker), Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ArrayList),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool MatchEnumeration(XmlQualifiedName value, ArrayList enumeration)
		{
			throw null;
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00004A9C File Offset: 0x00002C9C
		[global::Cpp2ILInjected.Token(Token = "0x6000A03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC9658", Offset = "0x1DC9658", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public QNameFacetsChecker()
		{
			throw null;
		}
	}
}
