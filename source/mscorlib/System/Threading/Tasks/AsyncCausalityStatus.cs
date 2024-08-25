using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace System.Threading.Tasks
{
	[global::System.Runtime.CompilerServices.FriendAccessAllowed]
	[global::Cpp2ILInjected.Token(Token = "0x2000254")]
	internal enum AsyncCausalityStatus
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000ACC")]
		Started,
		[global::Cpp2ILInjected.Token(Token = "0x4000ACD")]
		Completed,
		[global::Cpp2ILInjected.Token(Token = "0x4000ACE")]
		Canceled,
		[global::Cpp2ILInjected.Token(Token = "0x4000ACF")]
		Error
	}
}
