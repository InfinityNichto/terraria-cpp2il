using System;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Messaging
{
	[global::Cpp2ILInjected.Token(Token = "0x20003AA")]
	internal interface IInternalMessage
	{
		[global::Cpp2ILInjected.Token(Token = "0x170003B6")]
		Identity TargetIdentity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E0B")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6001E0C")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003B7")]
		string Uri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E0D")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6001E0E")]
			set;
		}
	}
}
