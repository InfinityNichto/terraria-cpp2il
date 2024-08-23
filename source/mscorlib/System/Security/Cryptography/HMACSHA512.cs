using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000243 RID: 579
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002E0")]
	public class HMACSHA512 : HMAC
	{
		// Token: 0x0600169D RID: 5789 RVA: 0x00018485 File Offset: 0x00016685
		[global::Cpp2ILInjected.Token(Token = "0x60018B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFECE0", Offset = "0x1AFECE0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public HMACSHA512()
		{
			throw null;
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00018488 File Offset: 0x00016688
		[global::Cpp2ILInjected.Token(Token = "0x60018B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFED44", Offset = "0x1AFED44", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = "OpenHmac", ReturnType = typeof(HMAC))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "_ProduceLegacyHmacValues", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA512Managed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HMAC), Member = "InitializeKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public HMACSHA512(byte[] key)
		{
			throw null;
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600169F RID: 5791 RVA: 0x0001848B File Offset: 0x0001668B
		[global::Cpp2ILInjected.Token(Token = "0x1700029E")]
		private int BlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFEE48", Offset = "0x1AFEE48", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060016A0 RID: 5792 RVA: 0x0001848E File Offset: 0x0001668E
		// (set) Token: 0x060016A1 RID: 5793 RVA: 0x00018491 File Offset: 0x00016691
		[global::Cpp2ILInjected.Token(Token = "0x1700029F")]
		public bool ProduceLegacyHmacValues
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFEE60", Offset = "0x1AFEE60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60018BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFEE68", Offset = "0x1AFEE68", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HMAC), Member = "InitializeKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x040009DF RID: 2527
		[global::Cpp2ILInjected.Token(Token = "0x4000CB9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x61")]
		private bool m_useLegacyBlockSize;
	}
}
