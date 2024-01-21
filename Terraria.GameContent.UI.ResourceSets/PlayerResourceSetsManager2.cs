using Cpp2IlInjected;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.IO;

namespace Terraria.GameContent.UI.ResourceSets;

[Cpp2IlInjected.Token(Token = "0x20006B0")]
public class PlayerResourceSetsManager2 : SelectionHolder<IPlayerResourcesDisplaySet>
{
	[Cpp2IlInjected.Token(Token = "0x60043A0")]
	[Cpp2IlInjected.Address(RVA = "0x10A7810", Offset = "0x10A7810", VA = "0x10A7810", Slot = "4")]
	protected override void Configuration_Save(Preferences obj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043A1")]
	[Cpp2IlInjected.Address(RVA = "0x10A7878", Offset = "0x10A7878", VA = "0x10A7878", Slot = "5")]
	protected override void Configuration_OnLoad(Preferences obj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043A2")]
	[Cpp2IlInjected.Address(RVA = "0x10A7928", Offset = "0x10A7928", VA = "0x10A7928", Slot = "6")]
	protected override void PopulateOptionsAndLoadContent(AssetRequestMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043A3")]
	[Cpp2IlInjected.Address(RVA = "0x10A7BA8", Offset = "0x10A7BA8", VA = "0x10A7BA8")]
	public void TryToHoverOverResources()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043A4")]
	[Cpp2IlInjected.Address(RVA = "0x10A7C68", Offset = "0x10A7C68", VA = "0x10A7C68")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043A5")]
	[Cpp2IlInjected.Address(RVA = "0x10A7D28", Offset = "0x10A7D28", VA = "0x10A7D28")]
	public PlayerResourceSetsManager2()
	{
	}
}
