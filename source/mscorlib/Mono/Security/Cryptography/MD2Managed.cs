using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000030 RID: 48
	[global::Cpp2ILInjected.Token(Token = "0x2000046")]
	internal class MD2Managed : MD2
	{
		// Token: 0x0600010C RID: 268 RVA: 0x000148DC File Offset: 0x00012ADC
		[global::Cpp2ILInjected.Token(Token = "0x600014E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABA614", Offset = "0x1ABA614", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MD2Managed), Member = "HashFinal", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte[] Padding(int nLength)
		{
			throw null;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000148DF File Offset: 0x00012ADF
		[global::Cpp2ILInjected.Token(Token = "0x600014F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABA570", Offset = "0x1ABA570", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MD2), Member = "Create", ReturnType = typeof(MD2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.HashAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public MD2Managed()
		{
			throw null;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000148E2 File Offset: 0x00012AE2
		[global::Cpp2ILInjected.Token(Token = "0x6000150")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABA698", Offset = "0x1ABA698", Length = "0x60")]
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

		// Token: 0x0600010F RID: 271 RVA: 0x000148E5 File Offset: 0x00012AE5
		[global::Cpp2ILInjected.Token(Token = "0x6000151")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABA6F8", Offset = "0x1ABA6F8", Length = "0xDC")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD2Managed), Member = "MD2Transform", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
			throw null;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000148E8 File Offset: 0x00012AE8
		[global::Cpp2ILInjected.Token(Token = "0x6000152")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABA98C", Offset = "0x1ABA98C", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD2Managed), Member = "Padding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected override byte[] HashFinal()
		{
			throw null;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000148EB File Offset: 0x00012AEB
		[global::Cpp2ILInjected.Token(Token = "0x6000153")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABA7D4", Offset = "0x1ABA7D4", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MD2Managed), Member = "HashCore", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index)
		{
			throw null;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000148EE File Offset: 0x00012AEE
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000154")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABAA74", Offset = "0x1ABAA74", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static MD2Managed()
		{
			throw null;
		}

		// Token: 0x0400009B RID: 155
		[global::Cpp2ILInjected.Token(Token = "0x4000148")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] state;

		// Token: 0x0400009C RID: 156
		[global::Cpp2ILInjected.Token(Token = "0x4000149")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private byte[] checksum;

		// Token: 0x0400009D RID: 157
		[global::Cpp2ILInjected.Token(Token = "0x400014A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private byte[] buffer;

		// Token: 0x0400009E RID: 158
		[global::Cpp2ILInjected.Token(Token = "0x400014B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int count;

		// Token: 0x0400009F RID: 159
		[global::Cpp2ILInjected.Token(Token = "0x400014C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private byte[] x;

		// Token: 0x040000A0 RID: 160
		[global::Cpp2ILInjected.Token(Token = "0x400014D")]
		private static readonly byte[] PI_SUBST;
	}
}
