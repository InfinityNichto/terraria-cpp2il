using System;
using System.Net;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x200007B")]
	internal static class IPv6AddressHelper
	{
		[global::Cpp2ILInjected.Token(Token = "0x60001D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9FE4C", Offset = "0x1E9FE4C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPv6AddressHelper), Member = "ParseCanonicalName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref bool),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddressParser), Member = "AppendSections", MemberParameters = new object[]
		{
			typeof(ushort[]),
			typeof(int),
			typeof(int),
			typeof(StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTuple<int, int>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ValueTuple<int, int> FindCompressionRange(ReadOnlySpan<ushort> numbers)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9FF2C", Offset = "0x1E9FF2C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPv6AddressHelper), Member = "ParseCanonicalName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref bool),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddressParser), Member = "IPv6AddressToStringHelper", MemberParameters = new object[]
		{
			typeof(ushort[]),
			typeof(uint)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal static bool ShouldHaveIpv4Embedded(ReadOnlySpan<ushort> numbers)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9FFBC", Offset = "0x1E9FFBC", Length = "0x380")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddressParser), Member = "Ipv6StringToAddress", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(ushort*),
			typeof(int),
			typeof(ref uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "IsHexDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv4AddressHelper), Member = "IsValidCanonical", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(ref int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal unsafe static bool IsValidStrict(char* name, int start, ref int end)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA033C", Offset = "0x1EA033C", Length = "0x43C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPv6AddressHelper), Member = "ParseCanonicalName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref bool),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddressParser), Member = "Ipv6StringToAddress", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(ushort*),
			typeof(int),
			typeof(ref uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "FromHex", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(ReadOnlySpan<char>) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv4AddressHelper), Member = "ParseHostNumber", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal unsafe static void Parse(ReadOnlySpan<char> address, ushort* numbers, int start, ref string scopeId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA0778", Offset = "0x1EA0778", Length = "0x5D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CreateHostStringHelper", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ushort),
			typeof(ushort),
			typeof(ref Uri.Flags),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv6AddressHelper), Member = "Parse", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(ushort*),
			typeof(int),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Span<ushort>), Member = "op_Implicit", MemberParameters = new object[] { typeof(Span<ushort>) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv6AddressHelper), Member = "IsLoopback", MemberParameters = new object[] { typeof(ReadOnlySpan<ushort>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv6AddressHelper), Member = "FindCompressionRange", MemberParameters = new object[] { typeof(ReadOnlySpan<ushort>) }, ReturnType = typeof(ValueTuple<int, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv6AddressHelper), Member = "ShouldHaveIpv4Embedded", MemberParameters = new object[] { typeof(ReadOnlySpan<ushort>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(Span<char>),
			typeof(ref int),
			typeof(ReadOnlySpan<char>),
			typeof(IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(Span<char>),
			typeof(ref int),
			typeof(ReadOnlySpan<char>),
			typeof(IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Span<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(Span<char>) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(ReadOnlySpan<char>) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		internal unsafe static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA0D48", Offset = "0x1EA0D48", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPv6AddressHelper), Member = "ParseCanonicalName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref bool),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private static bool IsLoopback(ReadOnlySpan<ushort> numbers)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA0DC4", Offset = "0x1EA0DC4", Length = "0x2D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPv6AddressHelper), Member = "IsValid", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "IsHexDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv4AddressHelper), Member = "IsValidCanonical", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(ref int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA1094", Offset = "0x1EA1094", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CheckHostName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(UriHostNameType))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(ushort),
			typeof(ref ParsingError),
			typeof(ref Uri.Flags),
			typeof(UriParser),
			typeof(ref string)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv6AddressHelper), Member = "InternalIsValid", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		internal unsafe static bool IsValid(char* name, int start, ref int end)
		{
			throw null;
		}
	}
}
