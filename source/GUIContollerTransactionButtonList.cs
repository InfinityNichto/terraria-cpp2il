using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x2000084")]
public class GUIContollerTransactionButtonList : GUIControllerItem
{
	[global::Cpp2ILInjected.Token(Token = "0x6000332")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C0888", Offset = "0x9C0888", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000333")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C08F4", Offset = "0x9C08F4", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsPauseMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = "get_FilterListOptionsController", ReturnType = typeof(GUIContollerTransactionButtonList))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMainMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "get_MultiplayerLobbyOptionsController", ReturnType = typeof(GUIContollerTransactionButtonList))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "get_PlayerListOptionsController", ReturnType = typeof(GUIContollerTransactionButtonList))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "get_WorldListOptionsController", ReturnType = typeof(GUIContollerTransactionButtonList))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIContollerTransactionButtonList(bool vertical, bool wrapAround, TransactionButton_Layout[] items, GUIContollerTransactionButtonList.SetupRegions regionSetup = null)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000334")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C093C", Offset = "0x9C093C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsPauseMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void Activate()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000335")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C0944", Offset = "0x9C0944", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void SelectOption(int option)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000336")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C094C", Offset = "0x9C094C", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000337")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C09C4", Offset = "0x9C09C4", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public GUIControllerItem Navigate(Vector2 navigationAxis)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000339")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool _vertical;

	[global::Cpp2ILInjected.Token(Token = "0x400033A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
	private bool _wrapAround;

	[global::Cpp2ILInjected.Token(Token = "0x400033B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private int _selectedItem;

	[global::Cpp2ILInjected.Token(Token = "0x400033C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private TransactionButton_Layout[] _items;

	[global::Cpp2ILInjected.Token(Token = "0x400033D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private GUIContollerTransactionButtonList.SetupRegions _regionSetup;

	[global::Cpp2ILInjected.Token(Token = "0x2000085")]
	public delegate void SetupRegions(bool setup);
}
