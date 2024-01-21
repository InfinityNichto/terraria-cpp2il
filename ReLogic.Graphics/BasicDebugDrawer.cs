using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ReLogic.Graphics;

[Cpp2IlInjected.Token(Token = "0x2000739")]
public class BasicDebugDrawer : IDebugDrawer, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400734A")]
	private SpriteBatch _spriteBatch;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400734B")]
	private Texture2D _texture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400734C")]
	private bool _disposedValue;

	[Cpp2IlInjected.Token(Token = "0x6004736")]
	[Cpp2IlInjected.Address(RVA = "0x10C0AC0", Offset = "0x10C0AC0", VA = "0x10C0AC0")]
	public BasicDebugDrawer(GraphicsDevice graphicsDevice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004737")]
	[Cpp2IlInjected.Address(RVA = "0x10C0BF0", Offset = "0x10C0BF0", VA = "0x10C0BF0")]
	public void Begin(Matrix matrix)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004738")]
	[Cpp2IlInjected.Address(RVA = "0x10C0D30", Offset = "0x10C0D30", VA = "0x10C0D30")]
	public void Begin()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004739")]
	[Cpp2IlInjected.Address(RVA = "0x10C0DA0", Offset = "0x10C0DA0", VA = "0x10C0DA0", Slot = "4")]
	public void DrawSquare(Vector4 positionAndSize, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600473A")]
	[Cpp2IlInjected.Address(RVA = "0x10C0F40", Offset = "0x10C0F40", VA = "0x10C0F40")]
	public void DrawSquare(Vector2 position, Vector2 size, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600473B")]
	[Cpp2IlInjected.Address(RVA = "0x10C10AC", Offset = "0x10C10AC", VA = "0x10C10AC", Slot = "5")]
	public void DrawSquareFromCenter(Vector2 center, Vector2 size, float rotation, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600473C")]
	[Cpp2IlInjected.Address(RVA = "0x10C11E4", Offset = "0x10C11E4", VA = "0x10C11E4")]
	public void DrawLine(Vector2 start, Vector2 end, float width, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600473D")]
	[Cpp2IlInjected.Address(RVA = "0x10C13D4", Offset = "0x10C13D4", VA = "0x10C13D4")]
	public void End()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600473E")]
	[Cpp2IlInjected.Address(RVA = "0x10C13E0", Offset = "0x10C13E0", VA = "0x10C13E0", Slot = "7")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600473F")]
	[Cpp2IlInjected.Address(RVA = "0x10C1444", Offset = "0x10C1444", VA = "0x10C1444", Slot = "6")]
	public void Dispose()
	{
	}
}
