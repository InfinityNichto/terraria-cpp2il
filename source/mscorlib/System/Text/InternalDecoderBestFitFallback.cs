using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	[global::Cpp2ILInjected.Token(Token = "0x200025F")]
	[global::System.Serializable]
	internal sealed class InternalDecoderBestFitFallback : DecoderFallback
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001488")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB1CF8", Offset = "0x1CB1CF8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal InternalDecoderBestFitFallback(Encoding encoding)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001489")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB1D30", Offset = "0x1CB1D30", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalDecoderBestFitFallbackBuffer), Member = ".ctor", MemberParameters = new object[] { typeof(InternalDecoderBestFitFallback) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override DecoderFallbackBuffer CreateFallbackBuffer()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000202")]
		public override int MaxCharCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x600148A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB1E90", Offset = "0x1CB1E90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600148B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB1E98", Offset = "0x1CB1E98", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600148C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB1F30", Offset = "0x1CB1F30", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000AE6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal Encoding _encoding;

		[global::Cpp2ILInjected.Token(Token = "0x4000AE7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal char[] _arrayBestFit;

		[global::Cpp2ILInjected.Token(Token = "0x4000AE8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal char _cReplacement;
	}
}
