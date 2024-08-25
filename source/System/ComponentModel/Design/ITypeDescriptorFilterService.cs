using System;
using System.Collections;
using Cpp2ILInjected;

namespace System.ComponentModel.Design
{
	[global::Cpp2ILInjected.Token(Token = "0x2000412")]
	public interface ITypeDescriptorFilterService
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001C12")]
		bool FilterAttributes(IComponent component, IDictionary attributes);

		[global::Cpp2ILInjected.Token(Token = "0x6001C13")]
		bool FilterEvents(IComponent component, IDictionary events);

		[global::Cpp2ILInjected.Token(Token = "0x6001C14")]
		bool FilterProperties(IComponent component, IDictionary properties);
	}
}
