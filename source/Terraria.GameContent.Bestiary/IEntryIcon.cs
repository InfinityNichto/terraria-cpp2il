using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000621")]
public interface IEntryIcon
{
	[Cpp2IlInjected.Token(Token = "0x6003EBE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Update(BestiaryUICollectionInfo providedInfo, Rectangle hitbox, EntryIconDrawSettings settings);

	[Cpp2IlInjected.Token(Token = "0x6003EBF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Draw(BestiaryUICollectionInfo providedInfo, SpriteBatch spriteBatch, EntryIconDrawSettings settings);

	[Cpp2IlInjected.Token(Token = "0x6003EC0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GetUnlockState(BestiaryUICollectionInfo providedInfo);

	[Cpp2IlInjected.Token(Token = "0x6003EC1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string GetHoverText(BestiaryUICollectionInfo providedInfo);

	[Cpp2IlInjected.Token(Token = "0x6003EC2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IEntryIcon CreateClone();
}
