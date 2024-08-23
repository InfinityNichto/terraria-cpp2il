using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000075 RID: 117
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000097")]
	public interface IValueProvider
	{
		// Token: 0x060004D8 RID: 1240
		[global::Cpp2ILInjected.Token(Token = "0x600053A")]
		void SetValue(object target, object value);

		// Token: 0x060004D9 RID: 1241
		[global::Cpp2ILInjected.Token(Token = "0x600053B")]
		object GetValue(object target);
	}
}
