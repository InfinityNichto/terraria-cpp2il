using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200042F")]
public interface ISearchFilter<T> : IEntryFilter<T>
{
	[Cpp2IlInjected.Token(Token = "0x6003115")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void SetSearch(string searchText);
}
