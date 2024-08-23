using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.X509
{
	// Token: 0x02000009 RID: 9
	[global::Cpp2ILInjected.Token(Token = "0x200000D")]
	internal class SafeBag
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00002FBB File Offset: 0x000011BB
		[global::Cpp2ILInjected.Token(Token = "0x6000046")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7B8A0", Offset = "0x1A7B8A0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SafeBag(string bagOID, ASN1 asn1)
		{
			throw null;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002FBE File Offset: 0x000011BE
		[global::Cpp2ILInjected.Token(Token = "0x17000016")]
		public string BagOID
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000047")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7B8CC", Offset = "0x1A7B8CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002FC1 File Offset: 0x000011C1
		[global::Cpp2ILInjected.Token(Token = "0x17000017")]
		public ASN1 ASN1
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000048")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7B8D4", Offset = "0x1A7B8D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400000C RID: 12
		[global::Cpp2ILInjected.Token(Token = "0x4000021")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _bagOID;

		// Token: 0x0400000D RID: 13
		[global::Cpp2ILInjected.Token(Token = "0x4000022")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ASN1 _asn1;
	}
}
