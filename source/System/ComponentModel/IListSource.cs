using System;
using System.Collections;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	[MergableProperty(false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000384")]
	public interface IListSource
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700055F")]
		bool ContainsListCollection
		{
			[global::Cpp2ILInjected.Token(Token = "0x600179A")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600179B")]
		IList GetList();
	}
}
