using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	[Obsolete("This interface has been deprecated. Add a TypeDescriptionProvider to handle type TypeDescriptor.ComObjectType instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
	[global::Cpp2ILInjected.Token(Token = "0x200037F")]
	public interface IComNativeDescriptorHandler
	{
		[global::Cpp2ILInjected.Token(Token = "0x600177D")]
		AttributeCollection GetAttributes(object component);

		[global::Cpp2ILInjected.Token(Token = "0x600177E")]
		string GetClassName(object component);

		[global::Cpp2ILInjected.Token(Token = "0x600177F")]
		TypeConverter GetConverter(object component);

		[global::Cpp2ILInjected.Token(Token = "0x6001780")]
		EventDescriptor GetDefaultEvent(object component);

		[global::Cpp2ILInjected.Token(Token = "0x6001781")]
		PropertyDescriptor GetDefaultProperty(object component);

		[global::Cpp2ILInjected.Token(Token = "0x6001782")]
		object GetEditor(object component, Type baseEditorType);

		[global::Cpp2ILInjected.Token(Token = "0x6001783")]
		string GetName(object component);

		[global::Cpp2ILInjected.Token(Token = "0x6001784")]
		EventDescriptorCollection GetEvents(object component);

		[global::Cpp2ILInjected.Token(Token = "0x6001785")]
		EventDescriptorCollection GetEvents(object component, Attribute[] attributes);

		[global::Cpp2ILInjected.Token(Token = "0x6001786")]
		PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes);

		[global::Cpp2ILInjected.Token(Token = "0x6001787")]
		object GetPropertyValue(object component, string propertyName, ref bool success);

		[global::Cpp2ILInjected.Token(Token = "0x6001788")]
		object GetPropertyValue(object component, int dispid, ref bool success);
	}
}
