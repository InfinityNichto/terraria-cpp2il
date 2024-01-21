using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20001F2")]
public class GUISliderSetting : GUISettingEntry
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001705")]
	private float scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001706")]
	protected float sliderValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001707")]
	private float TimeSinceModified;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001708")]
	protected GUISlider.DragState dragState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001709")]
	protected GUISlider.DrawBackingHandler backingHandler;

	[Cpp2IlInjected.Token(Token = "0x6000E4D")]
	[Cpp2IlInjected.Address(RVA = "0xEE80CC", Offset = "0xEE80CC", VA = "0xEE80CC")]
	public GUISliderSetting(GUISettingID id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E4E")]
	[Cpp2IlInjected.Address(RVA = "0xEF44C4", Offset = "0xEF44C4", VA = "0xEF44C4", Slot = "7")]
	protected virtual SettingsOverlaySlider_Layout GetLayout()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000E4F")]
	[Cpp2IlInjected.Address(RVA = "0xEF4520", Offset = "0xEF4520", VA = "0xEF4520")]
	private Vector3 GetHSL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000E50")]
	[Cpp2IlInjected.Address(RVA = "0xEF4968", Offset = "0xEF4968", VA = "0xEF4968")]
	private void SetHSL(Vector3 hsl)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E51")]
	[Cpp2IlInjected.Address(RVA = "0xEF4C2C", Offset = "0xEF4C2C", VA = "0xEF4C2C", Slot = "4")]
	public override void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E52")]
	[Cpp2IlInjected.Address(RVA = "0xEF6F5C", Offset = "0xEF6F5C", VA = "0xEF6F5C", Slot = "5")]
	public override float GetElementHeight()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000E53")]
	[Cpp2IlInjected.Address(RVA = "0xEF535C", Offset = "0xEF535C", VA = "0xEF535C")]
	private float GetValue()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000E54")]
	[Cpp2IlInjected.Address(RVA = "0xEF5E7C", Offset = "0xEF5E7C", VA = "0xEF5E7C")]
	private int GetMaxValue()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000E55")]
	[Cpp2IlInjected.Address(RVA = "0xEF5F44", Offset = "0xEF5F44", VA = "0xEF5F44")]
	private void SetValue(float value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E56")]
	[Cpp2IlInjected.Address(RVA = "0xEF66EC", Offset = "0xEF66EC", VA = "0xEF66EC")]
	private string GetStringValue()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000E57")]
	[Cpp2IlInjected.Address(RVA = "0xEF5A24", Offset = "0xEF5A24", VA = "0xEF5A24")]
	private string GetTitle()
	{
		return null;
	}
}
