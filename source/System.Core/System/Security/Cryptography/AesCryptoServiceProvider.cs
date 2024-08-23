using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000004 RID: 4
	[global::Cpp2ILInjected.Token(Token = "0x2000004")]
	public sealed class AesCryptoServiceProvider : Aes
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00004307 File Offset: 0x00002507
		[global::Cpp2ILInjected.Token(Token = "0x6000016")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3C938", Offset = "0x1D3C938", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Aes), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public AesCryptoServiceProvider()
		{
			throw null;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000430A File Offset: 0x0000250A
		[global::Cpp2ILInjected.Token(Token = "0x6000017")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3C99C", Offset = "0x1D3C99C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Security.Cryptography.KeyBuilder", Member = "IV", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		public override void GenerateIV()
		{
			throw null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000430D File Offset: 0x0000250D
		[global::Cpp2ILInjected.Token(Token = "0x6000018")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3C9C0", Offset = "0x1D3C9C0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Security.Cryptography.KeyBuilder", Member = "Key", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		public override void GenerateKey()
		{
			throw null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00004310 File Offset: 0x00002510
		[global::Cpp2ILInjected.Token(Token = "0x6000019")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3C9E4", Offset = "0x1D3C9E4", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AesTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Aes),
			typeof(bool),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv)
		{
			throw null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00004313 File Offset: 0x00002513
		[global::Cpp2ILInjected.Token(Token = "0x600001A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3D044", Offset = "0x1D3D044", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AesTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Aes),
			typeof(bool),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv)
		{
			throw null;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00004316 File Offset: 0x00002516
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00004319 File Offset: 0x00002519
		[global::Cpp2ILInjected.Token(Token = "0x17000007")]
		public override byte[] IV
		{
			[global::Cpp2ILInjected.Token(Token = "0x600001B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3D134", Offset = "0x1D3D134", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = "get_IV", ReturnType = typeof(byte[]))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600001C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3D13C", Offset = "0x1D3D13C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = "set_IV", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001D RID: 29 RVA: 0x0000431C File Offset: 0x0000251C
		// (set) Token: 0x0600001E RID: 30 RVA: 0x0000431F File Offset: 0x0000251F
		[global::Cpp2ILInjected.Token(Token = "0x17000008")]
		public override byte[] Key
		{
			[global::Cpp2ILInjected.Token(Token = "0x600001D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3D144", Offset = "0x1D3D144", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = "get_Key", ReturnType = typeof(byte[]))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600001E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3D14C", Offset = "0x1D3D14C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = "set_Key", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00004322 File Offset: 0x00002522
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00004325 File Offset: 0x00002525
		[global::Cpp2ILInjected.Token(Token = "0x17000009")]
		public override int KeySize
		{
			[global::Cpp2ILInjected.Token(Token = "0x600001F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3D154", Offset = "0x1D3D154", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000020")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3D15C", Offset = "0x1D3D15C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = "set_KeySize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00004328 File Offset: 0x00002528
		// (set) Token: 0x06000022 RID: 34 RVA: 0x0000432B File Offset: 0x0000252B
		[global::Cpp2ILInjected.Token(Token = "0x1700000A")]
		public override int FeedbackSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000021")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3D164", Offset = "0x1D3D164", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000022")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3D16C", Offset = "0x1D3D16C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = "set_FeedbackSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000023 RID: 35 RVA: 0x0000432E File Offset: 0x0000252E
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00004331 File Offset: 0x00002531
		[global::Cpp2ILInjected.Token(Token = "0x1700000B")]
		public override CipherMode Mode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000023")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3D174", Offset = "0x1D3D174", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000024")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3D17C", Offset = "0x1D3D17C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = "set_Mode", MemberParameters = new object[] { typeof(CipherMode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00004334 File Offset: 0x00002534
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00004337 File Offset: 0x00002537
		[global::Cpp2ILInjected.Token(Token = "0x1700000C")]
		public override PaddingMode Padding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000025")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3D1D8", Offset = "0x1D3D1D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000026")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3D1E0", Offset = "0x1D3D1E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = "set_Padding", MemberParameters = new object[] { typeof(PaddingMode) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000433A File Offset: 0x0000253A
		[global::Cpp2ILInjected.Token(Token = "0x6000027")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3D1E8", Offset = "0x1D3D1E8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override ICryptoTransform CreateDecryptor()
		{
			throw null;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000433D File Offset: 0x0000253D
		[global::Cpp2ILInjected.Token(Token = "0x6000028")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3D238", Offset = "0x1D3D238", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override ICryptoTransform CreateEncryptor()
		{
			throw null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00004340 File Offset: 0x00002540
		[global::Cpp2ILInjected.Token(Token = "0x6000029")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3D288", Offset = "0x1D3D288", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}
	}
}
