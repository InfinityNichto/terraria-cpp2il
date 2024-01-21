using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000624")]
public class CustomEntryIcon : IEntryIcon
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C57")]
	private LocalizedText _text;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006C58")]
	private Asset<Texture2D> _textureAsset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006C59")]
	private Rectangle _sourceRectangle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006C5A")]
	private Func<bool> _unlockCondition;

	[Cpp2IlInjected.Token(Token = "0x6003ECC")]
	[Cpp2IlInjected.Address(RVA = "0x10F8844", Offset = "0x10F8844", VA = "0x10F8844")]
	public CustomEntryIcon(string nameLanguageKey, string texturePath, Func<bool> unlockCondition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003ECD")]
	[Cpp2IlInjected.Address(RVA = "0x10FA6D0", Offset = "0x10FA6D0", VA = "0x10FA6D0", Slot = "8")]
	public IEntryIcon CreateClone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003ECE")]
	[Cpp2IlInjected.Address(RVA = "0x10FA75C", Offset = "0x10FA75C", VA = "0x10FA75C", Slot = "4")]
	public void Update(BestiaryUICollectionInfo providedInfo, Rectangle hitbox, EntryIconDrawSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003ECF")]
	[Cpp2IlInjected.Address(RVA = "0x10FA77C", Offset = "0x10FA77C", VA = "0x10FA77C", Slot = "5")]
	public void Draw(BestiaryUICollectionInfo providedInfo, SpriteBatch spriteBatch, EntryIconDrawSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003ED0")]
	[Cpp2IlInjected.Address(RVA = "0x10FA9D0", Offset = "0x10FA9D0", VA = "0x10FA9D0", Slot = "7")]
	public string GetHoverText(BestiaryUICollectionInfo providedInfo)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003ED1")]
	[Cpp2IlInjected.Address(RVA = "0x10FA5F8", Offset = "0x10FA5F8", VA = "0x10FA5F8")]
	private void UpdateUnlockState(bool state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003ED2")]
	[Cpp2IlInjected.Address(RVA = "0x10FA76C", Offset = "0x10FA76C", VA = "0x10FA76C", Slot = "6")]
	public bool GetUnlockState(BestiaryUICollectionInfo providedInfo)
	{
		return default(bool);
	}
}
