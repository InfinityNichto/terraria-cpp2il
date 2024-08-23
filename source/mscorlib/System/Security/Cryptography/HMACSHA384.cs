using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000242 RID: 578
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002DF")]
	public class HMACSHA384 : HMAC
	{
		// Token: 0x06001698 RID: 5784 RVA: 0x00018476 File Offset: 0x00016676
		[global::Cpp2ILInjected.Token(Token = "0x60018B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFEB34", Offset = "0x1AFEB34", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public HMACSHA384()
		{
			throw null;
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00018479 File Offset: 0x00016679
		[global::Cpp2ILInjected.Token(Token = "0x60018B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFEB98", Offset = "0x1AFEB98", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = "OpenHmac", ReturnType = typeof(HMAC))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "_ProduceLegacyHmacValues", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA384Managed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HMAC), Member = "InitializeKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public HMACSHA384(byte[] key)
		{
			throw null;
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600169A RID: 5786 RVA: 0x0001847C File Offset: 0x0001667C
		[global::Cpp2ILInjected.Token(Token = "0x1700029C")]
		private int BlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFEC9C", Offset = "0x1AFEC9C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600169B RID: 5787 RVA: 0x0001847F File Offset: 0x0001667F
		// (set) Token: 0x0600169C RID: 5788 RVA: 0x00018482 File Offset: 0x00016682
		[global::Cpp2ILInjected.Token(Token = "0x1700029D")]
		public bool ProduceLegacyHmacValues
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFECB4", Offset = "0x1AFECB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60018B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFECBC", Offset = "0x1AFECBC", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HMAC), Member = "InitializeKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x040009DE RID: 2526
		[global::Cpp2ILInjected.Token(Token = "0x4000CB8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x61")]
		private bool m_useLegacyBlockSize;
	}
}
