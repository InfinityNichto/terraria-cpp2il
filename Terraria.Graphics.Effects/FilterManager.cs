using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Effects;

[Cpp2IlInjected.Token(Token = "0x200051E")]
public class FilterManager : EffectManager<Filter>
{
	[Cpp2IlInjected.Token(Token = "0x4006858")]
	private const float OPACITY_RATE = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400685A")]
	private LinkedList<Filter> _activeFilters;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400685B")]
	private int _filterLimit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400685C")]
	private EffectPriority _priorityThreshold;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400685D")]
	private int _activeFilterCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400685E")]
	private bool _captureThisFrame;

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event Action OnPostDraw
	{
		[Cpp2IlInjected.Token(Token = "0x6003897")]
		[Cpp2IlInjected.Address(RVA = "0x15079A8", Offset = "0x15079A8", VA = "0x15079A8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6003898")]
		[Cpp2IlInjected.Address(RVA = "0x1507A58", Offset = "0x1507A58", VA = "0x1507A58")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003899")]
	[Cpp2IlInjected.Address(RVA = "0x1507B08", Offset = "0x1507B08", VA = "0x1507B08")]
	public FilterManager()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600389A")]
	[Cpp2IlInjected.Address(RVA = "0x1507BA0", Offset = "0x1507BA0", VA = "0x1507BA0", Slot = "4")]
	public override void OnActivate(Filter effect, Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600389B")]
	[Cpp2IlInjected.Address(RVA = "0x1507D28", Offset = "0x1507D28", VA = "0x1507D28")]
	public void BeginCapture(RenderTarget2D screenTarget1, Color clearColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600389C")]
	[Cpp2IlInjected.Address(RVA = "0x1507E08", Offset = "0x1507E08", VA = "0x1507E08")]
	public void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600389D")]
	[Cpp2IlInjected.Address(RVA = "0x1508014", Offset = "0x1508014", VA = "0x1508014")]
	public void UpdateFilters()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600389E")]
	[Cpp2IlInjected.Address(RVA = "0x150813C", Offset = "0x150813C", VA = "0x150813C")]
	public void EndCapture(RenderTarget2D finalTexture, RenderTarget2D screenTarget1, RenderTarget2D screenTarget2, Color clearColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600389F")]
	[Cpp2IlInjected.Address(RVA = "0x1508F54", Offset = "0x1508F54", VA = "0x1508F54")]
	public bool HasActiveFilter()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60038A0")]
	[Cpp2IlInjected.Address(RVA = "0x1508FA8", Offset = "0x1508FA8", VA = "0x1508FA8")]
	public bool CanCapture()
	{
		return default(bool);
	}
}
