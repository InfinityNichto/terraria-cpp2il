using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using ReLogic.Content;
using Terraria.IO;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000474")]
public abstract class SelectionHolder<TCycleType> where TCycleType : class, IConfigKeyHolder
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006425")]
	protected Dictionary<string, TCycleType> Options;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006426")]
	protected TCycleType ActiveSelection;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006427")]
	protected string ActiveSelectionConfigKey;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006428")]
	protected bool LoadedContent;

	[Cpp2IlInjected.Token(Token = "0x17000626")]
	public string ActiveSelectionKeyName
	{
		[Cpp2IlInjected.Token(Token = "0x600322E")]
		[Cpp2IlInjected.Address(RVA = "0x163EA0C", Offset = "0x163EA0C", VA = "0x163EA0C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600322F")]
		[Cpp2IlInjected.Address(RVA = "0x163EA14", Offset = "0x163EA14", VA = "0x163EA14")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003230")]
	[Cpp2IlInjected.Address(RVA = "0x163EA1C", Offset = "0x163EA1C", VA = "0x163EA1C")]
	public void BindTo(Preferences preferences)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003231")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void Configuration_Save(Preferences obj);

	[Cpp2IlInjected.Token(Token = "0x6003232")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void Configuration_OnLoad(Preferences obj);

	[Cpp2IlInjected.Token(Token = "0x6003233")]
	[Cpp2IlInjected.Address(RVA = "0x163EAF8", Offset = "0x163EAF8", VA = "0x163EAF8")]
	protected void Wrapped_Configuration_OnLoad(Preferences obj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003234")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void PopulateOptionsAndLoadContent(AssetRequestMode mode);

	[Cpp2IlInjected.Token(Token = "0x6003235")]
	[Cpp2IlInjected.Address(RVA = "0x163EB48", Offset = "0x163EB48", VA = "0x163EB48")]
	public void LoadContent(AssetRequestMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003236")]
	[Cpp2IlInjected.Address(RVA = "0x163EB90", Offset = "0x163EB90", VA = "0x163EB90")]
	public void CycleSelection()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003237")]
	[Cpp2IlInjected.Address(RVA = "0x163ECD0", Offset = "0x163ECD0", VA = "0x163ECD0")]
	public void SetActiveMinimapFromLoadedConfigKey()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003238")]
	[Cpp2IlInjected.Address(RVA = "0x163ECE8", Offset = "0x163ECE8", VA = "0x163ECE8")]
	private void SetActiveFrame(string frameName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003239")]
	[Cpp2IlInjected.Address(RVA = "0x163EE14", Offset = "0x163EE14", VA = "0x163EE14")]
	private void SetActiveFrame(TCycleType frame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600323A")]
	[Cpp2IlInjected.Address(RVA = "0x163EF70", Offset = "0x163EF70", VA = "0x163EF70")]
	protected SelectionHolder()
	{
	}
}
