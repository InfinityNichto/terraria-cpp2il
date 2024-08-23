using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000274 RID: 628
	[global::Cpp2ILInjected.Token(Token = "0x2000311")]
	internal class DESTransform : Mono.Security.Cryptography.SymmetricTransform
	{
		// Token: 0x06001877 RID: 6263 RVA: 0x000189E9 File Offset: 0x00016BE9
		[global::Cpp2ILInjected.Token(Token = "0x6001A91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B16248", Offset = "0x1B16248", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "CreateEncryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "CreateDecryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDESTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TripleDES),
			typeof(bool),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.SymmetricTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SymmetricAlgorithm),
			typeof(bool),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DESTransform), Member = "GetStrongKey", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DES), Member = "IsWeakKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DES), Member = "IsSemiWeakKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DESTransform), Member = "SetKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		internal DESTransform(SymmetricAlgorithm symmAlgo, bool encryption, byte[] key, byte[] iv)
		{
			throw null;
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x000189EC File Offset: 0x00016BEC
		[global::Cpp2ILInjected.Token(Token = "0x6001A92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B16810", Offset = "0x1B16810", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESTransform), Member = "ProcessBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 31)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private uint CipherFunct(uint r, int n)
		{
			throw null;
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x000189EF File Offset: 0x00016BEF
		[global::Cpp2ILInjected.Token(Token = "0x6001A93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B16960", Offset = "0x1B16960", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESTransform), Member = "ECB", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDESTransform), Member = "ECB", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static void Permutation(byte[] input, byte[] output, uint[] permTab, bool preSwap)
		{
			throw null;
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x000189F2 File Offset: 0x00016BF2
		[global::Cpp2ILInjected.Token(Token = "0x6001A94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B16BC8", Offset = "0x1B16BC8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void BSwap(byte[] byteBuff)
		{
			throw null;
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x000189F5 File Offset: 0x00016BF5
		[global::Cpp2ILInjected.Token(Token = "0x6001A95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B16538", Offset = "0x1B16538", Length = "0x2D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SymmetricAlgorithm),
			typeof(bool),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal void SetKey(byte[] key)
		{
			throw null;
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x000189F8 File Offset: 0x00016BF8
		[global::Cpp2ILInjected.Token(Token = "0x6001A96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B16C0C", Offset = "0x1B16C0C", Length = "0x34C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESTransform), Member = "ECB", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDESTransform), Member = "ECB", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DESTransform), Member = "CipherFunct", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(int)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void ProcessBlock(byte[] input, byte[] output)
		{
			throw null;
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x000189FB File Offset: 0x00016BFB
		[global::Cpp2ILInjected.Token(Token = "0x6001A97")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B16F58", Offset = "0x1B16F58", Length = "0xA4")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void ECB(byte[] input, byte[] output)
		{
			throw null;
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x000189FE File Offset: 0x00016BFE
		[global::Cpp2ILInjected.Token(Token = "0x6001A98")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B16460", Offset = "0x1B16460", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SymmetricAlgorithm),
			typeof(bool),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.KeyBuilder), Member = "Key", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DES), Member = "IsWeakKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DES), Member = "IsSemiWeakKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static byte[] GetStrongKey()
		{
			throw null;
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x00018A01 File Offset: 0x00016C01
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001A99")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B16FFC", Offset = "0x1B16FFC", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		static DESTransform()
		{
			throw null;
		}

		// Token: 0x04000AAB RID: 2731
		[global::Cpp2ILInjected.Token(Token = "0x4000D85")]
		internal static readonly int KEY_BIT_SIZE;

		// Token: 0x04000AAC RID: 2732
		[global::Cpp2ILInjected.Token(Token = "0x4000D86")]
		internal static readonly int KEY_BYTE_SIZE;

		// Token: 0x04000AAD RID: 2733
		[global::Cpp2ILInjected.Token(Token = "0x4000D87")]
		internal static readonly int BLOCK_BIT_SIZE;

		// Token: 0x04000AAE RID: 2734
		[global::Cpp2ILInjected.Token(Token = "0x4000D88")]
		internal static readonly int BLOCK_BYTE_SIZE;

		// Token: 0x04000AAF RID: 2735
		[global::Cpp2ILInjected.Token(Token = "0x4000D89")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private byte[] keySchedule;

		// Token: 0x04000AB0 RID: 2736
		[global::Cpp2ILInjected.Token(Token = "0x4000D8A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private byte[] byteBuff;

		// Token: 0x04000AB1 RID: 2737
		[global::Cpp2ILInjected.Token(Token = "0x4000D8B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private uint[] dwordBuff;

		// Token: 0x04000AB2 RID: 2738
		[global::Cpp2ILInjected.Token(Token = "0x4000D8C")]
		private static readonly uint[] spBoxes;

		// Token: 0x04000AB3 RID: 2739
		[global::Cpp2ILInjected.Token(Token = "0x4000D8D")]
		private static readonly byte[] PC1;

		// Token: 0x04000AB4 RID: 2740
		[global::Cpp2ILInjected.Token(Token = "0x4000D8E")]
		private static readonly byte[] leftRotTotal;

		// Token: 0x04000AB5 RID: 2741
		[global::Cpp2ILInjected.Token(Token = "0x4000D8F")]
		private static readonly byte[] PC2;

		// Token: 0x04000AB6 RID: 2742
		[global::Cpp2ILInjected.Token(Token = "0x4000D90")]
		internal static readonly uint[] ipTab;

		// Token: 0x04000AB7 RID: 2743
		[global::Cpp2ILInjected.Token(Token = "0x4000D91")]
		internal static readonly uint[] fpTab;
	}
}
