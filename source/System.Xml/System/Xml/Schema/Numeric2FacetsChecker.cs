using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000F4 RID: 244
	[global::Cpp2ILInjected.Token(Token = "0x2000121")]
	internal class Numeric2FacetsChecker : FacetsChecker
	{
		// Token: 0x06000950 RID: 2384 RVA: 0x00004A48 File Offset: 0x00002C48
		[global::Cpp2ILInjected.Token(Token = "0x60009E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC7E10", Offset = "0x1DC7E10", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00004A4B File Offset: 0x00002C4B
		[global::Cpp2ILInjected.Token(Token = "0x60009E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC7E64", Offset = "0x1DC7E64", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Numeric2FacetsChecker), Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(double),
			typeof(ArrayList),
			typeof(XmlValueConverter)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal override Exception CheckValueFacets(double value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00004A4E File Offset: 0x00002C4E
		[global::Cpp2ILInjected.Token(Token = "0x60009E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC813C", Offset = "0x1DC813C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override Exception CheckValueFacets(float value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00004A51 File Offset: 0x00002C51
		[global::Cpp2ILInjected.Token(Token = "0x60009EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC814C", Offset = "0x1DC814C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Numeric2FacetsChecker), Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(double),
			typeof(ArrayList),
			typeof(XmlValueConverter)
		}, ReturnType = typeof(bool))]
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00004A54 File Offset: 0x00002C54
		[global::Cpp2ILInjected.Token(Token = "0x60009EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC8090", Offset = "0x1DC8090", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Numeric2FacetsChecker), Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(double),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Numeric2FacetsChecker), Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ArrayList),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		private bool MatchEnumeration(double value, ArrayList enumeration, XmlValueConverter valueConverter)
		{
			throw null;
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00004A57 File Offset: 0x00002C57
		[global::Cpp2ILInjected.Token(Token = "0x60009EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC81BC", Offset = "0x1DC81BC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Numeric2FacetsChecker()
		{
			throw null;
		}
	}
}
