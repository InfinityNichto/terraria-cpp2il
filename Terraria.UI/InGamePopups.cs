using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Achievements;
using Terraria.Social.Base;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004C6")]
public class InGamePopups
{
	[Cpp2IlInjected.Token(Token = "0x200094B")]
	public class AchievementUnlockedPopup : IInGameNotification
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008B2E")]
		private Achievement _theAchievement;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008B2F")]
		private Asset<Texture2D> _achievementTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008B30")]
		private Asset<Texture2D> _achievementBorderTexture;

		[Cpp2IlInjected.Token(Token = "0x4008B31")]
		private const int _iconSize = 64;

		[Cpp2IlInjected.Token(Token = "0x4008B32")]
		private const int _iconSizeWithSpace = 66;

		[Cpp2IlInjected.Token(Token = "0x4008B33")]
		private const int _iconsPerRow = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008B34")]
		private int _iconIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008B35")]
		private Rectangle _achievementIconFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4008B36")]
		private string _title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4008B37")]
		private float _height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4008B38")]
		private int _ingameDisplayTimeLeft;

		[Cpp2IlInjected.Token(Token = "0x170008B4")]
		public bool ShouldBeRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x6004D2F")]
			[Cpp2IlInjected.Address(RVA = "0x13A5E14", Offset = "0x13A5E14", VA = "0x13A5E14", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6004D30")]
			[Cpp2IlInjected.Address(RVA = "0x13A5E1C", Offset = "0x13A5E1C", VA = "0x13A5E1C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008B5")]
		public object CreationObject
		{
			[Cpp2IlInjected.Token(Token = "0x6004D31")]
			[Cpp2IlInjected.Address(RVA = "0x13A5E24", Offset = "0x13A5E24", VA = "0x13A5E24", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6004D32")]
			[Cpp2IlInjected.Address(RVA = "0x13A5E2C", Offset = "0x13A5E2C", VA = "0x13A5E2C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008B6")]
		private float Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6004D35")]
			[Cpp2IlInjected.Address(RVA = "0x13A5E48", Offset = "0x13A5E48", VA = "0x13A5E48")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008B7")]
		private float Opacity
		{
			[Cpp2IlInjected.Token(Token = "0x6004D36")]
			[Cpp2IlInjected.Address(RVA = "0x13A5F14", Offset = "0x13A5F14", VA = "0x13A5F14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D33")]
		[Cpp2IlInjected.Address(RVA = "0x13A56BC", Offset = "0x13A56BC", VA = "0x13A56BC")]
		public AchievementUnlockedPopup(Achievement achievement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D34")]
		[Cpp2IlInjected.Address(RVA = "0x13A5E34", Offset = "0x13A5E34", VA = "0x13A5E34", Slot = "6")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D37")]
		[Cpp2IlInjected.Address(RVA = "0x13A5F50", Offset = "0x13A5F50", VA = "0x13A5F50", Slot = "8")]
		public void PushAnchor(ref Vector2 anchorPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D38")]
		[Cpp2IlInjected.Address(RVA = "0x13A6004", Offset = "0x13A6004", VA = "0x13A6004", Slot = "7")]
		public void DrawInGame(SpriteBatch sb, Vector2 bottomAnchorPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D39")]
		[Cpp2IlInjected.Address(RVA = "0x13A69B4", Offset = "0x13A69B4", VA = "0x13A69B4")]
		private void OnMouseOver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D3A")]
		[Cpp2IlInjected.Address(RVA = "0x13A6B08", Offset = "0x13A6B08", VA = "0x13A6B08", Slot = "9")]
		public void DrawInNotificationsArea(SpriteBatch spriteBatch, Rectangle area, ref int gamepadPointLocalIndexTouse)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200094C")]
	public class PlayerWantsToJoinGamePopup : IInGameNotification
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008B3B")]
		private int _timeLeft;

		[Cpp2IlInjected.Token(Token = "0x4008B3C")]
		private const int _timeLeftMax = 1800;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008B3D")]
		private string _displayTextWithoutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008B3E")]
		private UserJoinToServerRequest _request;

		[Cpp2IlInjected.Token(Token = "0x170008B8")]
		private float Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6004D3B")]
			[Cpp2IlInjected.Address(RVA = "0x13A6BF0", Offset = "0x13A6BF0", VA = "0x13A6BF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008B9")]
		private float Opacity
		{
			[Cpp2IlInjected.Token(Token = "0x6004D3C")]
			[Cpp2IlInjected.Address(RVA = "0x13A6C60", Offset = "0x13A6C60", VA = "0x13A6C60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008BA")]
		public object CreationObject
		{
			[Cpp2IlInjected.Token(Token = "0x6004D3D")]
			[Cpp2IlInjected.Address(RVA = "0x13A6C9C", Offset = "0x13A6C9C", VA = "0x13A6C9C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6004D3E")]
			[Cpp2IlInjected.Address(RVA = "0x13A6CA4", Offset = "0x13A6CA4", VA = "0x13A6CA4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008BB")]
		public bool ShouldBeRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x6004D40")]
			[Cpp2IlInjected.Address(RVA = "0x13A6CAC", Offset = "0x13A6CAC", VA = "0x13A6CAC", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D3F")]
		[Cpp2IlInjected.Address(RVA = "0x13A596C", Offset = "0x13A596C", VA = "0x13A596C")]
		public PlayerWantsToJoinGamePopup(UserJoinToServerRequest request)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D41")]
		[Cpp2IlInjected.Address(RVA = "0x13A6CC0", Offset = "0x13A6CC0", VA = "0x13A6CC0", Slot = "6")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D42")]
		[Cpp2IlInjected.Address(RVA = "0x13A6CD0", Offset = "0x13A6CD0", VA = "0x13A6CD0", Slot = "7")]
		public void DrawInGame(SpriteBatch spriteBatch, Vector2 bottomAnchorPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D43")]
		[Cpp2IlInjected.Address(RVA = "0x13A7AD0", Offset = "0x13A7AD0", VA = "0x13A7AD0")]
		private void OnMouseOver(bool reject = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D44")]
		[Cpp2IlInjected.Address(RVA = "0x13A7C38", Offset = "0x13A7C38", VA = "0x13A7C38", Slot = "8")]
		public void PushAnchor(ref Vector2 positionAnchorBottom)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D45")]
		[Cpp2IlInjected.Address(RVA = "0x13A7C8C", Offset = "0x13A7C8C", VA = "0x13A7C8C", Slot = "9")]
		public void DrawInNotificationsArea(SpriteBatch spriteBatch, Rectangle area, ref int gamepadPointLocalIndexTouse)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60035DE")]
	[Cpp2IlInjected.Address(RVA = "0x13A5E0C", Offset = "0x13A5E0C", VA = "0x13A5E0C")]
	public InGamePopups()
	{
	}
}
