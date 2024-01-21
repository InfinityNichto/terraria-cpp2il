using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006DF")]
public class UIList : UIElement, IEnumerable<UIElement>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000AB9")]
	public delegate bool ElementSearchMethod(UIElement element);

	[Cpp2IlInjected.Token(Token = "0x2000ABA")]
	private class UIInnerList : UIElement
	{
		[Cpp2IlInjected.Token(Token = "0x60052C0")]
		[Cpp2IlInjected.Address(RVA = "0x1494738", Offset = "0x1494738", VA = "0x1494738", Slot = "12")]
		public override bool ContainsPoint(Vector2 point)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60052C1")]
		[Cpp2IlInjected.Address(RVA = "0x1494740", Offset = "0x1494740", VA = "0x1494740", Slot = "7")]
		protected override void DrawChildren(SpriteBatch spriteBatch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60052C2")]
		[Cpp2IlInjected.Address(RVA = "0x1494974", Offset = "0x1494974", VA = "0x1494974", Slot = "13")]
		public override Rectangle GetViewCullingArea()
		{
			return default(Rectangle);
		}

		[Cpp2IlInjected.Token(Token = "0x60052C3")]
		[Cpp2IlInjected.Address(RVA = "0x1493970", Offset = "0x1493970", VA = "0x1493970")]
		public UIInnerList()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4007072")]
	protected List<UIElement> _items;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4007073")]
	protected UIScrollbar _scrollbar;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4007074")]
	private UIElement _innerList;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4007075")]
	private float _innerListHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4007076")]
	public float ListPadding;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4007077")]
	public Action<List<UIElement>> ManualSortMethod;

	[Cpp2IlInjected.Token(Token = "0x170007C8")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x60044E9")]
		[Cpp2IlInjected.Address(RVA = "0x1493924", Offset = "0x1493924", VA = "0x1493924")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60044EA")]
	[Cpp2IlInjected.Address(RVA = "0x147E648", Offset = "0x147E648", VA = "0x147E648")]
	public UIList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044EB")]
	[Cpp2IlInjected.Address(RVA = "0x14939EC", Offset = "0x14939EC", VA = "0x14939EC")]
	public float GetTotalHeight()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60044EC")]
	[Cpp2IlInjected.Address(RVA = "0x14939F4", Offset = "0x14939F4", VA = "0x14939F4")]
	public void Goto(ElementSearchMethod searchMethod)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044ED")]
	[Cpp2IlInjected.Address(RVA = "0x1493F10", Offset = "0x1493F10", VA = "0x1493F10", Slot = "32")]
	public virtual void Add(UIElement item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044EE")]
	[Cpp2IlInjected.Address(RVA = "0x149408C", Offset = "0x149408C", VA = "0x149408C", Slot = "33")]
	public virtual bool Remove(UIElement item)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60044EF")]
	[Cpp2IlInjected.Address(RVA = "0x1494108", Offset = "0x1494108", VA = "0x1494108", Slot = "34")]
	public virtual void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044F0")]
	[Cpp2IlInjected.Address(RVA = "0x1494170", Offset = "0x1494170", VA = "0x1494170", Slot = "11")]
	public override void Recalculate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044F1")]
	[Cpp2IlInjected.Address(RVA = "0x14941C0", Offset = "0x14941C0", VA = "0x14941C0", Slot = "25")]
	public override void ScrollWheel(UIScrollWheelEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044F2")]
	[Cpp2IlInjected.Address(RVA = "0x149421C", Offset = "0x149421C", VA = "0x149421C", Slot = "14")]
	public override void RecalculateChildren()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044F3")]
	[Cpp2IlInjected.Address(RVA = "0x14941A4", Offset = "0x14941A4", VA = "0x14941A4")]
	private void UpdateScrollbar()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044F4")]
	[Cpp2IlInjected.Address(RVA = "0x147EA44", Offset = "0x147EA44", VA = "0x147EA44")]
	public void SetScrollbar(UIScrollbar scrollbar)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044F5")]
	[Cpp2IlInjected.Address(RVA = "0x1493FA0", Offset = "0x1493FA0", VA = "0x1493FA0")]
	public void UpdateOrder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044F6")]
	[Cpp2IlInjected.Address(RVA = "0x1494358", Offset = "0x1494358", VA = "0x1494358")]
	public int SortMethod(UIElement item1, UIElement item2)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60044F7")]
	[Cpp2IlInjected.Address(RVA = "0x1494374", Offset = "0x1494374", VA = "0x1494374", Slot = "10")]
	public override List<SnapPoint> GetSnapPoints()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60044F8")]
	[Cpp2IlInjected.Address(RVA = "0x1494514", Offset = "0x1494514", VA = "0x1494514", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044F9")]
	[Cpp2IlInjected.Address(RVA = "0x1494560", Offset = "0x1494560", VA = "0x1494560", Slot = "30")]
	public IEnumerator<UIElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60044FA")]
	[Cpp2IlInjected.Address(RVA = "0x1494620", Offset = "0x1494620", VA = "0x1494620", Slot = "31")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
