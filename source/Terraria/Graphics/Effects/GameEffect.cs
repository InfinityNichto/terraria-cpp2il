using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Effects
{
	// Token: 0x0200051C RID: 1308
	[global::Cpp2ILInjected.Token(Token = "0x2000785")]
	public abstract class GameEffect
	{
		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06003865 RID: 14437 RVA: 0x0002C126 File Offset: 0x0002A326
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

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06003866 RID: 14438 RVA: 0x0002C129 File Offset: 0x0002A329
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

		// Token: 0x06003867 RID: 14439 RVA: 0x0002C12C File Offset: 0x0002A32C
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

		// Token: 0x06003868 RID: 14440 RVA: 0x0002C12F File Offset: 0x0002A32F
		[global::Cpp2ILInjected.Token(Token = "0x6003F07")]
		[global::Cpp2ILInjected.Address(RVA = "0x741DDC", Offset = "0x741DDC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnLoad()
		{
			throw null;
		}

		// Token: 0x06003869 RID: 14441
		[global::Cpp2ILInjected.Token(Token = "0x6003F08")]
		public abstract bool IsVisible();

		// Token: 0x0600386A RID: 14442
		[global::Cpp2ILInjected.Token(Token = "0x6003F09")]
		public abstract void Activate(Vector2 position, params object[] args);

		// Token: 0x0600386B RID: 14443
		[global::Cpp2ILInjected.Token(Token = "0x6003F0A")]
		public abstract void Deactivate(params object[] args);

		// Token: 0x0600386C RID: 14444 RVA: 0x0002C132 File Offset: 0x0002A332
		[global::Cpp2ILInjected.Token(Token = "0x6003F0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x740B2C", Offset = "0x740B2C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected GameEffect()
		{
			throw null;
		}

		// Token: 0x0400685E RID: 26718
		[global::Cpp2ILInjected.Token(Token = "0x4007D84")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public float Opacity;

		// Token: 0x0400685F RID: 26719
		[global::Cpp2ILInjected.Token(Token = "0x4007D85")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		protected bool _isLoaded;

		// Token: 0x04006860 RID: 26720
		[global::Cpp2ILInjected.Token(Token = "0x4007D86")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected EffectPriority _priority;
	}
}
