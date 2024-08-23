using System;
using System.Collections;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000F3 RID: 243
	[global::Cpp2ILInjected.Token(Token = "0x2000120")]
	internal class Numeric10FacetsChecker : FacetsChecker
	{
		// Token: 0x06000946 RID: 2374 RVA: 0x00004A2A File Offset: 0x00002C2A
		[global::Cpp2ILInjected.Token(Token = "0x60009DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBF7C8", Offset = "0x1DBF7C8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal Numeric10FacetsChecker(decimal minVal, decimal maxVal)
		{
			throw null;
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00004A2D File Offset: 0x00002C2D
		[global::Cpp2ILInjected.Token(Token = "0x60009DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC7400", Offset = "0x1DC7400", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00004A30 File Offset: 0x00002C30
		[global::Cpp2ILInjected.Token(Token = "0x60009DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC7464", Offset = "0x1DC7464", Length = "0x4DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaDatatype), Member = "get_TypeCodeString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_GreaterThanOrEqual", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_LessThanOrEqual", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Numeric10FacetsChecker), Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(ArrayList),
			typeof(XmlValueConverter)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Numeric10FacetsChecker), Member = "CheckTotalAndFractionDigits", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		internal override Exception CheckValueFacets(decimal value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00004A33 File Offset: 0x00002C33
		[global::Cpp2ILInjected.Token(Token = "0x60009E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC7B7C", Offset = "0x1DC7B7C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Implicit", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override Exception CheckValueFacets(long value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00004A36 File Offset: 0x00002C36
		[global::Cpp2ILInjected.Token(Token = "0x60009E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC7C08", Offset = "0x1DC7C08", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00004A39 File Offset: 0x00002C39
		[global::Cpp2ILInjected.Token(Token = "0x60009E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC7C94", Offset = "0x1DC7C94", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Implicit", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override Exception CheckValueFacets(short value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00004A3C File Offset: 0x00002C3C
		[global::Cpp2ILInjected.Token(Token = "0x60009E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC7D20", Offset = "0x1DC7D20", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Numeric10FacetsChecker), Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(ArrayList),
			typeof(XmlValueConverter)
		}, ReturnType = typeof(bool))]
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00004A3F File Offset: 0x00002C3F
		[global::Cpp2ILInjected.Token(Token = "0x60009E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC7A68", Offset = "0x1DC7A68", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Numeric10FacetsChecker), Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Numeric10FacetsChecker), Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ArrayList),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal bool MatchEnumeration(decimal value, ArrayList enumeration, XmlValueConverter valueConverter)
		{
			throw null;
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00004A42 File Offset: 0x00002C42
		[global::Cpp2ILInjected.Token(Token = "0x60009E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC62C8", Offset = "0x1DC62C8", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_fixed), Member = "ParseValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNameTable),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_fixed), Member = "TryParseValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNameTable),
			typeof(IXmlNamespaceResolver),
			typeof(ref object)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Numeric10FacetsChecker), Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FacetsChecker), Member = "Power", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(decimal)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "Negate", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "Truncate", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(decimal)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal Exception CheckTotalAndFractionDigits(decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction)
		{
			throw null;
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00004A45 File Offset: 0x00002C45
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60009E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC7D9C", Offset = "0x1DC7D9C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static Numeric10FacetsChecker()
		{
			throw null;
		}

		// Token: 0x04000394 RID: 916
		[global::Cpp2ILInjected.Token(Token = "0x400050E")]
		private static readonly char[] signs;

		// Token: 0x04000395 RID: 917
		[global::Cpp2ILInjected.Token(Token = "0x400050F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private decimal maxValue;

		// Token: 0x04000396 RID: 918
		[global::Cpp2ILInjected.Token(Token = "0x4000510")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private decimal minValue;
	}
}
