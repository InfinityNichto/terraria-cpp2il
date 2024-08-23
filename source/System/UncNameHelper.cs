using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000045 RID: 69
	[global::Cpp2ILInjected.Token(Token = "0x2000096")]
	internal class UncNameHelper
	{
		// Token: 0x06000229 RID: 553 RVA: 0x00003446 File Offset: 0x00001646
		[global::Cpp2ILInjected.Token(Token = "0x60002B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA6EFC", Offset = "0x1EA6EFC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CreateHostStringHelper", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ushort),
			typeof(ushort),
			typeof(ref Uri.Flags),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DomainNameHelper), Member = "ParseCanonicalName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		internal static string ParseCanonicalName(string str, int start, int end, ref bool loopback)
		{
			throw null;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00003449 File Offset: 0x00001649
		[global::Cpp2ILInjected.Token(Token = "0x60002B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA6F00", Offset = "0x1EA6F00", Length = "0x2D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal unsafe static bool IsValid(char* name, ushort start, ref int returnedEnd, bool notImplicitFile)
		{
			throw null;
		}
	}
}
