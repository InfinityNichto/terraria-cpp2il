using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	[global::Cpp2ILInjected.Token(Token = "0x2000005")]
	internal class AesTransform : SymmetricTransform
	{
		[global::Cpp2ILInjected.Token(Token = "0x600002A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3CAD4", Offset = "0x1D3CAD4", Length = "0x570")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AesCryptoServiceProvider), Member = "CreateDecryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AesCryptoServiceProvider), Member = "CreateEncryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Security.Cryptography.SymmetricTransform", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SymmetricAlgorithm),
			typeof(bool),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AesTransform), Member = "SubByte", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Locale", Member = "GetText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		public AesTransform(Aes algo, bool encryption, byte[] key, byte[] iv)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600002B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3D320", Offset = "0x1D3D320", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AesTransform), Member = "Decrypt128", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(uint[])
		}, ReturnType = typeof(void))]
		protected override void ECB(byte[] input, byte[] output)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600002C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3D294", Offset = "0x1D3D294", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AesTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Aes),
			typeof(bool),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private uint SubByte(uint a)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600002D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3D334", Offset = "0x1D3D334", Length = "0xDE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void Encrypt128(byte[] indata, byte[] outdata, uint[] ekey)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600002E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3E114", Offset = "0x1D3E114", Length = "0xDE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AesTransform), Member = "ECB", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void Decrypt128(byte[] indata, byte[] outdata, uint[] ekey)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600002F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3EEF8", Offset = "0x1D3EEF8", Length = "0x318")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		static AesTransform()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000002")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private uint[] expandedKey;

		[global::Cpp2ILInjected.Token(Token = "0x4000003")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private int Nk;

		[global::Cpp2ILInjected.Token(Token = "0x4000004")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		private int Nr;

		[global::Cpp2ILInjected.Token(Token = "0x4000005")]
		private static readonly uint[] Rcon;

		[global::Cpp2ILInjected.Token(Token = "0x4000006")]
		private static readonly byte[] SBox;

		[global::Cpp2ILInjected.Token(Token = "0x4000007")]
		private static readonly byte[] iSBox;

		[global::Cpp2ILInjected.Token(Token = "0x4000008")]
		private static readonly uint[] T0;

		[global::Cpp2ILInjected.Token(Token = "0x4000009")]
		private static readonly uint[] T1;

		[global::Cpp2ILInjected.Token(Token = "0x400000A")]
		private static readonly uint[] T2;

		[global::Cpp2ILInjected.Token(Token = "0x400000B")]
		private static readonly uint[] T3;

		[global::Cpp2ILInjected.Token(Token = "0x400000C")]
		private static readonly uint[] iT0;

		[global::Cpp2ILInjected.Token(Token = "0x400000D")]
		private static readonly uint[] iT1;

		[global::Cpp2ILInjected.Token(Token = "0x400000E")]
		private static readonly uint[] iT2;

		[global::Cpp2ILInjected.Token(Token = "0x400000F")]
		private static readonly uint[] iT3;
	}
}
