using System;
using Cpp2ILInjected;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000627")]
	public interface ISearchFilter<T> : IEntryFilter<T>
	{
		[global::Cpp2ILInjected.Token(Token = "0x60035F6")]
		void SetSearch(string searchText);
	}
}
