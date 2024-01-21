using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Effects;

[Cpp2IlInjected.Token(Token = "0x200051F")]
public abstract class GameEffect
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400685F")]
	public float Opacity;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006860")]
	protected bool _isLoaded;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006861")]
	protected EffectPriority _priority;

	[Cpp2IlInjected.Token(Token = "0x1700070C")]
	public bool IsLoaded
	{
		[Cpp2IlInjected.Token(Token = "0x60038A1")]
		[Cpp2IlInjected.Address(RVA = "0x1509080", Offset = "0x1509080", VA = "0x1509080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700070D")]
	public EffectPriority Priority
	{
		[Cpp2IlInjected.Token(Token = "0x60038A2")]
		[Cpp2IlInjected.Address(RVA = "0x1509088", Offset = "0x1509088", VA = "0x1509088")]
		get
		{
			return default(EffectPriority);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60038A3")]
	[Cpp2IlInjected.Address(RVA = "0x1509090", Offset = "0x1509090", VA = "0x1509090")]
	public void Load()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038A4")]
	[Cpp2IlInjected.Address(RVA = "0x15090B4", Offset = "0x15090B4", VA = "0x15090B4", Slot = "4")]
	public virtual void OnLoad()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool IsVisible();

	[Cpp2IlInjected.Token(Token = "0x60038A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void Activate(Vector2 position, params object[] args);

	[Cpp2IlInjected.Token(Token = "0x60038A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void Deactivate(params object[] args);

	[Cpp2IlInjected.Token(Token = "0x60038A8")]
	[Cpp2IlInjected.Address(RVA = "0x1507860", Offset = "0x1507860", VA = "0x1507860")]
	protected GameEffect()
	{
	}
}
