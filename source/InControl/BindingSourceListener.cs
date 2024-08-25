using System;
using Cpp2ILInjected;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x2000004")]
	public interface BindingSourceListener
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000018")]
		void Reset();

		[global::Cpp2ILInjected.Token(Token = "0x6000019")]
		BindingSource Listen(BindingListenOptions listenOptions, InputDevice device);
	}
}
