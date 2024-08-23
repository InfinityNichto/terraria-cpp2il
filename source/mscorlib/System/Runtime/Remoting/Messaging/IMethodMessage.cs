using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x0200030A RID: 778
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003AF")]
	public interface IMethodMessage : IMessage
	{
		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06001BE0 RID: 7136
		[global::Cpp2ILInjected.Token(Token = "0x170003B9")]
		int ArgCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E12")]
			get;
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06001BE1 RID: 7137
		[global::Cpp2ILInjected.Token(Token = "0x170003BA")]
		object[] Args
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E13")]
			get;
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06001BE2 RID: 7138
		[global::Cpp2ILInjected.Token(Token = "0x170003BB")]
		LogicalCallContext LogicalCallContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E14")]
			get;
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06001BE3 RID: 7139
		[global::Cpp2ILInjected.Token(Token = "0x170003BC")]
		global::System.Reflection.MethodBase MethodBase
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E15")]
			get;
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001BE4 RID: 7140
		[global::Cpp2ILInjected.Token(Token = "0x170003BD")]
		string MethodName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E16")]
			get;
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001BE5 RID: 7141
		[global::Cpp2ILInjected.Token(Token = "0x170003BE")]
		object MethodSignature
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E17")]
			get;
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001BE6 RID: 7142
		[global::Cpp2ILInjected.Token(Token = "0x170003BF")]
		string TypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E18")]
			get;
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001BE7 RID: 7143
		[global::Cpp2ILInjected.Token(Token = "0x170003C0")]
		string Uri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E19")]
			get;
		}

		// Token: 0x06001BE8 RID: 7144
		[global::Cpp2ILInjected.Token(Token = "0x6001E1A")]
		object GetArg(int argNum);
	}
}
