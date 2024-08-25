using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002CE")]
	public sealed class KeySizes
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000291")]
		public int MinSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x600183F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFA22C", Offset = "0x1AFA22C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000292")]
		public int MaxSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001840")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFA234", Offset = "0x1AFA234", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000293")]
		public int SkipSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001841")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFA23C", Offset = "0x1AFA23C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001842")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8AB8", Offset = "0x1AF8AB8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDES), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.RC4", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.RSAManaged", Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public KeySizes(int minSize, int maxSize, int skipSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001843")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA244", Offset = "0x1AFA244", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal bool IsLegal(int keySize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001844")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA290", Offset = "0x1AFA290", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RC2Transform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(RC2),
			typeof(bool),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal static bool IsLegalKeySize(KeySizes[] legalKeys, int size)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000C8B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int m_minSize;

		[global::Cpp2ILInjected.Token(Token = "0x4000C8C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int m_maxSize;

		[global::Cpp2ILInjected.Token(Token = "0x4000C8D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int m_skipSize;
	}
}
