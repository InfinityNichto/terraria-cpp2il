using System;
using Cpp2ILInjected;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200038C RID: 908
	[global::Cpp2ILInjected.Token(Token = "0x2000436")]
	public interface ICustomMarshaler
	{
		// Token: 0x06001F20 RID: 7968
		[global::Cpp2ILInjected.Token(Token = "0x6002161")]
		object MarshalNativeToManaged(global::System.IntPtr pNativeData);

		// Token: 0x06001F21 RID: 7969
		[global::Cpp2ILInjected.Token(Token = "0x6002162")]
		global::System.IntPtr MarshalManagedToNative(object ManagedObj);

		// Token: 0x06001F22 RID: 7970
		[global::Cpp2ILInjected.Token(Token = "0x6002163")]
		void CleanUpNativeData(global::System.IntPtr pNativeData);

		// Token: 0x06001F23 RID: 7971
		[global::Cpp2ILInjected.Token(Token = "0x6002164")]
		void CleanUpManagedData(object ManagedObj);

		// Token: 0x06001F24 RID: 7972
		[global::Cpp2ILInjected.Token(Token = "0x6002165")]
		int GetNativeDataSize();
	}
}
