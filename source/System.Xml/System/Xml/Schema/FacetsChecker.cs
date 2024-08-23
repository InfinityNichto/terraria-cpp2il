using System;
using System.Collections;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000F2 RID: 242
	[global::Cpp2ILInjected.Token(Token = "0x200011F")]
	internal abstract class FacetsChecker
	{
		// Token: 0x06000934 RID: 2356 RVA: 0x000049F4 File Offset: 0x00002BF4
		[global::Cpp2ILInjected.Token(Token = "0x60009CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC6FE8", Offset = "0x1DC6FE8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FacetsChecker), Member = "CheckWhitespaceFacets", MemberParameters = new object[]
		{
			typeof(ref string),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FacetsChecker), Member = "CheckPatternFacets", MemberParameters = new object[]
		{
			typeof(RestrictionFacets),
			typeof(string)
		}, ReturnType = typeof(Exception))]
		internal virtual Exception CheckLexicalFacets(ref string parseString, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x000049F7 File Offset: 0x00002BF7
		[global::Cpp2ILInjected.Token(Token = "0x60009CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC7264", Offset = "0x1DC7264", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x000049FA File Offset: 0x00002BFA
		[global::Cpp2ILInjected.Token(Token = "0x60009CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC726C", Offset = "0x1DC726C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual Exception CheckValueFacets(decimal value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x000049FD File Offset: 0x00002BFD
		[global::Cpp2ILInjected.Token(Token = "0x60009CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC7274", Offset = "0x1DC7274", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual Exception CheckValueFacets(long value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00004A00 File Offset: 0x00002C00
		[global::Cpp2ILInjected.Token(Token = "0x60009CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC727C", Offset = "0x1DC727C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00004A03 File Offset: 0x00002C03
		[global::Cpp2ILInjected.Token(Token = "0x60009D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC7284", Offset = "0x1DC7284", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual Exception CheckValueFacets(short value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00004A06 File Offset: 0x00002C06
		[global::Cpp2ILInjected.Token(Token = "0x60009D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC728C", Offset = "0x1DC728C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00004A09 File Offset: 0x00002C09
		[global::Cpp2ILInjected.Token(Token = "0x60009D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC7294", Offset = "0x1DC7294", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual Exception CheckValueFacets(double value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00004A0C File Offset: 0x00002C0C
		[global::Cpp2ILInjected.Token(Token = "0x60009D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC729C", Offset = "0x1DC729C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00004A0F File Offset: 0x00002C0F
		[global::Cpp2ILInjected.Token(Token = "0x60009D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC72A4", Offset = "0x1DC72A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00004A12 File Offset: 0x00002C12
		[global::Cpp2ILInjected.Token(Token = "0x60009D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC72AC", Offset = "0x1DC72AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00004A15 File Offset: 0x00002C15
		[global::Cpp2ILInjected.Token(Token = "0x60009D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC72B4", Offset = "0x1DC72B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00004A18 File Offset: 0x00002C18
		[global::Cpp2ILInjected.Token(Token = "0x60009D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC72BC", Offset = "0x1DC72BC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00004A1B File Offset: 0x00002C1B
		[global::Cpp2ILInjected.Token(Token = "0x60009D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC7020", Offset = "0x1DC7020", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FacetsChecker), Member = "CheckLexicalFacets", MemberParameters = new object[]
		{
			typeof(ref string),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlComplianceUtil), Member = "NonCDataNormalize", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlComplianceUtil), Member = "CDataNormalize", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		internal void CheckWhitespaceFacets(ref string s, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00004A1E File Offset: 0x00002C1E
		[global::Cpp2ILInjected.Token(Token = "0x60009D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC70FC", Offset = "0x1DC70FC", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FacetsChecker), Member = "CheckLexicalFacets", MemberParameters = new object[]
		{
			typeof(ref string),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal Exception CheckPatternFacets(RestrictionFacets restriction, string value)
		{
			throw null;
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00004A21 File Offset: 0x00002C21
		[global::Cpp2ILInjected.Token(Token = "0x60009DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC72C4", Offset = "0x1DC72C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00004A24 File Offset: 0x00002C24
		[global::Cpp2ILInjected.Token(Token = "0x60009DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC72CC", Offset = "0x1DC72CC", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Numeric10FacetsChecker), Member = "CheckTotalAndFractionDigits", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(decimal)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static decimal Power(int x, int y)
		{
			throw null;
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00004A27 File Offset: 0x00002C27
		[global::Cpp2ILInjected.Token(Token = "0x60009DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC73F8", Offset = "0x1DC73F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected FacetsChecker()
		{
			throw null;
		}
	}
}
