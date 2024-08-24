using System;
using System.Collections.Generic;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Localization;
using Terraria.Map;

// Token: 0x020000C6 RID: 198
[global::Cpp2ILInjected.Token(Token = "0x200011F")]
public class GUIAccessoryInfo
{
	// Token: 0x06000644 RID: 1604 RVA: 0x00022E11 File Offset: 0x00021011
	[global::Cpp2ILInjected.Token(Token = "0x6000737")]
	[global::Cpp2ILInjected.Address(RVA = "0x1103DDC", Offset = "0x1103DDC", Length = "0x1AC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemScaleHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.CursorOver), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.DrawItemHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
	public GUIAccessoryInfo()
	{
		throw null;
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x00022E14 File Offset: 0x00021014
	[global::Cpp2ILInjected.Token(Token = "0x6000738")]
	[global::Cpp2ILInjected.Address(RVA = "0x1103F88", Offset = "0x1103F88", Length = "0xB1C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_28_InfoAccs", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "DrawRightPageHUD", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UsingTouchUI", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
	{
		typeof(SpriteSortMode),
		typeof(BlendState),
		typeof(SamplerState),
		typeof(DepthStencilState),
		typeof(RasterizerState),
		typeof(Effect),
		typeof(Matrix?),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAccessoryInfo), Member = "BuildInfoAccs", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RightSideHUDAnchorUpdator), Member = "get_AllowRowHeight", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(Texture2D)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "TopLeft", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "BottomRight", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "DrawAtPosition", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(Vector2),
		typeof(Vector2),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RightSideHUDAnchorUpdator), Member = "get_AllowSecondRow", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "FlushBatches", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_ButtonConfiguration", ReturnType = typeof(VirtualControlsButtonConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "GetButtonControlSubStyle", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfigurationMapping_Layout.ContolType) }, ReturnType = typeof(VirtualControlsButtonConfiguration_Layout.Style))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsButtonConfiguration_Layout), Member = "GetStyle", MemberParameters = new object[] { typeof(VirtualControlsButtonConfiguration_Layout.Style) }, ReturnType = typeof(QuickActionButton_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_AxisConfiguration", ReturnType = typeof(VirtualControlsAxisConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "GetAxisControlSubStyle", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfigurationMapping_Layout.ContolType) }, ReturnType = typeof(VirtualControlsAxisConfiguration_Layout.Style))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsAxisConfiguration_Layout), Member = "GetStyle", MemberParameters = new object[] { typeof(VirtualControlsAxisConfiguration_Layout.Style) }, ReturnType = typeof(Axis_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(float),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x00022E17 File Offset: 0x00021017
	[global::Cpp2ILInjected.Token(Token = "0x6000739")]
	[global::Cpp2ILInjected.Address(RVA = "0x1107760", Offset = "0x1107760", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public float ItemScale(int index)
	{
		throw null;
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x00022E1A File Offset: 0x0002101A
	[global::Cpp2ILInjected.Token(Token = "0x600073A")]
	[global::Cpp2ILInjected.Address(RVA = "0x11077AC", Offset = "0x11077AC", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void ItemOver(int index)
	{
		throw null;
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x00022E1D File Offset: 0x0002101D
	[global::Cpp2ILInjected.Token(Token = "0x600073B")]
	[global::Cpp2ILInjected.Address(RVA = "0x11077B0", Offset = "0x11077B0", Length = "0x3E4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Texture2D),
		typeof(Vector2),
		typeof(Rectangle?),
		typeof(Color),
		typeof(float),
		typeof(Vector2),
		typeof(float),
		typeof(SpriteEffects),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Union", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(Rectangle)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public void ItemDraw(ItemGrid_Layout gridLayout, int i, Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x00022E20 File Offset: 0x00021020
	[global::Cpp2ILInjected.Token(Token = "0x600073C")]
	[global::Cpp2ILInjected.Address(RVA = "0x1104AA4", Offset = "0x1104AA4", Length = "0x2CBC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfo), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfoToggles), Member = "DrawToggles", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfoToggles), Member = "DrawInfoAccesoriesToggles", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipmentLoadout), Member = "DrawToggles", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_playerInventory", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetFishingConditions", ReturnType = typeof(PlayerFishingConditions))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SceneMetrics", ReturnType = typeof(SceneMetrics))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point?), Member = "get_Value", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "GetTileSafely", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Tile))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "GetTileBaseOption", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(Tile),
		typeof(ref int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "TileToLookup", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "GetMapObjectName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_GivenOrTypeName", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "BannerToNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "GetNPCNameValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "checkDPSTime", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "getDPS", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 240)]
	public void BuildInfoAccs()
	{
		throw null;
	}

	// Token: 0x040003A6 RID: 934
	[global::Cpp2ILInjected.Token(Token = "0x400059A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public int numInfoAccessories;

	// Token: 0x040003A7 RID: 935
	[global::Cpp2ILInjected.Token(Token = "0x400059B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int[] DisplayIcons;

	// Token: 0x040003A8 RID: 936
	[global::Cpp2ILInjected.Token(Token = "0x400059C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public string[] IconText;

	// Token: 0x040003A9 RID: 937
	[global::Cpp2ILInjected.Token(Token = "0x400059D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public string[] InfoText;

	// Token: 0x040003AA RID: 938
	[global::Cpp2ILInjected.Token(Token = "0x400059E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private GUIAccessoryInfo.StringState[] InfoState;

	// Token: 0x040003AB RID: 939
	[global::Cpp2ILInjected.Token(Token = "0x400059F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private Rectangle lastDrawRegion;

	// Token: 0x040003AC RID: 940
	[global::Cpp2ILInjected.Token(Token = "0x40005A0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private GUIItemGrid.GetItemScaleHandler itemScale;

	// Token: 0x040003AD RID: 941
	[global::Cpp2ILInjected.Token(Token = "0x40005A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private GUIItemGrid.CursorOver itemOver;

	// Token: 0x040003AE RID: 942
	[global::Cpp2ILInjected.Token(Token = "0x40005A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private GUIItemGrid.DrawItemHandler itemDraw;

	// Token: 0x040003AF RID: 943
	[global::Cpp2ILInjected.Token(Token = "0x40005A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private int itemOffset;

	// Token: 0x020007BB RID: 1979
	[global::Cpp2ILInjected.Token(Token = "0x2000120")]
	private enum StringState
	{
		// Token: 0x040079DA RID: 31194
		[global::Cpp2ILInjected.Token(Token = "0x40005A5")]
		Normal,
		// Token: 0x040079DB RID: 31195
		[global::Cpp2ILInjected.Token(Token = "0x40005A6")]
		Disabled,
		// Token: 0x040079DC RID: 31196
		[global::Cpp2ILInjected.Token(Token = "0x40005A7")]
		Critter
	}
}
