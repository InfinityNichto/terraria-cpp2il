using System;
using System.IO;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Serialization
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003DA")]
	public interface IFormatter
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001F1A")]
		object Deserialize(global::System.IO.Stream serializationStream);
	}
}
