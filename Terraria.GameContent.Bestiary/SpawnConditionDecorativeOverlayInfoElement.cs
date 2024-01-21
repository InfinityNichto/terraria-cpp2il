using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x200063E")]
public class SpawnConditionDecorativeOverlayInfoElement : IBestiaryInfoElement, IBestiaryBackgroundOverlayAndColorProvider
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C7F")]
	private string _overlayImagePath;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006C80")]
	private Color? _overlayColor;

	[Cpp2IlInjected.Token(Token = "0x17000772")]
	public float DisplayPriority
	{
		[Cpp2IlInjected.Token(Token = "0x6003F24")]
		[Cpp2IlInjected.Address(RVA = "0x1104D04", Offset = "0x1104D04", VA = "0x1104D04", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6003F25")]
		[Cpp2IlInjected.Address(RVA = "0x1104D0C", Offset = "0x1104D0C", VA = "0x1104D0C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003F26")]
	[Cpp2IlInjected.Address(RVA = "0x10F7608", Offset = "0x10F7608", VA = "0x10F7608")]
	public SpawnConditionDecorativeOverlayInfoElement([Optional] string overlayImagePath, [Optional] Color? overlayColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F27")]
	[Cpp2IlInjected.Address(RVA = "0x1104D14", Offset = "0x1104D14", VA = "0x1104D14", Slot = "5")]
	public Asset<Texture2D> GetBackgroundOverlayImage()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F28")]
	[Cpp2IlInjected.Address(RVA = "0x1104E3C", Offset = "0x1104E3C", VA = "0x1104E3C", Slot = "6")]
	public Color? GetBackgroundOverlayColor()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F29")]
	[Cpp2IlInjected.Address(RVA = "0x1104E50", Offset = "0x1104E50", VA = "0x1104E50", Slot = "4")]
	public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
	{
		return null;
	}
}
