using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x200033C")]
	public interface ISite : IServiceProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x170004EB")]
		IComponent Component
		{
			[global::Cpp2ILInjected.Token(Token = "0x600159A")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004EC")]
		IContainer Container
		{
			[global::Cpp2ILInjected.Token(Token = "0x600159B")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004ED")]
		bool DesignMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600159C")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004EE")]
		string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x600159D")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x600159E")]
			set;
		}
	}
}
