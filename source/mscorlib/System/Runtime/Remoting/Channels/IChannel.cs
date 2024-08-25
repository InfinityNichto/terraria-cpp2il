using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Channels
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200037C")]
	public interface IChannel
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700036F")]
		string ChannelName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D44")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000370")]
		int ChannelPriority
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D45")]
			get;
		}
	}
}
