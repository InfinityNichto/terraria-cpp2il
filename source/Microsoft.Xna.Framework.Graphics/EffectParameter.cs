using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002A2")]
[Cpp2IlInjected.Attribute(Name = "DebuggerDisplayAttribute", RVA = "0x384D20", Offset = "0x384D20")]
public class EffectParameter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001EFB")]
	internal float[] Data;

	[Cpp2IlInjected.Token(Token = "0x17000274")]
	public string Name
	{
		[Cpp2IlInjected.Token(Token = "0x6001570")]
		[Cpp2IlInjected.Address(RVA = "0x139AFB8", Offset = "0x139AFB8", VA = "0x139AFB8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001571")]
		[Cpp2IlInjected.Address(RVA = "0x139AFC0", Offset = "0x139AFC0", VA = "0x139AFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000275")]
	public UnityEngine.Vector4 Vector
	{
		[Cpp2IlInjected.Token(Token = "0x6001578")]
		[Cpp2IlInjected.Address(RVA = "0x139B050", Offset = "0x139B050", VA = "0x139B050")]
		get
		{
			return default(UnityEngine.Vector4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000276")]
	public float Float
	{
		[Cpp2IlInjected.Token(Token = "0x6001579")]
		[Cpp2IlInjected.Address(RVA = "0x139B08C", Offset = "0x139B08C", VA = "0x139B08C")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000277")]
	public bool Bool
	{
		[Cpp2IlInjected.Token(Token = "0x600157A")]
		[Cpp2IlInjected.Address(RVA = "0x139B098", Offset = "0x139B098", VA = "0x139B098")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000278")]
	public UnityEngine.Color Color
	{
		[Cpp2IlInjected.Token(Token = "0x600157B")]
		[Cpp2IlInjected.Address(RVA = "0x139B0B4", Offset = "0x139B0B4", VA = "0x139B0B4")]
		get
		{
			return default(UnityEngine.Color);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600156E")]
	[Cpp2IlInjected.Address(RVA = "0x139AE8C", Offset = "0x139AE8C", VA = "0x139AE8C")]
	internal EffectParameter(string name)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600156F")]
	[Cpp2IlInjected.Address(RVA = "0x139AF00", Offset = "0x139AF00", VA = "0x139AF00")]
	internal EffectParameter(EffectParameter cloneSource)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001572")]
	[Cpp2IlInjected.Address(RVA = "0x139AFC8", Offset = "0x139AFC8", VA = "0x139AFC8")]
	public void SetValue(Matrix value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001573")]
	[Cpp2IlInjected.Address(RVA = "0x139AFCC", Offset = "0x139AFCC", VA = "0x139AFCC")]
	public void SetValue(bool value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001574")]
	[Cpp2IlInjected.Address(RVA = "0x139AFEC", Offset = "0x139AFEC", VA = "0x139AFEC")]
	public void SetValue(float value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001575")]
	[Cpp2IlInjected.Address(RVA = "0x139AFF8", Offset = "0x139AFF8", VA = "0x139AFF8")]
	public void SetValue(Vector2 value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001576")]
	[Cpp2IlInjected.Address(RVA = "0x139B00C", Offset = "0x139B00C", VA = "0x139B00C")]
	public void SetValue(Vector3 value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001577")]
	[Cpp2IlInjected.Address(RVA = "0x139B028", Offset = "0x139B028", VA = "0x139B028")]
	public void SetValue(Vector4 value)
	{
	}
}
