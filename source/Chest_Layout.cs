using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x200019B")]
public class Chest_Layout : PageControllerLayoutDefinition<Chest_Layout>
{
	[global::Cpp2ILInjected.Token(Token = "0x17000123")]
	public ItemGrid_Layout DisplayChestGrid
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000B63")]
		[global::Cpp2ILInjected.Address(RVA = "0x9AC504", Offset = "0x9AC504", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChest), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChest4Page), Member = "GetGrid", ReturnType = typeof(ItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "LoadPageRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "DrawSlots", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UseHorizontalPages", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B64")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC570", Offset = "0x9AC570", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public Chest_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000CD5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x4000CD6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public String_Layout TitleController;

	[global::Cpp2ILInjected.Token(Token = "0x4000CD7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public String_Layout TitleTouch;

	[global::Cpp2ILInjected.Token(Token = "0x4000CD8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public float ItemScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000CD9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public float ItemHighlightScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000CDA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout ChestGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4000CDB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public ItemGrid_Layout HorizontalChestGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4000CDC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public PopoutMenu_Layout Menu;

	[global::Cpp2ILInjected.Token(Token = "0x4000CDD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout ChestRename;

	[global::Cpp2ILInjected.Token(Token = "0x4000CDE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout ChestRename_Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x4000CDF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout ChestRestock;

	[global::Cpp2ILInjected.Token(Token = "0x4000CE0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout ChestRestock_Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x4000CE1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout ChestQuickStack;

	[global::Cpp2ILInjected.Token(Token = "0x4000CE2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout ChestDepositAll;

	[global::Cpp2ILInjected.Token(Token = "0x4000CE3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout ChestDepositAll_Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x4000CE4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout ChestLootAll;

	[global::Cpp2ILInjected.Token(Token = "0x4000CE5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout ChestLootAll_Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x4000CE6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public TransactionButton_Layout LootButton;

	[global::Cpp2ILInjected.Token(Token = "0x4000CE7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public TransactionButton_Layout Favorite;
}
