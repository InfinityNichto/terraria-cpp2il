using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x20000EF")]
public class GUIPlayerCreateController : GUIControllerItem
{
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

	[global::Cpp2ILInjected.Token(Token = "0x600064D")]
	[global::Cpp2ILInjected.Address(RVA = "0xD16F40", Offset = "0xD16F40", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600064E")]
	[global::Cpp2ILInjected.Address(RVA = "0xD16F48", Offset = "0xD16F48", Length = "0xC0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600064F")]
	[global::Cpp2ILInjected.Address(RVA = "0xD17008", Offset = "0xD17008", Length = "0x9C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

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

	[global::Cpp2ILInjected.Token(Token = "0x40004D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private GUIControllerItem _activeItem;

	[global::Cpp2ILInjected.Token(Token = "0x40004D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public readonly GUIPlayerCreateController_MainButtons Buttons;

	[global::Cpp2ILInjected.Token(Token = "0x40004D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public readonly GUIPlayerCreateController_Tabs Tabs;

	[global::Cpp2ILInjected.Token(Token = "0x40004DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public readonly GUIPlayerCreateController_Info InfoPage;

	[global::Cpp2ILInjected.Token(Token = "0x40004DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public readonly GUIPlayerCreateController_Gender GenderPage;

	[global::Cpp2ILInjected.Token(Token = "0x40004DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public readonly GUIPlayerCreateController_HairStyle HairStlyePage;

	[global::Cpp2ILInjected.Token(Token = "0x40004DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public readonly GUIPlayerCreateController_ItemColour HairColour;

	[global::Cpp2ILInjected.Token(Token = "0x40004DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public readonly GUIPlayerCreateController_ItemColour EyeColour;

	[global::Cpp2ILInjected.Token(Token = "0x40004DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public readonly GUIPlayerCreateController_ItemColour SkinColour;

	[global::Cpp2ILInjected.Token(Token = "0x40004E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public readonly GUIPlayerCreateController_ItemColour ShirtColour;

	[global::Cpp2ILInjected.Token(Token = "0x40004E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public readonly GUIPlayerCreateController_ItemColour UndershirtColour;

	[global::Cpp2ILInjected.Token(Token = "0x40004E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public readonly GUIPlayerCreateController_ItemColour PantsColour;

	[global::Cpp2ILInjected.Token(Token = "0x40004E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public readonly GUIPlayerCreateController_ItemColour ShoesColour;
}
