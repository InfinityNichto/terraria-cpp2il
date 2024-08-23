using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000231 RID: 561
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002CE")]
	public sealed class KeySizes
	{
		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x0001832F File Offset: 0x0001652F
		[global::Cpp2ILInjected.Token(Token = "0x17000291")]
		public int MinSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x600183F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFA22C", Offset = "0x1AFA22C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x00018332 File Offset: 0x00016532
		[global::Cpp2ILInjected.Token(Token = "0x17000292")]
		public int MaxSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001840")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFA234", Offset = "0x1AFA234", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06001627 RID: 5671 RVA: 0x00018335 File Offset: 0x00016535
		[global::Cpp2ILInjected.Token(Token = "0x17000293")]
		public int SkipSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001841")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFA23C", Offset = "0x1AFA23C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00018338 File Offset: 0x00016538
		[global::Cpp2ILInjected.Token(Token = "0x6001842")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8AB8", Offset = "0x1AF8AB8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDES), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.RC4", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.RSAManaged", Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public KeySizes(int minSize, int maxSize, int skipSize)
		{
			throw null;
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x0001833B File Offset: 0x0001653B
		[global::Cpp2ILInjected.Token(Token = "0x6001843")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA244", Offset = "0x1AFA244", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal bool IsLegal(int keySize)
		{
			throw null;
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x0001833E File Offset: 0x0001653E
		[global::Cpp2ILInjected.Token(Token = "0x6001844")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA290", Offset = "0x1AFA290", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RC2Transform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(RC2),
			typeof(bool),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal static bool IsLegalKeySize(KeySizes[] legalKeys, int size)
		{
			throw null;
		}

		// Token: 0x040009B1 RID: 2481
		[global::Cpp2ILInjected.Token(Token = "0x4000C8B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int m_minSize;

		// Token: 0x040009B2 RID: 2482
		[global::Cpp2ILInjected.Token(Token = "0x4000C8C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int m_maxSize;

		// Token: 0x040009B3 RID: 2483
		[global::Cpp2ILInjected.Token(Token = "0x4000C8D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int m_skipSize;
	}
}
