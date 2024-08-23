using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x0200030B RID: 779
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003B0")]
	public interface IMethodReturnMessage : IMethodMessage, IMessage
	{
		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001BE9 RID: 7145
		[global::Cpp2ILInjected.Token(Token = "0x170003C1")]
		global::System.Exception Exception
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E1B")]
			get;
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001BEA RID: 7146
		[global::Cpp2ILInjected.Token(Token = "0x170003C2")]
		object[] OutArgs
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E1C")]
			get;
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06001BEB RID: 7147
		[global::Cpp2ILInjected.Token(Token = "0x170003C3")]
		object ReturnValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E1D")]
			get;
		}
	}
}
