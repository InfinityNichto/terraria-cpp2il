using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameInput;

[Cpp2IlInjected.Token(Token = "0x20004B8")]
public class PlayerInputProfile
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006604")]
	public Dictionary<InputMode, KeyConfiguration> InputModes;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006605")]
	public string Name;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006606")]
	public bool AllowEditting;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006607")]
	public int HotbarRadialHoldTimeRequired;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006608")]
	public float TriggersDeadzone;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006609")]
	public float InterfaceDeadzoneX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400660A")]
	public float LeftThumbstickDeadzoneX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400660B")]
	public float LeftThumbstickDeadzoneY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400660C")]
	public float RightThumbstickDeadzoneX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400660D")]
	public float RightThumbstickDeadzoneY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400660E")]
	public bool LeftThumbstickInvertX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x400660F")]
	public bool LeftThumbstickInvertY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x4006610")]
	public bool RightThumbstickInvertX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x33")]
	[Cpp2IlInjected.Token(Token = "0x4006611")]
	public bool RightThumbstickInvertY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4006612")]
	public int InventoryMoveCD;

	[Cpp2IlInjected.Token(Token = "0x17000686")]
	public string ShowName
	{
		[Cpp2IlInjected.Token(Token = "0x60034BB")]
		[Cpp2IlInjected.Address(RVA = "0x13060BC", Offset = "0x13060BC", VA = "0x13060BC")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000687")]
	public bool HotbarAllowsRadial
	{
		[Cpp2IlInjected.Token(Token = "0x60034BC")]
		[Cpp2IlInjected.Address(RVA = "0x13060C4", Offset = "0x13060C4", VA = "0x13060C4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60034BD")]
	[Cpp2IlInjected.Address(RVA = "0x13060D8", Offset = "0x13060D8", VA = "0x13060D8")]
	public PlayerInputProfile(string name)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034BE")]
	[Cpp2IlInjected.Address(RVA = "0x1306274", Offset = "0x1306274", VA = "0x1306274")]
	public void Initialize(PresetProfiles style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034BF")]
	[Cpp2IlInjected.Address(RVA = "0x13063E0", Offset = "0x13063E0", VA = "0x13063E0")]
	public void CopyGameplaySettingsFrom(PlayerInputProfile profile, InputMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034C0")]
	[Cpp2IlInjected.Address(RVA = "0x13065CC", Offset = "0x13065CC", VA = "0x13065CC")]
	public void CopyHotbarSettingsFrom(PlayerInputProfile profile, InputMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034C1")]
	[Cpp2IlInjected.Address(RVA = "0x130666C", Offset = "0x130666C", VA = "0x130666C")]
	public void CopyMapSettingsFrom(PlayerInputProfile profile, InputMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034C2")]
	[Cpp2IlInjected.Address(RVA = "0x130670C", Offset = "0x130670C", VA = "0x130670C")]
	public void CopyGamepadSettingsFrom(PlayerInputProfile profile, InputMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034C3")]
	[Cpp2IlInjected.Address(RVA = "0x13067BC", Offset = "0x13067BC", VA = "0x13067BC")]
	public void CopyGamepadAdvancedSettingsFrom(PlayerInputProfile profile, InputMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034C4")]
	[Cpp2IlInjected.Address(RVA = "0x1306480", Offset = "0x1306480", VA = "0x1306480")]
	private void CopyKeysFrom(PlayerInputProfile profile, InputMode mode, TriggerNames[] keysToCopy)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034C5")]
	[Cpp2IlInjected.Address(RVA = "0x1306818", Offset = "0x1306818", VA = "0x1306818")]
	public bool UsingDpadHotbar()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60034C6")]
	[Cpp2IlInjected.Address(RVA = "0x1306D20", Offset = "0x1306D20", VA = "0x1306D20")]
	public bool UsingDpadMovekeys()
	{
		return default(bool);
	}
}
