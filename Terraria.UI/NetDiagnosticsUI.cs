using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004CF")]
public class NetDiagnosticsUI : INetDiagnosticsUI
{
	[Cpp2IlInjected.Token(Token = "0x2000950")]
	private struct CounterForMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008B6A")]
		public int timesReceived;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008B6B")]
		public int timesSent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008B6C")]
		public int bytesReceived;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008B6D")]
		public int bytesSent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008B6E")]
		public bool exemptFromBadScoreTest;

		[Cpp2IlInjected.Token(Token = "0x6004D4E")]
		[Cpp2IlInjected.Address(RVA = "0x39E620", Offset = "0x39E620", VA = "0x39E620")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D4F")]
		[Cpp2IlInjected.Address(RVA = "0x39E630", Offset = "0x39E630", VA = "0x39E630")]
		public void CountReadMessage(int messageLength)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D50")]
		[Cpp2IlInjected.Address(RVA = "0x39E64C", Offset = "0x39E64C", VA = "0x39E64C")]
		public void CountSentMessage(int messageLength)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40066A8")]
	private CounterForMessage[] _counterByMessageId;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40066A9")]
	private Dictionary<int, CounterForMessage> _counterByModuleId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40066AA")]
	private int _highestFoundReadBytes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40066AB")]
	private int _highestFoundReadCount;

	[Cpp2IlInjected.Token(Token = "0x6003619")]
	[Cpp2IlInjected.Address(RVA = "0x1343FD0", Offset = "0x1343FD0", VA = "0x1343FD0", Slot = "4")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600361A")]
	[Cpp2IlInjected.Address(RVA = "0x1344088", Offset = "0x1344088", VA = "0x1344088", Slot = "6")]
	public void CountReadMessage(int messageId, int messageLength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600361B")]
	[Cpp2IlInjected.Address(RVA = "0x13440CC", Offset = "0x13440CC", VA = "0x13440CC", Slot = "7")]
	public void CountSentMessage(int messageId, int messageLength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600361C")]
	[Cpp2IlInjected.Address(RVA = "0x1344110", Offset = "0x1344110", VA = "0x1344110", Slot = "8")]
	public void CountReadModuleMessage(int moduleMessageId, int messageLength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600361D")]
	[Cpp2IlInjected.Address(RVA = "0x13441E8", Offset = "0x13441E8", VA = "0x13441E8", Slot = "9")]
	public void CountSentModuleMessage(int moduleMessageId, int messageLength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600361E")]
	[Cpp2IlInjected.Address(RVA = "0x13442C0", Offset = "0x13442C0", VA = "0x13442C0", Slot = "5")]
	public void Draw(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600361F")]
	[Cpp2IlInjected.Address(RVA = "0x1344634", Offset = "0x1344634", VA = "0x1344634")]
	private void DrawCounter(SpriteBatch spriteBatch, ref CounterForMessage counter, string title, Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003620")]
	[Cpp2IlInjected.Address(RVA = "0x13449B4", Offset = "0x13449B4", VA = "0x13449B4")]
	private void DrawText(SpriteBatch spriteBatch, string text, Vector2 pos, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003621")]
	[Cpp2IlInjected.Address(RVA = "0x1344B1C", Offset = "0x1344B1C", VA = "0x1344B1C")]
	public NetDiagnosticsUI()
	{
	}
}
