using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000550")]
public abstract class ARenderTargetContentByRequest : INeedRenderTargetContent
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40068ED")]
	protected RenderTarget2D _target;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40068EE")]
	protected bool _wasPrepared;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x40068EF")]
	private bool _wasRequested;

	[Cpp2IlInjected.Token(Token = "0x1700071F")]
	public bool IsReady
	{
		[Cpp2IlInjected.Token(Token = "0x60039FE")]
		[Cpp2IlInjected.Address(RVA = "0x1330F38", Offset = "0x1330F38", VA = "0x1330F38", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60039FF")]
	[Cpp2IlInjected.Address(RVA = "0x1330F40", Offset = "0x1330F40", VA = "0x1330F40")]
	public void Request()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A00")]
	[Cpp2IlInjected.Address(RVA = "0x1330F4C", Offset = "0x1330F4C", VA = "0x1330F4C")]
	public RenderTarget2D GetTarget()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003A01")]
	[Cpp2IlInjected.Address(RVA = "0x1330F54", Offset = "0x1330F54", VA = "0x1330F54", Slot = "5")]
	public void PrepareRenderTarget(GraphicsDevice device, SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A02")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract void HandleUseReqest(GraphicsDevice device, SpriteBatch spriteBatch);

	[Cpp2IlInjected.Token(Token = "0x6003A03")]
	[Cpp2IlInjected.Address(RVA = "0x1330F7C", Offset = "0x1330F7C", VA = "0x1330F7C")]
	protected void PrepareARenderTarget_AndListenToEvents(ref RenderTarget2D target, GraphicsDevice device, int neededWidth, int neededHeight, RenderTargetUsage usage)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A04")]
	[Cpp2IlInjected.Address(RVA = "0x1330F80", Offset = "0x1330F80", VA = "0x1330F80")]
	private void target_Disposing(object sender, EventArgs e)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A05")]
	[Cpp2IlInjected.Address(RVA = "0x1330F90", Offset = "0x1330F90", VA = "0x1330F90")]
	private void target_ContentLost(object sender, EventArgs e)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A06")]
	[Cpp2IlInjected.Address(RVA = "0x1330F9C", Offset = "0x1330F9C", VA = "0x1330F9C", Slot = "6")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A07")]
	[Cpp2IlInjected.Address(RVA = "0x1330FAC", Offset = "0x1330FAC", VA = "0x1330FAC")]
	protected void PrepareARenderTarget_WithoutListeningToEvents(ref RenderTarget2D target, GraphicsDevice device, int neededWidth, int neededHeight, RenderTargetUsage usage)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A08")]
	[Cpp2IlInjected.Address(RVA = "0x1330FB0", Offset = "0x1330FB0", VA = "0x1330FB0")]
	protected ARenderTargetContentByRequest()
	{
	}
}
