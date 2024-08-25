using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	[global::Cpp2ILInjected.Token(Token = "0x2000314")]
	internal class RC2Transform : Mono.Security.Cryptography.SymmetricTransform
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001AC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B19FE0", Offset = "0x1B19FE0", Length = "0x400")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RC2CryptoServiceProvider), Member = "CreateEncryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RC2CryptoServiceProvider), Member = "CreateDecryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.SymmetricTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SymmetricAlgorithm),
			typeof(bool),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.KeyBuilder), Member = "Key", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeySizes), Member = "IsLegalKeySize", MemberParameters = new object[]
		{
			typeof(KeySizes[]),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public RC2Transform(RC2 rc2Algo, bool encryption, byte[] key, byte[] iv)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1A3E0", Offset = "0x1B1A3E0", Length = "0x5E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void ECB(byte[] input, byte[] output)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001AC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1A9C0", Offset = "0x1B1A9C0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static RC2Transform()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000DA1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private ushort R0;

		[global::Cpp2ILInjected.Token(Token = "0x4000DA2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5A")]
		private ushort R1;

		[global::Cpp2ILInjected.Token(Token = "0x4000DA3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private ushort R2;

		[global::Cpp2ILInjected.Token(Token = "0x4000DA4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5E")]
		private ushort R3;

		[global::Cpp2ILInjected.Token(Token = "0x4000DA5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private ushort[] K;

		[global::Cpp2ILInjected.Token(Token = "0x4000DA6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private int j;

		[global::Cpp2ILInjected.Token(Token = "0x4000DA7")]
		private static readonly byte[] pitable;
	}
}
