using System;
using System.Globalization;
using System.IO;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Versioning;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Globalization.Unicode;
using Mono.Xml;

namespace System
{
	// Token: 0x0200006E RID: 110
	[global::Cpp2ILInjected.Token(Token = "0x2000095")]
	[global::System.Serializable]
	public readonly struct Char : global::System.IComparable, global::System.IComparable<char>, global::System.IEquatable<char>, global::System.IConvertible
	{
		// Token: 0x060003CC RID: 972 RVA: 0x00015083 File Offset: 0x00013283
		[global::Cpp2ILInjected.Token(Token = "0x6000466")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA0B0", Offset = "0x1BBA0B0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsLatin1(char ch)
		{
			throw null;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00015086 File Offset: 0x00013286
		[global::Cpp2ILInjected.Token(Token = "0x6000467")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA0C0", Offset = "0x1BBA0C0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsAscii(char ch)
		{
			throw null;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00015089 File Offset: 0x00013289
		[global::Cpp2ILInjected.Token(Token = "0x6000468")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA0D0", Offset = "0x1BBA0D0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "IsLetter", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "IsUpper", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "IsLower", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "IsPunctuation", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "IsNumber", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "IsNumber", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "IsSymbol", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "GetUnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "GetUnicodeCategory", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static global::System.Globalization.UnicodeCategory GetLatin1UnicodeCategory(char ch)
		{
			throw null;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0001508C File Offset: 0x0001328C
		[global::Cpp2ILInjected.Token(Token = "0x6000469")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA134", Offset = "0x1BBA134", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0001508F File Offset: 0x0001328F
		[global::Cpp2ILInjected.Token(Token = "0x600046A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA140", Offset = "0x1BBA140", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00015092 File Offset: 0x00013292
		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x600046B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA1B8", Offset = "0x1BBA1B8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T&",
			"T&",
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		public bool Equals(char obj)
		{
			throw null;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00015095 File Offset: 0x00013295
		[global::Cpp2ILInjected.Token(Token = "0x600046C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA1C8", Offset = "0x1BBA1C8", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_char", Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public int CompareTo(object value)
		{
			throw null;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00015098 File Offset: 0x00013298
		[global::Cpp2ILInjected.Token(Token = "0x600046D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA280", Offset = "0x1BBA280", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "SequenceCompareTo", MemberParameters = new object[]
		{
			typeof(ref char),
			typeof(int),
			typeof(ref char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexCharClass.SingleRangeComparer", Member = "Compare", MemberParameters = new object[] { "System.Text.RegularExpressions.RegexCharClass.SingleRange", "System.Text.RegularExpressions.RegexCharClass.SingleRange" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public int CompareTo(char value)
		{
			throw null;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0001509B File Offset: 0x0001329B
		[global::Cpp2ILInjected.Token(Token = "0x600046E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAAFA4", Offset = "0x1BAAFA4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 97)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateFromChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0001509E File Offset: 0x0001329E
		[global::Cpp2ILInjected.Token(Token = "0x600046F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA294", Offset = "0x1BBA294", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlException", Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = "System.String[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new object[]
		{
			typeof(global::System.Guid),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JTokenWriter", Member = "WriteValue", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Bson.BsonWriter", Member = "WriteValue", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateFromChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string ToString(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000150A1 File Offset: 0x000132A1
		[global::Cpp2ILInjected.Token(Token = "0x6000470")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA28C", Offset = "0x1BBA28C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateFromChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(string))]
		public static string ToString(char c)
		{
			throw null;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x000150A4 File Offset: 0x000132A4
		[global::Cpp2ILInjected.Token(Token = "0x6000471")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA2F0", Offset = "0x1BBA2F0", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.PrimitiveArray), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static char Parse(string s)
		{
			throw null;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x000150A7 File Offset: 0x000132A7
		[global::Cpp2ILInjected.Token(Token = "0x6000472")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA38C", Offset = "0x1BBA38C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToChar", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref char)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		public static bool TryParse(string s, out char result)
		{
			throw null;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000150AA File Offset: 0x000132AA
		[global::Cpp2ILInjected.Token(Token = "0x6000473")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB4158", Offset = "0x1BB4158", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIMultiplayerLobby", Member = "CompareNatural", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIPlayerSelectMenu", Member = "CompareNatural", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIWorldSelectMenu", Member = "CompareNatural", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.TimeZoneInfo.<>c", Member = "<TZif_ParsePosixName>b__34_0", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.TimeZoneInfo.<>c", Member = "<TZif_ParsePosixOffset>b__35_0", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "TryParseEnum", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(bool),
			typeof(ref global::System.Enum.EnumResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "CreateVersionFromString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Version))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "CheckValid", MemberParameters = new object[]
		{
			"System.Net.ResponseDescription",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MaskedTextProvider", Member = "IsAlphanumeric", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MaskedTextProvider", Member = "TestChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			"System.ComponentModel.MaskedTextResultHint&"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseNumber", MemberParameters = new object[] { "Newtonsoft.Json.ReadType" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTime", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Utilities.StringReference",
			"Newtonsoft.Json.DateTimeZoneHandling",
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTime", MemberParameters = new object[]
		{
			typeof(string),
			"Newtonsoft.Json.DateTimeZoneHandling",
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeOffset", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Utilities.StringReference",
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(ref global::System.DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeOffset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(ref global::System.DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.JPath", Member = "ParseArrayIndexer", MemberParameters = new object[] { typeof(char) }, ReturnType = "Newtonsoft.Json.Linq.JsonPath.PathFilter")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.JPath", Member = "ParseValue", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X501", Member = "IsHex", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 37)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsDigit(char c)
		{
			throw null;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000150AD File Offset: 0x000132AD
		[global::Cpp2ILInjected.Token(Token = "0x6000474")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA3CC", Offset = "0x1BBA3CC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static bool CheckLetter(global::System.Globalization.UnicodeCategory uc)
		{
			throw null;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x000150B0 File Offset: 0x000132B0
		[global::Cpp2ILInjected.Token(Token = "0x6000475")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA3D8", Offset = "0x1BBA3D8", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchWord", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "Lex", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeToken),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.__DTString), Member = "MatchSpecifiedWords", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new object[]
		{
			typeof(global::System.TokenType),
			typeof(ref global::System.TokenType),
			typeof(ref int),
			typeof(ref global::System.__DTString)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.DateTimeFormatInfoScanner), Member = "SkipWhiteSpacesAndNonLetter", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.UncNameHelper", Member = "IsValid", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(ushort),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MaskedTextProvider", Member = "IsAlphanumeric", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MaskedTextProvider", Member = "SetChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			"System.ComponentModel.MaskedTextProvider.CharDescriptor"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MaskedTextProvider", Member = "TestChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			"System.ComponentModel.MaskedTextResultHint&"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "Validate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(char)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "GetLatin1UnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static bool IsLetter(char c)
		{
			throw null;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x000150B3 File Offset: 0x000132B3
		[global::Cpp2ILInjected.Token(Token = "0x6000476")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA4B0", Offset = "0x1BBA4B0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsWhiteSpaceLatin1(char c)
		{
			throw null;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000150B6 File Offset: 0x000132B6
		[global::Cpp2ILInjected.Token(Token = "0x6000477")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB7DC0", Offset = "0x1BB7DC0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 55)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CharUnicodeInfo), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool IsWhiteSpace(char c)
		{
			throw null;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x000150B9 File Offset: 0x000132B9
		[global::Cpp2ILInjected.Token(Token = "0x6000478")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA4EC", Offset = "0x1BBA4EC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MaskedTextProvider", Member = "SetChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			"System.ComponentModel.MaskedTextProvider.CharDescriptor"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.StringUtils", Member = "ToCamelCase", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "Validate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(char)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "GetLatin1UnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool IsUpper(char c)
		{
			throw null;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x000150BC File Offset: 0x000132BC
		[global::Cpp2ILInjected.Token(Token = "0x6000479")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA5A8", Offset = "0x1BBA5A8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "Validate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(char)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "GetLatin1UnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool IsLower(char c)
		{
			throw null;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x000150BF File Offset: 0x000132BF
		[global::Cpp2ILInjected.Token(Token = "0x600047A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA664", Offset = "0x1BBA664", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static bool CheckPunctuation(global::System.Globalization.UnicodeCategory uc)
		{
			throw null;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x000150C2 File Offset: 0x000132C2
		[global::Cpp2ILInjected.Token(Token = "0x600047B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA674", Offset = "0x1BBA674", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MaskedTextProvider", Member = "IsPrintableChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "GetLatin1UnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool IsPunctuation(char c)
		{
			throw null;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x000150C5 File Offset: 0x000132C5
		[global::Cpp2ILInjected.Token(Token = "0x600047C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA720", Offset = "0x1BBA720", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static bool CheckLetterOrDigit(global::System.Globalization.UnicodeCategory uc)
		{
			throw null;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x000150C8 File Offset: 0x000132C8
		[global::Cpp2ILInjected.Token(Token = "0x600047D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA73C", Offset = "0x1BBA73C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CultureInfo), Member = "VerifyCultureName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MaskedTextProvider", Member = "IsPrintableChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ValidIdentifierChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseConstructor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "GetLatin1UnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool IsLetterOrDigit(char c)
		{
			throw null;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x000150CB File Offset: 0x000132CB
		[global::Cpp2ILInjected.Token(Token = "0x600047E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA7F8", Offset = "0x1BBA7F8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpDateParse", Member = "MAKE_UPPER", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X501", Member = "IsHex", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static char ToUpper(char c, global::System.Globalization.CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000150CE File Offset: 0x000132CE
		[global::Cpp2ILInjected.Token(Token = "0x600047F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA870", Offset = "0x1BBA870", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "Validate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(char)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static char ToUpper(char c)
		{
			throw null;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x000150D1 File Offset: 0x000132D1
		[global::Cpp2ILInjected.Token(Token = "0x6000480")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA8E0", Offset = "0x1BBA8E0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "TryParseGuidWithNoStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemName), Member = "MatchPattern", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X500DistinguishedName", Member = "Canonize", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static char ToUpperInvariant(char c)
		{
			throw null;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000150D4 File Offset: 0x000132D4
		[global::Cpp2ILInjected.Token(Token = "0x6000481")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA950", Offset = "0x1BBA950", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.UriHelper", Member = "TestForSubPath", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(ushort),
			"System.Char*",
			typeof(ushort),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.StringUtils", Member = "ToCamelCase", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static char ToLower(char c, global::System.Globalization.CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x000150D7 File Offset: 0x000132D7
		[global::Cpp2ILInjected.Token(Token = "0x6000482")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA9C8", Offset = "0x1BBA9C8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "Validate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(char)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static char ToLower(char c)
		{
			throw null;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x000150DA File Offset: 0x000132DA
		[global::Cpp2ILInjected.Token(Token = "0x6000483")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBAA38", Offset = "0x1BBAA38", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "IsHexPrefix", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static char ToLowerInvariant(char c)
		{
			throw null;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x000150DD File Offset: 0x000132DD
		[global::Cpp2ILInjected.Token(Token = "0x6000484")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBAAA8", Offset = "0x1BBAAA8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public global::System.TypeCode GetTypeCode()
		{
			throw null;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000150E0 File Offset: 0x000132E0
		[global::Cpp2ILInjected.Token(Token = "0x6000485")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBAAB0", Offset = "0x1BBAAB0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private bool System.IConvertible.ToBoolean(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000150E3 File Offset: 0x000132E3
		[global::Cpp2ILInjected.Token(Token = "0x6000486")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBAB34", Offset = "0x1BBAB34", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private char System.IConvertible.ToChar(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x000150E6 File Offset: 0x000132E6
		[global::Cpp2ILInjected.Token(Token = "0x6000487")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBAB3C", Offset = "0x1BBAB3C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private sbyte System.IConvertible.ToSByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000150E9 File Offset: 0x000132E9
		[global::Cpp2ILInjected.Token(Token = "0x6000488")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBABF0", Offset = "0x1BBABF0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte System.IConvertible.ToByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000150EC File Offset: 0x000132EC
		[global::Cpp2ILInjected.Token(Token = "0x6000489")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBACA4", Offset = "0x1BBACA4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private short System.IConvertible.ToInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000150EF File Offset: 0x000132EF
		[global::Cpp2ILInjected.Token(Token = "0x600048A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBAD54", Offset = "0x1BBAD54", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ushort System.IConvertible.ToUInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000150F2 File Offset: 0x000132F2
		[global::Cpp2ILInjected.Token(Token = "0x600048B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBADB0", Offset = "0x1BBADB0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int System.IConvertible.ToInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x000150F5 File Offset: 0x000132F5
		[global::Cpp2ILInjected.Token(Token = "0x600048C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBAE10", Offset = "0x1BBAE10", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private uint System.IConvertible.ToUInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000150F8 File Offset: 0x000132F8
		[global::Cpp2ILInjected.Token(Token = "0x600048D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBAE70", Offset = "0x1BBAE70", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private long System.IConvertible.ToInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000150FB File Offset: 0x000132FB
		[global::Cpp2ILInjected.Token(Token = "0x600048E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBAED0", Offset = "0x1BBAED0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ulong System.IConvertible.ToUInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000150FE File Offset: 0x000132FE
		[global::Cpp2ILInjected.Token(Token = "0x600048F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBAF30", Offset = "0x1BBAF30", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private float System.IConvertible.ToSingle(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00015101 File Offset: 0x00013301
		[global::Cpp2ILInjected.Token(Token = "0x6000490")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBAFB4", Offset = "0x1BBAFB4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private double System.IConvertible.ToDouble(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00015104 File Offset: 0x00013304
		[global::Cpp2ILInjected.Token(Token = "0x6000491")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBB038", Offset = "0x1BBB038", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private decimal System.IConvertible.ToDecimal(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00015107 File Offset: 0x00013307
		[global::Cpp2ILInjected.Token(Token = "0x6000492")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBB0BC", Offset = "0x1BBB0BC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private global::System.DateTime System.IConvertible.ToDateTime(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0001510A File Offset: 0x0001330A
		[global::Cpp2ILInjected.Token(Token = "0x6000493")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBB140", Offset = "0x1BBB140", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "DefaultToType", MemberParameters = new object[]
		{
			typeof(global::System.IConvertible),
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private object System.IConvertible.ToType(global::System.Type type, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0001510D File Offset: 0x0001330D
		[global::Cpp2ILInjected.Token(Token = "0x6000494")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBB1E8", Offset = "0x1BBB1E8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static bool CheckNumber(global::System.Globalization.UnicodeCategory uc)
		{
			throw null;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00015110 File Offset: 0x00013310
		[global::Cpp2ILInjected.Token(Token = "0x6000495")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBB1F8", Offset = "0x1BBB1F8", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseValue", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.StringEnumConverter", Member = "WriteJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonWriter",
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "GetLatin1UnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static bool IsNumber(char c)
		{
			throw null;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00015113 File Offset: 0x00013313
		[global::Cpp2ILInjected.Token(Token = "0x6000496")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBB2D0", Offset = "0x1BBB2D0", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "GetPortV4", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "GetLatin1UnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static bool IsNumber(string s, int index)
		{
			throw null;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00015116 File Offset: 0x00013316
		[global::Cpp2ILInjected.Token(Token = "0x6000497")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBB454", Offset = "0x1BBB454", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.DecoderFallbackBuffer), Member = "InternalFallback", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte*),
			typeof(ref char*)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.DecoderFallbackBuffer), Member = "InternalFallback", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte*)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.BinaryWriter), Member = "Write", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebUtility", Member = "HtmlEncode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IO.TextWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebUtility", Member = "IndexOfHtmlEncodingChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebUtility", Member = "StringRequiresHtmlDecoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlWellFormedWriter", Member = "WriteCharEntity", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		public unsafe static bool IsSurrogate(char c)
		{
			throw null;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00015119 File Offset: 0x00013319
		[global::Cpp2ILInjected.Token(Token = "0x6000498")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBB464", Offset = "0x1BBB464", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.DecoderReplacementFallback), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncoderReplacementFallback), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static bool IsSurrogate(string s, int index)
		{
			throw null;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0001511C File Offset: 0x0001331C
		[global::Cpp2ILInjected.Token(Token = "0x6000499")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBB560", Offset = "0x1BBB560", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static bool CheckSymbol(global::System.Globalization.UnicodeCategory uc)
		{
			throw null;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0001511F File Offset: 0x0001331F
		[global::Cpp2ILInjected.Token(Token = "0x600049A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBB570", Offset = "0x1BBB570", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MaskedTextProvider", Member = "IsPrintableChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "GetLatin1UnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool IsSymbol(char c)
		{
			throw null;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00015122 File Offset: 0x00013322
		[global::Cpp2ILInjected.Token(Token = "0x600049B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBB61C", Offset = "0x1BBB61C", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X500DistinguishedName", Member = "Canonize", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CharUnicodeInfo), Member = "IsWhiteSpace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static bool IsWhiteSpace(string s, int index)
		{
			throw null;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00015125 File Offset: 0x00013325
		[global::Cpp2ILInjected.Token(Token = "0x600049C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBB794", Offset = "0x1BBB794", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Xml.SmallXmlParser), Member = "IsNameChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Globalization.Unicode.MSCompatUnicodeTable), Member = "IsIgnorable", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Globalization.Unicode.SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new object[]
		{
			typeof(int),
			"Mono.Globalization.Unicode.SimpleCollator.ExtenderType",
			typeof(Mono.Globalization.Unicode.SortKeyBuffer),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "GetLatin1UnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static global::System.Globalization.UnicodeCategory GetUnicodeCategory(char c)
		{
			throw null;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00015128 File Offset: 0x00013328
		[global::Cpp2ILInjected.Token(Token = "0x600049D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBB814", Offset = "0x1BBB814", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.IdnMapping), Member = "NamePrep", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.IdnMapping), Member = "VerifyProhibitedCharacters", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "GetLatin1UnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CharUnicodeInfo), Member = "InternalGetUnicodeCategory", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static global::System.Globalization.UnicodeCategory GetUnicodeCategory(string s, int index)
		{
			throw null;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0001512B File Offset: 0x0001332B
		[global::Cpp2ILInjected.Token(Token = "0x600049E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBB958", Offset = "0x1BBB958", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIMultiplayerLobby", Member = "CompareNatural", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIPlayerSelectMenu", Member = "CompareNatural", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIWorldSelectMenu", Member = "CompareNatural", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CharUnicodeInfo), Member = "GetNumericValue", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(double))]
		public static double GetNumericValue(char c)
		{
			throw null;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0001512E File Offset: 0x0001332E
		[global::Cpp2ILInjected.Token(Token = "0x600049F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBB960", Offset = "0x1BBB960", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.DecoderFallbackBuffer), Member = "InternalFallback", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte*),
			typeof(ref char*)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.DecoderFallbackBuffer), Member = "InternalFallback", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte*)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.InternalEncoderBestFitFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncoderExceptionFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncoderFallbackException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(char),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncoderFallbackBuffer), Member = "InternalFallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(ref char*)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncoderReplacementFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncoderReplacementFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.UTF32Encoding), Member = "GetByteCount", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(global::System.Text.EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.UTF32Encoding), Member = "GetBytes", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(byte*),
			typeof(int),
			typeof(global::System.Text.EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IriHelper", Member = "EscapeUnescapeIri", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(int),
			typeof(int),
			"System.UriComponents"
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "CheckCanonical", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(ref ushort),
			typeof(ushort),
			typeof(char)
		}, ReturnType = "System.Uri.Check")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.UriHelper", Member = "MatchUTF8Sequence", MemberParameters = new object[]
		{
			"System.Char*",
			"System.Char[]",
			typeof(ref int),
			"System.Char[]",
			typeof(int),
			"System.Byte[]",
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.StringUtils", Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		public unsafe static bool IsHighSurrogate(char c)
		{
			throw null;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00015131 File Offset: 0x00013331
		[global::Cpp2ILInjected.Token(Token = "0x60004A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBB970", Offset = "0x1BBB970", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.DecoderReplacementFallback), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncoderReplacementFallback), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static bool IsHighSurrogate(string s, int index)
		{
			throw null;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00015134 File Offset: 0x00013334
		[global::Cpp2ILInjected.Token(Token = "0x60004A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBBA70", Offset = "0x1BBBA70", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.InternalEncoderBestFitFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncoderExceptionFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncoderFallbackException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(char),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncoderFallbackBuffer), Member = "InternalFallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(ref char*)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncoderReplacementFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncoderReplacementFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.UTF32Encoding), Member = "GetByteCount", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(global::System.Text.EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.UTF32Encoding), Member = "GetBytes", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(byte*),
			typeof(int),
			typeof(global::System.Text.EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.StringUtils", Member = "IsLowSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		public unsafe static bool IsLowSurrogate(char c)
		{
			throw null;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00015137 File Offset: 0x00013337
		[global::Cpp2ILInjected.Token(Token = "0x60004A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBBA80", Offset = "0x1BBBA80", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IriHelper", Member = "CheckIriUnicodeRange", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(ref bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebUtility", Member = "GetNextUnicodeScalarValueFromUtf16Surrogate", MemberParameters = new object[]
		{
			"System.Char*&",
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.CharEntityEncoderFallbackBuffer", Member = "Fallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlWellFormedWriter", Member = "WriteSurrogateCharEntity", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate)
		{
			throw null;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0001513A File Offset: 0x0001333A
		[global::Cpp2ILInjected.Token(Token = "0x60004A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBBAA4", Offset = "0x1BBBAA4", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequestUriBuilder", Member = "AppendUnicodeCodePointValuePercentEncoded", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateFromChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public unsafe static string ConvertFromUtf32(int utf32)
		{
			throw null;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0001513D File Offset: 0x0001333D
		[global::Cpp2ILInjected.Token(Token = "0x60004A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBBBD0", Offset = "0x1BBBBD0", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncoderExceptionFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncoderFallbackBuffer), Member = "InternalFallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(ref char*)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncoderReplacementFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncoderReplacementFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public unsafe static int ConvertToUtf32(char highSurrogate, char lowSurrogate)
		{
			throw null;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00015140 File Offset: 0x00013340
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60004A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBBCF4", Offset = "0x1BBBCF4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static Char()
		{
			throw null;
		}

		// Token: 0x04000124 RID: 292
		[global::Cpp2ILInjected.Token(Token = "0x400020B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly char m_value;

		// Token: 0x04000125 RID: 293
		[global::Cpp2ILInjected.Token(Token = "0x400020C")]
		public const char MaxValue = '\uffff';

		// Token: 0x04000126 RID: 294
		[global::Cpp2ILInjected.Token(Token = "0x400020D")]
		public const char MinValue = '\0';

		// Token: 0x04000127 RID: 295
		[global::Cpp2ILInjected.Token(Token = "0x400020E")]
		private static readonly byte[] s_categoryForLatin1;

		// Token: 0x04000128 RID: 296
		[global::Cpp2ILInjected.Token(Token = "0x400020F")]
		internal const int UNICODE_PLANE00_END = 65535;

		// Token: 0x04000129 RID: 297
		[global::Cpp2ILInjected.Token(Token = "0x4000210")]
		internal const int UNICODE_PLANE01_START = 65536;

		// Token: 0x0400012A RID: 298
		[global::Cpp2ILInjected.Token(Token = "0x4000211")]
		internal const int UNICODE_PLANE16_END = 1114111;

		// Token: 0x0400012B RID: 299
		[global::Cpp2ILInjected.Token(Token = "0x4000212")]
		internal const int HIGH_SURROGATE_START = 55296;

		// Token: 0x0400012C RID: 300
		[global::Cpp2ILInjected.Token(Token = "0x4000213")]
		internal const int LOW_SURROGATE_END = 57343;
	}
}
