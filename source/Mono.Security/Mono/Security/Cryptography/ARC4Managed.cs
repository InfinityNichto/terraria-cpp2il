using System;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000036 RID: 54
	[global::Cpp2ILInjected.Token(Token = "0x2000051")]
	public class ARC4Managed : RC4, ICryptoTransform, IDisposable
	{
		// Token: 0x060001CF RID: 463 RVA: 0x00003489 File Offset: 0x00001689
		[global::Cpp2ILInjected.Token(Token = "0x6000225")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9BB80", Offset = "0x1A9BB80", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RC4), Member = "Create", ReturnType = typeof(RC4))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RC4), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public ARC4Managed()
		{
			throw null;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000348C File Offset: 0x0000168C
		[global::Cpp2ILInjected.Token(Token = "0x6000226")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9BC7C", Offset = "0x1A9BC7C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000348F File Offset: 0x0000168F
		[global::Cpp2ILInjected.Token(Token = "0x6000227")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9BD1C", Offset = "0x1A9BD1C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00003492 File Offset: 0x00001692
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00003495 File Offset: 0x00001695
		[global::Cpp2ILInjected.Token(Token = "0x170000AB")]
		public override byte[] Key
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000228")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9BDC0", Offset = "0x1A9BDC0", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000229")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9BE4C", Offset = "0x1A9BE4C", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00003498 File Offset: 0x00001698
		[global::Cpp2ILInjected.Token(Token = "0x170000AC")]
		public bool CanReuseTransform
		{
			[global::Cpp2ILInjected.Token(Token = "0x600022A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9BFA0", Offset = "0x1A9BFA0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000349B File Offset: 0x0000169B
		[global::Cpp2ILInjected.Token(Token = "0x600022B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9BFA8", Offset = "0x1A9BFA8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgvIV)
		{
			throw null;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000349E File Offset: 0x0000169E
		[global::Cpp2ILInjected.Token(Token = "0x600022C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9BFCC", Offset = "0x1A9BFCC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgvIV)
		{
			throw null;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000034A1 File Offset: 0x000016A1
		[global::Cpp2ILInjected.Token(Token = "0x600022D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9BFFC", Offset = "0x1A9BFFC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void GenerateIV()
		{
			throw null;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000034A4 File Offset: 0x000016A4
		[global::Cpp2ILInjected.Token(Token = "0x600022E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9C058", Offset = "0x1A9C058", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyBuilder), Member = "Key", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		public override void GenerateKey()
		{
			throw null;
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x000034A7 File Offset: 0x000016A7
		[global::Cpp2ILInjected.Token(Token = "0x170000AD")]
		public bool CanTransformMultipleBlocks
		{
			[global::Cpp2ILInjected.Token(Token = "0x600022F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9C0E0", Offset = "0x1A9C0E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001DA RID: 474 RVA: 0x000034AA File Offset: 0x000016AA
		[global::Cpp2ILInjected.Token(Token = "0x170000AE")]
		public int InputBlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000230")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9C0E8", Offset = "0x1A9C0E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001DB RID: 475 RVA: 0x000034AD File Offset: 0x000016AD
		[global::Cpp2ILInjected.Token(Token = "0x170000AF")]
		public int OutputBlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000231")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9C0F0", Offset = "0x1A9C0F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000034B0 File Offset: 0x000016B0
		[global::Cpp2ILInjected.Token(Token = "0x6000232")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9BF20", Offset = "0x1A9BF20", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void KeySetup(byte[] key)
		{
			throw null;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000034B3 File Offset: 0x000016B3
		[global::Cpp2ILInjected.Token(Token = "0x6000233")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9C0F8", Offset = "0x1A9C0F8", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ARC4Managed), Member = "TransformBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ARC4Managed), Member = "TransformFinalBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			throw null;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000034B6 File Offset: 0x000016B6
		[global::Cpp2ILInjected.Token(Token = "0x6000234")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9C23C", Offset = "0x1A9C23C", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ARC4Managed), Member = "CheckInput", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			throw null;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000034B9 File Offset: 0x000016B9
		[global::Cpp2ILInjected.Token(Token = "0x6000235")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9C3A0", Offset = "0x1A9C3A0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ARC4Managed), Member = "TransformFinalBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			throw null;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000034BC File Offset: 0x000016BC
		[global::Cpp2ILInjected.Token(Token = "0x6000236")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9C444", Offset = "0x1A9C444", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ARC4Managed), Member = "CheckInput", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ARC4Managed), Member = "InternalTransformBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			throw null;
		}

		// Token: 0x04000221 RID: 545
		[global::Cpp2ILInjected.Token(Token = "0x400024E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private byte[] key;

		// Token: 0x04000222 RID: 546
		[global::Cpp2ILInjected.Token(Token = "0x400024F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private byte[] state;

		// Token: 0x04000223 RID: 547
		[global::Cpp2ILInjected.Token(Token = "0x4000250")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private byte x;

		// Token: 0x04000224 RID: 548
		[global::Cpp2ILInjected.Token(Token = "0x4000251")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x59")]
		private byte y;

		// Token: 0x04000225 RID: 549
		[global::Cpp2ILInjected.Token(Token = "0x4000252")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5A")]
		private bool m_disposed;
	}
}
