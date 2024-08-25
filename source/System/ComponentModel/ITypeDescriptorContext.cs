using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x2000389")]
	public interface ITypeDescriptorContext : IServiceProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000564")]
		IContainer Container
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017A2")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000565")]
		object Instance
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017A3")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000566")]
		PropertyDescriptor PropertyDescriptor
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017A4")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017A5")]
		bool OnComponentChanging();

		[global::Cpp2ILInjected.Token(Token = "0x60017A6")]
		void OnComponentChanged();
	}
}
