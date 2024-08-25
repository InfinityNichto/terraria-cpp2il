using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	[global::Cpp2ILInjected.Token(Token = "0x2000261")]
	[global::System.Serializable]
	public sealed class DecoderExceptionFallback : DecoderFallback
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001495")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB216C", Offset = "0x1CB216C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequestUriBuilder", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DecoderExceptionFallback()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001496")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB2174", Offset = "0x1CB2174", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override DecoderFallbackBuffer CreateFallbackBuffer()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000205")]
		public override int MaxCharCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001497")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB21D0", Offset = "0x1CB21D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001498")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB21D8", Offset = "0x1CB21D8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001499")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB2234", Offset = "0x1CB2234", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}
	}
}
