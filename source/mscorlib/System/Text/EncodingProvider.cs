using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001F0 RID: 496
	[global::Cpp2ILInjected.Token(Token = "0x2000275")]
	public abstract class EncodingProvider
	{
		// Token: 0x06001376 RID: 4982
		[global::Cpp2ILInjected.Token(Token = "0x6001530")]
		public abstract Encoding GetEncoding(string name);

		// Token: 0x06001377 RID: 4983
		[global::Cpp2ILInjected.Token(Token = "0x6001531")]
		public abstract Encoding GetEncoding(int codepage);

		// Token: 0x06001378 RID: 4984 RVA: 0x00017B97 File Offset: 0x00015D97
		[global::Cpp2ILInjected.Token(Token = "0x6001532")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD2F64", Offset = "0x1AD2F64", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "set_EncoderFallback", MemberParameters = new object[] { typeof(EncoderFallback) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "set_DecoderFallback", MemberParameters = new object[] { typeof(DecoderFallback) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual Encoding GetEncoding(string name, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			throw null;
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x00017B9A File Offset: 0x00015D9A
		[global::Cpp2ILInjected.Token(Token = "0x6001533")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD3058", Offset = "0x1AD3058", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "set_EncoderFallback", MemberParameters = new object[] { typeof(EncoderFallback) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "set_DecoderFallback", MemberParameters = new object[] { typeof(DecoderFallback) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			throw null;
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x00017B9D File Offset: 0x00015D9D
		[global::Cpp2ILInjected.Token(Token = "0x6001534")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD314C", Offset = "0x1AD314C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static Encoding GetEncodingFromProvider(int codepage)
		{
			throw null;
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x00017BA0 File Offset: 0x00015DA0
		[global::Cpp2ILInjected.Token(Token = "0x6001535")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD3218", Offset = "0x1AD3218", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static Encoding GetEncodingFromProvider(string encodingName)
		{
			throw null;
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x00017BA3 File Offset: 0x00015DA3
		[global::Cpp2ILInjected.Token(Token = "0x6001536")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD32E4", Offset = "0x1AD32E4", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[]
		{
			typeof(int),
			typeof(EncoderFallback),
			typeof(DecoderFallback)
		}, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static Encoding GetEncodingFromProvider(int codepage, EncoderFallback enc, DecoderFallback dec)
		{
			throw null;
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x00017BA6 File Offset: 0x00015DA6
		[global::Cpp2ILInjected.Token(Token = "0x6001537")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD33C8", Offset = "0x1AD33C8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[]
		{
			typeof(string),
			typeof(EncoderFallback),
			typeof(DecoderFallback)
		}, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static Encoding GetEncodingFromProvider(string encodingName, EncoderFallback enc, DecoderFallback dec)
		{
			throw null;
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x00017BA9 File Offset: 0x00015DA9
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001538")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD34AC", Offset = "0x1AD34AC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static EncodingProvider()
		{
			throw null;
		}

		// Token: 0x040008AF RID: 2223
		[global::Cpp2ILInjected.Token(Token = "0x4000B1B")]
		private static object s_InternalSyncObject;

		// Token: 0x040008B0 RID: 2224
		[global::Cpp2ILInjected.Token(Token = "0x4000B1C")]
		private static EncodingProvider[] s_providers;
	}
}
