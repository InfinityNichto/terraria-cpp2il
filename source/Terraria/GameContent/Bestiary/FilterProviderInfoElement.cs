using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000634 RID: 1588
	[global::Cpp2ILInjected.Token(Token = "0x2000957")]
	public class FilterProviderInfoElement : IFilterInfoProvider, IProvideSearchFilterString, IBestiaryInfoElement
	{
		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06003EC1 RID: 16065 RVA: 0x0002D344 File Offset: 0x0002B544
		// (set) Token: 0x06003EC2 RID: 16066 RVA: 0x0002D347 File Offset: 0x0002B547
		[global::Cpp2ILInjected.Token(Token = "0x17000826")]
		public int DisplayTextPriority
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60047D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x81CB64", Offset = "0x81CB64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60047D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x81CB6C", Offset = "0x81CB6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06003EC3 RID: 16067 RVA: 0x0002D34A File Offset: 0x0002B54A
		// (set) Token: 0x06003EC4 RID: 16068 RVA: 0x0002D34D File Offset: 0x0002B54D
		[global::Cpp2ILInjected.Token(Token = "0x17000827")]
		public bool HideInPortraitInfo
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60047D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x81CB74", Offset = "0x81CB74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60047D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x81CB7C", Offset = "0x81CB7C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x0002D350 File Offset: 0x0002B550
		[global::Cpp2ILInjected.Token(Token = "0x60047D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x81CB88", Offset = "0x81CB88", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public FilterProviderInfoElement(string nameLanguageKey, int filterIconFrame)
		{
			throw null;
		}

		// Token: 0x06003EC6 RID: 16070 RVA: 0x0002D353 File Offset: 0x0002B553
		[global::Cpp2ILInjected.Token(Token = "0x60047DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x81CBD0", Offset = "0x81CBD0", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FilterProviderInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageFramed), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public UIElement GetFilterImage()
		{
			throw null;
		}

		// Token: 0x06003EC7 RID: 16071 RVA: 0x0002D356 File Offset: 0x0002B556
		[global::Cpp2ILInjected.Token(Token = "0x60047DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x81CD84", Offset = "0x81CD84", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		public string GetSearchString(ref BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x06003EC8 RID: 16072 RVA: 0x0002D359 File Offset: 0x0002B559
		[global::Cpp2ILInjected.Token(Token = "0x60047DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x81CDB0", Offset = "0x81CDB0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public string GetDisplayNameKey()
		{
			throw null;
		}

		// Token: 0x06003EC9 RID: 16073 RVA: 0x0002D35C File Offset: 0x0002B55C
		[global::Cpp2ILInjected.Token(Token = "0x60047DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x81CDB8", Offset = "0x81CDB8", Length = "0x340")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetPadding", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FilterProviderInfoElement), Member = "GetFilterImage", ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FilterProviderInfoElement), Member = "AddOnHover", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x0002D35F File Offset: 0x0002B55F
		[global::Cpp2ILInjected.Token(Token = "0x60047DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D180", Offset = "0x81D180", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void GetDisplay(out Texture2D texture, out Rectangle frame)
		{
			throw null;
		}

		// Token: 0x06003ECB RID: 16075 RVA: 0x0002D362 File Offset: 0x0002B562
		[global::Cpp2ILInjected.Token(Token = "0x60047DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D0F8", Offset = "0x81D0F8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FilterProviderInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.ElementEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void AddOnHover(UIElement button)
		{
			throw null;
		}

		// Token: 0x06003ECC RID: 16076 RVA: 0x0002D365 File Offset: 0x0002B565
		[global::Cpp2ILInjected.Token(Token = "0x60047E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D308", Offset = "0x81D308", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FilterProviderInfoElement), Member = "<AddOnHover>b__18_0", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
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
		private void ShowButtonName(UIElement element)
		{
			throw null;
		}

		// Token: 0x06003ECD RID: 16077 RVA: 0x0002D368 File Offset: 0x0002B568
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x60047E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D3B4", Offset = "0x81D3B4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FilterProviderInfoElement), Member = "ShowButtonName", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		private void <AddOnHover>b__18_0(UIElement e)
		{
			throw null;
		}

		// Token: 0x04006C6E RID: 27758
		[global::Cpp2ILInjected.Token(Token = "0x400838D")]
		private const int framesPerRow = 16;

		// Token: 0x04006C6F RID: 27759
		[global::Cpp2ILInjected.Token(Token = "0x400838E")]
		private const int framesPerColumn = 5;

		// Token: 0x04006C70 RID: 27760
		[global::Cpp2ILInjected.Token(Token = "0x400838F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Point _filterIconFrame;

		// Token: 0x04006C71 RID: 27761
		[global::Cpp2ILInjected.Token(Token = "0x4008390")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _key;

		// Token: 0x04006C72 RID: 27762
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008391")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int <DisplayTextPriority>k__BackingField;

		// Token: 0x04006C73 RID: 27763
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008392")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private bool <HideInPortraitInfo>k__BackingField;
	}
}
