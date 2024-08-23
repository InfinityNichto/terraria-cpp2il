using System;
using System.Globalization;
using System.Xml.Linq;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000002 RID: 2
[global::Cpp2ILInjected.Token(Token = "0x2000002")]
internal static class SR
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[global::Cpp2ILInjected.Token(Token = "0x6000001")]
	[global::Cpp2ILInjected.Address(RVA = "0x1D688AC", Offset = "0x1D688AC", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XAttribute), Member = "ValidateAttribute", MemberParameters = new object[]
	{
		typeof(XName),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDocument), Member = "ValidateNode", MemberParameters = new object[]
	{
		typeof(XNode),
		typeof(XNode)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XElement), Member = "ValidateNode", MemberParameters = new object[]
	{
		typeof(XNode),
		typeof(XNode)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XName), Member = "Get", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XName))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XProcessingInstruction), Member = "ValidateName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
	{
		typeof(IFormatProvider),
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	internal static string Format(string resourceFormat, object p1)
	{
		throw null;
	}
}
