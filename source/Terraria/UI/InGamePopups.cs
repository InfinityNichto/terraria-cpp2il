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
	[global::Cpp2ILInjected.Token(Token = "0x20006E2")]
	public class InGamePopups
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003B25")]
		[global::Cpp2ILInjected.Address(RVA = "0x147B464", Offset = "0x147B464", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public InGamePopups()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20006E3")]
		public class AchievementUnlockedPopup : IInGameNotification
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6003B2B")]
			[global::Cpp2ILInjected.Address(RVA = "0x147B490", Offset = "0x147B490", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Update()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x4007AF4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private Achievement _theAchievement;

			[global::Cpp2ILInjected.Token(Token = "0x4007AF5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private Asset<Texture2D> _achievementTexture;

			[global::Cpp2ILInjected.Token(Token = "0x4007AF6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private Asset<Texture2D> _achievementBorderTexture;

			[global::Cpp2ILInjected.Token(Token = "0x4007AF7")]
			private const int _iconSize = 64;

			[global::Cpp2ILInjected.Token(Token = "0x4007AF8")]
			private const int _iconSizeWithSpace = 66;

			[global::Cpp2ILInjected.Token(Token = "0x4007AF9")]
			private const int _iconsPerRow = 8;

			[global::Cpp2ILInjected.Token(Token = "0x4007AFA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private int _iconIndex;

			[global::Cpp2ILInjected.Token(Token = "0x4007AFB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			private Rectangle _achievementIconFrame;

			[global::Cpp2ILInjected.Token(Token = "0x4007AFC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private string _title;

			[global::Cpp2ILInjected.Token(Token = "0x4007AFD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private float _height;

			[global::Cpp2ILInjected.Token(Token = "0x4007AFE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
			private int _ingameDisplayTimeLeft;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4007AFF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private bool <ShouldBeRemoved>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4007B00")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private object <CreationObject>k__BackingField;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20006E4")]
		public class PlayerWantsToJoinGamePopup : IInGameNotification
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6003B38")]
			[global::Cpp2ILInjected.Address(RVA = "0x147C094", Offset = "0x147C094", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Update()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x6003B3B")]
			[global::Cpp2ILInjected.Address(RVA = "0x147CD10", Offset = "0x147CD10", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "get_Scale", ReturnType = typeof(float))]
			public void PushAnchor(ref Vector2 positionAnchorBottom)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x4007B01")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int _timeLeft;

			[global::Cpp2ILInjected.Token(Token = "0x4007B02")]
			private const int _timeLeftMax = 1800;

			[global::Cpp2ILInjected.Token(Token = "0x4007B03")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string _displayTextWithoutTime;

			[global::Cpp2ILInjected.Token(Token = "0x4007B04")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private UserJoinToServerRequest _request;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4007B05")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private object <CreationObject>k__BackingField;
		}
	}
}
