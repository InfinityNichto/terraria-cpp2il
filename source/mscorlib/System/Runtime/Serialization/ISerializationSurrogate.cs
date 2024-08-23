using System;
using Cpp2ILInjected;

namespace System.Runtime.Serialization
{
	// Token: 0x02000328 RID: 808
	[global::Cpp2ILInjected.Token(Token = "0x20003CE")]
	public interface ISerializationSurrogate
	{
		// Token: 0x06001CA9 RID: 7337
		[global::Cpp2ILInjected.Token(Token = "0x6001EE2")]
		void GetObjectData(object obj, SerializationInfo info, StreamingContext context);

		// Token: 0x06001CAA RID: 7338
		[global::Cpp2ILInjected.Token(Token = "0x6001EE3")]
		object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector);
	}
}
