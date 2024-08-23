using System;
using System.Globalization;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200011C RID: 284
	[global::Cpp2ILInjected.Token(Token = "0x20001A3")]
	internal static class ValidationHelper
	{
		// Token: 0x0600097B RID: 2427 RVA: 0x00004910 File Offset: 0x00002B10
		[global::Cpp2ILInjected.Token(Token = "0x6000A8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0EF34", Offset = "0x1F0EF34", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Authorization), Member = "set_ProtectionRealm", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static string[] MakeEmptyArrayNull(string[] stringArray)
		{
			throw null;
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00004913 File Offset: 0x00002B13
		[global::Cpp2ILInjected.Token(Token = "0x6000A8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0EF48", Offset = "0x1F0EF48", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Authorization), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Authorization), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Authorization), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static string MakeStringNull(string stringValue)
		{
			throw null;
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00004916 File Offset: 0x00002B16
		[global::Cpp2ILInjected.Token(Token = "0x6000A8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0EF5C", Offset = "0x1F0EF5C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValidationHelper), Member = "ExceptionMessage", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValidationHelper), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationHelper), Member = "ExceptionMessage", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static string ExceptionMessage(Exception exception)
		{
			throw null;
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00004919 File Offset: 0x00002B19
		[global::Cpp2ILInjected.Token(Token = "0x6000A8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0B618", Offset = "0x1F0B618", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CredentialHostKey), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CredentialKey), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationHelper), Member = "ExceptionMessage", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static string ToString(object objectValue)
		{
			throw null;
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0000491C File Offset: 0x00002B1C
		[global::Cpp2ILInjected.Token(Token = "0x6000A8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0F050", Offset = "0x1F0F050", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static string HashString(object objectValue)
		{
			throw null;
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0000491F File Offset: 0x00002B1F
		[global::Cpp2ILInjected.Token(Token = "0x6000A8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0F10C", Offset = "0x1F0F10C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsInvalidHttpString(string stringValue)
		{
			throw null;
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00004922 File Offset: 0x00002B22
		[global::Cpp2ILInjected.Token(Token = "0x6000A90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0F17C", Offset = "0x1F0F17C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cookie), Member = "set_Name", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cookie), Member = "InternalSetName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(CookieCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "set_Method", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static bool IsBlankString(string stringValue)
		{
			throw null;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00004925 File Offset: 0x00002B25
		[global::Cpp2ILInjected.Token(Token = "0x6000A91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0F198", Offset = "0x1F0F198", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpListener), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpListener), Member = "Create", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TcpListener))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UdpClient), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(AddressFamily)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public static bool ValidateTcpPort(int port)
		{
			throw null;
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00004928 File Offset: 0x00002B28
		[global::Cpp2ILInjected.Token(Token = "0x6000A92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0F1A4", Offset = "0x1F0F1A4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool ValidateRange(int actual, int fromAllowed, int toAllowed)
		{
			throw null;
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0000492B File Offset: 0x00002B2B
		[global::Cpp2ILInjected.Token(Token = "0x6000A93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0F1BC", Offset = "0x1F0F1BC", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal static void ValidateSegment(ArraySegment<byte> segment)
		{
			throw null;
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0000492E File Offset: 0x00002B2E
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000A94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0F2AC", Offset = "0x1F0F2AC", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static ValidationHelper()
		{
			throw null;
		}

		// Token: 0x0400064A RID: 1610
		[global::Cpp2ILInjected.Token(Token = "0x4000863")]
		public static string[] EmptyArray;

		// Token: 0x0400064B RID: 1611
		[global::Cpp2ILInjected.Token(Token = "0x4000864")]
		internal static readonly char[] InvalidMethodChars;

		// Token: 0x0400064C RID: 1612
		[global::Cpp2ILInjected.Token(Token = "0x4000865")]
		internal static readonly char[] InvalidParamChars;
	}
}
