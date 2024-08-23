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
	// Token: 0x020004D6 RID: 1238
	[global::Cpp2ILInjected.Token(Token = "0x2000727")]
	public class UserInterface
	{
		// Token: 0x06003645 RID: 13893 RVA: 0x0002BB17 File Offset: 0x00029D17
		[global::Cpp2ILInjected.Token(Token = "0x6003C95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1491FC8", Offset = "0x1491FC8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ClearPointers()
		{
			throw null;
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x0002BB1A File Offset: 0x00029D1A
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

		// Token: 0x06003647 RID: 13895 RVA: 0x0002BB1D File Offset: 0x00029D1D
		[global::Cpp2ILInjected.Token(Token = "0x6003C97")]
		[global::Cpp2ILInjected.Address(RVA = "0x1492090", Offset = "0x1492090", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "ToggleMenu", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserInterface), Member = "ResetLasts", ReturnType = typeof(void))]
		public void EscapeElements()
		{
			throw null;
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06003648 RID: 13896 RVA: 0x0002BB20 File Offset: 0x00029D20
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

		// Token: 0x06003649 RID: 13897 RVA: 0x0002BB23 File Offset: 0x00029D23
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

		// Token: 0x0600364A RID: 13898 RVA: 0x0002BB26 File Offset: 0x00029D26
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

		// Token: 0x0600364B RID: 13899 RVA: 0x0002BB29 File Offset: 0x00029D29
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

		// Token: 0x0600364C RID: 13900 RVA: 0x0002BB2C File Offset: 0x00029D2C
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

		// Token: 0x0600364D RID: 13901 RVA: 0x0002BB2F File Offset: 0x00029D2F
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

		// Token: 0x0600364E RID: 13902 RVA: 0x0002BB32 File Offset: 0x00029D32
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

		// Token: 0x0600364F RID: 13903 RVA: 0x0002BB35 File Offset: 0x00029D35
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

		// Token: 0x06003650 RID: 13904 RVA: 0x0002BB38 File Offset: 0x00029D38
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

		// Token: 0x06003651 RID: 13905 RVA: 0x0002BB3B File Offset: 0x00029D3B
		[global::Cpp2ILInjected.Token(Token = "0x6003CA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1492F08", Offset = "0x1492F08", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void DrawDebugHitbox(BasicDebugDrawer drawer)
		{
			throw null;
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x0002BB3E File Offset: 0x00029D3E
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

		// Token: 0x06003653 RID: 13907 RVA: 0x0002BB41 File Offset: 0x00029D41
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

		// Token: 0x06003654 RID: 13908 RVA: 0x0002BB44 File Offset: 0x00029D44
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

		// Token: 0x06003655 RID: 13909 RVA: 0x0002BB47 File Offset: 0x00029D47
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

		// Token: 0x06003656 RID: 13910 RVA: 0x0002BB4A File Offset: 0x00029D4A
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

		// Token: 0x06003657 RID: 13911 RVA: 0x0002BB4D File Offset: 0x00029D4D
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

		// Token: 0x06003658 RID: 13912 RVA: 0x0002BB50 File Offset: 0x00029D50
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

		// Token: 0x06003659 RID: 13913 RVA: 0x0002BB53 File Offset: 0x00029D53
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

		// Token: 0x040066EA RID: 26346
		[global::Cpp2ILInjected.Token(Token = "0x4007BB6")]
		private const double DOUBLE_CLICK_TIME = 500.0;

		// Token: 0x040066EB RID: 26347
		[global::Cpp2ILInjected.Token(Token = "0x4007BB7")]
		private const double STATE_CHANGE_CLICK_DISABLE_TIME = 200.0;

		// Token: 0x040066EC RID: 26348
		[global::Cpp2ILInjected.Token(Token = "0x4007BB8")]
		private const int MAX_HISTORY_SIZE = 32;

		// Token: 0x040066ED RID: 26349
		[global::Cpp2ILInjected.Token(Token = "0x4007BB9")]
		private const int HISTORY_PRUNE_SIZE = 4;

		// Token: 0x040066EE RID: 26350
		[global::Cpp2ILInjected.Token(Token = "0x4007BBA")]
		public static UserInterface ActiveInstance;

		// Token: 0x040066EF RID: 26351
		[global::Cpp2ILInjected.Token(Token = "0x4007BBB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<UIState> _history;

		// Token: 0x040066F0 RID: 26352
		[global::Cpp2ILInjected.Token(Token = "0x4007BBC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private UserInterface.InputPointerCache LeftMouse;

		// Token: 0x040066F1 RID: 26353
		[global::Cpp2ILInjected.Token(Token = "0x4007BBD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private UserInterface.InputPointerCache RightMouse;

		// Token: 0x040066F2 RID: 26354
		[global::Cpp2ILInjected.Token(Token = "0x4007BBE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Vector2 MousePosition;

		// Token: 0x040066F3 RID: 26355
		[global::Cpp2ILInjected.Token(Token = "0x4007BBF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private UIElement _lastElementHover;

		// Token: 0x040066F4 RID: 26356
		[global::Cpp2ILInjected.Token(Token = "0x4007BC0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private double _clickDisabledTimeRemaining;

		// Token: 0x040066F5 RID: 26357
		[global::Cpp2ILInjected.Token(Token = "0x4007BC1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool _isStateDirty;

		// Token: 0x040066F6 RID: 26358
		[global::Cpp2ILInjected.Token(Token = "0x4007BC2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
		public bool IsVisible;

		// Token: 0x040066F7 RID: 26359
		[global::Cpp2ILInjected.Token(Token = "0x4007BC3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private UIState _currentState;

		// Token: 0x0200095E RID: 2398
		// (Invoke) Token: 0x06004D2B RID: 19755
		[global::Cpp2ILInjected.Token(Token = "0x2000728")]
		private delegate void MouseElementEvent(UIElement element, UIMouseEvent evt);

		// Token: 0x0200095F RID: 2399
		[global::Cpp2ILInjected.Token(Token = "0x2000729")]
		private class InputPointerCache
		{
			// Token: 0x06004D2E RID: 19758 RVA: 0x0002FA17 File Offset: 0x0002DC17
			[global::Cpp2ILInjected.Token(Token = "0x6003CAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1491FE4", Offset = "0x1491FE4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Clear()
			{
				throw null;
			}

			// Token: 0x06004D2F RID: 19759 RVA: 0x0002FA1A File Offset: 0x0002DC1A
			[global::Cpp2ILInjected.Token(Token = "0x6003CAF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1492548", Offset = "0x1492548", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public InputPointerCache()
			{
				throw null;
			}

			// Token: 0x04008B82 RID: 35714
			[global::Cpp2ILInjected.Token(Token = "0x4007BC4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public double LastTimeDown;

			// Token: 0x04008B83 RID: 35715
			[global::Cpp2ILInjected.Token(Token = "0x4007BC5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public bool WasDown;

			// Token: 0x04008B84 RID: 35716
			[global::Cpp2ILInjected.Token(Token = "0x4007BC6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public UIElement LastDown;

			// Token: 0x04008B85 RID: 35717
			[global::Cpp2ILInjected.Token(Token = "0x4007BC7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public UIElement LastClicked;

			// Token: 0x04008B86 RID: 35718
			[global::Cpp2ILInjected.Token(Token = "0x4007BC8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public UserInterface.MouseElementEvent MouseDownEvent;

			// Token: 0x04008B87 RID: 35719
			[global::Cpp2ILInjected.Token(Token = "0x4007BC9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public UserInterface.MouseElementEvent MouseUpEvent;

			// Token: 0x04008B88 RID: 35720
			[global::Cpp2ILInjected.Token(Token = "0x4007BCA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public UserInterface.MouseElementEvent ClickEvent;

			// Token: 0x04008B89 RID: 35721
			[global::Cpp2ILInjected.Token(Token = "0x4007BCB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			public UserInterface.MouseElementEvent DoubleClickEvent;
		}

		// Token: 0x02000960 RID: 2400
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200072A")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004D30 RID: 19760 RVA: 0x0002FA1D File Offset: 0x0002DC1D
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

			// Token: 0x06004D31 RID: 19761 RVA: 0x0002FA20 File Offset: 0x0002DC20
			[global::Cpp2ILInjected.Token(Token = "0x6003CB1")]
			[global::Cpp2ILInjected.Address(RVA = "0x149349C", Offset = "0x149349C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004D32 RID: 19762 RVA: 0x0002FA23 File Offset: 0x0002DC23
			[global::Cpp2ILInjected.Token(Token = "0x6003CB2")]
			[global::Cpp2ILInjected.Address(RVA = "0x14934A4", Offset = "0x14934A4", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void <.ctor>b__21_0(UIElement element, UIMouseEvent evt)
			{
				throw null;
			}

			// Token: 0x06004D33 RID: 19763 RVA: 0x0002FA26 File Offset: 0x0002DC26
			[global::Cpp2ILInjected.Token(Token = "0x6003CB3")]
			[global::Cpp2ILInjected.Address(RVA = "0x14934C0", Offset = "0x14934C0", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void <.ctor>b__21_1(UIElement element, UIMouseEvent evt)
			{
				throw null;
			}

			// Token: 0x06004D34 RID: 19764 RVA: 0x0002FA29 File Offset: 0x0002DC29
			[global::Cpp2ILInjected.Token(Token = "0x6003CB4")]
			[global::Cpp2ILInjected.Address(RVA = "0x14934DC", Offset = "0x14934DC", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void <.ctor>b__21_2(UIElement element, UIMouseEvent evt)
			{
				throw null;
			}

			// Token: 0x06004D35 RID: 19765 RVA: 0x0002FA2C File Offset: 0x0002DC2C
			[global::Cpp2ILInjected.Token(Token = "0x6003CB5")]
			[global::Cpp2ILInjected.Address(RVA = "0x14934F8", Offset = "0x14934F8", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void <.ctor>b__21_3(UIElement element, UIMouseEvent evt)
			{
				throw null;
			}

			// Token: 0x06004D36 RID: 19766 RVA: 0x0002FA2F File Offset: 0x0002DC2F
			[global::Cpp2ILInjected.Token(Token = "0x6003CB6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1493514", Offset = "0x1493514", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void <.ctor>b__21_4(UIElement element, UIMouseEvent evt)
			{
				throw null;
			}

			// Token: 0x06004D37 RID: 19767 RVA: 0x0002FA32 File Offset: 0x0002DC32
			[global::Cpp2ILInjected.Token(Token = "0x6003CB7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1493530", Offset = "0x1493530", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void <.ctor>b__21_5(UIElement element, UIMouseEvent evt)
			{
				throw null;
			}

			// Token: 0x06004D38 RID: 19768 RVA: 0x0002FA35 File Offset: 0x0002DC35
			[global::Cpp2ILInjected.Token(Token = "0x6003CB8")]
			[global::Cpp2ILInjected.Address(RVA = "0x149354C", Offset = "0x149354C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void <.ctor>b__21_6(UIElement element, UIMouseEvent evt)
			{
				throw null;
			}

			// Token: 0x06004D39 RID: 19769 RVA: 0x0002FA38 File Offset: 0x0002DC38
			[global::Cpp2ILInjected.Token(Token = "0x6003CB9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1493568", Offset = "0x1493568", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void <.ctor>b__21_7(UIElement element, UIMouseEvent evt)
			{
				throw null;
			}

			// Token: 0x04008B8A RID: 35722
			[global::Cpp2ILInjected.Token(Token = "0x4007BCC")]
			public static readonly UserInterface.<>c <>9;

			// Token: 0x04008B8B RID: 35723
			[global::Cpp2ILInjected.Token(Token = "0x4007BCD")]
			public static UserInterface.MouseElementEvent <>9__21_0;

			// Token: 0x04008B8C RID: 35724
			[global::Cpp2ILInjected.Token(Token = "0x4007BCE")]
			public static UserInterface.MouseElementEvent <>9__21_1;

			// Token: 0x04008B8D RID: 35725
			[global::Cpp2ILInjected.Token(Token = "0x4007BCF")]
			public static UserInterface.MouseElementEvent <>9__21_2;

			// Token: 0x04008B8E RID: 35726
			[global::Cpp2ILInjected.Token(Token = "0x4007BD0")]
			public static UserInterface.MouseElementEvent <>9__21_3;

			// Token: 0x04008B8F RID: 35727
			[global::Cpp2ILInjected.Token(Token = "0x4007BD1")]
			public static UserInterface.MouseElementEvent <>9__21_4;

			// Token: 0x04008B90 RID: 35728
			[global::Cpp2ILInjected.Token(Token = "0x4007BD2")]
			public static UserInterface.MouseElementEvent <>9__21_5;

			// Token: 0x04008B91 RID: 35729
			[global::Cpp2ILInjected.Token(Token = "0x4007BD3")]
			public static UserInterface.MouseElementEvent <>9__21_6;

			// Token: 0x04008B92 RID: 35730
			[global::Cpp2ILInjected.Token(Token = "0x4007BD4")]
			public static UserInterface.MouseElementEvent <>9__21_7;
		}
	}
}
