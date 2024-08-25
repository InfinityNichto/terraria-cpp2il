using System;
using System.IO;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	[global::Cpp2ILInjected.Token(Token = "0x200026F")]
	[global::System.Serializable]
	public abstract class EncoderFallback
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000218")]
		public static EncoderFallback ReplacementFallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAF2F4", Offset = "0x1CAF2F4", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ASCIIEncoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderReplacementFallback), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000219")]
		public static EncoderFallback ExceptionFallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB4FB8", Offset = "0x1CB4FB8", Length = "0x98")]
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

		[global::Cpp2ILInjected.Token(Token = "0x60014F7")]
		public abstract EncoderFallbackBuffer CreateFallbackBuffer();

		[global::Cpp2ILInjected.Token(Token = "0x1700021A")]
		public abstract int MaxCharCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014F8")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB4354", Offset = "0x1CB4354", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncoderReplacementFallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncoderReplacementFallback), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.CharEntityEncoderFallback", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlEncodedRawTextWriter", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			"System.Xml.XmlWriterSettings"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected EncoderFallback()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000B09")]
		private static EncoderFallback s_replacementFallback;

		[global::Cpp2ILInjected.Token(Token = "0x4000B0A")]
		private static EncoderFallback s_exceptionFallback;
	}
}
