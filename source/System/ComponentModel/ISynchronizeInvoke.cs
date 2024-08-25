using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x200033E")]
	public interface ISynchronizeInvoke
	{
		[global::Cpp2ILInjected.Token(Token = "0x170004EF")]
		bool InvokeRequired
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015A1")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015A2")]
		IAsyncResult BeginInvoke(Delegate method, object[] args);

		[global::Cpp2ILInjected.Token(Token = "0x60015A3")]
		object EndInvoke(IAsyncResult result);

		[global::Cpp2ILInjected.Token(Token = "0x60015A4")]
		object Invoke(Delegate method, object[] args);
	}
}
