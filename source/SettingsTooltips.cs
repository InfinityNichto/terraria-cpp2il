using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001F9 RID: 505
[global::Cpp2ILInjected.Token(Token = "0x200029E")]
[Serializable]
public class SettingsTooltips
{
	// Token: 0x06000E84 RID: 3716 RVA: 0x000246D1 File Offset: 0x000228D1
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

	// Token: 0x04001738 RID: 5944
	[global::Cpp2ILInjected.Token(Token = "0x4001C5F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Vector2 DrawOffset;

	// Token: 0x04001739 RID: 5945
	[global::Cpp2ILInjected.Token(Token = "0x4001C60")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float Scale;

	// Token: 0x0400173A RID: 5946
	[global::Cpp2ILInjected.Token(Token = "0x4001C61")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public Vector2 Distance;

	// Token: 0x0400173B RID: 5947
	[global::Cpp2ILInjected.Token(Token = "0x4001C62")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout Backing;

	// Token: 0x0400173C RID: 5948
	[global::Cpp2ILInjected.Token(Token = "0x4001C63")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Vector2 TouchOpenButtonTooltipOffset;

	// Token: 0x0400173D RID: 5949
	[global::Cpp2ILInjected.Token(Token = "0x4001C64")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout TouchOpenButtonTooltip;

	// Token: 0x0400173E RID: 5950
	[global::Cpp2ILInjected.Token(Token = "0x4001C65")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Vector2 TouchInteractButtonTooltipOffset;

	// Token: 0x0400173F RID: 5951
	[global::Cpp2ILInjected.Token(Token = "0x4001C66")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout TouchInteractButtonTooltip;

	// Token: 0x04001740 RID: 5952
	[global::Cpp2ILInjected.Token(Token = "0x4001C67")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Vector2 TouchTeleportButtonTooltipOffset;

	// Token: 0x04001741 RID: 5953
	[global::Cpp2ILInjected.Token(Token = "0x4001C68")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout TouchFireButtonTooltip;

	// Token: 0x04001742 RID: 5954
	[global::Cpp2ILInjected.Token(Token = "0x4001C69")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Vector2 TouchFireButtonTooltipOffset;

	// Token: 0x04001743 RID: 5955
	[global::Cpp2ILInjected.Token(Token = "0x4001C6A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout TouchTeleportButtonTooltip;

	// Token: 0x04001744 RID: 5956
	[global::Cpp2ILInjected.Token(Token = "0x4001C6B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Vector2 TouchWiringButtonTooltipOffset;

	// Token: 0x04001745 RID: 5957
	[global::Cpp2ILInjected.Token(Token = "0x4001C6C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout TouchWiringButtonTooltip;

	// Token: 0x04001746 RID: 5958
	[global::Cpp2ILInjected.Token(Token = "0x4001C6D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Vector2 TouchHousingButtonTooltipOffset;

	// Token: 0x04001747 RID: 5959
	[global::Cpp2ILInjected.Token(Token = "0x4001C6E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout TouchHousingButtonTooltip;

	// Token: 0x04001748 RID: 5960
	[global::Cpp2ILInjected.Token(Token = "0x4001C6F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Vector2 TouchCraftingButtonTooltipOffset;

	// Token: 0x04001749 RID: 5961
	[global::Cpp2ILInjected.Token(Token = "0x4001C70")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout TouchCraftingButtonTooltip;

	// Token: 0x0400174A RID: 5962
	[global::Cpp2ILInjected.Token(Token = "0x4001C71")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Vector2 TouchJumpButtonTooltipOffset;

	// Token: 0x0400174B RID: 5963
	[global::Cpp2ILInjected.Token(Token = "0x4001C72")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public TransactionButton_Layout TouchJumpButtonTooltip;

	// Token: 0x0400174C RID: 5964
	[global::Cpp2ILInjected.Token(Token = "0x4001C73")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Vector2 TouchQuickActionButtonTooltipOffset;

	// Token: 0x0400174D RID: 5965
	[global::Cpp2ILInjected.Token(Token = "0x4001C74")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public TransactionButton_Layout TouchQuickActionButtonTooltip;

	// Token: 0x0400174E RID: 5966
	[global::Cpp2ILInjected.Token(Token = "0x4001C75")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Vector2 TouchCloseButtonTooltipOffset;

	// Token: 0x0400174F RID: 5967
	[global::Cpp2ILInjected.Token(Token = "0x4001C76")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public TransactionButton_Layout TouchCloseButtonTooltip;

	// Token: 0x04001750 RID: 5968
	[global::Cpp2ILInjected.Token(Token = "0x4001C77")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Vector2 TouchInventoryButtonTooltipOffset;

	// Token: 0x04001751 RID: 5969
	[global::Cpp2ILInjected.Token(Token = "0x4001C78")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public TransactionButton_Layout TouchInventoryButtonTooltip;

	// Token: 0x04001752 RID: 5970
	[global::Cpp2ILInjected.Token(Token = "0x4001C79")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Vector2 TouchPauseButtonTooltipOffset;

	// Token: 0x04001753 RID: 5971
	[global::Cpp2ILInjected.Token(Token = "0x4001C7A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public TransactionButton_Layout TouchPauseButtonTooltip;

	// Token: 0x04001754 RID: 5972
	[global::Cpp2ILInjected.Token(Token = "0x4001C7B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public Vector2 TouchEquipButtonTooltipOffset;

	// Token: 0x04001755 RID: 5973
	[global::Cpp2ILInjected.Token(Token = "0x4001C7C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public TransactionButton_Layout TouchEquipButtonTooltip;

	// Token: 0x04001756 RID: 5974
	[global::Cpp2ILInjected.Token(Token = "0x4001C7D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public Vector2 TouchAxisTooltipOffset;

	// Token: 0x04001757 RID: 5975
	[global::Cpp2ILInjected.Token(Token = "0x4001C7E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public Axis_Layout TouchAxisTooltip;

	// Token: 0x04001758 RID: 5976
	[global::Cpp2ILInjected.Token(Token = "0x4001C7F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public Color KeyboardBindingColour;
}
