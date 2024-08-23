using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000003 RID: 3
	[global::Cpp2ILInjected.Token(Token = "0x2000003")]
	public sealed class AesManaged : Aes
	{
		// Token: 0x06000002 RID: 2 RVA: 0x000042CB File Offset: 0x000024CB
		[global::Cpp2ILInjected.Token(Token = "0x6000002")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3C2C0", Offset = "0x1D3C2C0", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Aes), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "get_AllowOnlyFipsAlgorithms", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RijndaelManaged), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public AesManaged()
		{
			throw null;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x000042CE File Offset: 0x000024CE
		// (set) Token: 0x06000004 RID: 4 RVA: 0x000042D1 File Offset: 0x000024D1
		[global::Cpp2ILInjected.Token(Token = "0x17000001")]
		public override int FeedbackSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000003")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3C410", Offset = "0x1D3C410", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000004")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3C420", Offset = "0x1D3C420", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000042D4 File Offset: 0x000024D4
		// (set) Token: 0x06000006 RID: 6 RVA: 0x000042D7 File Offset: 0x000024D7
		[global::Cpp2ILInjected.Token(Token = "0x17000002")]
		public override byte[] IV
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000005")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3C430", Offset = "0x1D3C430", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000006")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3C440", Offset = "0x1D3C440", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000042DA File Offset: 0x000024DA
		// (set) Token: 0x06000008 RID: 8 RVA: 0x000042DD File Offset: 0x000024DD
		[global::Cpp2ILInjected.Token(Token = "0x17000003")]
		public override byte[] Key
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000007")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3C450", Offset = "0x1D3C450", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000008")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3C460", Offset = "0x1D3C460", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000042E0 File Offset: 0x000024E0
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000042E3 File Offset: 0x000024E3
		[global::Cpp2ILInjected.Token(Token = "0x17000004")]
		public override int KeySize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000009")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3C474", Offset = "0x1D3C474", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600000A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3C488", Offset = "0x1D3C488", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000042E6 File Offset: 0x000024E6
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000042E9 File Offset: 0x000024E9
		[global::Cpp2ILInjected.Token(Token = "0x17000005")]
		public override CipherMode Mode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3C49C", Offset = "0x1D3C49C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600000C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3C4B0", Offset = "0x1D3C4B0", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000042EC File Offset: 0x000024EC
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000042EF File Offset: 0x000024EF
		[global::Cpp2ILInjected.Token(Token = "0x17000006")]
		public override PaddingMode Padding
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3C528", Offset = "0x1D3C528", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600000E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3C53C", Offset = "0x1D3C53C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000042F2 File Offset: 0x000024F2
		[global::Cpp2ILInjected.Token(Token = "0x600000F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3C550", Offset = "0x1D3C550", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override ICryptoTransform CreateDecryptor()
		{
			throw null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000042F5 File Offset: 0x000024F5
		[global::Cpp2ILInjected.Token(Token = "0x6000010")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3C564", Offset = "0x1D3C564", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = "ValidKeySize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv)
		{
			throw null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000042F8 File Offset: 0x000024F8
		[global::Cpp2ILInjected.Token(Token = "0x6000011")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3C69C", Offset = "0x1D3C69C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override ICryptoTransform CreateEncryptor()
		{
			throw null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000042FB File Offset: 0x000024FB
		[global::Cpp2ILInjected.Token(Token = "0x6000012")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3C6B0", Offset = "0x1D3C6B0", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = "ValidKeySize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv)
		{
			throw null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000042FE File Offset: 0x000024FE
		[global::Cpp2ILInjected.Token(Token = "0x6000013")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3C7E8", Offset = "0x1D3C7E8", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00004301 File Offset: 0x00002501
		[global::Cpp2ILInjected.Token(Token = "0x6000014")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3C910", Offset = "0x1D3C910", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void GenerateIV()
		{
			throw null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00004304 File Offset: 0x00002504
		[global::Cpp2ILInjected.Token(Token = "0x6000015")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3C924", Offset = "0x1D3C924", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void GenerateKey()
		{
			throw null;
		}

		// Token: 0x04000001 RID: 1
		[global::Cpp2ILInjected.Token(Token = "0x4000001")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private RijndaelManaged m_rijndael;
	}
}
