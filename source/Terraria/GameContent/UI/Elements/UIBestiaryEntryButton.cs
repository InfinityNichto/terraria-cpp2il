using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	[global::Cpp2ILInjected.Token(Token = "0x2000A94")]
	public class UIBestiaryEntryButton : UIElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x170008BB")]
		public BestiaryEntry Entry
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004FF6")]
			[global::Cpp2ILInjected.Address(RVA = "0x905B4C", Offset = "0x905B4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004FF7")]
			[global::Cpp2ILInjected.Address(RVA = "0x905B54", Offset = "0x905B54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004FF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x905B5C", Offset = "0x905B5C", Length = "0x800")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryGrid), Member = "FillBestiarySpaceWithEntries", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetPadding", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImage), Member = ".ctor", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryButton), Member = "TryGettingBackgroundImageProvider", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(Asset<Texture2D>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryIcon), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(BestiaryEntry),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryButton), Member = "TryGettingDisplayIndex", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(int?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RemoveChild", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOver", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOut", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 44)]
		public UIBestiaryEntryButton(BestiaryEntry entry, bool isAPrettyPortrait)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004FF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x90635C", Offset = "0x90635C", Length = "0x870")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryButton), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(BestiaryEntry),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, bool>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Select", MemberTypeParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, object>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "OfType", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(IEnumerable) }, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
		private Asset<Texture2D> TryGettingBackgroundImageProvider(BestiaryEntry entry)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004FFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x906DF0", Offset = "0x906DF0", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryButton), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(BestiaryEntry),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "FirstOrDefault", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, bool>)
		}, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private int? TryGettingDisplayIndex(BestiaryEntry entry)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004FFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x906FB4", Offset = "0x906FB4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryIcon), Member = "GetHoverText", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(byte),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004FFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x907108", Offset = "0x907108", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RemoveChild", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		private void MouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004FFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x90719C", Offset = "0x90719C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RemoveChild", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		private void MouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40088DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private BestiaryEntry <Entry>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x40088DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private UIImage _bordersGlow;

		[global::Cpp2ILInjected.Token(Token = "0x40088DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private UIImage _bordersOverlay;

		[global::Cpp2ILInjected.Token(Token = "0x40088E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private UIImage _borders;

		[global::Cpp2ILInjected.Token(Token = "0x40088E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private UIBestiaryEntryIcon _icon;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000A95")]
		private sealed class <>c__DisplayClass9_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004FFE")]
			[global::Cpp2ILInjected.Address(RVA = "0x906FAC", Offset = "0x906FAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass9_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004FFF")]
			[global::Cpp2ILInjected.Address(RVA = "0x907200", Offset = "0x907200", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			internal bool <TryGettingBackgroundImageProvider>b__2(IBestiaryBackgroundImagePathAndColorProvider provider)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40088E2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public IEnumerable<IPreferenceProviderElement> preferences;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000A96")]
		private sealed class <>c__DisplayClass9_1
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005000")]
			[global::Cpp2ILInjected.Address(RVA = "0x9072D4", Offset = "0x9072D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass9_1()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005001")]
			[global::Cpp2ILInjected.Address(RVA = "0x9072DC", Offset = "0x9072DC", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal bool <TryGettingBackgroundImageProvider>b__3(IPreferenceProviderElement preference)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40088E3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public IBestiaryBackgroundImagePathAndColorProvider provider;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000A97")]
		[Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6005002")]
			[global::Cpp2ILInjected.Address(RVA = "0x907388", Offset = "0x907388", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005003")]
			[global::Cpp2ILInjected.Address(RVA = "0x9073E4", Offset = "0x9073E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005004")]
			[global::Cpp2ILInjected.Address(RVA = "0x9073EC", Offset = "0x9073EC", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool <TryGettingBackgroundImageProvider>b__9_0(IBestiaryInfoElement x)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005005")]
			[global::Cpp2ILInjected.Address(RVA = "0x907440", Offset = "0x907440", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal IBestiaryBackgroundImagePathAndColorProvider <TryGettingBackgroundImageProvider>b__9_1(IBestiaryInfoElement x)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005006")]
			[global::Cpp2ILInjected.Address(RVA = "0x907488", Offset = "0x907488", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool <TryGettingDisplayIndex>b__10_0(IBestiaryInfoElement x)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40088E4")]
			public static readonly UIBestiaryEntryButton.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x40088E5")]
			public static Func<IBestiaryInfoElement, bool> <>9__9_0;

			[global::Cpp2ILInjected.Token(Token = "0x40088E6")]
			public static Func<IBestiaryInfoElement, IBestiaryBackgroundImagePathAndColorProvider> <>9__9_1;

			[global::Cpp2ILInjected.Token(Token = "0x40088E7")]
			public static Func<IBestiaryInfoElement, bool> <>9__10_0;
		}
	}
}
