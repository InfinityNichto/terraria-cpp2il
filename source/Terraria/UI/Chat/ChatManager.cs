using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Chat;
using Terraria.GameContent.Animations;
using Terraria.GameContent.UI;
using Terraria.GameContent.UI.Chat;
using Terraria.GameContent.UI.Elements;
using Terraria.Graphics.Capture;
using Terraria.Initializers;

namespace Terraria.UI.Chat
{
	// Token: 0x020004D9 RID: 1241
	[global::Cpp2ILInjected.Token(Token = "0x200072D")]
	public static class ChatManager
	{
		// Token: 0x06003667 RID: 13927 RVA: 0x0002BB7D File Offset: 0x00029D7D
		[global::Cpp2ILInjected.Token(Token = "0x6003CC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1493A74", Offset = "0x1493A74", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextSnippet), Member = "GetVisibleColor", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Color WaveColor(Color color)
		{
			throw null;
		}

		// Token: 0x06003668 RID: 13928 RVA: 0x0002BB80 File Offset: 0x00029D80
		[global::Cpp2ILInjected.Token(Token = "0x6003CC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1493B44", Offset = "0x1493B44", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawColorCodedStringWithShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIText), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlainTagHandler.PlainSnippet), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void ConvertNormalSnippets(TextSnippet[] snippets)
		{
			throw null;
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x0002BB83 File Offset: 0x00029D83
		[global::Cpp2ILInjected.Token(Token = "0x6003CC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1576AF0", Offset = "0x1576AF0", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Register<T>(params string[] names) where T : ITagHandler, new()
		{
			throw null;
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x0002BB86 File Offset: 0x00029D86
		[global::Cpp2ILInjected.Token(Token = "0x6003CCA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1493CA0", Offset = "0x1493CA0", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "ParseMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(TextSnippet[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static ITagHandler GetHandler(string tagName)
		{
			throw null;
		}

		// Token: 0x0600366B RID: 13931 RVA: 0x0002BB89 File Offset: 0x00029D89
		[global::Cpp2ILInjected.Token(Token = "0x6003CCB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1493D7C", Offset = "0x1493D7C", Length = "0x800")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player.OverheadMessage), Member = "NewMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "WordwrapStringSmart", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(SpriteFont),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(List<List<TextSnippet>>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "GetStringSize", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawColorCodedStringWithShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIText), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyChatMonitor), Member = "NewTextInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileChatMonitor), Member = "NewTextInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Matches", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(MatchCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MatchCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextSnippet), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Group))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Capture), Member = "get_Value", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "GetHandler", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ITagHandler))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		public static TextSnippet[] ParseMessage(string text, Color baseColor, float maxWidth = -1f)
		{
			throw null;
		}

		// Token: 0x0600366C RID: 13932 RVA: 0x0002BB8C File Offset: 0x00029D8C
		[global::Cpp2ILInjected.Token(Token = "0x6003CCC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1494614", Offset = "0x1494614", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "OverrideLeftClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool AddChatText(SpriteFont font, string text, Vector2 baseScale)
		{
			throw null;
		}

		// Token: 0x0600366D RID: 13933 RVA: 0x0002BB8F File Offset: 0x00029D8F
		[global::Cpp2ILInjected.Token(Token = "0x6003CCD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1494698", Offset = "0x1494698", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
		{
			typeof(StringButton_Layout),
			typeof(string),
			typeof(ref float),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutCalculator), Member = "GetChatManagerAlignmentOffset", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(float),
			typeof(LayoutCalculator.AnchorType)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "DrawTitle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_14_EntityHealthBars", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawMoney", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(string),
			typeof(float),
			typeof(float),
			typeof(int[]),
			typeof(bool),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomCurrencySingleCoin), Member = "DrawSavingsMoney", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(string),
			typeof(float),
			typeof(float),
			typeof(long),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementListItem), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIKeybindingSimpleListItem), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "ParseMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(TextSnippet[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Vector2 GetStringSize(SpriteFont font, string text, Vector2 baseScale, float maxWidth = -1f)
		{
			throw null;
		}

		// Token: 0x0600366E RID: 13934 RVA: 0x0002BB92 File Offset: 0x00029D92
		[global::Cpp2ILInjected.Token(Token = "0x6003CCE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1494764", Offset = "0x1494764", Length = "0x8B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "CalulatePageSnippetSize", MemberParameters = new object[] { typeof(TextSnippet[]) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "CalulateMiniSnippetSize", MemberParameters = new object[] { typeof(TextSnippet[]) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "CalulateMiniTouchSnippetSize", MemberParameters = new object[] { typeof(TextSnippet[]) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "DrawNotification", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINPCDialogue), Member = "UpdateText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutCalculator), Member = "GetChatManagerAlignmentOffset", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(TextSnippet[]),
			typeof(float),
			typeof(LayoutCalculator.AnchorType),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player.OverheadMessage), Member = "NewMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "GetMaxCharacterIndex", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Between", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public static Vector2 GetStringSize(SpriteFont font, TextSnippet[] snippets, Vector2 baseScale, float maxWidth = -1f)
		{
			throw null;
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x0002BB95 File Offset: 0x00029D95
		[global::Cpp2ILInjected.Token(Token = "0x6003CCF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1495014", Offset = "0x1495014", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawColorCodedStringWithShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(TextSnippet[]),
			typeof(Vector2),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(ref int),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawColorCodedStringWithShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIText), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawColorCodedString", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(TextSnippet[]),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(ref int),
			typeof(float),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void DrawColorCodedStringShadow(SpriteBatch spriteBatch, SpriteFont font, TextSnippet[] snippets, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f, int maxLines = 100)
		{
			throw null;
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x0002BB98 File Offset: 0x00029D98
		[global::Cpp2ILInjected.Token(Token = "0x6003CD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x14951BC", Offset = "0x14951BC", Length = "0xE38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawColorCodedStringShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(TextSnippet[]),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawColorCodedStringWithShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(TextSnippet[]),
			typeof(Vector2),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(ref int),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawColorCodedStringWithShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIText), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Between", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "GetMaxCharacterIndex", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public static Vector2 DrawColorCodedString(SpriteBatch spriteBatch, SpriteFont font, TextSnippet[] snippets, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, out int hoveredSnippet, float maxWidth, bool ignoreColors = false, int maxLines = 100)
		{
			throw null;
		}

		// Token: 0x06003671 RID: 13937 RVA: 0x0002BB9B File Offset: 0x00029D9B
		[global::Cpp2ILInjected.Token(Token = "0x6003CD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1495FF4", Offset = "0x1495FF4", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
		{
			typeof(String_Layout),
			typeof(TextSnippet[]),
			typeof(ref int),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawPlayerChatBubbles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyChatMonitor), Member = "DrawChat", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileChatMonitor), Member = "DrawChat", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemadeChatMonitor), Member = "DrawChat", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawColorCodedStringShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(TextSnippet[]),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawColorCodedString", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(TextSnippet[]),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(ref int),
			typeof(float),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Vector2 DrawColorCodedStringWithShadow(SpriteBatch spriteBatch, SpriteFont font, TextSnippet[] snippets, Vector2 position, float rotation, Vector2 origin, Vector2 baseScale, out int hoveredSnippet, float maxWidth = -1f, float spread = 2f, int maxLines = 100)
		{
			throw null;
		}

		// Token: 0x06003672 RID: 13938 RVA: 0x0002BB9E File Offset: 0x00029D9E
		[global::Cpp2ILInjected.Token(Token = "0x6003CD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1496168", Offset = "0x1496168", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawStringWithShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Segments.LocalizedTextSegment), Member = "Draw", MemberParameters = new object[] { typeof(ref GameAnimationSegment) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void DrawColorCodedStringShadow(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f)
		{
			throw null;
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x0002BBA1 File Offset: 0x00029DA1
		[global::Cpp2ILInjected.Token(Token = "0x6003CD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1496A18", Offset = "0x1496A18", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_14_EntityHealthBars", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawStringWithShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawColorCodedString", MemberParameters = new object[]
		{
			typeof(Vector2[]),
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void DrawColorCodedStringShadow(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f, int maxLines = 100)
		{
			throw null;
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x0002BBA4 File Offset: 0x00029DA4
		[global::Cpp2ILInjected.Token(Token = "0x6003CD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1496BA8", Offset = "0x1496BA8", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawStringWithShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void DrawColorCodedStringShadow(SpriteBatch spriteBatch, SpriteFont font, StringBuilder text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f)
		{
			throw null;
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x0002BBA7 File Offset: 0x00029DA7
		[global::Cpp2ILInjected.Token(Token = "0x6003CD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x14971E8", Offset = "0x14971E8", Length = "0x730")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_14_EntityHealthBars", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawStringWithShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawStringWithShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Segments.LocalizedTextSegment), Member = "Draw", MemberParameters = new object[] { typeof(ref GameAnimationSegment) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static void DrawColorCodedString(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, bool ignoreColors = false, int maxLines = 100)
		{
			throw null;
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x0002BBAA File Offset: 0x00029DAA
		[global::Cpp2ILInjected.Token(Token = "0x6003CD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x14962F4", Offset = "0x14962F4", Length = "0x724")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawColorCodedStringShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static void DrawColorCodedString(Vector2[] offsets, SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, bool ignoreColors = false, int maxLines = 100)
		{
			throw null;
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x0002BBAD File Offset: 0x00029DAD
		[global::Cpp2ILInjected.Token(Token = "0x6003CD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1497918", Offset = "0x1497918", Length = "0x4B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawStringWithShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static Vector2 DrawColorCodedString(SpriteBatch spriteBatch, SpriteFont font, StringBuilder text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, bool ignoreColors = false)
		{
			throw null;
		}

		// Token: 0x06003678 RID: 13944 RVA: 0x0002BBB0 File Offset: 0x00029DB0
		[global::Cpp2ILInjected.Token(Token = "0x6003CD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1496D30", Offset = "0x1496D30", Length = "0x4B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static Vector2 DrawColorCodedString(Vector2[] offsets, SpriteBatch spriteBatch, SpriteFont font, StringBuilder text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, bool ignoreColors = false)
		{
			throw null;
		}

		// Token: 0x06003679 RID: 13945 RVA: 0x0002BBB3 File Offset: 0x00029DB3
		[global::Cpp2ILInjected.Token(Token = "0x6003CD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1497DCC", Offset = "0x1497DCC", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_14_EntityHealthBars", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "DrawBorderString", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChestUI), Member = "DrawName", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChestUI), Member = "DrawButton", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface.ModeChangeSettings", Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaptureInterface), Member = "DrawCameraLock", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyMultiplayerClosePlayersOverlay), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementListItem), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIKeybindingSimpleListItem), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIKeybindingToggleListItem), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "ParseMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(TextSnippet[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "ConvertNormalSnippets", MemberParameters = new object[] { typeof(TextSnippet[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawColorCodedStringShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(TextSnippet[]),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawColorCodedString", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(TextSnippet[]),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(ref int),
			typeof(float),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void DrawColorCodedStringWithShadow(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f)
		{
			throw null;
		}

		// Token: 0x0600367A RID: 13946 RVA: 0x0002BBB6 File Offset: 0x00029DB6
		[global::Cpp2ILInjected.Token(Token = "0x6003CDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1497F8C", Offset = "0x1497F8C", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPopoutMenu), Member = "DrawMenu", MemberParameters = new object[]
		{
			typeof(PopoutMenu_Layout),
			typeof(string[]),
			typeof(ref Rectangle)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
		{
			typeof(String_Layout),
			typeof(string),
			typeof(Color),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIString), Member = "DrawWithShadow", MemberParameters = new object[]
		{
			typeof(String_Layout),
			typeof(string),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIString), Member = "DrawButton", MemberParameters = new object[]
		{
			typeof(String_Layout),
			typeof(string),
			typeof(Color)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
		{
			typeof(StringButton_Layout),
			typeof(string),
			typeof(ref float),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "MaterialItemTooltipDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "MaterialItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "DrawItem", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ItemGrid_Layout),
			typeof(Item[]),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforgePopup), Member = "DrawPrefixes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameTipsDisplay), Member = "Draw", MemberParameters = new object[]
		{
			typeof(String_Layout),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawColorCodedStringShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawColorCodedString", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void DrawStringWithShadow(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f)
		{
			throw null;
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x0002BBB9 File Offset: 0x00029DB9
		[global::Cpp2ILInjected.Token(Token = "0x6003CDB")]
		[global::Cpp2ILInjected.Address(RVA = "0x149813C", Offset = "0x149813C", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = "AchievementDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawColorCodedStringShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawColorCodedString", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void DrawStringWithShadow(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f, int maxLines = 100)
		{
			throw null;
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x0002BBBC File Offset: 0x00029DBC
		[global::Cpp2ILInjected.Token(Token = "0x6003CDC")]
		[global::Cpp2ILInjected.Address(RVA = "0x14982FC", Offset = "0x14982FC", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
		{
			typeof(String_Layout),
			typeof(StringBuilder),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "DrawHotbarItem", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ItemGrid_Layout),
			typeof(Item[]),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "DrawItem", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ItemGrid_Layout),
			typeof(Item[]),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawColorCodedStringShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawColorCodedString", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void DrawStringWithShadow(SpriteBatch spriteBatch, SpriteFont font, StringBuilder text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f)
		{
			throw null;
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x0002BBBF File Offset: 0x00029DBF
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003CDD")]
		[global::Cpp2ILInjected.Address(RVA = "0x14984A8", Offset = "0x14984A8", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatCommandProcessor), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		static ChatManager()
		{
			throw null;
		}

		// Token: 0x04006709 RID: 26377
		[global::Cpp2ILInjected.Token(Token = "0x4007BE6")]
		public static readonly ChatCommandProcessor Commands;

		// Token: 0x0400670A RID: 26378
		[global::Cpp2ILInjected.Token(Token = "0x4007BE7")]
		private static ConcurrentDictionary<string, ITagHandler> _handlers;

		// Token: 0x0400670B RID: 26379
		[global::Cpp2ILInjected.Token(Token = "0x4007BE8")]
		private static Vector2[] ShadowDirectionsScaled;

		// Token: 0x0400670C RID: 26380
		[global::Cpp2ILInjected.Token(Token = "0x4007BE9")]
		public static readonly Vector2[] ShadowDirections;

		// Token: 0x0400670D RID: 26381
		[global::Cpp2ILInjected.Token(Token = "0x4007BEA")]
		public static bool AllowColon;

		// Token: 0x0400670E RID: 26382
		[global::Cpp2ILInjected.Token(Token = "0x4007BEB")]
		public static SpriteBatch overloadedSpriteBatch;

		// Token: 0x02000961 RID: 2401
		[global::Cpp2ILInjected.Token(Token = "0x200072E")]
		public static class Regexes
		{
			// Token: 0x06004D3A RID: 19770 RVA: 0x0002FA3B File Offset: 0x0002DC3B
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003CDE")]
			[global::Cpp2ILInjected.Address(RVA = "0x14986F0", Offset = "0x14986F0", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(RegexOptions)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			static Regexes()
			{
				throw null;
			}

			// Token: 0x04008B93 RID: 35731
			[global::Cpp2ILInjected.Token(Token = "0x4007BEC")]
			public static readonly Regex Format;
		}
	}
}
