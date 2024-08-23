using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000002 RID: 2
[global::Cpp2ILInjected.Token(Token = "0x2000002")]
internal static class SR
{
	// Token: 0x06000001 RID: 1 RVA: 0x00003026 File Offset: 0x00001226
	[global::Cpp2ILInjected.Token(Token = "0x6000001")]
	[global::Cpp2ILInjected.Address(RVA = "0x1D5C428", Offset = "0x1D5C428", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
	{
		typeof(IFormatProvider),
		typeof(string),
		typeof(object[])
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	internal static string GetString(string name, params object[] args)
	{
		throw null;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00003029 File Offset: 0x00001229
	[global::Cpp2ILInjected.Token(Token = "0x6000002")]
	[global::Cpp2ILInjected.Address(RVA = "0x1D5C498", Offset = "0x1D5C498", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
	{
		typeof(IFormatProvider),
		typeof(string),
		typeof(object[])
	}, ReturnType = typeof(string))]
	internal static string GetString(CultureInfo culture, string name, params object[] args)
	{
		throw null;
	}
}
