using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	[global::Cpp2ILInjected.Token(Token = "0x2000275")]
	public abstract class EncodingProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001530")]
		public abstract Encoding GetEncoding(string name);

		[global::Cpp2ILInjected.Token(Token = "0x6001531")]
		public abstract Encoding GetEncoding(int codepage);

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

		[global::Cpp2ILInjected.Token(Token = "0x4000B1B")]
		private static object s_InternalSyncObject;

		[global::Cpp2ILInjected.Token(Token = "0x4000B1C")]
		private static EncodingProvider[] s_providers;
	}
}
