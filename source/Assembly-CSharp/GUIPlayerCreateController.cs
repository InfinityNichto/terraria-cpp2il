using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x020000A9 RID: 169
[global::Cpp2ILInjected.Token(Token = "0x20000EF")]
public class GUIPlayerCreateController : GUIControllerItem
{
	// Token: 0x06000584 RID: 1412 RVA: 0x00022BD1 File Offset: 0x00020DD1
	[global::Cpp2ILInjected.Token(Token = "0x600064A")]
	[global::Cpp2ILInjected.Address(RVA = "0xD16AA0", Offset = "0xD16AA0", Length = "0x220")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	public GUIPlayerCreateController()
	{
		throw null;
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x00022BD4 File Offset: 0x00020DD4
	[global::Cpp2ILInjected.Token(Token = "0x600064B")]
	[global::Cpp2ILInjected.Address(RVA = "0xD16DB8", Offset = "0xD16DB8", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawName", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawDifficulty", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "StyleOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "HairOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawCategoryButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawHSLSlider", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerCreateController_Tabs), Member = "NavigateIntoCurrentPage", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(GUIControllerItem))]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06000586 RID: 1414 RVA: 0x00022BD7 File Offset: 0x00020DD7
	[global::Cpp2ILInjected.Token(Token = "0x600064C")]
	[global::Cpp2ILInjected.Address(RVA = "0xD16F2C", Offset = "0xD16F2C", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawInfo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawStylesGrid", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawHairGrid", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	public void ActivateRandomise()
	{
		throw null;
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x00022BDA File Offset: 0x00020DDA
	[global::Cpp2ILInjected.Token(Token = "0x600064D")]
	[global::Cpp2ILInjected.Address(RVA = "0xD16F40", Offset = "0xD16F40", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x06000588 RID: 1416 RVA: 0x00022BDD File Offset: 0x00020DDD
	[global::Cpp2ILInjected.Token(Token = "0x600064E")]
	[global::Cpp2ILInjected.Address(RVA = "0xD16F48", Offset = "0xD16F48", Length = "0xC0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x00022BE0 File Offset: 0x00020DE0
	[global::Cpp2ILInjected.Token(Token = "0x600064F")]
	[global::Cpp2ILInjected.Address(RVA = "0xD17008", Offset = "0xD17008", Length = "0x9C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x0600058A RID: 1418 RVA: 0x00022BE3 File Offset: 0x00020DE3
	[global::Cpp2ILInjected.Token(Token = "0x170000CC")]
	public GUIControllerItem CurrentItem
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000650")]
		[global::Cpp2ILInjected.Address(RVA = "0xD170A4", Offset = "0xD170A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400034A RID: 842
	[global::Cpp2ILInjected.Token(Token = "0x40004D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private GUIControllerItem _activeItem;

	// Token: 0x0400034B RID: 843
	[global::Cpp2ILInjected.Token(Token = "0x40004D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public readonly GUIPlayerCreateController_MainButtons Buttons;

	// Token: 0x0400034C RID: 844
	[global::Cpp2ILInjected.Token(Token = "0x40004D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public readonly GUIPlayerCreateController_Tabs Tabs;

	// Token: 0x0400034D RID: 845
	[global::Cpp2ILInjected.Token(Token = "0x40004DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public readonly GUIPlayerCreateController_Info InfoPage;

	// Token: 0x0400034E RID: 846
	[global::Cpp2ILInjected.Token(Token = "0x40004DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public readonly GUIPlayerCreateController_Gender GenderPage;

	// Token: 0x0400034F RID: 847
	[global::Cpp2ILInjected.Token(Token = "0x40004DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public readonly GUIPlayerCreateController_HairStyle HairStlyePage;

	// Token: 0x04000350 RID: 848
	[global::Cpp2ILInjected.Token(Token = "0x40004DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public readonly GUIPlayerCreateController_ItemColour HairColour;

	// Token: 0x04000351 RID: 849
	[global::Cpp2ILInjected.Token(Token = "0x40004DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public readonly GUIPlayerCreateController_ItemColour EyeColour;

	// Token: 0x04000352 RID: 850
	[global::Cpp2ILInjected.Token(Token = "0x40004DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public readonly GUIPlayerCreateController_ItemColour SkinColour;

	// Token: 0x04000353 RID: 851
	[global::Cpp2ILInjected.Token(Token = "0x40004E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public readonly GUIPlayerCreateController_ItemColour ShirtColour;

	// Token: 0x04000354 RID: 852
	[global::Cpp2ILInjected.Token(Token = "0x40004E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public readonly GUIPlayerCreateController_ItemColour UndershirtColour;

	// Token: 0x04000355 RID: 853
	[global::Cpp2ILInjected.Token(Token = "0x40004E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public readonly GUIPlayerCreateController_ItemColour PantsColour;

	// Token: 0x04000356 RID: 854
	[global::Cpp2ILInjected.Token(Token = "0x40004E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public readonly GUIPlayerCreateController_ItemColour ShoesColour;
}
