using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000224 RID: 548
	[global::Cpp2ILInjected.Token(Token = "0x20002C1")]
	public sealed class RSASignaturePadding : global::System.IEquatable<RSASignaturePadding>
	{
		// Token: 0x060015CF RID: 5583 RVA: 0x00018257 File Offset: 0x00016457
		[global::Cpp2ILInjected.Token(Token = "0x60017E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8410", Offset = "0x1AF8410", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private RSASignaturePadding(RSASignaturePaddingMode mode)
		{
			throw null;
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060015D0 RID: 5584 RVA: 0x0001825A File Offset: 0x0001645A
		[global::Cpp2ILInjected.Token(Token = "0x17000280")]
		public static RSASignaturePadding Pkcs1
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF8438", Offset = "0x1AF8438", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x0001825D File Offset: 0x0001645D
		[global::Cpp2ILInjected.Token(Token = "0x17000281")]
		public static RSASignaturePadding Pss
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF8490", Offset = "0x1AF8490", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060015D2 RID: 5586 RVA: 0x00018260 File Offset: 0x00016460
		[global::Cpp2ILInjected.Token(Token = "0x17000282")]
		public RSASignaturePaddingMode Mode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF84E8", Offset = "0x1AF84E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00018263 File Offset: 0x00016463
		[global::Cpp2ILInjected.Token(Token = "0x60017ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF84F0", Offset = "0x1AF84F0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x00018266 File Offset: 0x00016466
		[global::Cpp2ILInjected.Token(Token = "0x60017EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF84FC", Offset = "0x1AF84FC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00018269 File Offset: 0x00016469
		[global::Cpp2ILInjected.Token(Token = "0x60017EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8560", Offset = "0x1AF8560", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSASignaturePadding), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(RSASignaturePadding),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSASignaturePadding), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(RSASignaturePadding),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSASignaturePadding), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(RSASignaturePadding),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(RSASignaturePadding other)
		{
			throw null;
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x0001826C File Offset: 0x0001646C
		[global::Cpp2ILInjected.Token(Token = "0x60017F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8668", Offset = "0x1AF8668", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "SignData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "SignData", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "VerifyData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(byte[]),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "VerifyData", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(byte[]),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "TrySignData", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Span<byte>),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "VerifyData", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "SignHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "VerifyHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSASignaturePadding), Member = "Equals", MemberParameters = new object[] { typeof(RSASignaturePadding) }, ReturnType = typeof(bool))]
		public static bool operator ==(RSASignaturePadding left, RSASignaturePadding right)
		{
			throw null;
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x0001826F File Offset: 0x0001646F
		[global::Cpp2ILInjected.Token(Token = "0x60017F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF85E4", Offset = "0x1AF85E4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSASignaturePadding), Member = "Equals", MemberParameters = new object[] { typeof(RSASignaturePadding) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "SignHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "VerifyHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSASignaturePadding), Member = "Equals", MemberParameters = new object[] { typeof(RSASignaturePadding) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool operator !=(RSASignaturePadding left, RSASignaturePadding right)
		{
			throw null;
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00018272 File Offset: 0x00016472
		[global::Cpp2ILInjected.Token(Token = "0x60017F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF867C", Offset = "0x1AF867C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00018275 File Offset: 0x00016475
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60017F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF86E4", Offset = "0x1AF86E4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static RSASignaturePadding()
		{
			throw null;
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00018278 File Offset: 0x00016478
		[global::Cpp2ILInjected.Token(Token = "0x60017F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF876C", Offset = "0x1AF876C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal RSASignaturePadding()
		{
			throw null;
		}

		// Token: 0x04000995 RID: 2453
		[global::Cpp2ILInjected.Token(Token = "0x4000C6F")]
		private static readonly RSASignaturePadding s_pkcs1;

		// Token: 0x04000996 RID: 2454
		[global::Cpp2ILInjected.Token(Token = "0x4000C70")]
		private static readonly RSASignaturePadding s_pss;

		// Token: 0x04000997 RID: 2455
		[global::Cpp2ILInjected.Token(Token = "0x4000C71")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly RSASignaturePaddingMode _mode;
	}
}
