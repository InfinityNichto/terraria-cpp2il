using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200012C")]
	internal class NegotiationInfoClass
	{
		[global::Cpp2ILInjected.Token(Token = "0x600072A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE5150", Offset = "0x1EE5150", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public NegotiationInfoClass()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000591")]
		internal const string NTLM = "NTLM";

		[global::Cpp2ILInjected.Token(Token = "0x4000592")]
		internal const string Kerberos = "Kerberos";

		[global::Cpp2ILInjected.Token(Token = "0x4000593")]
		internal const string Negotiate = "Negotiate";

		[global::Cpp2ILInjected.Token(Token = "0x4000594")]
		internal const string Basic = "Basic";
	}
}
