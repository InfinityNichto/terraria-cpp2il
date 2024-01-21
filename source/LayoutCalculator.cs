using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x2000165")]
public static class LayoutCalculator
{
	[Cpp2IlInjected.Token(Token = "0x20007E0")]
	public enum AnchorFlags
	{
		[Cpp2IlInjected.Token(Token = "0x4007BF4")]
		Left = 1,
		[Cpp2IlInjected.Token(Token = "0x4007BF5")]
		CentreHorizontal = 2,
		[Cpp2IlInjected.Token(Token = "0x4007BF6")]
		Right = 4,
		[Cpp2IlInjected.Token(Token = "0x4007BF7")]
		Top = 8,
		[Cpp2IlInjected.Token(Token = "0x4007BF8")]
		CentreVertical = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4007BF9")]
		Bottom = 0x20
	}

	[Cpp2IlInjected.Token(Token = "0x20007E1")]
	public enum AnchorType
	{
		[Cpp2IlInjected.Token(Token = "0x4007BFB")]
		TopLeft = 9,
		[Cpp2IlInjected.Token(Token = "0x4007BFC")]
		TopCentre = 10,
		[Cpp2IlInjected.Token(Token = "0x4007BFD")]
		TopRight = 12,
		[Cpp2IlInjected.Token(Token = "0x4007BFE")]
		CentreLeft = 17,
		[Cpp2IlInjected.Token(Token = "0x4007BFF")]
		CentreBoth = 18,
		[Cpp2IlInjected.Token(Token = "0x4007C00")]
		CentreRight = 20,
		[Cpp2IlInjected.Token(Token = "0x4007C01")]
		BottomLeft = 33,
		[Cpp2IlInjected.Token(Token = "0x4007C02")]
		BottomCentre = 34,
		[Cpp2IlInjected.Token(Token = "0x4007C03")]
		BottomRight = 36
	}

	[Cpp2IlInjected.Token(Token = "0x4000DB4")]
	public static bool DrawSafeRegions;

	[Cpp2IlInjected.Token(Token = "0x4000DB5")]
	public static bool DrawPickingRegions;

	[Cpp2IlInjected.Token(Token = "0x4000DB6")]
	private static Texture2D _pickingRegion;

	[Cpp2IlInjected.Token(Token = "0x4000DB7")]
	private static Texture2D _pickingRegionCircle;

	[Cpp2IlInjected.Token(Token = "0x4000DB8")]
	private static Color _pickingRegionColour;

	[Cpp2IlInjected.Token(Token = "0x6000B51")]
	[Cpp2IlInjected.Address(RVA = "0x12D5978", Offset = "0x12D5978", VA = "0x12D5978")]
	public static void LoadContent(ContentManager content)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B52")]
	[Cpp2IlInjected.Address(RVA = "0x12D5A48", Offset = "0x12D5A48", VA = "0x12D5A48")]
	public static void DrawCentredPickingRegion(SpriteBatch batch, ControlAnchor.ControlId anchorControl, AnchorType anchorType, Vector2 position, Vector2 size)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B53")]
	[Cpp2IlInjected.Address(RVA = "0x12D5C28", Offset = "0x12D5C28", VA = "0x12D5C28")]
	public static void DrawCentredPickingRegion(SpriteBatch batch, Vector2 position, Vector2 size)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B54")]
	[Cpp2IlInjected.Address(RVA = "0x12D5D50", Offset = "0x12D5D50", VA = "0x12D5D50")]
	public static void DrawCentredCirclePickingRegion(SpriteBatch batch, ControlAnchor.ControlId anchorControl, AnchorType anchorType, Vector2 position, Vector2 size)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B55")]
	[Cpp2IlInjected.Address(RVA = "0x12D5E10", Offset = "0x12D5E10", VA = "0x12D5E10")]
	public static void DrawCentredCirclePickingRegion(SpriteBatch batch, Vector2 position, Vector2 size)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B56")]
	[Cpp2IlInjected.Address(RVA = "0x12D5F38", Offset = "0x12D5F38", VA = "0x12D5F38")]
	public static void DrawPickingRegion(SpriteBatch batch, ControlAnchor.ControlId anchorControl, AnchorType anchorType, Vector2 position, Vector2 size)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B57")]
	[Cpp2IlInjected.Address(RVA = "0x12D6110", Offset = "0x12D6110", VA = "0x12D6110")]
	public static void DrawPickPoint(SpriteBatch batch, Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B58")]
	[Cpp2IlInjected.Address(RVA = "0x12D5FF8", Offset = "0x12D5FF8", VA = "0x12D5FF8")]
	public static void DrawPickingRegion(SpriteBatch batch, Vector2 position, Vector2 size)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B59")]
	[Cpp2IlInjected.Address(RVA = "0x12D62A8", Offset = "0x12D62A8", VA = "0x12D62A8")]
	public static void DrawSafeRegion(SpriteBatch batch, Vector2 position, Vector2 size, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5A")]
	[Cpp2IlInjected.Address(RVA = "0x12D63B4", Offset = "0x12D63B4", VA = "0x12D63B4")]
	public static void Draw(SpriteBatch batch, Vector2 position, float rotation, float scale, Texture2D texture, [Optional] Color? color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5B")]
	[Cpp2IlInjected.Address(RVA = "0x12D657C", Offset = "0x12D657C", VA = "0x12D657C")]
	public static void Draw(SpriteBatch batch, Vector2 position, float scale, Texture2D texture, [Optional] Color? color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5C")]
	[Cpp2IlInjected.Address(RVA = "0x12D66EC", Offset = "0x12D66EC", VA = "0x12D66EC")]
	public static void DrawCentred(SpriteBatch batch, Vector2 position, float scale, Texture2D texture, [Optional] Color? color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5D")]
	[Cpp2IlInjected.Address(RVA = "0x12D6870", Offset = "0x12D6870", VA = "0x12D6870")]
	public static void DrawCentred(SpriteBatch batch, ControlAnchor.ControlId anchorControl, AnchorType anchorType, Vector2 position, float scale, Texture2D texture, [Optional] Color? color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5E")]
	[Cpp2IlInjected.Address(RVA = "0x12D6B44", Offset = "0x12D6B44", VA = "0x12D6B44")]
	public static void DrawCentred(SpriteBatch batch, ControlAnchor.ControlId anchorControl, AnchorType anchorType, Vector2 position, Rectangle srcRect, float scale, Texture2D texture, [Optional] Color? color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5F")]
	[Cpp2IlInjected.Address(RVA = "0x12D6DC0", Offset = "0x12D6DC0", VA = "0x12D6DC0")]
	public static void DrawCentred(SpriteBatch batch, Vector2 position, Rectangle srcRect, float scale, Texture2D texture, [Optional] Color? color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B60")]
	[Cpp2IlInjected.Address(RVA = "0x12D6FD4", Offset = "0x12D6FD4", VA = "0x12D6FD4")]
	public static void Draw(SpriteBatch batch, ControlAnchor.ControlId anchorControl, AnchorType anchorType, Vector2 position, float scale, Texture2D texture, [Optional] Color? color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B61")]
	[Cpp2IlInjected.Address(RVA = "0x12D7178", Offset = "0x12D7178", VA = "0x12D7178")]
	public static void Draw(SpriteBatch batch, ControlAnchor.ControlId anchorControl, AnchorType anchorType, Vector2 position, Vector2 size, Texture2D texture, [Optional] Color? color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B62")]
	[Cpp2IlInjected.Address(RVA = "0x12D72D8", Offset = "0x12D72D8", VA = "0x12D72D8")]
	public static bool IsOverIcon(Vector2 position, ControlAnchor.ControlId anchorControl, AnchorType anchorType, Vector2 anchorPosition, Texture2D texture, float textureScale, Vector2 pickingBorder)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B63")]
	[Cpp2IlInjected.Address(RVA = "0x12D74E4", Offset = "0x12D74E4", VA = "0x12D74E4")]
	public static Vector2 GetChatManagerAlignmentOffset(SpriteFont font, TextSnippet[] text, float scale, AnchorType stringAlignment, float maxWidth = -1f)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B64")]
	[Cpp2IlInjected.Address(RVA = "0x12D76CC", Offset = "0x12D76CC", VA = "0x12D76CC")]
	public static Vector2 GetAlignmentOffset(SpriteFont font, string text, float scale, AnchorType stringAlignment)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B65")]
	[Cpp2IlInjected.Address(RVA = "0x12D780C", Offset = "0x12D780C", VA = "0x12D780C")]
	public static Vector2 GetChatManagerAlignmentOffset(SpriteFont font, string text, float scale, AnchorType stringAlignment)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B66")]
	[Cpp2IlInjected.Address(RVA = "0x12D79E8", Offset = "0x12D79E8", VA = "0x12D79E8")]
	public static Vector2 GetAlignmentOffset(SpriteFont font, StringBuilder text, float scale, AnchorType stringAlignment)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B67")]
	[Cpp2IlInjected.Address(RVA = "0x12D7B28", Offset = "0x12D7B28", VA = "0x12D7B28")]
	public static Vector2 GetAlignmentOffset(SpriteFont font, string text, float scale, AnchorType stringAlignment, out Vector2 stringDimensions)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B68")]
	[Cpp2IlInjected.Address(RVA = "0x12D7C6C", Offset = "0x12D7C6C", VA = "0x12D7C6C")]
	public static Vector2 GetAlignmentOffset(SpriteFont font, StringBuilder text, float scale, AnchorType stringAlignment, out Vector2 stringDimensions)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B69")]
	[Cpp2IlInjected.Address(RVA = "0x12D7DB0", Offset = "0x12D7DB0", VA = "0x12D7DB0")]
	public static Vector2 GetAnchoredStringPosition(ControlAnchor.ControlId anchorControl, AnchorType anchorType, Vector2 position, SpriteFont font, string text, float scale, AnchorType stringAlignment)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6A")]
	[Cpp2IlInjected.Address(RVA = "0x12D7ED8", Offset = "0x12D7ED8", VA = "0x12D7ED8")]
	public static Vector2 GetAnchoredStringPosition(ControlAnchor.ControlId anchorControl, AnchorType anchorType, Vector2 position, SpriteFont font, TextSnippet[] text, float scale, AnchorType stringAlignment, float maxWidth = -1f)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6B")]
	[Cpp2IlInjected.Address(RVA = "0x12D8008", Offset = "0x12D8008", VA = "0x12D8008")]
	public static Vector2 GetAnchoredChatManagerStringPosition(ControlAnchor.ControlId anchorControl, AnchorType anchorType, Vector2 position, SpriteFont font, string text, float scale, AnchorType stringAlignment)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6C")]
	[Cpp2IlInjected.Address(RVA = "0x12D8130", Offset = "0x12D8130", VA = "0x12D8130")]
	public static Vector2 GetAnchoredStringPosition(ControlAnchor.ControlId anchorControl, AnchorType anchorType, Vector2 position, SpriteFont font, StringBuilder text, float scale, AnchorType stringAlignment)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6D")]
	[Cpp2IlInjected.Address(RVA = "0x12D8258", Offset = "0x12D8258", VA = "0x12D8258")]
	public static Vector2 GetAnchoredStringButtonPosition(ControlAnchor.ControlId anchorControl, AnchorType anchorType, Vector2 position, SpriteFont font, string text, float scale, AnchorType stringAlignment, out bool over, out Vector2 dimensions)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6E")]
	[Cpp2IlInjected.Address(RVA = "0x12D83C8", Offset = "0x12D83C8", VA = "0x12D83C8")]
	public static Vector2 GetAnchoredStringButtonPosition(ControlAnchor.ControlId anchorControl, AnchorType anchorType, Vector2 position, SpriteFont font, StringBuilder text, float scale, AnchorType stringAlignment, out bool over, out Vector2 dimensions)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6F")]
	[Cpp2IlInjected.Address(RVA = "0x12D5B08", Offset = "0x12D5B08", VA = "0x12D5B08")]
	public static Vector2 GetAnchoredPosition(ControlAnchor.ControlId anchorControl, AnchorType anchorType, Vector2 position)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B70")]
	[Cpp2IlInjected.Address(RVA = "0x12D6A20", Offset = "0x12D6A20", VA = "0x12D6A20")]
	public static Rectangle GetLayoutRect(ControlAnchor.ControlId anchorControl, AnchorType anchorType, Vector2 position, Vector2 size, Texture2D texture)
	{
		return default(Rectangle);
	}
}
