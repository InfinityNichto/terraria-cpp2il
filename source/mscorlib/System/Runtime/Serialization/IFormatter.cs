using System;
using System.IO;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Serialization
{
	// Token: 0x02000332 RID: 818
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003DA")]
	public interface IFormatter
	{
		// Token: 0x06001CDC RID: 7388
		[global::Cpp2ILInjected.Token(Token = "0x6001F1A")]
		object Deserialize(global::System.IO.Stream serializationStream);
	}
}
