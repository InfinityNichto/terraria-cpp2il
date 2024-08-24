using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x020000A5 RID: 165
[global::Cpp2ILInjected.Token(Token = "0x20000E0")]
public class GUIPageContentController : GUIControllerItem
{
	// Token: 0x06000532 RID: 1330 RVA: 0x00022ADB File Offset: 0x00020CDB
	[global::Cpp2ILInjected.Token(Token = "0x60005CC")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1991C", Offset = "0xB1991C", Length = "0x2C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerAmmo), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerAmmo4Page), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChest), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChest4Page), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCoins), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCoins4Page), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting4Page), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuide), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuide4Page), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDisplayDoll), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDisplayDoll4Page), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDresser), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	protected GUIPageContentController(GUIPageIcons.Category pageCategory)
	{
		throw null;
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x00022ADE File Offset: 0x00020CDE
	[global::Cpp2ILInjected.Token(Token = "0x60005CD")]
	[global::Cpp2ILInjected.Address(RVA = "0xB23888", Offset = "0xB23888", Length = "0x2C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	protected GUIPageContentController(GUIPageIconGrouping.SettingCategory settingCategory)
	{
		throw null;
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x00022AE1 File Offset: 0x00020CE1
	[global::Cpp2ILInjected.Token(Token = "0x60005CE")]
	[global::Cpp2ILInjected.Address(RVA = "0xB238B4", Offset = "0xB238B4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x00022AE4 File Offset: 0x00020CE4
	[global::Cpp2ILInjected.Token(Token = "0x60005CF")]
	[global::Cpp2ILInjected.Address(RVA = "0xB238BC", Offset = "0xB238BC", Length = "0x3C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "get_ParentGrouping", ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_MenuController", ReturnType = typeof(GUIControllerPageGroup))]
	public bool IsPageContoller(GUIControllerItem item)
	{
		throw null;
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x06000536 RID: 1334 RVA: 0x00022AE7 File Offset: 0x00020CE7
	[global::Cpp2ILInjected.Token(Token = "0x170000AB")]
	public GUIPageIconGrouping ParentGrouping
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005D0")]
		[global::Cpp2ILInjected.Address(RVA = "0xB186B8", Offset = "0xB186B8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 71)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "GetSettingGrouping", MemberParameters = new object[] { typeof(GUIPageIconGrouping.SettingCategory) }, ReturnType = typeof(GUIPageIconGrouping))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "GetCategoryGrouping", MemberParameters = new object[]
		{
			typeof(GUIPageIcons.Category),
			typeof(bool)
		}, ReturnType = typeof(GUIPageIconGrouping))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x00022AEA File Offset: 0x00020CEA
	[global::Cpp2ILInjected.Token(Token = "0x60005D1")]
	[global::Cpp2ILInjected.Address(RVA = "0xB18A84", Offset = "0xB18A84", Length = "0x2C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 51)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "get_ParentGrouping", ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	public void LoadPageAnchor()
	{
		throw null;
	}

	// Token: 0x06000538 RID: 1336 RVA: 0x00022AED File Offset: 0x00020CED
	[global::Cpp2ILInjected.Token(Token = "0x60005D2")]
	[global::Cpp2ILInjected.Address(RVA = "0xB238F8", Offset = "0xB238F8", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void Activate()
	{
		throw null;
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x00022AF0 File Offset: 0x00020CF0
	[global::Cpp2ILInjected.Token(Token = "0x60005D3")]
	[global::Cpp2ILInjected.Address(RVA = "0xB238FC", Offset = "0xB238FC", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x00022AF3 File Offset: 0x00020CF3
	[global::Cpp2ILInjected.Token(Token = "0x60005D4")]
	[global::Cpp2ILInjected.Address(RVA = "0xB23900", Offset = "0xB23900", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x00022AF6 File Offset: 0x00020CF6
	[global::Cpp2ILInjected.Token(Token = "0x60005D5")]
	[global::Cpp2ILInjected.Address(RVA = "0xB2390C", Offset = "0xB2390C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void NavigateInto(int column, int row)
	{
		throw null;
	}

	// Token: 0x0400032A RID: 810
	[global::Cpp2ILInjected.Token(Token = "0x40004B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private readonly GUIPageIcons.Category PageCategory;

	// Token: 0x0400032B RID: 811
	[global::Cpp2ILInjected.Token(Token = "0x40004B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private readonly GUIPageIconGrouping.SettingCategory SettingCategory;

	// Token: 0x0400032C RID: 812
	[global::Cpp2ILInjected.Token(Token = "0x40004B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int ResearchButton;
}
