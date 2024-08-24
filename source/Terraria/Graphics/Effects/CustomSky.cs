using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Skies;

namespace Terraria.Graphics.Effects
{
	// Token: 0x02000517 RID: 1303
	[global::Cpp2ILInjected.Token(Token = "0x2000780")]
	public abstract class CustomSky : GameEffect
	{
		// Token: 0x06003840 RID: 14400
		[global::Cpp2ILInjected.Token(Token = "0x6003EDF")]
		public abstract void Update(GameTime gameTime);

		// Token: 0x06003841 RID: 14401
		[global::Cpp2ILInjected.Token(Token = "0x6003EE0")]
		public abstract void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth);

		// Token: 0x06003842 RID: 14402
		[global::Cpp2ILInjected.Token(Token = "0x6003EE1")]
		public abstract bool IsActive();

		// Token: 0x06003843 RID: 14403
		[global::Cpp2ILInjected.Token(Token = "0x6003EE2")]
		public abstract void Reset();

		// Token: 0x06003844 RID: 14404 RVA: 0x0002C0C3 File Offset: 0x0002A2C3
		[global::Cpp2ILInjected.Token(Token = "0x6003EE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x740B0C", Offset = "0x740B0C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual Color OnTileColor(Color inColor)
		{
			throw null;
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x0002C0C6 File Offset: 0x0002A2C6
		[global::Cpp2ILInjected.Token(Token = "0x6003EE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x740B14", Offset = "0x740B14", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual float GetCloudAlpha()
		{
			throw null;
		}

		// Token: 0x06003846 RID: 14406 RVA: 0x0002C0C9 File Offset: 0x0002A2C9
		[global::Cpp2ILInjected.Token(Token = "0x6003EE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x740B1C", Offset = "0x740B1C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool IsVisible()
		{
			throw null;
		}

		// Token: 0x06003847 RID: 14407 RVA: 0x0002C0CC File Offset: 0x0002A2CC
		[global::Cpp2ILInjected.Token(Token = "0x6003EE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x740B24", Offset = "0x740B24", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PartySky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlizzardSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanternSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MartianSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonLordSky), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NebulaSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SandstormSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlimeSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SolarSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StardustSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VortexSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected CustomSky()
		{
			throw null;
		}
	}
}
