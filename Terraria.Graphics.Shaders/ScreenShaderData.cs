using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.Graphics.Shaders;

[Cpp2IlInjected.Token(Token = "0x20004F3")]
public class ScreenShaderData : ShaderData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006773")]
	private Vector3 _uColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006774")]
	private Vector3 _uSecondaryColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4006775")]
	private float _uOpacity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4006776")]
	private float _globalOpacity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4006777")]
	private float _uIntensity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4006778")]
	private Vector2 _uTargetPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4006779")]
	private Vector2 _uDirection;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400677A")]
	private float _uProgress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400677B")]
	private Vector2 _uImageOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400677C")]
	private Asset<Texture2D>[] _uAssetImages;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400677D")]
	private Texture2D[] _uCustomImages;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400677E")]
	private SamplerState[] _samplerStates;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400677F")]
	private Vector2[] _imageScales;

	[Cpp2IlInjected.Token(Token = "0x170006E7")]
	public float Intensity
	{
		[Cpp2IlInjected.Token(Token = "0x6003756")]
		[Cpp2IlInjected.Address(RVA = "0x124A090", Offset = "0x124A090", VA = "0x124A090")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006E8")]
	public float CombinedOpacity
	{
		[Cpp2IlInjected.Token(Token = "0x6003757")]
		[Cpp2IlInjected.Address(RVA = "0x124A098", Offset = "0x124A098", VA = "0x124A098")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003758")]
	[Cpp2IlInjected.Address(RVA = "0x124A0AC", Offset = "0x124A0AC", VA = "0x124A0AC")]
	public ScreenShaderData(string passName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003759")]
	[Cpp2IlInjected.Address(RVA = "0x124A534", Offset = "0x124A534", VA = "0x124A534")]
	public ScreenShaderData(Ref<Effect> shader, string passName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600375A")]
	[Cpp2IlInjected.Address(RVA = "0x124A988", Offset = "0x124A988", VA = "0x124A988", Slot = "6")]
	public virtual void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600375B")]
	[Cpp2IlInjected.Address(RVA = "0x124A98C", Offset = "0x124A98C", VA = "0x124A98C", Slot = "5")]
	public override void Apply()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600375C")]
	[Cpp2IlInjected.Address(RVA = "0x124B054", Offset = "0x124B054", VA = "0x124B054")]
	public ScreenShaderData UseImageOffset(Vector2 offset)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600375D")]
	[Cpp2IlInjected.Address(RVA = "0x124B060", Offset = "0x124B060", VA = "0x124B060")]
	public ScreenShaderData UseIntensity(float intensity)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600375E")]
	[Cpp2IlInjected.Address(RVA = "0x124B068", Offset = "0x124B068", VA = "0x124B068")]
	public ScreenShaderData UseColor(float r, float g, float b)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600375F")]
	[Cpp2IlInjected.Address(RVA = "0x124B0BC", Offset = "0x124B0BC", VA = "0x124B0BC")]
	public ScreenShaderData UseProgress(float progress)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003760")]
	[Cpp2IlInjected.Address(RVA = "0x124B0C4", Offset = "0x124B0C4", VA = "0x124B0C4")]
	public ScreenShaderData UseImage(Texture2D image, int index = 0, [Optional] SamplerState samplerState)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003761")]
	[Cpp2IlInjected.Address(RVA = "0x124B164", Offset = "0x124B164", VA = "0x124B164")]
	public ScreenShaderData UseImage(string path, int index = 0, [Optional] SamplerState samplerState)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003762")]
	[Cpp2IlInjected.Address(RVA = "0x124B31C", Offset = "0x124B31C", VA = "0x124B31C")]
	public ScreenShaderData UseColor(Color color)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003763")]
	[Cpp2IlInjected.Address(RVA = "0x124B0B0", Offset = "0x124B0B0", VA = "0x124B0B0")]
	public ScreenShaderData UseColor(Vector3 color)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003764")]
	[Cpp2IlInjected.Address(RVA = "0x124B358", Offset = "0x124B358", VA = "0x124B358")]
	public ScreenShaderData UseDirection(Vector2 direction)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003765")]
	[Cpp2IlInjected.Address(RVA = "0x124B364", Offset = "0x124B364", VA = "0x124B364")]
	public ScreenShaderData UseGlobalOpacity(float opacity)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003766")]
	[Cpp2IlInjected.Address(RVA = "0x124B36C", Offset = "0x124B36C", VA = "0x124B36C")]
	public ScreenShaderData UseTargetPosition(Vector2 position)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003767")]
	[Cpp2IlInjected.Address(RVA = "0x124B378", Offset = "0x124B378", VA = "0x124B378")]
	public ScreenShaderData UseSecondaryColor(float r, float g, float b)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003768")]
	[Cpp2IlInjected.Address(RVA = "0x124B3CC", Offset = "0x124B3CC", VA = "0x124B3CC")]
	public ScreenShaderData UseSecondaryColor(Color color)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003769")]
	[Cpp2IlInjected.Address(RVA = "0x124B3C0", Offset = "0x124B3C0", VA = "0x124B3C0")]
	public ScreenShaderData UseSecondaryColor(Vector3 color)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600376A")]
	[Cpp2IlInjected.Address(RVA = "0x124B408", Offset = "0x124B408", VA = "0x124B408")]
	public ScreenShaderData UseOpacity(float opacity)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600376B")]
	[Cpp2IlInjected.Address(RVA = "0x124B410", Offset = "0x124B410", VA = "0x124B410")]
	public ScreenShaderData UseImageScale(Vector2 scale, int index = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600376C")]
	[Cpp2IlInjected.Address(RVA = "0x124B430", Offset = "0x124B430", VA = "0x124B430", Slot = "7")]
	public virtual ScreenShaderData GetSecondaryShader(Player player)
	{
		return null;
	}
}
