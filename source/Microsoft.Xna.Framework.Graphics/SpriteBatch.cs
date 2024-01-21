using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using Terraria.Graphics;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002C4")]
public class SpriteBatch : GraphicsResource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400200D")]
	public bool BatchDeffered;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400200E")]
	public bool BatchDefferedHeadInsert;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400200F")]
	private readonly SpriteBatcher _batcher;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4002010")]
	private SpriteSortMode _sortMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4002011")]
	private BlendState _blendState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4002012")]
	private DepthStencilState _depthStencilState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4002013")]
	private RasterizerState _rasterizerState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4002014")]
	private Effect _effect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4002015")]
	public bool _beginCalled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4002016")]
	private int _batchOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4002017")]
	private SpriteBatchItem _lastBatchItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4002018")]
	private SpriteBatchItemList _firstBatchList;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4002019")]
	private SpriteBatchItemList _lastBatchList;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400201A")]
	private Effect _spriteEffect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400201B")]
	private readonly EffectPass _spritePass;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400201C")]
	private Matrix _renderMatrix;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400201D")]
	private bool _hasMatrix;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400201E")]
	private Viewport _lastViewport;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x400201F")]
	private Matrix _projection;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4002020")]
	private Rectangle _tempRect;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4002021")]
	private Vector2 _texCoordTL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4002022")]
	private Vector2 _texCoordBR;

	[Cpp2IlInjected.Token(Token = "0x4002023")]
	internal static bool NeedsHalfPixelOffset;

	[Cpp2IlInjected.Token(Token = "0x4002024")]
	public static string LastBeginCall;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4002025")]
	public EffectPass OverloadedEffectPass;

	[Cpp2IlInjected.Token(Token = "0x4002026")]
	public static bool forceDrawScale;

	[Cpp2IlInjected.Token(Token = "0x4002027")]
	public static Vector2 forcedDrawScale;

	[Cpp2IlInjected.Token(Token = "0x4002028")]
	public static Vector2 forcedDrawOrigin;

	[Cpp2IlInjected.Token(Token = "0x4002029")]
	public static Vector2 forcedDrawPosition;

	[Cpp2IlInjected.Token(Token = "0x400202A")]
	private static List<float> rightLineLengths;

	[Cpp2IlInjected.Token(Token = "0x400202B")]
	private static List<int> rightLineOffsets;

	[Cpp2IlInjected.Token(Token = "0x400202C")]
	private static List<SpriteBatchItem> rightLineElements;

	[Cpp2IlInjected.Token(Token = "0x60016D3")]
	[Cpp2IlInjected.Address(RVA = "0x159510C", Offset = "0x159510C", VA = "0x159510C")]
	public SpriteBatch(GraphicsDevice graphicsDevice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016D4")]
	[Cpp2IlInjected.Address(RVA = "0x159525C", Offset = "0x159525C", VA = "0x159525C")]
	public void Begin(SpriteSortMode sortMode, bool useTransformMatrix, bool defferedBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016D5")]
	[Cpp2IlInjected.Address(RVA = "0x1595494", Offset = "0x1595494", VA = "0x1595494")]
	public void Begin(SpriteSortMode sortMode = SpriteSortMode.Deferred, [Optional] BlendState blendState, [Optional] SamplerState samplerState, [Optional] DepthStencilState depthStencilState, [Optional] RasterizerState rasterizerState, [Optional] Effect effect, [Optional] Matrix? transformMatrix, bool defferedBatch = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016D6")]
	[Cpp2IlInjected.Address(RVA = "0x1595660", Offset = "0x1595660", VA = "0x1595660")]
	public void End()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016D7")]
	[Cpp2IlInjected.Address(RVA = "0x159577C", Offset = "0x159577C", VA = "0x159577C")]
	public void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016D8")]
	[Cpp2IlInjected.Address(RVA = "0x1595418", Offset = "0x1595418", VA = "0x1595418")]
	private void Setup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016D9")]
	[Cpp2IlInjected.Address(RVA = "0x1595788", Offset = "0x1595788", VA = "0x1595788")]
	private void CheckValid(Texture2D texture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016DA")]
	[Cpp2IlInjected.Address(RVA = "0x1595868", Offset = "0x1595868", VA = "0x1595868")]
	private void CheckValid(SpriteFont spriteFont, string text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016DB")]
	[Cpp2IlInjected.Address(RVA = "0x159597C", Offset = "0x159597C", VA = "0x159597C")]
	private void CheckValid(SpriteFont spriteFont, StringBuilder text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016DC")]
	[Cpp2IlInjected.Address(RVA = "0x1595A90", Offset = "0x1595A90", VA = "0x1595A90")]
	public void Draw(Texture2D texture, [Optional] Vector2? position, [Optional] Rectangle? destinationRectangle, [Optional] Rectangle? sourceRectangle, [Optional] Vector2? origin, float rotation = 0f, [Optional] Vector2? scale, [Optional] Color? color, SpriteEffects effects = SpriteEffects.None, float layerDepth = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016DD")]
	[Cpp2IlInjected.Address(RVA = "0x1596808", Offset = "0x1596808", VA = "0x1596808")]
	public void Draw(Texture2D texture, Vector2? position, Rectangle? destinationRectangle, Rectangle? sourceRectangle, Vector2? origin, float rotation, Vector2? scale, ref VertexColors color, SpriteEffects effects = SpriteEffects.None, float layerDepth = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016DE")]
	[Cpp2IlInjected.Address(RVA = "0x15974F8", Offset = "0x15974F8", VA = "0x15974F8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F194", Offset = "0x38F194")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F194", Offset = "0x38F194")]
	public SpriteBatchItem InsertNewBatchItem(Texture2D texture)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60016DF")]
	[Cpp2IlInjected.Address(RVA = "0x1597794", Offset = "0x1597794", VA = "0x1597794")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F248", Offset = "0x38F248")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F248", Offset = "0x38F248")]
	public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects = SpriteEffects.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016E0")]
	[Cpp2IlInjected.Address(RVA = "0x1597A1C", Offset = "0x1597A1C", VA = "0x1597A1C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F2FC", Offset = "0x38F2FC")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F2FC", Offset = "0x38F2FC")]
	public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects = SpriteEffects.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016E1")]
	[Cpp2IlInjected.Address(RVA = "0x1597C94", Offset = "0x1597C94", VA = "0x1597C94")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F3B0", Offset = "0x38F3B0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F3B0", Offset = "0x38F3B0")]
	public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref Color color, float rotation, Vector2 origin, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016E2")]
	[Cpp2IlInjected.Address(RVA = "0x1597ED0", Offset = "0x1597ED0", VA = "0x1597ED0")]
	public void Draw(Texture2D texture, ref Vector2 position, ref Color color, float rotation, Vector2 origin, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016E3")]
	[Cpp2IlInjected.Address(RVA = "0x1595F0C", Offset = "0x1595F0C", VA = "0x1595F0C")]
	public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016E4")]
	[Cpp2IlInjected.Address(RVA = "0x15981C8", Offset = "0x15981C8", VA = "0x15981C8")]
	public void Draw(Texture2D texture, Vector2 position, ref Rectangle srcRect, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016E5")]
	[Cpp2IlInjected.Address(RVA = "0x1596BF0", Offset = "0x1596BF0", VA = "0x1596BF0")]
	public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, ref VertexColors color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016E6")]
	[Cpp2IlInjected.Address(RVA = "0x159842C", Offset = "0x159842C", VA = "0x159842C")]
	public void Draw(Texture2D texture, Vector2 position, ref Rectangle srcRect, ref VertexColors color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016E7")]
	[Cpp2IlInjected.Address(RVA = "0x15986A8", Offset = "0x15986A8", VA = "0x15986A8")]
	public void Draw(Texture2D texture, Vector2 position, ref Rectangle srcRect, ref VertexColors color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016E8")]
	[Cpp2IlInjected.Address(RVA = "0x1598908", Offset = "0x1598908", VA = "0x1598908")]
	public static void ForceDrawScale(float scale, Vector2 origin, Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016E9")]
	[Cpp2IlInjected.Address(RVA = "0x15989EC", Offset = "0x15989EC", VA = "0x15989EC")]
	public static void ClearDrawScale()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016EA")]
	[Cpp2IlInjected.Address(RVA = "0x1598A68", Offset = "0x1598A68", VA = "0x1598A68")]
	public static void TransformPosition(ref Vector2 position, ref Vector2 scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016EB")]
	[Cpp2IlInjected.Address(RVA = "0x1598BE0", Offset = "0x1598BE0", VA = "0x1598BE0")]
	public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016EC")]
	[Cpp2IlInjected.Address(RVA = "0x1598C90", Offset = "0x1598C90", VA = "0x1598C90")]
	public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016ED")]
	[Cpp2IlInjected.Address(RVA = "0x1598D74", Offset = "0x1598D74", VA = "0x1598D74")]
	public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref VertexColors color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016EE")]
	[Cpp2IlInjected.Address(RVA = "0x1598E58", Offset = "0x1598E58", VA = "0x1598E58")]
	public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref Color color, SpriteEffects effects)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016EF")]
	[Cpp2IlInjected.Address(RVA = "0x1598F88", Offset = "0x1598F88", VA = "0x1598F88")]
	public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref VertexColors color, SpriteEffects effects)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016F0")]
	[Cpp2IlInjected.Address(RVA = "0x15990B8", Offset = "0x15990B8", VA = "0x15990B8")]
	public void Draw(Texture2D texture, Vector2 position, ref Rectangle srcRect, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016F1")]
	[Cpp2IlInjected.Address(RVA = "0x1599310", Offset = "0x1599310", VA = "0x1599310")]
	public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, ref VertexColors color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016F2")]
	[Cpp2IlInjected.Address(RVA = "0x1596398", Offset = "0x1596398", VA = "0x1596398")]
	public void Draw(Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, SpriteEffects effects, float layerDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016F3")]
	[Cpp2IlInjected.Address(RVA = "0x1597024", Offset = "0x1597024", VA = "0x1597024")]
	public void Draw(Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, ref VertexColors color, float rotation, Vector2 origin, SpriteEffects effects, float layerDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016F4")]
	[Cpp2IlInjected.Address(RVA = "0x15979F4", Offset = "0x15979F4", VA = "0x15979F4")]
	internal void FlushIfNeeded()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016F5")]
	[Cpp2IlInjected.Address(RVA = "0x15993C0", Offset = "0x15993C0", VA = "0x15993C0")]
	public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016F6")]
	[Cpp2IlInjected.Address(RVA = "0x159966C", Offset = "0x159966C", VA = "0x159966C")]
	public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, ref VertexColors color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016F7")]
	[Cpp2IlInjected.Address(RVA = "0x1599918", Offset = "0x1599918", VA = "0x1599918")]
	public void Draw(Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016F8")]
	[Cpp2IlInjected.Address(RVA = "0x1599B90", Offset = "0x1599B90", VA = "0x1599B90")]
	public void Draw(Texture2D texture, Vector2 position, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016F9")]
	[Cpp2IlInjected.Address(RVA = "0x1599D6C", Offset = "0x1599D6C", VA = "0x1599D6C")]
	public void Draw(Texture2D texture, Rectangle destinationRectangle, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016FA")]
	[Cpp2IlInjected.Address(RVA = "0x1599F6C", Offset = "0x1599F6C", VA = "0x1599F6C")]
	public void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016FB")]
	[Cpp2IlInjected.Address(RVA = "0x159A4E0", Offset = "0x159A4E0", VA = "0x159A4E0")]
	public void DrawString(SpriteFont spriteFont, StringBuilder text, Vector2 position, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016FC")]
	[Cpp2IlInjected.Address(RVA = "0x159ABD4", Offset = "0x159ABD4", VA = "0x159ABD4")]
	public void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016FD")]
	[Cpp2IlInjected.Address(RVA = "0x159B7CC", Offset = "0x159B7CC", VA = "0x159B7CC")]
	public void DrawString(SpriteFont spriteFont, StringBuilder text, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016FE")]
	[Cpp2IlInjected.Address(RVA = "0x159AC6C", Offset = "0x159AC6C", VA = "0x159AC6C")]
	public void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016FF")]
	[Cpp2IlInjected.Address(RVA = "0x159C3C0", Offset = "0x159C3C0", VA = "0x159C3C0")]
	public void DrawStringMultiLineRight(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001700")]
	[Cpp2IlInjected.Address(RVA = "0x159D34C", Offset = "0x159D34C", VA = "0x159D34C")]
	public void DrawStringMultiLineCentre(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001701")]
	[Cpp2IlInjected.Address(RVA = "0x159B864", Offset = "0x159B864", VA = "0x159B864")]
	public void DrawString(SpriteFont spriteFont, StringBuilder text, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001702")]
	[Cpp2IlInjected.Address(RVA = "0x159E2E4", Offset = "0x159E2E4", VA = "0x159E2E4")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F464", Offset = "0x38F464")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F464", Offset = "0x38F464")]
	public void DrawString(SpriteFont spriteFont, string text, int start, int end, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, Vector2[] offsets)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001703")]
	[Cpp2IlInjected.Address(RVA = "0x159EE54", Offset = "0x159EE54", VA = "0x159EE54")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F518", Offset = "0x38F518")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F518", Offset = "0x38F518")]
	public void DrawString(SpriteFont spriteFont, StringBuilder text, int start, int end, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, Vector2[] offsets)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001704")]
	[Cpp2IlInjected.Address(RVA = "0x159F788", Offset = "0x159F788", VA = "0x159F788")]
	public void DrawString(SpriteFont spriteFont, string text, int start, int end, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001705")]
	[Cpp2IlInjected.Address(RVA = "0x15A0384", Offset = "0x15A0384", VA = "0x15A0384")]
	public void DrawString(SpriteFont spriteFont, StringBuilder text, int start, int end, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
	{
	}
}
