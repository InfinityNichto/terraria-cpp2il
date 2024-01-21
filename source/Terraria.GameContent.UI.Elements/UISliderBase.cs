using Cpp2IlInjected;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006CB")]
public class UISliderBase : UIElement
{
	[Cpp2IlInjected.Token(Token = "0x4006FF8")]
	internal const int UsageLevel_NotSelected = 0;

	[Cpp2IlInjected.Token(Token = "0x4006FF9")]
	internal const int UsageLevel_SelectedAndLocked = 1;

	[Cpp2IlInjected.Token(Token = "0x4006FFA")]
	internal const int UsageLevel_OtherElementIsLocked = 2;

	[Cpp2IlInjected.Token(Token = "0x4006FFB")]
	internal static UIElement CurrentLockedSlider;

	[Cpp2IlInjected.Token(Token = "0x4006FFC")]
	internal static UIElement CurrentAimedSlider;

	[Cpp2IlInjected.Token(Token = "0x6004466")]
	[Cpp2IlInjected.Address(RVA = "0x14863A0", Offset = "0x14863A0", VA = "0x14863A0")]
	internal int GetUsageLevel()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6004467")]
	[Cpp2IlInjected.Address(RVA = "0x1496F94", Offset = "0x1496F94", VA = "0x1496F94")]
	public static void EscapeElements()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004468")]
	[Cpp2IlInjected.Address(RVA = "0x1485C94", Offset = "0x1485C94", VA = "0x1485C94")]
	public UISliderBase()
	{
	}
}
