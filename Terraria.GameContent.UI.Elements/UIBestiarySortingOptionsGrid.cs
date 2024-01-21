using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006BF")]
public class UIBestiarySortingOptionsGrid : UIPanel
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4006FC0")]
	private EntrySorter<BestiaryEntry, IBestiarySortStep> _sorter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4006FC1")]
	private List<GroupOptionButton<int>> _buttonsBySorting;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4006FC2")]
	private int _currentSelected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x4006FC3")]
	private int _defaultStepIndex;

	[Cpp2IlInjected.Token(Token = "0x14000057")]
	public event Action OnClickingOption
	{
		[Cpp2IlInjected.Token(Token = "0x600440E")]
		[Cpp2IlInjected.Address(RVA = "0x14830A4", Offset = "0x14830A4", VA = "0x14830A4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600440F")]
		[Cpp2IlInjected.Address(RVA = "0x1483154", Offset = "0x1483154", VA = "0x1483154")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004410")]
	[Cpp2IlInjected.Address(RVA = "0x1483204", Offset = "0x1483204", VA = "0x1483204")]
	public UIBestiarySortingOptionsGrid(EntrySorter<BestiaryEntry, IBestiarySortStep> sorter)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004411")]
	[Cpp2IlInjected.Address(RVA = "0x14833A0", Offset = "0x14833A0", VA = "0x14833A0")]
	private void BuildGrid()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004412")]
	[Cpp2IlInjected.Address(RVA = "0x1483AC0", Offset = "0x1483AC0", VA = "0x1483AC0")]
	private void ClickOption(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004413")]
	[Cpp2IlInjected.Address(RVA = "0x1483D24", Offset = "0x1483D24", VA = "0x1483D24")]
	public void GetEntriesToShow(out int maxEntriesWidth, out int maxEntriesHeight, out int maxEntriesToHave)
	{
	}
}
