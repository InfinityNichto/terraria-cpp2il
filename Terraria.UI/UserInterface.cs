using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004D9")]
public class UserInterface
{
	[Cpp2IlInjected.Token(Token = "0x2000955")]
	private delegate void MouseElementEvent(UIElement element, UIMouseEvent evt);

	[Cpp2IlInjected.Token(Token = "0x2000956")]
	private class InputPointerCache
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008B6F")]
		public double LastTimeDown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008B70")]
		public bool WasDown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008B71")]
		public UIElement LastDown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008B72")]
		public UIElement LastClicked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008B73")]
		public MouseElementEvent MouseDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008B74")]
		public MouseElementEvent MouseUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4008B75")]
		public MouseElementEvent ClickEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4008B76")]
		public MouseElementEvent DoubleClickEvent;

		[Cpp2IlInjected.Token(Token = "0x6004D65")]
		[Cpp2IlInjected.Address(RVA = "0x10D7584", Offset = "0x10D7584", VA = "0x10D7584")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D66")]
		[Cpp2IlInjected.Address(RVA = "0x10D7C7C", Offset = "0x10D7C7C", VA = "0x10D7C7C")]
		public InputPointerCache()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40066EB")]
	private const double DOUBLE_CLICK_TIME = 500.0;

	[Cpp2IlInjected.Token(Token = "0x40066EC")]
	private const double STATE_CHANGE_CLICK_DISABLE_TIME = 200.0;

	[Cpp2IlInjected.Token(Token = "0x40066ED")]
	private const int MAX_HISTORY_SIZE = 32;

	[Cpp2IlInjected.Token(Token = "0x40066EE")]
	private const int HISTORY_PRUNE_SIZE = 4;

	[Cpp2IlInjected.Token(Token = "0x40066EF")]
	public static UserInterface ActiveInstance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40066F0")]
	private List<UIState> _history;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40066F1")]
	private InputPointerCache LeftMouse;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40066F2")]
	private InputPointerCache RightMouse;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40066F3")]
	public Vector2 MousePosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40066F4")]
	private UIElement _lastElementHover;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40066F5")]
	private double _clickDisabledTimeRemaining;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40066F6")]
	private bool _isStateDirty;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40066F7")]
	public bool IsVisible;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40066F8")]
	private UIState _currentState;

	[Cpp2IlInjected.Token(Token = "0x170006CF")]
	public UIState CurrentState
	{
		[Cpp2IlInjected.Token(Token = "0x6003684")]
		[Cpp2IlInjected.Address(RVA = "0x10D7668", Offset = "0x10D7668", VA = "0x10D7668")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003681")]
	[Cpp2IlInjected.Address(RVA = "0x10D7554", Offset = "0x10D7554", VA = "0x10D7554")]
	public void ClearPointers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003682")]
	[Cpp2IlInjected.Address(RVA = "0x10D759C", Offset = "0x10D759C", VA = "0x10D759C")]
	public void ResetLasts()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003683")]
	[Cpp2IlInjected.Address(RVA = "0x10D7664", Offset = "0x10D7664", VA = "0x10D7664")]
	public void EscapeElements()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003685")]
	[Cpp2IlInjected.Address(RVA = "0x10D7670", Offset = "0x10D7670", VA = "0x10D7670")]
	public UserInterface()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003686")]
	[Cpp2IlInjected.Address(RVA = "0x10D7C98", Offset = "0x10D7C98", VA = "0x10D7C98")]
	public void Use()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003687")]
	[Cpp2IlInjected.Address(RVA = "0x10D7DB4", Offset = "0x10D7DB4", VA = "0x10D7DB4")]
	private void ImmediatelyUpdateInputPointers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003688")]
	[Cpp2IlInjected.Address(RVA = "0x10D7E48", Offset = "0x10D7E48", VA = "0x10D7E48")]
	private void ResetState()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003689")]
	[Cpp2IlInjected.Address(RVA = "0x10D7FC4", Offset = "0x10D7FC4", VA = "0x10D7FC4")]
	private void GetMousePosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600368A")]
	[Cpp2IlInjected.Address(RVA = "0x10D808C", Offset = "0x10D808C", VA = "0x10D808C")]
	public void Update(GameTime time)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600368B")]
	[Cpp2IlInjected.Address(RVA = "0x10D84D8", Offset = "0x10D84D8", VA = "0x10D84D8")]
	private void HandleClick(InputPointerCache cache, GameTime time, bool isDown, UIElement mouseElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600368C")]
	[Cpp2IlInjected.Address(RVA = "0x10D8BF4", Offset = "0x10D8BF4", VA = "0x10D8BF4")]
	public void Draw(SpriteBatch spriteBatch, GameTime time)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600368D")]
	[Cpp2IlInjected.Address(RVA = "0x10D8C58", Offset = "0x10D8C58", VA = "0x10D8C58")]
	public void DrawDebugHitbox(BasicDebugDrawer drawer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600368E")]
	[Cpp2IlInjected.Address(RVA = "0x10D8C5C", Offset = "0x10D8C5C", VA = "0x10D8C5C")]
	public void SetState(UIState state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600368F")]
	[Cpp2IlInjected.Address(RVA = "0x10D8E04", Offset = "0x10D8E04", VA = "0x10D8E04")]
	public void GoBack()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003690")]
	[Cpp2IlInjected.Address(RVA = "0x10D8D70", Offset = "0x10D8D70", VA = "0x10D8D70")]
	private void AddToHistory(UIState state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003691")]
	[Cpp2IlInjected.Address(RVA = "0x10D7D98", Offset = "0x10D7D98", VA = "0x10D7D98")]
	public void Recalculate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003692")]
	[Cpp2IlInjected.Address(RVA = "0x10D8E8C", Offset = "0x10D8E8C", VA = "0x10D8E8C")]
	public CalculatedStyle GetDimensions()
	{
		return default(CalculatedStyle);
	}

	[Cpp2IlInjected.Token(Token = "0x6003693")]
	[Cpp2IlInjected.Address(RVA = "0x10D905C", Offset = "0x10D905C", VA = "0x10D905C")]
	internal void RefreshState()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003694")]
	[Cpp2IlInjected.Address(RVA = "0x10D90A8", Offset = "0x10D90A8", VA = "0x10D90A8")]
	public bool IsElementUnderMouse()
	{
		return default(bool);
	}
}
