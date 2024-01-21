using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200042D")]
public interface IEntryFilter<T>
{
	[Cpp2IlInjected.Token(Token = "0x6003110")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FitsFilter(T entry);

	[Cpp2IlInjected.Token(Token = "0x6003111")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GetDisplayNameKey();

	[Cpp2IlInjected.Token(Token = "0x6003112")]
	[Cpp2IlInjected.Address(Slot = "2")]
	UIElement GetImage();

	[Cpp2IlInjected.Token(Token = "0x6003113")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GetDisplay(out Texture2D texture, out Rectangle frame);
}
