using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Ionic.Crc;

namespace Ionic.Zip
{
	// Token: 0x0200001A RID: 26
	[global::Cpp2ILInjected.Token(Token = "0x200001A")]
	internal class ZipCrypto
	{
		// Token: 0x0600008C RID: 140 RVA: 0x0000502C File Offset: 0x0000322C
		[global::Cpp2ILInjected.Token(Token = "0x600008C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4784C", Offset = "0x1A4784C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipCrypto), Member = "ForWrite", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipCrypto))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipCrypto), Member = "ForRead", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry)
		}, ReturnType = typeof(ZipCrypto))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private ZipCrypto()
		{
			throw null;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000502F File Offset: 0x0000322F
		[global::Cpp2ILInjected.Token(Token = "0x600008D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A478FC", Offset = "0x1A478FC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "WriteSecurityMetadata", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipCrypto), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipCrypto), Member = "InitCipher", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BadPasswordException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static ZipCrypto ForWrite(string password)
		{
			throw null;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00005032 File Offset: 0x00003232
		[global::Cpp2ILInjected.Token(Token = "0x600008E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A47A38", Offset = "0x1A47A38", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "SetupCryptoForExtract", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipCrypto), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipCrypto), Member = "InitCipher", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ReadWeakEncryptionHeader", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(byte[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipCrypto), Member = "DecryptMessage", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BadPasswordException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static ZipCrypto ForRead(string password, ZipEntry e)
		{
			throw null;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00005035 File Offset: 0x00003235
		[global::Cpp2ILInjected.Token(Token = "0x1700001B")]
		private byte MagicByte
		{
			[global::Cpp2ILInjected.Token(Token = "0x600008F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A47DB4", Offset = "0x1A47DB4", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00005038 File Offset: 0x00003238
		[global::Cpp2ILInjected.Token(Token = "0x6000090")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A47C58", Offset = "0x1A47C58", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipCrypto), Member = "ForRead", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry)
		}, ReturnType = typeof(ZipCrypto))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipCipherStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipCrypto), Member = "UpdateKeys", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public byte[] DecryptMessage(byte[] cipherText, int length)
		{
			throw null;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000503B File Offset: 0x0000323B
		[global::Cpp2ILInjected.Token(Token = "0x6000091")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A47E44", Offset = "0x1A47E44", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipCipherStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "WriteSecurityMetadata", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipCrypto), Member = "UpdateKeys", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public byte[] EncryptMessage(byte[] plainText, int length)
		{
			throw null;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000503E File Offset: 0x0000323E
		[global::Cpp2ILInjected.Token(Token = "0x6000092")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A479A4", Offset = "0x1A479A4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipCrypto), Member = "ForWrite", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipCrypto))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipCrypto), Member = "ForRead", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry)
		}, ReturnType = typeof(ZipCrypto))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "StringToByteArray", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipCrypto), Member = "UpdateKeys", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void InitCipher(string passphrase)
		{
			throw null;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00005041 File Offset: 0x00003241
		[global::Cpp2ILInjected.Token(Token = "0x6000093")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A47DD8", Offset = "0x1A47DD8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipCrypto), Member = "DecryptMessage", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipCrypto), Member = "EncryptMessage", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipCrypto), Member = "InitCipher", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "ComputeCrc32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(int))]
		private void UpdateKeys(byte byteValue)
		{
			throw null;
		}

		// Token: 0x04000044 RID: 68
		[global::Cpp2ILInjected.Token(Token = "0x4000044")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private uint[] _Keys;

		// Token: 0x04000045 RID: 69
		[global::Cpp2ILInjected.Token(Token = "0x4000045")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private CRC32 crc32;
	}
}
