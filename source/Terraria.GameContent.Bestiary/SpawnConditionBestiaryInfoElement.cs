using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x200063C")]
public class SpawnConditionBestiaryInfoElement : FilterProviderInfoElement, IBestiaryBackgroundImagePathAndColorProvider, IBestiaryPrioritizedElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006C78")]
	private string _backgroundImagePath;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006C79")]
	private Color? _backgroundColor;

	[Cpp2IlInjected.Token(Token = "0x1700076F")]
	public float OrderPriority
	{
		[Cpp2IlInjected.Token(Token = "0x6003F18")]
		[Cpp2IlInjected.Address(RVA = "0x1104A5C", Offset = "0x1104A5C", VA = "0x1104A5C", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6003F19")]
		[Cpp2IlInjected.Address(RVA = "0x1104A64", Offset = "0x1104A64", VA = "0x1104A64")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003F1A")]
	[Cpp2IlInjected.Address(RVA = "0x10F64F4", Offset = "0x10F64F4", VA = "0x10F64F4")]
	public SpawnConditionBestiaryInfoElement(string nameLanguageKey, int filterIconFrame, [Optional] string backgroundImagePath, [Optional] Color? backgroundColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F1B")]
	[Cpp2IlInjected.Address(RVA = "0x1104A6C", Offset = "0x1104A6C", VA = "0x1104A6C", Slot = "9")]
	public Asset<Texture2D> GetBackgroundImage()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F1C")]
	[Cpp2IlInjected.Address(RVA = "0x1104B94", Offset = "0x1104B94", VA = "0x1104B94", Slot = "10")]
	public Color? GetBackgroundColor()
	{
		return null;
	}
}
