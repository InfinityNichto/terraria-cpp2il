using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x0200005F RID: 95
[global::Cpp2ILInjected.Token(Token = "0x200008C")]
public class GUIControllerCraftingMaterials : GUIControllerItem
{
	// Token: 0x060002CE RID: 718 RVA: 0x000223BB File Offset: 0x000205BB
	[global::Cpp2ILInjected.Token(Token = "0x6000368")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C3110", Offset = "0x9C3110", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "UpdateMaterialNavigation", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x060002CF RID: 719 RVA: 0x000223BE File Offset: 0x000205BE
	[global::Cpp2ILInjected.Token(Token = "0x6000369")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C3170", Offset = "0x9C3170", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingMaterials), Member = "NavigateNext", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingMaterials), Member = "NavigatePrevious", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingMaterials), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICrafting), Member = "get_SelectedNumMaterials", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Clamp()
	{
		throw null;
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x000223C1 File Offset: 0x000205C1
	[global::Cpp2ILInjected.Token(Token = "0x600036A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C3200", Offset = "0x9C3200", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x060002D1 RID: 721 RVA: 0x000223C4 File Offset: 0x000205C4
	[global::Cpp2ILInjected.Token(Token = "0x1700007A")]
	public float UITextAlpha
	{
		[global::Cpp2ILInjected.Token(Token = "0x600036B")]
		[global::Cpp2ILInjected.Address(RVA = "0x9C3208", Offset = "0x9C3208", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x000223C7 File Offset: 0x000205C7
	[global::Cpp2ILInjected.Token(Token = "0x600036C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C329C", Offset = "0x9C329C", Length = "0xD8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingMaterials), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingMaterials), Member = "Clamp", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICrafting), Member = "get_SelectedNumMaterials", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void NavigateNext()
	{
		throw null;
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x000223CA File Offset: 0x000205CA
	[global::Cpp2ILInjected.Token(Token = "0x600036D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C3374", Offset = "0x9C3374", Length = "0xB0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingMaterials), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingMaterials), Member = "Clamp", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICrafting), Member = "get_SelectedNumMaterials", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void NavigatePrevious()
	{
		throw null;
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x000223CD File Offset: 0x000205CD
	[global::Cpp2ILInjected.Token(Token = "0x600036E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C3424", Offset = "0x9C3424", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Tick()
	{
		throw null;
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x000223D0 File Offset: 0x000205D0
	[global::Cpp2ILInjected.Token(Token = "0x600036F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C3480", Offset = "0x9C3480", Length = "0x8C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingMaterials), Member = "NavigatePrevious", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingMaterials), Member = "NavigateNext", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x000223D3 File Offset: 0x000205D3
	[global::Cpp2ILInjected.Token(Token = "0x6000370")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C350C", Offset = "0x9C350C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetSelectedItem()
	{
		throw null;
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x000223D6 File Offset: 0x000205D6
	[global::Cpp2ILInjected.Token(Token = "0x6000371")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C3514", Offset = "0x9C3514", Length = "0x26C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "DrawMaterialsGrid", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingMaterials), Member = "Clamp", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICrafting), Member = "get_SelectedNumMaterials", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x000223D9 File Offset: 0x000205D9
	[global::Cpp2ILInjected.Token(Token = "0x6000372")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C3780", Offset = "0x9C3780", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuide), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerCraftingMaterials()
	{
		throw null;
	}

	// Token: 0x0400023D RID: 573
	[global::Cpp2ILInjected.Token(Token = "0x4000360")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private int selectedItem;

	// Token: 0x0400023E RID: 574
	[global::Cpp2ILInjected.Token(Token = "0x4000361")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public DateTime LastActivated;
}
