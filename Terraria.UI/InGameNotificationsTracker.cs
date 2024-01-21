using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Achievements;
using Terraria.Social.Base;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004C4")]
public class InGameNotificationsTracker
{
	[Cpp2IlInjected.Token(Token = "0x4006692")]
	private static List<IInGameNotification> _notifications;

	[Cpp2IlInjected.Token(Token = "0x60035CD")]
	[Cpp2IlInjected.Address(RVA = "0x13A4B88", Offset = "0x13A4B88", VA = "0x13A4B88")]
	public static void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035CE")]
	[Cpp2IlInjected.Address(RVA = "0x13A4D10", Offset = "0x13A4D10", VA = "0x13A4D10")]
	private static void JoinRequests_OnRequestAdded(UserJoinToServerRequest request)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035CF")]
	[Cpp2IlInjected.Address(RVA = "0x13A4E80", Offset = "0x13A4E80", VA = "0x13A4E80")]
	private static void JoinRequests_OnRequestRemoved(UserJoinToServerRequest request)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035D0")]
	[Cpp2IlInjected.Address(RVA = "0x13A5034", Offset = "0x13A5034", VA = "0x13A5034")]
	public static void DrawInGame(SpriteBatch sb)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035D1")]
	[Cpp2IlInjected.Address(RVA = "0x13A5378", Offset = "0x13A5378", VA = "0x13A5378")]
	public static void DrawInIngameOptions(SpriteBatch spriteBatch, Rectangle area, ref int gamepadPointIdLocalIndexToUse)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035D2")]
	[Cpp2IlInjected.Address(RVA = "0x13A55C4", Offset = "0x13A55C4", VA = "0x13A55C4")]
	public static void AddCompleted(Achievement achievement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035D3")]
	[Cpp2IlInjected.Address(RVA = "0x13A4D88", Offset = "0x13A4D88", VA = "0x13A4D88")]
	public static void AddJoinRequest(UserJoinToServerRequest request)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035D4")]
	[Cpp2IlInjected.Address(RVA = "0x13A5A90", Offset = "0x13A5A90", VA = "0x13A5A90")]
	public static void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035D5")]
	[Cpp2IlInjected.Address(RVA = "0x13A5B1C", Offset = "0x13A5B1C", VA = "0x13A5B1C")]
	public static void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035D6")]
	[Cpp2IlInjected.Address(RVA = "0x13A5D7C", Offset = "0x13A5D7C", VA = "0x13A5D7C")]
	public InGameNotificationsTracker()
	{
	}
}
