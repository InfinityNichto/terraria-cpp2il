using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x2000123")]
	internal class DateTimeFacetsChecker : FacetsChecker
	{
		[global::Cpp2ILInjected.Token(Token = "0x60009F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC8730", Offset = "0x1DC8730", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60009F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC8788", Offset = "0x1DC8788", Length = "0x364")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFacetsChecker), Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(ArrayList),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		internal override Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60009F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC8C14", Offset = "0x1DC8C14", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFacetsChecker), Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(ArrayList),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(bool))]
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60009F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC8AEC", Offset = "0x1DC8AEC", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFacetsChecker), Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFacetsChecker), Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ArrayList),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private bool MatchEnumeration(DateTime value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60009F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC8C68", Offset = "0x1DC8C68", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DateTimeFacetsChecker()
		{
			throw null;
		}
	}
}
