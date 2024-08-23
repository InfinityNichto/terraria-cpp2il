using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000235 RID: 565
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002D2")]
	public sealed class CspParameters
	{
		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06001637 RID: 5687 RVA: 0x00018365 File Offset: 0x00016565
		// (set) Token: 0x06001638 RID: 5688 RVA: 0x00018368 File Offset: 0x00016568
		[global::Cpp2ILInjected.Token(Token = "0x17000294")]
		public CspProviderFlags Flags
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001851")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFA5FC", Offset = "0x1AFA5FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001852")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFA604", Offset = "0x1AFA604", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "Copy", MemberParameters = new object[] { typeof(CspParameters) }, ReturnType = typeof(CspParameters))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CspParameters), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(string),
				typeof(string),
				typeof(CspProviderFlags)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CspParameters), Member = ".ctor", MemberParameters = new object[] { typeof(CspParameters) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "ImportCspBlob", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.CryptoConvert", Member = "FromCapiPrivateKeyBlob", MemberParameters = new object[]
			{
				"System.Byte[]",
				typeof(int)
			}, ReturnType = typeof(RSA))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.PKCS8.PrivateKeyInfo", Member = "DecodeRSA", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(RSA))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06001639 RID: 5689 RVA: 0x0001836B File Offset: 0x0001656B
		// (set) Token: 0x0600163A RID: 5690 RVA: 0x0001836E File Offset: 0x0001656E
		[global::Cpp2ILInjected.Token(Token = "0x17000295")]
		public global::System.Security.AccessControl.CryptoKeySecurity CryptoKeySecurity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001853")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFA6D4", Offset = "0x1AFA6D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001854")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFA6DC", Offset = "0x1AFA6DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x00018371 File Offset: 0x00016571
		// (set) Token: 0x0600163C RID: 5692 RVA: 0x00018374 File Offset: 0x00016574
		[global::Cpp2ILInjected.Token(Token = "0x17000296")]
		public SecureString KeyPassword
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001855")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFA6E4", Offset = "0x1AFA6E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001856")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFA6EC", Offset = "0x1AFA6EC", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x00018377 File Offset: 0x00016577
		// (set) Token: 0x0600163E RID: 5694 RVA: 0x0001837A File Offset: 0x0001657A
		[global::Cpp2ILInjected.Token(Token = "0x17000297")]
		public global::System.IntPtr ParentWindowHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001857")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFA74C", Offset = "0x1AFA74C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001858")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFA754", Offset = "0x1AFA754", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x0001837D File Offset: 0x0001657D
		[global::Cpp2ILInjected.Token(Token = "0x6001859")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA75C", Offset = "0x1AFA75C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.CryptoConvert", Member = "FromCapiPrivateKeyBlob", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int)
		}, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.PKCS8.PrivateKeyInfo", Member = "DecodeRSA", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CspParameters()
		{
			throw null;
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00018380 File Offset: 0x00016580
		[global::Cpp2ILInjected.Token(Token = "0x600185A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA7CC", Offset = "0x1AFA7CC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "ImportCspBlob", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CspParameters(int dwTypeIn)
		{
			throw null;
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00018383 File Offset: 0x00016583
		[global::Cpp2ILInjected.Token(Token = "0x600185B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA800", Offset = "0x1AFA800", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CspParameters(int dwTypeIn, string strProviderNameIn)
		{
			throw null;
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00018386 File Offset: 0x00016586
		[global::Cpp2ILInjected.Token(Token = "0x600185C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA788", Offset = "0x1AFA788", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "Copy", MemberParameters = new object[] { typeof(CspParameters) }, ReturnType = typeof(CspParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CspParameters(int dwTypeIn, string strProviderNameIn, string strContainerNameIn)
		{
			throw null;
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00018389 File Offset: 0x00016589
		[global::Cpp2ILInjected.Token(Token = "0x600185D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA888", Offset = "0x1AFA888", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CspParameters(int providerType, string providerName, string keyContainerName, global::System.Security.AccessControl.CryptoKeySecurity cryptoKeySecurity, SecureString keyPassword)
		{
			throw null;
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x0001838C File Offset: 0x0001658C
		[global::Cpp2ILInjected.Token(Token = "0x600185E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA8E0", Offset = "0x1AFA8E0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CspParameters(int providerType, string providerName, string keyContainerName, global::System.Security.AccessControl.CryptoKeySecurity cryptoKeySecurity, global::System.IntPtr parentWindowHandle)
		{
			throw null;
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x0001838F File Offset: 0x0001658F
		[global::Cpp2ILInjected.Token(Token = "0x600185F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA838", Offset = "0x1AFA838", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CspParameters), Member = "set_Flags", MemberParameters = new object[] { typeof(CspProviderFlags) }, ReturnType = typeof(void))]
		internal CspParameters(int providerType, string providerName, string keyContainerName, CspProviderFlags flags)
		{
			throw null;
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00018392 File Offset: 0x00016592
		[global::Cpp2ILInjected.Token(Token = "0x6001860")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA93C", Offset = "0x1AFA93C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CspParameters), Member = "set_Flags", MemberParameters = new object[] { typeof(CspProviderFlags) }, ReturnType = typeof(void))]
		internal CspParameters(CspParameters parameters)
		{
			throw null;
		}

		// Token: 0x040009C1 RID: 2497
		[global::Cpp2ILInjected.Token(Token = "0x4000C9B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int ProviderType;

		// Token: 0x040009C2 RID: 2498
		[global::Cpp2ILInjected.Token(Token = "0x4000C9C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public string ProviderName;

		// Token: 0x040009C3 RID: 2499
		[global::Cpp2ILInjected.Token(Token = "0x4000C9D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public string KeyContainerName;

		// Token: 0x040009C4 RID: 2500
		[global::Cpp2ILInjected.Token(Token = "0x4000C9E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int KeyNumber;

		// Token: 0x040009C5 RID: 2501
		[global::Cpp2ILInjected.Token(Token = "0x4000C9F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int m_flags;

		// Token: 0x040009C6 RID: 2502
		[global::Cpp2ILInjected.Token(Token = "0x4000CA0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private global::System.Security.AccessControl.CryptoKeySecurity m_cryptoKeySecurity;

		// Token: 0x040009C7 RID: 2503
		[global::Cpp2ILInjected.Token(Token = "0x4000CA1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private SecureString m_keyPassword;

		// Token: 0x040009C8 RID: 2504
		[global::Cpp2ILInjected.Token(Token = "0x4000CA2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private global::System.IntPtr m_parentWindowHandle;
	}
}
