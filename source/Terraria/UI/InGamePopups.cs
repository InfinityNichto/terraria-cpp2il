using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Achievements;
using Terraria.GameInput;
using Terraria.Social.Base;
using Terraria.Utilities;

namespace Terraria.UI
{
	// Token: 0x020004C3 RID: 1219
	[global::Cpp2ILInjected.Token(Token = "0x20006E2")]
	public class InGamePopups
	{
		// Token: 0x060035A2 RID: 13730 RVA: 0x0002B95B File Offset: 0x00029B5B
		[global::Cpp2ILInjected.Token(Token = "0x6003B25")]
		[global::Cpp2ILInjected.Address(RVA = "0x147B464", Offset = "0x147B464", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public InGamePopups()
		{
			throw null;
		}

		// Token: 0x02000954 RID: 2388
		[global::Cpp2ILInjected.Token(Token = "0x20006E3")]
		public class AchievementUnlockedPopup : IInGameNotification
		{
			// Token: 0x170008B2 RID: 2226
			// (get) Token: 0x06004CF8 RID: 19704 RVA: 0x0002F9B1 File Offset: 0x0002DBB1
			// (set) Token: 0x06004CF9 RID: 19705 RVA: 0x0002F9B4 File Offset: 0x0002DBB4
			[global::Cpp2ILInjected.Token(Token = "0x17000759")]
			public bool ShouldBeRemoved
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6003B26")]
				[global::Cpp2ILInjected.Address(RVA = "0x147B46C", Offset = "0x147B46C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6003B27")]
				[global::Cpp2ILInjected.Address(RVA = "0x147B474", Offset = "0x147B474", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x170008B3 RID: 2227
			// (get) Token: 0x06004CFA RID: 19706 RVA: 0x0002F9B7 File Offset: 0x0002DBB7
			// (set) Token: 0x06004CFB RID: 19707 RVA: 0x0002F9BA File Offset: 0x0002DBBA
			[global::Cpp2ILInjected.Token(Token = "0x1700075A")]
			public object CreationObject
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6003B28")]
				[global::Cpp2ILInjected.Address(RVA = "0x147B480", Offset = "0x147B480", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6003B29")]
				[global::Cpp2ILInjected.Address(RVA = "0x147B488", Offset = "0x147B488", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x06004CFC RID: 19708 RVA: 0x0002F9BD File Offset: 0x0002DBBD
			[global::Cpp2ILInjected.Token(Token = "0x6003B2A")]
			[global::Cpp2ILInjected.Address(RVA = "0x147AED8", Offset = "0x147AED8", Length = "0x260")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGameNotificationsTracker), Member = "AddCompleted", MemberParameters = new object[] { typeof(Achievement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Achievements", ReturnType = typeof(AchievementManager))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "GetIconIndex", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public AchievementUnlockedPopup(Achievement achievement)
			{
				throw null;
			}

			// Token: 0x06004CFD RID: 19709 RVA: 0x0002F9C0 File Offset: 0x0002DBC0
			[global::Cpp2ILInjected.Token(Token = "0x6003B2B")]
			[global::Cpp2ILInjected.Address(RVA = "0x147B490", Offset = "0x147B490", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Update()
			{
				throw null;
			}

			// Token: 0x170008B4 RID: 2228
			// (get) Token: 0x06004CFE RID: 19710 RVA: 0x0002F9C3 File Offset: 0x0002DBC3
			[global::Cpp2ILInjected.Token(Token = "0x1700075B")]
			private float Scale
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B2C")]
				[global::Cpp2ILInjected.Address(RVA = "0x147B4A4", Offset = "0x147B4A4", Length = "0xB0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.AchievementUnlockedPopup), Member = "get_Opacity", ReturnType = typeof(float))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.AchievementUnlockedPopup), Member = "PushAnchor", MemberParameters = new object[] { typeof(ref Vector2) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.AchievementUnlockedPopup), Member = "DrawInGame", MemberParameters = new object[]
				{
					typeof(SpriteBatch),
					typeof(Vector2)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
				{
					typeof(float),
					typeof(float),
					typeof(float)
				}, ReturnType = typeof(float))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170008B5 RID: 2229
			// (get) Token: 0x06004CFF RID: 19711 RVA: 0x0002F9C6 File Offset: 0x0002DBC6
			[global::Cpp2ILInjected.Token(Token = "0x1700075C")]
			private float Opacity
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B2D")]
				[global::Cpp2ILInjected.Address(RVA = "0x147B554", Offset = "0x147B554", Length = "0x2C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InGamePopups.AchievementUnlockedPopup), Member = "get_Scale", ReturnType = typeof(float))]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004D00 RID: 19712 RVA: 0x0002F9C9 File Offset: 0x0002DBC9
			[global::Cpp2ILInjected.Token(Token = "0x6003B2E")]
			[global::Cpp2ILInjected.Address(RVA = "0x147B580", Offset = "0x147B580", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InGamePopups.AchievementUnlockedPopup), Member = "get_Scale", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void PushAnchor(ref Vector2 anchorPosition)
			{
				throw null;
			}

			// Token: 0x06004D01 RID: 19713 RVA: 0x0002F9CC File Offset: 0x0002DBCC
			[global::Cpp2ILInjected.Token(Token = "0x6003B2F")]
			[global::Cpp2ILInjected.Address(RVA = "0x147B624", Offset = "0x147B624", Length = "0x6F8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InGamePopups.AchievementUnlockedPopup), Member = "get_Scale", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CenteredRectangle", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterInputRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawInvBG", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(Rectangle),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Right", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Left", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(Vector2),
				typeof(Rectangle?),
				typeof(Color),
				typeof(float),
				typeof(Vector2),
				typeof(float),
				typeof(SpriteEffects),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawBorderString", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(string),
				typeof(Vector2),
				typeof(Color),
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(int)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "DrawPickingRegion", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IngameFancyUI), Member = "OpenAchievementsAndGoto", MemberParameters = new object[] { typeof(Achievement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
			public void DrawInGame(SpriteBatch sb, Vector2 bottomAnchorPosition)
			{
				throw null;
			}

			// Token: 0x06004D02 RID: 19714 RVA: 0x0002F9CF File Offset: 0x0002DBCF
			[global::Cpp2ILInjected.Token(Token = "0x6003B30")]
			[global::Cpp2ILInjected.Address(RVA = "0x147BD1C", Offset = "0x147BD1C", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_IgnoreMouseInterface", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IngameFancyUI), Member = "OpenAchievementsAndGoto", MemberParameters = new object[] { typeof(Achievement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			private void OnMouseOver()
			{
				throw null;
			}

			// Token: 0x06004D03 RID: 19715 RVA: 0x0002F9D2 File Offset: 0x0002DBD2
			[global::Cpp2ILInjected.Token(Token = "0x6003B31")]
			[global::Cpp2ILInjected.Address(RVA = "0x147BE18", Offset = "0x147BE18", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawInvBG", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(Rectangle),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public void DrawInNotificationsArea(SpriteBatch spriteBatch, Rectangle area, ref int gamepadPointLocalIndexTouse)
			{
				throw null;
			}

			// Token: 0x04008B41 RID: 35649
			[global::Cpp2ILInjected.Token(Token = "0x4007AF4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private Achievement _theAchievement;

			// Token: 0x04008B42 RID: 35650
			[global::Cpp2ILInjected.Token(Token = "0x4007AF5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private Asset<Texture2D> _achievementTexture;

			// Token: 0x04008B43 RID: 35651
			[global::Cpp2ILInjected.Token(Token = "0x4007AF6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private Asset<Texture2D> _achievementBorderTexture;

			// Token: 0x04008B44 RID: 35652
			[global::Cpp2ILInjected.Token(Token = "0x4007AF7")]
			private const int _iconSize = 64;

			// Token: 0x04008B45 RID: 35653
			[global::Cpp2ILInjected.Token(Token = "0x4007AF8")]
			private const int _iconSizeWithSpace = 66;

			// Token: 0x04008B46 RID: 35654
			[global::Cpp2ILInjected.Token(Token = "0x4007AF9")]
			private const int _iconsPerRow = 8;

			// Token: 0x04008B47 RID: 35655
			[global::Cpp2ILInjected.Token(Token = "0x4007AFA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private int _iconIndex;

			// Token: 0x04008B48 RID: 35656
			[global::Cpp2ILInjected.Token(Token = "0x4007AFB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			private Rectangle _achievementIconFrame;

			// Token: 0x04008B49 RID: 35657
			[global::Cpp2ILInjected.Token(Token = "0x4007AFC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private string _title;

			// Token: 0x04008B4A RID: 35658
			[global::Cpp2ILInjected.Token(Token = "0x4007AFD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private float _height;

			// Token: 0x04008B4B RID: 35659
			[global::Cpp2ILInjected.Token(Token = "0x4007AFE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
			private int _ingameDisplayTimeLeft;

			// Token: 0x04008B4C RID: 35660
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4007AFF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private bool <ShouldBeRemoved>k__BackingField;

			// Token: 0x04008B4D RID: 35661
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4007B00")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private object <CreationObject>k__BackingField;
		}

		// Token: 0x02000955 RID: 2389
		[global::Cpp2ILInjected.Token(Token = "0x20006E4")]
		public class PlayerWantsToJoinGamePopup : IInGameNotification
		{
			// Token: 0x170008B6 RID: 2230
			// (get) Token: 0x06004D04 RID: 19716 RVA: 0x0002F9D5 File Offset: 0x0002DBD5
			[global::Cpp2ILInjected.Token(Token = "0x1700075D")]
			private float Scale
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B32")]
				[global::Cpp2ILInjected.Address(RVA = "0x147BEC0", Offset = "0x147BEC0", Length = "0x5C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "get_Opacity", ReturnType = typeof(float))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "DrawInGame", MemberParameters = new object[]
				{
					typeof(SpriteBatch),
					typeof(Vector2)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "PushAnchor", MemberParameters = new object[] { typeof(ref Vector2) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
				{
					typeof(float),
					typeof(float),
					typeof(float)
				}, ReturnType = typeof(float))]
				get
				{
					throw null;
				}
			}

			// Token: 0x170008B7 RID: 2231
			// (get) Token: 0x06004D05 RID: 19717 RVA: 0x0002F9D8 File Offset: 0x0002DBD8
			[global::Cpp2ILInjected.Token(Token = "0x1700075E")]
			private float Opacity
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B33")]
				[global::Cpp2ILInjected.Address(RVA = "0x147BF1C", Offset = "0x147BF1C", Length = "0x2C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "get_Scale", ReturnType = typeof(float))]
				get
				{
					throw null;
				}
			}

			// Token: 0x170008B8 RID: 2232
			// (get) Token: 0x06004D06 RID: 19718 RVA: 0x0002F9DB File Offset: 0x0002DBDB
			// (set) Token: 0x06004D07 RID: 19719 RVA: 0x0002F9DE File Offset: 0x0002DBDE
			[global::Cpp2ILInjected.Token(Token = "0x1700075F")]
			public object CreationObject
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6003B34")]
				[global::Cpp2ILInjected.Address(RVA = "0x147BF48", Offset = "0x147BF48", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6003B35")]
				[global::Cpp2ILInjected.Address(RVA = "0x147BF50", Offset = "0x147BF50", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x06004D08 RID: 19720 RVA: 0x0002F9E1 File Offset: 0x0002DBE1
			[global::Cpp2ILInjected.Token(Token = "0x6003B36")]
			[global::Cpp2ILInjected.Address(RVA = "0x147BF58", Offset = "0x147BF58", Length = "0x12C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGameNotificationsTracker), Member = "AddJoinRequest", MemberParameters = new object[] { typeof(UserJoinToServerRequest) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public PlayerWantsToJoinGamePopup(UserJoinToServerRequest request)
			{
				throw null;
			}

			// Token: 0x170008B9 RID: 2233
			// (get) Token: 0x06004D09 RID: 19721 RVA: 0x0002F9E4 File Offset: 0x0002DBE4
			[global::Cpp2ILInjected.Token(Token = "0x17000760")]
			public bool ShouldBeRemoved
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B37")]
				[global::Cpp2ILInjected.Address(RVA = "0x147C084", Offset = "0x147C084", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004D0A RID: 19722 RVA: 0x0002F9E7 File Offset: 0x0002DBE7
			[global::Cpp2ILInjected.Token(Token = "0x6003B38")]
			[global::Cpp2ILInjected.Address(RVA = "0x147C094", Offset = "0x147C094", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Update()
			{
				throw null;
			}

			// Token: 0x06004D0B RID: 19723 RVA: 0x0002F9EA File Offset: 0x0002DBEA
			[global::Cpp2ILInjected.Token(Token = "0x6003B39")]
			[global::Cpp2ILInjected.Address(RVA = "0x147C0A4", Offset = "0x147C0A4", Length = "0xB48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "get_Scale", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType10<, >), Member = ".ctor", MemberParameters = new object[] { "<DisplayName>j__TPar", "<FullId>j__TPar" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "FormatWith", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CenteredRectangle", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_MouseScreen", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawInvBG", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(Rectangle),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Center", ReturnType = typeof(Point))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(Vector2),
				typeof(Rectangle?),
				typeof(Color),
				typeof(float),
				typeof(Vector2),
				typeof(float),
				typeof(SpriteEffects),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "OnMouseOver", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToVector2", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawBorderString", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(string),
				typeof(Vector2),
				typeof(Color),
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(int)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
			public void DrawInGame(SpriteBatch spriteBatch, Vector2 bottomAnchorPosition)
			{
				throw null;
			}

			// Token: 0x06004D0C RID: 19724 RVA: 0x0002F9ED File Offset: 0x0002DBED
			[global::Cpp2ILInjected.Token(Token = "0x6003B3A")]
			[global::Cpp2ILInjected.Address(RVA = "0x147CBEC", Offset = "0x147CBEC", Length = "0x124")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "DrawInGame", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "DrawInNotificationsArea", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(Rectangle),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_IgnoreMouseInterface", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserJoinToServerRequest), Member = "Reject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserJoinToServerRequest), Member = "Accept", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			private void OnMouseOver(bool reject = false)
			{
				throw null;
			}

			// Token: 0x06004D0D RID: 19725 RVA: 0x0002F9F0 File Offset: 0x0002DBF0
			[global::Cpp2ILInjected.Token(Token = "0x6003B3B")]
			[global::Cpp2ILInjected.Address(RVA = "0x147CD10", Offset = "0x147CD10", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "get_Scale", ReturnType = typeof(float))]
			public void PushAnchor(ref Vector2 positionAnchorBottom)
			{
				throw null;
			}

			// Token: 0x06004D0E RID: 19726 RVA: 0x0002F9F3 File Offset: 0x0002DBF3
			[global::Cpp2ILInjected.Token(Token = "0x6003B3C")]
			[global::Cpp2ILInjected.Address(RVA = "0x147CD58", Offset = "0x147CD58", Length = "0xA20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "TrimTextIfNeeded", MemberParameters = new object[]
			{
				typeof(ref string),
				typeof(SpriteFont),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType10<, >), Member = ".ctor", MemberParameters = new object[] { "<DisplayName>j__TPar", "<FullId>j__TPar" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "FormatWith", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_MouseScreen", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawInvBG", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(Rectangle),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Center", ReturnType = typeof(Point))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CenteredRectangle", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(Vector2),
				typeof(Rectangle?),
				typeof(Color),
				typeof(float),
				typeof(Vector2),
				typeof(float),
				typeof(SpriteEffects),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "OnMouseOver", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawBorderString", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(string),
				typeof(Vector2),
				typeof(Color),
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(int)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
			public void DrawInNotificationsArea(SpriteBatch spriteBatch, Rectangle area, ref int gamepadPointLocalIndexTouse)
			{
				throw null;
			}

			// Token: 0x04008B4E RID: 35662
			[global::Cpp2ILInjected.Token(Token = "0x4007B01")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int _timeLeft;

			// Token: 0x04008B4F RID: 35663
			[global::Cpp2ILInjected.Token(Token = "0x4007B02")]
			private const int _timeLeftMax = 1800;

			// Token: 0x04008B50 RID: 35664
			[global::Cpp2ILInjected.Token(Token = "0x4007B03")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string _displayTextWithoutTime;

			// Token: 0x04008B51 RID: 35665
			[global::Cpp2ILInjected.Token(Token = "0x4007B04")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private UserJoinToServerRequest _request;

			// Token: 0x04008B52 RID: 35666
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4007B05")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private object <CreationObject>k__BackingField;
		}
	}
}
