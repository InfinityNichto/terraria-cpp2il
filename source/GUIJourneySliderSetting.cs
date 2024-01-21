using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x2000111")]
public class GUIJourneySliderSetting : GUISliderSetting
{
	[Cpp2IlInjected.Token(Token = "0x20007CE")]
	public struct ColorFadeBackup
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007AD3")]
		private Color IconColour;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007AD4")]
		private Color PressedIconColour;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007AD5")]
		private Color LabelColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007AD6")]
		private Color PressedLabelColor;

		[Cpp2IlInjected.Token(Token = "0x6004911")]
		[Cpp2IlInjected.Address(RVA = "0x399EA4", Offset = "0x399EA4", VA = "0x399EA4")]
		public void ApplyFade(TransactionButton_Layout layout, float fadeAmount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004912")]
		[Cpp2IlInjected.Address(RVA = "0x399EAC", Offset = "0x399EAC", VA = "0x399EAC")]
		public void RestoreFade(TransactionButton_Layout layout)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400087C")]
	private DateTime lastShown;

	[Cpp2IlInjected.Token(Token = "0x400087D")]
	private static ColorFadeBackup fadeSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400087E")]
	private float iconScale;

	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0x1372CE8", Offset = "0x1372CE8", VA = "0x1372CE8")]
	public GUIJourneySliderSetting(GUISettingID id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A11")]
	[Cpp2IlInjected.Address(RVA = "0x1374DBC", Offset = "0x1374DBC", VA = "0x1374DBC")]
	public void WindBackingHandler(Vector2 position, Vector2 size, Slider_Layout layout, bool controllerOver)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A12")]
	[Cpp2IlInjected.Address(RVA = "0x1375A90", Offset = "0x1375A90", VA = "0x1375A90")]
	public void RainBackingHandler(Vector2 position, Vector2 size, Slider_Layout layout, bool controllerOver)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A13")]
	[Cpp2IlInjected.Address(RVA = "0x1376724", Offset = "0x1376724", VA = "0x1376724")]
	public void DifficultyBackingHandler(Vector2 position, Vector2 size, Slider_Layout layout, bool controllerOver)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x1377738", Offset = "0x1377738", VA = "0x1377738", Slot = "4")]
	public override void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x13778A4", Offset = "0x13778A4", VA = "0x13778A4", Slot = "7")]
	protected override SettingsOverlaySlider_Layout GetLayout()
	{
		return null;
	}
}
