using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using NaughtyAttributes;
using Newtonsoft.Json;

[JsonObject(MemberSerialization.Fields)]
[global::Cpp2ILInjected.Token(Token = "0x20001B7")]
[Serializable]
public class QuickActionButton_Layout : Button_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000BC3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B2DE4", Offset = "0x9B2DE4", Length = "0x1E0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TransactionButton_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Button_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public QuickActionButton_Layout()
	{
		throw null;
	}

	[BoxGroup("Disabled", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E71")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x39")]
	public Color DisabledColour;

	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E72")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D")]
	public Color PressedColour;

	[ShowIf("DrawIcon")]
	[BoxGroup("Normal", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E73")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
	public Color IconColour;

	[BoxGroup("Disabled", -1, null, null)]
	[ShowIf("DrawIcon")]
	[global::Cpp2ILInjected.Token(Token = "0x4000E74")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x45")]
	public Color DisabledIconColour;

	[BoxGroup("Pressed", -1, null, null)]
	[ShowIf("DrawIcon")]
	[global::Cpp2ILInjected.Token(Token = "0x4000E75")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
	public Color PressedIconColour;

	[BoxGroup("Highlight", -1, "Style", null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E76")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4D")]
	public Color LabelHighlightTint;

	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E77")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public float ScaleSpeed;

	[BoxGroup("Disabled", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E78")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public float DisabledScale;

	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E79")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public float PressedScale;

	[BoxGroup("Icon", -1, null, null)]
	[ShowIf("DrawIcon")]
	[global::Cpp2ILInjected.Token(Token = "0x4000E7A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public int IconMaxSizeInset;

	[BoxGroup("Disabled", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E7B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Texture_Layout BackingDisabled;

	[BoxGroup("Normal", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E7C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Texture_Layout BackingNormal;

	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E7D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Texture_Layout BackingPressed;

	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E7E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Texture_Layout BackingPressedHighlight;

	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E7F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Color BackingPressedHighlightColour;

	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E80")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Texture_Layout OverBackingHighlight;

	[global::Cpp2ILInjected.Token(Token = "0x20001B8")]
	public enum QuickActionControl
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000E82")]
		Heal,
		[global::Cpp2ILInjected.Token(Token = "0x4000E83")]
		Mana,
		[global::Cpp2ILInjected.Token(Token = "0x4000E84")]
		Mount,
		[global::Cpp2ILInjected.Token(Token = "0x4000E85")]
		Buff,
		[global::Cpp2ILInjected.Token(Token = "0x4000E86")]
		Grapple,
		[global::Cpp2ILInjected.Token(Token = "0x4000E87")]
		Jump,
		[global::Cpp2ILInjected.Token(Token = "0x4000E88")]
		Fire,
		[global::Cpp2ILInjected.Token(Token = "0x4000E89")]
		SmartCursor,
		[global::Cpp2ILInjected.Token(Token = "0x4000E8A")]
		AutoFire,
		[global::Cpp2ILInjected.Token(Token = "0x4000E8B")]
		ZoomIn,
		[global::Cpp2ILInjected.Token(Token = "0x4000E8C")]
		ZoomOut,
		[global::Cpp2ILInjected.Token(Token = "0x4000E8D")]
		ZoomDefault,
		[global::Cpp2ILInjected.Token(Token = "0x4000E8E")]
		MapZoomIn,
		[global::Cpp2ILInjected.Token(Token = "0x4000E8F")]
		MapZoomOut,
		[global::Cpp2ILInjected.Token(Token = "0x4000E90")]
		MapZoomDefault,
		[global::Cpp2ILInjected.Token(Token = "0x4000E91")]
		MinimapZoomIn,
		[global::Cpp2ILInjected.Token(Token = "0x4000E92")]
		MinimapZoomOut,
		[global::Cpp2ILInjected.Token(Token = "0x4000E93")]
		MinimapZoomDefault,
		[global::Cpp2ILInjected.Token(Token = "0x4000E94")]
		Interact,
		[global::Cpp2ILInjected.Token(Token = "0x4000E95")]
		Inventory,
		[global::Cpp2ILInjected.Token(Token = "0x4000E96")]
		Reforge,
		[global::Cpp2ILInjected.Token(Token = "0x4000E97")]
		AutoSelect,
		[global::Cpp2ILInjected.Token(Token = "0x4000E98")]
		GrappleFire,
		[global::Cpp2ILInjected.Token(Token = "0x4000E99")]
		Map,
		[global::Cpp2ILInjected.Token(Token = "0x4000E9A")]
		TargetLockOn,
		[global::Cpp2ILInjected.Token(Token = "0x4000E9B")]
		ProfileSwitch,
		[global::Cpp2ILInjected.Token(Token = "0x4000E9C")]
		Settings,
		[global::Cpp2ILInjected.Token(Token = "0x4000E9D")]
		Loadout1,
		[global::Cpp2ILInjected.Token(Token = "0x4000E9E")]
		Loadout2,
		[global::Cpp2ILInjected.Token(Token = "0x4000E9F")]
		Loadout3,
		[global::Cpp2ILInjected.Token(Token = "0x4000EA0")]
		LoadoutCycle,
		[global::Cpp2ILInjected.Token(Token = "0x4000EA1")]
		Unbound
	}
}
