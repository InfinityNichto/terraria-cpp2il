using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000097")]
	public interface IValueProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x600053A")]
		void SetValue(object target, object value);

		[global::Cpp2ILInjected.Token(Token = "0x600053B")]
		object GetValue(object target);
	}
}
