using System;
using Cpp2ILInjected;

namespace System.Runtime.Serialization
{
	[global::Cpp2ILInjected.Token(Token = "0x20003CF")]
	public interface ISurrogateSelector
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001EE4")]
		ISerializationSurrogate GetSurrogate(global::System.Type type, StreamingContext context, out ISurrogateSelector selector);
	}
}
