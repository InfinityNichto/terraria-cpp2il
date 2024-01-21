using System.Collections.Generic;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200007A")]
public class GUIControllerHardwareProfile
{
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private static GUIControllerMappingEntryBase overlayEntry;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private static Rectangle overlayRegion;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static bool Enabled;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	private static bool performingBinding;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	private static float TimeSinceItemChange;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	private static float GameplayButtonScale;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	private static float UIButtonScale;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private static float SaveAndCloseButtonScale;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private static float ResetSettingsButtonScale;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private static float titleScale;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static float ScrollOffset;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private static float ScrollMomentum;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private static int ScrollDragging;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private static Vector2 DragOffset;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static List<GUIControllerMappingEntryBase> _categorySettings;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private static bool hasFocus;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private static GUIInputRegionExclusive _categoriesBlocker;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static ControllerDevice.ControlScheme ActiveScheme;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static ControllerDevice CurrentDevice;

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x129A95C", Offset = "0x129A95C", VA = "0x129A95C")]
	public static void RegisterOverlay(GUIControllerMappingEntryBase entry, Rectangle region)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x129AAA4", Offset = "0x129AAA4", VA = "0x129AAA4")]
	public static void SetControllerFace(ControllerDevice.ControlScheme scheme)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x129AB20", Offset = "0x129AB20", VA = "0x129AB20")]
	public static void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x129B2B4", Offset = "0x129B2B4", VA = "0x129B2B4")]
	public static void Close()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x129BE90", Offset = "0x129BE90", VA = "0x129BE90")]
	public static void UpdateAndSaveCurrentProfile()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x129B9B4", Offset = "0x129B9B4", VA = "0x129B9B4")]
	private static void DrawMainButtons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x129B7BC", Offset = "0x129B7BC", VA = "0x129B7BC")]
	private static void DrawTitle()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x129B500", Offset = "0x129B500", VA = "0x129B500")]
	private static void DrawBacking()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x129B5BC", Offset = "0x129B5BC", VA = "0x129B5BC")]
	private static void DrawCategoryOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x129C494", Offset = "0x129C494", VA = "0x129C494")]
	private static float SettingScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x129C49C", Offset = "0x129C49C", VA = "0x129C49C")]
	private static void SettingOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x129C4A0", Offset = "0x129C4A0", VA = "0x129C4A0")]
	private static void SettingDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x129C624", Offset = "0x129C624", VA = "0x129C624")]
	private static Vector2 SettingSize(int index)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x129B338", Offset = "0x129B338", VA = "0x129B338")]
	public static void Open(ControllerDevice device)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x129CA1C", Offset = "0x129CA1C", VA = "0x129CA1C")]
	public GUIControllerHardwareProfile()
	{
	}
}
