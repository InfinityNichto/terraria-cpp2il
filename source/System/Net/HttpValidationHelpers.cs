using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000C6 RID: 198
	[global::Cpp2ILInjected.Token(Token = "0x2000127")]
	internal static class HttpValidationHelpers
	{
		// Token: 0x0600063B RID: 1595 RVA: 0x00004004 File Offset: 0x00002204
		[global::Cpp2ILInjected.Token(Token = "0x60006EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE12EC", Offset = "0x1EE12EC", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpValidationHelpers), Member = "IsInvalidMethodOrHeaderString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpValidationHelpers), Member = "ContainsNonAsciiChars", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static string CheckBadHeaderNameChars(string name)
		{
			throw null;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00004007 File Offset: 0x00002207
		[global::Cpp2ILInjected.Token(Token = "0x60006EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE14BC", Offset = "0x1EE14BC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpValidationHelpers), Member = "CheckBadHeaderNameChars", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpValidationHelpers), Member = "IsValidToken", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		internal static bool ContainsNonAsciiChars(string token)
		{
			throw null;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0000400A File Offset: 0x0000220A
		[global::Cpp2ILInjected.Token(Token = "0x60006EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE1538", Offset = "0x1EE1538", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpValidationHelpers), Member = "IsInvalidMethodOrHeaderString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpValidationHelpers), Member = "ContainsNonAsciiChars", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static bool IsValidToken(string token)
		{
			throw null;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0000400D File Offset: 0x0000220D
		[global::Cpp2ILInjected.Token(Token = "0x60006ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE15C8", Offset = "0x1EE15C8", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_Connection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_TransferEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static string CheckBadHeaderValueChars(string value)
		{
			throw null;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00004010 File Offset: 0x00002210
		[global::Cpp2ILInjected.Token(Token = "0x60006EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE13C4", Offset = "0x1EE13C4", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpValidationHelpers), Member = "CheckBadHeaderNameChars", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpValidationHelpers), Member = "IsValidToken", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_Method", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		public static bool IsInvalidMethodOrHeaderString(string stringValue)
		{
			throw null;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00004013 File Offset: 0x00002213
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60006EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE1798", Offset = "0x1EE1798", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static HttpValidationHelpers()
		{
			throw null;
		}

		// Token: 0x040003F1 RID: 1009
		[global::Cpp2ILInjected.Token(Token = "0x4000566")]
		private static readonly char[] s_httpTrimCharacters;
	}
}
