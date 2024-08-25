using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x2000388")]
	public interface ISupportInitializeNotification : ISupportInitialize
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000563")]
		bool IsInitialized
		{
			[global::Cpp2ILInjected.Token(Token = "0x600179F")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x14000014")]
		event EventHandler Initialized;
	}
}
