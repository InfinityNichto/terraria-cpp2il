using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x0200027C RID: 636
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000319")]
	public sealed class SHA1CryptoServiceProvider : SHA1
	{
		// Token: 0x060018CF RID: 6351 RVA: 0x00018AE5 File Offset: 0x00016CE5
		[global::Cpp2ILInjected.Token(Token = "0x6001AE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1C4B0", Offset = "0x1B1C4B0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA1), Member = "Create", ReturnType = typeof(SHA1))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfigForwarder), Member = "CreateDefaultHashAlgorithm", ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1Internal), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public SHA1CryptoServiceProvider()
		{
			throw null;
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x00018AE8 File Offset: 0x00016CE8
		[global::Cpp2ILInjected.Token(Token = "0x6001AEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1C510", Offset = "0x1B1C510", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x00018AEB File Offset: 0x00016CEB
		[global::Cpp2ILInjected.Token(Token = "0x6001AEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1C5B4", Offset = "0x1B1C5B4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x00018AEE File Offset: 0x00016CEE
		[global::Cpp2ILInjected.Token(Token = "0x6001AEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1C5C0", Offset = "0x1B1C5C0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1Internal), Member = "HashCore", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
			throw null;
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x00018AF1 File Offset: 0x00016CF1
		[global::Cpp2ILInjected.Token(Token = "0x6001AED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1C5D4", Offset = "0x1B1C5D4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1Internal), Member = "HashFinal", ReturnType = typeof(byte[]))]
		protected override byte[] HashFinal()
		{
			throw null;
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x00018AF4 File Offset: 0x00016CF4
		[global::Cpp2ILInjected.Token(Token = "0x6001AEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1C5E4", Offset = "0x1B1C5E4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Initialize()
		{
			throw null;
		}

		// Token: 0x04000ADA RID: 2778
		[global::Cpp2ILInjected.Token(Token = "0x4000DB4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private SHA1Internal sha;
	}
}
