﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000192")]
	internal sealed class HttpListenerRequestUriBuilder
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0C5A8", Offset = "0x1F0C5A8", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderExceptionFallback), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderExceptionFallback), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[]
		{
			typeof(int),
			typeof(EncoderFallback),
			typeof(DecoderFallback)
		}, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		static HttpListenerRequestUriBuilder()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0C708", Offset = "0x1F0C708", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "GetRequestUri", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "AddSlashToAsteriskOnlyPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private HttpListenerRequestUriBuilder(string rawUri, string cookedUriScheme, string cookedUriHost, string cookedUriPath, string cookedUriQuery)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A50")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0C848", Offset = "0x1F0C848", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Uri GetRequestUri(string rawUri, string cookedUriScheme, string cookedUriHost, string cookedUriPath, string cookedUriQuery)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A51")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0C8D0", Offset = "0x1F0C8D0", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingCookedPath", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingRawPath", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private Uri Build()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A52")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0C9B8", Offset = "0x1F0C9B8", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "Build", ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UriKind),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private void BuildRequestUriUsingCookedPath()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A53")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0CBD8", Offset = "0x1F0CBD8", Length = "0x310")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "Build", ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "GetPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UriKind),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "GetEncoding", MemberParameters = new object[] { typeof(HttpListenerRequestUriBuilder.EncodingType) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingRawPath", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(HttpListenerRequestUriBuilder.ParsingResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private void BuildRequestUriUsingRawPath()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A54")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0D050", Offset = "0x1F0D050", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingRawPath", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static Encoding GetEncoding(HttpListenerRequestUriBuilder.EncodingType type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A55")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0D0BC", Offset = "0x1F0D0BC", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingRawPath", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<byte>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "ParseRawPath", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(HttpListenerRequestUriBuilder.ParsingResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UriKind),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private HttpListenerRequestUriBuilder.ParsingResult BuildRequestUriUsingRawPath(Encoding encoding)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A56")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0D2D4", Offset = "0x1F0D2D4", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingRawPath", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(HttpListenerRequestUriBuilder.ParsingResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "EmptyDecodeAndAppendRawOctetsList", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "AppendUnicodeCodePointValuePercentEncoded", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "AddPercentEncodedOctetToRawOctetsList", MemberParameters = new object[]
		{
			typeof(Encoding),
			typeof(string)
		}, ReturnType = typeof(bool))]
		private HttpListenerRequestUriBuilder.ParsingResult ParseRawPath(Encoding encoding)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A57")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0D74C", Offset = "0x1F0D74C", Length = "0x2CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "ParseRawPath", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(HttpListenerRequestUriBuilder.ParsingResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(IFormatProvider),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ConvertFromUtf32", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "AppendOctetsPercentEncoded", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(IEnumerable<byte>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		private bool AppendUnicodeCodePointValuePercentEncoded(string codePoint)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A58")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0DA18", Offset = "0x1F0DA18", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "ParseRawPath", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(HttpListenerRequestUriBuilder.ParsingResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(IFormatProvider),
			typeof(ref byte)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private bool AddPercentEncodedOctetToRawOctetsList(Encoding encoding, string escapedCharacter)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A59")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0D414", Offset = "0x1F0D414", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "ParseRawPath", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(HttpListenerRequestUriBuilder.ParsingResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<byte>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "AppendOctetsPercentEncoded", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(IEnumerable<byte>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "GetOctetsAsString", MemberParameters = new object[] { typeof(IEnumerable<byte>) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private bool EmptyDecodeAndAppendRawOctetsList(Encoding encoding)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0DB50", Offset = "0x1F0DB50", Length = "0x34C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "AppendUnicodeCodePointValuePercentEncoded", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "EmptyDecodeAndAppendRawOctetsList", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private static void AppendOctetsPercentEncoded(StringBuilder target, IEnumerable<byte> octets)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0DE9C", Offset = "0x1F0DE9C", Length = "0x3C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "EmptyDecodeAndAppendRawOctetsList", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private static string GetOctetsAsString(IEnumerable<byte> octets)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0CEF0", Offset = "0x1F0CEF0", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingRawPath", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "AddSlashToAsteriskOnlyPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static string GetPath(string uriString)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0C7D4", Offset = "0x1F0C7D4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "GetPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static string AddSlashToAsteriskOnlyPath(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0CEE8", Offset = "0x1F0CEE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		private void LogWarning(string methodName, string message, params object[] args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40007F2")]
		private static readonly bool useCookedRequestUrl;

		[global::Cpp2ILInjected.Token(Token = "0x40007F3")]
		private static readonly Encoding utf8Encoding;

		[global::Cpp2ILInjected.Token(Token = "0x40007F4")]
		private static readonly Encoding ansiEncoding;

		[global::Cpp2ILInjected.Token(Token = "0x40007F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string rawUri;

		[global::Cpp2ILInjected.Token(Token = "0x40007F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string cookedUriScheme;

		[global::Cpp2ILInjected.Token(Token = "0x40007F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly string cookedUriHost;

		[global::Cpp2ILInjected.Token(Token = "0x40007F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly string cookedUriPath;

		[global::Cpp2ILInjected.Token(Token = "0x40007F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly string cookedUriQuery;

		[global::Cpp2ILInjected.Token(Token = "0x40007FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private StringBuilder requestUriString;

		[global::Cpp2ILInjected.Token(Token = "0x40007FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private List<byte> rawOctets;

		[global::Cpp2ILInjected.Token(Token = "0x40007FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string rawPath;

		[global::Cpp2ILInjected.Token(Token = "0x40007FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Uri requestUri;

		[global::Cpp2ILInjected.Token(Token = "0x2000193")]
		private enum ParsingResult
		{
			[global::Cpp2ILInjected.Token(Token = "0x40007FF")]
			Success,
			[global::Cpp2ILInjected.Token(Token = "0x4000800")]
			InvalidString,
			[global::Cpp2ILInjected.Token(Token = "0x4000801")]
			EncodingError
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000194")]
		private enum EncodingType
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000803")]
			Primary,
			[global::Cpp2ILInjected.Token(Token = "0x4000804")]
			Secondary
		}
	}
}
