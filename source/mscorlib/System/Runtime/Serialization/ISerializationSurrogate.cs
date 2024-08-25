using System;
using Cpp2ILInjected;

namespace System.Runtime.Serialization
{
	[global::Cpp2ILInjected.Token(Token = "0x20003CE")]
	public interface ISerializationSurrogate
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001EE2")]
		void GetObjectData(object obj, SerializationInfo info, StreamingContext context);

		[global::Cpp2ILInjected.Token(Token = "0x6001EE3")]
		object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector);
	}
}
