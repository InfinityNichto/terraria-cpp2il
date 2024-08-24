using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Animations;
using Terraria.GameContent.Skies.CreditsRoll;
using Terraria.Graphics.Effects;
using Terraria.Initializers;

namespace Terraria.GameContent.Skies
{
	// Token: 0x0200065B RID: 1627
	[global::Cpp2ILInjected.Token(Token = "0x20009CD")]
	public class CreditsRollSky : CustomSky
	{
		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06003FA2 RID: 16290 RVA: 0x0002D5C3 File Offset: 0x0002B7C3
		[global::Cpp2ILInjected.Token(Token = "0x17000850")]
		public int AmountOfTimeNeededForFullPlay
		{
			[global::Cpp2ILInjected.Token(Token = "0x60049F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x839870", Offset = "0x839870", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x0002D5C6 File Offset: 0x0002B7C6
		[global::Cpp2ILInjected.Token(Token = "0x60049F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x839878", Offset = "0x839878", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "LoadSkies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public CreditsRollSky()
		{
			throw null;
		}

		// Token: 0x06003FA4 RID: 16292 RVA: 0x0002D5C9 File Offset: 0x0002B7C9
		[global::Cpp2ILInjected.Token(Token = "0x60049FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x839A28", Offset = "0x839A28", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToDirectionInt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "CanPlayCreditsRoll", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = "Deactivate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x0002D5CC File Offset: 0x0002B7CC
		[global::Cpp2ILInjected.Token(Token = "0x60049FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x839C50", Offset = "0x839C50", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ScreenSize", ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToVector2", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			throw null;
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x0002D5CF File Offset: 0x0002B7CF
		[global::Cpp2ILInjected.Token(Token = "0x60049FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x839E80", Offset = "0x839E80", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool IsActive()
		{
			throw null;
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x0002D5D2 File Offset: 0x0002B7D2
		[global::Cpp2ILInjected.Token(Token = "0x60049FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x839E88", Offset = "0x839E88", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollSky), Member = "EnsureSegmentsAreMade", ReturnType = typeof(void))]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x06003FA8 RID: 16296 RVA: 0x0002D5D5 File Offset: 0x0002B7D5
		[global::Cpp2ILInjected.Token(Token = "0x60049FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x839EA4", Offset = "0x839EA4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollSky), Member = "EnsureSegmentsAreMade", ReturnType = typeof(void))]
		public override void Activate(Vector2 position, params object[] args)
		{
			throw null;
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x0002D5D8 File Offset: 0x0002B7D8
		[global::Cpp2ILInjected.Token(Token = "0x60049FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x839940", Offset = "0x839940", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollSky), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollSky), Member = "Activate", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer), Member = "FillSegments", MemberParameters = new object[]
		{
			typeof(List<IAnimationSegment>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void EnsureSegmentsAreMade()
		{
			throw null;
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x0002D5DB File Offset: 0x0002B7DB
		[global::Cpp2ILInjected.Token(Token = "0x6004A00")]
		[global::Cpp2ILInjected.Address(RVA = "0x839ED0", Offset = "0x839ED0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Deactivate(params object[] args)
		{
			throw null;
		}

		// Token: 0x04006CD1 RID: 27857
		[global::Cpp2ILInjected.Token(Token = "0x400849B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int _endTime;

		// Token: 0x04006CD2 RID: 27858
		[global::Cpp2ILInjected.Token(Token = "0x400849C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _currentTime;

		// Token: 0x04006CD3 RID: 27859
		[global::Cpp2ILInjected.Token(Token = "0x400849D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private CreditsRollComposer _composer;

		// Token: 0x04006CD4 RID: 27860
		[global::Cpp2ILInjected.Token(Token = "0x400849E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private List<IAnimationSegment> _segmentsInGame;

		// Token: 0x04006CD5 RID: 27861
		[global::Cpp2ILInjected.Token(Token = "0x400849F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private List<IAnimationSegment> _segmentsInMainMenu;

		// Token: 0x04006CD6 RID: 27862
		[global::Cpp2ILInjected.Token(Token = "0x40084A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool _isActive;

		// Token: 0x04006CD7 RID: 27863
		[global::Cpp2ILInjected.Token(Token = "0x40084A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
		private bool _wantsToBeSeen;

		// Token: 0x04006CD8 RID: 27864
		[global::Cpp2ILInjected.Token(Token = "0x40084A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private float _opacity;
	}
}
