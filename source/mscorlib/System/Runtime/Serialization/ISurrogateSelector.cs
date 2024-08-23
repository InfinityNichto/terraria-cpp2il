using System;
using Cpp2ILInjected;

namespace System.Runtime.Serialization
{
	// Token: 0x02000329 RID: 809
	[global::Cpp2ILInjected.Token(Token = "0x20003CF")]
	public interface ISurrogateSelector
	{
		// Token: 0x06001CAB RID: 7339
		[global::Cpp2ILInjected.Token(Token = "0x6001EE4")]
		ISerializationSurrogate GetSurrogate(global::System.Type type, StreamingContext context, out ISurrogateSelector selector);
	}
}
