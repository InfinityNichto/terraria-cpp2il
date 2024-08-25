using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x2000380")]
	public interface ICustomTypeDescriptor
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001789")]
		AttributeCollection GetAttributes();

		[global::Cpp2ILInjected.Token(Token = "0x600178A")]
		string GetClassName();

		[global::Cpp2ILInjected.Token(Token = "0x600178B")]
		string GetComponentName();

		[global::Cpp2ILInjected.Token(Token = "0x600178C")]
		TypeConverter GetConverter();

		[global::Cpp2ILInjected.Token(Token = "0x600178D")]
		EventDescriptor GetDefaultEvent();

		[global::Cpp2ILInjected.Token(Token = "0x600178E")]
		PropertyDescriptor GetDefaultProperty();

		[global::Cpp2ILInjected.Token(Token = "0x600178F")]
		object GetEditor(Type editorBaseType);

		[global::Cpp2ILInjected.Token(Token = "0x6001790")]
		EventDescriptorCollection GetEvents();

		[global::Cpp2ILInjected.Token(Token = "0x6001791")]
		EventDescriptorCollection GetEvents(Attribute[] attributes);

		[global::Cpp2ILInjected.Token(Token = "0x6001792")]
		PropertyDescriptorCollection GetProperties();

		[global::Cpp2ILInjected.Token(Token = "0x6001793")]
		PropertyDescriptorCollection GetProperties(Attribute[] attributes);

		[global::Cpp2ILInjected.Token(Token = "0x6001794")]
		object GetPropertyOwner(PropertyDescriptor pd);
	}
}
