using System;
using Cpp2ILInjected;

namespace System.Runtime.ConstrainedExecution
{
	[global::Cpp2ILInjected.Token(Token = "0x200045E")]
	public enum Consistency
	{
		[global::Cpp2ILInjected.Token(Token = "0x400129C")]
		MayCorruptProcess,
		[global::Cpp2ILInjected.Token(Token = "0x400129D")]
		MayCorruptAppDomain,
		[global::Cpp2ILInjected.Token(Token = "0x400129E")]
		MayCorruptInstance,
		[global::Cpp2ILInjected.Token(Token = "0x400129F")]
		WillNotCorruptState
	}
}
