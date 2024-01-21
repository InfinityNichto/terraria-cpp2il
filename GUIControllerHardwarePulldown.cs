using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200007D")]
public class GUIControllerHardwarePulldown : GUIControllerMappingEntryBase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	private GUIPulldownSetting Worker;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x129C71C", Offset = "0x129C71C", VA = "0x129C71C")]
	public GUIControllerHardwarePulldown(GUISettingID id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x129E7D4", Offset = "0x129E7D4", VA = "0x129E7D4", Slot = "4")]
	public override void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x129E7E8", Offset = "0x129E7E8", VA = "0x129E7E8", Slot = "5")]
	public override float GetElementHeight()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x129E7FC", Offset = "0x129E7FC", VA = "0x129E7FC", Slot = "6")]
	public override void DrawOverlay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x129E810", Offset = "0x129E810", VA = "0x129E810")]
	private void ActivateOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x129E814", Offset = "0x129E814", VA = "0x129E814")]
	private void DeactivateOverlay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x129E818", Offset = "0x129E818", VA = "0x129E818")]
	private void RegisterOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x129E8B8", Offset = "0x129E8B8", VA = "0x129E8B8")]
	public int GetNumberOfOptions()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x129B2A8", Offset = "0x129B2A8", VA = "0x129B2A8")]
	public void CloseOptions()
	{
	}
}
