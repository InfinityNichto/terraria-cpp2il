using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200024C")]
public class DistortionRenderTargetManager : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x4001BB9")]
	public static DistortionRenderTargetManager _instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001BBA")]
	private Camera cameraObject;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001BBB")]
	public RenderTexture DistortionTarget;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001BBC")]
	public RenderTexture DistortionTargetSwap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001BBD")]
	public Microsoft.Xna.Framework.Graphics.Texture2D GameDistortionTarget;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001BBE")]
	public Microsoft.Xna.Framework.Graphics.Texture2D GameDistortionTargetSwap;

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public static DistortionRenderTargetManager Instance
	{
		[Cpp2IlInjected.Token(Token = "0x60010AC")]
		[Cpp2IlInjected.Address(RVA = "0x20CC740", Offset = "0x20CC740", VA = "0x20CC740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60010AD")]
	[Cpp2IlInjected.Address(RVA = "0x20CC838", Offset = "0x20CC838", VA = "0x20CC838")]
	private void InitialiseCamera()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010AE")]
	[Cpp2IlInjected.Address(RVA = "0x20CCBF8", Offset = "0x20CCBF8", VA = "0x20CCBF8")]
	public void ClearRenderTarget()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010AF")]
	[Cpp2IlInjected.Address(RVA = "0x20CCDEC", Offset = "0x20CCDEC", VA = "0x20CCDEC")]
	public void SwapTargets()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010B0")]
	[Cpp2IlInjected.Address(RVA = "0x20CCC1C", Offset = "0x20CCC1C", VA = "0x20CCC1C")]
	public void BeginRenderTarget(bool clear, float clearValue)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010B1")]
	[Cpp2IlInjected.Address(RVA = "0x20CCD68", Offset = "0x20CCD68", VA = "0x20CCD68")]
	public void EndRenderTarget()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010B2")]
	[Cpp2IlInjected.Address(RVA = "0x20CCEA0", Offset = "0x20CCEA0", VA = "0x20CCEA0")]
	public DistortionRenderTargetManager()
	{
	}
}
