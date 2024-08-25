using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200026A")]
	internal class NetConfig : ICloneable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001099")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E038EC", Offset = "0x1E038EC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal NetConfig()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600109A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E038FC", Offset = "0x1E038FC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		private object System.ICloneable.Clone()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000D1D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal bool ipv6Enabled;

		[global::Cpp2ILInjected.Token(Token = "0x4000D1E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int MaxResponseHeadersLength;
	}
}
