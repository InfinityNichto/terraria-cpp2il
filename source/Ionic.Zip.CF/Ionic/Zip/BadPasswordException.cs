using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zip
{
	// Token: 0x02000010 RID: 16
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000B")]
	[global::Cpp2ILInjected.Token(Token = "0x2000010")]
	[Serializable]
	public class BadPasswordException : ZipException
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00004F66 File Offset: 0x00003166
		[global::Cpp2ILInjected.Token(Token = "0x600004A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A459E4", Offset = "0x1A459E4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", ReturnType = typeof(void))]
		public BadPasswordException()
		{
			throw null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004F69 File Offset: 0x00003169
		[global::Cpp2ILInjected.Token(Token = "0x600004B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A459E8", Offset = "0x1A459E8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipCrypto), Member = "ForWrite", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipCrypto))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipCrypto), Member = "ForRead", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry)
		}, ReturnType = typeof(ZipCrypto))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public BadPasswordException(string message)
		{
			throw null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004F6C File Offset: 0x0000316C
		[global::Cpp2ILInjected.Token(Token = "0x600004C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A459EC", Offset = "0x1A459EC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		public BadPasswordException(string message, Exception innerException)
		{
			throw null;
		}
	}
}
