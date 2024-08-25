using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x200038A")]
	public interface ITypedList
	{
		[global::Cpp2ILInjected.Token(Token = "0x60017A7")]
		string GetListName(PropertyDescriptor[] listAccessors);

		[global::Cpp2ILInjected.Token(Token = "0x60017A8")]
		PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors);
	}
}
