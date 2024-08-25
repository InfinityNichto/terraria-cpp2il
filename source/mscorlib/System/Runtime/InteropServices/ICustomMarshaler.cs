using System;
using Cpp2ILInjected;

namespace System.Runtime.InteropServices
{
	[global::Cpp2ILInjected.Token(Token = "0x2000436")]
	public interface ICustomMarshaler
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002161")]
		object MarshalNativeToManaged(global::System.IntPtr pNativeData);

		[global::Cpp2ILInjected.Token(Token = "0x6002162")]
		global::System.IntPtr MarshalManagedToNative(object ManagedObj);

		[global::Cpp2ILInjected.Token(Token = "0x6002163")]
		void CleanUpNativeData(global::System.IntPtr pNativeData);

		[global::Cpp2ILInjected.Token(Token = "0x6002164")]
		void CleanUpManagedData(object ManagedObj);

		[global::Cpp2ILInjected.Token(Token = "0x6002165")]
		int GetNativeDataSize();
	}
}
