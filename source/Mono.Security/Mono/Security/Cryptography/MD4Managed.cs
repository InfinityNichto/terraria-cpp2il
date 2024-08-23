using System;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200003C RID: 60
	[global::Cpp2ILInjected.Token(Token = "0x2000057")]
	public class MD4Managed : MD4
	{
		// Token: 0x060001F7 RID: 503 RVA: 0x00003501 File Offset: 0x00001701
		[global::Cpp2ILInjected.Token(Token = "0x600024D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9D678", Offset = "0x1A9D678", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MD4), Member = "Create", ReturnType = typeof(MD4))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public MD4Managed()
		{
			throw null;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00003504 File Offset: 0x00001704
		[global::Cpp2ILInjected.Token(Token = "0x600024E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9D748", Offset = "0x1A9D748", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public override void Initialize()
		{
			throw null;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00003507 File Offset: 0x00001707
		[global::Cpp2ILInjected.Token(Token = "0x600024F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9D794", Offset = "0x1A9D794", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD4Managed), Member = "MD4Transform", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
			throw null;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000350A File Offset: 0x0000170A
		[global::Cpp2ILInjected.Token(Token = "0x6000250")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9DE1C", Offset = "0x1A9DE1C", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD4Managed), Member = "Encode", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(uint[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD4Managed), Member = "Padding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override byte[] HashFinal()
		{
			throw null;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000350D File Offset: 0x0000170D
		[global::Cpp2ILInjected.Token(Token = "0x6000251")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9DF68", Offset = "0x1A9DF68", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MD4Managed), Member = "HashFinal", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte[] Padding(int nLength)
		{
			throw null;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00003510 File Offset: 0x00001710
		[global::Cpp2ILInjected.Token(Token = "0x6000252")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9DFCC", Offset = "0x1A9DFCC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private uint F(uint x, uint y, uint z)
		{
			throw null;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00003513 File Offset: 0x00001713
		[global::Cpp2ILInjected.Token(Token = "0x6000253")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9DFDC", Offset = "0x1A9DFDC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private uint G(uint x, uint y, uint z)
		{
			throw null;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00003516 File Offset: 0x00001716
		[global::Cpp2ILInjected.Token(Token = "0x6000254")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9DFF0", Offset = "0x1A9DFF0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private uint H(uint x, uint y, uint z)
		{
			throw null;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00003519 File Offset: 0x00001719
		[global::Cpp2ILInjected.Token(Token = "0x6000255")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9DFFC", Offset = "0x1A9DFFC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private uint ROL(uint x, byte n)
		{
			throw null;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000351C File Offset: 0x0000171C
		[global::Cpp2ILInjected.Token(Token = "0x6000256")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9E00C", Offset = "0x1A9E00C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s)
		{
			throw null;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000351F File Offset: 0x0000171F
		[global::Cpp2ILInjected.Token(Token = "0x6000257")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9E038", Offset = "0x1A9E038", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s)
		{
			throw null;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00003522 File Offset: 0x00001722
		[global::Cpp2ILInjected.Token(Token = "0x6000258")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9E074", Offset = "0x1A9E074", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s)
		{
			throw null;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00003525 File Offset: 0x00001725
		[global::Cpp2ILInjected.Token(Token = "0x6000259")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9DF04", Offset = "0x1A9DF04", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MD4Managed), Member = "HashFinal", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		private void Encode(byte[] output, uint[] input)
		{
			throw null;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00003528 File Offset: 0x00001728
		[global::Cpp2ILInjected.Token(Token = "0x600025A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9E0A8", Offset = "0x1A9E0A8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MD4Managed), Member = "MD4Transform", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private void Decode(uint[] output, byte[] input, int index)
		{
			throw null;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000352B File Offset: 0x0000172B
		[global::Cpp2ILInjected.Token(Token = "0x600025B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9D888", Offset = "0x1A9D888", Length = "0x594")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MD4Managed), Member = "HashCore", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD4Managed), Member = "Decode", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void MD4Transform(uint[] state, byte[] block, int index)
		{
			throw null;
		}

		// Token: 0x0400022D RID: 557
		[global::Cpp2ILInjected.Token(Token = "0x400025A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private uint[] state;

		// Token: 0x0400022E RID: 558
		[global::Cpp2ILInjected.Token(Token = "0x400025B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private byte[] buffer;

		// Token: 0x0400022F RID: 559
		[global::Cpp2ILInjected.Token(Token = "0x400025C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private uint[] count;

		// Token: 0x04000230 RID: 560
		[global::Cpp2ILInjected.Token(Token = "0x400025D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private uint[] x;

		// Token: 0x04000231 RID: 561
		[global::Cpp2ILInjected.Token(Token = "0x400025E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private byte[] digest;
	}
}
