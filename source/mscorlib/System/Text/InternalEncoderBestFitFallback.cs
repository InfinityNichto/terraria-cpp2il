using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	[global::Cpp2ILInjected.Token(Token = "0x200026A")]
	[global::System.Serializable]
	internal class InternalEncoderBestFitFallback : EncoderFallback
	{
		[global::Cpp2ILInjected.Token(Token = "0x60014D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB432C", Offset = "0x1CB432C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal InternalEncoderBestFitFallback(Encoding encoding)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB435C", Offset = "0x1CB435C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalEncoderBestFitFallbackBuffer), Member = ".ctor", MemberParameters = new object[] { typeof(InternalEncoderBestFitFallback) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000213")]
		public override int MaxCharCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB44BC", Offset = "0x1CB44BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB44C4", Offset = "0x1CB44C4", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB4578", Offset = "0x1CB4578", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000AFE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal Encoding _encoding;

		[global::Cpp2ILInjected.Token(Token = "0x4000AFF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal char[] _arrayBestFit;
	}
}
