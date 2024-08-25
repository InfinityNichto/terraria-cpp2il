using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000626")]
	public interface IEntrySortStep<T> : IComparer<T>
	{
		[global::Cpp2ILInjected.Token(Token = "0x60035F5")]
		string GetDisplayNameKey();
	}
}
