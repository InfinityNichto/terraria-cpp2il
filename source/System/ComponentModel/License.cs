using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x2000393")]
	public abstract class License : IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700056D")]
		public abstract string LicenseKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017CB")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017CC")]
		public abstract void Dispose();

		[global::Cpp2ILInjected.Token(Token = "0x60017CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4DC94", Offset = "0x1E4DC94", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected License()
		{
			throw null;
		}
	}
}
