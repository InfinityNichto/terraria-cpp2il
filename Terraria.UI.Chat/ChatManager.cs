using System.Collections.Concurrent;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Chat;

namespace Terraria.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x20004DC")]
public static class ChatManager
{
	[Cpp2IlInjected.Token(Token = "0x2000958")]
	public static class Regexes
	{
		[Cpp2IlInjected.Token(Token = "0x4008B80")]
		public static readonly Regex Format;
	}

	[Cpp2IlInjected.Token(Token = "0x400670A")]
	public static readonly ChatCommandProcessor Commands;

	[Cpp2IlInjected.Token(Token = "0x400670B")]
	private static ConcurrentDictionary<string, ITagHandler> _handlers;

	[Cpp2IlInjected.Token(Token = "0x400670C")]
	private static Vector2[] ShadowDirectionsScaled;

	[Cpp2IlInjected.Token(Token = "0x400670D")]
	public static readonly Vector2[] ShadowDirections;

	[Cpp2IlInjected.Token(Token = "0x400670E")]
	public static bool AllowColon;

	[Cpp2IlInjected.Token(Token = "0x400670F")]
	public static SpriteBatch overloadedSpriteBatch;

	[Cpp2IlInjected.Token(Token = "0x60036A3")]
	[Cpp2IlInjected.Address(RVA = "0x14B3A54", Offset = "0x14B3A54", VA = "0x14B3A54")]
	public static Color WaveColor(Color color)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60036A4")]
	[Cpp2IlInjected.Address(RVA = "0x14B3B50", Offset = "0x14B3B50", VA = "0x14B3B50")]
	public static void ConvertNormalSnippets(TextSnippet[] snippets)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036A5")]
	[Cpp2IlInjected.Address(RVA = "0x15A6DC4", Offset = "0x15A6DC4", VA = "0x15A6DC4")]
	public static void Register<T>(params string[] names) where T : ITagHandler, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036A6")]
	[Cpp2IlInjected.Address(RVA = "0x14B3CC0", Offset = "0x14B3CC0", VA = "0x14B3CC0")]
	private static ITagHandler GetHandler(string tagName)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60036A7")]
	[Cpp2IlInjected.Address(RVA = "0x14B3DB8", Offset = "0x14B3DB8", VA = "0x14B3DB8")]
	public static TextSnippet[] ParseMessage(string text, Color baseColor, float maxWidth = -1f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60036A8")]
	[Cpp2IlInjected.Address(RVA = "0x14B4500", Offset = "0x14B4500", VA = "0x14B4500")]
	public static bool AddChatText(SpriteFont font, string text, Vector2 baseScale)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60036A9")]
	[Cpp2IlInjected.Address(RVA = "0x14B45A0", Offset = "0x14B45A0", VA = "0x14B45A0")]
	public static Vector2 GetStringSize(SpriteFont font, string text, Vector2 baseScale, float maxWidth = -1f)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60036AA")]
	[Cpp2IlInjected.Address(RVA = "0x14B4698", Offset = "0x14B4698", VA = "0x14B4698")]
	public static Vector2 GetStringSize(SpriteFont font, TextSnippet[] snippets, Vector2 baseScale, float maxWidth = -1f)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60036AB")]
	[Cpp2IlInjected.Address(RVA = "0x14B5254", Offset = "0x14B5254", VA = "0x14B5254")]
	public static void DrawColorCodedStringShadow(SpriteBatch spriteBatch, SpriteFont font, TextSnippet[] snippets, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f, int maxLines = 100)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036AC")]
	[Cpp2IlInjected.Address(RVA = "0x14B5438", Offset = "0x14B5438", VA = "0x14B5438")]
	public static Vector2 DrawColorCodedString(SpriteBatch spriteBatch, SpriteFont font, TextSnippet[] snippets, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, out int hoveredSnippet, float maxWidth, bool ignoreColors = false, int maxLines = 100)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60036AD")]
	[Cpp2IlInjected.Address(RVA = "0x14B6740", Offset = "0x14B6740", VA = "0x14B6740")]
	public static Vector2 DrawColorCodedStringWithShadow(SpriteBatch spriteBatch, SpriteFont font, TextSnippet[] snippets, Vector2 position, float rotation, Vector2 origin, Vector2 baseScale, out int hoveredSnippet, float maxWidth = -1f, float spread = 2f, int maxLines = 100)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60036AE")]
	[Cpp2IlInjected.Address(RVA = "0x14B68F8", Offset = "0x14B68F8", VA = "0x14B68F8")]
	public static void DrawColorCodedStringShadow(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036AF")]
	[Cpp2IlInjected.Address(RVA = "0x14B7484", Offset = "0x14B7484", VA = "0x14B7484")]
	public static void DrawColorCodedStringShadow(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f, int maxLines = 100)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036B0")]
	[Cpp2IlInjected.Address(RVA = "0x14B7694", Offset = "0x14B7694", VA = "0x14B7694")]
	public static void DrawColorCodedStringShadow(SpriteBatch spriteBatch, SpriteFont font, StringBuilder text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036B1")]
	[Cpp2IlInjected.Address(RVA = "0x14B7F2C", Offset = "0x14B7F2C", VA = "0x14B7F2C")]
	public static void DrawColorCodedString(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, bool ignoreColors = false, int maxLines = 100)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036B2")]
	[Cpp2IlInjected.Address(RVA = "0x14B6B08", Offset = "0x14B6B08", VA = "0x14B6B08")]
	public static void DrawColorCodedString(Vector2[] offsets, SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, bool ignoreColors = false, int maxLines = 100)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036B3")]
	[Cpp2IlInjected.Address(RVA = "0x14B8880", Offset = "0x14B8880", VA = "0x14B8880")]
	public static Vector2 DrawColorCodedString(SpriteBatch spriteBatch, SpriteFont font, StringBuilder text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, bool ignoreColors = false)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60036B4")]
	[Cpp2IlInjected.Address(RVA = "0x14B78A4", Offset = "0x14B78A4", VA = "0x14B78A4")]
	public static Vector2 DrawColorCodedString(Vector2[] offsets, SpriteBatch spriteBatch, SpriteFont font, StringBuilder text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, bool ignoreColors = false)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60036B5")]
	[Cpp2IlInjected.Address(RVA = "0x14B8EF4", Offset = "0x14B8EF4", VA = "0x14B8EF4")]
	public static void DrawColorCodedStringWithShadow(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036B6")]
	[Cpp2IlInjected.Address(RVA = "0x14B9124", Offset = "0x14B9124", VA = "0x14B9124")]
	public static void DrawStringWithShadow(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036B7")]
	[Cpp2IlInjected.Address(RVA = "0x14B9338", Offset = "0x14B9338", VA = "0x14B9338")]
	public static void DrawStringWithShadow(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f, int maxLines = 100)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036B8")]
	[Cpp2IlInjected.Address(RVA = "0x14B955C", Offset = "0x14B955C", VA = "0x14B955C")]
	public static void DrawStringWithShadow(SpriteBatch spriteBatch, SpriteFont font, StringBuilder text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f)
	{
	}
}
