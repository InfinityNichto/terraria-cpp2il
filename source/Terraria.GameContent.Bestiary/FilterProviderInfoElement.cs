using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000637")]
public class FilterProviderInfoElement : IFilterInfoProvider, IProvideSearchFilterString, IBestiaryInfoElement
{
	[Cpp2IlInjected.Token(Token = "0x4006C6F")]
	private const int framesPerRow = 16;

	[Cpp2IlInjected.Token(Token = "0x4006C70")]
	private const int framesPerColumn = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C71")]
	public Point _filterIconFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006C72")]
	private string _key;

	[Cpp2IlInjected.Token(Token = "0x1700076D")]
	public int DisplayTextPriority
	{
		[Cpp2IlInjected.Token(Token = "0x6003EFD")]
		[Cpp2IlInjected.Address(RVA = "0x10FAA3C", Offset = "0x10FAA3C", VA = "0x10FAA3C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003EFE")]
		[Cpp2IlInjected.Address(RVA = "0x10FAA44", Offset = "0x10FAA44", VA = "0x10FAA44")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700076E")]
	public bool HideInPortraitInfo
	{
		[Cpp2IlInjected.Token(Token = "0x6003EFF")]
		[Cpp2IlInjected.Address(RVA = "0x10FAA4C", Offset = "0x10FAA4C", VA = "0x10FAA4C")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6003F00")]
		[Cpp2IlInjected.Address(RVA = "0x10FAA54", Offset = "0x10FAA54", VA = "0x10FAA54")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003F01")]
	[Cpp2IlInjected.Address(RVA = "0x10FAA5C", Offset = "0x10FAA5C", VA = "0x10FAA5C")]
	public FilterProviderInfoElement(string nameLanguageKey, int filterIconFrame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F02")]
	[Cpp2IlInjected.Address(RVA = "0x10FAA9C", Offset = "0x10FAA9C", VA = "0x10FAA9C", Slot = "4")]
	public UIElement GetFilterImage()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F03")]
	[Cpp2IlInjected.Address(RVA = "0x10FAC6C", Offset = "0x10FAC6C", VA = "0x10FAC6C", Slot = "7")]
	public string GetSearchString(ref BestiaryUICollectionInfo info)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F04")]
	[Cpp2IlInjected.Address(RVA = "0x10FAC98", Offset = "0x10FAC98", VA = "0x10FAC98", Slot = "5")]
	public string GetDisplayNameKey()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F05")]
	[Cpp2IlInjected.Address(RVA = "0x10FACA0", Offset = "0x10FACA0", VA = "0x10FACA0", Slot = "8")]
	public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F06")]
	[Cpp2IlInjected.Address(RVA = "0x10FB0B8", Offset = "0x10FB0B8", VA = "0x10FB0B8", Slot = "6")]
	public void GetDisplay(out Texture2D texture, out Rectangle frame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F07")]
	[Cpp2IlInjected.Address(RVA = "0x10FB028", Offset = "0x10FB028", VA = "0x10FB028")]
	private void AddOnHover(UIElement button)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F08")]
	[Cpp2IlInjected.Address(RVA = "0x10FB264", Offset = "0x10FB264", VA = "0x10FB264")]
	private void ShowButtonName(UIElement element)
	{
	}
}
