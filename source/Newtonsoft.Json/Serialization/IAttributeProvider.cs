using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200007A")]
	public interface IAttributeProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000450")]
		IList<Attribute> GetAttributes(bool inherit);

		[global::Cpp2ILInjected.Token(Token = "0x6000451")]
		IList<Attribute> GetAttributes(Type attributeType, bool inherit);
	}
}
