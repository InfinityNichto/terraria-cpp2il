using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000054")]
public class GUIControllerPulldownEntry : GUIControllerMappingEntryBase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private GUIPulldownSetting Worker;

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x1218738", Offset = "0x1218738", VA = "0x1218738")]
	public GUIControllerPulldownEntry(GUISettingID id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x12188A4", Offset = "0x12188A4", VA = "0x12188A4", Slot = "4")]
	public override void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x12188B8", Offset = "0x12188B8", VA = "0x12188B8", Slot = "5")]
	public override float GetElementHeight()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x12188CC", Offset = "0x12188CC", VA = "0x12188CC", Slot = "6")]
	public override void DrawOverlay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x12188E0", Offset = "0x12188E0", VA = "0x12188E0")]
	private void ActivateOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x1218998", Offset = "0x1218998", VA = "0x1218998")]
	private void DeactivateOverlay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x1218A00", Offset = "0x1218A00", VA = "0x1218A00")]
	private void RegisterOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x1218A98", Offset = "0x1218A98", VA = "0x1218A98")]
	public int GetNumberOfOptions()
	{
		return default(int);
	}
}
