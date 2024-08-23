using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Authenticode;
using Mono.Security.Protocol.Ntlm;

namespace Mono.Security
{
	// Token: 0x02000005 RID: 5
	[global::Cpp2ILInjected.Token(Token = "0x2000005")]
	internal sealed class BitConverterLE
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00002F94 File Offset: 0x00001194
		[global::Cpp2ILInjected.Token(Token = "0x600001B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7A014", Offset = "0x1A7A014", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ASN1Convert), Member = "FromInt32", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BitConverterLE), Member = "GetBytes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private unsafe static byte[] GetUIntBytes(byte* bytes)
		{
			throw null;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002F97 File Offset: 0x00001197
		[global::Cpp2ILInjected.Token(Token = "0x600001C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7A0D0", Offset = "0x1A7A0D0", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BitConverterLE), Member = "GetBytes", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private unsafe static byte[] GetULongBytes(byte* bytes)
		{
			throw null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002F9A File Offset: 0x0000119A
		[global::Cpp2ILInjected.Token(Token = "0x600001D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A795B8", Offset = "0x1A795B8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverterLE), Member = "GetUIntBytes", MemberParameters = new object[] { typeof(byte*) }, ReturnType = typeof(byte[]))]
		internal unsafe static byte[] GetBytes(int value)
		{
			throw null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002F9D File Offset: 0x0000119D
		[global::Cpp2ILInjected.Token(Token = "0x600001E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7A1CC", Offset = "0x1A7A1CC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute_NTLMv2", MemberParameters = new object[]
		{
			typeof(Type2Message),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverterLE), Member = "GetULongBytes", MemberParameters = new object[] { typeof(byte*) }, ReturnType = typeof(byte[]))]
		internal unsafe static byte[] GetBytes(long value)
		{
			throw null;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002FA0 File Offset: 0x000011A0
		[global::Cpp2ILInjected.Token(Token = "0x600001F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7A1E4", Offset = "0x1A7A1E4", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BitConverterLE), Member = "ToUInt16", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static void UShortFromBytes(byte* dst, byte[] src, int startIndex)
		{
			throw null;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002FA3 File Offset: 0x000011A3
		[global::Cpp2ILInjected.Token(Token = "0x6000020")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7A280", Offset = "0x1A7A280", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BitConverterLE), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BitConverterLE), Member = "ToUInt32", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static void UIntFromBytes(byte* dst, byte[] src, int startIndex)
		{
			throw null;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002FA6 File Offset: 0x000011A6
		[global::Cpp2ILInjected.Token(Token = "0x6000021")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7A34C", Offset = "0x1A7A34C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeBase), Member = "ProcessFirstBlock", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrivateKey), Member = "Decode", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverterLE), Member = "UIntFromBytes", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal unsafe static int ToInt32(byte[] value, int startIndex)
		{
			throw null;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002FA9 File Offset: 0x000011A9
		[global::Cpp2ILInjected.Token(Token = "0x6000022")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7A370", Offset = "0x1A7A370", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Type1Message), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Type2Message), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Type3Message), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeBase), Member = "ProcessFirstBlock", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverterLE), Member = "UShortFromBytes", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal unsafe static ushort ToUInt16(byte[] value, int startIndex)
		{
			throw null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002FAC File Offset: 0x000011AC
		[global::Cpp2ILInjected.Token(Token = "0x6000023")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7A394", Offset = "0x1A7A394", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBase), Member = "CheckHeader", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Type1Message), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Type2Message), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Type3Message), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeBase), Member = "ProcessFirstBlock", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrivateKey), Member = "Decode", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverterLE), Member = "UIntFromBytes", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal unsafe static uint ToUInt32(byte[] value, int startIndex)
		{
			throw null;
		}
	}
}
