using System;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000305 RID: 773
	[global::Cpp2ILInjected.Token(Token = "0x20003AA")]
	internal interface IInternalMessage
	{
		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06001BD9 RID: 7129
		// (set) Token: 0x06001BDA RID: 7130
		[global::Cpp2ILInjected.Token(Token = "0x170003B6")]
		Identity TargetIdentity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E0B")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6001E0C")]
			set;
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06001BDB RID: 7131
		// (set) Token: 0x06001BDC RID: 7132
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
