using System;
using Cpp2ILInjected;

namespace System.Reflection
{
	[global::Cpp2ILInjected.Token(Token = "0x20004D6")]
	public interface ICustomAttributeProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x60023AB")]
		object[] GetCustomAttributes(bool inherit);

		[global::Cpp2ILInjected.Token(Token = "0x60023AC")]
		object[] GetCustomAttributes(global::System.Type attributeType, bool inherit);

		[global::Cpp2ILInjected.Token(Token = "0x60023AD")]
		bool IsDefined(global::System.Type attributeType, bool inherit);
	}
}
