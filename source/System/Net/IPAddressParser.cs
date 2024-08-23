using System;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000DA RID: 218
	[global::Cpp2ILInjected.Token(Token = "0x2000141")]
	internal class IPAddressParser
	{
		// Token: 0x060006FB RID: 1787 RVA: 0x00004244 File Offset: 0x00002444
		[global::Cpp2ILInjected.Token(Token = "0x60007C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE8C74", Offset = "0x1EE8C74", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref IPAddress)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(ref IPAddress)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress), Member = "Parse", MemberParameters = new object[] { typeof(ReadOnlySpan<char>) }, ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryExtensions), Member = "Contains", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(char)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.SpanHelpers", Member = "ClearWithoutReferences", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddressParser), Member = "Ipv6StringToAddress", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(ushort*),
			typeof(int),
			typeof(ref uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ushort*),
			typeof(int),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddressParser), Member = "Ipv4StringToAddress", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(ref long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal unsafe static IPAddress Parse(ReadOnlySpan<char> ipSpan, bool tryParse)
		{
			throw null;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00004247 File Offset: 0x00002447
		[global::Cpp2ILInjected.Token(Token = "0x60007C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE92B0", Offset = "0x1EE92B0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddressParser), Member = "IPv4AddressToStringHelper", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(char*)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal unsafe static string IPv4AddressToString(uint address)
		{
			throw null;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0000424A File Offset: 0x0000244A
		[global::Cpp2ILInjected.Token(Token = "0x60007C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEA4E0", Offset = "0x1EEA4E0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddressParser), Member = "IPv4AddressToStringHelper", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(char*)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal unsafe static void IPv4AddressToString(uint address, StringBuilder destination)
		{
			throw null;
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0000424D File Offset: 0x0000244D
		[global::Cpp2ILInjected.Token(Token = "0x60007C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE941C", Offset = "0x1EE941C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(Span<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddressParser), Member = "IPv4AddressToStringHelper", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(char*)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal unsafe static bool IPv4AddressToString(uint address, Span<char> formatted, out int charsWritten)
		{
			throw null;
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00004250 File Offset: 0x00002450
		[global::Cpp2ILInjected.Token(Token = "0x60007C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEA444", Offset = "0x1EEA444", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddressParser), Member = "IPv4AddressToString", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddressParser), Member = "IPv4AddressToString", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddressParser), Member = "IPv4AddressToString", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddressParser), Member = "IPv6AddressToStringHelper", MemberParameters = new object[]
		{
			typeof(ushort[]),
			typeof(uint)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddressParser), Member = "FormatIPv4AddressNumber", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char*),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		private unsafe static int IPv4AddressToStringHelper(uint address, char* addressString)
		{
			throw null;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00004253 File Offset: 0x00002453
		[global::Cpp2ILInjected.Token(Token = "0x60007C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE929C", Offset = "0x1EE929C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddressParser), Member = "IPv6AddressToStringHelper", MemberParameters = new object[]
		{
			typeof(ushort[]),
			typeof(uint)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(string))]
		internal static string IPv6AddressToString(ushort[] address, uint scopeId)
		{
			throw null;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00004256 File Offset: 0x00002456
		[global::Cpp2ILInjected.Token(Token = "0x60007C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE9344", Offset = "0x1EE9344", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddressParser), Member = "IPv6AddressToStringHelper", MemberParameters = new object[]
		{
			typeof(ushort[]),
			typeof(uint)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Text.StringBuilderCache", Member = "Release", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Span<char>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static bool IPv6AddressToString(ushort[] address, uint scopeId, Span<char> destination, out int charsWritten)
		{
			throw null;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00004259 File Offset: 0x00002459
		[global::Cpp2ILInjected.Token(Token = "0x60007C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEA600", Offset = "0x1EEA600", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddressParser), Member = "IPv6AddressToString", MemberParameters = new object[]
		{
			typeof(ushort[]),
			typeof(uint)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddressParser), Member = "IPv6AddressToString", MemberParameters = new object[]
		{
			typeof(ushort[]),
			typeof(uint),
			typeof(Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlySpan<ushort>), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort[]) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv6AddressHelper), Member = "ShouldHaveIpv4Embedded", MemberParameters = new object[] { typeof(ReadOnlySpan<ushort>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddressParser), Member = "AppendSections", MemberParameters = new object[]
		{
			typeof(ushort[]),
			typeof(int),
			typeof(int),
			typeof(StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddressParser), Member = "IPv4AddressToStringHelper", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(char*)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal unsafe static StringBuilder IPv6AddressToStringHelper(ushort[] address, uint scopeId)
		{
			throw null;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x0000425C File Offset: 0x0000245C
		[global::Cpp2ILInjected.Token(Token = "0x60007C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEA548", Offset = "0x1EEA548", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddressParser), Member = "IPv4AddressToStringHelper", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(char*)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "DivRem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static void FormatIPv4AddressNumber(int number, char* addressString, ref int offset)
		{
			throw null;
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x0000425F File Offset: 0x0000245F
		[global::Cpp2ILInjected.Token(Token = "0x60007CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEA370", Offset = "0x1EEA370", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddressParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(ReadOnlySpan<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv4AddressHelper), Member = "ParseNonCanonical", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public unsafe static bool Ipv4StringToAddress(ReadOnlySpan<char> ipSpan, out long address)
		{
			throw null;
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00004262 File Offset: 0x00002462
		[global::Cpp2ILInjected.Token(Token = "0x60007CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEA218", Offset = "0x1EEA218", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddressParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(ReadOnlySpan<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv6AddressHelper), Member = "IsValidStrict", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv6AddressHelper), Member = "Parse", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(ushort*),
			typeof(int),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public unsafe static bool Ipv6StringToAddress(ReadOnlySpan<char> ipSpan, ushort* numbers, int numbersLength, out uint scope)
		{
			throw null;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00004265 File Offset: 0x00002465
		[global::Cpp2ILInjected.Token(Token = "0x60007CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEA768", Offset = "0x1EEA768", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddressParser), Member = "IPv6AddressToStringHelper", MemberParameters = new object[]
		{
			typeof(ushort[]),
			typeof(uint)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv6AddressHelper), Member = "FindCompressionRange", MemberParameters = new object[] { typeof(ReadOnlySpan<ushort>) }, ReturnType = typeof(ValueTuple<int, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddressParser), Member = "AppendHex", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void AppendSections(ushort[] address, int fromInclusive, int toExclusive, StringBuilder buffer)
		{
			throw null;
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00004268 File Offset: 0x00002468
		[global::Cpp2ILInjected.Token(Token = "0x60007CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEA8F4", Offset = "0x1EEA8F4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddressParser), Member = "AppendSections", MemberParameters = new object[]
		{
			typeof(ushort[]),
			typeof(int),
			typeof(int),
			typeof(StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		private unsafe static void AppendHex(ushort value, StringBuilder buffer)
		{
			throw null;
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0000426B File Offset: 0x0000246B
		[global::Cpp2ILInjected.Token(Token = "0x60007CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEA8D8", Offset = "0x1EEA8D8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static uint ExtractIPv4Address(ushort[] address)
		{
			throw null;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0000426E File Offset: 0x0000246E
		[global::Cpp2ILInjected.Token(Token = "0x60007CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEA954", Offset = "0x1EEA954", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static ushort Reverse(ushort number)
		{
			throw null;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00004271 File Offset: 0x00002471
		[global::Cpp2ILInjected.Token(Token = "0x60007D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEA960", Offset = "0x1EEA960", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public IPAddressParser()
		{
			throw null;
		}

		// Token: 0x040004C0 RID: 1216
		[global::Cpp2ILInjected.Token(Token = "0x4000646")]
		private const int MaxIPv4StringLength = 15;
	}
}
