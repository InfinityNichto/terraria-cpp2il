using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000FA RID: 250
	[global::Cpp2ILInjected.Token(Token = "0x2000127")]
	internal class BinaryFacetsChecker : FacetsChecker
	{
		// Token: 0x0600096E RID: 2414 RVA: 0x00004AA2 File Offset: 0x00002CA2
		[global::Cpp2ILInjected.Token(Token = "0x6000A05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC9668", Offset = "0x1DC9668", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00004AA5 File Offset: 0x00002CA5
		[global::Cpp2ILInjected.Token(Token = "0x6000A06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC96F8", Offset = "0x1DC96F8", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryFacetsChecker), Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ArrayList),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal override Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00004AA8 File Offset: 0x00002CA8
		[global::Cpp2ILInjected.Token(Token = "0x6000A07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC9980", Offset = "0x1DC9980", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryFacetsChecker), Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ArrayList),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00004AAB File Offset: 0x00002CAB
		[global::Cpp2ILInjected.Token(Token = "0x6000A08")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC987C", Offset = "0x1DC987C", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryFacetsChecker), Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryFacetsChecker), Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ArrayList),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool MatchEnumeration(byte[] value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00004AAE File Offset: 0x00002CAE
		[global::Cpp2ILInjected.Token(Token = "0x6000A09")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC9A04", Offset = "0x1DC9A04", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BinaryFacetsChecker()
		{
			throw null;
		}
	}
}
