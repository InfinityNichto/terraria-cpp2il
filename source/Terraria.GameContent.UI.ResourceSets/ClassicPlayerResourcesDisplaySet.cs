using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Terraria.DataStructures;

namespace Terraria.GameContent.UI.ResourceSets;

[Cpp2IlInjected.Token(Token = "0x20006AB")]
public class ClassicPlayerResourcesDisplaySet : IPlayerResourcesDisplaySet, IConfigKeyHolder
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006F2D")]
	private int UIDisplay_ManaPerStar;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006F2E")]
	private float UIDisplay_LifePerHeart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006F2F")]
	private int UI_ScreenAnchorX;

	[Cpp2IlInjected.Token(Token = "0x170007AF")]
	public string NameKey
	{
		[Cpp2IlInjected.Token(Token = "0x6004373")]
		[Cpp2IlInjected.Address(RVA = "0x109FDDC", Offset = "0x109FDDC", VA = "0x109FDDC", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6004374")]
		[Cpp2IlInjected.Address(RVA = "0x109FDE4", Offset = "0x109FDE4", VA = "0x109FDE4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007B0")]
	public string ConfigKey
	{
		[Cpp2IlInjected.Token(Token = "0x6004375")]
		[Cpp2IlInjected.Address(RVA = "0x109FDEC", Offset = "0x109FDEC", VA = "0x109FDEC", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6004376")]
		[Cpp2IlInjected.Address(RVA = "0x109FDF4", Offset = "0x109FDF4", VA = "0x109FDF4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004377")]
	[Cpp2IlInjected.Address(RVA = "0x109FDFC", Offset = "0x109FDFC", VA = "0x109FDFC")]
	public ClassicPlayerResourcesDisplaySet(string nameKey, string configKey)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004378")]
	[Cpp2IlInjected.Address(RVA = "0x109FE3C", Offset = "0x109FE3C", VA = "0x109FE3C", Slot = "4")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004379")]
	[Cpp2IlInjected.Address(RVA = "0x109FED0", Offset = "0x109FED0", VA = "0x109FED0")]
	private void DrawLife()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600437A")]
	[Cpp2IlInjected.Address(RVA = "0x10A0B58", Offset = "0x10A0B58", VA = "0x10A0B58")]
	private void DrawMana()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600437B")]
	[Cpp2IlInjected.Address(RVA = "0x10A11D8", Offset = "0x10A11D8", VA = "0x10A11D8", Slot = "5")]
	public void TryToHover()
	{
	}
}
