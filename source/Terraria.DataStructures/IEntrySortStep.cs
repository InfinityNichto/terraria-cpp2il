using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200042E")]
public interface IEntrySortStep<T> : IComparer<T>
{
	[Cpp2IlInjected.Token(Token = "0x6003114")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GetDisplayNameKey();
}
