using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x0200026B RID: 619
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000308")]
	public abstract class SymmetricAlgorithm : global::System.IDisposable
	{
		// Token: 0x0600180D RID: 6157 RVA: 0x000188B7 File Offset: 0x00016AB7
		[global::Cpp2ILInjected.Token(Token = "0x6001A27")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B10CD8", Offset = "0x1B10CD8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Aes), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DES), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RC2), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rijndael), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.RC4", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected SymmetricAlgorithm()
		{
			throw null;
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x000188BA File Offset: 0x00016ABA
		[global::Cpp2ILInjected.Token(Token = "0x6001A28")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B10CFC", Offset = "0x1B10CFC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x000188BD File Offset: 0x00016ABD
		[global::Cpp2ILInjected.Token(Token = "0x6001A29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B10D68", Offset = "0x1B10D68", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MACTripleDES), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "Decrypt", MemberParameters = new object[]
		{
			typeof(string),
			"System.Byte[]",
			typeof(int),
			"System.Byte[]"
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse", Member = "set_Password", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_LM", MemberParameters = new object[]
		{
			typeof(string),
			"System.Byte[]"
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x000188C0 File Offset: 0x00016AC0
		[global::Cpp2ILInjected.Token(Token = "0x6001A2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B10DFC", Offset = "0x1B10DFC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AesManaged", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x000188C3 File Offset: 0x00016AC3
		// (set) Token: 0x06001812 RID: 6162 RVA: 0x000188C6 File Offset: 0x00016AC6
		[global::Cpp2ILInjected.Token(Token = "0x170002D2")]
		public virtual int BlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A2B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B10E48", Offset = "0x1B10E48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A2C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B10E50", Offset = "0x1B10E50", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x000188C9 File Offset: 0x00016AC9
		// (set) Token: 0x06001814 RID: 6164 RVA: 0x000188CC File Offset: 0x00016ACC
		[global::Cpp2ILInjected.Token(Token = "0x170002D3")]
		public virtual int FeedbackSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A2D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B10F24", Offset = "0x1B10F24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A2E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B10F2C", Offset = "0x1B10F2C", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_FeedbackSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06001815 RID: 6165 RVA: 0x000188CF File Offset: 0x00016ACF
		// (set) Token: 0x06001816 RID: 6166 RVA: 0x000188D2 File Offset: 0x00016AD2
		[global::Cpp2ILInjected.Token(Token = "0x170002D4")]
		public virtual byte[] IV
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A2F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B10FB0", Offset = "0x1B10FB0", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "get_IV", ReturnType = "System.Byte[]")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A30")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1103C", Offset = "0x1B1103C", Length = "0x15C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_IV", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06001817 RID: 6167 RVA: 0x000188D5 File Offset: 0x00016AD5
		// (set) Token: 0x06001818 RID: 6168 RVA: 0x000188D8 File Offset: 0x00016AD8
		[global::Cpp2ILInjected.Token(Token = "0x170002D5")]
		public virtual byte[] Key
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A31")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B11198", Offset = "0x1B11198", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "get_Key", ReturnType = "System.Byte[]")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A32")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B11224", Offset = "0x1B11224", Length = "0x154")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_Key", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = "ValidKeySize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06001819 RID: 6169 RVA: 0x000188DB File Offset: 0x00016ADB
		[global::Cpp2ILInjected.Token(Token = "0x170002D6")]
		public virtual KeySizes[] LegalBlockSizes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A33")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B11404", Offset = "0x1B11404", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x000188DE File Offset: 0x00016ADE
		[global::Cpp2ILInjected.Token(Token = "0x170002D7")]
		public virtual KeySizes[] LegalKeySizes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A34")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B11474", Offset = "0x1B11474", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x000188E1 File Offset: 0x00016AE1
		// (set) Token: 0x0600181C RID: 6172 RVA: 0x000188E4 File Offset: 0x00016AE4
		[global::Cpp2ILInjected.Token(Token = "0x170002D8")]
		public virtual int KeySize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A35")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B114E4", Offset = "0x1B114E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A36")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B114EC", Offset = "0x1B114EC", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RC2), Member = "set_KeySize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_KeySize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = "ValidKeySize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x0600181D RID: 6173 RVA: 0x000188E7 File Offset: 0x00016AE7
		// (set) Token: 0x0600181E RID: 6174 RVA: 0x000188EA File Offset: 0x00016AEA
		[global::Cpp2ILInjected.Token(Token = "0x170002D9")]
		public virtual CipherMode Mode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A37")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B11568", Offset = "0x1B11568", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A38")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B11570", Offset = "0x1B11570", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_Mode", MemberParameters = new object[] { typeof(CipherMode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x000188ED File Offset: 0x00016AED
		// (set) Token: 0x06001820 RID: 6176 RVA: 0x000188F0 File Offset: 0x00016AF0
		[global::Cpp2ILInjected.Token(Token = "0x170002DA")]
		public virtual PaddingMode Padding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A39")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B115E4", Offset = "0x1B115E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A3A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B115EC", Offset = "0x1B115EC", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_Padding", MemberParameters = new object[] { typeof(PaddingMode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x000188F3 File Offset: 0x00016AF3
		[global::Cpp2ILInjected.Token(Token = "0x6001A3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B11378", Offset = "0x1B11378", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DES), Member = "set_Key", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RC2), Member = "set_EffectiveKeySize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SymmetricAlgorithm), Member = "set_Key", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SymmetricAlgorithm), Member = "set_KeySize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDES), Member = "set_Key", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AesManaged", Member = "CreateDecryptor", MemberParameters = new object[] { "System.Byte[]", "System.Byte[]" }, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AesManaged", Member = "CreateEncryptor", MemberParameters = new object[] { "System.Byte[]", "System.Byte[]" }, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		public bool ValidKeySize(int bitLength)
		{
			throw null;
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x000188F6 File Offset: 0x00016AF6
		[global::Cpp2ILInjected.Token(Token = "0x6001A3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B11660", Offset = "0x1B11660", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RijndaelManaged), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static SymmetricAlgorithm Create()
		{
			throw null;
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x000188F9 File Offset: 0x00016AF9
		[global::Cpp2ILInjected.Token(Token = "0x6001A3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B116B4", Offset = "0x1B116B4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "GetSymmetricAlgorithm", MemberParameters = new object[]
		{
			typeof(string),
			"System.Byte[]",
			typeof(int)
		}, ReturnType = typeof(SymmetricAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static SymmetricAlgorithm Create(string algName)
		{
			throw null;
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x000188FC File Offset: 0x00016AFC
		[global::Cpp2ILInjected.Token(Token = "0x6001A3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B11754", Offset = "0x1B11754", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual ICryptoTransform CreateEncryptor()
		{
			throw null;
		}

		// Token: 0x06001825 RID: 6181
		[global::Cpp2ILInjected.Token(Token = "0x6001A3F")]
		public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);

		// Token: 0x06001826 RID: 6182 RVA: 0x000188FF File Offset: 0x00016AFF
		[global::Cpp2ILInjected.Token(Token = "0x6001A40")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B117A4", Offset = "0x1B117A4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual ICryptoTransform CreateDecryptor()
		{
			throw null;
		}

		// Token: 0x06001827 RID: 6183
		[global::Cpp2ILInjected.Token(Token = "0x6001A41")]
		public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);

		// Token: 0x06001828 RID: 6184
		[global::Cpp2ILInjected.Token(Token = "0x6001A42")]
		public abstract void GenerateKey();

		// Token: 0x06001829 RID: 6185
		[global::Cpp2ILInjected.Token(Token = "0x6001A43")]
		public abstract void GenerateIV();

		// Token: 0x04000A51 RID: 2641
		[global::Cpp2ILInjected.Token(Token = "0x4000D2B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected int BlockSizeValue;

		// Token: 0x04000A52 RID: 2642
		[global::Cpp2ILInjected.Token(Token = "0x4000D2C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		protected int FeedbackSizeValue;

		// Token: 0x04000A53 RID: 2643
		[global::Cpp2ILInjected.Token(Token = "0x4000D2D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected byte[] IVValue;

		// Token: 0x04000A54 RID: 2644
		[global::Cpp2ILInjected.Token(Token = "0x4000D2E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected byte[] KeyValue;

		// Token: 0x04000A55 RID: 2645
		[global::Cpp2ILInjected.Token(Token = "0x4000D2F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected KeySizes[] LegalBlockSizesValue;

		// Token: 0x04000A56 RID: 2646
		[global::Cpp2ILInjected.Token(Token = "0x4000D30")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		protected KeySizes[] LegalKeySizesValue;

		// Token: 0x04000A57 RID: 2647
		[global::Cpp2ILInjected.Token(Token = "0x4000D31")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		protected int KeySizeValue;

		// Token: 0x04000A58 RID: 2648
		[global::Cpp2ILInjected.Token(Token = "0x4000D32")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		protected CipherMode ModeValue;

		// Token: 0x04000A59 RID: 2649
		[global::Cpp2ILInjected.Token(Token = "0x4000D33")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		protected PaddingMode PaddingValue;
	}
}
