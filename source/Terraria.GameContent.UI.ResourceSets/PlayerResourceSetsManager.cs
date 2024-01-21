using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using ReLogic.Content;
using Terraria.IO;

namespace Terraria.GameContent.UI.ResourceSets;

[Cpp2IlInjected.Token(Token = "0x20006B1")]
public class PlayerResourceSetsManager
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006F61")]
	private Dictionary<string, IPlayerResourcesDisplaySet> _sets;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006F62")]
	private IPlayerResourcesDisplaySet _activeSet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006F63")]
	private string _activeSetConfigKey;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006F64")]
	private bool _loadedContent;

	[Cpp2IlInjected.Token(Token = "0x170007B5")]
	public string ActiveSetKeyName
	{
		[Cpp2IlInjected.Token(Token = "0x60043A6")]
		[Cpp2IlInjected.Address(RVA = "0x10A6D88", Offset = "0x10A6D88", VA = "0x10A6D88")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60043A7")]
		[Cpp2IlInjected.Address(RVA = "0x10A6D90", Offset = "0x10A6D90", VA = "0x10A6D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60043A8")]
	[Cpp2IlInjected.Address(RVA = "0x10A6D98", Offset = "0x10A6D98", VA = "0x10A6D98")]
	public void BindTo(Preferences preferences)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043A9")]
	[Cpp2IlInjected.Address(RVA = "0x10A6E70", Offset = "0x10A6E70", VA = "0x10A6E70")]
	private void Configuration_OnLoad(Preferences obj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043AA")]
	[Cpp2IlInjected.Address(RVA = "0x10A6F18", Offset = "0x10A6F18", VA = "0x10A6F18")]
	private void Configuration_OnSave(Preferences obj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043AB")]
	[Cpp2IlInjected.Address(RVA = "0x10A6F80", Offset = "0x10A6F80", VA = "0x10A6F80")]
	public void LoadContent(AssetRequestMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043AC")]
	[Cpp2IlInjected.Address(RVA = "0x10A6F10", Offset = "0x10A6F10", VA = "0x10A6F10")]
	public void SetActiveFromLoadedConfigKey()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043AD")]
	[Cpp2IlInjected.Address(RVA = "0x10A7208", Offset = "0x10A7208", VA = "0x10A7208")]
	private void SetActive(string name)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043AE")]
	[Cpp2IlInjected.Address(RVA = "0x10A7330", Offset = "0x10A7330", VA = "0x10A7330")]
	private void SetActiveFrame(IPlayerResourcesDisplaySet set)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043AF")]
	[Cpp2IlInjected.Address(RVA = "0x10A7468", Offset = "0x10A7468", VA = "0x10A7468")]
	public void TryToHoverOverResources()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043B0")]
	[Cpp2IlInjected.Address(RVA = "0x10A7528", Offset = "0x10A7528", VA = "0x10A7528")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043B1")]
	[Cpp2IlInjected.Address(RVA = "0x10A75E8", Offset = "0x10A75E8", VA = "0x10A75E8")]
	public void CycleResourceSet()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043B2")]
	[Cpp2IlInjected.Address(RVA = "0x10A7718", Offset = "0x10A7718", VA = "0x10A7718")]
	public PlayerResourceSetsManager()
	{
	}
}
