using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x0200024E RID: 590
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002EB")]
	public sealed class RC2CryptoServiceProvider : RC2
	{
		// Token: 0x060016FA RID: 5882 RVA: 0x00018584 File Offset: 0x00016784
		[global::Cpp2ILInjected.Token(Token = "0x6001914")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B01EC8", Offset = "0x1B01EC8", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RC2), Member = "Create", ReturnType = typeof(RC2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RC2), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "get_AllowOnlyFipsAlgorithms", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "HasAlgorithm", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public RC2CryptoServiceProvider()
		{
			throw null;
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060016FB RID: 5883 RVA: 0x00018587 File Offset: 0x00016787
		// (set) Token: 0x060016FC RID: 5884 RVA: 0x0001858A File Offset: 0x0001678A
		[global::Cpp2ILInjected.Token(Token = "0x170002B2")]
		public override int EffectiveKeySize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001915")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B02228", Offset = "0x1B02228", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001916")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B02230", Offset = "0x1B02230", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x0001858D File Offset: 0x0001678D
		// (set) Token: 0x060016FE RID: 5886 RVA: 0x00018590 File Offset: 0x00016790
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170002B3")]
		public bool UseSalt
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001917")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0229C", Offset = "0x1B0229C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001918")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B022A4", Offset = "0x1B022A4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00018593 File Offset: 0x00016793
		[global::Cpp2ILInjected.Token(Token = "0x6001919")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B022B0", Offset = "0x1B022B0", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RC2Transform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(RC2),
			typeof(bool),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			throw null;
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x00018596 File Offset: 0x00016796
		[global::Cpp2ILInjected.Token(Token = "0x600191A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B02378", Offset = "0x1B02378", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RC2Transform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(RC2),
			typeof(bool),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			throw null;
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x00018599 File Offset: 0x00016799
		[global::Cpp2ILInjected.Token(Token = "0x600191B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B02440", Offset = "0x1B02440", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "get_StaticRandomNumberGenerator", ReturnType = typeof(RNGCryptoServiceProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void GenerateKey()
		{
			throw null;
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x0001859C File Offset: 0x0001679C
		[global::Cpp2ILInjected.Token(Token = "0x600191C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B024E0", Offset = "0x1B024E0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "get_StaticRandomNumberGenerator", ReturnType = typeof(RNGCryptoServiceProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void GenerateIV()
		{
			throw null;
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x0001859F File Offset: 0x0001679F
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600191D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B02570", Offset = "0x1B02570", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static RC2CryptoServiceProvider()
		{
			throw null;
		}

		// Token: 0x040009F8 RID: 2552
		[global::Cpp2ILInjected.Token(Token = "0x4000CD2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool m_use40bitSalt;

		// Token: 0x040009F9 RID: 2553
		[global::Cpp2ILInjected.Token(Token = "0x4000CD3")]
		private static KeySizes[] s_legalKeySizes;
	}
}
