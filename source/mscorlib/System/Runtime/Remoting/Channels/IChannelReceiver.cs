using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Channels
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200037E")]
	public interface IChannelReceiver : IChannel
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000371")]
		object ChannelData
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D46")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D47")]
		void StartListening(object data);
	}
}
