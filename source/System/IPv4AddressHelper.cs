using System;
using System.Net;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000030 RID: 48
	[global::Cpp2ILInjected.Token(Token = "0x200007A")]
	internal static class IPv4AddressHelper
	{
		// Token: 0x06000149 RID: 329 RVA: 0x000031A6 File Offset: 0x000013A6
		[global::Cpp2ILInjected.Token(Token = "0x60001CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9F6B0", Offset = "0x1E9F6B0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPv6AddressHelper), Member = "Parse", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(ushort*),
			typeof(int),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv4AddressHelper), Member = "ParseCanonical", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(byte*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		internal unsafe static int ParseHostNumber(ReadOnlySpan<char> str, int start, int end)
		{
			throw null;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000031A9 File Offset: 0x000013A9
		[global::Cpp2ILInjected.Token(Token = "0x60001D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9F750", Offset = "0x1E9F750", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv4AddressHelper), Member = "ParseNonCanonical", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(long))]
		internal unsafe static bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme)
		{
			throw null;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000031AC File Offset: 0x000013AC
		[global::Cpp2ILInjected.Token(Token = "0x60001D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9F6E0", Offset = "0x1E9F6E0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPv4AddressHelper), Member = "ParseHostNumber", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private unsafe static bool ParseCanonical(ReadOnlySpan<char> name, byte* numbers, int start, int end)
		{
			throw null;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000031AF File Offset: 0x000013AF
		[global::Cpp2ILInjected.Token(Token = "0x60001D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9F780", Offset = "0x1E9F780", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPv6AddressHelper), Member = "IsValidStrict", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPv6AddressHelper), Member = "InternalIsValid", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal unsafe static bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile)
		{
			throw null;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000031B2 File Offset: 0x000013B2
		[global::Cpp2ILInjected.Token(Token = "0x60001D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9F8C0", Offset = "0x1E9F8C0", Length = "0x2F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPv4AddressHelper), Member = "IsValid", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(ref int),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPv4AddressHelper), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddressParser), Member = "Ipv4StringToAddress", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(ref long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal unsafe static long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile)
		{
			throw null;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000031B5 File Offset: 0x000013B5
		[global::Cpp2ILInjected.Token(Token = "0x60001D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9FBB4", Offset = "0x1E9FBB4", Length = "0x22C")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv4AddressHelper), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(Span<char>),
			typeof(ref int),
			typeof(ReadOnlySpan<char>),
			typeof(IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Span<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(Span<char>) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(ReadOnlySpan<char>) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal unsafe static string ParseCanonicalName(string str, int start, int end, ref bool isLoopback)
		{
			throw null;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000031B8 File Offset: 0x000013B8
		[global::Cpp2ILInjected.Token(Token = "0x60001D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9FDE0", Offset = "0x1E9FDE0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPv4AddressHelper), Member = "ParseCanonicalName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv4AddressHelper), Member = "ParseNonCanonical", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(long))]
		private unsafe static bool Parse(string name, byte* numbers, int start, int end)
		{
			throw null;
		}
	}
}
