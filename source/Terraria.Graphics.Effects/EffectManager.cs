using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Effects;

[Cpp2IlInjected.Token(Token = "0x200051B")]
[Cpp2IlInjected.Attribute(Name = "DefaultMemberAttribute", RVA = "0x3851FC", Offset = "0x3851FC")]
public abstract class EffectManager<T> where T : GameEffect
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400684D")]
	protected bool _isLoaded;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400684E")]
	protected Dictionary<string, T> _effects;

	[Cpp2IlInjected.Token(Token = "0x1700070A")]
	public bool IsLoaded
	{
		[Cpp2IlInjected.Token(Token = "0x6003884")]
		[Cpp2IlInjected.Address(RVA = "0x1643980", Offset = "0x1643980", VA = "0x1643980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700070B")]
	public T Item
	{
		[Cpp2IlInjected.Token(Token = "0x6003885")]
		[Cpp2IlInjected.Address(RVA = "0x1643988", Offset = "0x1643988", VA = "0x1643988")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003886")]
		[Cpp2IlInjected.Address(RVA = "0x16439CC", Offset = "0x16439CC", VA = "0x16439CC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003887")]
	[Cpp2IlInjected.Address(RVA = "0x16439E0", Offset = "0x16439E0", VA = "0x16439E0")]
	public void Bind(string name, T effect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003888")]
	[Cpp2IlInjected.Address(RVA = "0x1643A28", Offset = "0x1643A28", VA = "0x1643A28")]
	public void Load()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003889")]
	[Cpp2IlInjected.Address(RVA = "0x1643BF0", Offset = "0x1643BF0", VA = "0x1643BF0")]
	public T Activate(string name, [Optional] Vector2 position, params object[] args)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600388A")]
	[Cpp2IlInjected.Address(RVA = "0x1643E74", Offset = "0x1643E74", VA = "0x1643E74")]
	public void Deactivate(string name, params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600388B")]
	[Cpp2IlInjected.Address(RVA = "0x16440CC", Offset = "0x16440CC", VA = "0x16440CC", Slot = "4")]
	public virtual void OnActivate(T effect, Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600388C")]
	[Cpp2IlInjected.Address(RVA = "0x16440D0", Offset = "0x16440D0", VA = "0x16440D0", Slot = "5")]
	public virtual void OnDeactivate(T effect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600388D")]
	[Cpp2IlInjected.Address(RVA = "0x16440D4", Offset = "0x16440D4", VA = "0x16440D4")]
	protected EffectManager()
	{
	}
}
