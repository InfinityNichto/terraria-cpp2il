using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000964")]
	public class UnlockProgressDisplayBestiaryInfoElement : IBestiaryInfoElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004812")]
		[global::Cpp2ILInjected.Address(RVA = "0x81E2E0", Offset = "0x81E2E0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public UnlockProgressDisplayBestiaryInfoElement(BestiaryUnlockProgressReport progressReport)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004813")]
		[global::Cpp2ILInjected.Address(RVA = "0x81E308", Offset = "0x81E308", Length = "0x44C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "PrettifyPercentDisplay", MemberParameters = new object[]
		{
			typeof(float),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "FromPixelsAndPercent", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(StyleDimension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = "set_IsWrapped", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnlockProgressDisplayBestiaryInfoElement), Member = "AddDynamicResize", MemberParameters = new object[]
		{
			typeof(UIElement),
			typeof(UIText)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004814")]
		[global::Cpp2ILInjected.Address(RVA = "0x81E754", Offset = "0x81E754", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnlockProgressDisplayBestiaryInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = "add_OnInternalTextChange", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void AddDynamicResize(UIElement container, UIText text)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40083A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private BestiaryUnlockProgressReport _progressReport;

		[global::Cpp2ILInjected.Token(Token = "0x40083A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private UIElement _text1;

		[global::Cpp2ILInjected.Token(Token = "0x40083A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private UIElement _text2;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000965")]
		private sealed class <>c__DisplayClass5_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004815")]
			[global::Cpp2ILInjected.Address(RVA = "0x81E814", Offset = "0x81E814", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass5_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004816")]
			[global::Cpp2ILInjected.Address(RVA = "0x81E81C", Offset = "0x81E81C", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			internal void <AddDynamicResize>b__0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40083A8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public UIElement container;

			[global::Cpp2ILInjected.Token(Token = "0x40083A9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public UnlockProgressDisplayBestiaryInfoElement <>4__this;
		}
	}
}
