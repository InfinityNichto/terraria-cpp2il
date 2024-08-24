using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using NaughtyAttributes;
using Newtonsoft.Json;

// Token: 0x02000139 RID: 313
[JsonObject(MemberSerialization.Fields)]
[global::Cpp2ILInjected.Token(Token = "0x20001B7")]
[Serializable]
public class QuickActionButton_Layout : Button_Layout
{
	// Token: 0x06000AB4 RID: 2740 RVA: 0x00023B61 File Offset: 0x00021D61
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

	// Token: 0x04000AA8 RID: 2728
	[BoxGroup("Disabled", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E71")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x39")]
	public Color DisabledColour;

	// Token: 0x04000AA9 RID: 2729
	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E72")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D")]
	public Color PressedColour;

	// Token: 0x04000AAA RID: 2730
	[ShowIf("DrawIcon")]
	[BoxGroup("Normal", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E73")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
	public Color IconColour;

	// Token: 0x04000AAB RID: 2731
	[BoxGroup("Disabled", -1, null, null)]
	[ShowIf("DrawIcon")]
	[global::Cpp2ILInjected.Token(Token = "0x4000E74")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x45")]
	public Color DisabledIconColour;

	// Token: 0x04000AAC RID: 2732
	[BoxGroup("Pressed", -1, null, null)]
	[ShowIf("DrawIcon")]
	[global::Cpp2ILInjected.Token(Token = "0x4000E75")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
	public Color PressedIconColour;

	// Token: 0x04000AAD RID: 2733
	[BoxGroup("Highlight", -1, "Style", null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E76")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4D")]
	public Color LabelHighlightTint;

	// Token: 0x04000AAE RID: 2734
	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E77")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public float ScaleSpeed;

	// Token: 0x04000AAF RID: 2735
	[BoxGroup("Disabled", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E78")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public float DisabledScale;

	// Token: 0x04000AB0 RID: 2736
	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E79")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public float PressedScale;

	// Token: 0x04000AB1 RID: 2737
	[BoxGroup("Icon", -1, null, null)]
	[ShowIf("DrawIcon")]
	[global::Cpp2ILInjected.Token(Token = "0x4000E7A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public int IconMaxSizeInset;

	// Token: 0x04000AB2 RID: 2738
	[BoxGroup("Disabled", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E7B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Texture_Layout BackingDisabled;

	// Token: 0x04000AB3 RID: 2739
	[BoxGroup("Normal", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E7C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Texture_Layout BackingNormal;

	// Token: 0x04000AB4 RID: 2740
	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E7D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Texture_Layout BackingPressed;

	// Token: 0x04000AB5 RID: 2741
	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E7E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Texture_Layout BackingPressedHighlight;

	// Token: 0x04000AB6 RID: 2742
	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E7F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Color BackingPressedHighlightColour;

	// Token: 0x04000AB7 RID: 2743
	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000E80")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Texture_Layout OverBackingHighlight;

	// Token: 0x020007DF RID: 2015
	[global::Cpp2ILInjected.Token(Token = "0x20001B8")]
	public enum QuickActionControl
	{
		// Token: 0x04007B94 RID: 31636
		[global::Cpp2ILInjected.Token(Token = "0x4000E82")]
		Heal,
		// Token: 0x04007B95 RID: 31637
		[global::Cpp2ILInjected.Token(Token = "0x4000E83")]
		Mana,
		// Token: 0x04007B96 RID: 31638
		[global::Cpp2ILInjected.Token(Token = "0x4000E84")]
		Mount,
		// Token: 0x04007B97 RID: 31639
		[global::Cpp2ILInjected.Token(Token = "0x4000E85")]
		Buff,
		// Token: 0x04007B98 RID: 31640
		[global::Cpp2ILInjected.Token(Token = "0x4000E86")]
		Grapple,
		// Token: 0x04007B99 RID: 31641
		[global::Cpp2ILInjected.Token(Token = "0x4000E87")]
		Jump,
		// Token: 0x04007B9A RID: 31642
		[global::Cpp2ILInjected.Token(Token = "0x4000E88")]
		Fire,
		// Token: 0x04007B9B RID: 31643
		[global::Cpp2ILInjected.Token(Token = "0x4000E89")]
		SmartCursor,
		// Token: 0x04007B9C RID: 31644
		[global::Cpp2ILInjected.Token(Token = "0x4000E8A")]
		AutoFire,
		// Token: 0x04007B9D RID: 31645
		[global::Cpp2ILInjected.Token(Token = "0x4000E8B")]
		ZoomIn,
		// Token: 0x04007B9E RID: 31646
		[global::Cpp2ILInjected.Token(Token = "0x4000E8C")]
		ZoomOut,
		// Token: 0x04007B9F RID: 31647
		[global::Cpp2ILInjected.Token(Token = "0x4000E8D")]
		ZoomDefault,
		// Token: 0x04007BA0 RID: 31648
		[global::Cpp2ILInjected.Token(Token = "0x4000E8E")]
		MapZoomIn,
		// Token: 0x04007BA1 RID: 31649
		[global::Cpp2ILInjected.Token(Token = "0x4000E8F")]
		MapZoomOut,
		// Token: 0x04007BA2 RID: 31650
		[global::Cpp2ILInjected.Token(Token = "0x4000E90")]
		MapZoomDefault,
		// Token: 0x04007BA3 RID: 31651
		[global::Cpp2ILInjected.Token(Token = "0x4000E91")]
		MinimapZoomIn,
		// Token: 0x04007BA4 RID: 31652
		[global::Cpp2ILInjected.Token(Token = "0x4000E92")]
		MinimapZoomOut,
		// Token: 0x04007BA5 RID: 31653
		[global::Cpp2ILInjected.Token(Token = "0x4000E93")]
		MinimapZoomDefault,
		// Token: 0x04007BA6 RID: 31654
		[global::Cpp2ILInjected.Token(Token = "0x4000E94")]
		Interact,
		// Token: 0x04007BA7 RID: 31655
		[global::Cpp2ILInjected.Token(Token = "0x4000E95")]
		Inventory,
		// Token: 0x04007BA8 RID: 31656
		[global::Cpp2ILInjected.Token(Token = "0x4000E96")]
		Reforge,
		// Token: 0x04007BA9 RID: 31657
		[global::Cpp2ILInjected.Token(Token = "0x4000E97")]
		AutoSelect,
		// Token: 0x04007BAA RID: 31658
		[global::Cpp2ILInjected.Token(Token = "0x4000E98")]
		GrappleFire,
		// Token: 0x04007BAB RID: 31659
		[global::Cpp2ILInjected.Token(Token = "0x4000E99")]
		Map,
		// Token: 0x04007BAC RID: 31660
		[global::Cpp2ILInjected.Token(Token = "0x4000E9A")]
		TargetLockOn,
		// Token: 0x04007BAD RID: 31661
		[global::Cpp2ILInjected.Token(Token = "0x4000E9B")]
		ProfileSwitch,
		// Token: 0x04007BAE RID: 31662
		[global::Cpp2ILInjected.Token(Token = "0x4000E9C")]
		Settings,
		// Token: 0x04007BAF RID: 31663
		[global::Cpp2ILInjected.Token(Token = "0x4000E9D")]
		Loadout1,
		// Token: 0x04007BB0 RID: 31664
		[global::Cpp2ILInjected.Token(Token = "0x4000E9E")]
		Loadout2,
		// Token: 0x04007BB1 RID: 31665
		[global::Cpp2ILInjected.Token(Token = "0x4000E9F")]
		Loadout3,
		// Token: 0x04007BB2 RID: 31666
		[global::Cpp2ILInjected.Token(Token = "0x4000EA0")]
		LoadoutCycle,
		// Token: 0x04007BB3 RID: 31667
		[global::Cpp2ILInjected.Token(Token = "0x4000EA1")]
		Unbound
	}
}
