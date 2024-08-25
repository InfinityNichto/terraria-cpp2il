using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200009A")]
	public delegate void SerializationCallback(object o, StreamingContext context);
}
