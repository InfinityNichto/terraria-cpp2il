using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000115 RID: 277
[global::Cpp2ILInjected.Token(Token = "0x200018D")]
public class Achievements_Layout : LayoutDefinition
{
	// Token: 0x06000A3A RID: 2618 RVA: 0x000239F3 File Offset: 0x00021BF3
	[global::Cpp2ILInjected.Token(Token = "0x6000B47")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AB788", Offset = "0x9AB788", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000A3B RID: 2619 RVA: 0x000239F6 File Offset: 0x00021BF6
	[global::Cpp2ILInjected.Token(Token = "0x6000B48")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AB7D4", Offset = "0x9AB7D4", Length = "0xB4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Achievements_Layout()
	{
		throw null;
	}

	// Token: 0x040008D4 RID: 2260
	[global::Cpp2ILInjected.Token(Token = "0x4000BF6")]
	public static Achievements_Layout Instance;

	// Token: 0x040008D5 RID: 2261
	[global::Cpp2ILInjected.Token(Token = "0x4000BF7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	// Token: 0x040008D6 RID: 2262
	[global::Cpp2ILInjected.Token(Token = "0x4000BF8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public DraggableItemGrid_Layout AchievementsGrid;

	// Token: 0x040008D7 RID: 2263
	[global::Cpp2ILInjected.Token(Token = "0x4000BF9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Title;

	// Token: 0x040008D8 RID: 2264
	[global::Cpp2ILInjected.Token(Token = "0x4000BFA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout MenuDivider;

	// Token: 0x040008D9 RID: 2265
	[global::Cpp2ILInjected.Token(Token = "0x4000BFB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout MenuDivider2;

	// Token: 0x040008DA RID: 2266
	[global::Cpp2ILInjected.Token(Token = "0x4000BFC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Back;

	// Token: 0x040008DB RID: 2267
	[global::Cpp2ILInjected.Token(Token = "0x4000BFD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Panel_Layout ItemBacking;

	// Token: 0x040008DC RID: 2268
	[global::Cpp2ILInjected.Token(Token = "0x4000BFE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x040008DD RID: 2269
	[global::Cpp2ILInjected.Token(Token = "0x4000BFF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Button_Layout ItemDivider;

	// Token: 0x040008DE RID: 2270
	[global::Cpp2ILInjected.Token(Token = "0x4000C00")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public String_Layout ItemName;

	// Token: 0x040008DF RID: 2271
	[global::Cpp2ILInjected.Token(Token = "0x4000C01")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public String_Layout ItemNameCompleted;

	// Token: 0x040008E0 RID: 2272
	[global::Cpp2ILInjected.Token(Token = "0x4000C02")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Panel_Layout ItemNameDivider;

	// Token: 0x040008E1 RID: 2273
	[global::Cpp2ILInjected.Token(Token = "0x4000C03")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public String_Layout ItemDescription;

	// Token: 0x040008E2 RID: 2274
	[global::Cpp2ILInjected.Token(Token = "0x4000C04")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public int ItemDescWidth;

	// Token: 0x040008E3 RID: 2275
	[global::Cpp2ILInjected.Token(Token = "0x4000C05")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public AchievementIcon ItemIcon;

	// Token: 0x040008E4 RID: 2276
	[global::Cpp2ILInjected.Token(Token = "0x4000C06")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Vector2 ItemCatIconsPosition;

	// Token: 0x040008E5 RID: 2277
	[global::Cpp2ILInjected.Token(Token = "0x4000C07")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public float ItemCatIconsScale;

	// Token: 0x040008E6 RID: 2278
	[global::Cpp2ILInjected.Token(Token = "0x4000C08")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public String_Layout ProgressNumbers;

	// Token: 0x040008E7 RID: 2279
	[global::Cpp2ILInjected.Token(Token = "0x4000C09")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public ProgressBar_Layout ProgressBar;

	// Token: 0x040008E8 RID: 2280
	[global::Cpp2ILInjected.Token(Token = "0x4000C0A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Panel_Layout ItemInnerPanelTop;

	// Token: 0x040008E9 RID: 2281
	[global::Cpp2ILInjected.Token(Token = "0x4000C0B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Panel_Layout ItemSelectedInnerPanelTop;

	// Token: 0x040008EA RID: 2282
	[global::Cpp2ILInjected.Token(Token = "0x4000C0C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Panel_Layout ItemInnerPanelBottom;

	// Token: 0x040008EB RID: 2283
	[global::Cpp2ILInjected.Token(Token = "0x4000C0D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Panel_Layout ItemSelectedInnerPanelBottom;

	// Token: 0x040008EC RID: 2284
	[global::Cpp2ILInjected.Token(Token = "0x4000C0E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Panel_Layout CategoryDivider;

	// Token: 0x040008ED RID: 2285
	[global::Cpp2ILInjected.Token(Token = "0x4000C0F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Vector2 InGameWindowShift;

	// Token: 0x040008EE RID: 2286
	[global::Cpp2ILInjected.Token(Token = "0x4000C10")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public TransactionButton_Layout Filters;

	// Token: 0x040008EF RID: 2287
	[global::Cpp2ILInjected.Token(Token = "0x4000C11")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Panel_Layout FiltersBacking;

	// Token: 0x040008F0 RID: 2288
	[global::Cpp2ILInjected.Token(Token = "0x4000C12")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public TransactionButton_Layout Slayer;

	// Token: 0x040008F1 RID: 2289
	[global::Cpp2ILInjected.Token(Token = "0x4000C13")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public TransactionButton_Layout Collector;

	// Token: 0x040008F2 RID: 2290
	[global::Cpp2ILInjected.Token(Token = "0x4000C14")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public TransactionButton_Layout Explorer;

	// Token: 0x040008F3 RID: 2291
	[global::Cpp2ILInjected.Token(Token = "0x4000C15")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public TransactionButton_Layout Challenger;
}
