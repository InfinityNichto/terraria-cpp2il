using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x200033B")]
	public interface IContainer : IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001596")]
		void Add(IComponent component);

		[global::Cpp2ILInjected.Token(Token = "0x6001597")]
		void Add(IComponent component, string name);

		[global::Cpp2ILInjected.Token(Token = "0x170004EA")]
		ComponentCollection Components
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001598")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001599")]
		void Remove(IComponent component);
	}
}
