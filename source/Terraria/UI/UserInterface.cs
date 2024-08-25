using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria.GameContent.Creative;
using Terraria.GameContent.UI.States;
using Terraria.GameInput;

namespace Terraria.UI
{
	[global::Cpp2ILInjected.Token(Token = "0x2000727")]
	public class UserInterface
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003C95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1491FC8", Offset = "0x1491FC8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ClearPointers()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1491FF0", Offset = "0x1491FF0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserInterface), Member = "EscapeElements", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void ResetLasts()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C97")]
		[global::Cpp2ILInjected.Address(RVA = "0x1492090", Offset = "0x1492090", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "ToggleMenu", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserInterface), Member = "ResetLasts", ReturnType = typeof(void))]
		public void EscapeElements()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000768")]
		public UIState CurrentState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003C98")]
			[global::Cpp2ILInjected.Address(RVA = "0x1492094", Offset = "0x1492094", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C99")]
		[global::Cpp2ILInjected.Address(RVA = "0x149209C", Offset = "0x149209C", Length = "0x4AC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserInterface), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserInterface.MouseElementEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
		public UserInterface()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1492680", Offset = "0x1492680", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserInterface), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(GameTime)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Use()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1492748", Offset = "0x1492748", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserInterface), Member = "ResetState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseRight", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ImmediatelyUpdateInputPointers()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x14927C0", Offset = "0x14927C0", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserInterface), Member = "SetState", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserInterface), Member = "RefreshState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserInterface), Member = "GetMousePosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserInterface), Member = "ImmediatelyUpdateInputPointers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void ResetState()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x14928EC", Offset = "0x14928EC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserInterface), Member = "ResetState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserInterface), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void GetMousePosition()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1492978", Offset = "0x1492978", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserInterface), Member = "GetMousePosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "GetElementAt", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserInterface), Member = "HandleClick", MemberParameters = new object[]
		{
			typeof(UserInterface.InputPointerCache),
			typeof(GameTime),
			typeof(bool),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseRight", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public void Update(GameTime time)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1492CB0", Offset = "0x1492CB0", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserInterface), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void HandleClick(UserInterface.InputPointerCache cache, GameTime time, bool isDown, UIElement mouseElement)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003CA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1492EAC", Offset = "0x1492EAC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserInterface), Member = "Use", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Draw(SpriteBatch spriteBatch, GameTime time)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003CA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1492F08", Offset = "0x1492F08", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void DrawDebugHitbox(BasicDebugDrawer drawer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003CA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1492F0C", Offset = "0x1492F0C", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IngameFancyUI), Member = "OpenUIState", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IngameFancyUI), Member = "OpenVirtualKeyboard", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IngameFancyUI), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IngameFancyUI), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(GameTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserInterface), Member = "GoBack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "OpenVirtualKeyboardWhenNeeded", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "GoBackHere", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserInterface), Member = "AddToHistory", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Deactivate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserInterface), Member = "ResetState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Activate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void SetState(UIState state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003CA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x14930F0", Offset = "0x14930F0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserInterface), Member = "SetState", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void GoBack()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003CA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1493004", Offset = "0x1493004", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserInterface), Member = "SetState", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void AddToHistory(UIState state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003CA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1492730", Offset = "0x1492730", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "PreDrawMenu", MemberParameters = new object[]
		{
			typeof(ref Point),
			typeof(ref Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SetDisplayMode", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Recalculate()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003CA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1493198", Offset = "0x1493198", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIElement), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_OriginalScreenSize", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public CalculatedStyle GetDimensions()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003CA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x14932D4", Offset = "0x14932D4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Deactivate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserInterface), Member = "ResetState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Activate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void RefreshState()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003CA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1493314", Offset = "0x1493314", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IngameFancyUI), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(GameTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IngameFancyUI), Member = "MouseOver", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool IsElementUnderMouse()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003CA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x14933A0", Offset = "0x14933A0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserInterface), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static UserInterface()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007BB6")]
		private const double DOUBLE_CLICK_TIME = 500.0;

		[global::Cpp2ILInjected.Token(Token = "0x4007BB7")]
		private const double STATE_CHANGE_CLICK_DISABLE_TIME = 200.0;

		[global::Cpp2ILInjected.Token(Token = "0x4007BB8")]
		private const int MAX_HISTORY_SIZE = 32;

		[global::Cpp2ILInjected.Token(Token = "0x4007BB9")]
		private const int HISTORY_PRUNE_SIZE = 4;

		[global::Cpp2ILInjected.Token(Token = "0x4007BBA")]
		public static UserInterface ActiveInstance;

		[global::Cpp2ILInjected.Token(Token = "0x4007BBB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<UIState> _history;

		[global::Cpp2ILInjected.Token(Token = "0x4007BBC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private UserInterface.InputPointerCache LeftMouse;

		[global::Cpp2ILInjected.Token(Token = "0x4007BBD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private UserInterface.InputPointerCache RightMouse;

		[global::Cpp2ILInjected.Token(Token = "0x4007BBE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Vector2 MousePosition;

		[global::Cpp2ILInjected.Token(Token = "0x4007BBF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private UIElement _lastElementHover;

		[global::Cpp2ILInjected.Token(Token = "0x4007BC0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private double _clickDisabledTimeRemaining;

		[global::Cpp2ILInjected.Token(Token = "0x4007BC1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool _isStateDirty;

		[global::Cpp2ILInjected.Token(Token = "0x4007BC2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
		public bool IsVisible;

		[global::Cpp2ILInjected.Token(Token = "0x4007BC3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private UIState _currentState;

		[global::Cpp2ILInjected.Token(Token = "0x2000728")]
		private delegate void MouseElementEvent(UIElement element, UIMouseEvent evt);

		[global::Cpp2ILInjected.Token(Token = "0x2000729")]
		private class InputPointerCache
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003CAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1491FE4", Offset = "0x1491FE4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Clear()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003CAF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1492548", Offset = "0x1492548", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public InputPointerCache()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4007BC4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public double LastTimeDown;

			[global::Cpp2ILInjected.Token(Token = "0x4007BC5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public bool WasDown;

			[global::Cpp2ILInjected.Token(Token = "0x4007BC6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public UIElement LastDown;

			[global::Cpp2ILInjected.Token(Token = "0x4007BC7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public UIElement LastClicked;

			[global::Cpp2ILInjected.Token(Token = "0x4007BC8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public UserInterface.MouseElementEvent MouseDownEvent;

			[global::Cpp2ILInjected.Token(Token = "0x4007BC9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public UserInterface.MouseElementEvent MouseUpEvent;

			[global::Cpp2ILInjected.Token(Token = "0x4007BCA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public UserInterface.MouseElementEvent ClickEvent;

			[global::Cpp2ILInjected.Token(Token = "0x4007BCB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			public UserInterface.MouseElementEvent DoubleClickEvent;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200072A")]
		[Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003CB0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1493440", Offset = "0x1493440", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003CB1")]
			[global::Cpp2ILInjected.Address(RVA = "0x149349C", Offset = "0x149349C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003CB2")]
			[global::Cpp2ILInjected.Address(RVA = "0x14934A4", Offset = "0x14934A4", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void <.ctor>b__21_0(UIElement element, UIMouseEvent evt)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003CB3")]
			[global::Cpp2ILInjected.Address(RVA = "0x14934C0", Offset = "0x14934C0", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void <.ctor>b__21_1(UIElement element, UIMouseEvent evt)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003CB4")]
			[global::Cpp2ILInjected.Address(RVA = "0x14934DC", Offset = "0x14934DC", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void <.ctor>b__21_2(UIElement element, UIMouseEvent evt)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003CB5")]
			[global::Cpp2ILInjected.Address(RVA = "0x14934F8", Offset = "0x14934F8", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void <.ctor>b__21_3(UIElement element, UIMouseEvent evt)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003CB6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1493514", Offset = "0x1493514", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void <.ctor>b__21_4(UIElement element, UIMouseEvent evt)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003CB7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1493530", Offset = "0x1493530", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void <.ctor>b__21_5(UIElement element, UIMouseEvent evt)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003CB8")]
			[global::Cpp2ILInjected.Address(RVA = "0x149354C", Offset = "0x149354C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void <.ctor>b__21_6(UIElement element, UIMouseEvent evt)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003CB9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1493568", Offset = "0x1493568", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void <.ctor>b__21_7(UIElement element, UIMouseEvent evt)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4007BCC")]
			public static readonly UserInterface.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x4007BCD")]
			public static UserInterface.MouseElementEvent <>9__21_0;

			[global::Cpp2ILInjected.Token(Token = "0x4007BCE")]
			public static UserInterface.MouseElementEvent <>9__21_1;

			[global::Cpp2ILInjected.Token(Token = "0x4007BCF")]
			public static UserInterface.MouseElementEvent <>9__21_2;

			[global::Cpp2ILInjected.Token(Token = "0x4007BD0")]
			public static UserInterface.MouseElementEvent <>9__21_3;

			[global::Cpp2ILInjected.Token(Token = "0x4007BD1")]
			public static UserInterface.MouseElementEvent <>9__21_4;

			[global::Cpp2ILInjected.Token(Token = "0x4007BD2")]
			public static UserInterface.MouseElementEvent <>9__21_5;

			[global::Cpp2ILInjected.Token(Token = "0x4007BD3")]
			public static UserInterface.MouseElementEvent <>9__21_6;

			[global::Cpp2ILInjected.Token(Token = "0x4007BD4")]
			public static UserInterface.MouseElementEvent <>9__21_7;
		}
	}
}
