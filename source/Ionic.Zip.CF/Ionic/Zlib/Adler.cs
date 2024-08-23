using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zlib
{
	// Token: 0x02000046 RID: 70
	[global::Cpp2ILInjected.Token(Token = "0x2000055")]
	public sealed class Adler
	{
		// Token: 0x0600038D RID: 909 RVA: 0x00005920 File Offset: 0x00003B20
		[global::Cpp2ILInjected.Token(Token = "0x60003AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6FDDC", Offset = "0x1A6FDDC", Length = "0x274")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "SetDictionary", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "Deflate", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InflateBlocks), Member = "Flush", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InflateManager), Member = "SetDictionary", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibCodec), Member = "read_buf", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static uint Adler32(uint adler, byte[] buf, int index, int len)
		{
			throw null;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00005923 File Offset: 0x00003B23
		[global::Cpp2ILInjected.Token(Token = "0x60003AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7493C", Offset = "0x1A7493C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Adler()
		{
			throw null;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00005926 File Offset: 0x00003B26
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60003AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A74944", Offset = "0x1A74944", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Adler()
		{
			throw null;
		}

		// Token: 0x04000278 RID: 632
		[global::Cpp2ILInjected.Token(Token = "0x40002E4")]
		private static readonly uint BASE;

		// Token: 0x04000279 RID: 633
		[global::Cpp2ILInjected.Token(Token = "0x40002E5")]
		private static readonly int NMAX;
	}
}
