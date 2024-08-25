using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Effects
{
	[global::Cpp2ILInjected.Token(Token = "0x2000785")]
	public abstract class GameEffect
	{
		[global::Cpp2ILInjected.Token(Token = "0x170007A5")]
		public bool IsLoaded
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003F04")]
			[global::Cpp2ILInjected.Address(RVA = "0x741DAC", Offset = "0x741DAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007A6")]
		public EffectPriority Priority
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003F05")]
			[global::Cpp2ILInjected.Address(RVA = "0x741DB4", Offset = "0x741DB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003F06")]
		[global::Cpp2ILInjected.Address(RVA = "0x741DBC", Offset = "0x741DBC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EffectManager<>), Member = "Bind", MemberParameters = new object[]
		{
			typeof(string),
			"T"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EffectManager<>), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Load()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003F07")]
		[global::Cpp2ILInjected.Address(RVA = "0x741DDC", Offset = "0x741DDC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnLoad()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003F08")]
		public abstract bool IsVisible();

		[global::Cpp2ILInjected.Token(Token = "0x6003F09")]
		public abstract void Activate(Vector2 position, params object[] args);

		[global::Cpp2ILInjected.Token(Token = "0x6003F0A")]
		public abstract void Deactivate(params object[] args);

		[global::Cpp2ILInjected.Token(Token = "0x6003F0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x740B2C", Offset = "0x740B2C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected GameEffect()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007D84")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public float Opacity;

		[global::Cpp2ILInjected.Token(Token = "0x4007D85")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		protected bool _isLoaded;

		[global::Cpp2ILInjected.Token(Token = "0x4007D86")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected EffectPriority _priority;
	}
}
