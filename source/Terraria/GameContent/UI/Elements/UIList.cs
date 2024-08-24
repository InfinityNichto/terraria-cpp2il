using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Achievements;
using Terraria.GameContent.UI.States;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006DC RID: 1756
	[global::Cpp2ILInjected.Token(Token = "0x2000AC2")]
	public class UIList : UIElement, IEnumerable<UIElement>, IEnumerable
	{
		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x060044AA RID: 17578 RVA: 0x0002E499 File Offset: 0x0002C699
		[global::Cpp2ILInjected.Token(Token = "0x170008C7")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005103")]
			[global::Cpp2ILInjected.Address(RVA = "0x92B444", Offset = "0x92B444", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060044AB RID: 17579 RVA: 0x0002E49C File Offset: 0x0002C69C
		[global::Cpp2ILInjected.Token(Token = "0x6005104")]
		[global::Cpp2ILInjected.Address(RVA = "0x92B484", Offset = "0x92B484", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementsMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryInfoPage), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildInfinitesMenuContents", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIList.UIInnerList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public UIList()
		{
			throw null;
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x0002E49F File Offset: 0x0002C69F
		[global::Cpp2ILInjected.Token(Token = "0x6005105")]
		[global::Cpp2ILInjected.Address(RVA = "0x92B60C", Offset = "0x92B60C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float GetTotalHeight()
		{
			throw null;
		}

		// Token: 0x060044AD RID: 17581 RVA: 0x0002E4A2 File Offset: 0x0002C6A2
		[global::Cpp2ILInjected.Token(Token = "0x6005106")]
		[global::Cpp2ILInjected.Address(RVA = "0x92B614", Offset = "0x92B614", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementsMenu), Member = "GotoAchievement", MemberParameters = new object[] { typeof(Achievement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Goto(UIList.ElementSearchMethod searchMethod)
		{
			throw null;
		}

		// Token: 0x060044AE RID: 17582 RVA: 0x0002E4A5 File Offset: 0x0002C6A5
		[global::Cpp2ILInjected.Token(Token = "0x6005107")]
		[global::Cpp2ILInjected.Address(RVA = "0x92B71C", Offset = "0x92B71C", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIList), Member = "UpdateOrder", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual void Add(UIElement item)
		{
			throw null;
		}

		// Token: 0x060044AF RID: 17583 RVA: 0x0002E4A8 File Offset: 0x0002C6A8
		[global::Cpp2ILInjected.Token(Token = "0x6005108")]
		[global::Cpp2ILInjected.Address(RVA = "0x92B8C0", Offset = "0x92B8C0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RemoveChild", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIList), Member = "UpdateOrder", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual bool Remove(UIElement item)
		{
			throw null;
		}

		// Token: 0x060044B0 RID: 17584 RVA: 0x0002E4AB File Offset: 0x0002C6AB
		[global::Cpp2ILInjected.Token(Token = "0x6005109")]
		[global::Cpp2ILInjected.Address(RVA = "0x92B930", Offset = "0x92B930", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RemoveAllChildren", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Clear()
		{
			throw null;
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x0002E4AE File Offset: 0x0002C6AE
		[global::Cpp2ILInjected.Token(Token = "0x600510A")]
		[global::Cpp2ILInjected.Address(RVA = "0x92B9A4", Offset = "0x92B9A4", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIScrollbar), Member = "SetView", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public override void Recalculate()
		{
			throw null;
		}

		// Token: 0x060044B2 RID: 17586 RVA: 0x0002E4B1 File Offset: 0x0002C6B1
		[global::Cpp2ILInjected.Token(Token = "0x600510B")]
		[global::Cpp2ILInjected.Address(RVA = "0x92B9F0", Offset = "0x92B9F0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "ScrollWheel", MemberParameters = new object[] { typeof(UIScrollWheelEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public override void ScrollWheel(UIScrollWheelEvent evt)
		{
			throw null;
		}

		// Token: 0x060044B3 RID: 17587 RVA: 0x0002E4B4 File Offset: 0x0002C6B4
		[global::Cpp2ILInjected.Token(Token = "0x600510C")]
		[global::Cpp2ILInjected.Address(RVA = "0x92BA48", Offset = "0x92BA48", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RecalculateChildren", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void RecalculateChildren()
		{
			throw null;
		}

		// Token: 0x060044B4 RID: 17588 RVA: 0x0002E4B7 File Offset: 0x0002C6B7
		[global::Cpp2ILInjected.Token(Token = "0x600510D")]
		[global::Cpp2ILInjected.Address(RVA = "0x92B9D4", Offset = "0x92B9D4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIScrollbar), Member = "SetView", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		private void UpdateScrollbar()
		{
			throw null;
		}

		// Token: 0x060044B5 RID: 17589 RVA: 0x0002E4BA File Offset: 0x0002C6BA
		[global::Cpp2ILInjected.Token(Token = "0x600510E")]
		[global::Cpp2ILInjected.Address(RVA = "0x92BBA0", Offset = "0x92BBA0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementsMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryInfoPage), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildInfinitesMenuContents", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIScrollbar), Member = "SetView", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public void SetScrollbar(UIScrollbar scrollbar)
		{
			throw null;
		}

		// Token: 0x060044B6 RID: 17590 RVA: 0x0002E4BD File Offset: 0x0002C6BD
		[global::Cpp2ILInjected.Token(Token = "0x600510F")]
		[global::Cpp2ILInjected.Address(RVA = "0x92B7E0", Offset = "0x92B7E0", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementsMenu), Member = "OnActivate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIList), Member = "Add", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIList), Member = "Remove", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIScrollbar), Member = "SetView", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void UpdateOrder()
		{
			throw null;
		}

		// Token: 0x060044B7 RID: 17591 RVA: 0x0002E4C0 File Offset: 0x0002C6C0
		[global::Cpp2ILInjected.Token(Token = "0x6005110")]
		[global::Cpp2ILInjected.Address(RVA = "0x92BBBC", Offset = "0x92BBBC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int SortMethod(UIElement item1, UIElement item2)
		{
			throw null;
		}

		// Token: 0x060044B8 RID: 17592 RVA: 0x0002E4C3 File Offset: 0x0002C6C3
		[global::Cpp2ILInjected.Token(Token = "0x6005111")]
		[global::Cpp2ILInjected.Address(RVA = "0x92BBD8", Offset = "0x92BBD8", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "GetSnapPoint", MemberParameters = new object[] { typeof(ref SnapPoint) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override List<SnapPoint> GetSnapPoints()
		{
			throw null;
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x0002E4C6 File Offset: 0x0002C6C6
		[global::Cpp2ILInjected.Token(Token = "0x6005112")]
		[global::Cpp2ILInjected.Address(RVA = "0x92BDF4", Offset = "0x92BDF4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x060044BA RID: 17594 RVA: 0x0002E4C9 File Offset: 0x0002C6C9
		[global::Cpp2ILInjected.Token(Token = "0x6005113")]
		[global::Cpp2ILInjected.Address(RVA = "0x92BE34", Offset = "0x92BE34", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public IEnumerator<UIElement> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060044BB RID: 17595 RVA: 0x0002E4CC File Offset: 0x0002C6CC
		[global::Cpp2ILInjected.Token(Token = "0x6005114")]
		[global::Cpp2ILInjected.Address(RVA = "0x92BECC", Offset = "0x92BECC", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x04007071 RID: 28785
		[global::Cpp2ILInjected.Token(Token = "0x40089BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		protected List<UIElement> _items;

		// Token: 0x04007072 RID: 28786
		[global::Cpp2ILInjected.Token(Token = "0x40089BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		protected UIScrollbar _scrollbar;

		// Token: 0x04007073 RID: 28787
		[global::Cpp2ILInjected.Token(Token = "0x40089BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private UIElement _innerList;

		// Token: 0x04007074 RID: 28788
		[global::Cpp2ILInjected.Token(Token = "0x40089C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private float _innerListHeight;

		// Token: 0x04007075 RID: 28789
		[global::Cpp2ILInjected.Token(Token = "0x40089C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x164")]
		public float ListPadding;

		// Token: 0x04007076 RID: 28790
		[global::Cpp2ILInjected.Token(Token = "0x40089C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		public Action<List<UIElement>> ManualSortMethod;

		// Token: 0x02000AC2 RID: 2754
		// (Invoke) Token: 0x06005286 RID: 21126
		[global::Cpp2ILInjected.Token(Token = "0x2000AC3")]
		public delegate bool ElementSearchMethod(UIElement element);

		// Token: 0x02000AC3 RID: 2755
		[global::Cpp2ILInjected.Token(Token = "0x2000AC4")]
		private class UIInnerList : UIElement
		{
			// Token: 0x06005289 RID: 21129 RVA: 0x000308E1 File Offset: 0x0002EAE1
			[global::Cpp2ILInjected.Token(Token = "0x6005119")]
			[global::Cpp2ILInjected.Address(RVA = "0x92C0E4", Offset = "0x92C0E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool ContainsPoint(Vector2 point)
			{
				throw null;
			}

			// Token: 0x0600528A RID: 21130 RVA: 0x000308E4 File Offset: 0x0002EAE4
			[global::Cpp2ILInjected.Token(Token = "0x600511A")]
			[global::Cpp2ILInjected.Address(RVA = "0x92C0EC", Offset = "0x92C0EC", Length = "0x240")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "Position", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "CheckAABBvAABBCollision", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			protected override void DrawChildren(SpriteBatch spriteBatch)
			{
				throw null;
			}

			// Token: 0x0600528B RID: 21131 RVA: 0x000308E7 File Offset: 0x0002EAE7
			[global::Cpp2ILInjected.Token(Token = "0x600511B")]
			[global::Cpp2ILInjected.Address(RVA = "0x92C32C", Offset = "0x92C32C", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "ToRectangle", ReturnType = typeof(Rectangle))]
			public override Rectangle GetViewCullingArea()
			{
				throw null;
			}

			// Token: 0x0600528C RID: 21132 RVA: 0x000308EA File Offset: 0x0002EAEA
			[global::Cpp2ILInjected.Token(Token = "0x600511C")]
			[global::Cpp2ILInjected.Address(RVA = "0x92B5B4", Offset = "0x92B5B4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIList), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public UIInnerList()
			{
				throw null;
			}
		}
	}
}
