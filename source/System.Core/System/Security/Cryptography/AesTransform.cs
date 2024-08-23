using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000005 RID: 5
	[global::Cpp2ILInjected.Token(Token = "0x2000005")]
	internal class AesTransform : SymmetricTransform
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00004343 File Offset: 0x00002543
		[global::Cpp2ILInjected.Token(Token = "0x600002A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3CAD4", Offset = "0x1D3CAD4", Length = "0x570")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AesCryptoServiceProvider), Member = "CreateDecryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AesCryptoServiceProvider), Member = "CreateEncryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Security.Cryptography.SymmetricTransform", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SymmetricAlgorithm),
			typeof(bool),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AesTransform), Member = "SubByte", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Locale", Member = "GetText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		public AesTransform(Aes algo, bool encryption, byte[] key, byte[] iv)
		{
			throw null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004346 File Offset: 0x00002546
		[global::Cpp2ILInjected.Token(Token = "0x600002B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3D320", Offset = "0x1D3D320", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AesTransform), Member = "Decrypt128", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(uint[])
		}, ReturnType = typeof(void))]
		protected override void ECB(byte[] input, byte[] output)
		{
			throw null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004349 File Offset: 0x00002549
		[global::Cpp2ILInjected.Token(Token = "0x600002C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3D294", Offset = "0x1D3D294", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AesTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Aes),
			typeof(bool),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private uint SubByte(uint a)
		{
			throw null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000434C File Offset: 0x0000254C
		[global::Cpp2ILInjected.Token(Token = "0x600002D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3D334", Offset = "0x1D3D334", Length = "0xDE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void Encrypt128(byte[] indata, byte[] outdata, uint[] ekey)
		{
			throw null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000434F File Offset: 0x0000254F
		[global::Cpp2ILInjected.Token(Token = "0x600002E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3E114", Offset = "0x1D3E114", Length = "0xDE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AesTransform), Member = "ECB", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void Decrypt128(byte[] indata, byte[] outdata, uint[] ekey)
		{
			throw null;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004352 File Offset: 0x00002552
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600002F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3EEF8", Offset = "0x1D3EEF8", Length = "0x318")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		static AesTransform()
		{
			throw null;
		}

		// Token: 0x04000002 RID: 2
		[global::Cpp2ILInjected.Token(Token = "0x4000002")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private uint[] expandedKey;

		// Token: 0x04000003 RID: 3
		[global::Cpp2ILInjected.Token(Token = "0x4000003")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private int Nk;

		// Token: 0x04000004 RID: 4
		[global::Cpp2ILInjected.Token(Token = "0x4000004")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		private int Nr;

		// Token: 0x04000005 RID: 5
		[global::Cpp2ILInjected.Token(Token = "0x4000005")]
		private static readonly uint[] Rcon;

		// Token: 0x04000006 RID: 6
		[global::Cpp2ILInjected.Token(Token = "0x4000006")]
		private static readonly byte[] SBox;

		// Token: 0x04000007 RID: 7
		[global::Cpp2ILInjected.Token(Token = "0x4000007")]
		private static readonly byte[] iSBox;

		// Token: 0x04000008 RID: 8
		[global::Cpp2ILInjected.Token(Token = "0x4000008")]
		private static readonly uint[] T0;

		// Token: 0x04000009 RID: 9
		[global::Cpp2ILInjected.Token(Token = "0x4000009")]
		private static readonly uint[] T1;

		// Token: 0x0400000A RID: 10
		[global::Cpp2ILInjected.Token(Token = "0x400000A")]
		private static readonly uint[] T2;

		// Token: 0x0400000B RID: 11
		[global::Cpp2ILInjected.Token(Token = "0x400000B")]
		private static readonly uint[] T3;

		// Token: 0x0400000C RID: 12
		[global::Cpp2ILInjected.Token(Token = "0x400000C")]
		private static readonly uint[] iT0;

		// Token: 0x0400000D RID: 13
		[global::Cpp2ILInjected.Token(Token = "0x400000D")]
		private static readonly uint[] iT1;

		// Token: 0x0400000E RID: 14
		[global::Cpp2ILInjected.Token(Token = "0x400000E")]
		private static readonly uint[] iT2;

		// Token: 0x0400000F RID: 15
		[global::Cpp2ILInjected.Token(Token = "0x400000F")]
		private static readonly uint[] iT3;
	}
}
