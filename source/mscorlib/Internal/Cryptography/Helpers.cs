using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Internal.Cryptography
{
	// Token: 0x0200004B RID: 75
	[global::Cpp2ILInjected.Token(Token = "0x2000066")]
	internal static class Helpers
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x00014B40 File Offset: 0x00012D40
		[global::Cpp2ILInjected.Token(Token = "0x600023D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC7114", Offset = "0x1AC7114", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.Rfc2898DeriveBytes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(int),
			typeof(global::System.Security.Cryptography.HashAlgorithmName)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.Rfc2898DeriveBytes), Member = "get_Salt", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.Rfc2898DeriveBytes), Member = "set_Salt", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = "GetCertHash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = "GetRawCertData", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = "GetKeyAlgorithmParameters", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = "GetPublicKey", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = "GetSerialNumber", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_RawData", ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static byte[] CloneByteArray(this byte[] src)
		{
			throw null;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00014B43 File Offset: 0x00012D43
		[global::Cpp2ILInjected.Token(Token = "0x600023E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC718C", Offset = "0x1AC718C", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.Rfc2898DeriveBytes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.Security.Cryptography.HashAlgorithmName)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.RandomNumberGenerator), Member = "Create", ReturnType = typeof(global::System.Security.Cryptography.RandomNumberGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static byte[] GenerateRandom(int count)
		{
			throw null;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00014B46 File Offset: 0x00012D46
		[global::Cpp2ILInjected.Token(Token = "0x600023F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC7328", Offset = "0x1AC7328", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.Rfc2898DeriveBytes), Member = "Func", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static void WriteInt(uint i, byte[] arr, int offset)
		{
			throw null;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00014B49 File Offset: 0x00012D49
		[global::Cpp2ILInjected.Token(Token = "0x6000240")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC7358", Offset = "0x1AC7358", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Helpers), Member = "ToHexStringUpper", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static char[] ToHexArrayUpper(this byte[] bytes)
		{
			throw null;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00014B4C File Offset: 0x00012D4C
		[global::Cpp2ILInjected.Token(Token = "0x6000241")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC7428", Offset = "0x1AC7428", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = "GetCertHashString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = "GetSerialNumberString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_Thumbprint", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new object[]
		{
			"System.Security.Cryptography.X509Certificates.X509FindType",
			typeof(object),
			typeof(bool)
		}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Helpers), Member = "ToHexArrayUpper", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Ctor", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		public static string ToHexStringUpper(this byte[] bytes)
		{
			throw null;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00014B4F File Offset: 0x00012D4F
		[global::Cpp2ILInjected.Token(Token = "0x6000242")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC740C", Offset = "0x1AC740C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static char NibbleToHex(byte b)
		{
			throw null;
		}
	}
}
