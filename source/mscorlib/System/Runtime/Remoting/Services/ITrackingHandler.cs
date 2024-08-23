using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Services
{
	// Token: 0x020002B7 RID: 695
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000357")]
	public interface ITrackingHandler
	{
		// Token: 0x06001A63 RID: 6755
		[global::Cpp2ILInjected.Token(Token = "0x6001C88")]
		void DisconnectedObject(object obj);

		// Token: 0x06001A64 RID: 6756
		[global::Cpp2ILInjected.Token(Token = "0x6001C89")]
		void MarshaledObject(object obj, ObjRef or);

		// Token: 0x06001A65 RID: 6757
		[global::Cpp2ILInjected.Token(Token = "0x6001C8A")]
		void UnmarshaledObject(object obj, ObjRef or);
	}
}
