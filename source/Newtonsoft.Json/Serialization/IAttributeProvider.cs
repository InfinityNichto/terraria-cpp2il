using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000061 RID: 97
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200007A")]
	public interface IAttributeProvider
	{
		// Token: 0x0600040D RID: 1037
		[global::Cpp2ILInjected.Token(Token = "0x6000450")]
		IList<Attribute> GetAttributes(bool inherit);

		// Token: 0x0600040E RID: 1038
		[global::Cpp2ILInjected.Token(Token = "0x6000451")]
		IList<Attribute> GetAttributes(Type attributeType, bool inherit);
	}
}
