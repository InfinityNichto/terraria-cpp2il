using System;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	[global::Cpp2ILInjected.Token(Token = "0x2000631")]
	public interface IEnumerator<out T> : global::System.IDisposable, IEnumerator
	{
		[global::Cpp2ILInjected.Token(Token = "0x170007D0")]
		T Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003090")]
			get;
		}
	}
}
