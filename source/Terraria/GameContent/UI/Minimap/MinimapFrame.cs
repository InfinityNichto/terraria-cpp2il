using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.Initializers;

namespace Terraria.GameContent.UI.Minimap
{
	// Token: 0x020006B1 RID: 1713
	[global::Cpp2ILInjected.Token(Token = "0x2000A8A")]
	public class MinimapFrame : IConfigKeyHolder
	{
		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06004377 RID: 17271 RVA: 0x0002E112 File Offset: 0x0002C312
		// (set) Token: 0x06004378 RID: 17272 RVA: 0x0002E115 File Offset: 0x0002C315
		[global::Cpp2ILInjected.Token(Token = "0x170008B4")]
		public string ConfigKey
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004FAC")]
			[global::Cpp2ILInjected.Address(RVA = "0x90069C", Offset = "0x90069C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004FAD")]
			[global::Cpp2ILInjected.Address(RVA = "0x9006A4", Offset = "0x9006A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06004379 RID: 17273 RVA: 0x0002E118 File Offset: 0x0002C318
		// (set) Token: 0x0600437A RID: 17274 RVA: 0x0002E11B File Offset: 0x0002C31B
		[global::Cpp2ILInjected.Token(Token = "0x170008B5")]
		public string NameKey
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004FAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x9006AC", Offset = "0x9006AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004FAF")]
			[global::Cpp2ILInjected.Address(RVA = "0x9006B4", Offset = "0x9006B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x0600437B RID: 17275 RVA: 0x0002E11E File Offset: 0x0002C31E
		// (set) Token: 0x0600437C RID: 17276 RVA: 0x0002E121 File Offset: 0x0002C321
		[global::Cpp2ILInjected.Token(Token = "0x170008B6")]
		public Vector2 MinimapPosition
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004FB0")]
			[global::Cpp2ILInjected.Address(RVA = "0x9006BC", Offset = "0x9006BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004FB1")]
			[global::Cpp2ILInjected.Address(RVA = "0x9006C4", Offset = "0x9006C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x0600437D RID: 17277 RVA: 0x0002E124 File Offset: 0x0002C324
		// (set) Token: 0x0600437E RID: 17278 RVA: 0x0002E127 File Offset: 0x0002C327
		[global::Cpp2ILInjected.Token(Token = "0x170008B7")]
		private Vector2 FramePosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004FB2")]
			[global::Cpp2ILInjected.Address(RVA = "0x9006CC", Offset = "0x9006CC", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinimapFrame), Member = "DrawForeground", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinimapFrame), Member = "GetButtonUnderMouse", ReturnType = typeof(MinimapFrame.Button))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6004FB3")]
			[global::Cpp2ILInjected.Address(RVA = "0x900748", Offset = "0x900748", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600437F RID: 17279 RVA: 0x0002E12A File Offset: 0x0002C32A
		[global::Cpp2ILInjected.Token(Token = "0x6004FB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x9007D0", Offset = "0x9007D0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadMinimap", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(AssetRequestMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MinimapFrame(Asset<Texture2D> frameTexture, Vector2 frameOffset)
		{
			throw null;
		}

		// Token: 0x06004380 RID: 17280 RVA: 0x0002E12D File Offset: 0x0002C32D
		[global::Cpp2ILInjected.Token(Token = "0x6004FB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x90080C", Offset = "0x90080C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadMinimap", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(AssetRequestMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinimapFrameTemplate), Member = "CreateInstance", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(MinimapFrame))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void SetResetButton(Asset<Texture2D> hoverTexture, Vector2 position)
		{
			throw null;
		}

		// Token: 0x06004381 RID: 17281 RVA: 0x0002E130 File Offset: 0x0002C330
		[global::Cpp2ILInjected.Token(Token = "0x6004FB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x900914", Offset = "0x900914", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinimapFrame), Member = "<SetResetButton>b__24_0", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapMinimapScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ResetZoom()
		{
			throw null;
		}

		// Token: 0x06004382 RID: 17282 RVA: 0x0002E133 File Offset: 0x0002C333
		[global::Cpp2ILInjected.Token(Token = "0x6004FB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x90096C", Offset = "0x90096C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadMinimap", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(AssetRequestMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinimapFrameTemplate), Member = "CreateInstance", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(MinimapFrame))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void SetZoomInButton(Asset<Texture2D> hoverTexture, Vector2 position)
		{
			throw null;
		}

		// Token: 0x06004383 RID: 17283 RVA: 0x0002E136 File Offset: 0x0002C336
		[global::Cpp2ILInjected.Token(Token = "0x6004FB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x900A34", Offset = "0x900A34", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinimapFrame), Member = "<SetZoomInButton>b__26_0", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapMinimapScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapMinimapScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ZoomInButton()
		{
			throw null;
		}

		// Token: 0x06004384 RID: 17284 RVA: 0x0002E139 File Offset: 0x0002C339
		[global::Cpp2ILInjected.Token(Token = "0x6004FB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x900A98", Offset = "0x900A98", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadMinimap", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(AssetRequestMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinimapFrameTemplate), Member = "CreateInstance", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(MinimapFrame))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void SetZoomOutButton(Asset<Texture2D> hoverTexture, Vector2 position)
		{
			throw null;
		}

		// Token: 0x06004385 RID: 17285 RVA: 0x0002E13C File Offset: 0x0002C33C
		[global::Cpp2ILInjected.Token(Token = "0x6004FBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x900B60", Offset = "0x900B60", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinimapFrame), Member = "<SetZoomOutButton>b__28_0", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapMinimapScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapMinimapScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ZoomOutButton()
		{
			throw null;
		}

		// Token: 0x06004386 RID: 17286 RVA: 0x0002E13F File Offset: 0x0002C33F
		[global::Cpp2ILInjected.Token(Token = "0x6004FBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x900BC4", Offset = "0x900BC4", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinimapFrameManager), Member = "DrawTo", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinimapFrame), Member = "GetButtonUnderMouse", ReturnType = typeof(MinimapFrame.Button))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_IgnoreMouseInterface", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x06004387 RID: 17287 RVA: 0x0002E142 File Offset: 0x0002C342
		[global::Cpp2ILInjected.Token(Token = "0x6004FBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x900E5C", Offset = "0x900E5C", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinimapFrameManager), Member = "DrawTo", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapMinimapAlpha", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void DrawBackground(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06004388 RID: 17288 RVA: 0x0002E145 File Offset: 0x0002C345
		[global::Cpp2ILInjected.Token(Token = "0x6004FBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x900FAC", Offset = "0x900FAC", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinimapFrameManager), Member = "DrawForeground", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinimapFrame), Member = "get_FramePosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinimapFrame.Button), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void DrawForeground(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x0002E148 File Offset: 0x0002C348
		[global::Cpp2ILInjected.Token(Token = "0x6004FBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x900D20", Offset = "0x900D20", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinimapFrame), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinimapFrame), Member = "get_FramePosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinimapFrame.Button), Member = "IsTouchingPoint", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private MinimapFrame.Button GetButtonUnderMouse()
		{
			throw null;
		}

		// Token: 0x0600438A RID: 17290 RVA: 0x0002E14B File Offset: 0x0002C34B
		[Conditional("DEBUG")]
		[global::Cpp2ILInjected.Token(Token = "0x6004FBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x901340", Offset = "0x901340", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void ValidateState()
		{
			throw null;
		}

		// Token: 0x0600438B RID: 17291 RVA: 0x0002E14E File Offset: 0x0002C34E
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6004FC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x901344", Offset = "0x901344", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinimapFrame), Member = "ResetZoom", ReturnType = typeof(void))]
		private void <SetResetButton>b__24_0()
		{
			throw null;
		}

		// Token: 0x0600438C RID: 17292 RVA: 0x0002E151 File Offset: 0x0002C351
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6004FC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x901348", Offset = "0x901348", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinimapFrame), Member = "ZoomInButton", ReturnType = typeof(void))]
		private void <SetZoomInButton>b__26_0()
		{
			throw null;
		}

		// Token: 0x0600438D RID: 17293 RVA: 0x0002E154 File Offset: 0x0002C354
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6004FC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x90134C", Offset = "0x90134C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinimapFrame), Member = "ZoomOutButton", ReturnType = typeof(void))]
		private void <SetZoomOutButton>b__28_0()
		{
			throw null;
		}

		// Token: 0x04006F74 RID: 28532
		[global::Cpp2ILInjected.Token(Token = "0x4008898")]
		private const float DEFAULT_ZOOM = 1.05f;

		// Token: 0x04006F75 RID: 28533
		[global::Cpp2ILInjected.Token(Token = "0x4008899")]
		private const float ZOOM_OUT_MULTIPLIER = 0.975f;

		// Token: 0x04006F76 RID: 28534
		[global::Cpp2ILInjected.Token(Token = "0x400889A")]
		private const float ZOOM_IN_MULTIPLIER = 1.025f;

		// Token: 0x04006F77 RID: 28535
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400889B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <ConfigKey>k__BackingField;

		// Token: 0x04006F78 RID: 28536
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400889C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string <NameKey>k__BackingField;

		// Token: 0x04006F79 RID: 28537
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400889D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Vector2 <MinimapPosition>k__BackingField;

		// Token: 0x04006F7A RID: 28538
		[global::Cpp2ILInjected.Token(Token = "0x400889E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly Asset<Texture2D> _frameTexture;

		// Token: 0x04006F7B RID: 28539
		[global::Cpp2ILInjected.Token(Token = "0x400889F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly Vector2 _frameOffset;

		// Token: 0x04006F7C RID: 28540
		[global::Cpp2ILInjected.Token(Token = "0x40088A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private MinimapFrame.Button _resetButton;

		// Token: 0x04006F7D RID: 28541
		[global::Cpp2ILInjected.Token(Token = "0x40088A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private MinimapFrame.Button _zoomInButton;

		// Token: 0x04006F7E RID: 28542
		[global::Cpp2ILInjected.Token(Token = "0x40088A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private MinimapFrame.Button _zoomOutButton;

		// Token: 0x02000AB5 RID: 2741
		[global::Cpp2ILInjected.Token(Token = "0x2000A8B")]
		private class Button
		{
			// Token: 0x17000908 RID: 2312
			// (get) Token: 0x06005261 RID: 21089 RVA: 0x00030875 File Offset: 0x0002EA75
			[global::Cpp2ILInjected.Token(Token = "0x170008B8")]
			private Vector2 Size
			{
				[global::Cpp2ILInjected.Token(Token = "0x6004FC3")]
				[global::Cpp2ILInjected.Address(RVA = "0x901350", Offset = "0x901350", Length = "0x98")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinimapFrame.Button), Member = "IsTouchingPoint", MemberParameters = new object[]
				{
					typeof(Vector2),
					typeof(Vector2)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(float),
					typeof(float)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06005262 RID: 21090 RVA: 0x00030878 File Offset: 0x0002EA78
			[global::Cpp2ILInjected.Token(Token = "0x6004FC4")]
			[global::Cpp2ILInjected.Address(RVA = "0x9008D4", Offset = "0x9008D4", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Button(Asset<Texture2D> hoverTexture, Vector2 position, Action mouseDownCallback)
			{
				throw null;
			}

			// Token: 0x06005263 RID: 21091 RVA: 0x0003087B File Offset: 0x0002EA7B
			[global::Cpp2ILInjected.Token(Token = "0x6004FC5")]
			[global::Cpp2ILInjected.Address(RVA = "0x900E48", Offset = "0x900E48", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Click()
			{
				throw null;
			}

			// Token: 0x06005264 RID: 21092 RVA: 0x0003087E File Offset: 0x0002EA7E
			[global::Cpp2ILInjected.Token(Token = "0x6004FC6")]
			[global::Cpp2ILInjected.Address(RVA = "0x90109C", Offset = "0x90109C", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinimapFrame), Member = "DrawForeground", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(Vector2),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public void Draw(SpriteBatch spriteBatch, Vector2 parentPosition)
			{
				throw null;
			}

			// Token: 0x06005265 RID: 21093 RVA: 0x00030881 File Offset: 0x0002EA81
			[global::Cpp2ILInjected.Token(Token = "0x6004FC7")]
			[global::Cpp2ILInjected.Address(RVA = "0x9011A0", Offset = "0x9011A0", Length = "0x1A0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinimapFrame), Member = "GetButtonUnderMouse", ReturnType = typeof(MinimapFrame.Button))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinimapFrame.Button), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Max", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public bool IsTouchingPoint(Vector2 testPoint, Vector2 parentPosition)
			{
				throw null;
			}

			// Token: 0x04008F30 RID: 36656
			[global::Cpp2ILInjected.Token(Token = "0x40088A3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public bool IsHighlighted;

			// Token: 0x04008F31 RID: 36657
			[global::Cpp2ILInjected.Token(Token = "0x40088A4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			private readonly Vector2 _position;

			// Token: 0x04008F32 RID: 36658
			[global::Cpp2ILInjected.Token(Token = "0x40088A5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private readonly Asset<Texture2D> _hoverTexture;

			// Token: 0x04008F33 RID: 36659
			[global::Cpp2ILInjected.Token(Token = "0x40088A6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private readonly Action _onMouseDown;
		}
	}
}
