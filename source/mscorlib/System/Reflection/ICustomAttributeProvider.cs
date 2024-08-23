using System;
using Cpp2ILInjected;

namespace System.Reflection
{
	// Token: 0x02000417 RID: 1047
	[global::Cpp2ILInjected.Token(Token = "0x20004D6")]
	public interface ICustomAttributeProvider
	{
		// Token: 0x06002111 RID: 8465
		[global::Cpp2ILInjected.Token(Token = "0x60023AB")]
		object[] GetCustomAttributes(bool inherit);

		// Token: 0x06002112 RID: 8466
		[global::Cpp2ILInjected.Token(Token = "0x60023AC")]
		object[] GetCustomAttributes(global::System.Type attributeType, bool inherit);

		// Token: 0x06002113 RID: 8467
		[global::Cpp2ILInjected.Token(Token = "0x60023AD")]
		bool IsDefined(global::System.Type attributeType, bool inherit);
	}
}
