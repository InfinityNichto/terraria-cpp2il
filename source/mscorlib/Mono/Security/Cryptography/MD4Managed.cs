using System;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000032 RID: 50
	[global::Cpp2ILInjected.Token(Token = "0x2000048")]
	internal class MD4Managed : MD4
	{
		// Token: 0x06000115 RID: 277 RVA: 0x000148F7 File Offset: 0x00012AF7
		[global::Cpp2ILInjected.Token(Token = "0x6000157")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABAB78", Offset = "0x1ABAB78", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MD4), Member = "Create", ReturnType = typeof(MD4))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.HashAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public MD4Managed()
		{
			throw null;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000148FA File Offset: 0x00012AFA
		[global::Cpp2ILInjected.Token(Token = "0x6000158")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABAC48", Offset = "0x1ABAC48", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public override void Initialize()
		{
			throw null;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000148FD File Offset: 0x00012AFD
		[global::Cpp2ILInjected.Token(Token = "0x6000159")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABAC94", Offset = "0x1ABAC94", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
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

		// Token: 0x06000118 RID: 280 RVA: 0x00014900 File Offset: 0x00012B00
		[global::Cpp2ILInjected.Token(Token = "0x600015A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABB31C", Offset = "0x1ABB31C", Length = "0xE8")]
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

		// Token: 0x06000119 RID: 281 RVA: 0x00014903 File Offset: 0x00012B03
		[global::Cpp2ILInjected.Token(Token = "0x600015B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABB468", Offset = "0x1ABB468", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MD4Managed), Member = "HashFinal", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte[] Padding(int nLength)
		{
			throw null;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00014906 File Offset: 0x00012B06
		[global::Cpp2ILInjected.Token(Token = "0x600015C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABB4CC", Offset = "0x1ABB4CC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private uint F(uint x, uint y, uint z)
		{
			throw null;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00014909 File Offset: 0x00012B09
		[global::Cpp2ILInjected.Token(Token = "0x600015D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABB4DC", Offset = "0x1ABB4DC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private uint G(uint x, uint y, uint z)
		{
			throw null;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0001490C File Offset: 0x00012B0C
		[global::Cpp2ILInjected.Token(Token = "0x600015E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABB4F0", Offset = "0x1ABB4F0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private uint H(uint x, uint y, uint z)
		{
			throw null;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0001490F File Offset: 0x00012B0F
		[global::Cpp2ILInjected.Token(Token = "0x600015F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABB4FC", Offset = "0x1ABB4FC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private uint ROL(uint x, byte n)
		{
			throw null;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00014912 File Offset: 0x00012B12
		[global::Cpp2ILInjected.Token(Token = "0x6000160")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABB50C", Offset = "0x1ABB50C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s)
		{
			throw null;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00014915 File Offset: 0x00012B15
		[global::Cpp2ILInjected.Token(Token = "0x6000161")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABB538", Offset = "0x1ABB538", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s)
		{
			throw null;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00014918 File Offset: 0x00012B18
		[global::Cpp2ILInjected.Token(Token = "0x6000162")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABB574", Offset = "0x1ABB574", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s)
		{
			throw null;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0001491B File Offset: 0x00012B1B
		[global::Cpp2ILInjected.Token(Token = "0x6000163")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABB404", Offset = "0x1ABB404", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MD4Managed), Member = "HashFinal", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		private void Encode(byte[] output, uint[] input)
		{
			throw null;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0001491E File Offset: 0x00012B1E
		[global::Cpp2ILInjected.Token(Token = "0x6000164")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABB5A8", Offset = "0x1ABB5A8", Length = "0x5C")]
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

		// Token: 0x06000123 RID: 291 RVA: 0x00014921 File Offset: 0x00012B21
		[global::Cpp2ILInjected.Token(Token = "0x6000165")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABAD88", Offset = "0x1ABAD88", Length = "0x594")]
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

		// Token: 0x040000A1 RID: 161
		[global::Cpp2ILInjected.Token(Token = "0x400014E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private uint[] state;

		// Token: 0x040000A2 RID: 162
		[global::Cpp2ILInjected.Token(Token = "0x400014F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private byte[] buffer;

		// Token: 0x040000A3 RID: 163
		[global::Cpp2ILInjected.Token(Token = "0x4000150")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private uint[] count;

		// Token: 0x040000A4 RID: 164
		[global::Cpp2ILInjected.Token(Token = "0x4000151")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private uint[] x;

		// Token: 0x040000A5 RID: 165
		[global::Cpp2ILInjected.Token(Token = "0x4000152")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private byte[] digest;
	}
}
