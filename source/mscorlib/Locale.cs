using System;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

// Token: 0x02000004 RID: 4
[global::Cpp2ILInjected.Token(Token = "0x200000C")]
internal sealed class Locale
{
	// Token: 0x06000008 RID: 8 RVA: 0x000145FA File Offset: 0x000127FA
	[global::Cpp2ILInjected.Token(Token = "0x600002E")]
	[global::Cpp2ILInjected.Address(RVA = "0x1AAA64C", Offset = "0x1AAA64C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 81)]
	public static string GetText(string msg)
	{
		throw null;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x000145FD File Offset: 0x000127FD
	[global::Cpp2ILInjected.Token(Token = "0x600002F")]
	[global::Cpp2ILInjected.Address(RVA = "0x1AAA650", Offset = "0x1AAA650", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.SymmetricTransform), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(global::System.Security.Cryptography.SymmetricAlgorithm),
		typeof(bool),
		typeof(byte[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RC2Transform), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(global::System.Security.Cryptography.RC2),
		typeof(bool),
		typeof(byte[]),
		typeof(byte[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.PublicKey", Member = "get_Key", ReturnType = typeof(global::System.Security.Cryptography.AsymmetricAlgorithm))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new object[]
	{
		"System.Security.Cryptography.X509Certificates.X509FindType",
		typeof(object),
		typeof(bool)
	}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Store", Member = "Open", MemberParameters = new object[] { "System.Security.Cryptography.X509Certificates.OpenFlags" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AesTransform", Member = ".ctor", MemberParameters = new object[]
	{
		typeof(global::System.Security.Cryptography.Aes),
		typeof(bool),
		"System.Byte[]",
		"System.Byte[]"
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object[])
	}, ReturnType = typeof(string))]
	public static string GetText(string fmt, params object[] args)
	{
		throw null;
	}
}
