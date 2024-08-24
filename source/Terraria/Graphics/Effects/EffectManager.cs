using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Ambience;
using Terraria.GameContent.Events;
using Terraria.GameContent.Skies;
using Terraria.Graphics.Light;
using Terraria.Initializers;

namespace Terraria.Graphics.Effects
{
	// Token: 0x02000518 RID: 1304
	[global::Cpp2ILInjected.Token(Token = "0x2000781")]
	public abstract class EffectManager<T> where T : GameEffect
	{
		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06003848 RID: 14408 RVA: 0x0002C0CF File Offset: 0x0002A2CF
		[global::Cpp2ILInjected.Token(Token = "0x170007A3")]
		public bool IsLoaded
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003EE7")]
			[global::Cpp2ILInjected.Address(RVA = "0x16224BC", Offset = "0x16224BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000709 RID: 1801
		[global::Cpp2ILInjected.Token(Token = "0x170007A4")]
		public T this[string key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003EE8")]
			[global::Cpp2ILInjected.Address(RVA = "0x16224C4", Offset = "0x16224C4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 103)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003EE9")]
			[global::Cpp2ILInjected.Address(RVA = "0x16224FC", Offset = "0x16224FC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "Load", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "LoadSkies", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 46)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x0002C0D8 File Offset: 0x0002A2D8
		[global::Cpp2ILInjected.Token(Token = "0x6003EEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1622510", Offset = "0x1622510", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameEffect), Member = "Load", ReturnType = typeof(void))]
		public void Bind(string name, T effect)
		{
			throw null;
		}

		// Token: 0x0600384C RID: 14412 RVA: 0x0002C0DB File Offset: 0x0002A2DB
		[global::Cpp2ILInjected.Token(Token = "0x6003EEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1622560", Offset = "0x1622560", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "LoadSkies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameEffect), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Load()
		{
			throw null;
		}

		// Token: 0x0600384D RID: 14413 RVA: 0x0002C0DE File Offset: 0x0002A2DE
		[global::Cpp2ILInjected.Token(Token = "0x6003EEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1622680", Offset = "0x1622680", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMainMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TryPlayingCreditsRoll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(NPC),
			typeof(bool),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(NPC),
			typeof(bool),
			typeof(Vector2),
			typeof(LightMap),
			typeof(ref Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSurfaceBG", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "CheckMonoliths", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "StartSlimeRain", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateBiomes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ManageSpecialBiomeVisuals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(SkyEntityType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BirthdayParty), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanternNight), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Sandstorm), Member = "HandleEffectAndSky", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MissingEffectException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public T Activate(string name, Vector2 position = default(Vector2), params object[] args)
		{
			throw null;
		}

		// Token: 0x0600384E RID: 14414 RVA: 0x0002C0E1 File Offset: 0x0002A2E1
		[global::Cpp2ILInjected.Token(Token = "0x6003EED")]
		[global::Cpp2ILInjected.Address(RVA = "0x16228A8", Offset = "0x16228A8", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSurfaceBG", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "CheckMonoliths", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "StopSlimeRain", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateBiomes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ManageSpecialBiomeVisuals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollSky), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BirthdayParty), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanternNight), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Sandstorm), Member = "HandleEffectAndSky", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MissingEffectException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public void Deactivate(string name, params object[] args)
		{
			throw null;
		}

		// Token: 0x0600384F RID: 14415 RVA: 0x0002C0E4 File Offset: 0x0002A2E4
		[global::Cpp2ILInjected.Token(Token = "0x6003EEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1622AA8", Offset = "0x1622AA8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnActivate(T effect, Vector2 position)
		{
			throw null;
		}

		// Token: 0x06003850 RID: 14416 RVA: 0x0002C0E7 File Offset: 0x0002A2E7
		[global::Cpp2ILInjected.Token(Token = "0x6003EEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1622AAC", Offset = "0x1622AAC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnDeactivate(T effect)
		{
			throw null;
		}

		// Token: 0x06003851 RID: 14417 RVA: 0x0002C0EA File Offset: 0x0002A2EA
		[global::Cpp2ILInjected.Token(Token = "0x6003EF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1622AB0", Offset = "0x1622AB0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FilterManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OverlayManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SkyManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected EffectManager()
		{
			throw null;
		}

		// Token: 0x0400684C RID: 26700
		[global::Cpp2ILInjected.Token(Token = "0x4007D72")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected bool _isLoaded;

		// Token: 0x0400684D RID: 26701
		[global::Cpp2ILInjected.Token(Token = "0x4007D73")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected Dictionary<string, T> _effects;
	}
}
