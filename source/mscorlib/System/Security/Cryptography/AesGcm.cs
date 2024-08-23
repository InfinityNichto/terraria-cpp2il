using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x0200027F RID: 639
	[global::Cpp2ILInjected.Token(Token = "0x200031C")]
	public sealed class AesGcm : global::System.IDisposable
	{
		// Token: 0x060018E1 RID: 6369 RVA: 0x00018B1B File Offset: 0x00016D1B
		[global::Cpp2ILInjected.Token(Token = "0x6001AFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1CCC0", Offset = "0x1B1CCC0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public AesGcm(byte[] key)
		{
			throw null;
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00018B1E File Offset: 0x00016D1E
		[global::Cpp2ILInjected.Token(Token = "0x6001AFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1CD00", Offset = "0x1B1CD00", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public AesGcm(global::System.ReadOnlySpan<byte> key)
		{
			throw null;
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060018E3 RID: 6371 RVA: 0x00018B21 File Offset: 0x00016D21
		[global::Cpp2ILInjected.Token(Token = "0x170002F9")]
		public static KeySizes NonceByteSizes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001AFD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1CD40", Offset = "0x1B1CD40", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060018E4 RID: 6372 RVA: 0x00018B24 File Offset: 0x00016D24
		[global::Cpp2ILInjected.Token(Token = "0x170002FA")]
		public static KeySizes TagByteSizes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001AFE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1CD78", Offset = "0x1B1CD78", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x00018B27 File Offset: 0x00016D27
		[global::Cpp2ILInjected.Token(Token = "0x6001AFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1CDB0", Offset = "0x1B1CDB0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Decrypt(byte[] nonce, byte[] ciphertext, byte[] tag, byte[] plaintext, byte[] associatedData = null)
		{
			throw null;
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00018B2A File Offset: 0x00016D2A
		[global::Cpp2ILInjected.Token(Token = "0x6001B00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1CDE8", Offset = "0x1B1CDE8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Decrypt(global::System.ReadOnlySpan<byte> nonce, global::System.ReadOnlySpan<byte> ciphertext, global::System.ReadOnlySpan<byte> tag, global::System.Span<byte> plaintext, global::System.ReadOnlySpan<byte> associatedData = default(global::System.ReadOnlySpan<byte>))
		{
			throw null;
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x00018B2D File Offset: 0x00016D2D
		[global::Cpp2ILInjected.Token(Token = "0x6001B01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1CE20", Offset = "0x1B1CE20", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x00018B30 File Offset: 0x00016D30
		[global::Cpp2ILInjected.Token(Token = "0x6001B02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1CE24", Offset = "0x1B1CE24", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Encrypt(byte[] nonce, byte[] plaintext, byte[] ciphertext, byte[] tag, byte[] associatedData = null)
		{
			throw null;
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x00018B33 File Offset: 0x00016D33
		[global::Cpp2ILInjected.Token(Token = "0x6001B03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1CE5C", Offset = "0x1B1CE5C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Encrypt(global::System.ReadOnlySpan<byte> nonce, global::System.ReadOnlySpan<byte> plaintext, global::System.Span<byte> ciphertext, global::System.Span<byte> tag, global::System.ReadOnlySpan<byte> associatedData = default(global::System.ReadOnlySpan<byte>))
		{
			throw null;
		}
	}
}
