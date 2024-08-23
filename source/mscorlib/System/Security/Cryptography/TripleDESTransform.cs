using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x0200027D RID: 637
	[global::Cpp2ILInjected.Token(Token = "0x200031A")]
	internal class TripleDESTransform : Mono.Security.Cryptography.SymmetricTransform
	{
		// Token: 0x060018D5 RID: 6357 RVA: 0x00018AF7 File Offset: 0x00016CF7
		[global::Cpp2ILInjected.Token(Token = "0x6001AEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1C610", Offset = "0x1B1C610", Length = "0x310")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDESCryptoServiceProvider), Member = "CreateEncryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDESCryptoServiceProvider), Member = "CreateDecryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.SymmetricTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SymmetricAlgorithm),
			typeof(bool),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TripleDESTransform), Member = "GetStrongKey", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TripleDES), Member = "IsWeakKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DES), Member = "Create", ReturnType = typeof(DES))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DESTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SymmetricAlgorithm),
			typeof(bool),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public TripleDESTransform(TripleDES algo, bool encryption, byte[] key, byte[] iv)
		{
			throw null;
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x00018AFA File Offset: 0x00016CFA
		[global::Cpp2ILInjected.Token(Token = "0x6001AF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1C9C8", Offset = "0x1B1C9C8", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DESTransform), Member = "Permutation", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(uint[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DESTransform), Member = "ProcessBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected override void ECB(byte[] input, byte[] output)
		{
			throw null;
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x00018AFD File Offset: 0x00016CFD
		[global::Cpp2ILInjected.Token(Token = "0x6001AF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1C920", Offset = "0x1B1C920", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDESTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TripleDES),
			typeof(bool),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.KeyBuilder), Member = "Key", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TripleDES), Member = "IsWeakKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static byte[] GetStrongKey()
		{
			throw null;
		}

		// Token: 0x04000ADB RID: 2779
		[global::Cpp2ILInjected.Token(Token = "0x4000DB5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private DESTransform E1;

		// Token: 0x04000ADC RID: 2780
		[global::Cpp2ILInjected.Token(Token = "0x4000DB6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private DESTransform D2;

		// Token: 0x04000ADD RID: 2781
		[global::Cpp2ILInjected.Token(Token = "0x4000DB7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private DESTransform E3;

		// Token: 0x04000ADE RID: 2782
		[global::Cpp2ILInjected.Token(Token = "0x4000DB8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private DESTransform D1;

		// Token: 0x04000ADF RID: 2783
		[global::Cpp2ILInjected.Token(Token = "0x4000DB9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private DESTransform E2;

		// Token: 0x04000AE0 RID: 2784
		[global::Cpp2ILInjected.Token(Token = "0x4000DBA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private DESTransform D3;
	}
}
