﻿using System;
using System.Collections;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x2000124")]
	internal class StringFacetsChecker : FacetsChecker
	{
		[global::Cpp2ILInjected.Token(Token = "0x170002AE")]
		private static Regex LanguagePattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC8C70", Offset = "0x1DC8C70", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringFacetsChecker), Member = "CheckBuiltInFacets", MemberParameters = new object[]
			{
				typeof(string),
				typeof(XmlTypeCode),
				typeof(bool)
			}, ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(RegexOptions)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60009F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC8D20", Offset = "0x1DC8D20", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringFacetsChecker), Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlSchemaDatatype),
			typeof(bool)
		}, ReturnType = typeof(Exception))]
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60009F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC8D74", Offset = "0x1DC8D74", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringFacetsChecker), Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlSchemaDatatype),
			typeof(bool)
		}, ReturnType = typeof(Exception))]
		internal override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60009FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC18B4", Offset = "0x1DC18B4", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_anyURI), Member = "TryParseValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNameTable),
			typeof(IXmlNamespaceResolver),
			typeof(ref object)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringFacetsChecker), Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(object),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringFacetsChecker), Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringFacetsChecker), Member = "CheckBuiltInFacets", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlTypeCode),
			typeof(bool)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringFacetsChecker), Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ArrayList),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60009FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC912C", Offset = "0x1DC912C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringFacetsChecker), Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ArrayList),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(bool))]
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60009FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC8F7C", Offset = "0x1DC8F7C", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringFacetsChecker), Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlSchemaDatatype),
			typeof(bool)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringFacetsChecker), Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ArrayList),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60009FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC8D7C", Offset = "0x1DC8D7C", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringFacetsChecker), Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlSchemaDatatype),
			typeof(bool)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryVerifyNCName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryToUri", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref Uri)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryVerifyNormalizedString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryVerifyTOKEN", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringFacetsChecker), Member = "get_LanguagePattern", ReturnType = typeof(Regex))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryVerifyNMTOKEN", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryVerifyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60009FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC9180", Offset = "0x1DC9180", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public StringFacetsChecker()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000511")]
		private static Regex languagePattern;
	}
}
