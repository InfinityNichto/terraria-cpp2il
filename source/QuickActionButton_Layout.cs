using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200013A")]
[JsonObject]
public class QuickActionButton_Layout : Button_Layout
{
	[Cpp2IlInjected.Token(Token = "0x20007D6")]
	public enum QuickActionControl
	{
		[Cpp2IlInjected.Token(Token = "0x4007B81")]
		Heal,
		[Cpp2IlInjected.Token(Token = "0x4007B82")]
		Mana,
		[Cpp2IlInjected.Token(Token = "0x4007B83")]
		Mount,
		[Cpp2IlInjected.Token(Token = "0x4007B84")]
		Buff,
		[Cpp2IlInjected.Token(Token = "0x4007B85")]
		Grapple,
		[Cpp2IlInjected.Token(Token = "0x4007B86")]
		Jump,
		[Cpp2IlInjected.Token(Token = "0x4007B87")]
		Fire,
		[Cpp2IlInjected.Token(Token = "0x4007B88")]
		SmartCursor,
		[Cpp2IlInjected.Token(Token = "0x4007B89")]
		AutoFire,
		[Cpp2IlInjected.Token(Token = "0x4007B8A")]
		ZoomIn,
		[Cpp2IlInjected.Token(Token = "0x4007B8B")]
		ZoomOut,
		[Cpp2IlInjected.Token(Token = "0x4007B8C")]
		ZoomDefault,
		[Cpp2IlInjected.Token(Token = "0x4007B8D")]
		MapZoomIn,
		[Cpp2IlInjected.Token(Token = "0x4007B8E")]
		MapZoomOut,
		[Cpp2IlInjected.Token(Token = "0x4007B8F")]
		MapZoomDefault,
		[Cpp2IlInjected.Token(Token = "0x4007B90")]
		MinimapZoomIn,
		[Cpp2IlInjected.Token(Token = "0x4007B91")]
		MinimapZoomOut,
		[Cpp2IlInjected.Token(Token = "0x4007B92")]
		MinimapZoomDefault,
		[Cpp2IlInjected.Token(Token = "0x4007B93")]
		Interact,
		[Cpp2IlInjected.Token(Token = "0x4007B94")]
		Inventory,
		[Cpp2IlInjected.Token(Token = "0x4007B95")]
		Reforge,
		[Cpp2IlInjected.Token(Token = "0x4007B96")]
		AutoSelect,
		[Cpp2IlInjected.Token(Token = "0x4007B97")]
		GrappleFire,
		[Cpp2IlInjected.Token(Token = "0x4007B98")]
		Map,
		[Cpp2IlInjected.Token(Token = "0x4007B99")]
		TargetLockOn,
		[Cpp2IlInjected.Token(Token = "0x4007B9A")]
		ProfileSwitch,
		[Cpp2IlInjected.Token(Token = "0x4007B9B")]
		Settings,
		[Cpp2IlInjected.Token(Token = "0x4007B9C")]
		Loadout1,
		[Cpp2IlInjected.Token(Token = "0x4007B9D")]
		Loadout2,
		[Cpp2IlInjected.Token(Token = "0x4007B9E")]
		Loadout3,
		[Cpp2IlInjected.Token(Token = "0x4007B9F")]
		LoadoutCycle,
		[Cpp2IlInjected.Token(Token = "0x4007BA0")]
		Unbound
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x4000AB1")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x386640", Offset = "0x386640")]
	public Color DisabledColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000AB2")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x38668C", Offset = "0x38668C")]
	public Color PressedColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x4000AB3")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3866D8", Offset = "0x3866D8")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x3866D8", Offset = "0x3866D8")]
	public Color IconColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
	[Cpp2IlInjected.Token(Token = "0x4000AB4")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x386750", Offset = "0x386750")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x386750", Offset = "0x386750")]
	public Color DisabledIconColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000AB5")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3867C8", Offset = "0x3867C8")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x3867C8", Offset = "0x3867C8")]
	public Color PressedIconColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000AB6")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x386840", Offset = "0x386840")]
	public Color LabelHighlightTint;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000AB7")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3868A0", Offset = "0x3868A0")]
	public float ScaleSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000AB8")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3868EC", Offset = "0x3868EC")]
	public float DisabledScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000AB9")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x386938", Offset = "0x386938")]
	public float PressedScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000ABA")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x386984", Offset = "0x386984")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x386984", Offset = "0x386984")]
	public int IconMaxSizeInset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000ABB")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3869FC", Offset = "0x3869FC")]
	public Texture_Layout BackingDisabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000ABC")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x386A48", Offset = "0x386A48")]
	public Texture_Layout BackingNormal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000ABD")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x386A94", Offset = "0x386A94")]
	public Texture_Layout BackingPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000ABE")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x386AE0", Offset = "0x386AE0")]
	public Texture_Layout BackingPressedHighlight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000ABF")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x386B2C", Offset = "0x386B2C")]
	public Color BackingPressedHighlightColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000AC0")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x386B78", Offset = "0x386B78")]
	public Texture_Layout OverBackingHighlight;

	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x10BD008", Offset = "0x10BD008", VA = "0x10BD008")]
	public QuickActionButton_Layout()
	{
	}
}
