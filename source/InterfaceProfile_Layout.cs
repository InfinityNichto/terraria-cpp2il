using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000157")]
[JsonObject]
public class InterfaceProfile_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000D0F")]
	[JsonProperty]
	public string ProfileName;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000D10")]
	[JsonProperty]
	public int VerticalResolution;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000D11")]
	private Vector2 _minResolution;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000D12")]
	private bool forceEquipmentExpanded;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000D13")]
	[JsonProperty]
	public Dictionary<GUIPageIcons.Category, bool> GroupsCollapsed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000D14")]
	[JsonProperty]
	public List<GUIPageIconGrouping> LeftGroupings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000D15")]
	[JsonProperty]
	public List<GUIPageIconGrouping> RightGroupings;

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public int MinVerticalResolution
	{
		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x1170C00", Offset = "0x1170C00", VA = "0x1170C00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B17")]
	[Cpp2IlInjected.Address(RVA = "0x1170B24", Offset = "0x1170B24", VA = "0x1170B24")]
	public void InvalidateMinResolution()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B19")]
	[Cpp2IlInjected.Address(RVA = "0x117134C", Offset = "0x117134C", VA = "0x117134C")]
	public bool IsPageSelected(GUIPageIcons.Category category)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1A")]
	[Cpp2IlInjected.Address(RVA = "0x1171448", Offset = "0x1171448", VA = "0x1171448")]
	public bool LoadSettingRegion(GUIPageIconGrouping.SettingCategory category)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1B")]
	[Cpp2IlInjected.Address(RVA = "0x11715B0", Offset = "0x11715B0", VA = "0x11715B0")]
	public GUIPageIconGrouping GetSettingGrouping(GUIPageIconGrouping.SettingCategory category)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1C")]
	[Cpp2IlInjected.Address(RVA = "0x1171708", Offset = "0x1171708", VA = "0x1171708")]
	public GUIPageIconGrouping GetCategoryGrouping(GUIPageIcons.Category category, bool includeOptions = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1D")]
	[Cpp2IlInjected.Address(RVA = "0x11719A0", Offset = "0x11719A0", VA = "0x11719A0")]
	public void SetCollapsed(GUIPageIcons.Category category, bool collapsed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1E")]
	[Cpp2IlInjected.Address(RVA = "0x1171A44", Offset = "0x1171A44", VA = "0x1171A44")]
	public bool IsCollapsed(GUIPageIcons.Category category)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1F")]
	[Cpp2IlInjected.Address(RVA = "0x1171B9C", Offset = "0x1171B9C", VA = "0x1171B9C")]
	private bool IsGroupSame(GUIPageIconGrouping dest, GUIPageIconGrouping src, int groupIndex, bool allowFixups)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B20")]
	[Cpp2IlInjected.Address(RVA = "0x1171E80", Offset = "0x1171E80", VA = "0x1171E80")]
	private bool IsGroupListSame(List<GUIPageIconGrouping> dest, List<GUIPageIconGrouping> src, bool allowFixups, int groupOffset = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B21")]
	[Cpp2IlInjected.Address(RVA = "0x1171F74", Offset = "0x1171F74", VA = "0x1171F74")]
	public bool IsSame(InterfaceProfile_Layout other, bool allowFixups = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B22")]
	[Cpp2IlInjected.Address(RVA = "0x1172034", Offset = "0x1172034", VA = "0x1172034")]
	private void CopyGroup(GUIPageIconGrouping dest, GUIPageIconGrouping src, bool copySerialiseSettings = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B23")]
	[Cpp2IlInjected.Address(RVA = "0x1172130", Offset = "0x1172130", VA = "0x1172130")]
	private void CopyGroupList(List<GUIPageIconGrouping> dest, List<GUIPageIconGrouping> src, bool copySerialiseSettings = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B24")]
	[Cpp2IlInjected.Address(RVA = "0x1172280", Offset = "0x1172280", VA = "0x1172280")]
	public void Copy(InterfaceProfile_Layout other, bool copySerialiseSettings = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B25")]
	[Cpp2IlInjected.Address(RVA = "0x11725C0", Offset = "0x11725C0", VA = "0x11725C0")]
	private void CleanGroupList(List<GUIPageIconGrouping> dest, bool touchProfile)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B26")]
	[Cpp2IlInjected.Address(RVA = "0x1172834", Offset = "0x1172834", VA = "0x1172834")]
	public void Clean(bool touchProfile = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B27")]
	[Cpp2IlInjected.Address(RVA = "0x11728EC", Offset = "0x11728EC", VA = "0x11728EC")]
	public void OpenUI(GUIPageIcons.Category left, GUIPageIcons.Category right)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B28")]
	[Cpp2IlInjected.Address(RVA = "0x1173678", Offset = "0x1173678", VA = "0x1173678")]
	public void Close(bool shutdown = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B29")]
	[Cpp2IlInjected.Address(RVA = "0x11738A8", Offset = "0x11738A8", VA = "0x11738A8")]
	public GUIPageIcons.Category GetFirstSelectedCategory()
	{
		return default(GUIPageIcons.Category);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2A")]
	[Cpp2IlInjected.Address(RVA = "0x11739DC", Offset = "0x11739DC", VA = "0x11739DC")]
	public bool AnyOpen()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2B")]
	[Cpp2IlInjected.Address(RVA = "0x1173AD4", Offset = "0x1173AD4", VA = "0x1173AD4")]
	private void AddAvailable(GUIPageIcons.Category category)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2C")]
	[Cpp2IlInjected.Address(RVA = "0x1172E94", Offset = "0x1172E94", VA = "0x1172E94")]
	public void RefreshAllItems()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2D")]
	[Cpp2IlInjected.Address(RVA = "0x11740F0", Offset = "0x11740F0", VA = "0x11740F0")]
	public void DrawClosed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2E")]
	[Cpp2IlInjected.Address(RVA = "0x11741DC", Offset = "0x11741DC", VA = "0x11741DC")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2F")]
	[Cpp2IlInjected.Address(RVA = "0x1174584", Offset = "0x1174584", VA = "0x1174584")]
	public void DrawEdit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B30")]
	[Cpp2IlInjected.Address(RVA = "0x1175338", Offset = "0x1175338", VA = "0x1175338")]
	public void LeftRightPageController()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B31")]
	[Cpp2IlInjected.Address(RVA = "0x11760D8", Offset = "0x11760D8", VA = "0x11760D8")]
	public GUIControllerItem GetGroupUp(GUIPageIconGrouping sourceGroup, int column)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B32")]
	[Cpp2IlInjected.Address(RVA = "0x117635C", Offset = "0x117635C", VA = "0x117635C")]
	public GUIControllerItem GetGroupDown(GUIPageIconGrouping sourceGroup, int column)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B33")]
	[Cpp2IlInjected.Address(RVA = "0x1176594", Offset = "0x1176594", VA = "0x1176594")]
	public GUIControllerItem GetGroupLeft(GUIPageIconGrouping sourceGroup, int row)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B34")]
	[Cpp2IlInjected.Address(RVA = "0x117678C", Offset = "0x117678C", VA = "0x117678C")]
	public GUIControllerItem GetGroupRight(GUIPageIconGrouping sourceGroup, int row)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B35")]
	[Cpp2IlInjected.Address(RVA = "0x1176984", Offset = "0x1176984", VA = "0x1176984")]
	public InterfaceProfile_Layout()
	{
	}
}
