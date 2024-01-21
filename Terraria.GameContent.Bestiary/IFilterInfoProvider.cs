using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x200063F")]
public interface IFilterInfoProvider
{
	[Cpp2IlInjected.Token(Token = "0x6003F2A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	UIElement GetFilterImage();

	[Cpp2IlInjected.Token(Token = "0x6003F2B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GetDisplayNameKey();

	[Cpp2IlInjected.Token(Token = "0x6003F2C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GetDisplay(out Texture2D texture, out Rectangle frame);
}
