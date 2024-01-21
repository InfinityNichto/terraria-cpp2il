using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000250")]
public class WaterRenderTargetManager : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x4001BDC")]
	public static WaterRenderTargetManager _instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001BDD")]
	private Camera cameraObject;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001BDE")]
	public RenderTexture RenderTarget;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001BDF")]
	public Microsoft.Xna.Framework.Graphics.Texture2D GameRenderTarget;

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public static WaterRenderTargetManager Instance
	{
		[Cpp2IlInjected.Token(Token = "0x60010CF")]
		[Cpp2IlInjected.Address(RVA = "0xE8ED80", Offset = "0xE8ED80", VA = "0xE8ED80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60010D0")]
	[Cpp2IlInjected.Address(RVA = "0xE8EE78", Offset = "0xE8EE78", VA = "0xE8EE78")]
	private void InitialiseCamera()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010D1")]
	[Cpp2IlInjected.Address(RVA = "0xE8F1FC", Offset = "0xE8F1FC", VA = "0xE8F1FC")]
	public void UpdateRenderTarget()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010D2")]
	[Cpp2IlInjected.Address(RVA = "0xE8F298", Offset = "0xE8F298", VA = "0xE8F298")]
	public WaterRenderTargetManager()
	{
	}
}
