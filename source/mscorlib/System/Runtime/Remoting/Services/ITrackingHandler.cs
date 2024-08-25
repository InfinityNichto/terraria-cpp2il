using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Services
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000357")]
	public interface ITrackingHandler
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001C88")]
		void DisconnectedObject(object obj);

		[global::Cpp2ILInjected.Token(Token = "0x6001C89")]
		void MarshaledObject(object obj, ObjRef or);

		[global::Cpp2ILInjected.Token(Token = "0x6001C8A")]
		void UnmarshaledObject(object obj, ObjRef or);
	}
}
