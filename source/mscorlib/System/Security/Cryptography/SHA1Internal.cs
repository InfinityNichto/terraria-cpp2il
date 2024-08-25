using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::Cpp2ILInjected.Token(Token = "0x2000318")]
	internal class SHA1Internal
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001AE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1BA50", Offset = "0x1B1BA50", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA1CryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public SHA1Internal()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1BB34", Offset = "0x1B1BB34", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA1CryptoServiceProvider), Member = "HashCore", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1Internal), Member = "ProcessBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(uint)
		}, ReturnType = typeof(void))]
		public void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1C024", Offset = "0x1B1C024", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA1CryptoServiceProvider), Member = "HashFinal", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1Internal), Member = "ProcessFinalBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public byte[] HashFinal()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1BB0C", Offset = "0x1B1BB0C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Initialize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1BC34", Offset = "0x1B1BC34", Length = "0x3F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA1Internal), Member = "HashCore", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA1Internal), Member = "ProcessFinalBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1Internal), Member = "InitialiseBuff", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(byte[]),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1Internal), Member = "FillBuff", MemberParameters = new object[] { typeof(uint[]) }, ReturnType = typeof(void))]
		private void ProcessBlock(byte[] inputBuffer, uint inputOffset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1C220", Offset = "0x1B1C220", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA1Internal), Member = "ProcessBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private static void InitialiseBuff(uint[] buff, byte[] input, uint inputOffset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1C348", Offset = "0x1B1C348", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA1Internal), Member = "ProcessBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private static void FillBuff(uint[] buff)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1C0CC", Offset = "0x1B1C0CC", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA1Internal), Member = "HashFinal", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1Internal), Member = "AddLength", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1Internal), Member = "ProcessBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1C450", Offset = "0x1B1C450", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA1Internal), Member = "ProcessFinalBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void AddLength(ulong length, byte[] buffer, int position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000DAE")]
		private const int BLOCK_SIZE_BYTES = 64;

		[global::Cpp2ILInjected.Token(Token = "0x4000DAF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private uint[] _H;

		[global::Cpp2ILInjected.Token(Token = "0x4000DB0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ulong count;

		[global::Cpp2ILInjected.Token(Token = "0x4000DB1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private byte[] _ProcessingBuffer;

		[global::Cpp2ILInjected.Token(Token = "0x4000DB2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _ProcessingBufferCount;

		[global::Cpp2ILInjected.Token(Token = "0x4000DB3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private uint[] buff;
	}
}
