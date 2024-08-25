using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	[global::Cpp2ILInjected.Token(Token = "0x2000264")]
	[global::System.Serializable]
	public abstract class DecoderFallback
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000207")]
		public static DecoderFallback ReplacementFallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAF388", Offset = "0x1CAF388", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ASCIIEncoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderReplacementFallback), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000208")]
		public static DecoderFallback ExceptionFallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB24E0", Offset = "0x1CB24E0", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF32Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnicodeEncoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection.HeaderEncoding", Member = "DecodeUtf8FromString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014A4")]
		public abstract DecoderFallbackBuffer CreateFallbackBuffer();

		[global::Cpp2ILInjected.Token(Token = "0x17000209")]
		public abstract int MaxCharCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014A5")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB1D28", Offset = "0x1CB1D28", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.UTF7Encoding.DecoderUTF7Fallback", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected DecoderFallback()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000AF0")]
		private static DecoderFallback s_replacementFallback;

		[global::Cpp2ILInjected.Token(Token = "0x4000AF1")]
		private static DecoderFallback s_exceptionFallback;
	}
}
