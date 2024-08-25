using System;
using Cpp2ILInjected;

namespace System.ComponentModel.Design
{
	[global::Cpp2ILInjected.Token(Token = "0x200040E")]
	public interface IDesignerHost : IServiceProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700063B")]
		IComponent RootComponent
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C0A")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C0B")]
		IDesigner GetDesigner(IComponent component);
	}
}
