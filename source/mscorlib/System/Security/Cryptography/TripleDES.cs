﻿using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000309")]
	public abstract class TripleDES : SymmetricAlgorithm
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001A44")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B117F4", Offset = "0x1B117F4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDESCryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected TripleDES()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002DB")]
		public override byte[] Key
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A45")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1187C", Offset = "0x1B1187C", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TripleDES), Member = "IsWeakKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A46")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B11A8C", Offset = "0x1B11A8C", Length = "0x1D4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = "ValidKeySize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TripleDES), Member = "IsWeakKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B11C60", Offset = "0x1B11C60", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MACTripleDES), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MACTripleDES), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TripleDESCryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public new static TripleDES Create()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A48")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B11D34", Offset = "0x1B11D34", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MACTripleDES), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public new static TripleDES Create(string str)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A49")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1193C", Offset = "0x1B1193C", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDES), Member = "get_Key", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDES), Member = "set_Key", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDESCryptoServiceProvider), Member = "CreateEncryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDESCryptoServiceProvider), Member = "CreateDecryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDESCryptoServiceProvider), Member = "GenerateKey", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDESTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TripleDES),
			typeof(bool),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDESTransform), Member = "GetStrongKey", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "FixupKeyParity", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TripleDES), Member = "EqualBytes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static bool IsWeakKey(byte[] rgbKey)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B11E98", Offset = "0x1B11E98", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDES), Member = "IsWeakKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static bool EqualBytes(byte[] rgbKey, int start1, int start2, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B11DD4", Offset = "0x1B11DD4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsLegalKeySize(byte[] rgbKey)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001A4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B11FE4", Offset = "0x1B11FE4", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeySizes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		static TripleDES()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000D34")]
		private static KeySizes[] s_legalBlockSizes;

		[global::Cpp2ILInjected.Token(Token = "0x4000D35")]
		private static KeySizes[] s_legalKeySizes;
	}
}
