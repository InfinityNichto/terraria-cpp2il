using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20001F9")]
public class Settings : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4001739")]
	public static Settings Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400173A")]
	public SettingsTooltips Tooltips;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400173B")]
	public int BannerTooltipItemWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400173C")]
	public float DeselectedPageFade;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400173D")]
	public AnimationCurve SliderSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400173E")]
	public AnimationCurve AimCursorSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400173F")]
	public float MouseScrollSensitivity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001740")]
	public float GridScrollSpeed;

	[Cpp2IlInjected.Token(Token = "0x6000E95")]
	[Cpp2IlInjected.Address(RVA = "0xFA777C", Offset = "0xFA777C", VA = "0xFA777C")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E96")]
	[Cpp2IlInjected.Address(RVA = "0xFA77D8", Offset = "0xFA77D8", VA = "0xFA77D8")]
	public Settings()
	{
	}
}
