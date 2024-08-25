using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x200029E")]
[Serializable]
public class SettingsTooltips
{
	[global::Cpp2ILInjected.Token(Token = "0x6000FB4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA39930", Offset = "0xA39930", Length = "0x240")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public SettingsTooltips()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001C5F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Vector2 DrawOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001C60")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float Scale;

	[global::Cpp2ILInjected.Token(Token = "0x4001C61")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public Vector2 Distance;

	[global::Cpp2ILInjected.Token(Token = "0x4001C62")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4001C63")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Vector2 TouchOpenButtonTooltipOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001C64")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout TouchOpenButtonTooltip;

	[global::Cpp2ILInjected.Token(Token = "0x4001C65")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Vector2 TouchInteractButtonTooltipOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001C66")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout TouchInteractButtonTooltip;

	[global::Cpp2ILInjected.Token(Token = "0x4001C67")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Vector2 TouchTeleportButtonTooltipOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001C68")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout TouchFireButtonTooltip;

	[global::Cpp2ILInjected.Token(Token = "0x4001C69")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Vector2 TouchFireButtonTooltipOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001C6A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout TouchTeleportButtonTooltip;

	[global::Cpp2ILInjected.Token(Token = "0x4001C6B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Vector2 TouchWiringButtonTooltipOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001C6C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout TouchWiringButtonTooltip;

	[global::Cpp2ILInjected.Token(Token = "0x4001C6D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Vector2 TouchHousingButtonTooltipOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001C6E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout TouchHousingButtonTooltip;

	[global::Cpp2ILInjected.Token(Token = "0x4001C6F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Vector2 TouchCraftingButtonTooltipOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001C70")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout TouchCraftingButtonTooltip;

	[global::Cpp2ILInjected.Token(Token = "0x4001C71")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Vector2 TouchJumpButtonTooltipOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001C72")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public TransactionButton_Layout TouchJumpButtonTooltip;

	[global::Cpp2ILInjected.Token(Token = "0x4001C73")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Vector2 TouchQuickActionButtonTooltipOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001C74")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public TransactionButton_Layout TouchQuickActionButtonTooltip;

	[global::Cpp2ILInjected.Token(Token = "0x4001C75")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Vector2 TouchCloseButtonTooltipOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001C76")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public TransactionButton_Layout TouchCloseButtonTooltip;

	[global::Cpp2ILInjected.Token(Token = "0x4001C77")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Vector2 TouchInventoryButtonTooltipOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001C78")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public TransactionButton_Layout TouchInventoryButtonTooltip;

	[global::Cpp2ILInjected.Token(Token = "0x4001C79")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Vector2 TouchPauseButtonTooltipOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001C7A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public TransactionButton_Layout TouchPauseButtonTooltip;

	[global::Cpp2ILInjected.Token(Token = "0x4001C7B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public Vector2 TouchEquipButtonTooltipOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001C7C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public TransactionButton_Layout TouchEquipButtonTooltip;

	[global::Cpp2ILInjected.Token(Token = "0x4001C7D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public Vector2 TouchAxisTooltipOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001C7E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public Axis_Layout TouchAxisTooltip;

	[global::Cpp2ILInjected.Token(Token = "0x4001C7F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public Color KeyboardBindingColour;
}
