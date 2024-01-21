using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x200063D")]
public class SpawnConditionBestiaryOverlayInfoElement : FilterProviderInfoElement, IBestiaryBackgroundOverlayAndColorProvider, IBestiaryPrioritizedElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006C7B")]
	private string _overlayImagePath;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006C7C")]
	private Color? _overlayColor;

	[Cpp2IlInjected.Token(Token = "0x17000770")]
	public float DisplayPriority
	{
		[Cpp2IlInjected.Token(Token = "0x6003F1D")]
		[Cpp2IlInjected.Address(RVA = "0x1104BA8", Offset = "0x1104BA8", VA = "0x1104BA8", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6003F1E")]
		[Cpp2IlInjected.Address(RVA = "0x1104BB0", Offset = "0x1104BB0", VA = "0x1104BB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000771")]
	public float OrderPriority
	{
		[Cpp2IlInjected.Token(Token = "0x6003F1F")]
		[Cpp2IlInjected.Address(RVA = "0x1104BB8", Offset = "0x1104BB8", VA = "0x1104BB8", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6003F20")]
		[Cpp2IlInjected.Address(RVA = "0x1104BC0", Offset = "0x1104BC0", VA = "0x1104BC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003F21")]
	[Cpp2IlInjected.Address(RVA = "0x10F6B34", Offset = "0x10F6B34", VA = "0x10F6B34")]
	public SpawnConditionBestiaryOverlayInfoElement(string nameLanguageKey, int filterIconFrame, [Optional] string overlayImagePath, [Optional] Color? overlayColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F22")]
	[Cpp2IlInjected.Address(RVA = "0x1104BC8", Offset = "0x1104BC8", VA = "0x1104BC8", Slot = "9")]
	public Asset<Texture2D> GetBackgroundOverlayImage()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F23")]
	[Cpp2IlInjected.Address(RVA = "0x1104CF0", Offset = "0x1104CF0", VA = "0x1104CF0", Slot = "10")]
	public Color? GetBackgroundOverlayColor()
	{
		return null;
	}
}
