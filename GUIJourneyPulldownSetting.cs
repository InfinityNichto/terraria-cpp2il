using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000110")]
public class GUIJourneyPulldownSetting : GUIPulldownSetting
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400087B")]
	private float iconScale;

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x1372DE8", Offset = "0x1372DE8", VA = "0x1372DE8")]
	public GUIJourneyPulldownSetting(GUISettingID id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x1374A44", Offset = "0x1374A44", VA = "0x1374A44", Slot = "4")]
	public override void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0D")]
	[Cpp2IlInjected.Address(RVA = "0x1374C1C", Offset = "0x1374C1C", VA = "0x1374C1C")]
	private static void ActivateOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0E")]
	[Cpp2IlInjected.Address(RVA = "0x1374CD0", Offset = "0x1374CD0", VA = "0x1374CD0")]
	private static void DeactivateOverlay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0F")]
	[Cpp2IlInjected.Address(RVA = "0x1374D38", Offset = "0x1374D38", VA = "0x1374D38")]
	private static void RegisterOverlayJM(GUIPulldownSetting overlayEntry, Rectangle overlayRegion)
	{
	}
}
